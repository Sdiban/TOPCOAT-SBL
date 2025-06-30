Imports System.Data.SqlClient
Imports Klik.Windows.Forms.v1.EntryLib

Public Class frmExistencias
    Dim bMinimo As Boolean = False
    Dim bAgrupaProducto As Boolean = False
    Dim bCargando As Boolean = True
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Private Sub cargarDatos()
        Dim ds As New DataSet
        Dim dta As New DataTable
        Dim sqla As String = ""
        If bMinimo Or bAgrupaProducto Then
            sql = "SELECT cod_producto"
            sql += ",desc_producto"
            sql += ",cantidad_producto"
            sql += ",cantidad_compra"
            sql += ",minimo"
            sql += ",id_familia"
            sql += ",usa_serie"
            sql += ",valor_existencia "
            sql += "FROM dbo.get_existencias_por_producto() "
        Else
            sql = "SELECT cod_ubicacion"
            sql += ",cod_producto"
            sql += ",desc_producto"
            sql += ",cantidad_producto"
            sql += ",codigoint"
            sql += ",minimo"
            sql += ",maximo"
            sql += ",valor"
            sql += ",id_familia"
            sql += ",usa_serie "
            sql += "FROM get_existencias() "
        End If
        If Trim(txtUbicacion.Text) <> "" And Not bMinimo Then
            If Trim(sqla) = "" Then
                sqla = "WHERE cod_ubicacion Like '%" & txtUbicacion.Text & "%' "
            Else
                sqla += "And cod_ubicacion Like '%" & txtUbicacion.Text & "%' "
            End If
        End If
        If Trim(txtDescripcion.Text) <> "" Then
            If Trim(sqla) = "" Then
                sqla = "WHERE desc_producto Like '%" & txtDescripcion.Text & "%' "
            Else
                sqla += "And desc_producto Like '%" & txtDescripcion.Text & "%' "
            End If
        End If
        If Trim(txtCodigo.Text) <> "" Then
            If Trim(sqla) = "" Then
                sqla = "WHERE cod_producto like '%" & txtCodigo.Text & "%' or codigoint like '%" & txtCodigo.Text & "%' "
            Else
                sqla += "And cod_producto like '%" & txtCodigo.Text & "%'  or codigoint like '%" & txtCodigo.Text & "%' "
            End If
        End If
        If bMinimo Then
            If Trim(sqla) = "" Then
                sqla = "WHERE cantidad_producto < minimo "
            Else
                sqla += "And cantidad_producto < minimo "
            End If
        End If
        ' indice 0 es todo
        If cmbFamilia.SelectedIndex > 0 Then
            If Trim(sqla) = "" Then
                sqla += "WHERE id_familia = " & cmbFamilia.Items(cmbFamilia.SelectedIndex).Key & " "
            Else
                sqla += "and id_familia = " & cmbFamilia.Items(cmbFamilia.SelectedIndex).Key & " "
            End If
        End If
        If bMinimo Or bAgrupaProducto Then
            sqla += "ORDER BY cantidad_producto, cod_producto"
        End If
        dta.TableName = "existencias"
        dta = execDataSet(sql & sqla, csql).Tables("Sql")
        erpResultados.FooterText = dta.Rows.Count.ToString & " resultado(s)"
        dtaGrid.AutoGenerateColumns = False
        dtaGrid.Columns.Clear()
        If Not bAgrupaProducto And Not bMinimo Then
            dtaGrid.Columns.Add("cod_ubicacion", "Ubicacion")
        End If
        dtaGrid.Columns.Add("cod_producto", "Cod. Producto")
        dtaGrid.Columns.Add("desc_producto", "Desc. Producto")
        dtaGrid.Columns.Add("cantidad_producto", "Cantidad")
        If bAgrupaProducto Or bMinimo Then
            dtaGrid.Columns.Add("cantidad_compra", "Cantidad Compra")
        End If
        If Not bAgrupaProducto And Not bMinimo Then
            dtaGrid.Columns.Add("codigoint", "Cod. Interno")
        End If
        dtaGrid.Columns.Add("minimo", "Min")
        If Not bAgrupaProducto And Not bMinimo Then
            dtaGrid.Columns.Add("maximo", "Max")
        End If
        dtaGrid.Columns.Add("usa_serie", "Usa Serie")
        If Not bAgrupaProducto And Not bMinimo Then
            dtaGrid.Columns.Add("valor", "Valor")
        End If
        If bAgrupaProducto Or bMinimo Then
            dtaGrid.Columns.Add("valor_existencia", "Valor Existencia")
        End If
        If Not bAgrupaProducto And Not bMinimo Then
            dtaGrid.Columns("cod_ubicacion").DataPropertyName = "cod_ubicacion"
        End If
        dtaGrid.Columns("cod_producto").DataPropertyName = "cod_producto"
        dtaGrid.Columns("desc_producto").DataPropertyName = "desc_producto"
        dtaGrid.Columns("cantidad_producto").DataPropertyName = "cantidad_producto"
        If bAgrupaProducto Or bMinimo Then
            dtaGrid.Columns("cantidad_compra").DataPropertyName = "cantidad_compra"
        End If
        If Not bAgrupaProducto And Not bMinimo Then
            dtaGrid.Columns("codigoint").DataPropertyName = "codigoint"
        End If
        dtaGrid.Columns("minimo").DataPropertyName = "minimo"
        If Not bAgrupaProducto And Not bMinimo Then
            dtaGrid.Columns("maximo").DataPropertyName = "maximo"
        End If
        dtaGrid.Columns("usa_serie").DataPropertyName = "usa_serie"
        If Not bAgrupaProducto And Not bMinimo Then
            dtaGrid.Columns("valor").DataPropertyName = "valor"
        End If
        If bAgrupaProducto Or bMinimo Then
            dtaGrid.Columns("valor_existencia").DataPropertyName = "valor_existencia"
        End If
        If Not bAgrupaProducto And Not bMinimo Then
            dtaGrid.Columns("cod_ubicacion").Width = 90
        End If
        dtaGrid.Columns("cod_producto").Width = 80
        dtaGrid.Columns("desc_producto").Width = 300
        dtaGrid.Columns("cantidad_producto").Width = 60
        If bAgrupaProducto Or bMinimo Then
            dtaGrid.Columns("cantidad_compra").Width = 60
        End If
        If Not bAgrupaProducto And Not bMinimo Then
            dtaGrid.Columns("codigoint").Width = 80
        End If
        dtaGrid.Columns("minimo").Width = 60
        dtaGrid.Columns("usa_serie").Width = 60
        If Not bAgrupaProducto And Not bMinimo Then
            dtaGrid.Columns("maximo").Width = 60
            dtaGrid.Columns("valor").Width = 80
            dtaGrid.Columns("maximo").DefaultCellStyle.Format = "n0"
            dtaGrid.Columns("valor").DefaultCellStyle.Format = "n0"
        End If
        If bAgrupaProducto Or bMinimo Then
            dtaGrid.Columns("valor_existencia").Width = 80
            dtaGrid.Columns("valor_existencia").DefaultCellStyle.Format = "n0"
        End If
        dtaGrid.Columns("cantidad_producto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(3, Byte), Integer))
        dtaGrid.DataSource = dta
    End Sub
    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        bCargando = True
        Call cargarDatos()
        bCargando = False
    End Sub
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
    Private Sub frmExistencias_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        ReleaseVentana(Me)
    End Sub
    Private Sub frmExistencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarDatos()
        CargaFamilias()
    End Sub
    Private Sub dtaGrid_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dtaGrid.RowPostPaint
        If e Is Nothing Then
            Exit Sub
        End If
        If bAgrupaProducto Then
            If dtaGrid.Rows(e.RowIndex).Cells("cantidad_producto").Value < dtaGrid.Rows(e.RowIndex).Cells("minimo").Value Then
                For j = 0 To dtaGrid.ColumnCount - 1
                    dtaGrid.Rows(e.RowIndex).Cells(j).Style = DataGridViewCellStyle1
                Next
            End If
        End If
    End Sub
    Private Sub dtaGrid_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dtaGrid.RowsRemoved
        If bCargando Then
            Exit Sub
        End If
        Try
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim resp As MsgBoxResult
        Dim szLista As String = ""
        For Each dg In dtaGrid.SelectedRows
            szLista += dg.Cells(0).Value & " " & "" & dg.Cells(1).Value & vbCrLf
        Next
        If szLista.Length = 0 Then
            Exit Sub
        End If
        resp = MsgBox("Esta seguro de eliminar existencia ?" & vbCrLf & "Este proceso es irreversible" & vbCrLf & vbCrLf & szLista, MsgBoxStyle.YesNo)
        If resp = MsgBoxResult.Yes Then
            For Each dg In dtaGrid.SelectedRows
                execUpdate("DELETE FROM existencias WHERE cod_producto='" & dg.Cells(1).Value & "' and cod_ubicacion = '" & dg.Cells(0).Value & "'", csql)
            Next
            cargarDatos()
        End If
        Call cargarDatos()
    End Sub
    Private Sub txtDescripcion_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescripcion.TextChanged
        txtDescripcion.Text = UCase(txtDescripcion.Text)
        txtDescripcion.SelectionStart = Me.txtDescripcion.Text.Length + 1
        Call cargarDatos()
    End Sub
    Private Sub txtCodigo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged
        Call cargarDatos()
    End Sub
    Private Sub txtUbicacion_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUbicacion.TextChanged
        Call cargarDatos()
    End Sub
    Private Sub btnAgrupar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgrupar.Click
        bAgrupaProducto = Not bAgrupaProducto
        bMinimo = False
        If Not bAgrupaProducto Then
            btnAgrupar.Text = "EXISTENCIA POR PRODUCTO"
        Else
            btnAgrupar.Text = "EXISTENCIA POR UBICACIÓN"
        End If
        cargarDatos()
    End Sub
    Private Sub btnFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltro.Click
        bMinimo = Not bMinimo
        If bMinimo Then
            btnFiltro.Text = "MUESTRA TODOS"
        Else
            btnFiltro.Text = "FILTRAR X MINIMO"
        End If
        cargarDatos()
    End Sub
    Private Sub CargaFamilias()
        Try
            cmbFamilia.Items.Clear()
            Dim Cont As Integer = 0
            cmbFamilia.Items.Add("Todos")
            cmbFamilia.Items(Cont).Key = "-1"
            sql = "SELECT * "
            sql += "FROM familias"
            Dim dR As SqlDataReader = execQuery(sql, csql)
            While dR.Read
                Cont += 1
                cmbFamilia.Items.Add(dR("descripcion"))
                cmbFamilia.Items(Cont).Key = dR("id_familia")
            End While
            dR.Close()
        Catch ex As Exception
            MsgBox("Error de Aplicación: " & ex.Message)
        End Try
    End Sub
    Private Sub dtaGrid_Click(sender As Object, e As EventArgs) Handles dtaGrid.Click
        If dtaGrid.SelectedRows.Count > 0 Then
            If dtaGrid.SelectedRows(0).Cells("usa_serie").Value = "SI" Then
                cod_producto = dtaGrid.SelectedRows(0).Cells("cod_producto").Value
                id_ubicacion = dtaGrid.SelectedRows(0).Cells("cod_ubicacion").Value
                frmConsultaSeries.Show()
            End If
        End If
    End Sub


    Private Sub dtaGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtaGrid.CellContentClick

    End Sub


    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Call ExportarAExcel(dtaGrid)
    End Sub

End Class