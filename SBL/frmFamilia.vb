Imports System.Data.SqlClient
Public Class frmFamilia
    Private Sub cargarDatos()
        Dim dt As New DataTable
        sql = "SELECT * "
        sql += "FROM familias "
        sql += "ORDER BY id_familia"
        dt = execDataSet(sql, csql).Tables("Sql")
        dtaGrid.AutoGenerateColumns = False
        dtaGrid.Columns.Clear()
        dtaGrid.Columns.Add("id_familia", "ID") '0
        dtaGrid.Columns.Add("descripcion", "FAMILIA") '1
        dtaGrid.Columns("id_familia").DataPropertyName = "id_familia"
        dtaGrid.Columns("descripcion").DataPropertyName = "descripcion"
        dtaGrid.Columns("id_familia").Width = 50
        dtaGrid.Columns("descripcion").Width = 300
        dtaGrid.DataSource = dt
    End Sub
    Private Sub frmFamilia_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ReleaseVentana(Me)
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Trim(txtFamilia.Text) = "" Then
            erpEdicion.FooterText = "Debe ingresar la descricpción de la familia"
            tmrMensaje.Enabled = True
            txtFamilia.Focus()
            Exit Sub
        End If
        Dim permisos As String = ""
        permisos = ""
        If operador = "A" Then
            sql = "SELECT * "
            sql += "FROM familias "
            sql += "WHERE descripcion = '" & txtFamilia.Text & "'"
            Dim dr As SqlDataReader = execQuery(sql, csql)
            If dr.Read Then
                dr.Close()
                erpEdicion.Text = "La familia ingresado ya existe"
                tmrMensaje.Enabled = True
                Exit Sub
            End If
            dr.Close()
            sql = "INSERT INTO familias(descripcion) VALUES("
            sql += "'" & txtFamilia.Text & "')"
            Call execUpdate(sql, csql)

            sql = "SELECT @@IDENTITY AS ID"
            dr = execQuery(sql, csql)
            If dr.Read Then
                MsgBox("Familia creada correctamente el codigo es : " & dr("ID"), MsgBoxStyle.Exclamation, "TDS - SBL")
            End If
            dr.Close()
        Else
            sql = "UPDATE familias "
            sql += "SET descripcion = '" & txtFamilia.Text & "' "
            sql += "WHERE id_familia = '" & txtID_Familia.Text & "'"
            Call execUpdate(sql, csql)
        End If
        Call btnUndo_Click(sender, e)
        operador = ""
    End Sub
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
    Private Sub tmrMensaje_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMensaje.Tick
        erpEdicion.FooterText = ""
        tmrMensaje.Enabled = False
    End Sub
    Private Sub btnUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUndo.Click
        txtFamilia.Text = ""
        txtFamilia.Enabled = False
        Call cargarDatos()
    End Sub
    Private Sub dtaGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtaGrid.DoubleClick
        If dtaGrid.SelectedRows.Count > 0 Then
            operador = "M"
            txtID_Familia.Text = dtaGrid.SelectedRows(0).Cells(0).Value
            txtFamilia.Text = dtaGrid.SelectedRows(0).Cells(1).Value
            txtFamilia.Enabled = True
        End If
    End Sub
    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Dim resp As MsgBoxResult
        Dim szLista As String = ""
        Dim familia As Integer = 0
        For Each dg In dtaGrid.SelectedRows
            szLista += dg.Cells("id_familia").Value & "- " & dg.Cells("descripcion").Value & vbCrLf
            familia = dg.Cells(0).Value
        Next
        If szLista.Length = 0 Then
            Exit Sub
        End If
        resp = MsgBox("Esta seguro de eliminar familia/s, este proceso es irreversible." & vbCrLf & szLista, MsgBoxStyle.YesNo)
        If resp = MsgBoxResult.Yes Then
            sql = "SELECT * "
            sql += "FROM productos "
            sql += "WHERE id_familia = '" & familia & "'"
            Dim dr As SqlDataReader = execQuery(sql, csql)
            If dr.Read Then
                dr.Close()
                MsgBox("¡ La familia seleccionada no puede ser eliminada !", vbExclamation)
                Exit Sub
            Else
                dr.Close()
                For Each dg In dtaGrid.SelectedRows
                    execUpdate("DELETE FROM familias WHERE id_familia = '" & dg.Cells(0).Value & "'", csql)
                Next
                cargarDatos()
            End If
        End If
        txtFamilia.Text = ""
        txtID_Familia.Text = ""
        txtFamilia.Enabled = False
        txtID_Familia.Enabled = False
        Call cargarDatos()
    End Sub
    Private Sub frmFamilia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call cargarDatos()
    End Sub
    Private Sub btnCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrear.Click
        operador = "A"
        'sql = "SELECT max(id_familia) as familia "
        'sql += "FROM familias"
        'Dim dr As SqlDataReader = execQuery(sql, csql)
        'If dr.Read Then
        '    txtID_Familia.Text = dr("familia") + 1
        'Else
        '    txtID_Familia.Text = 1
        'End If
        'dr.Close()
        txtFamilia.Enabled = True
        txtFamilia.Focus()
    End Sub
    Private Sub txtFamilia_TextChanged(sender As Object, e As EventArgs) Handles txtFamilia.TextChanged
        txtFamilia.Text = UCase(txtFamilia.Text)
        txtFamilia.SelectionStart = Me.txtFamilia.Text.Length + 1
    End Sub
End Class