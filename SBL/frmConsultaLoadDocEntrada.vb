Imports System.Data.SqlClient
Public Class frmConsultaLoadDocEntrada
    Private Sub cargarDatosEntrada()
        Dim ds As New DataSet
        Dim dta As New DataTable
        sql = "SELECT id_documento_entrada"
        sql += ",nombre_proveedor"
        sql += ",id_proveedor"
        sql += ",fecha_creacion"
        sql += ",desc_estado"
        sql += ",descripcion"
        sql += ",observaciones "
        sql += "FROM get_documentos_entrada_resumen() "
        If gEstado <> "" Then
            sql += "WHERE estado_documento = '" & gEstado & "'"
        End If
        dta.TableName = "registros"
        dta = execDataSet(sql, csql).Tables("Sql")
        erpResultados.FooterText = dta.Rows.Count.ToString & " resultado(s)"
        dtaGrid.AutoGenerateColumns = False
        dtaGrid.Columns.Clear()
        dtaGrid.Columns.Add("descripcion", "Tipo Doc.")
        dtaGrid.Columns.Add("id_documento_entrada", "Número Doc.")
        dtaGrid.Columns.Add("id_proveedor", "Rut Proveedor")
        dtaGrid.Columns.Add("nombre_proveedor", "Proveedor")
        dtaGrid.Columns.Add("fecha_creacion", "Fecha")
        dtaGrid.Columns.Add("observaciones", "Observaciones")
        dtaGrid.Columns.Add("desc_estado", "Estado")
        dtaGrid.Columns(0).DataPropertyName = "descripcion"
        dtaGrid.Columns(1).DataPropertyName = "id_documento_entrada"
        dtaGrid.Columns(2).DataPropertyName = "id_proveedor"
        dtaGrid.Columns(3).DataPropertyName = "nombre_proveedor"
        dtaGrid.Columns(4).DataPropertyName = "fecha_creacion"
        dtaGrid.Columns(5).DataPropertyName = "Observaciones"
        dtaGrid.Columns(6).DataPropertyName = "desc_estado"
        dtaGrid.Columns(0).Width = 60
        dtaGrid.Columns(1).Width = 70
        dtaGrid.Columns(2).Width = 80
        dtaGrid.Columns(3).Width = 150
        dtaGrid.Columns(4).Width = 90
        dtaGrid.Columns(5).Width = 170
        dtaGrid.Columns(6).Width = 80
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
        Me.Tag = dtaGrid.SelectedRows(0).Cells(0).Value & ";" & dtaGrid.SelectedRows(0).Cells(1).Value
        Me.Close()
    End Sub

End Class