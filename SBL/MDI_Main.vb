Imports System.Windows.Forms
Imports System.Data.SqlClient
Public Class MDI_Main
    Dim ComPid As String
    Dim Producto As String = "SBL 2.0"
    Private Sub cargarAccesos()
        Dim okC As Boolean = False
        Dim okD As Boolean = False
        Dim okI As Boolean = False
        Dim szAcceso As String = ""
        If username = "superadmin" Then
            szAcceso = "BODPROUBIUACUMOUPCIVPDOEDOSDOCIVLVREVEXVMO"
        Else
            sql = "SELECT accesos_usuario "
            sql += "FROM Usuarios_pc "
            sql += "WHERE Id_Usuario = '" & username & "'"
            Dim dR As SqlDataReader = execQuery(sql, csql)
            If dR.Read Then
                szAcceso = dR("accesos_usuario")
            End If
            dR.Close()
        End If
        ' ***** Administración
        If szAcceso.IndexOf("BOD") <> -1 Then
            Me.BodegasToolStripMenuItem.Visible = True
        End If
        If szAcceso.IndexOf("PRO") <> -1 Then
            Me.ProductosToolStripMenuItem.Visible = True
        End If
        If szAcceso.IndexOf("UBI") <> -1 Then
            Me.UbicacionesBodegaToolStripMenuItem.Visible = True
        End If
        If szAcceso.IndexOf("FAM") <> -1 Then
            Me.FamiliasToolStripMenuItem.Visible = True
        End If
        If szAcceso.IndexOf("USE") <> -1 Then
            SeriesToolStripMenuItem.Visible = True
        End If
        If szAcceso.IndexOf("UMO") <> -1 Then
            Me.UsuariosMovilesToolStripMenuItem.Visible = True
        End If
        If szAcceso.IndexOf("UPC") <> -1 Then
            Me.UsuariosPCToolStripMenuItem.Visible = True
        End If
        If szAcceso.IndexOf("PRV") <> -1 Then
            Me.ProveedoresToolStripMenuItem.Visible = True
        End If
        If szAcceso.IndexOf("CLI") <> -1 Then
            Me.ClientesToolStripMenuItem.Visible = True
        End If
        ' ***** Consultas
        If szAcceso.IndexOf("VEX") <> -1 Then
            Me.VerExistenciasToolStripMenuItem.Visible = True
            okC = True
        End If
        If szAcceso.IndexOf("VMO") <> -1 Then
            Me.VerMovimientosToolStripMenuItem.Visible = True
            okC = True
        End If
        If szAcceso.IndexOf("DSA") <> -1 Then
        End If
        ' ***** Inventarios
        If szAcceso.IndexOf("CIV") <> -1 Then
            Me.InventariosToolStripMenuItem.Visible = True
            okI = True
        End If
        If szAcceso.IndexOf("IVC") <> -1 Then
            Me.ConsultaInventarioToolStripMenuItem.Visible = True
            okI = True
        End If
        'If szAcceso.IndexOf("UAC") <> -1 Then
        '    Me.UsuariosAccesoToolStripMenuItem.Visible = True
        'End If
        'If szAcceso.IndexOf("VRE") <> -1 Then
        '    Me.VerRegistroAccesoToolStripMenuItem.Visible = True
        '    okC = True
        'End If
        ' ***** Procesos
        If szAcceso.IndexOf("DOE") <> -1 Then
            Me.EntradaToolStripMenuItem.Visible = True
            okD = True
        End If
        If szAcceso.IndexOf("DOS") <> -1 Then
            Me.SalidaToolStripMenuItem.Visible = True
            okD = True
        End If
        If okC Then
            Me.ConsultasToolStripMenuItem.Visible = True
        End If
        If okD Then
            Me.DocumentosToolStripMenuItem.Visible = True
        End If
        If okI Then
            Me.InventarioToolStripMenuItem.Visible = True
        End If
    End Sub
    Private Sub frmMenu_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            csql.Close()
        Catch ex As Exception
        End Try
        Application.Exit()
    End Sub
    Private Sub frmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Visible = False
        Dim ctl As Control
        Dim ctlMDI As MdiClient
        frmMDI = Me
        For Each ctl In Me.Controls
            Try
                ctlMDI = CType(ctl, MdiClient)
                ctlMDI.BackColor = Me.BackColor
            Catch exc As InvalidCastException

            End Try
        Next
        ComPid = pcInfo()
        If ExisteArchivo(My.Application.Info.DirectoryPath & "\logo.jpg") Then
            Me.BackgroundImage = Image.FromFile(My.Application.Info.DirectoryPath & "\logo.jpg")
        End If
        Me.Text += " - v. " & System.Diagnostics.FileVersionInfo.GetVersionInfo(Application.ExecutablePath).FileVersion
        Call getConfxml()
        Call getConnection()
        Dim fLogin As frmLogin = New frmLogin
        fLogin.ShowDialog()
        fLogin.Dispose()
        If cerrar Then
            csql.Close()
            Application.Exit()
            Exit Sub
        Else
            Me.Visible = True
            Call cargarAccesos()
        End If
    End Sub
    Private Function CheckKey(ByVal CompID As String, ByVal Producto As String) As Boolean
        Dim BinKey As Object
        Dim RawKey As Object
        Dim FeatID As Integer
        Dim KeyCode As String
        FeatID = 0
        RawKey = GenKeyString(CompID, Producto, FeatID)
        BinKey = HexStrToBinStr(RawKey)
        KeyCode = FormatKeyCode(Base32Enc(BinKey), 4)
        Dim readValue As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Tds", Producto, Nothing)
        If readValue <> KeyCode Then
            Return False
        End If
        Return True
    End Function
    Private Sub TerminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Application.Exit()
    End Sub
    Private Sub VerRegistroAccesoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerRegistroAccesoToolStripMenuItem.Click
        Dim fb As frmConsultaAccesos = New frmConsultaAccesos
        If PushVentana(fb) Then
            fb.MdiParent = Me
            fb.Show()
        Else
            fb.Dispose()
        End If
    End Sub
    Private Sub BodegasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BodegasToolStripMenuItem.Click
        Dim fb As frmBodegas = New frmBodegas
        If PushVentana(fb) Then
            fb.MdiParent = Me
            fb.Show()
        Else
            fb.Dispose()
        End If
    End Sub
    Private Sub UbicacionesBodegaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UbicacionesBodegaToolStripMenuItem.Click
        Dim fb As frmUbicaciones = New frmUbicaciones
        If PushVentana(fb) Then
            fb.MdiParent = Me
            fb.Show()
        Else
            fb.Dispose()
        End If
    End Sub
    Private Sub VerMovimientosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerMovimientosToolStripMenuItem.Click
        Dim fb As frmMovimientos = New frmMovimientos
        If PushVentana(fb) Then
            fb.MdiParent = Me
            fb.Show()
        Else
            fb.Dispose()
        End If
    End Sub
    Private Sub ProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosToolStripMenuItem.Click
        Dim fb As frmProductos = New frmProductos
        If PushVentana(fb) Then
            fb.MdiParent = Me
            fb.Show()
        Else
            fb.Dispose()
        End If
    End Sub
    Private Sub VerExistenciasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerExistenciasToolStripMenuItem.Click
        Dim fb As frmExistencias = New frmExistencias
        If PushVentana(fb) Then
            fb.MdiParent = Me
            fb.Show()
        Else
            fb.Dispose()
        End If
    End Sub
    Private Sub UsuariosPCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosPCToolStripMenuItem.Click
        Dim fb As frmUsersPC = New frmUsersPC
        If PushVentana(fb) Then
            fb.MdiParent = Me
            fb.Show()
        Else
            fb.Dispose()
        End If
    End Sub
    Private Sub UsuariosMovilesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosMovilesToolStripMenuItem.Click
        Dim fb As frmUsersRF = New frmUsersRF
        If PushVentana(fb) Then
            fb.MdiParent = Me
            fb.Show()
        Else
            fb.Dispose()
        End If
    End Sub
    Private Sub TerminarAplicaciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TerminarAplicaciónToolStripMenuItem.Click
        Application.Exit()
    End Sub
    Private Sub EntradaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntradaToolStripMenuItem.Click
        Dim fb As frmLoadDocEntrada = New frmLoadDocEntrada
        If PushVentana(fb) Then
            fb.MdiParent = Me
            fb.Show()
        Else
            fb.Dispose()
        End If
    End Sub
    Private Sub SalidaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalidaToolStripMenuItem.Click
        Dim fb As frmLoadDocSalida = New frmLoadDocSalida
        If PushVentana(fb) Then
            fb.MdiParent = Me
            fb.Show()
        Else
            fb.Dispose()
        End If
    End Sub
    Private Sub CompraToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim fb As frmLoadCompras = New frmLoadCompras
        If PushVentana(fb) Then
            fb.MdiParent = Me
            fb.Show()
        Else
            fb.Dispose()
        End If
    End Sub
    Private Sub InventariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventariosToolStripMenuItem.Click
        Dim fb As frmCreaInventario = New frmCreaInventario
        If PushVentana(fb) Then
            fb.MdiParent = Me
            fb.Show()
        Else
            fb.Dispose()
        End If
    End Sub
    Private Sub ConsultaInventarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaInventarioToolStripMenuItem.Click
        Dim fb As frmComparaInventario = New frmComparaInventario
        fb.Tag = "menu"
        If PushVentana(fb) Then
            fb.MdiParent = Me
            fb.Show()
        Else
            fb.Dispose()
        End If
    End Sub
    Private Sub FamiliasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FamiliasToolStripMenuItem.Click
        Dim fb As frmFamilia = New frmFamilia
        If PushVentana(fb) Then
            fb.MdiParent = Me
            fb.Show()
        Else
            fb.Dispose()
        End If
    End Sub
    Private Sub CapturadoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CapturadoresToolStripMenuItem.Click
        Dim fb As frmCapturadores = New frmCapturadores
        If PushVentana(fb) Then
            fb.MdiParent = Me
            fb.Show()
        Else
            fb.Dispose()
        End If
    End Sub
    Private Sub SeriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeriesToolStripMenuItem.Click
        Dim fb As frmSeries = New frmSeries
        If PushVentana(fb) Then
            fb.MdiParent = Me
            fb.Show()
        Else
            fb.Dispose()
        End If
    End Sub

    Private Sub RecetasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecetasToolStripMenuItem.Click
        Dim fb As frmRecetas = New frmRecetas
        If PushVentana(fb) Then
            fb.MdiParent = Me
            fb.Show()
        Else
            fb.Dispose()
        End If
    End Sub
    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Dim fb As frmMantProveedor = New frmMantProveedor
        If PushVentana(fb) Then
            fb.MdiParent = Me
            fb.Show()
        Else
            fb.Dispose()
        End If
    End Sub
    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim fb As frmMantCliente = New frmMantCliente
        If PushVentana(fb) Then
            fb.MdiParent = Me
            fb.Show()
        Else
            fb.Dispose()
        End If
    End Sub
    Private Sub DoctosSalidaToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TrackingSeriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrackingSeriesToolStripMenuItem.Click
        Dim fb As frmTrackingSeries = New frmTrackingSeries
        If PushVentana(fb) Then
            fb.MdiParent = Me
            fb.Show()
        Else
            fb.Dispose()
        End If
    End Sub

    'Private Sub SeriesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SeriesToolStripMenuItem1.Click
    '    Dim fb As frmVerSeries = New frmVerSeries
    '    If PushVentana(fb) Then
    '        fb.MdiParent = Me
    '        fb.Show()
    '    Else
    '        fb.Dispose()
    '    End If

    'End Sub
End Class