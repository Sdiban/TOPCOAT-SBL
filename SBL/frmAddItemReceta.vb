Imports System.Data.SqlClient
Public Class frmAddItemReceta
    Public frmPadre As frmRecetas
    Dim existe As Boolean = False
    Dim istock As Integer
    Dim dta As New DataTable
    Private Sub cargarDatos()
        Dim sqla As String = ""
        Dim bAnd As Boolean = False
        dta.Clear()
        sql = "SELECT cod_producto"
        sql += ",desc_producto"
        sql += ",codigoint "
        sql += "FROM productos "
        If Trim(txtBuscar.Text) <> "" Then
            sql += "WHERE (cod_producto like '%" & txtBuscar.Text & "%' or codigoint like '%" & txtBuscar.Text & "%' or desc_producto like '%" & txtBuscar.Text & "%') "
        End If
        sql += "ORDER BY cod_producto"
        dta.TableName = "productos"
        dta = execDataSet(sql & sqla, csql).Tables("Sql")
        dtaGrid.AutoGenerateColumns = False
        dtaGrid.Columns.Clear()
        dtaGrid.Columns.Add("cod_producto", "CÓDIGO")
        dtaGrid.Columns.Add("codigoint", "CÓDIGO INT")
        dtaGrid.Columns.Add("desc_producto", "DESCRIPCIÓN")
        dtaGrid.Columns("cod_producto").DataPropertyName = "cod_producto"
        dtaGrid.Columns("codigoint").DataPropertyName = "codigoint"
        dtaGrid.Columns("desc_producto").DataPropertyName = "desc_producto"
        dtaGrid.Columns("cod_producto").Width = 200
        dtaGrid.Columns("codigoint").Width = 100
        dtaGrid.Columns("desc_producto").Width = 310
        dtaGrid.DataSource = dta
    End Sub
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim lProducto As String = ""
        If Not existe Then
            erpDetalle.FooterText = "el codigo ingresado no existe"
            tmrMensaje.Enabled = True
            txtBuscar.Text = ""
            txtBuscar.Text = ""
            txtCantidad.Text = "0"
            txtBuscar.Focus()
            Exit Sub
        End If
        If Val(txtCantidad.Text) < 1 Then
            erpDetalle.FooterText = "debe ingresar la cantidad de producto para la receta"
            tmrMensaje.Enabled = True
            txtCantidad.Focus()
            Exit Sub
        End If
        Try
            frmPadre.jrow = frmPadre.jdt.NewRow()
            frmPadre.jrow("cod_producto") = cod_producto
            frmPadre.jrow("desc_producto") = desc_producto
            frmPadre.jrow("cod_productoreceta") = dtaGrid.SelectedRows(0).Cells(0).Value
            lProducto = dtaGrid.SelectedRows(0).Cells(0).Value
            frmPadre.jrow("desc_prodreceta") = lblDescripcion.Text
            frmPadre.jrow("cantidad") = txtCantidad.Text
            frmPadre.jrow("fecha_incorporacion") = Now
            frmPadre.jdt.Rows.Add(frmPadre.jrow)
            frmPadre.dtaDetalles.DataSource = frmPadre.jdt
        Catch ex As Exception
        End Try
        existe = False
        txtCantidad.Text = "0"
        txtBuscar.Text = ""
        erpDetalle.FooterText = "Producto " & lProducto & " - " & lblDescripcion.Text & " fue agregado a la receta"
        lblDescripcion.Text = ""
        tmrMensaje.Enabled = True
        txtBuscar.Focus()
    End Sub
    Private Sub txtDescripcion_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.GotFocus
        txtBuscar.SelectionStart = 0
        txtBuscar.SelectionLength = Len(txtBuscar.Text)
    End Sub
    Private Sub txtBuscar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        txtBuscar.SelectionStart = 0
        txtBuscar.SelectionLength = Len(txtBuscar.Text)
    End Sub
    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Trim(txtBuscar.Text) <> "" And e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            lblDescripcion.Text = ""
            sql = "SELECT * "
            sql += "FROM productos "
            sql += "WHERE cod_producto = '" & txtBuscar.Text & "'"
            Dim dr As SqlDataReader = execQuery(sql, csql)
            If dr.Read Then
                existe = True
                lblDescripcion.Text = dr("desc_producto")
                dr.Close()
                If dtaGrid.RowCount > 0 Then
                    dtaGrid.Rows(0).Selected = True
                End If
                txtCantidad.Enabled = True
                txtCantidad.Focus()
            Else
                erpDetalle.FooterText = "el codigo ingresado no existe"
                tmrMensaje.Enabled = True
            End If
            dr.Close()
        End If
    End Sub
    Private Sub txtCantidad_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidad.GotFocus
        txtCantidad.SelectionStart = 0
        txtCantidad.SelectionLength = Len(txtCantidad.Text)
    End Sub
    Private Sub dtaGrid_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        txtCantidad.Focus()
    End Sub
    Private Sub txtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Val(txtCantidad.Text) > 0 And e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            btnAdd.Focus()
        End If
    End Sub
    Private Sub txtBuscar_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        cargarDatos()
    End Sub
    Private Sub frm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        ReleaseVentana(Me)
    End Sub
    Private Sub dtaGrid_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtaGrid.Click
        dtaGrid_DoubleClick(sender, e)
    End Sub
    Private Sub dtaGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtaGrid.DoubleClick
        If dtaGrid.SelectedRows.Count > 0 Then
            lblDescripcion.Text = dtaGrid.SelectedRows(0).Cells(2).Value
            existe = True
            txtCantidad.Enabled = True
            txtCantidad.Focus()
            erpDetalle.FooterText = ""
            tmrMensaje.Enabled = True
        End If
    End Sub
    Private Sub txtDescripcion_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        cargarDatos()
    End Sub
    Private Sub frmAddItemSalida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarDatos()
        txtBuscar.Focus()
    End Sub
    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        txtBuscar.Text = ""
        txtBuscar.Text = ""
        lblDescripcion.Text = ""
        txtBuscar.Focus()
    End Sub
    Private Sub txtDescripcion_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.Leave
        If dtaGrid.RowCount > 0 Then
            dtaGrid.Rows(0).Selected = True
        End If
    End Sub
End Class