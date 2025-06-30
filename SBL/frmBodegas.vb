Imports System.Data.SqlClient
Public Class frmBodegas
    Private Oper As String = ""
    Private codCentro As String = ""
    Private codTipo As String = ""
    Private descTipo As String = ""
    Private Sub Format_Grid()
        Dim dt As New DataTable
        sql = "SELECT * "
        sql += "FROM Bodegas "
        dt = execDataSet(sql, csql).Tables("Sql")
        dtaGrid.AutoGenerateColumns = False
        dtaGrid.Columns.Clear()
        dtaGrid.Columns.Add("Cod_Bodega", "CODIGO") '0
        dtaGrid.Columns.Add("Desc_Bodega", "DESCRIPCION") '1
        dtaGrid.Columns.Add("Estado_Bodega", "ESTADO") '1
        dtaGrid.Columns(0).DataPropertyName = "Cod_Bodega"
        dtaGrid.Columns(1).DataPropertyName = "Desc_Bodega"
        dtaGrid.Columns(2).DataPropertyName = "Estado_Bodega"
        dtaGrid.Columns(0).Width = 80
        dtaGrid.Columns(1).Width = 220
        dtaGrid.Columns(2).Width = 60
        dtaGrid.DataSource = dt
    End Sub
    Private Sub Cargar_Datos()
        Dim dS As New DataSet
        Dim dT As New DataTable
        Dim oCmd As SqlCommand = New SqlCommand
        oCmd.Connection = csql
        oCmd.CommandText = "SELECT * FROM Bodegas ORDER BY Cod_Bodega"
        dT.TableName = "Bodegas"
        dT.Load(oCmd.ExecuteReader)
        dS.Tables.Add(dT)
        dtaGrid.DataSource = dS.Tables("Bodegas")
        dtaGrid.Refresh()
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Oper = "A"
        btnAdd.Enabled = False
        btnSave.Enabled = True
        btnDel.Enabled = False
        txtCodigo.Enabled = True
        txtDescripcion.Enabled = True
        cmbEstado.Enabled = True
        txtCodigo.Focus()
    End Sub
    Private Sub btnUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUndo.Click
        btnAdd.Enabled = True
        btnDel.Enabled = True
        btnSave.Enabled = False
        txtCodigo.Enabled = False
        txtDescripcion.Enabled = False
        cmbEstado.Enabled = False
        txtCodigo.Text = ""
        txtDescripcion.Text = ""
        cmbEstado.SelectedIndex = -1
        Call Cargar_Datos()
    End Sub
    Private Sub frmBodegas_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ReleaseVentana(Me)
    End Sub
    Private Sub frmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargaEstados(cmbEstado, "BOD")
        Call Format_Grid()
        Call Cargar_Datos()
    End Sub
    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If dtaGrid.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        Dim resp As MsgBoxResult
        Dim szLista As String = ""
        For Each dg In dtaGrid.SelectedRows
            szLista += dg.Cells(0).Value & vbCrLf
        Next
        If szLista.Length = 0 Then
            Exit Sub
        End If
        resp = MsgBox("Esta seguro de eliminar bodega ?" & vbCrLf & "Este proceso es irreversible" & vbCrLf & vbCrLf & szLista, MsgBoxStyle.YesNo)
        If resp = MsgBoxResult.Yes Then
            For Each dg In dtaGrid.SelectedRows
                sql = "SELECT * "
                sql += "FROM movimientos "
                sql += "WHERE substring(cod_ubicacion,1,3) = '" & dg.Cells(0).Value & "'"
                Dim dR As SqlDataReader = execQuery(sql, csql)
                If dR.Read Then
                    erpEdicion.FooterText = "Bodega no puede ser eliminada tiene movimientos asociados."
                    tmrMensaje.Enabled = True
                    Application.DoEvents()
                    dR.Close()
                    Exit Sub
                End If
                dR.Close()
                execUpdate("DELETE FROM bodegas WHERE cod_bodega='" & dg.Cells(0).Value & "'", csql)
            Next
            Call btnUndo_Click(sender, e)
            Call Cargar_Datos()
        End If
    End Sub
    Private Sub dtaGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtaGrid.DoubleClick
        If dtaGrid.SelectedRows.Count > 0 Then
            sql = "SELECT * "
            sql += "FROM Bodegas "
            sql += "WHERE Cod_Bodega = '" & dtaGrid.SelectedRows(0).Cells(0).Value & "'"
            Dim dr As SqlDataReader = execQuery(sql, csql)
            If dr.Read Then
                txtCodigo.Text = dr("Cod_Bodega")
                txtDescripcion.Text = dr("Desc_Bodega")
                Select Case dr("Estado_Bodega")
                    Case "INA"
                        cmbEstado.Text = "Inactivo"
                    Case Else
                        cmbEstado.Text = "Activo"
                End Select
                txtDescripcion.Enabled = True
                txtCodigo.Focus()
                Oper = "M"
                btnAdd.Enabled = False
                btnDel.Enabled = False
                btnSave.Enabled = True
                txtDescripcion.Enabled = True
                cmbEstado.Enabled = True
                txtDescripcion.Focus()
            Else
                erpEdicion.FooterText = "Error al cargar los datos de bodega"
                tmrMensaje.Enabled = True
            End If
            dr.Close()
        End If
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Select Case Oper
            Case "A"
                If Trim(txtCodigo.Text) = "" Then
                    MsgBox("Debe ingresar el código de la bodega", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Bodegas")
                    txtCodigo.Focus()
                    Exit Sub
                End If
                If Trim(txtDescripcion.Text) = "" Then
                    MsgBox("Debe ingresar la descripción de la bodega", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Bodegas")
                    txtDescripcion.Focus()
                    Exit Sub
                End If
                If Trim(cmbEstado.Text) = "" Then
                    MsgBox("Debe seleccionar el estado del centro logístico", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Bodegas")
                    cmbEstado.Focus()
                    Exit Sub
                End If
                Try
                    sql = "SELECT * "
                    sql += "FROM Bodegas "
                    sql += "WHERE Cod_Bodega = '" & txtCodigo.Text & "'"
                    Dim dR As SqlDataReader = execQuery(sql, csql)
                    If dR.Read Then
                        MsgBox("La bodega ya existe en la base de datos", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Bodegas")
                        txtCodigo.Focus()
                        dR.Close()
                        Exit Sub
                    End If
                    dR.Close()
                    sql = "INSERT INTO Bodegas VALUES("
                    sql += "'" & txtCodigo.Text & "'"
                    sql += ",'" & txtDescripcion.Text & "'"
                    Select Case cmbEstado.Text
                        Case "ACTIVA"
                            sql += ",'ACT')"
                        Case "INACTIVA"
                            sql += ",'INA')"
                        Case "BLOQUEADA"
                            sql += ",'BLO')"
                    End Select
                    Call execUpdate(sql, csql)
                    Call btnUndo_Click(sender, e)
                    operador = ""
                Catch ex As Exception
                    MsgBox("Error de Aplicación: " & ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Bodegas")
                End Try
            Case "M"
                If Trim(txtDescripcion.Text) = "" Then
                    MsgBox("Debe ingresar el Nombre de Usuario", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Bodegas")
                    txtDescripcion.Focus()
                    Exit Sub
                End If
                If Trim(cmbEstado.Text) = "" Then
                    MsgBox("Debe seleccionar el estado del centro logístico", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Bodegas")
                    cmbEstado.Focus()
                    Exit Sub
                End If
                Try
                    sql = "UPDATE Bodegas Set Desc_Bodega = '" & txtDescripcion.Text & "'"
                    Select Case cmbEstado.Text
                        Case "ACTIVO"
                            sql += ",Estado_Bodega = 'ACT'"
                        Case "INACTIVO"
                            sql += ",Estado_Bodega = 'INA'"
                    End Select
                    sql += " WHERE Cod_Bodega = '" & txtCodigo.Text & "'"
                    Call execUpdate(sql, csql)
                    Call btnUndo_Click(sender, e)
                    operador = ""
                Catch ex As Exception
                    MsgBox("Error de Aplicación: " & ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Bodegas")
                End Try
        End Select
    End Sub
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class