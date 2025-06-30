Public Class frmTrackingSeries
    Private Sub frmTrackingSeries_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cargarDatos()
        Dim ds As New DataSet
        Dim dta As New DataTable
        Dim sqla As String = ""
        sql = "select movimientos.tipo_movimiento,movimientos.num_movimiento, movimientos.cod_producto,movimientos_series.id_serie from movimientos_series "
        sql += "inner join movimientos "
        sql += "on movimientos.num_movimiento = movimientos_series.num_movimiento "
        sql += "where movimientos_series.id_serie like '%" & txtSerie.Text & "%'"
        dta.TableName = "series"
        dta = execDataSet(sql, csql).Tables("Sql")
        erpResultados.FooterText = dta.Rows.Count.ToString & " AA"
        dtaGrid.AutoGenerateColumns = False
        dtaGrid.Columns.Clear()
        dtaGrid.Columns.Add("tipo_movimiento", "tipo_movimiento")
        dtaGrid.Columns.Add("num_movimiento", "num_movimiento")
        dtaGrid.Columns.Add("cod_producto", " cod_producto")
        dtaGrid.Columns.Add("id_serie", "id_serie")
        dtaGrid.Columns("tipo_movimiento").DataPropertyName = "tipo_movimiento"
        dtaGrid.Columns("num_movimiento").DataPropertyName = "num_movimiento"
        dtaGrid.Columns("cod_producto").DataPropertyName = "cod_producto"
        dtaGrid.Columns("id_serie").DataPropertyName = "id_serie"
        dtaGrid.Columns("tipo_movimiento").Width = 90
        dtaGrid.Columns("num_movimiento").Width = 90
        dtaGrid.Columns("cod_producto").Width = 100
        dtaGrid.Columns("id_serie").Width = 300
        dtaGrid.DataSource = dta
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSerie.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cargarDatos()
    End Sub
End Class