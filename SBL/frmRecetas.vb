Imports System.Data.SqlClient
Public Class frmRecetas
    Public jdt As DataTable
    Public jrow As DataRow
    Private Sub CargarReceta()
        Dim dt As New DataTable
        Dim sqla As String = ""
        sql = "SELECT id_receta"
        sql += ",cod_producto"
        sql += ",desc_producto"
        sql += ",id_usuario"
        sql += ",nombre_usuario"
        sql += ",fecha_creacion"
        sql += ",fecha_modificacion"
        sql += ",id_usuariomodificacion"
        sql += ",nombre_usuario_modif"
        sql += ",desc_estado "
        sql += "FROM get_recetas() "
        dt = execDataSet(sql, csql).Tables("Sql")
        dtaGrid.AutoGenerateColumns = False
        dtaGrid.Columns.Clear()
        dtaGrid.Columns.Add("id_receta", "RECETA")
        dtaGrid.Columns.Add("cod_producto", "CÓDIGO PROD.")
        dtaGrid.Columns.Add("desc_producto", "DESCRIPCIÓN")
        dtaGrid.Columns.Add("nombre_usuario", "NOMBRE")
        dtaGrid.Columns.Add("fecha_creacion", "FECHA CREACION")
        dtaGrid.Columns.Add("fecha_modificacion", "FECHA MODIFICACIÓN")
        dtaGrid.Columns.Add("nombre_usuario_modif", "USUARIO MODIFICACION")
        dtaGrid.Columns.Add("desc_estado", "ESTADO")
        dtaGrid.Columns("id_receta").DataPropertyName = "id_receta"
        dtaGrid.Columns("cod_producto").DataPropertyName = "cod_producto"
        dtaGrid.Columns("desc_producto").DataPropertyName = "desc_producto"
        dtaGrid.Columns("nombre_usuario").DataPropertyName = "nombre_usuario"
        dtaGrid.Columns("fecha_creacion").DataPropertyName = "fecha_creacion"
        dtaGrid.Columns("fecha_modificacion").DataPropertyName = "fecha_modificacion"
        dtaGrid.Columns("nombre_usuario_modif").DataPropertyName = "nombre_usuario_modif"
        dtaGrid.Columns("desc_estado").DataPropertyName = "desc_estado"
        dtaGrid.Columns("id_receta").Width = 50
        dtaGrid.Columns("cod_producto").Width = 150
        dtaGrid.Columns("desc_producto").Width = 280
        dtaGrid.Columns("nombre_usuario").Width = 150
        dtaGrid.Columns("fecha_creacion").Width = 100
        dtaGrid.Columns("fecha_modificacion").Width = 100
        dtaGrid.Columns("nombre_usuario_modif").Width = 150
        dtaGrid.Columns("desc_estado").Width = 100
        dtaGrid.DataSource = dt
        jdt.Rows.Clear()
        dtaDetalles.DataSource = Nothing
    End Sub
    Private Sub CargarRecetaDetalle(ByVal idReceta As String)
        Dim ds As New DataSet
        Dim dta As New DataTable
        Dim dr As SqlDataReader = Nothing
        sql = "SELECT id_receta"
        sql += ",cod_producto"
        sql += ",desc_producto"
        sql += ",cod_productoreceta"
        sql += ",desc_prodreceta"
        sql += ",cantidad"
        sql += ",fecha_incorporacion "
        sql += "FROM dbo.get_recetas_detalles('" & idReceta & "') "
        dta.TableName = "recetas_detalles"
        Try
            jdt.Clear()
            dr = execQuery(sql, csql)
            While dr.Read
                jrow = jdt.NewRow()
                jrow("cod_producto") = dr("cod_producto")
                jrow("desc_producto") = dr("desc_producto")
                jrow("cod_productoreceta") = dr("cod_productoreceta")
                jrow("desc_prodreceta") = dr("desc_prodreceta")
                jrow("cantidad") = dr("cantidad")
                jrow("fecha_incorporacion") = dr("fecha_incorporacion")
                jdt.Rows.Add(jrow)
            End While
            dr.Close()
            'erpResultados.FooterText = jdt.Rows.Count.ToString & " resultado(s)"
            dtaDetalles.DataSource = jdt
        Catch ex As Exception
        End Try
        dtaDetalles.EditMode = DataGridViewEditMode.EditOnEnter
    End Sub
    Public Sub CreaGrilla()
        dtaGrid.AutoGenerateColumns = False
        dtaGrid.Columns.Clear()
        dtaGrid.Columns.Add("cod_producto", "Producto")
        dtaGrid.Columns.Add("desc_producto", "Descripcion")
        dtaGrid.Columns.Add("cod_productoreceta", "Elemento Receta")
        dtaGrid.Columns.Add("desc_prodreceta", "Descripcion Elemento")
        dtaGrid.Columns.Add("cantidad", "Cantidad")
        dtaGrid.Columns.Add("fecha_incorporacion", "Fecha Incorporación")
        dtaGrid.Columns("cod_producto").DataPropertyName = "cod_producto"
        dtaGrid.Columns("desc_producto").DataPropertyName = "desc_producto"
        dtaGrid.Columns("cod_productoreceta").DataPropertyName = "cod_productoreceta"
        dtaGrid.Columns("desc_prodreceta").DataPropertyName = "desc_prodreceta"
        dtaGrid.Columns("cantidad").DataPropertyName = "cantidad"
        dtaGrid.Columns("fecha_incorporacion").DataPropertyName = "fecha_incorporacion"
        dtaGrid.Columns("cod_producto").Width = 150
        dtaGrid.Columns("desc_producto").Width = 250
        dtaGrid.Columns("cod_productoreceta").Width = 150
        dtaGrid.Columns("desc_prodreceta").Width = 250
        dtaGrid.Columns("cantidad").Width = 60
        dtaGrid.Columns("fecha_incorporacion").Width = 100
    End Sub
    Private Sub frmRecetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cod_producto = ""
        CreaGrilla()
        jdt = New DataTable("ParentTable177")
        Dim drG As DataRow = jdt.NewRow
        Dim column As DataColumn

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "cod_producto"
        column.ReadOnly = True
        jdt.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "desc_producto"
        column.ReadOnly = True
        jdt.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "cod_productoreceta"
        column.ReadOnly = True
        jdt.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "desc_prodreceta"
        column.ReadOnly = True
        jdt.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Int32")
        column.ColumnName = "cantidad"
        column.ReadOnly = True
        jdt.Columns.Add(column)

        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "fecha_incorporacion"
        column.ReadOnly = True
        jdt.Columns.Add(column)

        dtaGrid.DataSource = jdt

        Call CargaUsuarios(cmbUsuario)
        CargarReceta()
        'btnSave.Enabled = True
        'If dtaGrid.Rows.Count > 0 Then
        '    btnDel.Enabled = True
        '    btnAdd.Enabled = True
        '    btnELimina.Enabled = True
        'End If
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim fa As frmAddItemReceta = New frmAddItemReceta
        id_receta = dtaGrid.SelectedRows(0).Cells(0).Value
        cod_producto = dtaGrid.SelectedRows(0).Cells(1).Value
        desc_producto = dtaGrid.SelectedRows(0).Cells(2).Value
        fa.Tag = txtProducto.Text
        fa.frmPadre = Me
        fa.ShowDialog()
        fa.Dispose()
    End Sub
    Private Sub dtaGrid_Click(sender As Object, e As EventArgs) Handles dtaGrid.Click
        Me.Focus()
        If dtaGrid.SelectedRows.Count > 0 Then
            CargarRecetaDetalle(dtaGrid.SelectedRows(0).Cells(0).Value)
            btnSave.Enabled = False
            btnDel.Enabled = True
            btnAdd.Enabled = True
            btnELimina.Enabled = True
            btnGrabaItem.Enabled = True
        End If
    End Sub
    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If dtaGrid.SelectedRows.Count > 0 Then
            Dim resp As Integer = MsgBox("¿Esta seguro de cambiar el estado de la receta seleccionada?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WMS SCB")
            If resp = 6 Then
                Dim producto As String = ""
                Dim dg As DataGridViewRow
                For Each dg In dtaGrid.SelectedRows
                    producto = dg.Cells(1).Value
                    sql = "UPDATE receta_cabecera "
                    sql += "SET estado_receta = 'INA' "
                    sql += "WHERE cod_producto = '" & producto & "'"
                    Call execUpdate(sql, csql)
                Next
            End If
        End If
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub txtProducto_TextChanged(sender As Object, e As EventArgs) Handles txtProducto.TextChanged
        txtProducto.Text = UCase(txtProducto.Text)
        txtProducto.SelectionStart = Me.txtProducto.Text.Length + 1
    End Sub
    Private Sub txtProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProducto.KeyPress
        If Trim(txtProducto.Text) <> "" And e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            txtDescripcion.Text = ""
            sql = "SELECT * "
            sql += "FROM productos "
            sql += "WHERE cod_producto = '" & txtProducto.Text & "'"
            Dim dr As SqlDataReader = execQuery(sql, csql)
            If dr.Read Then
                txtDescripcion.Text = dr("desc_producto")
                dr.Close()
                btnSave.Enabled = True
            Else
                erpBusqueda.FooterText = "El código de producto ingresado no existe"
                tmrMensaje.Enabled = True
                txtProducto.Focus()
            End If
            dr.Close()
        End If
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim sql As String
        Dim secuencia As String
        If txtProducto.Text = "" And cod_producto = "" Then
            erpBusqueda.FooterText = "Debe Ingresar código del producto de la receta"
            tmrMensaje.Enabled = True
            Application.DoEvents()
            txtProducto.Focus()
            Exit Sub
        End If
        If cmbUsuario.Text = "" Then
            erpBusqueda.FooterText = "Debe selecionar el usuario que crea la receta"
            tmrMensaje.Enabled = True
            Application.DoEvents()
            txtProducto.Focus()
            Exit Sub
        End If
        sql = "SELECT * "
        sql += "FROM receta_cabecera "
        sql += "WHERE cod_producto = '" & Trim(txtProducto.Text) & "'"
        Dim dR As SqlDataReader = execQuery(sql, csql)
        If Not dR.Read Then
            dR.Close()
            sql = "INSERT INTO receta_cabecera(cod_producto"
            sql += ",id_usuario"
            sql += ",fecha_creacion"
            sql += ",estado_receta) "
            sql += "VALUES('" & txtProducto.Text & "'"
            sql += ",'" & cmbUsuario.SelectedItem.Key & "'"
            sql += ",Getdate()"
            sql += ",'ACT')"
            Call execUpdate(sql, csql)
            sql = "SELECT SCOPE_IDENTITY() as Num_Folio"
            dR = execQuery(sql, csql)
            If dR.Read Then
                secuencia = dR("Num_Folio")
            Else
                secuencia = "1"
            End If
            dR.Close()
        Else
            Dim resp As Integer = MsgBox("¿ Receta para el producto existe, confirma la modicicación ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SBL")
            If resp = 6 Then
                sql = "UPDATE receta_cabecera "
                sql += "SET fecha_modificacion = GETDATE() "
                sql += ",id_usuariomodificacion = '" & cmbUsuario.Text & "' "
                sql += "WHERE cod_producto = '" & Trim(txtProducto.Text) & "'"
                Call execUpdate(sql, csql)
            End If
        End If
        txtProducto.Text = ""
        txtDescripcion.Text = ""
        cmbUsuario.SelectedIndex = -1
        CargarReceta()
    End Sub
    Private Sub dtaDetalles_TextChanged(sender As Object, e As EventArgs) Handles dtaDetalles.TextChanged
        If dtaDetalles.SelectedRows.Count > 0 Then
            btnGrabaItem.Enabled = True
        End If
    End Sub
    Private Sub btnGrabaItem_Click(sender As Object, e As EventArgs) Handles btnGrabaItem.Click
        If dtaDetalles.Rows.Count > 0 Then
            sql = "SELECT * "
            sql += "FROM receta_detalle "
            sql += "WHERE id_receta = '" & id_receta & "'"
            Dim dR As SqlDataReader = execQuery(sql, csql)
            If dR.Read Then
                sql = "DELETE FROM receta_detalle "
                sql += "WHERE id_receta = '" & id_receta & "'"
                Call execUpdate(sql, csql)
            End If
            dR.Close()
            For i As Integer = 0 To dtaDetalles.Rows.Count - 1
                If Not dtaDetalles.Rows.Item(i) Is Nothing Then
                    sql = "INSERT INTO receta_detalle(id_receta"
                    sql += ",cod_productoreceta"
                    sql += ",cantidad"
                    sql += ",fecha_incorporacion) "
                    sql += "VALUES('" & id_receta & "'"
                    sql += ",'" & dtaDetalles.Rows.Item(i).Cells("cod_productoreceta").Value & "'"
                    sql += ",'" & dtaDetalles.Rows.Item(i).Cells("cantidad").Value & "'"
                    sql += ",Getdate())"
                    Call execUpdate(sql, csql)
                End If
            Next
            jdt.Rows.Clear()
            dtaDetalles.DataSource = Nothing
        End If
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim receta As String
        If txtProducto.Text = "" Then
            erpBusqueda.FooterText = "Debe Ingresar código producto de la receta"
            tmrMensaje.Enabled = True
            Application.DoEvents()
            txtProducto.Focus()
            Exit Sub
        End If
        sql = "SELECT * "
        sql += "FROM receta_cabecera "
        sql += "WHERE cod_producto = '" & Trim(txtProducto.Text) & "'"
        Dim dR As SqlDataReader = execQuery(sql, csql)
        If dR.Read Then
            receta = dR("id_receta")
            dR.Close()
            For i As Integer = 0 To dtaGrid.Rows.Count - 1
                If dtaGrid.Rows.Item(i).Cells("cod_producto").Value = txtProducto.Text Then
                    dtaGrid.Rows(i).Selected = True
                    dtaGrid.CurrentCell = dtaGrid.Rows(i).Cells(0)
                End If
            Next
            sql = "SELECT * "
            sql += "FROM receta_detalle "
            sql += "WHERE id_receta = '" & id_receta & "'"
            dR = execQuery(sql, csql)
            If dR.Read Then
                For i As Integer = 0 To dtaGrid.Rows.Count - 1
                    If dtaDetalles.Rows.Item(i).Cells("id_receta").Value = receta Then
                        dtaDetalles.Rows(i).Selected = True
                        dtaDetalles.CurrentCell = dtaDetalles.Rows(i).Cells(0)
                    End If
                Next
            End If
            dR.Close()
            txtProducto.Text = ""
            txtDescripcion.Text = ""
            erpBusqueda.FooterText = ""
            tmrMensaje.Enabled = True
            Application.DoEvents()
        Else
            dR.Close()
            erpBusqueda.FooterText = "No existe receta para el producto ingresado."
            tmrMensaje.Enabled = True
            Application.DoEvents()
            txtProducto.Text = ""
            txtDescripcion.Text = ""
            txtProducto.Focus()
            Exit Sub
        End If
    End Sub
    Private Sub btnELimina_Click(sender As Object, e As EventArgs) Handles btnELimina.Click
        If dtaDetalles.SelectedRows.Count > 0 Then
            dtaDetalles.Rows.Remove(dtaDetalles.CurrentRow)
        End If
    End Sub
End Class