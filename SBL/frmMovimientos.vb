Imports System.Data.SqlClient
Public Class frmMovimientos
    Private Sub cargarTipos()
        cboTipo.Items.Add("TODOS")
        cboTipo.Items.Add("ENTRADAS")
        cboTipo.Items.Add("SALIDAS")
        cboTipo.Items.Add("CARGA INICIAL")
        cboTipo.Items.Add("TRASLADO")
        cboTipo.Items.Add("INVENTARIOS")
    End Sub
    Private Sub cargarDatos()
        Dim ds As New DataSet
        Dim dta As New DataTable
        Dim sqla As String = ""
        sql = "SELECT * "
        sql += "FROM get_movimientos() "
        If Trim(txtUsuario.Text) <> "" Then
            If Trim(sqla) = "" Then
                sqla = "WHERE id_usuario Like '%" & txtUsuario.Text & "%' "
            Else
                sqla += "And id_usuario Like '%" & txtUsuario.Text & "%' "
            End If
        End If
        If Trim(txtDescripcion.Text) <> "" Then
            If Trim(sqla) = "" Then
                sqla = "WHERE desc_producto Like '%" & txtDescripcion.Text & "%' "
            Else
                sqla += "And desc_producto Like '%" & txtDescripcion.Text & "%' "
            End If
        End If
        If Trim(txtDocumento.Text) <> "" Then
            If Trim(sqla) = "" Then
                sqla = "WHERE id_documento = '" & txtDocumento.Text & "' "
            Else
                sqla += "And id_documento = '" & txtDocumento.Text & "' "
            End If
        End If
        Select Case cboTipo.SelectedIndex
            Case 1
                If Trim(sqla) = "" Then
                    sqla = "WHERE tipo_movimiento = 'ENT' "
                Else
                    sqla += "And tipo_movimiento = 'ENT' "
                End If
            Case 2
                If Trim(sqla) = "" Then
                    sqla = "WHERE tipo_movimiento = 'SAL' "
                Else
                    sqla += "And tipo_movimiento = 'SAL' "
                End If
            Case 3
                If Trim(sqla) = "" Then
                    sqla = "WHERE tipo_movimiento = 'CAR' "
                Else
                    sqla += "And tipo_movimiento = 'CAR' "
                End If
            Case 4
                If Trim(sqla) = "" Then
                    sqla = "WHERE tipo_movimiento = 'TRA' "
                Else
                    sqla += "And tipo_movimiento = 'TRA' "
                End If
            Case 5
                If Trim(sqla) = "" Then
                    sqla = "WHERE tipo_movimiento = 'INV' "
                Else
                    sqla += "And tipo_movimiento = 'INV' "
                End If
        End Select
        If Trim(txtCodigo.Text) <> "" Then
            If Trim(sqla) = "" Then
                sqla = "WHERE cod_producto like '%" & txtCodigo.Text & "%' "
            Else
                sqla += "And cod_producto like '%" & txtCodigo.Text & "%' "
            End If
        End If
        If dtpFecIni.Checked Then
            If Trim(sqla) = "" Then
                sqla = "WHERE fecha_movimiento >= cast('" & Mid(dtpFecIni.Text, 7, 4) & "-" & Mid(dtpFecIni.Text, 4, 2) & "-" & Mid(dtpFecIni.Text, 1, 2) & "T00:00:00' as datetime) "
            Else
                sqla += "And fecha_movimiento >= cast('" & Mid(dtpFecIni.Text, 7, 4) & "-" & Mid(dtpFecIni.Text, 4, 2) & "-" & Mid(dtpFecIni.Text, 1, 2) & "T00:00:00' as datetime) "
            End If
        End If
        If dtpFecFin.Checked Then
            If Trim(sqla) = "" Then
                sqla = "WHERE fecha_movimiento <= cast('" & Mid(dtpFecFin.Text, 7, 4) & "-" & Mid(dtpFecFin.Text, 4, 2) & "-" & Mid(dtpFecFin.Text, 1, 2) & "T23:59:00' as datetime) "
            Else
                sqla += "And fecha_movimiento <= cast('" & Mid(dtpFecFin.Text, 7, 4) & "-" & Mid(dtpFecFin.Text, 4, 2) & "-" & Mid(dtpFecFin.Text, 1, 2) & "T23:59:00' as datetime) "
            End If
        End If
        sqla += "ORDER BY fecha_movimiento desc"
        dta.TableName = "movimientos"
        dta = execDataSet(sql & sqla, csql).Tables("Sql")
        erpResultados.FooterText = dta.Rows.Count.ToString & " resultado(s)"
        dtaGrid.AutoGenerateColumns = False
        dtaGrid.Columns.Clear()
        dtaGrid.Columns.Add("num_movimiento", "Num.")
        dtaGrid.Columns.Add("tipo_movimiento", "Tipo")
        dtaGrid.Columns.Add("id_documento", "Doc. / Destino")
        dtaGrid.Columns.Add("cod_ubicacion", "Ubicación")
        dtaGrid.Columns.Add("cod_producto", "Cod. Producto")
        dtaGrid.Columns.Add("desc_producto", "Desc. Producto")
        dtaGrid.Columns.Add("fecha_movimiento", "Fecha")
        dtaGrid.Columns.Add("cant_movimiento", "Cantidad")
        dtaGrid.Columns.Add("id_usuario", "Usuario")
        dtaGrid.Columns.Add("usa_serie", "Usa Serie")
        dtaGrid.Columns("num_movimiento").DataPropertyName = "num_movimiento"
        dtaGrid.Columns("tipo_movimiento").DataPropertyName = "tipo_movimiento"
        dtaGrid.Columns("id_documento").DataPropertyName = "id_documento"
        dtaGrid.Columns("cod_ubicacion").DataPropertyName = "cod_ubicacion"
        dtaGrid.Columns("cod_producto").DataPropertyName = "cod_producto"
        dtaGrid.Columns("desc_producto").DataPropertyName = "desc_producto"
        dtaGrid.Columns("fecha_movimiento").DataPropertyName = "fecha_movimiento"
        dtaGrid.Columns("cant_movimiento").DataPropertyName = "cant_movimiento"
        dtaGrid.Columns("id_usuario").DataPropertyName = "id_usuario"
        dtaGrid.Columns("usa_serie").DataPropertyName = "usa_serie"
        dtaGrid.Columns("num_movimiento").Width = 80
        dtaGrid.Columns("tipo_movimiento").Width = 50
        dtaGrid.Columns("id_documento").Width = 90
        dtaGrid.Columns("cod_ubicacion").Width = 90
        dtaGrid.Columns("cod_producto").Width = 120
        dtaGrid.Columns("desc_producto").Width = 240
        dtaGrid.Columns("fecha_movimiento").Width = 110
        dtaGrid.Columns("cant_movimiento").Width = 60
        dtaGrid.Columns("id_usuario").Width = 80
        dtaGrid.Columns("usa_serie").Width = 60
        dtaGrid.DataSource = dta
    End Sub
    Private Sub frmMovimientos_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ReleaseVentana(Me)
    End Sub
    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Call cargarDatos()
    End Sub
    Private Sub frmMovimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpFecFin.Value = Now
        dtpFecIni.Value = Now
        dtpFecIni.Checked = False
        dtpFecFin.Checked = False
        Call cargarTipos()
        cboTipo.SelectedIndex = 0
    End Sub
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
    Private Sub txtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged
        txtDescripcion.Text = UCase(txtDescripcion.Text)
        txtDescripcion.SelectionStart = Me.txtDescripcion.Text.Length + 1
    End Sub
    Private Sub dtaGrid_Click(sender As Object, e As EventArgs) Handles dtaGrid.Click
        If dtaGrid.SelectedRows.Count > 0 Then
            If dtaGrid.SelectedRows(0).Cells("usa_serie").Value = "SI" Then
                num_movimiento = dtaGrid.SelectedRows(0).Cells("num_movimiento").Value
                cod_producto = dtaGrid.SelectedRows(0).Cells("cod_producto").Value
                frmMovimientosSerie.Show()
            End If
        End If
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Call ExportarAExcel(dtaGrid)
    End Sub
End Class