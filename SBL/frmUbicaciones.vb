Imports System.Data.SqlClient
Imports SBL.ntPrint
Public Class frmUbicaciones
    Public Const aEtq As Integer = 400
    Private Oper As String = ""
    Private codCentro As String = ""
    Private codBodega As String = ""
    Dim sz As String = ""
    Dim sql As String
    Dim tt As New tPrint
    Public Sub printUbicaciones10x5(ByVal id As String, ByVal impresora As String)
        Dim tt As New tPrint
        Dim sz As String = ""
        Dim iPos As Integer = 0
        Dim iPosCod As Integer = 0
        ' codigo
        iPosCod = 380 - (id.Length * 25) / 2
        If iPosCod < 1 Then
            iPosCod = 1
        End If
        ' producto
        iPos = 380 - (id.Length * 10) / 2
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
        sz += "^FD>:" & id & "^FS" & vbCrLf
        sz += "^FT" & iPos & ",297^A0N,28,28^FH\^FD" & id & "^FS" & vbCrLf
        sz += "^PQ1,0,1,Y^XZ" & vbCrLf
        tt.SendStringToPrinter(impresora, sz)
    End Sub
    Public Sub printUbicaciones5x2Angosto(ByVal id As String, ByVal impresora As String, ByVal columna As Integer)
        ' columna 1 o 2
        Dim x As Integer = aEtq
        Dim xb As Integer = EjeXAg1
        Dim iPosCod As Integer = 0
        If columna = 2 Then
            x = 1
            xb = EjeXAg2
        End If
        If columna = 1 Then
            sz = "^XA~TA000~JSN^LT0^MNW^MTT^PON^PMN^LH0,0^JMA^PR5,5~SD15^JUS^LRN^CI0^XZ" & vbCrLf
            sz += "^XA" & vbCrLf
            sz += "^MMT" & vbCrLf
            sz += "^PW799" & vbCrLf
            sz += "^LL0200" & vbCrLf
            sz += "^LS0" & vbCrLf
        End If
        sz += "^FB370,3,0,C" & vbCrLf
        sz += "^FT" & x & ",185^A0N,17,16^FH\^FD" & id & "^FS" & vbCrLf
        sz += "^BY1,3,95^FT" & xb & ",115^BCN,,Y,N" & vbCrLf
        sz += "^FD>:" & id & "^FS" & vbCrLf
        If columna = 2 Then
            sz += "^PQ1,0,1,Y^XZ" & vbCrLf
            Console.Out.WriteLine(sz)
            tt.SendStringToPrinter(impresora, sz)
            sz = ""
        End If
    End Sub
    Public Sub printUbicaciones5x2Ancho(ByVal id As String, ByVal impresora As String, ByVal columna As Integer)
        ' columna 1 o 2
        Dim x As Integer = aEtq
        Dim xb As Integer = EjeXAn1
        Dim iPosCod As Integer = 0
        If columna = 2 Then
            x = 1
            xb = EjeXAn2
        End If
        If columna = 1 Then
            sz = "^XA~TA000~JSN^LT0^MNW^MTT^PON^PMN^LH0,0^JMA^PR5,5~SD15^JUS^LRN^CI0^XZ^XA^MMT^PW799^LL0200^LS0" & vbCrLf
            sz += "^XA" & vbCrLf
            sz += "^MMT" & vbCrLf
            sz += "^PW799" & vbCrLf
            sz += "^LL0200" & vbCrLf
            sz += "^LS0" & vbCrLf
        End If
        sz += "^BY2,3,95^FT" & xb & ",115^BCN,,Y,N" & vbCrLf
        sz += "^FD>:" & id & "^FS" & vbCrLf
        If columna = 2 Then
            sz += "^PQ1,0,1,Y^XZ" & vbCrLf
            Console.Out.WriteLine(sz)
            tt.SendStringToPrinter(impresora, sz)
            sz = ""
        End If
    End Sub
    Private Sub cargarDatos()
        Dim dS As New DataSet
        Dim dT As New DataTable
        dtaGrid.AutoGenerateColumns = False
        dtaGrid.Columns.Clear()
        dtaGrid.Columns.Add("cod_hilera", "Hilera")
        dtaGrid.Columns.Add("cod_columna", "Columna")
        dtaGrid.Columns.Add("cod_nivel", "Nivel")
        dtaGrid.Columns.Add("ubicacion", "Ubicación")
        dtaGrid.Columns.Add("estado_ubicacion", "Estado")
        dtaGrid.Columns(0).DataPropertyName = "cod_hilera"
        dtaGrid.Columns(1).DataPropertyName = "cod_columna"
        dtaGrid.Columns(2).DataPropertyName = "cod_nivel"
        dtaGrid.Columns(3).DataPropertyName = "cod_ubicacion"
        dtaGrid.Columns(4).DataPropertyName = "estado_ubicacion"
        dtaGrid.Columns(0).Width = 72
        dtaGrid.Columns(1).Width = 72
        dtaGrid.Columns(2).Width = 72
        dtaGrid.Columns(3).Width = 130
        dtaGrid.Columns(4).Width = 90
        dtaGrid.DataSource = dT
        Dim oCmd As SqlCommand = New SqlCommand
        oCmd.Connection = csql
        oCmd.CommandText = "SELECT * FROM Ubicaciones WHERE Cod_Bodega = '" & codBodega & "'"
        If Trim(cmbHileras.Text) <> "" Then
            oCmd.CommandText += " And Cod_Hilera = '" & cmbHileras.Text & "'"
        End If
        If Trim(cmbColumnas.Text) <> "" Then
            oCmd.CommandText += " And Cod_Columna = '" & cmbColumnas.Text & "'"
        End If
        oCmd.CommandText += " And Cod_Hilera <> ''"
        oCmd.CommandText += " ORDER BY Cod_Hilera,Cod_Columna,Cod_Nivel"
        dT.TableName = "Ubicaciones"
        dT.Load(oCmd.ExecuteReader)
        dS.Tables.Add(dT)
        btnEliminar.Enabled = False
        txtCantidad.Text = "1"
        dtaGrid.DataSource = dS.Tables("Ubicaciones")
        dtaGrid.Refresh()
    End Sub
    Private Sub cargarBodegas()
        sql = "SELECT Cod_Bodega"
        sql += ",Desc_Bodega "
        sql += "FROM Bodegas WHERE Estado_Bodega = 'ACT' "
        sql += "ORDER BY Cod_Bodega"
        Dim dR As SqlDataReader = execQuery(sql, csql)
        While dR.Read
            cmbBodegas.Items.Add(dR("Cod_Bodega") & " - " & dR("Desc_Bodega"))
        End While
        dR.Close()
    End Sub
    Private Sub cargarHileras()
        sql = "SELECT Cod_Hilera "
        sql += "FROM Ubicaciones "
        sql += "WHERE Cod_Bodega = '" & codBodega & "' "
        sql += "Group By Cod_Hilera "
        sql += "ORDER BY Cod_Hilera"
        Dim dR As SqlDataReader = execQuery(sql, csql)
        While dR.Read
            cmbHileras.Items.Add(dR("Cod_Hilera"))
        End While
        dR.Close()
    End Sub
    Private Sub cargarColumnas()
        sql = "SELECT Cod_Columna "
        sql += "FROM Ubicaciones "
        sql += "WHERE Cod_Bodega = '" & codBodega & "' "
        sql += "And Cod_Hilera = '" & cmbHileras.Text & "' "
        sql += "And Estado_Ubicacion = 'ACT' "
        sql += "Group By Cod_Columna "
        sql += "ORDER BY Cod_Columna"
        Dim dR As SqlDataReader = execQuery(sql, csql)
        While dR.Read
            cmbColumnas.Items.Add(dR("Cod_Columna"))
        End While
        dR.Close()
    End Sub
    Private Sub frmUbicaciones_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ReleaseVentana(Me)
    End Sub
    Sub getInformacionImpresora()
        For Each printerName As String In System.Drawing.Printing.PrinterSettings.InstalledPrinters()
            If printerName.IndexOf("PL") > 0 Then cmbPrinter.Items.Add(printerName)
        Next
        If cmbPrinter.Items.Count > 0 Then
            cmbPrinter.SelectedIndex = 0
        End If
    End Sub
    Private Sub frmUbicaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getInformacionImpresora()
        SerialPort.PortName = portname
        cmbEstado.Items.Add("Activa")
        cmbEstado.Items.Add("Inactiva")
        cmbTama.Items.Add("5x2.5 cm Angosto")
        cmbTama.Items.Add("5x2.5 cm Ancho")
        cmbTama.Items.Add("10x5 cm")
        cmbTama.SelectedIndex = 0
        Call cargarBodegas()
    End Sub
    Private Sub cmbBodegas_SELECTedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBodegas.SelectedIndexChanged
        If Trim(cmbBodegas.Text) <> "" Then
            cmbHileras.Items.Clear()
            cmbColumnas.Items.Clear()
            Dim aux() As String
            aux = cmbBodegas.Text.Split("-")
            codBodega = Trim(aux(0))
            Call cargarHileras()
            Call cargarDatos()
        End If
    End Sub
    Private Sub cmbColumnas_SELECTedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbColumnas.SelectedIndexChanged
        If Trim(cmbColumnas.Text) <> "" Then
            Call cargarDatos()
        End If
    End Sub
    Private Sub dtaGrid_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If dtaGrid.SelectedRows.Count = 0 Then Exit Sub
        btnEliminar.Enabled = True
    End Sub
    Private Sub dtaGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtaGrid.DoubleClick
        If dtaGrid.SelectedRows.Count = 0 Then Exit Sub
        Oper = "M"
        Try
            sql = "SELECT * "
            sql += "FROM Ubicaciones "
            sql += "WHERE Cod_Bodega = '" & codBodega & "' "
            sql += "And Cod_Hilera = '" & dtaGrid.SelectedRows(0).Cells(0).Value.ToString & "' "
            sql += "And Cod_Columna = '" & dtaGrid.SelectedRows(0).Cells(1).Value.ToString & "' "
            sql += "And Cod_Nivel = '" & dtaGrid.SelectedRows(0).Cells(2).Value.ToString & "' "
            Dim dR As SqlDataReader = execQuery(sql, csql)
            If dR.Read Then
                txtHilera.Text = dR("Cod_Hilera")
                txtColumna.Text = dR("Cod_Columna")
                txtNivel.Text = dR("Cod_Nivel")
                txtDescripcion.Text = dR("Cod_Ubicacion")
                Select Case dR("Estado_Ubicacion")
                    Case "INA"
                        cmbEstado.Text = "Inactiva"
                    Case Else
                        cmbEstado.Text = "Activa"
                End Select
            End If
            dR.Close()
        Catch ex As Exception
            MsgBox("Error de Aplicación: " & ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Bodegas")
        End Try
        btnEliminar.Enabled = False
        cmbEstado.Enabled = True
        cmbEstado.Focus()
    End Sub
    Private Sub btnLimpia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpia.Click
        cmbHileras.Items.Clear()
        cmbColumnas.Items.Clear()
        Me.txtColumna.Text = ""
        Me.txtDescripcion.Text = ""
        Me.txtHilera.Text = ""
        Me.txtNivel.Text = ""
        Me.upNiveles1.Value = 1
        btnEliminar.Enabled = False
        Me.upColumnas1.Value = 1
        cmbEstado.Enabled = False
        cmbEstado.SelectedIndex = -1
        cmbBodegas.SelectedIndex = -1
        dtaGrid.DataSource = Nothing
        dtaGrid.Refresh()
    End Sub
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If dtaGrid.SelectedRows.Count = 0 Then Exit Sub
        Dim resp As MsgBoxResult
        Dim szLista As String = ""
        For Each dg In dtaGrid.SelectedRows
            szLista += dg.Cells(0).Value & dg.Cells(1).Value & dg.Cells(2).Value & vbCrLf
        Next
        If szLista.Length = 0 Then Exit Sub
        resp = MsgBox("Esta seguro de eliminar ubicaciones ?" & vbCrLf & "Este proceso es irreversible" & vbCrLf & vbCrLf & szLista, MsgBoxStyle.YesNo)
        If resp = MsgBoxResult.Yes Then
            Try
                For Each dg In dtaGrid.SelectedRows
                    sql = "SELECT * "
                    sql += "FROM movimientos "
                    sql += "WHERE cod_ubicacion = '" & codBodega & dg.Cells(0).Value & dg.Cells(1).Value & dg.Cells(2).Value & "'"
                    Dim dR As SqlDataReader = execQuery(sql, csql)
                    If dR.Read Then
                        erpEdicion.FooterText = "Producto no puede ser eliminado tiene movimientos asociados."
                        tmrMensaje.Enabled = True
                        Application.DoEvents()
                        dR.Close()
                        Exit Sub
                    End If
                    dR.Close()
                    sql = "DELETE FROM Ubicaciones "
                    sql += "WHERE Cod_Bodega = '" & codBodega & "' "
                    sql += "And Cod_Hilera = '" & dg.Cells(0).Value & "' "
                    sql += "And Cod_Columna = '" & dg.Cells(1).Value & "' "
                    sql += "And Cod_Nivel = '" & dg.Cells(2).Value & "' "
                    Call execUpdate(sql, csql)
                Next
                btnEliminar.Enabled = False
            Catch ex As Exception
                MsgBox("Error de Aplicación: " & ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Ubicaciones")
            End Try
            cargarDatos()
        End If
    End Sub
    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Dim szEst As String = "ACT"
        If cmbEstado.Text = "Inactiva" Then
            szEst = "INA"
        End If
        If cmbBodegas.SelectedIndex < 0 Then
            MsgBox("Seleccione Bodega, antes de grabar")
            Exit Sub
        End If
        sql = "UPDATE Ubicaciones "
        sql += "set estado_ubicacion = '" & szEst & "' "
        sql += "WHERE Cod_Bodega = '" & codBodega & "' "
        sql += "And Cod_Hilera = '" & txtHilera.Text & "' "
        sql += "And Cod_Columna = '" & txtColumna.Text & "' "
        sql += "And Cod_Nivel = '" & txtNivel.Text & "' "
        Call execUpdate(sql, csql)
        Call cargarDatos()
    End Sub
    Private Sub btnLimiarC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimiarC.Click
        Me.upHilera1.Value = 1
        Me.upNiveles1.Value = 1
        Me.upColumnas1.Value = 1
        Me.upHilera2.Value = 1
        Me.upNiveles2.Value = 1
        Me.upColumnas2.Value = 1
    End Sub
    Private Sub btnGrabarC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabarC.Click
        Dim addH As Boolean = False
        Dim resp As MsgBoxResult
        If cmbBodegas.Text = "" Then
            MsgBox("Seleccione Bodega, antes de grabar")
            Exit Sub
        End If
        If upHilera2.Value < upHilera1.Value Then
            MsgBox("Hilera Inicial debe ser menor o igual a Hilera Final")
            Exit Sub
        End If
        If upColumnas2.Value < upColumnas1.Value Then
            MsgBox("Columna Inicial debe ser menor o igual a Columna Final")
            Exit Sub
        End If
        If upNiveles2.Value < upNiveles1.Value Then
            MsgBox("Nivel Inicial debe ser menor o igual a Nivel Final")
            Exit Sub
        End If
        resp = MsgBox("¿ Esta seguro de agregar nuevas ubicaciones de acuerdo a los parámetros ingresados ?", MsgBoxStyle.YesNo, "SBL")
        Dim i As Integer = 0
        Dim j As Integer = 0
        If resp = MsgBoxResult.Yes Then
            For h = upHilera1.Value To upHilera2.Value
                For i = upColumnas1.Value To upColumnas2.Value
                    For j = upNiveles1.Value To upNiveles2.Value
                        Try
                            sql = "INSERT INTO Ubicaciones(Cod_Bodega"
                            sql += ",Cod_Hilera"
                            sql += ",Cod_Columna"
                            sql += ",Cod_Nivel"
                            sql += ",Cod_Ubicacion"
                            sql += ",Estado_Ubicacion) "
                            sql += "VALUES('" & codBodega & "'"
                            sql += ",'H" & Format(h, "00") & "'"
                            sql += ",'C" & Format(i, "00") & "'"
                            sql += ",'N" & Format(j, "00") & "'"
                            sql += ",'" & codBodega & "H" & Format(h, "00") & "C" & Format(i, "00") & "N" & Format(j, "00") & "'"
                            sql += ",'ACT')"
                            Call execUpdate(sql, csql)
                        Catch ex As Exception
                        End Try
                    Next
                Next
            Next
            upNiveles1.Value = 1
            upColumnas1.Value = 1
            upNiveles1.Value = 1
            upNiveles2.Value = 1
            upColumnas2.Value = 1
            upNiveles2.Value = 1
            Call cargarHileras()
            Call cargarDatos()
        End If
    End Sub
    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If dtaGrid.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        Dim szPrint As String
        szPrint = cmbPrinter.Text
        If Val(txtCantidad.Text) < 1 Then
            MsgBox("Debe ingresar la cantidad a imprimir", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SBL")
            txtCantidad.Focus()
            Exit Sub
        End If
        If cmbTama.SelectedIndex = 2 Then ' 10x5
            Dim j As Integer = 1
            Dim i As Integer = 1
            Dim textos(6) As String
            textos(0) = ""
            textos(1) = ""
            Dim dg As DataGridViewRow
            For Each dg In dtaGrid.SelectedRows
                For j = 1 To Val(txtCantidad.Text)
                    Call printUbicaciones10x5(codBodega & dg.Cells(0).Value & dg.Cells(1).Value & dg.Cells(2).Value, szPrint)
                Next
            Next
            textos(0) = ""
            textos(1) = ""
        Else ' 5x2
            Dim idCol As Integer = 1
            Dim dg As DataGridViewRow
            For Each dg In dtaGrid.SelectedRows
                For j = 1 To Val(txtCantidad.Text)
                    If cmbTama.SelectedIndex = 0 Then
                        printUbicaciones5x2Angosto(codBodega & dg.Cells(0).Value & dg.Cells(1).Value & dg.Cells(2).Value, szPrint, idCol)
                    Else
                        If cmbTama.SelectedIndex = 1 Then
                            printUbicaciones5x2Ancho(codBodega & dg.Cells(0).Value & dg.Cells(1).Value & dg.Cells(2).Value, szPrint, idCol)
                        End If
                    End If
                    If idCol = 1 Then
                        idCol = 2
                    Else
                        idCol = 1
                    End If
                Next
            Next
            If sz.Length > 0 Then ' por si quedo una etiqueta sin imprimir (impar)
                sz += "^PQ1,0,1,Y^XZ" & vbCrLf
                tt.SendStringToPrinter(szPrint, sz)
                sz = ""
            End If
        End If
    End Sub
    Private Sub dtaGrid_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtaGrid.Click
        btnEliminar.Enabled = True
    End Sub
    Private Sub cmbHileras_SELECTedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbHileras.SelectedIndexChanged
        If Trim(cmbHileras.Text) <> "" Then
            cmbColumnas.Items.Clear()
            Call cargarColumnas()
            Call cargarDatos()
        End If
    End Sub
    Private Sub erpBusquedas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles erpBusquedas.Click
        Me.Focus()
    End Sub
    Private Sub dtaGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtaGrid.CellContentClick
        Me.Focus()
    End Sub
    Private Sub ElTabPage3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ElTabPage3.Click
        Me.Focus()
    End Sub
    Private Sub erpEdicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles erpEdicion.Click
        Me.Focus()
    End Sub
    Private Sub txtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged
        txtDescripcion.Text = UCase(txtDescripcion.Text)
        txtDescripcion.SelectionStart = Me.txtDescripcion.Text.Length + 1
    End Sub
    Private Sub txtHilera_TextChanged(sender As Object, e As EventArgs) Handles txtHilera.TextChanged
        txtHilera.Text = UCase(txtHilera.Text)
        txtHilera.SelectionStart = Me.txtHilera.Text.Length + 1
    End Sub
    Private Sub txtColumna_TextChanged(sender As Object, e As EventArgs) Handles txtColumna.TextChanged
        txtColumna.Text = UCase(txtColumna.Text)
        txtColumna.SelectionStart = Me.txtColumna.Text.Length + 1
    End Sub
    Private Sub txtNivel_TextChanged(sender As Object, e As EventArgs) Handles txtNivel.TextChanged
        txtNivel.Text = UCase(txtNivel.Text)
        txtNivel.SelectionStart = Me.txtNivel.Text.Length + 1
    End Sub
End Class