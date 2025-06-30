Imports System.Data.SqlClient
Public Class frmAddItemCompra
    Dim existe As Boolean = False
    Public frmpadre As frmLoadCompras
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
    Private Sub txtDescripcion_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.GotFocus
        txtBuscar.SelectionStart = 0
        txtBuscar.SelectionLength = Len(txtBuscar.Text)
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'validar seleccion en data cantidad
        If Not existe Then
            MsgBox("El código ingresado no existe.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "TDS - SBL")
            txtBuscar.Text = ""
            txtBuscar.Focus()
            Exit Sub
        End If
        If Val(txtCantidad.Text) < 1 Then
            MsgBox("Debe ingresar la cantidad a agregar del producto.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "TDS - SBL")
            txtCantidad.Focus()
            Exit Sub
        End If
        Dim mrow As DataRow
        Dim bEncontrado As Boolean = False
        Dim iDx As Integer = 0
        Dim iCan As Integer = 0
        Dim iAlm As Integer = 0
        For Each mrow In frmpadre.jdt.Rows
            If mrow("cod_producto") = dtaGrid.SelectedRows(0).Cells("cod_producto").Value Then
                bEncontrado = True
                iCan = CInt(mrow("cantidad_solicitada"))
                iAlm = CInt(mrow("cantidad_recibida"))
                Exit For
            End If
            iDx += 1
        Next
        If bEncontrado Then
            Dim mr As MsgBoxResult
            mr = MsgBox("Producto ya ingresado, con cantidad : " & iCan & vbCrLf & " Desea adicionar esta nueva cantidad " & txtCantidad.Text & " ?", MsgBoxStyle.YesNo, "TDS - SBL")
            If mr = MsgBoxResult.No Then
                MsgBox("Producto ya fue ingresado en el documento.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "TDS - SBL")
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
                    frmpadre.jrow("cantidad_solicitada") = txtCantidad.Text + iCan
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
                frmpadre.jrow("desc_producto") = lblDescripcion.Text
                frmpadre.jrow("cantidad_solicitada") = txtCantidad.Text
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
        MsgBox("codigo " & txtBuscar.Text & " agregado al documento.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "TDS - SBL")
        txtBuscar.Focus()
    End Sub
    Private Sub txtBuscar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        txtBuscar.SelectionStart = 0
        txtBuscar.SelectionLength = Len(txtBuscar.Text)
    End Sub
    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Trim(txtBuscar.Text) <> "" And e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            sql = "Select * "
            sql += "From productos "
            sql += "Where cod_producto = '" & txtBuscar.Text & "'"
            Dim dr As SqlDataReader = execQuery(sql, csql)
            If dr.Read Then
                existe = True
                lblDescripcion.Text = dr("desc_producto")
                txtCantidad.Enabled = True
                txtCantidad.Focus()
            Else
                MsgBox("El código ingresado no existe.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "TDS - SBL")
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
        Dim ls_Producto As String = ""
        Dim lr_Mr As MsgBoxResult
        Dim ld_Dr As SqlDataReader
        If Val(txtCantidad.Text) > 0 And e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            sql = "Select dbo.get_BuscaProductoCompras('" & dtaGrid.SelectedRows(0).Cells("cod_producto").Value & "')"
            ld_Dr = execQuery(sql, csql)
            If ld_Dr.Read Then
                If Len(ld_Dr(0) & "") > 0 Then
                    ld_Dr.Close()
                    lr_Mr = MsgBox("Producto ingresado existe en otra compra activa," & vbCrLf & "Confirma la creacion de esta compra.  ?", MsgBoxStyle.YesNo, "TDS - SBL")
                    If lr_Mr = MsgBoxResult.Yes Then
                        btnAdd.Focus()
                    Else
                        txtCantidad.Text = 0
                    End If
                Else
                    ld_Dr.Close()
                    btnAdd.Focus()
                End If
            Else
                ld_Dr.Close()
                btnAdd.Focus()
            End If
        End If
    End Sub
    Private Sub txtBuscar_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        cargarDatos()
    End Sub
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
        sql = "Select * "
        sql += "From productos "
        If Trim(txtBuscar.Text) <> "" Then
            sql += "Where (cod_producto Like '%" & txtBuscar.Text & "%' or codigoint like '%" & txtBuscar.Text & "%' or desc_producto like '%" & txtBuscar.Text & "%') "
        End If
        sql += "Order By cod_producto"
        dta.TableName = "productos"
        dta = execDataSet(sql & sqla, csql).Tables("Sql")
        dtaGrid.AutoGenerateColumns = False
        dtaGrid.Columns.Clear()
        dtaGrid.Columns.Add("cod_producto", "CÓDIGO") '1
        dtaGrid.Columns.Add("codigoint", "CÓDIGO INT") '1
        dtaGrid.Columns.Add("desc_producto", "DESCRIPCIÓN") '2
        dtaGrid.Columns("cod_producto").DataPropertyName = "cod_producto"
        dtaGrid.Columns("codigoint").DataPropertyName = "codigoint"
        dtaGrid.Columns("desc_producto").DataPropertyName = "desc_producto"
        dtaGrid.Columns("codigoint").Width = 200
        dtaGrid.Columns("cod_producto").Width = 200
        dtaGrid.Columns("desc_producto").Width = 310
        dtaGrid.DataSource = dta
        If dtaGrid.RowCount > 0 Then
            dtaGrid.Rows(0).Selected = True
        End If
    End Sub
    Private Sub txtDescripcion_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        cargarDatos()
    End Sub
    Private Sub dtaGrid_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtaGrid.Click
        If dtaGrid.SelectedRows.Count > 0 Then
            lblDescripcion.Text = dtaGrid.SelectedRows(0).Cells(2).Value
            existe = True
            txtCantidad.Enabled = True
            txtCantidad.Focus()
        End If
    End Sub
    Private Sub dtaGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtaGrid.DoubleClick
        If dtaGrid.SelectedRows.Count > 0 Then
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
End Class