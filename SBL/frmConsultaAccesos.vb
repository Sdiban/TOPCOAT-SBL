Imports System.Data.SqlClient
Public Class frmConsultaAccesos
    Private Sub cargarDatos()
        Dim ds As New DataSet
        Dim dta As New DataTable
        Dim sqla As String = ""
        sql = "SELECT * FROM get_registros_accesos() "
        If Trim(txtUsuario.Text) <> "" Then
            If Trim(sqla) = "" Then
                sqla = "WHERE id_usuario Like '%" & txtUsuario.Text & "%' "
            Else
                sqla += "AND id_usuario Like '%" & txtUsuario.Text & "%' "
            End If
        End If
        If Trim(txtNombre.Text) <> "" Then
            If Trim(sqla) = "" Then
                sqla = "WHERE nombre_usuario Like '%" & txtNombre.Text & "%' "
            Else
                sqla += "AND nombre_usuario Like '%" & txtNombre.Text & "%' "
            End If
        End If
        If Trim(txtRFID.Text) <> "" Then
            If Trim(sqla) = "" Then
                sqla = "WHERE codigo_rfid like '%" & txtRFID.Text & "%' "
            Else
                sqla += "AND codigo_rfid like '%" & txtRFID.Text & "%' "
            End If
        End If
        If dtpFecIni.Checked Then
            If Trim(sqla) = "" Then
                sqla = "WHERE fecha_registro >= cast('" & Mid(dtpFecIni.Text, 7, 4) & "-" & Mid(dtpFecIni.Text, 4, 2) & "-" & Mid(dtpFecIni.Text, 1, 2) & " 00:00:00' as datetime) "
            Else
                sqla += "AND fecha_registro >= cast('" & Mid(dtpFecIni.Text, 7, 4) & "-" & Mid(dtpFecIni.Text, 4, 2) & "-" & Mid(dtpFecIni.Text, 1, 2) & " 00:00:00' as datetime) "
            End If
        End If
        If dtpFecFin.Checked Then
            If Trim(sqla) = "" Then
                sqla = "WHERE fecha_registro <= cast('" & Mid(dtpFecFin.Text, 7, 4) & "-" & Mid(dtpFecFin.Text, 4, 2) & "-" & Mid(dtpFecFin.Text, 1, 2) & " 23:59:00' as datetime) "
            Else
                sqla += "AND fecha_registro <= cast('" & Mid(dtpFecFin.Text, 7, 4) & "-" & Mid(dtpFecFin.Text, 4, 2) & "-" & Mid(dtpFecFin.Text, 1, 2) & " 23:59:00' as datetime) "
            End If
        End If
        dta.TableName = "registros"
        dta = execDataSet(sql & sqla, csql).Tables("Sql")
        erpResultados.FooterText = dta.Rows.Count.ToString & " resultado(s)"
        dtaGrid.AutoGenerateColumns = False
        dtaGrid.Columns.Clear()
        dtaGrid.Columns.Add("num_registro", "N° Registro")
        dtaGrid.Columns.Add("id_usuario", "Usuario")
        dtaGrid.Columns.Add("nombre_usuario", "Nombre")
        dtaGrid.Columns.Add("codigo_rfid", "RFID")
        dtaGrid.Columns.Add("fecha_registro", "Fecha")
        dtaGrid.Columns(0).DataPropertyName = "num_registro"
        dtaGrid.Columns(1).DataPropertyName = "id_usuario"
        dtaGrid.Columns(2).DataPropertyName = "nombre_usuario"
        dtaGrid.Columns(3).DataPropertyName = "codigo_rfid"
        dtaGrid.Columns(4).DataPropertyName = "fecha_registro"
        dtaGrid.Columns(0).Width = 100
        dtaGrid.Columns(1).Width = 120
        dtaGrid.Columns(2).Width = 250
        dtaGrid.Columns(3).Width = 150
        dtaGrid.Columns(4).Width = 120
        dtaGrid.DataSource = dta
    End Sub
    Private Sub frmConsultaAccesos_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ReleaseVentana(Me)
    End Sub
    Private Sub frmConsultaAccesos_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        erpBusquedas.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Top
        erpResultados.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Top
    End Sub
    Private Sub erpResultados_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles erpResultados.SizeChanged
        dtaGrid.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Top
    End Sub
    Private Sub erpBusquedas_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles erpBusquedas.SizeChanged
        btnBack.Anchor = AnchorStyles.Bottom
    End Sub
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Call cargarDatos()
    End Sub
    Private Sub frmConsultaAccesos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpFecFin.Value = Now
        dtpFecIni.Value = Now
        dtpFecIni.Checked = False
        dtpFecFin.Checked = False
    End Sub
    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        txtNombre.Text = UCase(txtNombre.Text)
        txtNombre.SelectionStart = Me.txtNombre.Text.Length + 1
    End Sub
End Class