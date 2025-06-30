Imports System.Data.SqlClient
Imports System.IO
Imports System.Linq
Imports System.Text
Imports Microsoft.Office.Interop
Imports SBL.ntPrint
Module Modulo
    Public idEmpresa As String = "1"
    Public csql As SqlConnection
    Public server As String = ""
    Public userdb As String = ""
    Public passdb As String = ""
    Public database As String = ""
    Public sql As String = ""
    Public cerrar As Boolean = True
    Public operador As String = ""
    Public gsOperador As String = ""
    Public username As String = ""
    Public portname As String = "COM1"
    Public EjeXAn1 As Integer = 390
    Public EjeXAn2 As Integer = 10
    Public EjeXAg1 As Integer = 490
    Public EjeXAg2 As Integer = 100
    Public num_movimiento As String
    Public cod_producto As String
    Public id_ubicacion As String
    Public desc_producto As String
    Public id_receta As String
    Public id_Usuario As String
    Private MISocket As New MySocket
    Public opcEliminaExistencia As Boolean = False
    Public gEstado As String = ""
    Public gEcommerce As Integer = 0

    Public Const SQLS As String = "sqlserver"
    Public ServerType As String = SQLS

    Dim srReport As StreamWriter
    Public Function OpenReport(ByVal szNombre As String, Optional ByVal szRuta As String = "") As String
        Dim szFecha As String
        Dim mdoc As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        szFecha = ""
        My.Computer.FileSystem.CreateDirectory(mdoc & "\" & szRuta)
        If szRuta.Length = 0 Then
            mdoc = mdoc & "\reporte" & szNombre & szFecha & ".html"
        Else
            mdoc = mdoc & "\" & szRuta & szNombre & szFecha & ".html"
        End If
        srReport = New StreamWriter(mdoc, False)
        Return mdoc
    End Function
    Public Function modulo11(ByVal codigo As String) As String
        Dim factor As Integer = 2
        Dim i As Integer = 0
        Dim suma As Integer = 0
        Dim resto As Integer = 0
        Dim final As Integer = 0
        Dim devolver As String = ""
        For i = Len(codigo) To 1 Step -1
            suma += (Val(Mid(codigo, i, 1)) * factor)
            factor += 1
            If factor > 7 Then
                factor = 2
            End If
        Next
        resto = suma Mod 11
        final = 11 - resto
        Select Case final
            Case 11
                devolver = "0"
            Case 10
                devolver = "K"
            Case Else
                devolver = final.ToString
        End Select
        Return devolver
    End Function
    Sub GrabaReport(szTexto As String)
        Try
            srReport.WriteLine(szTexto & vbCrLf)
        Catch ex As Exception
        End Try
    End Sub
    Sub CloseReport()
        Try
            srReport.Close()
        Catch ex As Exception
        End Try
    End Sub
    Function mNum(ByVal txt As String) As Integer
        mNum = 0
        If txt.Length = 0 Then
            mNum = 0
            Exit Function
        End If
        Try
            mNum = CInt(txt)
        Catch ex As Exception
            mNum = 0
        End Try
    End Function
    Public Function FechaGringa(ByVal szFecha As String) As String
        FechaGringa = szFecha.Substring(6, 4) & szFecha.Substring(3, 2) & szFecha.Substring(0, 2) & " " & Format(Now, "HH:mm:ss")
    End Function
    Public Function StringToStream(input As String, enc As System.Text.Encoding) As Stream
        Dim memoryStream = New MemoryStream()
        Dim streamWriter = New StreamWriter(memoryStream, enc)
        streamWriter.Write(input)
        streamWriter.Flush()
        memoryStream.Position = 0
        Return memoryStream
    End Function
    Public Function CargaXml(filePath As String) As String
        Dim texto As String = ""
        Try
            Dim nfile As Integer = FreeFile()
            FileOpen(nfile, filePath, OpenMode.Input, OpenAccess.Read, OpenShare.Default)
            Do While Not EOF(nfile)
                texto &= LineInput(nfile)
            Loop
            FileClose(nfile)
        Catch ex As Exception

        End Try
        Return texto
    End Function
    Public Sub getConfxml()
        Try
            Dim ds As New DataSet
            Dim szTexto As String
            Dim szDummy As String
            Dim szFile As String = My.Application.Info.DirectoryPath & "\config.xml"
            Dim strm As Stream
            szDummy = CargaXml(szFile)
            ' si no se puede desencriptar, entonces es texto plano
            Try
                szTexto = Desencriptar(szDummy)
            Catch ex As Exception
                szTexto = szDummy
            End Try
            strm = StringToStream(szTexto, System.Text.Encoding.UTF8)
            ds.ReadXml(strm)
            server = ds.Tables(0).Rows(0).Item("server-name")
            userdb = ds.Tables(0).Rows(0).Item("user-name")
            passdb = ds.Tables(0).Rows(0).Item("password")
            database = ds.Tables(0).Rows(0).Item("db-name")
            portname = ds.Tables(0).Rows(0).Item("port-name")
        Catch ex As Exception
            MsgBox("Error de Configuracion: " & ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "SBL Error")
            Application.Exit()
            Exit Sub
        End Try
    End Sub
    Public Sub getConnection()
        Try
            csql = New SqlConnection
            csql.ConnectionString = "Data Source=" & server & ";Initial Catalog=" & database & ";User Id=" & userdb & ";Password=" & passdb & ";"
            csql.Open()
        Catch ex As Exception
            MsgBox("Error de Base de Datos: " & ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "SBL Error")
            Application.Exit()
            Exit Sub
        End Try
    End Sub
    Function execQuery(ByVal SQL As String, ByVal oConn As SqlConnection) As SqlDataReader
        Dim cM As New SqlCommand(SQL, oConn)
        Dim dR As SqlDataReader = cM.ExecuteReader()
        Return dR
    End Function
    Function execQueryT(ByVal SQL As String, ByVal oConn As SqlConnection, ByVal mytrans As SqlTransaction) As SqlDataReader
        Dim cM As New SqlCommand(SQL, oConn)
        cM.Transaction = mytrans
        Dim dR As SqlDataReader = cM.ExecuteReader()
        Return dR

    End Function
    Function execDataSet(ByVal Sql As String, ByVal oConn As SqlConnection) As DataSet
        Dim dA As New SqlDataAdapter(Sql, oConn)
        Dim dC As New SqlCommandBuilder(dA)
        'Crear una nueva instancia del DataSet
        Dim dS As New DataSet()
        dS.EnforceConstraints = False
        dA.Fill(dS, "Sql")
        Return dS
    End Function
    Public Sub execUpdate(ByVal SQL As String, ByVal oConn As SqlConnection)
        Dim cM As New SqlCommand(SQL, oConn)
        cM.CommandTimeout = 0
        cM.ExecuteNonQuery()
    End Sub
    Public Sub execUpdateT(ByVal SQL As String, ByVal oConn As SqlConnection, ByVal mytrans As SqlTransaction)
        Dim cM As New SqlCommand(SQL, oConn)
        cM.Transaction = mytrans
        cM.ExecuteNonQuery()
    End Sub
    Public Function checkConnection() As Boolean
        Dim ok As Boolean = True
        Try
            If csql.State = Data.ConnectionState.Broken Or csql.State = Data.ConnectionState.Closed Then
                ok = False
            End If
            Return ok
        Catch ex As Exception
            ok = False
            MsgBox(ex.Message)
        End Try
    End Function
    Dim iidx As Integer = 0
    Public Sub printUbicacionesOLD(ByVal impresora As String, ByVal textos() As String)
        Dim tt As New tPrint
        Dim sz As String = ""
        sz += "^XA~TA000~JSN^LT0^MNW^MTT^PON^PMN^LH0,0^JMA^PR5,5~SD15^JUS^LRN^CI0^XZ"
        sz += "^XA ^MMT ^PW799 ^LL0256 ^LS0"
        sz += "^FT615,230^BQN,2,5 ^FH\^FDMA," & textos(0) & "^FS ^FB238,2,0,C ^FT790,40^A0I,18,21^FH\^FD" & textos(0) & "^FS ^PQ1,0,1,Y^XZ"
        tt.SendStringToPrinter(impresora, sz)
    End Sub
    Public sz As String = ""
    Public iEtq As Integer = 1
    Public tt As tPrint
    Public Sub printUbicaciones(ByVal impresora As String, ByVal textos() As String)
        Dim iPos As Integer = 0
        Dim iPosCod As Integer = 0
        If iEtq = 1 Then
            sz = "^XA~TA000~JSN^LT0^MNW^MTT^PON^PMN^LH0,0^JMA^PR5,5~SD15^JUS^LRN^CI0^XZ"
            sz += "^XA ^MMT ^PW799 ^LL0256 ^LS0"
            iPos = 790
            iPosCod = 615
        End If
        If iEtq = 2 Then
            iPos = 514
            iPosCod = 343
        End If
        If iEtq = 3 Then
            iPos = 243
            iPosCod = 72
        End If
        textos(0) = escapezpl(textos(0))
        sz += "^FT" & iPosCod & ",230^BQN,2,5 ^FH\^FDMA," & textos(0) & "^FS ^FB238,2,0,C ^FT" & iPosCod & ",40^A0I,18,21^FH\^FD" & textos(0) & "^FS ^PQ1,0,1,Y^XZ"
        If iEtq = 3 Then
            sz += "^PQ1,0,1,Y^XZ" & vbCrLf
            Console.Out.WriteLine(sz)
            tt.SendStringToPrinter(impresora, sz)
            sz = ""
        End If
    End Sub
    Function acentoszpl(ByVal id As String) As String
        Dim i As Integer
        Dim szT As String = ""
        Dim c As String = ""
        For i = 0 To id.Length - 1
            c = id.Substring(i, 1)
            Select Case c
                Case c = "á"
                    c = "a"
                Case c = "é"
                    c = "e"
                Case c = "í"
                    c = "i"
                Case c = "ó"
                    c = "o"
                Case c = "ú"
                    c = "u"
                Case c = "ñ"
                    c = "n"
            End Select
            szT += c
        Next
        acentoszpl = szT
    End Function
    Public Sub printProductos10x5(ByVal impresora As String, ByVal textos() As String)
        Dim tt As New tPrint
        Dim sz As String = ""
        Dim iPos As Integer = 0
        Dim iPosCod As Integer = 0
        textos(0) = acentoszpl(textos(0))
        textos(1) = acentoszpl(textos(1))
        ' codigo
        iPosCod = 380 - (textos(0).Length * 25) / 2
        If iPosCod < 1 Then
            iPosCod = 1
        End If
        ' producto
        iPos = 380 - (textos(1).Length * 10) / 2
        If iPos < 1 Then
            iPos = 1
        End If
        sz += "^XA~TA000~JSN^LT0^MNW^MTD^PON^PMN^LH0,0^JMA^PR4,4~SD15^JUS^LRN^CI0^XZ" & vbCrLf
        sz += "^XA" & vbCrLf
        sz += "^MMT" & vbCrLf
        sz += "^PW799" & vbCrLf
        sz += "^LL0400" & vbCrLf
        sz += "^LS0" & vbCrLf
        sz += "^BY2,3,160^FT" & iPosCod & ",216^BCN,,Y,N" & vbCrLf
        sz += "^FD>:" & textos(0) & "^FS" & vbCrLf
        sz += "^FT" & iPos & ",297^A0N,28,28^FH\^FD" & textos(1) & "^FS" & vbCrLf
        sz += "^PQ1,0,1,Y^XZ" & vbCrLf
        tt.SendStringToPrinter(impresora, sz)
    End Sub
    Dim ArVentanas(40) As Object
    Dim icnt As Integer
    Public frmMDI As MDI_Main
    Public Function PushVentana(ByVal ob As Form) As Boolean
        Dim i As Integer
        Dim j As Integer = -1
        frmMDI.VentanaToolStripMenuItem.Visible = True
        For i = 0 To ArVentanas.Length - 1
            If Not IsNothing(ArVentanas(i)) Then
                If ArVentanas(i).Text = ob.Text Then
                    ArVentanas(i).BringToFront()
                    Return False
                End If
            Else
                If j = -1 Then
                    j = i ' guardamos posicion de nothing 
                End If
            End If
        Next
        If i = ArVentanas.Length Then
            ArVentanas(j) = ob
            Return True
        End If
    End Function
    Public Function ReleaseVentana(ByVal ob As Form) As Boolean
        Dim i As Integer
        Dim x As Integer
        For i = 0 To ArVentanas.Length - 1
            If Not IsNothing(ArVentanas(i)) Then
                If ArVentanas(i).Text = ob.Text Then
                    ArVentanas(i) = Nothing
                    For x = 0 To ArVentanas.Length - 1
                        If Not IsNothing(ArVentanas(x)) Then
                            Exit For
                        End If
                    Next
                    If x = ArVentanas.Length Then
                        frmMDI.VentanaToolStripMenuItem.Visible = False
                    End If
                    Exit For
                End If
            End If
        Next
        Return False
    End Function
    Public Function SinPuntos(ByVal szRut As String) As String
        Dim vrut As String
        vrut = szRut
        vrut = vrut.Replace(".", "")
        'vrut = vrut.Replace("-", "")
        vrut = vrut.Replace(" ", "")
        Return vrut
    End Function
    Public Function ValidaRut(ByVal szRut As String) As Boolean
        Dim dv As String
        Dim rut As String
        Dim szDV As String
        If szRut.IndexOf("-") = -1 Then
            Return False
        End If
        If szRut.Length < 2 Then
            Return False
        End If
        rut = SinPuntos(szRut)
        szDV = UCase(Right(rut, 1))
        rut = rut.Substring(0, rut.Length - 2)
        dv = RutDigito(CLng(rut))
        If szDV = dv Then
            Return True
        End If
        Return False
    End Function
    Public Function RutDigito(ByVal Rut As Long) As String
        Dim Digito As Integer
        Dim Contador As Integer
        Dim Multiplo As Integer
        Dim Acumulador As Integer
        Contador = 2
        Acumulador = 0
        While Rut <> 0
            Multiplo = (Rut Mod 10) * Contador
            Acumulador = Acumulador + Multiplo
            Rut = Rut \ 10
            Contador = Contador + 1
            If Contador = 8 Then
                Contador = 2
            End If
        End While
        Digito = 11 - (Acumulador Mod 11)
        RutDigito = CStr(Digito)
        If Digito = 10 Then RutDigito = "K"
        If Digito = 11 Then RutDigito = "0"
    End Function
    Function escapezpl(ByVal id As String) As String
        Dim i As Integer
        Dim iFirst As Boolean = True
        Dim szT As String = ""
        Dim c As String = ""
        For i = 0 To id.Length - 1
            If id.Substring(i, 1) = "-" Then
                '    If iFirst Then
                '        If szT.Length > 1 Then
                '            szT += "->5"
                '        Else
                '            szT = ">5-"
                '        End If
                '    Else
                '        szT += "-"
                '    End If
                '    iFirst = False
                'Else
                c = id.Substring(i, 1)
                Select Case c
                    Case c = "á"
                        c = "a"
                    Case c = "é"
                        c = "e"
                    Case c = "í"
                        c = "i"
                    Case c = "ó"
                        c = "o"
                    Case c = "ú"
                        c = "u"
                    Case c = "ñ"
                        c = "n"
                End Select
                szT += c
            End If
        Next
        escapezpl = szT
    End Function
    Public Function ExisteArchivo(ByVal archivo As String) As Boolean
        Dim filename As String = archivo
        If System.IO.File.Exists(filename) Then
            Return True
        End If
        Return False
    End Function
    Public Function findFolios(ByVal Codigo As String, Optional flag As Boolean = True) As Long
        findFolios = 0
        sql = "Select Num_Folio "
        sql += "From Folios "
        sql += "Where Cod_Folio = " & Codigo & " "
        Dim dr As SqlDataReader = execQuery(sql, csql)
        If dr.Read Then
            findFolios = dr("Num_Folio")
            dr.Close()
            If flag = True Then
                sql = "Update Folios "
                sql += "Set Num_Folio = Num_Folio + 1 "
                sql += "Where Cod_Folio = " & Codigo & " "
                Call execUpdate(sql, csql)
            End If
        End If
        dr.Close()
    End Function
    Public Sub cargaCiudad(ByVal cbox As Klik.Windows.Forms.v1.EntryLib.ELComboBox, Llave As String, szFiltro As String)
        cbox.Items.Clear()
        cbox.Items.Add("")
        cbox.Items(0).Key = -1
        sql = "select * "
        sql += "from ciudad "
        If Llave <> "" Then
            sql += "WHERE id_ciudad = '" & Llave & "' "
        End If
        sql += "Order By ciudad"
        Dim dr As SqlDataReader = execQuery(sql, csql)
        Dim i As Integer = 1
        Dim Posicion As Integer = 0
        While dr.Read
            cbox.Items.Add(dr("ciudad"))
            cbox.Items(i).Key = dr("id_ciudad")
            If szFiltro = dr("id_ciudad") Then
                Posicion = i
            End If
            i += 1
        End While
        dr.Close()
        If Posicion > 0 Then
            cbox.SelectedIndex = Posicion
        End If
    End Sub


    Public Sub ExportarAExcel(ByVal dataGridView As DataGridView)
        Dim aplicacionExcel As New Excel.Application
        Dim workbook As Excel.Workbook = aplicacionExcel.Workbooks.Add()
        Dim worksheet As Excel.Worksheet = workbook.ActiveSheet

        ' Exportar los encabezados
        For i As Integer = 1 To dataGridView.Columns.Count
            worksheet.Cells(1, i) = dataGridView.Columns(i - 1).HeaderText
        Next

        ' Exportar los datos
        For i As Integer = 0 To dataGridView.Rows.Count - 1
            For j As Integer = 0 To dataGridView.Columns.Count - 1
                Try
                    worksheet.Cells(i + 2, j + 1) = dataGridView.Rows(i).Cells(j).Value.ToString()
                Catch
                    worksheet.Cells(i + 2, j + 1) = ""
                End Try
            Next
        Next

        ' Ajustar el tamaño de las columnas
        worksheet.Columns.AutoFit()

        ' Mostrar Excel
        aplicacionExcel.Visible = True
    End Sub
End Module
