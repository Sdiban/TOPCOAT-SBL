Option Explicit On
Imports System.Data.SqlClient
Imports SBL.ntPrint
Public Class frmCreaInventario
    Public Const aEtq As Integer = 400
    Private Sub cargarDatos()
        Dim dt As New DataTable
        sql = "SELECT * "
        sql += "FROM get_inventarios() "
        sql += "ORDER BY id_inventario desc "
        dt = execDataSet(sql, csql).Tables("Sql")
        dtaGrid.AutoGenerateColumns = False
        dtaGrid.Columns.Clear()
        dtaGrid.Columns.Add("id_inventario", "Nº Inventario")
        dtaGrid.Columns.Add("fecha_creacion", "Fec. Creación")
        dtaGrid.Columns.Add("numero_conteo", "Conteo")
        dtaGrid.Columns.Add("observaciones", "Observaciones")
        dtaGrid.Columns.Add("desc_estado", "Estado")
        dtaGrid.Columns.Add("estado_inventario", "estado_inventario")
        dtaGrid.Columns("id_inventario").DataPropertyName = "id_inventario"
        dtaGrid.Columns("fecha_creacion").DataPropertyName = "fecha_creacion"
        dtaGrid.Columns("numero_conteo").DataPropertyName = "numero_conteo"
        dtaGrid.Columns("observaciones").DataPropertyName = "observaciones"
        dtaGrid.Columns("desc_estado").DataPropertyName = "desc_estado"
        dtaGrid.Columns("estado_inventario").DataPropertyName = "estado_inventario"
        dtaGrid.Columns("id_inventario").Width = 100
        dtaGrid.Columns("fecha_creacion").Width = 140
        dtaGrid.Columns("numero_conteo").Width = 100
        dtaGrid.Columns("observaciones").Width = 260
        dtaGrid.Columns("desc_estado").Width = 100
        dtaGrid.Columns("estado_inventario").Visible = False
        dtaGrid.DataSource = dt
    End Sub
    Private Sub frmCreaInventario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ReleaseVentana(Me)
    End Sub
    Private Sub frmUsersID_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call cargarDatos()
    End Sub
    Private Sub btnCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrear.Click
        Dim iResp As MsgBoxResult
        Dim iMax As Integer
        sql = "SELECT * "
        sql += "FROM inventarios "
        sql += "WHERE estado_inventario in('ACT','CRE')"
        Dim dr As SqlDataReader = execQuery(sql, csql)
        If dr.Read Then
            dr.Close()
            iResp = MsgBox("Hay inventarios creados o activos" & vbCrLf & vbCrLf & "Esta seguro de Crear un nuevo inventario ?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "SBL")
            If iResp = MsgBoxResult.No Then
                Exit Sub
            End If
        Else
            iResp = MsgBox("Esta seguro de Crear un nuevo inventario ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SBL")
            If iResp = MsgBoxResult.No Then
                Exit Sub
            End If
        End If
        dr.Close()
        sql = "SELECT (max(id_inventario) + 1) as maximo "
        sql += "FROM inventarios"
        iMax = 1
        dr = execQuery(sql, csql)
        If dr.Read Then
            If Not String.IsNullOrEmpty(dr("maximo").ToString) Then
                iMax = dr("maximo")
            End If
            dr.Close()
        End If
        dr.Close()
        Dim frm As frmObservaciones = New frmObservaciones
        frm.txtInv.Text = iMax.ToString
        frm.ShowDialog()
        cargarDatos()
    End Sub
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
    Private Sub dtaGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtaGrid.CellContentClick
        Me.Focus()
    End Sub
    Private Sub dtaGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtaGrid.DoubleClick
        If dtaGrid.SelectedRows.Count > 0 Then
            Dim frm As frmComparaInventario = New frmComparaInventario
            frm.Tag = ""
            frm.id_inventario = dtaGrid.SelectedRows(0).Cells(0).Value
            frm.Text = "INVENTARIO " & dtaGrid.SelectedRows(0).Cells(0).Value
            frm.txtObs.Text = dtaGrid.SelectedRows(0).Cells("observaciones").Value
            frm.ShowDialog()
        End If
    End Sub
    Private Sub erpResultados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles erpResultados.Click
        Me.Focus()
    End Sub
    Private Sub erpEdicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Focus()
    End Sub
    Private Sub txtBuscar_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Call cargarDatos()
    End Sub
    Private Sub btnCerrarInventario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarInventario.Click
        If dtaGrid.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        Dim iResp As MsgBoxResult
        iResp = MsgBox("Esta seguro de cerrar este inventario ? ", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "SBL")
        If iResp = MsgBoxResult.No Then
            Exit Sub
        End If
        For Each dg In dtaGrid.SelectedRows
            execUpdate("UPDATE inventarios set estado_inventario = 'CER' WHERE id_inventario=" & dg.Cells("id_inventario").Value, csql)
            execUpdate("UPDATE inventarios_detalles set estado_conteo = 'CER' WHERE id_inventario=" & dg.Cells("id_inventario").Value, csql)
        Next
        cargarDatos()
    End Sub
End Class