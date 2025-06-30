Public Class frmMovimientosSerie
    Private Sub frmMovimientosSerie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub
    Private Sub cargarDatos()
        Dim ds As New DataSet
        Dim dta As New DataTable
        Dim sqla As String = ""
        sql = "select movimientos.num_movimiento, movimientos.cod_producto,movimientos_series.id_serie from movimientos_series "
        sql += "inner join movimientos "
        sql += "on movimientos.num_movimiento = movimientos_series.num_movimiento "
        sql += "where movimientos.num_movimiento=" & num_movimiento & ""
        dta.TableName = "series"
        dta = execDataSet(sql, csql).Tables("Sql")
        erpResultados.FooterText = dta.Rows.Count.ToString & " AA"
        dtaGrid.AutoGenerateColumns = False
        dtaGrid.Columns.Clear()
        dtaGrid.Columns.Add("num_movimiento", "num_movimiento")
        dtaGrid.Columns.Add("cod_producto", " cod_producto")
        dtaGrid.Columns.Add("id_serie", "id_serie")
        dtaGrid.Columns("num_movimiento").DataPropertyName = "num_movimiento"
        dtaGrid.Columns("cod_producto").DataPropertyName = "cod_producto"
        dtaGrid.Columns("id_serie").DataPropertyName = "id_serie"
        dtaGrid.Columns("num_movimiento").Width = 90
        dtaGrid.Columns("cod_producto").Width = 100
        dtaGrid.Columns("id_serie").Width = 300
        dtaGrid.DataSource = dta
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()

    End Sub
End Class