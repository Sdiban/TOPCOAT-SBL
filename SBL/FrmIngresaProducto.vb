Imports System.Data.SqlClient
Public Class FrmIngresaProducto
    Public frmpadre1 As frmAddItemEntrada
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Trim(txtCodigo.Text) = "" Then
            erpEdicion.FooterText = "Debe ingresar código de barra del producto"
            Application.DoEvents()
            tmrMensaje.Enabled = True
            txtCodigo.Focus()
            Exit Sub
        End If
        If Trim(txtCodigoInt.Text) = "" Then
            erpEdicion.FooterText = "Debe ingresar código interno del producto"
            Application.DoEvents()
            tmrMensaje.Enabled = True
            txtCodigoInt.Focus()
            Exit Sub
        End If
        If Trim(txtDescripcion.Text) = "" Then
            erpEdicion.FooterText = "Debe ingresar descripción para producto"
            tmrMensaje.Enabled = True
            Application.DoEvents()
            txtDescripcion.Focus()
            Exit Sub
        End If

        sql = "SELECT * "
        sql += "FROM productos "
        sql += "WHERE cod_producto = '" & txtCodigo.Text & "'"
        Dim dr As SqlDataReader = execQuery(sql, csql)
        If dr.Read Then
            dr.Close()
            erpEdicion.Text = "El producto ingresado ya existe"
            Application.DoEvents()
            tmrMensaje.Enabled = True
            txtCodigo.Text = ""
            txtCodigoInt.Text = ""
            txtDescripcion.Text = ""
            Exit Sub
        End If
        dr.Close()
        sql = "INSERT INTO productos(cod_producto"
        sql += ",codigoint"
        sql += ",desc_producto"
        sql += ",minimo"
        sql += ",maximo"
        sql += ",valor"
        sql += ",id_familia"
        sql += ",id_unidadmedida"
        sql += ",usa_serie) "
        sql += "VALUES('" & txtCodigo.Text & "'"
        sql += ",'" & txtCodigoInt.Text & "'"
        sql += ",'" & txtDescripcion.Text & "'"
        sql += ",1"
        sql += ",999"
        sql += ",1"
        sql += ",1"
        sql += ",'01'"
        sql += ",'NO')"
        Call execUpdate(sql, csql)
        Me.Close()
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class