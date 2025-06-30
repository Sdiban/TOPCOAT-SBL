Imports System.Data.SqlClient
Imports QRCoder
Imports System.IO
Imports System.Drawing.Imaging

Public Class frmUsersRF
    Dim htmlhead As String = "<html><head><title>MANIFIESTO DE USUARIOS MOVILES</title>" & vbCrLf &
            "</head>" & vbCrLf &
            "<style type='text/css'>" & vbCrLf &
            ".box-blue," & vbCrLf &
            ".box-gray," & vbCrLf &
            ".box-green," & vbCrLf &
            ".box-grey," & vbCrLf &
            ".box-red," & vbCrLf &
            ".box-yellow {" & vbCrLf &
            "	margin:0 0 25px;	overflow:hidden;	padding:20px;	-webkit-border-radius: 10px;        border-radius: 10px;}" & vbCrLf &
            ".box-blue {" & vbCrLf &
            "	background-color:#d8ecf7;	border:1px solid #afcde3;}" & vbCrLf &
            ".box-gray {" & vbCrLf &
            "	background-color:#e2e2e2;	border:1px solid #bdbdbd;}" & vbCrLf &
            ".box-green {" & vbCrLf &
            "	background-color:#d9edc2;	border:1px solid #b2ce96;}" & vbCrLf &
            ".box-grey {" & vbCrLf &
            "	background-color:#F5F5F5;	border:1px solid #DDDDDD;}" & vbCrLf &
            ".box-red {" & vbCrLf &
            "	background-color:#f9dbdb;	border:1px solid #e9b3b3;}" & vbCrLf &
            ".box-yellow {" & vbCrLf &
            "	background-color:#fef5c4;	border:1px solid #fadf98;}" & vbCrLf &
            "</style>" & vbCrLf &
            "<body>" & vbCrLf &
            "<table border=0 cellspacing='0'>"
    Dim szLogo As String
    Private Function GetIconBitmap() As Bitmap
        szLogo = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        szLogo += "\SBL_WMS\logo.png"
        If (Not ExisteArchivo(szLogo)) Then
            Return Nothing
        End If
        Try
            Return New Bitmap(szLogo)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Function GenerarQR(usr As String, password As String, Optional bEscribe As Boolean = False) As String
        Dim level As String = "M"
        Dim s1 As String = usr.Replace(" ", "")
        Dim eccLevel As QRCodeGenerator.ECCLevel = CType(0, QRCodeGenerator.ECCLevel)
        Dim qrGenerator As QRCodeGenerator = New QRCodeGenerator
        Dim qrCodeData As QRCodeData = qrGenerator.CreateQrCode(usr & ";" & password, eccLevel)
        Dim qrCode As QRCode = New QRCode(qrCodeData)
        pictureBoxQRCode.BackgroundImage = qrCode.GetGraphic(20, panelPreviewPrimaryColor.BackColor,
                                                             panelPreviewBackgroundColor.BackColor, GetIconBitmap(),
                                                            IIf(ExisteArchivo(szLogo), 15, 0))
        Me.pictureBoxQRCode.Size = New System.Drawing.Size(pictureBoxQRCode.Width, pictureBoxQRCode.Height)
        'Set the SizeMode to center the image.
        Me.pictureBoxQRCode.SizeMode = PictureBoxSizeMode.CenterImage
        pictureBoxQRCode.SizeMode = PictureBoxSizeMode.StretchImage
        Dim mdoc As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        If bEscribe Then
            mdoc += "\SBL_WMS\" & s1 & ".png"
            Dim fs As FileStream = File.Create(mdoc)
            pictureBoxQRCode.BackgroundImage.Save(fs, ImageFormat.Png)
            Application.DoEvents()
            pictureBoxQRCode.BackgroundImage.Dispose()
            pictureBoxQRCode.BackgroundImage = Nothing
        End If
        Return mdoc
    End Function
    Private Sub cargarEstados()
        cboEstado.Items.Add("ACTIVO")
        cboEstado.Items.Add("INACTIVO")
    End Sub
    Private Sub cargarDatos()
        Dim dt As New DataTable
        sql = "SELECT * FROM usuarios_rf ORDER BY id_usuario"
        dt = execDataSet(sql, csql).Tables("Sql")
        dtaGrid.AutoGenerateColumns = False
        dtaGrid.Columns.Clear()
        dtaGrid.Columns.Add("id_usuario", "USUARIO") '0
        dtaGrid.Columns.Add("nombre_usuario", "NOMBRE") '1
        dtaGrid.Columns.Add("estado_usuario", "ESTADO")
        dtaGrid.Columns(0).DataPropertyName = "id_usuario"
        dtaGrid.Columns(1).DataPropertyName = "nombre_usuario"
        dtaGrid.Columns(2).DataPropertyName = "estado_usuario"
        dtaGrid.Columns(0).Width = 100
        dtaGrid.Columns(1).Width = 200
        dtaGrid.Columns(2).Width = 100
        dtaGrid.DataSource = dt
    End Sub
    Private Sub cargarPermisos()
        Try
            Dim tAccesos As DataTable = New DataTable
            lstPermisos.Items.Clear()
            Dim Cont As Integer = 0
            Dim dRA As SqlDataReader
            sql = "SELECT * "
            sql += "FROM permisos_rf "
            sql += "ORDER BY desc_permiso"
            tAccesos.Load(execQuery(sql, csql))
            For Cont = 0 To tAccesos.Rows.Count - 1
                lstPermisos.Items.Add(tAccesos.Rows(Cont).Item("desc_permiso"))
                If Trim(txtUsuario.Text) <> "" Then
                    sql = "SELECT * "
                    sql += "FROM usuarios_rf "
                    sql += "WHERE id_usuario = '" & txtUsuario.Text & "' "
                    sql += "AND accesos_usuario LIKE '%" & tAccesos.Rows(Cont).Item("id_permiso") & "%'"
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
    Private Sub frmUsersRF_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ReleaseVentana(Me)
    End Sub
    Private Sub frmUsersID_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pictureBoxQRCode.BackgroundImage = Nothing
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
        btnSave.Enabled = True
        Call cargarPermisos()
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
        Dim permisos As String = ""
        permisos = ""
        While lstPermisos.SelectedIndex <> -1
            sql = "SELECT id_permiso FROM permisos_rf WHERE desc_permiso = '" & lstPermisos.Items.Item(lstPermisos.SelectedIndex).ToString() & "'"
            Dim dr As SqlDataReader = execQuery(sql, csql)
            If dr.Read Then
                permisos += dr("id_permiso")
            End If
            dr.Close()
            lstPermisos.SetSelected(lstPermisos.SelectedIndex, False)
        End While
        If operador = "A" Then
            sql = "SELECT * FROM usuarios_rf WHERE id_usuario = '" & txtUsuario.Text & "'"
            Dim dr As SqlDataReader = execQuery(sql, csql)
            If dr.Read Then
                dr.Close()
                erpEdicion.Text = "El usuario ingresado ya existe"
                tmrMensaje.Enabled = True
                Exit Sub
            End If
            dr.Close()
            sql = "INSERT INTO usuarios_rf(id_usuario,nombre_usuario,clave_usuario,estado_usuario,accesos_usuario) VALUES("
            sql += "'" & txtUsuario.Text & "'"
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
            sql = "UPDATE usuarios_rf set nombre_usuario = '" & txtNombre.Text & "'"
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
        btnSave.Enabled = False
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
        lstPermisos.Items.Clear()
        cboEstado.SelectedIndex = -1
        txtUsuario.Enabled = False
        txtNombre.Enabled = False
        txtPass1.Enabled = False
        txtPass2.Enabled = False
        cboEstado.Enabled = False
        btnSave.Enabled = False
        btnPrint.Enabled = False
        btnDel.Enabled = False
        btnUndo.Enabled = False
        Call cargarDatos()
    End Sub
    Private Sub dtaGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtaGrid.DoubleClick
        If dtaGrid.SelectedRows.Count > 0 Then
            sql = "SELECT * "
            sql += "FROM usuarios_rf "
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
                txtUsuario.Focus()
                GenerarQR(txtUsuario.Text, txtPass1.Text)
                btnSave.Enabled = True
                btnPrint.Enabled = True
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
        If szLista.Length = 0 Then
            Exit Sub
        End If
        sql = "SELECT * "
        sql += "FROM movimientos "
        sql += "WHERE id_usuario = '" & dtaGrid.SelectedRows(0).Cells("id_usuario").Value & "'"
        Dim dr As SqlDataReader = execQuery(sql, csql)
        If dr.Read Then
            MsgBox("Usuario no puede ser eliminado, tiene movimientos asociados.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        dr.Close()
        resp = MsgBox("Esta seguro de eliminar usuario/s ?" & vbCrLf & "Este proceso es irreversible" & vbCrLf & vbCrLf & szLista, MsgBoxStyle.YesNo)
        If resp = MsgBoxResult.Yes Then
            For Each dg In dtaGrid.SelectedRows
                execUpdate("DELETE FROM usuarios_rf WHERE id_usuario='" & dg.Cells(0).Value & "'", csql)
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
        Call btnUndo_Click(sender, e)
        Call cargarDatos()
    End Sub
    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged
        txtUsuario.Text = UCase(txtUsuario.Text)
        txtUsuario.SelectionStart = Me.txtUsuario.Text.Length + 1
        GenerarQR(txtUsuario.Text, txtPass1.Text)
    End Sub
    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        txtNombre.Text = UCase(txtNombre.Text)
        txtNombre.SelectionStart = Me.txtNombre.Text.Length + 1
        GenerarQR(txtUsuario.Text, txtPass1.Text)
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If dtaGrid.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        Dim szReporte As String
        Dim s1 As String
        Me.Cursor = Cursors.WaitCursor
        szReporte = OpenReport("reporte_usuarios", "SBL_WMS\")
        GrabaReport(htmlhead)
        Dim icnt As Integer = 0
        For Each dg In dtaGrid.SelectedRows
            If dg.Cells("estado_usuario").Value = "ACT" Then
                sql = "SELECT * "
                sql += "FROM usuarios_rf "
                sql += "WHERE id_usuario = '" & dtaGrid.SelectedRows(0).Cells("id_usuario").Value & "'"
                Dim dr As SqlDataReader = execQuery(sql, csql)
                s1 = ""
                If dr.Read Then
                    s1 = dr("clave_usuario")
                End If
                s1 = GenerarQR(dg.Cells("id_usuario").Value, s1, True)
                s1 = dg.Cells("id_usuario").Value
                s1 = s1.Replace(" ", "")
                If icnt = 0 Then
                    GrabaReport("<tr>")
                End If
                GrabaReport("<td><div class='box-yellow' align='center' ><img src='" & s1 & ".png' style='width:120px;height:120px;'><br>")
                GrabaReport(dg.Cells("id_usuario").Value & "<br>")
                GrabaReport(dg.Cells("nombre_usuario").Value)
                GrabaReport("</td>")
                dr.Close()
                icnt += 1
                If icnt = 4 Then
                    icnt = 0
                    GrabaReport("</tr>")
                End If
            End If
            Application.DoEvents()
        Next
        If icnt < 4 Then
            GrabaReport("</tr>")
        End If
        GrabaReport("</table></body></html>")
        CloseReport()
        Application.DoEvents()
        For i = 0 To 10
            GenerarQR("00" & i, "00" & i, True)
            Application.DoEvents()
        Next
        Process.Start(szReporte)
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub txtPass1_TextChanged(sender As Object, e As EventArgs) Handles txtPass1.TextChanged
        GenerarQR(txtUsuario.Text, txtPass1.Text)
    End Sub

    Private Sub dtaGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtaGrid.CellContentClick

    End Sub
End Class