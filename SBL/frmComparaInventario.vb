Imports System.Data.SqlClient
Public Class frmComparaInventario
    Public id_inventario As Integer
    Private Sub cargarDatos(ByVal id_inventario As Integer)
        Dim ds As New DataSet
        Dim dta As New DataTable
        Dim sqla As String = ""
        sql = "SELECT *, (cantidad_contada_1 - cantidad_original) as diferencia "
        sql += "FROM get_inventarios_detalles() "
        sql += "WHERE id_inventario = " & id_inventario
        sql += IIf(cmBodega.SelectedIndex < 1, "", " And substring(id_ubicacion,1,3)='" & cmBodega.SelectedValue.ToString.Substring(0, 3) & "'")
        dta.TableName = "registros"
        dta = execDataSet(sql & sqla, csql).Tables("Sql")
        erpResultados.FooterText = dta.Rows.Count.ToString & " resultado(s)"
        dtaGrid.AutoGenerateColumns = False
        dtaGrid.Columns.Clear()
        dtaGrid.Columns.Add("desc_bodega", "Bodega")
        dtaGrid.Columns.Add("cod_producto", "Cod. Producto")
        dtaGrid.Columns.Add("desc_producto", "Descripción")
        dtaGrid.Columns.Add("id_ubicacion", "Ubicacion")
        dtaGrid.Columns.Add("fecha_conteo", "Fecha Conteo")
        dtaGrid.Columns.Add("cantidad_original", "Existencia")
        dtaGrid.Columns.Add("cantidad_contada_1", "Cantidad Inventario")
        dtaGrid.Columns.Add("diferencia", "Diferencia")
        dtaGrid.Columns(0).DataPropertyName = "desc_bodega"
        dtaGrid.Columns(1).DataPropertyName = "cod_producto"
        dtaGrid.Columns(2).DataPropertyName = "desc_producto"
        dtaGrid.Columns(3).DataPropertyName = "id_ubicacion"
        dtaGrid.Columns(4).DataPropertyName = "fecha_conteo"
        dtaGrid.Columns(5).DataPropertyName = "cantidad_original"
        dtaGrid.Columns(6).DataPropertyName = "cantidad_contada_1"
        dtaGrid.Columns(7).DataPropertyName = "diferencia"
        dtaGrid.Columns(0).Width = 130
        dtaGrid.Columns(1).Width = 100
        dtaGrid.Columns(2).Width = 250
        dtaGrid.Columns(3).Width = 100
        dtaGrid.Columns(4).Width = 100
        dtaGrid.Columns(5).Width = 70
        dtaGrid.Columns(6).Width = 70
        dtaGrid.Columns(7).Width = 70
        dtaGrid.DataSource = dta
    End Sub
    Private Sub CargaInventarios()
        sql = "SELECT id_inventario"
        sql += ",fecha_creacion "
        sql += "FROM Inventarios"
        Dim dR As SqlDataReader = execQuery(sql, csql)
        Dim i As Integer = 0
        While dR.Read
            cmbInventarios.Items.Add(dR("id_inventario") & " - " & dR("fecha_creacion"))
            cmbInventarios.Items(i).Key = dR(0)
            i += 1
        End While
        dR.Close()
        cmBodega.SelectedIndex = 0
    End Sub
    Private Sub cargarBodegas()
        sql = "SELECT Cod_Bodega"
        sql += ",Desc_Bodega "
        sql += "FROM Bodegas "
        sql += "WHERE Estado_Bodega = 'ACT' "
        sql += "ORDER BY Cod_Bodega"
        Dim dR As SqlDataReader = execQuery(sql, csql)
        cmBodega.Items.Add("Todas")
        While dR.Read
            cmBodega.Items.Add(dR("Cod_Bodega") & " - " & dR("Desc_Bodega"))
        End While
        dR.Close()
        cmBodega.SelectedIndex = 0
    End Sub
    Private Sub frmComparaInventario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ReleaseVentana(Me)
    End Sub
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
    Private Sub frmComparaInventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarBodegas()
        cmbInventarios.Visible = False
        If Me.Tag = "menu" Then
            CargaInventarios()
            cmbInventarios.Visible = True
            btnCargar.Visible = False
        Else
            Call cargarDatos(id_inventario)
        End If
    End Sub
    Private Sub cmBodega_SELECTedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmBodega.SelectedIndexChanged
        cargarDatos(id_inventario)
    End Sub
    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        cargarDatos(id_inventario)
    End Sub
    Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargar.Click
        Dim j As Integer = 1
        Dim i As Integer = 1
        Dim resp As MsgBoxResult
        Dim sql As String
        Dim sPass As String
        Dim dRA As SqlDataReader
        Dim frm As New frmPassword
        Dim dg As DataGridViewRow
        If dtaGrid.RowCount < 1 Then
            Exit Sub
        End If
        resp = MsgBox("Esta seguro de actualizar inventario ?" + vbCrLf + "este proceso no se puede revertir", MsgBoxStyle.YesNo, "SBL")
        If resp = MsgBoxResult.Yes Then
            sPass = ""
            sql = "SELECT clave_usuario "
            sql += "FROM usuarios_pc "
            sql += "WHERE id_usuario = 'CARGAINVENTARIO'"
            dRA = execQuery(sql, csql)
            If dRA.Read Then
                sPass = dRA("clave_usuario")
            Else
                MsgBox("No esta definido Control de Seguridad Carga Inventario")
                dRA.Close()
                Exit Sub
            End If
            dRA.Close()
            frm.ShowDialog()
            If frm.DialogResult = 2 Then
                Exit Sub
            ElseIf frm.txtPassword.Text <> sPass Then
                MsgBox("Clave ingresada no corresponde, favor validar.", MsgBoxStyle.Exclamation, "TDS - SBL")
                Exit Sub
            End If
            For i = 0 To dtaGrid.RowCount - 1
                dg = dtaGrid.Rows(i)
                sql = "SELECT 1 "
                sql += "FROM existencias "
                sql += "WHERE cod_ubicacion = '" & dg.Cells("id_ubicacion").Value & "' "
                sql += "AND cod_producto = '" & dg.Cells("cod_producto").Value & "'"
                dRA = execQuery(sql, csql)
                If dRA.Read Then
                    dRA.Close()
                    sql = "UPDATE existencias "
                    sql += "SET cantidad_producto = " & dg.Cells("cantidad_contada_1").Value & " "
                    sql += "WHERE cod_ubicacion = '" & dg.Cells("id_ubicacion").Value & "' "
                    sql += "AND cod_producto = '" & dg.Cells("cod_producto").Value & "'"
                Else
                    sql = "INSERT INTO existencias (cod_ubicacion"
                    sql += ",cod_producto"
                    sql += ",cantidad_producto) "
                    sql += "VALUES ('" & dg.Cells("id_ubicacion").Value & "'"
                    sql += ",'" & dg.Cells("cod_producto").Value & "'"
                    sql += "," & dg.Cells("cantidad_contada_1").Value & ")"
                    dRA.Close()
                End If
                Call execUpdate(sql, csql)
            Next
            MsgBox("Proceso Carga Finalizado!")
        End If
    End Sub
    Private Sub cmbInventarios_SELECTedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbInventarios.SelectedIndexChanged
        Dim dRA As SqlDataReader
        id_inventario = cmbInventarios.Items(cmbInventarios.SelectedIndex).Key
        sql = "SELECT observaciones "
        sql += "FROM inventarios "
        sql += "WHERE id_inventario = " & id_inventario
        dRA = execQuery(sql, csql)
        txtObs.Text = ""
        If dRA.Read Then
            txtObs.Text = dRA("observaciones")
        End If
        dRA.Close()
        cargarDatos(id_inventario)
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Call ExportarAExcel(dtaGrid)
    End Sub
End Class