Option Explicit On
Imports System.Data.SqlClient
Public Class frmLoadDocEntrada
    Public nDoc As String = "-1"
    Public jdt As DataTable
    Public jrow As DataRow
    Dim bDocExiste As Boolean = False
    Dim bAgregaProv As Boolean = False
    Sub LimpiaGrilla()
        erpResultados.FooterText = ""
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
        If blimpianumero Then
            txtNumero.Text = ""
        End If
        txtCliente.Text = ""
        txtRut.Text = ""
        dtpFecIni.Text = ""
        txtObservaciones.Text = ""
        txtCliente.Enabled = False
        txtObservaciones.Enabled = False
        txtRut.Enabled = False
        dtpFecIni.Enabled = False
        txtNumero.Enabled = True
        cmbTipoDoc.Enabled = True
        cmbEstado.Enabled = True
        btnSave.Enabled = False
        btnDel.Enabled = False
        dtaGrid.Enabled = False
        dtaGrid.DataSource = Nothing
        erpBusquedas.FooterText = ""
        LimpiaGrilla()
        jdt.Rows.Clear()
        dtaGrid.ReadOnly = False
        txtNumero.Focus()
        btnAprobar.Enabled = False
    End Sub
    Sub CargaGrilla()
        Dim ds As New DataSet
        Dim dta As New DataTable
        erpResultados.FooterText = ""
        sql = "SELECT cod_producto"
        sql += ",codigoint"
        sql += ",desc_producto"
        sql += ",cantidad"
        sql += ",cantidad_recibida "
        sql += "FROM get_documentos_entrada() "
        sql += "WHERE id_empresa = '" & idEmpresa & "' "
        sql += "AND tipo_documento = '" & cmbTipoDoc.SelectedItem.Key & "' "
        sql += "AND id_documento_entrada = '" & txtNumero.Text & "'"
        dta.TableName = "documentos_entrada"
        Try
            jdt.Clear()
            Dim dR As SqlDataReader = execQuery(sql, csql)
            While dR.Read
                jrow = jdt.NewRow()
                jrow("cod_producto") = dR("cod_producto")
                jrow("codigoint") = dR("codigoint")
                jrow("desc_producto") = dR("desc_producto")
                jrow("cantidad") = dR("cantidad")
                jrow("cantidad_recibida") = dR("cantidad_recibida")
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
            sql += "FROM documentos_entrada "
            sql += "WHERE id_empresa = '" & idEmpresa & "' "
            sql += "AND tipo_documento = '" & cmbTipoDoc.SelectedItem.Key & "' "
            sql += "AND id_documento_entrada = '" & txtNumero.Text & "'"
            Dim dR As SqlDataReader = execQuery(sql, csql)
            If dR.Read Then ' cargamos datos
                erpBusquedas.FooterText = ""
                If dR("estado_documento") = "CER" Then
                    dtaGrid.ReadOnly = True
                    txtCliente.Enabled = False
                    txtRut.Enabled = False
                    dtpFecIni.Enabled = False
                    btnSave.Enabled = False
                    txtObservaciones.Enabled = False
                    btnDel.Enabled = False
                    dtaGrid.Enabled = False
                    txtNumero.Enabled = False
                    cmbTipoDoc.Enabled = False
                    btnAdd.Enabled = False
                    btnELimina.Enabled = False
                Else
                    dtaGrid.ReadOnly = False
                    txtNumero.Enabled = True
                    cmbTipoDoc.Enabled = True
                    txtCliente.Enabled = True
                    txtObservaciones.Enabled = True
                    txtRut.Enabled = True
                    dtpFecIni.Enabled = True
                    btnSave.Enabled = True
                    btnDel.Enabled = True
                    dtaGrid.Enabled = True
                    btnAdd.Enabled = True
                    btnELimina.Enabled = True
                End If
                bDocExiste = True
                txtRut.Text = dR("id_proveedor")
                txtCliente.Text = dR("nombre_proveedor")
                dtpFecIni.Text = dR("fecha_creacion")
                If Not String.IsNullOrEmpty(dR("observaciones").ToString) Then
                    txtObservaciones.Text = dR("observaciones")
                End If
                dR.Close()
                CargaGrilla()
            Else
                dR.Close()
                bDocExiste = False
                txtObservaciones.Enabled = True
                txtCliente.Enabled = True
                txtRut.Enabled = True
                dtpFecIni.Enabled = True
                btnSave.Enabled = True
                dtaGrid.Enabled = True
                btnAdd.Enabled = True
                btnELimina.Enabled = True
                dtaGrid.DataSource = Nothing
                Call CargaEstados(cmbEstado, "DE", "", "CRE")
                cmbEstado.Enabled = False
            End If
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
    Function BuscaProductoEnGrilla(ByVal szProd As String) As Boolean
        Dim i As Integer
        Try
            If dtaGrid.RowCount >= 1 Then
                For i = 0 To dtaGrid.RowCount - 1
                    If i <> dtaGrid.CurrentRow.Index Then
                        If dtaGrid.Rows(i).Cells(0).Value = szProd Then
                            Return True
                        End If
                    End If
                Next
            End If
        Catch ex As InvalidOperationException ' Esta excepcion es por si ocurriera
        End Try
        Return False
    End Function
    Function BuscaProveedor() As Boolean
        Try
            sql = "SELECT nombre "
            sql += "FROM proveedores "
            sql += "WHERE rut = '" & SinPuntos(txtRut.Text) & "'"
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
    Sub GrabaProveedor()
        If BuscaProveedor() Then
            sql = "UPDATE proveedores "
            sql += "SET nombre = '" & txtCliente.Text & "' "
            sql += "WHERE rut = '" & txtRut.Text & "'"
            Call execUpdate(sql, csql)
        Else
            sql = "INSERT INTO proveedores (rut"
            sql += ",nombre"
            sql += ",direccion) "
            sql += "VALUES ('" & txtRut.Text & "'"
            sql += ",'" & txtCliente.Text & "'"
            sql += ",'')"
            Call execUpdate(sql, csql)
        End If
    End Sub
    Private Sub frmLoadDocEntrada_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ReleaseVentana(Me)
    End Sub
    Public Sub CreaGrilla()
        dtaGrid.AutoGenerateColumns = False
        dtaGrid.Columns.Clear()
        dtaGrid.Columns.Add("cod_producto", "Código") '0
        dtaGrid.Columns.Add("codigoint", "Código Int.") '0
        dtaGrid.Columns.Add("desc_producto", "Descripción") '0
        dtaGrid.Columns.Add("cantidad", "Cantidad") '0
        dtaGrid.Columns.Add("cantidad_recibida", "Almacenado") '0
        dtaGrid.Columns("cod_producto").DataPropertyName = "cod_producto"
        dtaGrid.Columns("codigoint").DataPropertyName = "codigoint"
        dtaGrid.Columns("desc_producto").DataPropertyName = "desc_producto"
        dtaGrid.Columns("cantidad").DataPropertyName = "cantidad"
        dtaGrid.Columns("cantidad_recibida").DataPropertyName = "cantidad_recibida"
        dtaGrid.Columns("cod_producto").Width = 175
        dtaGrid.Columns("codigoint").Width = 80
        dtaGrid.Columns("desc_producto").Width = 285
        dtaGrid.Columns("cantidad").Width = 60
        dtaGrid.Columns("cantidad_recibida").Width = 80
    End Sub
    Private Sub frmLoadDocEntrada_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CreaGrilla()
        jdt = New DataTable("ParentTable777")
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
        column.ColumnName = "cantidad_recibida"
        column.ReadOnly = True
        jdt.Columns.Add(column)
        dtaGrid.DataSource = jdt
        Call CargaDctoTipo(cmbTipoDoc)
        Call CargaEstados(cmbEstado, "DE")
    End Sub
    Private Sub txtNumero_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNumero.KeyUp
        If e.KeyCode = Keys.Enter Then
            If cmbTipoDoc.SelectedIndex = -1 Then
                MsgBox("Debe seleccionar tipo de documento.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "TDS - SBL")
                Exit Sub
            End If
            If BuscarDocumento() Then
                txtRut.Focus()
            End If
        End If
    End Sub
    Private Sub btnUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUndo.Click
        jdt.Rows.Clear()
        LimpiaCampos(True)
        btnAdd.Enabled = False
        btnELimina.Enabled = False
    End Sub
    Private Sub ElButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ElButton1.Click
        Me.Close()
    End Sub
    Private Sub dtaGrid_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtaGrid.CellEndEdit
        dtaGrid.Rows(e.RowIndex).ErrorText = String.Empty
    End Sub
    Private Sub dtaGrid_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dtaGrid.CellValidating
        Dim szRet As String = ""
        erpResultados.FooterText = ""
        Dim headerText As String = dtaGrid.Columns(e.ColumnIndex).HeaderText
        If String.IsNullOrEmpty(e.FormattedValue.ToString()) Then
            Exit Sub
        End If
        If headerText = "Código de Producto" Then
            ' producto ya ingresado
            If BuscaProductoEnGrilla(UCase(e.FormattedValue.ToString())) Then
                MsgBox("Producto ya Ingresado.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "TDS - SBL")
                e.Cancel = True
                Exit Sub
            End If
            szRet = BuscaProducto(UCase(e.FormattedValue.ToString()))
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
            Dim i As Integer
            i = CInt(e.FormattedValue.ToString())
            If i < 1 Then
                MsgBox("Solo se aceptan valores positivos.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "TDS - SBL")
                e.Cancel = True
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
        If dtaGrid.RowCount < 2 Then
            MsgBox("Documento esta vacio.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "TDS - SBL")
            txtCliente.Focus()
            Exit Sub
        End If
        If Trim(txtCliente.Text).Length = 0 Then
            MsgBox("Falta ingresar cliente.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "TDS - SBL")
            txtCliente.Focus()
            Exit Sub
        End If
        If Trim(txtRut.Text).Length = 0 Then
            MsgBox("Falta ingresar rut.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "TDS - SBL")
            txtRut.Focus()
            Exit Sub
        End If
        If dtaGrid.Rows.Count = 0 Then
            MsgBox("No hay productos para grabar.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "TDS - SBL")
            txtRut.Focus()
            Exit Sub
        End If
        GrabaProveedor()
        'evaluamos consistencia, detalle de documento
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
                MsgBox("Productos no existe.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "TDS - SBL")
                Exit Sub
            End If
        Next
        If Not bCant Then
            dtaGrid.Rows(iidx).Selected = True
            MsgBox("Revise los datos, no hay consistencia en lo ingresado, falta ingresar cantidad.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "TDS - SBL")
            Exit Sub
        End If
        If bDocExiste Then
            sql = "UPDATE documentos_entrada "
            sql += "SET id_proveedor = '" & txtRut.Text & "'"
            sql += ",nombre_proveedor = '" & txtCliente.Text & "'"
            sql += ",fecha_creacion='" & FechaGringa(dtpFecIni.Text) & "'"
            sql += ",observaciones='" & txtObservaciones.Text & "' "
            sql += "WHERE tipo_documento = '" & cmbTipoDoc.SelectedItem.Key & "' "
            sql += "AND id_documento_entrada='" & txtNumero.Text & "' "
            sql += "AND id_empresa='" & idEmpresa & "'"
            Call execUpdate(sql, csql)
        Else
            sql = "INSERT INTO documentos_entrada (id_documento_entrada"
            sql += ",id_empresa"
            sql += ",tipo_documento"
            sql += ",id_proveedor"
            sql += ",nombre_proveedor"
            sql += ",fecha_creacion"
            sql += ",estado_documento"
            sql += ",observaciones) "
            sql += "VALUES ('" & txtNumero.Text & "'"
            sql += ",'" & idEmpresa & "'"
            sql += ",'" & cmbTipoDoc.SelectedItem.Key & "'"
            sql += ",'" & SinPuntos(txtRut.Text) & "'"
            sql += ",'" & txtCliente.Text & "'"
            sql += ",'" & FechaGringa(dtpFecIni.Text) & "'"
            sql += ",'CRE'"
            sql += ",'" & txtObservaciones.Text & "')"
            Call execUpdate(sql, csql)
        End If
        If bDocExiste Then
            sql = "DELETE FROM documentos_entrada_detalles "
            sql += "WHERE tipo_documento = '" & cmbTipoDoc.SelectedItem.Key & "' "
            sql += "AND id_documento_entrada='" & txtNumero.Text & "' "
            sql += "AND id_empresa='" & idEmpresa & "' "
            Call execUpdate(sql, csql)
        End If
        Dim iCantidad = 0
        ' detalle de documento
        For i = 0 To dtaGrid.Rows.Count - 1
            If IsNothing(dtaGrid.Rows(i).Cells(0).Value) Then
                Continue For
            End If
            If Trim(dtaGrid.Rows(i).Cells("cod_producto").Value.ToString).Length > 0 Then
                If Not String.IsNullOrEmpty(dtaGrid.Rows(i).Cells("cantidad_recibida").Value.ToString) Then
                    iCantidad = CInt(dtaGrid.Rows(i).Cells("cantidad_recibida").Value)
                Else
                    If dtaGrid.Rows(i).Cells(4).Value.ToString = "" Then
                        iCantidad = 0
                    End If
                End If
                sql = "INSERT INTO documentos_entrada_detalles (id_documento_entrada"
                sql += ",id_empresa"
                sql += ",tipo_documento"
                sql += ",numero_linea"
                sql += ",cod_producto"
                sql += ",cantidad"
                sql += ",cantidad_recibida) "
                sql += "VALUES ('" & txtNumero.Text & "'"
                sql += ",'" & idEmpresa & "'"
                sql += ",'" & cmbTipoDoc.SelectedItem.Key & "'"
                sql += "," & (i + 1)
                sql += ",'" & UCase(dtaGrid.Rows(i).Cells("cod_producto").Value) & "'"
                sql += "," & dtaGrid.Rows(i).Cells("cantidad").Value
                sql += "," & iCantidad & ")"
                Call execUpdate(sql, csql)
            End If
        Next
        LimpiaCampos(True)
    End Sub
    Private Sub txtRut_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRut.KeyUp
        If e.KeyCode = Keys.Enter Then
            If txtRut.Text.Trim.Length < 2 Then
                Exit Sub
            End If
            If Not ValidaRut(txtRut.Text) Then
                MsgBox("Rut incorrecto, favor validar.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "TDS - SBL")
                txtRut.Text = ""
                txtRut.Focus()
                Exit Sub
            End If
            If BuscaProveedor() Then
                txtCliente.Focus()
            Else
                Dim ret As MsgBoxResult
                ret = MsgBox("Rut del proveedor no existe desea agregarlo.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "TDS - SBL")
                If ret = MsgBoxResult.Yes Then
                    txtCliente.Focus()
                Else
                    txtRut.Text = ""
                    txtRut.Focus()
                End If
            End If
        End If
    End Sub
    Private Sub txtCliente_KeyUpClick(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCliente.KeyUp
        If txtCliente.Text.Trim.Length = 0 Then
            Exit Sub
        End If
        If e.KeyCode = Keys.Enter Then
            txtObservaciones.Focus()
        End If
    End Sub
    Private Sub txtObservaciones_KeyUpClick(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtObservaciones.KeyUp
        If e.KeyCode = Keys.Enter Then
            dtpFecIni.Focus()
        End If
    End Sub
    Private Sub dtpFecIni_KeyUpClick(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpFecIni.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnAdd.Focus()
        End If
    End Sub
    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Dim ret As MsgBoxResult
        ret = MsgBox("Esta seguro de eliminar este documento ??", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "TDS - SBL")
        If ret = MsgBoxResult.No Then
            Exit Sub
        End If
        If bDocExiste Then
            sql = "DELETE FROM documentos_entrada_detalles "
            sql += "WHERE tipo_documento = '" & cmbTipoDoc.Text.Substring(0, 1) & "' "
            sql += "AND id_documento_entrada='" & txtNumero.Text & "' "
            sql += "AND id_empresa='" & idEmpresa & "' "
            Call execUpdate(sql, csql)
            sql = "DELETE FROM documentos_entrada "
            sql += "WHERE tipo_documento = '" & cmbTipoDoc.Text.Substring(0, 1) & "' "
            sql += "AND id_documento_entrada='" & txtNumero.Text & "' "
            sql += "AND id_empresa='" & idEmpresa & "' "
            Call execUpdate(sql, csql)
        End If
        LimpiaCampos(True)
    End Sub
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        Dim frm As New frmConsultaLoadDocEntrada
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
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim fa As frmAddItemEntrada = New frmAddItemEntrada
        fa.Tag = txtNumero.Text
        fa.frmpadre = Me
        fa.ShowDialog()
        fa.Dispose()
    End Sub
    Private Sub btnELimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnELimina.Click
        Dim sztxt As String = ""
        If dtaGrid.SelectedRows.Count > 0 Then
            For Each dg In dtaGrid.SelectedRows
                sztxt += IIf(sztxt.Length > 0, vbCrLf, "") & dg.Cells(0).Value
            Next
            Dim resp As Integer = MsgBox("¿ esta seguro de eliminar el/los codigo(s) " & sztxt & " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "TDS - SBL")
            If resp = 6 Then
                For Each dg In dtaGrid.SelectedRows
                    dtaGrid.Rows.Remove(dg)
                Next
            End If
        End If
    End Sub
    Private Sub erpBusquedas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles erpBusquedas.Click
        Me.Focus()
    End Sub
    Private Sub erpResultados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles erpResultados.Click
        Me.Focus()
    End Sub
    Private Sub cmbTipoDoc_TextChanged(sender As Object, e As EventArgs) Handles cmbTipoDoc.TextChanged
        txtNumero.Text = findFolios("1").ToString
        txtNumero.Focus()
    End Sub
    Private Sub btnAprobar_Click(sender As Object, e As EventArgs) Handles btnAprobar.Click
        Dim dR As SqlDataReader
        If Trim(txtNumero.Text).Length = 0 Or Trim(txtRut.Text).Length = 0 Then
            MsgBox("Debe selecionar la entrada de compras, que desea aprobar.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "TDS - SBL")
            Exit Sub
        End If
        sql = "SELECT * "
        sql += "FROM documentos_entrada "
        sql += "WHERE id_empresa = '" & idEmpresa & "' "
        sql += "AND id_proveedor = '" & txtRut.Text & "' "
        sql += "AND id_documento_entrada = '" & txtNumero.Text & "' "
        sql += "AND estado_documento = 'COM'"
        dR = execQuery(sql, csql)
        If dR.Read Then
            dR.Close()
            sql = "UPDATE documentos_entrada "
            sql += "SET estado_documento = 'CRE'"
            sql += "WHERE id_empresa = '" & idEmpresa & "' "
            sql += "AND id_proveedor = '" & txtRut.Text & "' "
            sql += "AND id_documento_entrada = '" & txtNumero.Text & "'"
            Call execUpdate(sql, csql)
            LimpiaCampos(False)
        Else
            MsgBox("Documento selecionado no pueder ser aprobado, valide su información.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "TDS - SBL")
        End If
    End Sub
    'Private Sub cmbEstado_TextChanged(sender As Object, e As EventArgs) Handles cmbEstado.TextChanged
    '    If cmbEstado.SelectedIndex <> -1 Then
    '        If cmbEstado.SelectedItem.Key = "COM" Then
    '            btnAprobar.Enabled = True
    '        Else
    '            btnAprobar.Enabled = False
    '        End If
    '    End If
    'End Sub
End Class