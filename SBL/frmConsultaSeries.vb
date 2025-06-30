Public Class frmConsultaSeries
    Private Sub cargarDatos()
        Dim ds As New DataSet
        Dim dta As New DataTable
        Dim sqla As String = ""
        sql = "SELECT id_serie"
        sql += ",cod_producto"
        sql += ",desc_producto"
        sql += ",estado_serie"
        sql += ",desc_estado"
        sql += ",fecha_estado"
        sql += ",id_ubicacion"
        sql += ",observacion "
        sql += "FROM dbo.get_series() "
        sql += "WHERE cod_producto = '" & cod_producto & "'"
        sql += "AND id_ubicacion = '" & id_ubicacion & "'"
        sql += "AND estado_serie = 'ACT'"
        sql += "ORDER BY estado_serie"
        dta.TableName = "series"
        dta = execDataSet(sql, csql).Tables("Sql")
        erpResultados.FooterText = dta.Rows.Count.ToString & " AA"
        dtaGrid.AutoGenerateColumns = False
        dtaGrid.Columns.Clear()
        dtaGrid.Columns.Add("id_serie", "Serie")
        dtaGrid.Columns.Add("cod_producto", "Cod. Producto")
        dtaGrid.Columns.Add("desc_producto", "Desc. Producto")
        dtaGrid.Columns.Add("desc_estado", "Desc. Estado")
        dtaGrid.Columns.Add("fecha_estado", "Fecha")
        dtaGrid.Columns.Add("observacion", "observacion")
        dtaGrid.Columns.Add("id_ubicacion", "Ubicacion")
        dtaGrid.Columns("id_serie").DataPropertyName = "id_serie"
        dtaGrid.Columns("cod_producto").DataPropertyName = "cod_producto"
        dtaGrid.Columns("desc_producto").DataPropertyName = "desc_producto"
        dtaGrid.Columns("desc_estado").DataPropertyName = "desc_estado"
        dtaGrid.Columns("fecha_estado").DataPropertyName = "fecha_estado"
        dtaGrid.Columns("observacion").DataPropertyName = "observacion"
        dtaGrid.Columns("id_ubicacion").DataPropertyName = "id_ubicacion"
        dtaGrid.Columns("id_serie").Width = 90
        dtaGrid.Columns("cod_producto").Width = 100
        dtaGrid.Columns("desc_producto").Width = 300
        dtaGrid.Columns("desc_estado").Width = 80
        dtaGrid.Columns("fecha_estado").Width = 120
        dtaGrid.Columns("observacion").Width = 120
        dtaGrid.Columns("id_ubicacion").Width = 90
        dtaGrid.DataSource = dta
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    'if press double click in row of the data grid open a msgbox to insert observacion'

    Private Sub dtaGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtaGrid.CellDoubleClick
        Dim id_serie As String = ""
        Dim cod_producto As String = ""
        Dim desc_producto As String = ""
        Dim desc_estado As String = ""
        Dim fecha_estado As String = ""
        Dim observacion As String = ""
        Dim id_ubicacion As String = ""
        'if dtaGrid.CurrentRow.Cells(6).Value is null'
        If dtaGrid.CurrentRow.Cells(0).Value Is DBNull.Value Then
            id_serie = ""
        Else
            id_serie = dtaGrid.CurrentRow.Cells(0).Value
        End If

        If dtaGrid.CurrentRow.Cells(1).Value Is DBNull.Value Then
            cod_producto = ""
        Else
            cod_producto = dtaGrid.CurrentRow.Cells(1).Value
        End If

        If dtaGrid.CurrentRow.Cells(2).Value Is DBNull.Value Then
            desc_producto = ""
        Else
            desc_producto = dtaGrid.CurrentRow.Cells(2).Value
        End If


        If dtaGrid.CurrentRow.Cells(3).Value Is DBNull.Value Then
            desc_estado = ""
        Else
            desc_estado = dtaGrid.CurrentRow.Cells(3).Value
        End If

        If dtaGrid.CurrentRow.Cells(4).Value Is DBNull.Value Then
            fecha_estado = ""
        Else
            fecha_estado = dtaGrid.CurrentRow.Cells(4).Value
        End If

        If dtaGrid.CurrentRow.Cells(5).Value Is DBNull.Value Then
            observacion = ""
        Else
            observacion = dtaGrid.CurrentRow.Cells(5).Value
        End If

        If dtaGrid.CurrentRow.Cells(6).Value Is DBNull.Value Then
            id_ubicacion = ""
        Else
            id_ubicacion = dtaGrid.CurrentRow.Cells(6).Value
        End If



        'observacion = inputbox and inputbox text= observacion'
        observacion = InputBox("Observacion", "Observacion", observacion)
        If observacion <> "" Then
            sql = "update series set observacion='" & observacion & "' where id_serie='" & id_serie & "' and cod_producto='" & cod_producto & "'"
            Call execUpdate(sql, csql)
            cargarDatos()
        End If
        cargarDatos()

    End Sub
    Private Sub frmConsultaSeries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Call ExportarAExcel(dtaGrid)
    End Sub
End Class