Imports System.Data.SqlClient
Imports SBL.ntPrint
Public Class frmSeries
    Private Sub cargarDatos()
        Dim dt As New DataTable
        sql = "SELECT * "
        sql += "FROM dbo.get_series() "
        sql += "ORDER BY cod_producto, id_serie"
        dt = execDataSet(sql, csql).Tables("Sql")
        dtaGrid.AutoGenerateColumns = False
        dtaGrid.Columns.Clear()
        dtaGrid.Columns.Add("cod_producto", "CÓDIGO")
        dtaGrid.Columns.Add("desc_producto", "DESCRIPCIÓN")
        dtaGrid.Columns.Add("id_serie", "SERIE")
        dtaGrid.Columns.Add("desc_estado", "ESTADO")
        dtaGrid.Columns.Add("fecha_estado", "FECHA")
        dtaGrid.Columns.Add("documento_entrada", "DOCUMENTO ENTRADA")
        dtaGrid.Columns.Add("documento_salida", "DOCUMENTO SALIDA")
        dtaGrid.Columns("cod_producto").DataPropertyName = "cod_producto"
        dtaGrid.Columns("desc_producto").DataPropertyName = "desc_producto"
        dtaGrid.Columns("id_serie").DataPropertyName = "id_serie"
        dtaGrid.Columns("desc_estado").DataPropertyName = "desc_estado"
        dtaGrid.Columns("fecha_estado").DataPropertyName = "fecha_estado"
        dtaGrid.Columns("documento_entrada").DataPropertyName = "documento_entrada"
        dtaGrid.Columns("documento_salida").DataPropertyName = "documento_salida"
        dtaGrid.Columns("cod_producto").Width = 100
        dtaGrid.Columns("desc_producto").Width = 200
        dtaGrid.Columns("id_serie").Width = 80
        dtaGrid.Columns("desc_estado").Width = 80
        dtaGrid.Columns("fecha_estado").Width = 80
        dtaGrid.Columns("documento_entrada").Width = 80
        dtaGrid.Columns("documento_salida").Width = 80
        dtaGrid.DataSource = dt
    End Sub
    Private Sub frmSeries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cargarDatos()
        Call CargaEstados(cmbEstado, "SE")
        txtSerie.Enabled = False
        txtCodigo.Enabled = False
        txtDescripcion.Enabled = False
        cmbEstado.Enabled = False
        operador = "A"
    End Sub
    Private Sub dtaGrid_DoubleClick(sender As Object, e As EventArgs) Handles dtaGrid.DoubleClick
        If dtaGrid.SelectedRows.Count > 0 Then
            sql = "SELECT * "
            sql += "FROM dbo.get_series() "
            sql += "WHERE id_serie = '" & dtaGrid.SelectedRows(0).Cells(2).Value & "' "
            sql += "AND cod_producto = '" & dtaGrid.SelectedRows(0).Cells(0).Value & "' "
            Dim dr As SqlDataReader = execQuery(sql, csql)
            If dr.Read Then
                txtSerie.Text = dr("id_serie")
                txtCodigo.Text = dr("cod_producto")
                txtDescripcion.Text = dr("desc_producto")
                For i = 1 To cmbEstado.Items.Count - 1
                    If cmbEstado.Items(i).Key = dr("estado_serie") Then
                        cmbEstado.SelectedIndex = i
                        Exit For
                    End If
                Next
                If dr("estado_serie") = "DES" Then
                    cmbEstado.Enabled = False
                Else
                    cmbEstado.Enabled = True
                End If
                txtCodigo.Focus()
                operador = "U"
            Else
                erpEdicion.FooterText = "Error al cargar los datos de la serie"
                tmrMensaje.Enabled = True
            End If
            dr.Close()
        End If
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        txtSerie.Text = ""
        txtCodigo.Text = ""
        txtDescripcion.Text = ""
        cmbEstado.SelectedIndex = -1
        cmbEstado.Enabled = False
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cmbEstado.SelectedIndex < 0 Then
            erpEdicion.FooterText = "Debe selacionar un estado para la serie"
            tmrMensaje.Enabled = True
            Application.DoEvents()
            cmbEstado.Focus()
            Exit Sub
        End If
        sql = "UPDATE series "
        sql += "SET estado_serie = '" & cmbEstado.Items(cmbEstado.SelectedIndex).Key & "' "
        sql += ",fecha_estado = getdate() "
        sql += "WHERE id_serie = '" & dtaGrid.SelectedRows(0).Cells(2).Value & "' "
        sql += "AND cod_producto = '" & dtaGrid.SelectedRows(0).Cells(0).Value & "' "
        Call execUpdate(sql, csql)
        cargarDatos()
    End Sub

    Private Sub cmbEstado_Click(sender As Object, e As EventArgs) Handles cmbEstado.Click

    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Call ExportarAExcel(dtaGrid)
    End Sub
End Class