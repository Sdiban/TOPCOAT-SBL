Imports System.Data.SqlClient
Public Class frmMantProveedor
    Private Sub cargarDatos()
        Dim dt As New DataTable
        sql = "Select * "
        sql += "From proveedores "
        sql += "order by rut"
        dt = execDataSet(sql, csql).Tables("Sql")
        dtaGrid.Enabled = True
        dtaGrid.AutoGenerateColumns = False
        dtaGrid.Columns.Clear()
        dtaGrid.Columns.Add("rut", "RUT PROV.")
        dtaGrid.Columns.Add("nombre", "NOMBRE PROV.")
        dtaGrid.Columns(0).DataPropertyName = "rut"
        dtaGrid.Columns(1).DataPropertyName = "nombre"
        dtaGrid.Columns(0).Width = 100
        dtaGrid.Columns(1).Width = 220
        dtaGrid.DataSource = dt
    End Sub
    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        gsOperador = "A"
        txtId.Enabled = True
        txtNombre.Enabled = True
        txtId.Focus()
        dtaGrid.Enabled = False
        btnSave.Enabled = True
        btnDel.Enabled = False
    End Sub
    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If dtaGrid.SelectedRows.Count > 0 Then
            Dim resp As Integer = MsgBox("¿ esta seguro de eliminar el proveedor seleccionado ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WMS SCB")
            If resp = 6 Then
                Dim dg As DataGridViewRow
                For Each dg In dtaGrid.SelectedRows
                    sql = "select * "
                    sql += "from documentos_entrada "
                    sql += "where id_proveedor = '" & dg.Cells("rut").Value & "'"
                    Dim dr As SqlDataReader = execQuery(sql, csql)
                    If Not dr.Read Then
                        dr.Close()
                        sql = "delete from proveedores "
                        sql += "where rut = '" & dg.Cells("rut").Value & "'"
                        Call execUpdate(sql, csql)
                    Else
                        MsgBox("El proveedor seleccionado no puede ser eliminado.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Proveedores TDS-SBL")
                    End If
                    dr.Close()
                Next
                Call btnUndo_Click(sender, e)
                Call cargarDatos()
            End If
        End If
    End Sub
    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        txtId.Text = ""
        txtNombre.Text = ""
        txtId.Enabled = False
        txtNombre.Enabled = False
        btnCrear.Enabled = True
        btnDel.Enabled = False
        btnUndo.Enabled = True
        btnSave.Enabled = False
        Call cargarDatos()
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Trim(txtId.Text) = "" Then
            MsgBox("Debe ingresar el rut del proveedor.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Proveedores TDS-SBL")
            txtId.Focus()
            Exit Sub
        End If
        If Trim(txtNombre.Text) = "" Then
            MsgBox("Debe ingresar el nombre del proveedor.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Proveedores TDS-SBL")
            txtNombre.Focus()
            Exit Sub
        End If
        If gsOperador = "A" Then
            sql = "select * "
            sql += "from proveedores "
            sql += "where rut = '" & txtId.Text & "'"
            Dim dr As SqlDataReader = execQuery(sql, csql)
            If dr.Read Then
                dr.Close()
                MsgBox("El proveedor ingresado ya existen.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Proveedores TDS-SBL")
                Exit Sub
            End If
            dr.Close()
            Me.Cursor = Cursors.WaitCursor
            sql = "insert into proveedores(rut"
            sql += ", nombre) "
            sql += "values ('" & txtId.Text & "'"
            sql += ",'" & txtNombre.Text & "')"
            Call execUpdate(sql, csql)
            Me.Cursor = Cursors.Default
        Else
            Me.Cursor = Cursors.WaitCursor
            sql = "update proveedores "
            sql += "set nombre = '" & txtNombre.Text & "' "
            sql += "where rut = '" & txtId.Text & "'"
            Call execUpdate(sql, csql)
            Me.Cursor = Cursors.Default
        End If
        Call btnUndo_Click(sender, e)
        Call cargarDatos()
    End Sub
    Private Sub dtaGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtaGrid.CellDoubleClick
        If dtaGrid.SelectedRows.Count > 0 Then
            gsOperador = "M"
            sql = "select * "
            sql += "from proveedores "
            sql += "where rut = '" & dtaGrid.SelectedRows(0).Cells("rut").Value & "'"
            Dim dr As SqlDataReader = execQuery(sql, csql)
            If dr.Read Then
                txtId.Text = dr("rut")
                txtNombre.Text = dr("nombre")
                txtNombre.Enabled = True
                txtNombre.Focus()
                operador = "M"
                dtaGrid.Enabled = False
                btnDel.Enabled = False
                btnSave.Enabled = True
            Else
                MsgBox("Error al cargar los datos del proveedor.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Proveedores TDS-SBL")
            End If
            dr.Close()
        End If
    End Sub
    Private Sub dtaGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtaGrid.CellContentClick
        Me.Focus()
    End Sub
    Private Sub dtaGrid_Click(sender As Object, e As EventArgs) Handles dtaGrid.Click
        txtId.Text = ""
        txtNombre.Text = ""
        txtId.Enabled = False
        txtNombre.Enabled = False
        btnDel.Enabled = True
        Me.Focus()
    End Sub
    Private Sub erpResultados_Click(sender As Object, e As EventArgs) Handles erpResultados.Click
        Me.Focus()
    End Sub
    Private Sub erpEdicion_Click(sender As Object, e As EventArgs) Handles erpEdicion.Click
        Me.Focus()
    End Sub
    Private Sub frmMantCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cargarDatos()
    End Sub
    'Private Sub txtId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtId.KeyPress
    '    Dim lDigitoVerificador As String
    '    Dim lRut As String
    '    Dim lRetorno As String
    '    Dim lPosicion As Integer
    '    If Trim(txtId.Text) <> "" And e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
    '        lPosicion = InStr(Trim(txtId.Text), "-")
    '        If Trim(txtId.Text).Length > 2 And lPosicion > 0 Then
    '            lPosicion = InStr(Trim(txtId.Text), "-")
    '            lRut = Mid(Trim(txtId.Text), 1, lPosicion - 1)
    '            lDigitoVerificador = Mid(Trim(txtId.Text), lPosicion + 1, 1)
    '            lRetorno = modulo11(Trim(lRut))
    '            If lRetorno <> lDigitoVerificador Then
    '                MsgBox("Rut ingresado existe, favor validar.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Proveedores TDS-SBL")
    '                txtId.Text = ""
    '                txtId.Focus()
    '            Else
    '                If BuscaProveedor() Then
    '                    txtNombre.Focus()
    '                Else
    '                    txtId.Enabled = False
    '                    txtNombre.Focus()
    '                End If
    '            End If
    '        Else
    '            MsgBox("Rut ingresado existe, favor validar.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Proveedores TDS-SBL")
    '            txtId.Text = ""
    '            txtId.Focus()
    '        End If
    '    End If
    'End Sub
    'Private Sub txtId_Leave(sender As Object, e As EventArgs) Handles txtId.Leave
    '    Dim lDigitoVerificador As String
    '    Dim lRut As String
    '    Dim lRetorno As String
    '    Dim lPosicion As Integer
    '    lPosicion = InStr(Trim(txtId.Text), "-")
    '    If Trim(txtId.Text).Length > 2 And lPosicion > 0 Then
    '        lPosicion = InStr(Trim(txtId.Text), "-")
    '        lRut = Mid(Trim(txtId.Text), 1, lPosicion - 1)
    '        lDigitoVerificador = Mid(Trim(txtId.Text), lPosicion + 1, 1)
    '        lRetorno = modulo11(Trim(lRut))
    '        If lRetorno <> lDigitoVerificador Then
    '            MsgBox("Rut ingresado existe, favor validar.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Proveedores TDS-SBL")
    '            txtId.Text = ""
    '            txtId.Focus()
    '        Else
    '            If BuscaProveedor() Then
    '                txtNombre.Focus()
    '            Else
    '                txtId.Enabled = False
    '                txtNombre.Focus()
    '            End If
    '        End If
    '    Else
    '        MsgBox("Rut ingresado existe, favor validar.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Proveedores TDS-SBL")
    '        txtId.Text = ""
    '        txtId.Focus()
    '    End If
    'End Sub
    Function BuscaProveedor() As Boolean
        Try
            Dim sql As String = ""
            sql = "Select * "
            sql += "From proveedores "
            sql += "where rut = '" & txtId.Text & "'"
            Dim dR As SqlDataReader = execQuery(sql, csql)
            If dR.Read Then ' cargamos datos
                MsgBox("Rut ingresado existe, favor validar.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Proveedores TDS-SBL")
                txtId.Text = ""
                txtId.Focus()
                dR.Close()
                Return False
            End If
            dR.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
        Return True
    End Function
    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        txtNombre.Text = UCase(txtNombre.Text)
        txtNombre.SelectionStart = Me.txtNombre.Text.Length + 1
    End Sub
End Class