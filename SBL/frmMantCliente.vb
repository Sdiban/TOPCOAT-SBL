Imports System.Data.SqlClient
Public Class frmMantCliente
    Dim szCi As String = ""
    Dim szCo As String = ""
    Dim szRe As String = ""
    Dim DireccionAux As String = ""
    Private Sub cargarDatos()
        Dim dt As New DataTable
        sql = "Select * "
        sql += "from get_clientes() "
        sql += "order by id_cliente, direccion"
        dt = execDataSet(sql, csql).Tables("Sql")
        dtaGrid.Enabled = True
        dtaGrid.AutoGenerateColumns = False
        dtaGrid.Columns.Clear()
        dtaGrid.Columns.Add("id_cliente", "RUT CLIENTE")
        dtaGrid.Columns.Add("nombre", "NOMBRE CLIENTE")
        dtaGrid.Columns.Add("direccion", "DIRECCION")
        dtaGrid.Columns.Add("ciudad", "CIUDAD")
        dtaGrid.Columns.Add("comuna", "COMUNA")
        dtaGrid.Columns.Add("id_ciudad", "ID CIUDAD")
        dtaGrid.Columns.Add("Id_comuna", "ID COMUNA")
        dtaGrid.Columns(0).DataPropertyName = "id_cliente"
        dtaGrid.Columns(1).DataPropertyName = "nombre"
        dtaGrid.Columns(2).DataPropertyName = "direccion"
        dtaGrid.Columns(3).DataPropertyName = "ciudad"
        dtaGrid.Columns(4).DataPropertyName = "comuna"
        dtaGrid.Columns(5).DataPropertyName = "id_ciudad"
        dtaGrid.Columns(6).DataPropertyName = "id_comuna"
        dtaGrid.Columns(0).Width = 100
        dtaGrid.Columns(1).Width = 200
        dtaGrid.Columns(2).Width = 200
        dtaGrid.Columns(3).Width = 100
        dtaGrid.Columns(4).Width = 100
        dtaGrid.Columns(5).Visible = False
        dtaGrid.Columns(6).Visible = False
        dtaGrid.DataSource = dt
    End Sub
    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        gsOperador = "A"
        txtId.Enabled = True
        txtNombre.Enabled = True
        txtDireccion.Enabled = True
        cmbCiudad.Enabled = True
        cmbComuna.Enabled = True
        txtId.Focus()
        dtaGrid.Enabled = False
        btnSave.Enabled = True
        btnDel.Enabled = False
        Call cargaCiudad(cmbCiudad, "", "")

    End Sub
    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If dtaGrid.SelectedRows.Count > 0 Then
            Dim resp As Integer = MsgBox("¿ esta seguro de eliminar el cliente seleccionado ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WMS SCB")
            If resp = 6 Then
                Dim id As String = ""
                Dim dg As DataGridViewRow
                For Each dg In dtaGrid.SelectedRows
                    id = dg.Cells(0).Value
                    sql = "SELECT * "
                    sql += "FROM documentos_salida "
                    sql += "WHERE id_cliente = '" & id & "'"
                    Dim dr As SqlDataReader = execQuery(sql, csql)
                    If dr.Read Then
                        MsgBox("El cliente seleccionado no puede ser eliminado.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Clientes TDS-SBL")
                    Else
                        dr.Close()
                        sql = "delete from clientes "
                        sql += "where id_cliente = '" & id & "'"
                        Call execUpdate(sql, csql)
                    End If
                    dr.Close()
                Next
                Call cargarDatos()
            End If
        End If
    End Sub
    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        txtId.Text = ""
        txtNombre.Text = ""
        txtDireccion.Text = ""
        cmbComuna.Items.Clear()
        cmbCiudad.Items.Clear()
        txtId.Enabled = False
        txtNombre.Enabled = False
        txtDireccion.Enabled = False
        cmbCiudad.Enabled = False
        cmbComuna.Enabled = False
        btnCrear.Enabled = True
        btnDel.Enabled = False
        btnSave.Enabled = False
        Call cargarDatos()
        Call cargaCiudad(cmbCiudad, "", "")

    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Trim(txtId.Text) = "" Then
            MsgBox("Debe ingresar el rut del cliente.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Clientes TDS-SBL")
            txtId.Focus()
            Exit Sub
        End If
        If Trim(txtNombre.Text) = "" Then
            MsgBox("Debe ingresar el nombre del cliente.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Clientes TDS-SBL")
            txtNombre.Focus()
            Exit Sub
        End If
        If Trim(txtDireccion.Text) = "" Then
            MsgBox("Debe ingresar la dirección del cliente.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Clientes TDS-SBL")
            txtDireccion.Focus()
            Exit Sub
        End If
        If gsOperador = "A" Then
            sql = "SELECT * "
            sql += "FROM cliente_direccion "
            sql += "WHERE id_cliente = '" & txtId.Text & "'"
            sql += "AND direccion = '" & txtDireccion.Text & "'"
            Dim dr As SqlDataReader = execQuery(sql, csql)
            If dr.Read Then
                dr.Close()
                MsgBox("El cliente y direccion ingresado ya existen.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Clientes TDS-SBL")
                Exit Sub
            End If
            dr.Close()
            Me.Cursor = Cursors.WaitCursor
            sql = "INSERT INTO clientes(id_cliente, nombre) "
            sql += "VALUES ('" & txtId.Text & "','" & txtNombre.Text & "')"
            Call execUpdate(sql, csql)
            sql = "INSERT INTO cliente_direccion (id_cliente,"
            sql += "direccion,"
            sql += "id_ciudad,"
            sql += "id_comuna,"
            sql += "id_region) "
            sql += "VALUES ('" & txtId.Text & "'"
            sql += ",'" & txtDireccion.Text & "'"
            sql += ",'" & cmbCiudad.SelectedItem.Key & "'"
            sql += ",'" & cmbComuna.SelectedItem.Key & "'"
            sql += ",'" & szRe & "')"
            Call execUpdate(sql, csql)
            Me.Cursor = Cursors.Default
        Else
            Me.Cursor = Cursors.WaitCursor
            sql = "UPDATE clientes "
            sql += "SET nombre = '" & txtNombre.Text & "' "
            sql += "WHERE id_cliente = '" & txtId.Text & "'"
            Call execUpdate(sql, csql)
            sql = "UPDATE cliente_direccion "
            sql += "SET direccion = '" & txtDireccion.Text & "',"
            sql += "id_ciudad = '" & cmbCiudad.Items(cmbCiudad.SelectedIndex).Key & "',"
            sql += "id_comuna = '" & cmbComuna.Items(cmbComuna.SelectedIndex).Key & "',"
            sql += "id_region = '" & szRe & "' "
            sql += "WHERE direccion = '" & DireccionAux & "' "
            sql += "AND id_cliente = '" & txtId.Text & "'"
            Call execUpdate(sql, csql)
            Me.Cursor = Cursors.Default
        End If
        Call btnUndo_Click(sender, e)
        Call cargarDatos()
    End Sub
    Private Sub dtaGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtaGrid.CellDoubleClick
        If dtaGrid.SelectedRows.Count > 0 Then
            gsOperador = "M"
            sql = "SELECT * "
            sql += "FROM get_clientes() "
            sql += "WHERE id_cliente = '" & dtaGrid.SelectedRows(0).Cells("id_cliente").Value & "' "
            sql += "AND direccion = '" & dtaGrid.SelectedRows(0).Cells("direccion").Value & "'"
            Dim dr As SqlDataReader = execQuery(sql, csql)
            If dr.Read Then
                txtId.Text = dtaGrid.SelectedRows(0).Cells("id_cliente").Value
                txtNombre.Text = dtaGrid.SelectedRows(0).Cells("nombre").Value
                txtDireccion.Text = dtaGrid.SelectedRows(0).Cells("direccion").Value
                DireccionAux = dtaGrid.SelectedRows(0).Cells("direccion").Value
                szRe = dr("region")
                dr.Close()
                Call cargaCiudad(cmbCiudad, "", dtaGrid.SelectedRows(0).Cells("id_ciudad").Value)
                Call cargaComuna(cmbComuna, dtaGrid.SelectedRows(0).Cells("id_ciudad").Value, "", dtaGrid.SelectedRows(0).Cells("id_comuna").Value)
                txtNombre.Enabled = True
                txtDireccion.Enabled = True
                cmbCiudad.Enabled = True
                cmbComuna.Enabled = True
                txtNombre.Focus()
                dtaGrid.Enabled = False
                btnSave.Enabled = True
                btnDel.Enabled = False
            Else
                MsgBox("Error al cargar los datos del cliente.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Clientes TDS-SBL")
            End If
            dr.Close()
        End If
    End Sub
    Private Sub dtaGrid_Click(sender As Object, e As EventArgs) Handles dtaGrid.Click
        txtId.Text = ""
        txtNombre.Text = ""
        txtDireccion.Text = ""
        cmbComuna.Items.Clear()
        cmbCiudad.Items.Clear()
        txtId.Enabled = False
        txtNombre.Enabled = False
        txtDireccion.Enabled = False
        cmbCiudad.Enabled = False
        cmbComuna.Enabled = False
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
    Function BuscaCliente() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT * "
            sql += "FROM get_clientes() "
            sql += "WHERE id_cliente = '" & txtId.Text & "'"
            Dim dR As SqlDataReader = execQuery(sql, csql)
            If dR.Read Then  'Cargamos datos
                txtNombre.Text = dR("nombre")
                txtDireccion.Text = dR("direccion")
                szCi = dR("id_ciudad")
                szCo = dR("id_comuna")
                dR.Close()
                Call cargaCiudad(cmbCiudad, "", szCi)
                Call cargaComuna(cmbComuna, szCi, "", szCo)
                If txtDireccion.Text <> "" Then
                    For i = 0 To cmbCiudad.Items.Count - 1
                        If cmbCiudad.Items(i).Key = szCi Then
                            cmbCiudad.SelectedIndex = i
                            Exit For
                        End If
                    Next
                    For i = 0 To cmbComuna.Items.Count - 1
                        If cmbComuna.Items(i).Key = szCo Then
                            cmbComuna.SelectedIndex = i
                            Exit For
                        End If
                    Next
                End If
                txtDireccion.Focus()
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
    '                MsgBox("Debe ingresar un rut valido.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Clientes TDS-SBL")
    '                txtId.Text = ""
    '                txtId.Focus()
    '            Else
    '                If BuscaCliente() Then
    '                    txtDireccion.Focus()
    '                Else
    '                    txtId.Enabled = False
    '                    txtNombre.Text = ""
    '                    txtDireccion.Text = ""
    '                    Call cargaCiudad(cmbCiudad, "", "")
    '                    txtNombre.Focus()
    '                End If
    '            End If
    '        Else
    '            MsgBox("Debe ingresar un rut valido.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Clientes TDS-SBL")
    '            txtId.Text = ""
    '            txtId.Focus()
    '        End If
    '        Call cargaCiudad(cmbCiudad, "", "")
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
    '            MsgBox("Debe ingresar un rut valido.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Clientes TDS-SBL")
    '            txtId.Text = ""
    '            txtId.Focus()
    '        Else
    '            If BuscaCliente() Then
    '                txtDireccion.Focus()
    '            Else
    '                txtId.Enabled = False
    '                txtNombre.Text = ""
    '                txtDireccion.Text = ""
    '                Call cargaCiudad(cmbCiudad, "", "")
    '                txtNombre.Focus()
    '            End If
    '        End If
    '    Else
    '        MsgBox("Debe ingresar un rut valido.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Clientes TDS-SBL")
    '        txtId.Text = ""
    '        txtId.Focus()
    '    End If
    '    Call cargaCiudad(cmbCiudad, "", "")
    'End Sub
    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        txtNombre.Text = UCase(txtNombre.Text)
        txtNombre.SelectionStart = Me.txtNombre.Text.Length + 1
    End Sub
    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If txtNombre.Text <> "" And e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            txtDireccion.Focus()
        End If
    End Sub
    Private Sub txtDireccion_TextChanged(sender As Object, e As EventArgs) Handles txtDireccion.TextChanged
        txtDireccion.Text = UCase(txtDireccion.Text)
        txtDireccion.SelectionStart = Me.txtDireccion.Text.Length + 1
    End Sub
    Private Sub txtDireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDireccion.KeyPress
        If txtDireccion.Text <> "" And e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            cmbCiudad.Focus()
        End If
    End Sub
    Private Sub cmbCiudad_TextChanged(sender As Object, e As EventArgs) Handles cmbCiudad.TextChanged
        If cmbCiudad.Text <> "" Then
            sql = "select * "
            sql += "from ciudad "
            sql += "WHERE id_ciudad = '" & cmbCiudad.SelectedItem.Key & "'"
            Dim dr As SqlDataReader = execQuery(sql, csql)
            If dr.Read Then
                szRe = dr("region")
            End If
            dr.Close()
            Call cargaComuna(cmbComuna, cmbCiudad.SelectedItem.Key, "", "")
        End If
    End Sub


End Class