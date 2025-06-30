Imports System.Data.SqlClient

Public Class frmAddItemSalida
    Public frmPadre As frmLoadDocSalida
    Dim existe As Boolean = False
    Dim istock As Integer
    Dim dta As New DataTable

    Private Sub cargarDatos()
        Dim sqla As String = ""
        Dim bAnd As Boolean = False
        dta.Clear()


        If txtBuscar.Text.Trim.Length = 0 Then

            sql = "SELECT cod_producto"
            sql += ",desc_producto"
            sql += ",codigoint"
            sql += ",sum(cantidad_producto) as cantidad"
            sql += ",valor "
            sql += "FROM get_existencias() " '
            sql += " Group By cod_producto, desc_producto, codigoint, valor"
            sql += " ORDER BY cod_producto"
        Else
            sql = "SELECT cod_producto"
            sql += ",desc_producto"
            sql += ",codigoint"
            sql += ",sum(cantidad_producto) AS Cantidad"
            sql += ",valor "
            sql += "FROM get_existenciaTotalizada('" & txtBuscar.Text & "') GROUP BY cod_producto, desc_producto, codigoint, valor"
        End If

        dta.TableName = "productos"
        dta = execDataSet(sql & sqla, csql).Tables("Sql")

        dtaGrid.AutoGenerateColumns = False
        dtaGrid.Columns.Clear()

        dtaGrid.Columns.Add("cod_producto", "CÓDIGO")
        dtaGrid.Columns.Add("codigoint", "CÓDIGO INT")
        dtaGrid.Columns.Add("desc_producto", "DESCRIPCIÓN")
        dtaGrid.Columns.Add("cantidad", "STOCK")
        dtaGrid.Columns.Add("valor", "VALOR")
        dtaGrid.Columns("cod_producto").DataPropertyName = "cod_producto"
        dtaGrid.Columns("codigoint").DataPropertyName = "codigoint"
        dtaGrid.Columns("desc_producto").DataPropertyName = "desc_producto"
        dtaGrid.Columns("cantidad").DataPropertyName = "cantidad"
        dtaGrid.Columns("valor").DataPropertyName = "valor"
        dtaGrid.Columns("cod_producto").Width = 200
        dtaGrid.Columns("codigoint").Width = 100
        dtaGrid.Columns("desc_producto").Width = 310
        dtaGrid.Columns("cantidad").Width = 60
        dtaGrid.Columns("valor").Width = 60
        dtaGrid.DataSource = dta
    End Sub
    Function HayStock(ByVal cod As String) As Integer
        Dim dr As SqlDataReader
        Try
            sql = "SELECT sum(cantidad) as Stk "
            sql += "FROM get_existencias() "
            sql += "WHERE cod_producto = '" & cod & "' "
            sql += "Group By cod_producto"
            dr = execQuery(sql, csql)
            If dr.Read Then
                If Not String.IsNullOrEmpty(dr("Stk").ToString) Then
                    HayStock = dr("Stk")
                End If
            End If
            dr.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim dr As SqlDataReader
        Dim ubicacion As String = ""
        'validar seleccion en data cantidad
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
            erpDetalle.FooterText = "debe ingresar la cantidad a agregar del producto"
            tmrMensaje.Enabled = True
            txtCantidad.Focus()
            Exit Sub
        End If
        If istock < Val(txtCantidad.Text) Then
            erpDetalle.FooterText = "Stock insuficiente...(" & istock & ")"
            tmrMensaje.Enabled = True
            txtCantidad.SelectionStart = 0
            txtCantidad.SelectionLength = txtCantidad.Text.Length
            Exit Sub
        End If
        Dim iDx As Integer = 0
        Dim iCan As Integer = 0
        Dim iAlm As Integer = 0
        Dim mrow As DataRow
        Dim bEncontrado As Boolean = False
        For Each mrow In frmPadre.jdt.Rows
            If mrow("cod_producto") = dtaGrid.SelectedRows(0).Cells("cod_producto").Value Then
                bEncontrado = True
                iCan = CInt(mrow("cantidad"))
                If String.IsNullOrEmpty(mrow("cantidad_despachada")) Then
                    iAlm = 0
                Else
                    iAlm = CInt(mrow("cantidad_despachada"))
                End If
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
                sql = "SELECT STUFF((select ('-'  + existencias.cod_ubicacion) "
                sql += " FROM existencias "
                sql += " WHERE existencias.cod_producto = '" & dtaGrid.SelectedRows(0).Cells("cod_producto").Value & "' "
                sql += " FOR XML PATH('')"
                sql += " ),1, 1, '') AS ubicacion"
                dr = execQuery(sql, csql)
                If dr.Read Then
                    ubicacion = dr("ubicacion")
                Else
                    ubicacion = ""
                End If
                dr.Close()
                frmPadre.dtaGrid.Rows.RemoveAt(iDx)
                Try
                    frmPadre.jrow = frmPadre.jdt.NewRow()
                    frmPadre.jrow("cod_producto") = dtaGrid.SelectedRows(0).Cells("cod_producto").Value
                    frmPadre.jrow("codigoint") = dtaGrid.SelectedRows(0).Cells("codigoint").Value
                    frmPadre.jrow("desc_producto") = lblDescripcion.Text
                    frmPadre.jrow("cantidad") = txtCantidad.Text + iCan
                    frmPadre.jrow("cantidad_despachada") = iAlm.ToString
                    frmPadre.jrow("ubicacion") = ubicacion
                    frmPadre.jdt.Rows.Add(frmPadre.jrow)
                    frmPadre.dtaGrid.DataSource = frmPadre.jdt
                Catch ex As Exception
                End Try
            End If
        Else
            Try
                sql = "SELECT STUFF((select ('-'  + existencias.cod_ubicacion) "
                sql += " FROM existencias "
                sql += " WHERE existencias.cod_producto = '" & dtaGrid.SelectedRows(0).Cells("cod_producto").Value & "' "
                sql += " FOR XML PATH('')"
                sql += " ),1, 1, '') AS ubicacion"
                dr = execQuery(sql, csql)
                If dr.Read Then
                    ubicacion = dr("ubicacion")
                Else
                    ubicacion = ""
                End If
                dr.Close()
                frmPadre.jrow = frmPadre.jdt.NewRow()
                frmPadre.jrow("cod_producto") = dtaGrid.SelectedRows(0).Cells("cod_producto").Value
                frmPadre.jrow("codigoint") = dtaGrid.SelectedRows(0).Cells("codigoint").Value
                frmPadre.jrow("desc_producto") = lblDescripcion.Text
                frmPadre.jrow("cantidad") = txtCantidad.Text
                frmPadre.jrow("ubicacion") = ubicacion
                frmPadre.jdt.Rows.Add(frmPadre.jrow)
                frmPadre.dtaGrid.DataSource = frmPadre.jdt
            Catch ex As Exception
            End Try
        End If
        existe = False
        txtCantidad.Text = "0"
        txtBuscar.Text = ""
        lblDescripcion.Text = ""
        erpDetalle.FooterText = "codigo " & txtBuscar.Text & " agregado al documento"
        lblDescripcion.Text = ""
        tmrMensaje.Enabled = True
        txtBuscar.Focus()
    End Sub
    Private Sub tmrMensaje_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMensaje.Tick
        erpDetalle.FooterText = ""
        tmrMensaje.Enabled = False
    End Sub
    'Private Sub txtDescripcion_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.GotFocus
    '    txtBuscar.SelectionStart = 0
    '    txtBuscar.SelectionLength = Len(txtBuscar.Text)
    'End Sub
    'Private Sub txtBuscar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
    '    txtBuscar.SelectionStart = 0
    '    txtBuscar.SelectionLength = Len(txtBuscar.Text)
    'End Sub
    'Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If Trim(txtBuscar.Text) <> "" And e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
    '        lblDescripcion.Text = ""
    '        sql = "SELECT * "
    '        sql += "FROM productos "
    '        sql += "WHERE cod_producto = '" & txtBuscar.Text & "'"
    '        Dim dr As SqlDataReader = execQuery(sql, csql)
    '        If dr.Read Then
    '            existe = True
    '            lblDescripcion.Text = dr("desc_producto")
    '            dr.Close()
    '            istock = HayStock(txtBuscar.Text)
    '            If istock = 0 Then
    '                erpDetalle.FooterText = "No hay stock"
    '                tmrMensaje.Enabled = True
    '                txtBuscar.Text = ""
    '                txtBuscar.Text = ""
    '                txtBuscar.Focus()
    '                Exit Sub
    '            End If
    '            If dtaGrid.RowCount > 0 Then
    '                dtaGrid.Rows(0).Selected = True
    '            End If
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
    Private Sub dtaGrid_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtaGrid.Click
        dtaGrid_DoubleClick(sender, e)
    End Sub
    Private Sub dtaGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtaGrid.DoubleClick
        If dtaGrid.SelectedRows.Count > 0 Then
            'cargar datos a tab 0
            lblDescripcion.Text = dtaGrid.SelectedRows(0).Cells(2).Value
            existe = True
            istock = HayStock(dtaGrid.SelectedRows(0).Cells(0).Value)
            If istock = 0 Then
                erpDetalle.FooterText = "No hay stock"
                tmrMensaje.Enabled = True
                txtBuscar.Text = ""
                txtBuscar.Focus()
                Exit Sub
            End If
            txtCantidad.Enabled = True
            txtCantidad.Focus()
        End If
    End Sub
    'Private Sub txtDescripcion_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
    '    cargarDatos()
    'End Sub
    Private Sub frmAddItemSalida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'cargarDatos()
        txtBuscar.Focus()
        cargarDatos()
    End Sub
    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        txtBuscar.Text = ""
        lblDescripcion.Text = ""
        txtBuscar.Focus()
    End Sub
    Private Sub txtDescripcion_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.Leave
        If dtaGrid.RowCount > 0 Then
            dtaGrid.Rows(0).Selected = True
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        cargarDatos()
    End Sub

    Private Sub dtaGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtaGrid.CellContentClick

    End Sub
End Class