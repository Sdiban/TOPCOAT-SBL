Imports System.Data.SqlClient
Public Class frmConsultaLoadCompras
    Private Sub cargarDatosEntrada()
        Dim ds As New DataSet
        Dim dta As New DataTable
        sql = "SELECT id_documento_compra"
        sql += ",id_proveedor"
        sql += ",nombre_proveedor"
        sql += ",fecha_creacion"
        sql += ",desc_estado"
        sql += ",descripcion"
        sql += ",observaciones "
        sql += "FROM get_documentos_compra_resumen() "
        If gEstado <> "" Then
            sql += "WHERE estado_documento = '" & gEstado & "'"
        End If
        dta.TableName = "registros"
        dta = execDataSet(sql, csql).Tables("Sql")
        erpResultados.FooterText = dta.Rows.Count.ToString & " resultado(s)"
        dtaGrid.AutoGenerateColumns = False
        dtaGrid.Columns.Clear()
        dtaGrid.Columns.Add("descripcion", "Tipo Doc.")
        dtaGrid.Columns.Add("id_documento_compra", "Número Doc.")
        dtaGrid.Columns.Add("id_proveedor", "Rut Proveedor")
        dtaGrid.Columns.Add("nombre_proveedor", "Proveedor")
        dtaGrid.Columns.Add("fecha_creacion", "Fecha")
        dtaGrid.Columns.Add("observaciones", "Observaciones")
        dtaGrid.Columns.Add("desc_estado", "Estado")
        dtaGrid.Columns("descripcion").DataPropertyName = "descripcion"
        dtaGrid.Columns("id_documento_compra").DataPropertyName = "id_documento_compra"
        dtaGrid.Columns("id_proveedor").DataPropertyName = "id_proveedor"
        dtaGrid.Columns("nombre_proveedor").DataPropertyName = "nombre_proveedor"
        dtaGrid.Columns("fecha_creacion").DataPropertyName = "fecha_creacion"
        dtaGrid.Columns("Observaciones").DataPropertyName = "Observaciones"
        dtaGrid.Columns("desc_estado").DataPropertyName = "desc_estado"
        dtaGrid.Columns("descripcion").Width = 60
        dtaGrid.Columns("id_documento_compra").Width = 70
        dtaGrid.Columns("id_proveedor").Width = 80
        dtaGrid.Columns("nombre_proveedor").Width = 150
        dtaGrid.Columns("fecha_creacion").Width = 90
        dtaGrid.Columns("Observaciones").Width = 170
        dtaGrid.Columns("desc_estado").Width = 80
        dtaGrid.DataSource = dta
    End Sub
    Private Sub frmConsultaLoadDocEntrada_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ReleaseVentana(Me)
    End Sub
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Tag = "CANCEL"
        Me.Close()
    End Sub
    Private Sub frmConsultaLoadDocEntrada_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call cargarDatosEntrada()
    End Sub
    Private Sub dtaGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtaGrid.DoubleClick
        If dtaGrid.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        Me.Tag = dtaGrid.SelectedRows(0).Cells("descripcion").Value & ";" & dtaGrid.SelectedRows(0).Cells("id_documento_compra").Value
        Me.Close()
    End Sub
End Class