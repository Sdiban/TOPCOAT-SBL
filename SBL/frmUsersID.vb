Imports System.Data.SqlClient

Public Class frmUsersID

    Private Sub cargarEstados()
        cboEstado.Items.Add("ACTIVO")
        cboEstado.Items.Add("INACTIVO")
    End Sub

    Private Sub cargarDatos()
        Dim dt As New DataTable

        sql = "Select * From usuarios_acceso order by id_usuario"
        dt = execDataSet(sql, csql).Tables("Sql")

        dtaGrid.AutoGenerateColumns = False
        dtaGrid.Columns.Clear()

        dtaGrid.Columns.Add("id_usuario", "USUARIO") '0
        dtaGrid.Columns.Add("nombre_usuario", "NOMBRE") '1
        dtaGrid.Columns.Add("rfid_usuario", "RFID") '2

        dtaGrid.Columns(0).DataPropertyName = "id_usuario"
        dtaGrid.Columns(1).DataPropertyName = "nombre_usuario"
        dtaGrid.Columns(2).DataPropertyName = "rfid_usuario"

        dtaGrid.Columns(0).Width = 100
        dtaGrid.Columns(1).Width = 200
        dtaGrid.Columns(2).Width = 100

        dtaGrid.DataSource = dt
    End Sub

    Private Sub frmUsersID_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ReleaseVentana(Me)
    End Sub

    Private Sub frmUsersID_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call cargarEstados()
        Call cargarDatos()
    End Sub

    Private Sub btnCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrear.Click
        operador = "A"
        txtUsuario.Enabled = True
        txtNombre.Enabled = True
        txtPass1.Enabled = True
        txtPass2.Enabled = True
        cboEstado.Enabled = True
        txtUsuario.Focus()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Trim(txtUsuario.Text) = "" Then
            erpEdicion.FooterText = "Debe ingresar el usuario"
            tmrMensaje.Enabled = True
            txtUsuario.Focus()
            Exit Sub
        End If
        If Trim(txtNombre.Text) = "" Then
            erpEdicion.FooterText = "Debe ingresar el nombre del usuario"
            tmrMensaje.Enabled = True
            txtNombre.Focus()
            Exit Sub
        End If
        If Trim(txtPass1.Text) = "" Then
            erpEdicion.FooterText = "Debe ingresar la contraseña del usuario"
            tmrMensaje.Enabled = True
            txtPass1.Focus()
            Exit Sub
        End If
        If Trim(txtPass2.Text) = "" Then
            erpEdicion.FooterText = "Debe ingresar la confirmacion de contraseña para el usuario"
            tmrMensaje.Enabled = True
            txtPass2.Focus()
            Exit Sub
        End If
        If Trim(txtPass1.Text) <> Trim(txtPass2.Text) Then
            erpEdicion.FooterText = "Las contraseñas ingresadas no coinciden, favor revise"
            tmrMensaje.Enabled = True
            txtPass2.Focus()
            Exit Sub
        End If
        If Trim(cboEstado.Text) = "" Then
            erpEdicion.FooterText = "Debe seleccionar el estado del usuario"
            tmrMensaje.Enabled = True
            cboEstado.Focus()
            Exit Sub
        End If
        If operador = "A" Then
            sql = "select * from usuarios_acceso where id_usuario = '" & txtUsuario.Text & "'"
            Dim dr As SqlDataReader = execQuery(sql, csql)
            If dr.Read Then
                dr.Close()
                erpEdicion.Text = "El usuario ingresado ya existe"
                tmrMensaje.Enabled = True
                Exit Sub
            End If
            dr.Close()
            sql = "insert into usuarios_acceso(id_usuario,nombre_usuario,clave_usuario,estado_usuario) values("
            sql += "'" & txtUsuario.Text & "'"
            sql += ",'" & txtNombre.Text & "'"
            sql += ",'" & txtPass1.Text & "'"
            If cboEstado.Text = "ACTIVO" Then
                sql += ",'ACT')"
            Else
                sql += ",'INA')"
            End If
            Call execUpdate(sql, csql)
        Else
            sql = "update usuarios_acceso set nombre_usuario = '" & txtNombre.Text & "'"
            sql += ",clave_usuario = '" & txtPass1.Text & "'"
            If cboEstado.Text = "ACTIVO" Then
                sql += ",estado_usuario = 'ACT'"
            Else
                sql += ",estado_usuario = 'INA'"
            End If
            sql += " where id_usuario = '" & txtUsuario.Text & "'"
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
        txtUsuario.Text = ""
        txtNombre.Text = ""
        txtPass1.Text = ""
        txtPass2.Text = ""
        cboEstado.SelectedIndex = -1
        txtUsuario.Enabled = False
        txtNombre.Enabled = False
        txtPass1.Enabled = False
        txtPass2.Enabled = False
        cboEstado.Enabled = False
        Call cargarDatos()
    End Sub

    Private Sub dtaGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtaGrid.DoubleClick
        If dtaGrid.SelectedRows.Count > 0 Then
            sql = "select * from usuarios_acceso where id_usuario = '" & dtaGrid.SelectedRows(0).Cells(0).Value & "'"
            Dim dr As SqlDataReader = execQuery(sql, csql)
            If dr.Read Then
                txtUsuario.Text = dr("id_usuario")
                txtNombre.Text = dr("nombre_usuario")
                txtPass1.Text = dr("clave_usuario")
                txtPass2.Text = dr("clave_usuario")
                Select Case dr("estado_usuario")
                    Case "ACT"
                        cboEstado.Text = "ACTIVO"
                    Case Else
                        cboEstado.Text = "INACTIVO"
                End Select
                If username.ToUpper = "ADM" Or username.ToUpper = "ADMIN" Then
                    txtPass1.ValidationStyle.PasswordChar = ""
                    txtPass2.ValidationStyle.PasswordChar = ""
                End If
                txtNombre.Enabled = True
                txtPass1.Enabled = True
                txtPass2.Enabled = True
                cboEstado.Enabled = True
                txtUsuario.Focus()
            Else
                erpEdicion.FooterText = "Error al cargar los datos del usuario"
                tmrMensaje.Enabled = True
            End If
            dr.Close()
        End If
    End Sub

    Private Sub dtaGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtaGrid.CellContentClick

    End Sub
End Class

