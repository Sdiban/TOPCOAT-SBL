Imports System.Data.SqlClient
Public Class frmUsersPC
    Private Sub cargarEstados()
        cboEstado.Items.Add("ACTIVO")
        cboEstado.Items.Add("INACTIVO")
    End Sub
    Private Sub cargarPermisos()
        Try
            Dim tAccesos As DataTable = New DataTable
            lstPermisos.Items.Clear()
            Dim Cont As Integer = 0
            Dim dRA As SqlDataReader
            sql = "SELECT * "
            sql += "FROM permisos_aplicacion "
            sql += "ORDER BY desc_permiso"
            tAccesos.Load(execQuery(sql, csql))
            For Cont = 0 To tAccesos.Rows.Count - 1
                lstPermisos.Items.Add(tAccesos.Rows(Cont).Item("desc_permiso"))
                If Trim(txtUsuario.Text) <> "" Then
                    sql = "SELECT * "
                    sql += "FROM usuarios_pc "
                    sql += "WHERE id_usuario = '" & txtUsuario.Text & "' "
                    sql += "AND accesos_usuario Like '%" & tAccesos.Rows(Cont).Item("id_permiso") & "%'"
                    dRA = execQuery(sql, csql)
                    If dRA.Read Then
                        lstPermisos.SetSelected(Cont, True)
                    End If
                    dRA.Close()
                End If
            Next
            tAccesos.Clear()
        Catch ex As Exception
            MsgBox("Error de Aplicación: " & ex.Message)
        End Try
    End Sub
    Private Sub cargarDatos()
        Dim dt As New DataTable
        sql = "SELECT * "
        sql += "FROM usuarios_pc "
        sql += "ORDER BY id_usuario"
        dt = execDataSet(sql, csql).Tables("Sql")
        dtaGrid.AutoGenerateColumns = False
        dtaGrid.Columns.Clear()
        dtaGrid.Columns.Add("id_usuario", "USUARIO") '0
        dtaGrid.Columns.Add("nombre_usuario", "NOMBRE") '1
        dtaGrid.Columns(0).DataPropertyName = "id_usuario"
        dtaGrid.Columns(1).DataPropertyName = "nombre_usuario"
        dtaGrid.Columns(0).Width = 100
        dtaGrid.Columns(1).Width = 200
        dtaGrid.DataSource = dt
    End Sub
    Private Sub frmUsersPC_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ReleaseVentana(Me)
    End Sub
    Private Sub frmUsersID_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call cargarEstados()
        Call cargarDatos()
    End Sub
    Private Sub btnCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrear.Click
        Call btnUndo_Click(sender, e)
        operador = "A"
        txtUsuario.Enabled = True
        txtNombre.Enabled = True
        txtPass1.Enabled = True
        txtPass2.Enabled = True
        cboEstado.Enabled = True
        lstPermisos.Enabled = True
        Call cargarPermisos()
        txtUsuario.Focus()
        btnSave.Enabled = True
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
        If lstPermisos.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar al menos un area de trabajo del usuario", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Usuarios RF")
            lstPermisos.Focus()
            Exit Sub
        End If
        Dim permisos As String = ""
        permisos = ""
        While lstPermisos.SelectedIndex <> -1
            sql = "SELECT id_permiso "
            sql += "FROM permisos_aplicacion "
            sql += "WHERE desc_permiso = '" & lstPermisos.Items.Item(lstPermisos.SelectedIndex).ToString() & "'"
            Dim dr As SqlDataReader = execQuery(sql, csql)
            If dr.Read Then
                permisos += dr("id_permiso")
            End If
            dr.Close()
            lstPermisos.SetSelected(lstPermisos.SelectedIndex, False)
        End While
        If operador = "A" Then
            sql = "SELECT * "
            sql += "FROM usuarios_pc "
            sql += "WHERE id_usuario = '" & txtUsuario.Text & "'"
            Dim dr As SqlDataReader = execQuery(sql, csql)
            If dr.Read Then
                dr.Close()
                erpEdicion.Text = "El usuario ingresado ya existe"
                tmrMensaje.Enabled = True
                Exit Sub
            End If
            dr.Close()
            sql = "INSERT INTO usuarios_pc(id_usuario"
            sql += ",nombre_usuario"
            sql += ",clave_usuario"
            sql += ",estado_usuario"
            sql += ",accesos_usuario) "
            sql += "VALUES('" & txtUsuario.Text & "'"
            sql += ",'" & txtNombre.Text & "'"
            sql += ",'" & txtPass1.Text & "'"
            If cboEstado.Text = "ACTIVO" Then
                sql += ",'ACT'"
            Else
                sql += ",'INA'"
            End If
            sql += ",'" & permisos & "')"
            Call execUpdate(sql, csql)
        Else
            sql = "UPDATE usuarios_pc "
            sql += "SET nombre_usuario = '" & txtNombre.Text & "'"
            sql += ",clave_usuario = '" & txtPass1.Text & "'"
            If cboEstado.Text = "ACTIVO" Then
                sql += ",estado_usuario = 'ACT'"
            Else
                sql += ",estado_usuario = 'INA'"
            End If
            sql += ",accesos_usuario = '" & permisos & "'"
            sql += " WHERE id_usuario = '" & txtUsuario.Text & "'"
            Call execUpdate(sql, csql)
        End If
        Call btnUndo_Click(sender, e)
        operador = ""
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
        lstPermisos.Enabled = False
        btnSave.Enabled = False
        btnUndo.Enabled = False
        btnDel.Enabled = False
        lstPermisos.Items.Clear()
        Call cargarDatos()
    End Sub
    Private Sub dtaGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtaGrid.DoubleClick
        If dtaGrid.SelectedRows.Count > 0 Then
            sql = "SELECT * "
            sql += "FROM usuarios_pc "
            sql += "WHERE id_usuario = '" & dtaGrid.SelectedRows(0).Cells("id_usuario").Value & "'"
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
                dr.Close()
                Call cargarPermisos()
                txtNombre.Enabled = True
                txtPass1.Enabled = True
                txtPass2.Enabled = True
                cboEstado.Enabled = True
                lstPermisos.Enabled = True
                btnSave.Enabled = True
                btnUndo.Enabled = True
                sql = "SELECT * "
                sql += "FROM movimientos "
                sql += "WHERE id_usuario = '" & dtaGrid.SelectedRows(0).Cells("id_usuario").Value & "'"
                dr = execQuery(sql, csql)
                If dr.Read Then
                    btnDel.Enabled = False
                Else
                    btnDel.Enabled = True
                End If
                txtUsuario.Focus()
                dr.Close()
            Else
                dr.Close()
                erpEdicion.FooterText = "Error al cargar los datos del usuario"
                tmrMensaje.Enabled = True
            End If
        End If
    End Sub
    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Dim resp As MsgBoxResult
        Dim szLista As String = ""
        For Each dg In dtaGrid.SelectedRows
            szLista += dg.Cells(0).Value & vbCrLf
        Next
        sql = "SELECT * "
        sql += "FROM movimientos "
        sql += "WHERE id_usuario = '" & dtaGrid.SelectedRows(0).Cells("id_usuario").Value & "'"
        Dim dr As SqlDataReader = execQuery(sql, csql)
        If dr.Read Then
            MsgBox("Usuario no puede ser eliminado, tiene movimientos asociados.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        dr.Close()
        If szLista.Length = 0 Then
            Exit Sub
        End If
        resp = MsgBox("Esta seguro de eliminar usuario/s ?" & vbCrLf & "Este proceso es irreversible" & vbCrLf & vbCrLf & szLista, MsgBoxStyle.YesNo)
        If resp = MsgBoxResult.Yes Then
            For Each dg In dtaGrid.SelectedRows
                execUpdate("DELETE FROM usuarios_pc WHERE id_usuario='" & dg.Cells(0).Value & "'", csql)
            Next
            cargarDatos()
        End If
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
        lstPermisos.Enabled = False
        lstPermisos.Items.Clear()
        Call btnUndo_Click(sender, e)
        Call cargarDatos()
    End Sub
    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        txtNombre.Text = UCase(txtNombre.Text)
        txtNombre.SelectionStart = Me.txtNombre.Text.Length + 1
    End Sub
End Class