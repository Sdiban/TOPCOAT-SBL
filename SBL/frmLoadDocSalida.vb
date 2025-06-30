Option Explicit On
Imports System.Data.SqlClient
Public Class frmLoadDocSalida
    Public jdt As DataTable
    Public jrow As DataRow
    Dim bDocExiste As Boolean = False
    Sub LimpiaGrilla()
        Try
            If dtaGrid.RowCount >= 1 Then
                While dtaGrid.RowCount > 0
                    Dim row As DataGridViewRow = dtaGrid.Rows(0)
                    dtaGrid.Rows.Remove(row)
                End While
            End If
        Catch ex As InvalidOperationException ' Esta excepcion es por si ocurriera
        End Try
    End Sub
    Sub LimpiaCampos(ByVal blimpianumero As Boolean)
        If blimpianumero Then txtNumero.Text = ""
        dtpFecIni.Text = ""
        txtObservaciones.Text = ""
        txtRut.Text = ""
        txtCliente.Text = ""
        dtpFecIni.Enabled = False
        btnSave.Enabled = False
        btnDel.Enabled = False
        txtObservaciones.Enabled = False
        dtaGrid.Enabled = False
        cmbTipoDoc.Enabled = True
        txtNumero.Enabled = True
        btnAdd.Enabled = False
        btnELimina.Enabled = False
        erpBusquedas.FooterText = ""
        LimpiaGrilla()
        jdt.Rows.Clear()
        dtaGrid.DataSource = Nothing
        txtNumero.Focus()
    End Sub
    Sub CargaGrilla()
        Dim ds As New DataSet
        Dim dta As New DataTable
        Dim cEstado As String = ""
        sql = "SELECT cod_producto"
        sql += ",codigoint"
        sql += ",desc_producto"
        sql += ",cantidad"
        sql += ",cantidad_despachada "
        sql += "FROM get_documentos_salida() "
        sql += "WHERE id_empresa = '" & idEmpresa & "' "
        sql += "AND tipo_documento = '" & cmbTipoDoc.Text.Substring(0, 1) & "' "
        sql += "AND id_documento_salida = '" & txtNumero.Text & "' "
        sql += "AND tipo_documento = '" & cmbTipoDoc.Text.Substring(0, 1) & "'"
        dta.TableName = "documentos_salida"
        Try
            jdt.Clear()
            Dim dR As SqlDataReader = execQuery(sql, csql)
            While dR.Read
                jrow = jdt.NewRow()
                jrow("cod_producto") = dR("cod_producto")
                jrow("codigoint") = dR("codigoint")
                jrow("desc_producto") = dR("desc_producto")
                jrow("cantidad") = dR("cantidad")
                jrow("cantidad_despachada") = dR("cantidad_despachada")
                jdt.Rows.Add(jrow)
            End While
            dR.Close()
            erpResultados.FooterText = jdt.Rows.Count.ToString & " resultado(s)"
            dtaGrid.DataSource = jdt
        Catch ex As Exception
        End Try
        dtaGrid.EditMode = DataGridViewEditMode.EditOnEnter
    End Sub
    Function BuscarDocumento() As Boolean
        Try
            LimpiaCampos(False)
            sql = "SELECT * "
            sql += "FROM documentos_salida "
            sql += "WHERE id_empresa = '" & idEmpresa & "' "
            sql += "AND tipo_documento = '" & cmbTipoDoc.Text.Substring(0, 1) & "' "
            sql += "AND id_documento_salida = '" & txtNumero.Text & "'"
            'sql += "AND estado_documento = '" & cmbEstado.SelectedIndex & "'"
            'If cmbEstado.SelectedIndex = -1 Then
            '    MsgBox("Debe seleccionar estado de documentos.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "TDS - SBL")
            'Else
            Dim dR As SqlDataReader = execQuery(sql, csql)
            If dR.Read Then ' cargamos datos
                bDocExiste = True
                If dR("estado_documento") = "CER" Then
                    cmbTipoDoc.Enabled = False
                    txtNumero.Enabled = False
                    dtpFecIni.Enabled = False
                    btnSave.Enabled = False
                    txtObservaciones.Enabled = False
                    txtRut.Enabled = False
                    btnDel.Enabled = False
                    btnAdd.Enabled = False
                    btnELimina.Enabled = False
                    dtaGrid.Enabled = True
                    dtaGrid.ReadOnly = True
                Else
                    dtpFecIni.Enabled = True
                    btnSave.Enabled = True
                    txtObservaciones.Enabled = True
                    txtRut.Enabled = True
                    btnDel.Enabled = True
                    dtaGrid.Enabled = True
                    dtaGrid.ReadOnly = False
                    btnAdd.Enabled = True
                    btnELimina.Enabled = True
                End If
                dtpFecIni.Text = dR("fecha_creacion")
                txtRut.Text = dR("id_cliente")
                If Not String.IsNullOrEmpty(dR("observaciones").ToString) Then
                    txtObservaciones.Text = dR("observaciones")
                End If
                dR.Close()
                Call BuscaCliente()
                CargaGrilla()
            Else
                dR.Close()
                bDocExiste = False
                dtpFecIni.Enabled = True
                btnSave.Enabled = True
                txtObservaciones.Enabled = True
                txtRut.Enabled = True
                dtaGrid.Enabled = True
                btnAdd.Enabled = True
                btnELimina.Enabled = True
                dtaGrid.DataSource = Nothing
                txtRut.Focus()
                Call CargaEstados(cmbEstado, "DS", "", "CRE")
            End If
            'End If
            Return True
        Catch ex As Exception
        End Try
        Return False
    End Function
    Function BuscaProducto(ByVal cod As String) As String
        Dim szRet As String = ""
        Try
            sql = "SELECT desc_producto "
            sql += "FROM productos "
            sql += "WHERE cod_producto = '" & cod & "'"
            Dim dR As SqlDataReader = execQuery(sql, csql)
            If dR.Read Then ' cargamos datos
                szRet = dR("desc_producto")
            End If
            dR.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return szRet
    End Function
    Function BuscaCliente() As Boolean
        Try
            sql = "SELECT nombre "
            sql += "FROM clientes "
            sql += "WHERE id_cliente = '" & SinPuntos(txtRut.Text) & "'"
            Dim dR As SqlDataReader = execQuery(sql, csql)
            If dR.Read Then ' cargamos datos
                txtCliente.Text = dR("nombre")
                dR.Close()
                Return True
            End If
            dR.Close()
            Return False
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
        Return True
    End Function
    Function HayExistencia(ByVal iCan As Integer) As Boolean
        Dim szCod As String
        Dim idbCant As Integer = 0
        szCod = dtaGrid.Item(0, dtaGrid.CurrentRow.Index).Value
        Try
            sql = "SELECT cantidad_producto "
            sql += "FROM existencias "
            sql += "WHERE cod_producto = '" & szCod & "'"
            Dim dR As SqlDataReader = execQuery(sql, csql)
            If dR.Read Then ' cargamos datos
                idbCant = dR("cantidad_producto")
            End If
            dR.Close()
            If iCan > idbCant Then
                MsgBox("Cantidad es superior a existencia (" & idbCant & ").", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "TDS - SBL")
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return True
    End Function
    Private Sub frmLoadDocSalida_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ReleaseVentana(Me)
    End Sub
    Public Sub CreaGrilla()
        dtaGrid.AutoGenerateColumns = False
        dtaGrid.Columns.Clear()
        dtaGrid.Columns.Add("cod_producto", "Codigo")
        dtaGrid.Columns.Add("codigoint", "Codigo Int")
        dtaGrid.Columns.Add("desc_producto", "Descripcion")
        dtaGrid.Columns.Add("cantidad", "Cantidad")
        dtaGrid.Columns.Add("cantidad_despachada", "Despachado")
        dtaGrid.Columns.Add("ubicacion", "Ubicaciones")
        dtaGrid.Columns("cod_producto").DataPropertyName = "cod_producto"
        dtaGrid.Columns("codigoint").DataPropertyName = "codigoint"
        dtaGrid.Columns("desc_producto").DataPropertyName = "desc_producto"
        dtaGrid.Columns("cantidad").DataPropertyName = "cantidad"
        dtaGrid.Columns("cantidad_despachada").DataPropertyName = "cantidad_despachada"
        dtaGrid.Columns("ubicacion").DataPropertyName = "ubicacion"
        dtaGrid.Columns("cod_producto").Width = 80
        dtaGrid.Columns("codigoint").Width = 80
        dtaGrid.Columns("desc_producto").Width = 250
        dtaGrid.Columns("cantidad").Width = 60
        dtaGrid.Columns("cantidad_despachada").Width = 80
        dtaGrid.Columns("ubicacion").Width = 200
    End Sub
    Private Sub frmLoadDocSalida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CreaGrilla()
        jdt = New DataTable("ParentTable177")
        Dim drG As DataRow = jdt.NewRow
        Dim column As DataColumn
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "cod_producto"
        column.ReadOnly = True
        jdt.Columns.Add(column)
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "codigoint"
        column.ReadOnly = True
        jdt.Columns.Add(column)
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "desc_producto"
        column.ReadOnly = True
        jdt.Columns.Add(column)
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Int32")
        column.ColumnName = "cantidad"
        column.ReadOnly = True
        jdt.Columns.Add(column)
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Int32")
        column.ColumnName = "cantidad_despachada"
        column.ReadOnly = True
        jdt.Columns.Add(column)
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "ubicacion"
        column.ReadOnly = True
        jdt.Columns.Add(column)
        dtaGrid.DataSource = jdt
        Dim dR As SqlDataReader
        Call CargaDctoTipo(cmbTipoDoc)
        Call CargaEstados(cmbEstado, "DS")
        sql = "SELECT valor_parametro "
        sql += "FROM parametros "
        sql += "WHERE tabla_parametro = 'ECM' "
        sql += "AND codigo_parametro = 'ECMSI' "
        sql += "AND id_empresa = " & idEmpresa
        dR = execQuery(sql, csql)
        If dR.Read Then
            If dR("valor_parametro") = "SI" Then
                dR.Close()
                cmbEcommerce.Visible = False
                Call CargaEcommerce(cmbEcommerce)
            Else
                dR.Close()
            End If
        Else
            dR.Close()
        End If
    End Sub
    Private Sub txtNumero_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNumero.KeyUp
        If e.KeyCode = Keys.Enter Then
            If cmbTipoDoc.SelectedIndex = -1 Then
                MsgBox("Debe seleccionar tipo de documento.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "TDS - SBL")
                Exit Sub
            End If
            If BuscarDocumento() Then
            End If
        End If
    End Sub
    Private Sub btnUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUndo.Click
        jdt.Rows.Clear()
        LimpiaCampos(True)
    End Sub
    Private Sub ElButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ElButton1.Click
        Me.Close()
    End Sub
    Private Sub dtaGrid_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtaGrid.CellEndEdit
        dtaGrid.Rows(e.RowIndex).ErrorText = String.Empty
    End Sub
    Private Sub dtaGrid_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dtaGrid.CellValidating
        Dim szRet As String = ""
        Dim headerText As String = dtaGrid.Columns(e.ColumnIndex).HeaderText
        erpResultados.FooterText = ""
        If String.IsNullOrEmpty(e.FormattedValue.ToString()) Then
            Exit Sub
        End If
        If headerText = "Código de Producto" Then
            szRet = BuscaProducto(e.FormattedValue.ToString())
            If szRet.Length = 0 Then
                MsgBox("Producto no existe.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "TDS - SBL")
                e.Cancel = True
                Exit Sub
            End If
            dtaGrid.Item(1, dtaGrid.CurrentRow.Index).Value = szRet
            dtaGrid.CurrentRow.Cells(2).Selected = True
        End If
        If headerText = "Cantidad" Then
            If Not IsNumeric(e.FormattedValue.ToString()) Then
                MsgBox("Solo se aceptan valores numericos.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "TDS - SBL")
                e.Cancel = True
                Exit Sub
            End If
            Dim iCan As Integer
            iCan = CInt(e.FormattedValue.ToString())
            If iCan < 1 Then
                MsgBox("Solo se aceptan valores positivos.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "TDS - SBL")
                e.Cancel = True
                Exit Sub
            End If
            If Not HayExistencia(iCan) Then
                e.Cancel = False
                Exit Sub
            End If
        End If
    End Sub
    Private Sub dtaGrid_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtaGrid.CellValueChanged
        If e.RowIndex < 0 Then
            Exit Sub
        End If
    End Sub
    Private Sub dtaGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtaGrid.CellContentClick
        Me.Focus()
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim sql As String
        If dtaGrid.Rows.Count = 0 Then
            MsgBox("No hay productos para grabar.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "TDS - SBL")
            txtNumero.Focus()
            Exit Sub
        End If
        'evaluamos consistencia
        ' detalle de documento
        Dim bCant As Boolean = True
        Dim iidx As Integer = 0
        Dim szRet As String
        For i = 0 To dtaGrid.Rows.Count - 1
            If IsNothing(dtaGrid.Rows(i).Cells(0).Value) Then
                Continue For
            End If
            If IsNothing(dtaGrid.Rows(i).Cells(2).Value) Then
                bCant = False
                iidx = i
            End If
            szRet = BuscaProducto(UCase(dtaGrid.Rows(i).Cells(0).Value))
            If szRet.Length = 0 Then
                dtaGrid.Rows(i).Selected = True
                MsgBox("Producto no existe.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "TDS - SBL")
                Exit Sub
            End If
        Next
        If Not bCant Then
            dtaGrid.Rows(iidx).Selected = True
            MsgBox("Revise los datos, no hay consistencia en lo ingresado, falta ingresar cantidad.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "TDS - SBL")
            Exit Sub
        End If
        If bDocExiste Then
            sql = "UPDATE documentos_salida "
            sql += "SET id_cliente = '" & txtRut.Text & "'"
            sql += ",fecha_creacion = '" & FechaGringa(dtpFecIni.Text) & "'"
            sql += ",observaciones = '" & txtObservaciones.Text & "' "
            sql += "WHERE tipo_documento = '" & cmbTipoDoc.Text.Substring(0, 1) & "' "
            sql += "AND id_documento_salida='" & txtNumero.Text & "' "
            sql += "AND id_empresa='" & idEmpresa & "'"
            Call execUpdate(sql, csql)
        Else
            sql = "INSERT INTO documentos_salida (id_documento_salida"
            sql += ",id_empresa"
            sql += ",id_cliente"
            sql += ",tipo_documento"
            sql += ",fecha_creacion"
            sql += ",estado_documento"
            sql += ",observaciones) "
            sql += "VALUES ('" & txtNumero.Text & "'"
            sql += ",'" & idEmpresa & "'"
            sql += ",'" & txtRut.Text & "'"
            sql += ",'" & cmbTipoDoc.Text.Substring(0, 1) & "'"
            sql += ",'" & FechaGringa(dtpFecIni.Text) & "'"
            sql += ",'CRE'"
            sql += ",'" & txtObservaciones.Text & "')"
            Call execUpdate(sql, csql)
        End If
        If bDocExiste Then
            sql = "DELETE FROM documentos_salida_detalles "
            sql += "WHERE tipo_documento = '" & cmbTipoDoc.Text.Substring(0, 1) & "' "
            sql += "AND id_documento_salida = '" & txtNumero.Text & "' "
            sql += "AND id_empresa = '" & idEmpresa & "' "
            Call execUpdate(sql, csql)
        End If
        Dim iCantidad = 0
        ' detalle de documento
        For i = 0 To dtaGrid.Rows.Count - 1
            If IsNothing(dtaGrid.Rows(i).Cells(0).Value) Then
                Continue For
            End If
            If Trim(dtaGrid.Rows(i).Cells(0).Value.ToString).Length > 0 Then
                If Not String.IsNullOrEmpty(dtaGrid.Rows(i).Cells(4).Value.ToString) Then
                    iCantidad = CInt(dtaGrid.Rows(i).Cells(4).Value)
                Else
                    If dtaGrid.Rows(i).Cells(4).Value.ToString = "" Then
                        iCantidad = 0
                    End If
                End If
                sql = "INSERT INTO documentos_salida_detalles (id_documento_salida"
                sql += ",id_empresa"
                sql += ",tipo_documento"
                sql += ",numero_linea"
                sql += ",cod_producto"
                sql += ",cantidad"
                sql += ",cantidad_despachada) "
                sql += "VALUES ('" & txtNumero.Text & "'"
                sql += ",'" & idEmpresa & "'"
                sql += ",'" & cmbTipoDoc.Text.Substring(0, 1) & "'"
                sql += "," & (i + 1)
                sql += ",'" & dtaGrid.Rows(i).Cells(0).Value & "'"
                sql += "," & dtaGrid.Rows(i).Cells(3).Value
                sql += "," & iCantidad & ")"
                Call execUpdate(sql, csql)
            End If
        Next
        LimpiaCampos(True)
    End Sub
    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Dim ret As MsgBoxResult
        ret = MsgBox("Esta seguro de eliminar este documento ??", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SBL")
        If ret = MsgBoxResult.No Then Exit Sub
        If bDocExiste Then
            sql = "DELETE FROM documentos_salida_detalles "
            sql += "WHERE tipo_documento = '" & cmbTipoDoc.Text.Substring(0, 1) & "' "
            sql += "AND id_documento_salida='" & txtNumero.Text & "' "
            sql += "AND id_empresa='" & idEmpresa & "' "
            Call execUpdate(sql, csql)
            sql = "DELETE FROM documentos_salida "
            sql += "WHERE tipo_documento = '" & cmbTipoDoc.Text.Substring(0, 1) & "' "
            sql += "AND id_documento_salida='" & txtNumero.Text & "' "
            sql += "AND id_empresa='" & idEmpresa & "' "
            Call execUpdate(sql, csql)
        End If
        LimpiaCampos(True)
    End Sub
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click

        Dim frm As New frmConsultaLoadDocSalida
        frm.ShowDialog()
        Tag = frm.Tag
        If Tag = "CANCEL" Then
            Exit Sub
        End If
        Dim szArr As String() = Split(Tag, ";")
        cmbTipoDoc.Text = szArr(0)
        txtNumero.Text = szArr(1)
        If BuscarDocumento() Then
            txtRut.Focus()
        End If

    End Sub

    'Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
    '    Dim frm As New frmConsultaLoadDocSalida
    '    Dim arData() As String
    '    If cmbEstado.SelectedIndex = -1 Then
    '        MsgBox("Debe seleccionar estado de documentos.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "TDS - SBL")
    '        Exit Sub
    '    Else
    '        sql = "SELECT valor_parametro "
    '        sql += "FROM parametros "
    '        sql += "WHERE tabla_parametro = 'ECM' "
    '        sql += "AND codigo_parametro = 'ECMSI' "
    '        sql += "AND id_empresa = " & idEmpresa
    '        Dim dR As SqlDataReader = execQuery(sql, csql)
    '        If dR.Read Then
    '            If dR("valor_parametro") = "SI" Then
    '                If cmbEcommerce.SelectedIndex = -1 Then
    '                    MsgBox("Debe seleccionar comercio de documento.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "TDS - SBL")
    '                    dR.Close()
    '                    Exit Sub
    '                Else
    '                    dR.Close()
    '                    gEstado = cmbEstado.SelectedItem.Key
    '                    gEcommerce = cmbEcommerce.SelectedItem.Key
    '                    frm.ShowDialog()
    '                    If frm.Tag = "CANCEL" Then
    '                        Exit Sub
    '                    End If
    '                    arData = Split(frm.Tag, ";")
    '                    cmbTipoDoc.Text = arData(0)
    '                    txtNumero.Text = arData(1)
    '                    BuscarDocumento()
    '                End If
    '            Else
    '                dR.Close()
    '                gEstado = cmbEstado.SelectedItem.Key
    '                gEcommerce = 0
    '                frm.ShowDialog()
    '                If frm.Tag = "CANCEL" Then
    '                    Exit Sub
    '                End If
    '                arData = Split(frm.Tag, ";")
    '                cmbTipoDoc.Text = arData(0)
    '                txtNumero.Text = arData(1)
    '                BuscarDocumento()
    '            End If
    '        Else
    '            dR.Close()
    '            gEstado = cmbEstado.SelectedItem.Key
    '            gEcommerce = 0
    '            frm.ShowDialog()
    '            If frm.Tag = "CANCEL" Then
    '                Exit Sub
    '            End If
    '            arData = Split(frm.Tag, ";")
    '            cmbTipoDoc.Text = arData(0)
    '            txtNumero.Text = arData(1)
    '            BuscarDocumento()
    '        End If
    '    End If
    'End Sub
    Private Sub btnPegar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not Clipboard.ContainsText Then
            Exit Sub
        End If
        Dim aLineas() As String
        Dim aCampos() As String
        aLineas = Split(Clipboard.GetText(), vbCrLf)
        For i = 0 To aLineas.Length - 1
            If Trim(aLineas(i)).Length = 0 Then Continue For
            aCampos = Split(aLineas(i), vbTab)
            If aCampos.Length > 3 Then
                If aCampos(0) = "Fecha" Then
                    Continue For
                End If
                Dim iTmp As Integer
                Dim row0(3) As String
                iTmp = CInt(aCampos(5))
                If iTmp < 0 Then
                    iTmp = iTmp * -1
                End If
                row0(0) = aCampos(1)
                row0(1) = aCampos(2)
                row0(2) = iTmp.ToString
                dtaGrid.Rows.Add(row0)
            End If
        Next
    End Sub
    Private Sub erpBusquedas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles erpBusquedas.Click
        Me.Focus()
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim fa As frmAddItemSalida = New frmAddItemSalida
        fa.Tag = txtNumero.Text
        fa.frmPadre = Me
        fa.ShowDialog()
        fa.Dispose()
    End Sub
    Private Sub btnELimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnELimina.Click
        Dim sztxt As String = ""
        If dtaGrid.SelectedRows.Count > 0 Then
            For Each dg In dtaGrid.SelectedRows
                sztxt += IIf(sztxt.Length > 0, vbCrLf, "") & dg.Cells(0).Value
            Next
            Dim resp As Integer = MsgBox("¿ esta seguro de eliminar el codigo " & sztxt, MsgBoxStyle.Question + MsgBoxStyle.YesNo, "TDS - SBL")
            If resp = 6 Then
                For Each dg In dtaGrid.SelectedRows
                    dtaGrid.Rows.Remove(dg)
                Next
            End If
        End If
    End Sub
    Private Sub erpResultados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles erpResultados.Click
        Me.Focus()
    End Sub
    Private Sub txtRut_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRut.KeyUp
        If e.KeyCode = Keys.Enter Then
            If txtRut.Text.Trim.Length < 2 Then
                Exit Sub
            End If
            If Not ValidaRut(txtRut.Text) Then
                MsgBox("Rut incorrecto.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Entradas TDS-SBL")
                txtRut.Text = ""
                txtRut.Focus()
                Exit Sub
            End If
            If BuscaCliente() Then
                txtObservaciones.Focus()
            Else
                MsgBox("Rut del proveedor no existe.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Entradas TDS-SBL")
                txtRut.Text = ""
                txtRut.Focus()
            End If
        End If
    End Sub
    Private Sub cmbTipoDoc_TextChanged(sender As Object, e As EventArgs) Handles cmbTipoDoc.TextChanged
        txtNumero.Text = findFolios("2").ToString
        txtNumero.Focus()
    End Sub
End Class