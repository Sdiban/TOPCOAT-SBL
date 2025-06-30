Imports System.Data.SqlClient
Imports SBL.ntPrint
Public Class frmProductos
    Dim sz As String = ""
    Public Const aEtq As Integer = 400
    Dim tt As New tPrint
    Public Sub printProductosQR(ByVal id As String, ByVal desc As String, ByVal impresora As String, ByVal columna As Integer)
        Dim iPos As Integer = 0
        Dim iPosCod As Integer = 0
        If columna = 1 Then
            sz = "^XA~TA000~JSN^LT0^MNW^MTT^PON^PMN^LH0,0^JMA^PR5,5~SD15^JUS^LRN^CI0^XZ" & vbCrLf
            sz += "^XA" & vbCrLf
            sz += "^MMT" & vbCrLf
            sz += "^PW799" & vbCrLf
            sz += "^LL0256" & vbCrLf
            sz += "^LS0" & vbCrLf
            iPos = 790
            iPosCod = 615
        End If
        If columna = 2 Then
            iPos = 514
            iPosCod = 343
        End If
        If columna = 3 Then
            iPos = 243
            iPosCod = 72
        End If
        sz += "^FT" & iPosCod & ",230^BQN,2,5" & vbCrLf
        sz += "^FH\^FDMA," & id & "^FS" & vbCrLf
        sz += "^FB238,2,0,C" & vbCrLf
        sz += "^FT" & iPos & ",40^A0I,18,21^FH\^FD" & id & "^FS" & vbCrLf
        If columna = 3 Then
            sz += "^PQ1,0,1,Y^XZ" & vbCrLf
            Console.Out.WriteLine(sz)
            tt.SendStringToPrinter(impresora, sz)
            sz = ""
        End If
    End Sub
    Public Sub printProductosQR31(ByVal id As String, ByVal desc As String, ByVal impresora As String, ByVal columna As Integer)
        Dim iPos As Integer = 0
        Dim iPosCod As Integer = 0
        If columna = 1 Then
            sz = "^XA~TA000~JSN^LT0^MNW^MTT^PON^PMN^LH0,0^JMA^PR5,5~SD15^JUS^LRN^CI0^XZ" & vbCrLf
            sz += "^XA" & vbCrLf
            sz += "^MMT" & vbCrLf
            sz += "^PW719" & vbCrLf
            sz += "^LL0160" & vbCrLf
            sz += "^LS0" & vbCrLf
            iPos = 750
            iPosCod = 603
        End If
        If columna = 2 Then
            iPos = 490
            iPosCod = 331
        End If
        If columna = 3 Then
            iPos = 210
            iPosCod = 52
        End If
        sz += "^FT" & iPosCod & ",153^BQN,2,5" & vbCrLf
        sz += "^FH\^FDLA," & id & "^FS" & vbCrLf
        sz += "^FB238,2,0,C" & vbCrLf
        sz += "^FT" & iPos & ",130^A0I,18,21^FH\^FD" & id & "^FS" & vbCrLf
        If columna = 3 Then
            sz += "^PQ1,0,1,Y^XZ" & vbCrLf
            Console.Out.WriteLine(sz)
            tt.SendStringToPrinter(impresora, sz)
            sz = ""
        End If
    End Sub
    Public Sub printProductos5x2(ByVal id As String, ByVal desc As String, ByVal impresora As String, ByVal columna As Integer)
        ' columna 1 o 2
        Dim x As Integer = aEtq
        Dim xb As Integer = 503
        Dim iPosCod As Integer = 0
        id = escapezpl(id)
        desc = acentoszpl(desc)
        If columna = 2 Then
            x = 1
            xb = 120
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
        sz += "^FT" & x & ",185^A0N,17,16^FH\^FD" & desc & "^FS" & vbCrLf
        sz += "^BY1,3,95^FT" & xb & ",115^BCN,,Y,N" & vbCrLf
        sz += "^FD>:" & id & "^FS" & vbCrLf
        If columna = 2 Then
            sz += "^PQ1,0,1,Y^XZ" & vbCrLf
            Console.Out.WriteLine(sz)
            tt.SendStringToPrinter(impresora, sz)
            sz = ""
        End If
    End Sub
    Public Sub printProductos3x2(ByVal id As String, ByVal desc As String, ByVal impresora As String, ByVal columna As Integer)
        ' columna 1 o 2
        Dim x As Integer = aEtq
        Dim xb As Integer = 790
        Dim iPosCod As Integer = 0
        id = escapezpl(id)
        desc = acentoszpl(desc)
        If columna = 1 Then
            sz = ""
            sz += "^XA~TA000~JSN^LT0^MNW^MTT^PON^PMN^LH0,0^JMA^PR4,4~SD28^JUS^LRN^CI0^XZ" & vbCrLf
            sz += "^XA" & vbCrLf
            sz += "^MMT" & vbCrLf
            sz += "^PW719" & vbCrLf
            sz += "^LL0160" & vbCrLf
            sz += "^LS0" & vbCrLf
            x = 710
            xb = 690
        End If
        If columna = 2 Then
            x = 460
            xb = 430
        End If
        If columna = 3 Then
            x = 190
            xb = 170
        End If
        sz += "^BY1,3,40^FT" & xb & ",110^BCI,,Y,N" & vbCrLf
        sz += "^FD>:" & id & "^FS" & vbCrLf
        sz += "^FB170,3,0,C" & vbCrLf
        sz += "^FT" & x & ",20^A0I,23,9^FH\^FD" & desc & "^FS" & vbCrLf
        If columna = 3 Then
            sz += "^PQ1,0,1,Y^XZ" & vbCrLf
            Console.Out.WriteLine(sz)
            tt.SendStringToPrinter(impresora, sz)
            sz = ""
        End If
    End Sub
    Sub getInformacionImpresora()
        For Each printerName As String In System.Drawing.Printing.PrinterSettings.InstalledPrinters()
            If printerName.IndexOf("PL") > 0 Then cmbPrinter.Items.Add(printerName)
        Next
        If cmbPrinter.Items.Count > 0 Then
            cmbPrinter.SELECTedIndex = 0
        End If
    End Sub
    Private Sub cargarDatos()
        Dim dt As New DataTable
        Dim sqla As String = ""
        sql = "SELECT a.cod_producto"
        sql += ",a.codigoint"
        sql += ",a.desc_producto"
        sql += ",(SELECT f.descripcion FROM familias f WHERE f.id_familia = a.id_familia) as descripcion"
        sql += ",a.minimo"
        sql += ",a.maximo"
        sql += ",a.valor"
        sql += ",a.id_unidadmedida"
        sql += ",(SELECT um.desc_unidadmedida FROM unidad_medida um WHERE um.id_unidadmedida = a.id_unidadmedida) as desc_unidadmedida"
        sql += ",a.usa_serie "
        sql += "FROM productos a "
        'sql += "WHERE a.id_familia = b.id_familia "
        sqla = ""
        If Trim(txtBuscar.Text) <> "" Then
            sqla = "WHERE (cod_producto like '%" & txtBuscar.Text & "%' "
            sqla += "or codigoint like '%" & txtBuscar.Text & "%' "
            sqla += "or desc_producto like '%" & txtBuscar.Text & "%') "
        End If
        ' indice 0 es todo
        If cmbFamiliaFiltro.SELECTedIndex > 0 Then
            If sqla = "" Then
                sqla = "WHERE "
            Else
                sqla += "AND "
            End If
            sqla += "a.id_familia = " & cmbFamiliaFiltro.Items(cmbFamiliaFiltro.SELECTedIndex).Key & " "
        End If
        sqla += "ORDER BY cod_producto"
        dt = execDataSet(sql + sqla, csql).Tables("Sql")
        dtaGrid.AutoGenerateColumns = False
        dtaGrid.Columns.Clear()
        dtaGrid.Columns.Add("cod_producto", "CÓDIGO")
        dtaGrid.Columns.Add("codigoint", "CÓDIGO INT.")
        dtaGrid.Columns.Add("desc_producto", "DESCRIPCIÓN")
        dtaGrid.Columns.Add("descripcion", "FAMILIA")
        dtaGrid.Columns.Add("minimo", "MIN")
        dtaGrid.Columns.Add("maximo", "MAX")
        dtaGrid.Columns.Add("desc_unidadmedida", "UNIDAD MEDIDA")
        dtaGrid.Columns.Add("usa_serie", "USA SERIE")
        dtaGrid.Columns.Add("valor", "VALOR")
        dtaGrid.Columns("cod_producto").DataPropertyName = "cod_producto"
        dtaGrid.Columns("codigoint").DataPropertyName = "codigoint"
        dtaGrid.Columns("desc_producto").DataPropertyName = "desc_producto"
        dtaGrid.Columns("descripcion").DataPropertyName = "descripcion"
        dtaGrid.Columns("minimo").DataPropertyName = "minimo"
        dtaGrid.Columns("maximo").DataPropertyName = "maximo"
        dtaGrid.Columns("desc_unidadmedida").DataPropertyName = "desc_unidadmedida"
        dtaGrid.Columns("usa_serie").DataPropertyName = "usa_serie"
        dtaGrid.Columns("valor").DataPropertyName = "valor"
        dtaGrid.Columns("cod_producto").Width = 150
        dtaGrid.Columns("codigoint").Width = 150
        dtaGrid.Columns("desc_producto").Width = 280
        dtaGrid.Columns("descripcion").Width = 90
        dtaGrid.Columns("minimo").Width = 50
        dtaGrid.Columns("maximo").Width = 60
        dtaGrid.Columns("desc_unidadmedida").Width = 100
        dtaGrid.Columns("usa_serie").Width = 90
        dtaGrid.Columns("valor").Width = 70
        dtaGrid.DataSource = dt
    End Sub
    Private Sub frmProductos_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ReleaseVentana(Me)
    End Sub
    Private Sub frmUsersID_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getInformacionImpresora()
        Call cargarDatos()
        Call CargaFamilias(cmbFamilia)
        Call CargaFamilias(cmbFamiliaFiltro)
        Call CargaUnidadMedida(cmbUnbidadMedida)
        Call CargaUsaSerie(cmbUsaSerie)
        cmbTama.Items.Add("3x2 cm")
        cmbTama.Items.Add("5x2.5 cm")
        cmbTama.Items.Add("10x5 cm")
        cmbTama.Items.Add("3x3 cm QR")
        cmbTama.Items.Add("3x2 cm QR")
        cmbTama.SELECTedIndex = 0
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub btnCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrear.Click
        operador = "A"
        txtCodigo.Enabled = True
        txtCodigoInt.Enabled = True
        txtDescripcion.Enabled = True
        txtMaximo.Enabled = True
        txtMinimo.Enabled = True
        txtValor.Enabled = True
        cmbFamilia.Enabled = True
        cmbUnbidadMedida.Enabled = True
        cmbUsaSerie.Enabled = True
        txtCodigo.Focus()
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Trim(txtCodigo.Text) = "" Then
            MsgBox("Falta ingresar código.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "TDS - SBL")
            Application.DoEvents()
            txtCodigo.Focus()
            Exit Sub
        End If
        If Trim(txtDescripcion.Text) = "" Then
            MsgBox("Falta ingresar descripción para product.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "TDS - SBL")
            Application.DoEvents()
            txtDescripcion.Focus()
            Exit Sub
        End If
        If mNum(txtMinimo.Text) = 0 Then
            MsgBox("Valor mínimo debe ser mayor a cero.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "TDS - SBL")
            Application.DoEvents()
            txtMinimo.Focus()
            Exit Sub
        End If
        If mNum(txtMinimo.Text) >= mNum(txtMaximo.Text) Then
            MsgBox("Valor máximo ingresado no es valido.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "TDS - SBL")
            Application.DoEvents()
            txtMaximo.Focus()
            Exit Sub
        End If
        If cmbFamilia.SelectedIndex < 0 Then
            MsgBox("Debe seleccione Familia.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "TDS - SBL")
            Application.DoEvents()
            cmbFamilia.Focus()
            Exit Sub
        End If
        If cmbUnbidadMedida.SelectedIndex < 0 Then
            MsgBox("Debe selacionar unidad de medida.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "TDS - SBL")
            Application.DoEvents()
            cmbFamilia.Focus()
            Exit Sub
        End If
        If cmbUsaSerie.SelectedIndex < 0 Then
            MsgBox("Debe selacionar si el producto usa serie.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "TDS - SBL")
            Application.DoEvents()
            cmbFamilia.Focus()
            Exit Sub
        End If
        If operador = "A" Then
            sql = "SELECT * "
            sql += "FROM productos "
            sql += "WHERE cod_producto = '" & txtCodigo.Text & "'"
            Dim dr As SqlDataReader = execQuery(sql, csql)
            If dr.Read Then
                dr.Close()
                MsgBox("Código de barra del producto ingresado ya existe.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "TDS - SBL")
                Application.DoEvents()
                Exit Sub
            End If
            dr.Close()
            sql = "SELECT * "
            sql += "FROM productos "
            sql += "WHERE codigoint = '" & txtCodigoInt.Text & "'"
            dr = execQuery(sql, csql)
            If dr.Read Then
                dr.Close()
                MsgBox("Código de interno del producto ingresado ya existe.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "TDS - SBL")
                Application.DoEvents()
                Exit Sub
            End If
            dr.Close()
            sql = "INSERT INTO productos(cod_producto"
            sql += ",codigoint"
            sql += ",desc_producto"
            sql += ",minimo"
            sql += ",maximo"
            sql += ",valor"
            sql += ",id_familia"
            sql += ",id_unidadmedida"
            sql += ",usa_serie) "
            sql += "VALUES('" & txtCodigo.Text & "'"
            sql += ",'" & txtCodigoInt.Text & "'"
            sql += ",'" & txtDescripcion.Text & "'"
            sql += "," & mNum(txtMinimo.Text)
            sql += "," & mNum(txtMaximo.Text)
            sql += "," & mNum(txtValor.Text)
            sql += "," & cmbFamilia.Items(cmbFamilia.SELECTedIndex).Key
            sql += ",'" & cmbUnbidadMedida.Items(cmbUnbidadMedida.SelectedIndex).Key & "'"
            sql += ",'" & cmbUsaSerie.Text & "')"
            Call execUpdate(sql, csql)
        Else
            sql = "UPDATE productos "
            sql += "SET desc_producto = '" & UCase(txtDescripcion.Text) & "'"
            sql += ",minimo = " & mNum(txtMinimo.Text)
            sql += ",maximo = " & mNum(txtMaximo.Text)
            sql += ",valor = " & mNum(txtValor.Text)
            sql += ",codigoint = '" & txtCodigoInt.Text & "'"
            sql += ",id_familia = " & cmbFamilia.Items(cmbFamilia.SELECTedIndex).Key
            sql += ",id_unidadmedida = '" & cmbUnbidadMedida.Items(cmbUnbidadMedida.SelectedIndex).Key & "'"
            sql += ",usa_serie = '" & cmbUsaSerie.Text & "' "
            sql += "WHERE cod_producto = '" & txtCodigo.Text & "'"
            Call execUpdate(sql, csql)
        End If
        Call btnUndo_Click(sender, e)
    End Sub
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
    Private Sub tmrMensaje_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMensaje.Tick
        erpEdicion.FooterText = ""
        tmrMensaje.Enabled = False
    End Sub
    Private Sub btnUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUndo.Click
        txtCodigo.Text = ""
        txtCodigoInt.Text = ""
        txtDescripcion.Text = ""
        txtMaximo.Text = ""
        txtMinimo.Text = ""
        txtValor.Text = ""
        txtCodigo.Enabled = False
        txtCodigoInt.Enabled = False
        txtDescripcion.Enabled = False
        txtMaximo.Enabled = False
        txtMinimo.Enabled = False
        txtValor.Enabled = False
        cmbFamilia.Enabled = False
        cmbFamilia.SELECTedIndex = -1
        cmbUnbidadMedida.Enabled = False
        cmbUnbidadMedida.SELECTedIndex = -1
        cmbUsaSerie.Enabled = False
        cmbUsaSerie.SELECTedIndex = -1
        Call cargarDatos()
    End Sub
    Private Sub dtaGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtaGrid.CellContentClick
        Me.Focus()
    End Sub
    Private Sub dtaGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtaGrid.DoubleClick
        If dtaGrid.SELECTedRows.Count > 0 Then
            sql = "SELECT * "
            sql += "FROM productos "
            sql += "WHERE cod_producto = '" & dtaGrid.SELECTedRows(0).Cells(0).Value & "'"
            Dim dr As SqlDataReader = execQuery(sql, csql)
            If dr.Read Then
                txtCodigo.Text = dr("cod_producto")
                txtCodigoInt.Text = dr("codigoint")
                txtDescripcion.Text = dr("desc_producto")
                txtMinimo.Text = dr("minimo")
                txtMaximo.Text = dr("maximo")
                txtValor.Text = dr("valor")
                cmbFamilia.Enabled = True
                For i = 0 To cmbFamilia.Items.Count - 1
                    If cmbFamilia.Items(i).Key = dr("id_familia") Then
                        cmbFamilia.SELECTedIndex = i
                        Exit For
                    End If
                Next
                cmbUnbidadMedida.Enabled = True
                For i = 0 To cmbUnbidadMedida.Items.Count - 1
                    If cmbUnbidadMedida.Items(i).Key = dr("id_unidadmedida") Then
                        cmbUnbidadMedida.SELECTedIndex = i
                        Exit For
                    End If
                Next
                cmbUsaSerie.Enabled = True
                For i = 0 To cmbUsaSerie.Items.Count - 1
                    If Not String.IsNullOrEmpty(dr("usa_serie").ToString) Then
                        cmbUsaSerie.SELECTedIndex = i
                        If cmbUsaSerie.SELECTedValue = dr("usa_serie") Then
                            cmbUsaSerie.SELECTedIndex = i
                            Exit For
                        End If
                    End If
                Next
                sql = "SELECT cod_producto"
                sql += ",sum(cantidad_producto) as Cantidad "
                sql += "FROM existencias "
                sql += "WHERE cod_producto = '" & dr("cod_producto") & "' "
                sql += "group by cod_producto"
                dr.Close()
                dr = execQuery(sql, csql)
                If dr.Read Then
                    txtExistencia.Text = dr("Cantidad")
                Else
                    txtExistencia.Text = "0"
                End If
                txtCodigoInt.Enabled = True
                txtDescripcion.Enabled = True
                txtMaximo.Enabled = True
                txtMinimo.Enabled = True
                txtValor.Enabled = True
                txtCodigo.Focus()
                operador = "U"
            Else
                MsgBox("Error al cargar los datos del producto.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "TDS - SBL")
            End If
            dr.Close()
        End If
    End Sub
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If dtaGrid.SELECTedRows.Count = 0 Then
            Exit Sub
        End If
        Dim szPrint As String
        szPrint = cmbPrinter.Text
        If Val(txtQ.Text) < 1 Then
            MsgBox("Debe ingresar la cantidad a imprimir.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "TDS - SBL")
            txtQ.Focus()
            Exit Sub
        End If
        Select Case cmbTama.Text
            Case "3x3 cm QR"
                Dim idCol As Integer = 1
                Dim dg As DataGridViewRow
                For Each dg In dtaGrid.SelectedRows
                    For j = 1 To Val(txtQ.Text)
                        printProductosQR(IIf(opcInterno.Checked, dg.Cells("codigoint").Value, dg.Cells("cod_producto").Value), dg.Cells("desc_producto").Value, szPrint, idCol)
                        idCol += 1
                        If idCol > 3 Then
                            idCol = 1
                        End If
                    Next
                Next
                If sz.Length > 0 Then ' por si quedo una etiqueta sin imprimir (impar)
                    sz += "^PQ1,0,1,Y^XZ" & vbCrLf
                    tt.SendStringToPrinter(szPrint, sz)
                    sz = ""
                End If
            Case "3x2 cm QR"
                Dim idCol As Integer = 1
                Dim dg As DataGridViewRow
                For Each dg In dtaGrid.SelectedRows
                    For j = 1 To Val(txtQ.Text)
                        printProductosQR31(dg.Cells("cod_producto").Value, dg.Cells("desc_producto").Value, szPrint, idCol)
                        idCol += 1
                        If idCol > 3 Then
                            idCol = 1
                        End If
                    Next
                Next
                If sz.Length > 0 Then ' por si quedo una etiqueta sin imprimir (impar)
                    sz += "^PQ1,0,1,Y^XZ" & vbCrLf
                    tt.SendStringToPrinter(szPrint, sz)
                    sz = ""
                End If
            Case "3x2 cm"
                Dim idCol As Integer = 1
                Dim dg As DataGridViewRow
                For Each dg In dtaGrid.SelectedRows
                    For j = 1 To Val(txtQ.Text)
                        printProductos3x2(IIf(opcInterno.Checked, dg.Cells("codigoint").Value, dg.Cells("cod_producto").Value), dg.Cells("desc_producto").Value, szPrint, idCol)
                        idCol += 1
                        If idCol > 3 Then
                            idCol = 1
                        End If
                    Next
                Next
                If sz.Length > 0 Then ' por si quedo una etiqueta sin imprimir (impar)
                    sz += "^PQ1,0,1,Y^XZ" & vbCrLf
                    Console.Out.WriteLine(sz)
                    tt.SendStringToPrinter(szPrint, sz)
                    sz = ""
                End If
            Case "5x2.5 cm"
                Dim idCol As Integer = 1
                Dim dg As DataGridViewRow
                For Each dg In dtaGrid.SelectedRows
                    For j = 1 To Val(txtQ.Text)
                        printProductos5x2(IIf(opcInterno.Checked, dg.Cells("codigoint").Value, dg.Cells("cod_producto").Value), dg.Cells("desc_producto").Value, szPrint, idCol)
                        If idCol = 1 Then
                            idCol = 2
                        Else
                            idCol = 1.0F
                        End If
                    Next
                Next
                If sz.Length > 0 Then ' por si quedo una etiqueta sin imprimir (impar)
                    sz += "^PQ1,0,1,Y^XZ" & vbCrLf
                    tt.SendStringToPrinter(szPrint, sz)
                    sz = ""
                End If
            Case "10x5 cm"
                Dim j As Integer = 1
                Dim i As Integer = 1
                Dim textos(6) As String
                textos(0) = ""
                textos(1) = ""
                Dim dg As DataGridViewRow
                For Each dg In dtaGrid.SelectedRows
                    For j = 1 To Val(txtQ.Text)
                        textos(0) = IIf(opcInterno.Checked, dg.Cells("codigoint").Value, dg.Cells("cod_producto").Value)
                        textos(1) = dg.Cells(2).Value
                        Call printProductos10x5(szPrint, textos)
                    Next
                Next
                textos(0) = ""
                textos(1) = ""
        End Select
    End Sub
    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = "'" Then
            e.KeyChar = "-"
        End If
    End Sub
    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Dim resp As MsgBoxResult
        Dim szLista As String = ""
        For Each dg In dtaGrid.SELECTedRows
            szLista += dg.Cells(0).Value & vbCrLf
        Next
        If szLista.Length = 0 Then Exit Sub
        resp = MsgBox("Esta seguro de eliminar producto ?" & vbCrLf & "Este proceso es irreversible" & vbCrLf & vbCrLf & szLista, MsgBoxStyle.YesNo)
        If resp = MsgBoxResult.Yes Then
            For Each dg In dtaGrid.SelectedRows
                sql = "SELECT * "
                sql += "FROM movimientos "
                sql += "WHERE cod_producto='" & dg.Cells(0).Value & "'"
                Dim dR As SqlDataReader = execQuery(sql, csql)
                If dR.Read Then
                    MsgBox("Producto no puede ser eliminado tiene movimientos asociados.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "TDS - SBL")
                    Application.DoEvents()
                    dR.Close()
                    Exit Sub
                End If
                dR.Close()
                execUpdate("DELETE FROM productos WHERE cod_producto='" & dg.Cells(0).Value & "'", csql)
            Next
            cargarDatos()
        End If
        txtCodigo.Text = ""
        txtDescripcion.Text = ""
        txtCodigo.Enabled = False
        txtDescripcion.Enabled = False
        Call cargarDatos()
    End Sub
    Private Sub erpResultados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles erpResultados.Click
        Me.Focus()
    End Sub
    Private Sub erpEdicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles erpEdicion.Click
        Me.Focus()
    End Sub
    Private Sub cmbFamiliaFiltro_SELECTedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbFamiliaFiltro.SelectedIndexChanged
        Call cargarDatos()
    End Sub
    Private Sub txtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged
        txtDescripcion.Text = UCase(txtDescripcion.Text)
        'txtDescripcion.SelectionStart = Me.txtDescripcion.Text.Length + 1
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Call cargarDatos()
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Call ExportarAExcel(dtaGrid)
    End Sub
End Class