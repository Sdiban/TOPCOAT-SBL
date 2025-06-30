Imports System.Data.SqlClient
Public Class frmAddItemEntrada
    Dim existe As Boolean = False
    Public frmpadre As frmLoadDocEntrada
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
    'Private Sub txtDescripcion_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.GotFocus
    '    txtBuscar.SelectionStart = 0
    '    txtBuscar.SelectionLength = Len(txtBuscar.Text)
    'End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'validar seleccion en data
        'cantidad
        If Not existe Then
            erpDetalle.FooterText = "el codigo ingresado no existe"
            tmrMensaje.Enabled = True
            txtBuscar.Text = ""
            txtBuscar.Focus()
            Exit Sub
        End If
        If Val(txtCantidad.Text) < 1 Then
            erpDetalle.FooterText = "debe ingresar la cantidad a agregar del producto"
            tmrMensaje.Enabled = True
            txtCantidad.Focus()
            Exit Sub
        End If
        Dim mrow As DataRow
        Dim bEncontrado As Boolean = False
        Dim iDx As Integer = 0
        Dim iCan As Integer = 0
        Dim iAlm As Integer = 0
        For Each mrow In frmpadre.jdt.Rows
            If mrow("cod_producto") = dtaGrid.SelectedRows(0).Cells(0).Value Then
                bEncontrado = True
                iCan = CInt(mrow("cantidad"))
                iAlm = CInt(mrow("cantidad_recibida"))
                Exit For
            End If
            iDx += 1
        Next
        If bEncontrado Then
            Dim mr As MsgBoxResult
            mr = MsgBox("Producto ya ingresado, con cantidad : " & iCan & vbCrLf & " Desea adicionar esta nueva cantidad " & txtCantidad.Text & " ?", MsgBoxStyle.YesNo)
            If mr = MsgBoxResult.No Then
                erpDetalle.FooterText = "Producto ya se encuentra en documento"
                tmrMensaje.Enabled = True
                txtBuscar.Text = ""
                txtCantidad.Text = "0"
                txtBuscar.Text = ""
                txtBuscar.Focus()
                Exit Sub
            Else
                frmpadre.dtaGrid.Rows.RemoveAt(iDx)
                Try
                    frmpadre.jrow = frmpadre.jdt.NewRow()
                    frmpadre.jrow("cod_producto") = dtaGrid.SelectedRows(0).Cells(0).Value
                    frmpadre.jrow("codigoint") = dtaGrid.SelectedRows(0).Cells(1).Value
                    frmpadre.jrow("desc_producto") = lblDescripcion.Text
                    frmpadre.jrow("cantidad") = txtCantidad.Text + iCan
                    frmpadre.jrow("cantidad_recibida") = iAlm.ToString
                    frmpadre.jdt.Rows.Add(frmpadre.jrow)
                    frmpadre.dtaGrid.DataSource = frmpadre.jdt
                Catch ex As Exception
                End Try
            End If
        Else
            Try
                frmpadre.jrow = frmpadre.jdt.NewRow()
                frmpadre.jrow("cod_producto") = dtaGrid.SelectedRows(0).Cells(0).Value
                frmpadre.jrow("codigoint") = dtaGrid.SelectedRows(0).Cells(1).Value
                frmpadre.jrow("desc_producto") = lblDescripcion.Text
                frmpadre.jrow("cantidad") = txtCantidad.Text
                frmpadre.jrow("cantidad_recibida") = "0"
                frmpadre.jdt.Rows.Add(frmpadre.jrow)
                frmpadre.dtaGrid.DataSource = frmpadre.jdt
            Catch ex As Exception
            End Try
        End If
        existe = False
        txtCantidad.Text = "0"
        txtBuscar.Text = ""
        lblDescripcion.Text = ""
        erpDetalle.FooterText = "codigo " & txtBuscar.Text & " agregado al documento"
        tmrMensaje.Enabled = True
        txtBuscar.Focus()
    End Sub
    Private Sub tmrMensaje_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMensaje.Tick
        erpDetalle.FooterText = ""
        tmrMensaje.Enabled = False
    End Sub
    'Private Sub txtBuscar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
    '    txtBuscar.SelectionStart = 0
    '    txtBuscar.SelectionLength = Len(txtBuscar.Text)
    'End Sub
    'Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If Trim(txtBuscar.Text) <> "" And e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
    '        sql = "SELECT * FROM productos WHERE cod_producto = '" & txtBuscar.Text & "'"
    '        Dim dr As SqlDataReader = execQuery(sql, csql)
    '        If dr.Read Then
    '            existe = True
    '            lblDescripcion.Text = dr("desc_producto")
    '            txtCantidad.Enabled = True
    '            txtCantidad.Focus()
    '        Else
    '            erpDetalle.FooterText = "el codigo ingresado no existe"
    '            tmrMensaje.Enabled = True
    '        End If
    '        dr.Close()
    '    End If
    'End Sub
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
    'Private Sub txtBuscar_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    cargarDatos()
    'End Sub
    Private Sub frm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ReleaseVentana(Me)
    End Sub
    Private Sub frmAddItemEntrada_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarDatos()
        txtBuscar.Focus()
    End Sub
    Private Sub cargarDatos()
        Dim dta As New DataTable
        Dim sqla As String = ""
        sql = "SELECT * FROM productos "
        If Trim(txtBuscar.Text) <> "" Then
            sql += " WHERE (cod_producto like '%" & txtBuscar.Text & "%' or codigoint like '%" & txtBuscar.Text & "%' or desc_producto like '%" & txtBuscar.Text & "%')"
        End If
        sql += " ORDER BY cod_producto"
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
        dtaGrid.Columns("codigoint").Width = 150
        dtaGrid.Columns("cod_producto").Width = 150
        dtaGrid.Columns("desc_producto").Width = 600
        dtaGrid.DataSource = dta
        If dtaGrid.RowCount > 0 Then
            dtaGrid.Rows(0).Selected = True
        End If
    End Sub
    Private Sub dtaGrid_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtaGrid.Click
        If dtaGrid.SelectedRows.Count > 0 Then
            'cargar datos a tab 0
            lblDescripcion.Text = dtaGrid.SelectedRows(0).Cells(2).Value
            existe = True
            txtCantidad.Enabled = True
            txtCantidad.Focus()
        End If
    End Sub
    Private Sub dtaGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtaGrid.DoubleClick
        If dtaGrid.SelectedRows.Count > 0 Then
            'cargar datos a tab 0
            lblDescripcion.Text = dtaGrid.SelectedRows(0).Cells(2).Value
            existe = True
            txtCantidad.Enabled = True
            txtCantidad.Focus()
        End If
    End Sub
    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        txtBuscar.Text = ""
        txtBuscar.Text = ""
        lblDescripcion.Text = ""
        txtBuscar.Focus()
    End Sub
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim fa As FrmIngresaProducto = New FrmIngresaProducto
        fa.Tag = txtCantidad.Text
        fa.frmpadre1 = Me
        fa.ShowDialog()
        fa.Dispose()
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        cargarDatos()
    End Sub
End Class