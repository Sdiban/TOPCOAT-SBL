Imports System.Data.SqlClient
Public Class frmCapturadores
    Private Oper As String = ""
    Private codCentro As String = ""
    Private codTipo As String = ""
    Private descTipo As String = ""
    Private Sub Format_Grid()
        Dim dt As New DataTable
        sql = "SELECT id_Capturador"
        sql += ",Desc_Capturador "
        sql += "FROM Capturadores "
        dt = execDataSet(sql, csql).Tables("Sql")
        dtaGrid.AutoGenerateColumns = False
        dtaGrid.Columns.Clear()
        dtaGrid.Columns.Add("id_Capturador", "CODIGO") '0
        dtaGrid.Columns.Add("Desc_Capturador", "DESCRIPCION") '1
        dtaGrid.Columns("id_Capturador").DataPropertyName = "id_Capturador"
        dtaGrid.Columns("Desc_Capturador").DataPropertyName = "Desc_Capturador"
        dtaGrid.Columns("id_Capturador").Width = 80
        dtaGrid.Columns("Desc_Capturador").Width = 300
        dtaGrid.DataSource = dt
    End Sub
    Private Sub Cargar_Datos()
        Dim dS As New DataSet
        Dim dT As New DataTable
        Dim oCmd As SqlCommand = New SqlCommand
        oCmd.Connection = csql
        oCmd.CommandText = "SELECT * FROM capturadores ORDER BY id_Capturador"
        dT.TableName = "Capturadores"
        dT.Load(oCmd.ExecuteReader)
        dS.Tables.Add(dT)
        dtaGrid.DataSource = dS.Tables("Capturadores")
        dtaGrid.Refresh()
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Oper = "A"
        btnAdd.Enabled = False
        btnSave.Enabled = True
        btnDel.Enabled = False
        txtCodigo.Enabled = True
        txtDescripcion.Enabled = True
        txtCodigo.Focus()
    End Sub
    Private Sub btnUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUndo.Click
        btnAdd.Enabled = True
        btnDel.Enabled = True
        btnSave.Enabled = False
        txtCodigo.Enabled = False
        txtDescripcion.Enabled = False
        txtCodigo.Text = ""
        txtDescripcion.Text = ""
        Call Cargar_Datos()
    End Sub
    Private Sub frmCapturadores_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ReleaseVentana(Me)
    End Sub
    Private Sub frmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        resp = MsgBox("Esta seguro de eliminar Capturador ?" & vbCrLf & "Este proceso es irreversible" & vbCrLf & vbCrLf & szLista, MsgBoxStyle.YesNo)
        If resp = MsgBoxResult.Yes Then
            For Each dg In dtaGrid.SelectedRows
                execUpdate("DELETE FROM Capturadores WHERE id_Capturador='" & dg.Cells(0).Value & "'", csql)
            Next
            Call btnUndo_Click(sender, e)
            Call Cargar_Datos()
        End If
    End Sub
    Private Sub dtaGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtaGrid.DoubleClick
        If dtaGrid.SelectedRows.Count > 0 Then
            sql = "SELECT * FROM Capturadores WHERE id_Capturador = '" & dtaGrid.SelectedRows(0).Cells(0).Value & "'"
            Dim dr As SqlDataReader = execQuery(sql, csql)
            If dr.Read Then
                txtCodigo.Text = dr("id_Capturador")
                txtDescripcion.Text = dr("Desc_Capturador")
                txtDescripcion.Enabled = True
                txtCodigo.Focus()
                Oper = "M"
                btnAdd.Enabled = False
                btnDel.Enabled = False
                btnSave.Enabled = True
                txtDescripcion.Enabled = True
                txtDescripcion.Focus()
            Else
                erpEdicion.FooterText = "Error al cargar los datos de Capturador"
                tmrMensaje.Enabled = True
            End If
            dr.Close()
        End If
    End Sub
    Private Sub txtUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = False
        If Char.IsControl(e.KeyChar) Then
        Else
            If Char.IsLetterOrDigit(e.KeyChar) Then
            Else
                If Char.IsPunctuation(e.KeyChar) Then
                    If e.KeyChar = "'" Then
                        e.Handled = True
                    End If
                Else
                    If Char.IsSymbol(e.KeyChar) Then
                    Else
                        e.Handled = True
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        e.Handled = False
        If Char.IsControl(e.KeyChar) Then
        Else
            If Char.IsLetterOrDigit(e.KeyChar) Then
            Else
                If Char.IsPunctuation(e.KeyChar) Then
                    If e.KeyChar = "'" Then
                        e.Handled = True
                    End If
                Else
                    If Char.IsSymbol(e.KeyChar) Then
                    Else
                        If Char.IsWhiteSpace(e.KeyChar) Then
                        Else
                            e.Handled = True
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Select Case Oper
            Case "A"
                If Trim(txtCodigo.Text) = "" Then
                    MsgBox("Debe ingresar el código de la Capturador", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Capturadores")
                    txtCodigo.Focus()
                    Exit Sub
                End If
                If Trim(txtDescripcion.Text) = "" Then
                    MsgBox("Debe ingresar la descripción de la Capturador", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Capturadores")
                    txtDescripcion.Focus()
                    Exit Sub
                End If
                Try
                    sql = "SELECT * "
                    sql += "FROM Capturadores "
                    sql += "WHERE id_Capturador = '" & Format(Val(txtCodigo.Text), "00") & "'"
                    Dim dR As SqlDataReader = execQuery(sql, csql)
                    If dR.Read Then
                        MsgBox("El Capturador ya existe en la base de datos", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Capturadores")
                        txtCodigo.Focus()
                        dR.Close()
                        Exit Sub
                    End If
                    dR.Close()
                    sql = "INSERT INTO Capturadores "
                    sql += "VALUES('" & Format(Val(txtCodigo.Text), "00") & "'"
                    sql += ",'" & txtDescripcion.Text & "')"
                    Call execUpdate(sql, csql)
                    Call btnUndo_Click(sender, e)
                Catch ex As Exception
                    MsgBox("Error de Aplicación: " & ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Capturadores")
                End Try
            Case "M"
                If Trim(txtDescripcion.Text) = "" Then
                    MsgBox("Debe ingresar el Nombre de Usuario", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Capturadores")
                    txtDescripcion.Focus()
                    Exit Sub
                End If
                Try
                    sql = "UPDATE Capturadores "
                    sql += "SET Desc_Capturador = '" & txtDescripcion.Text & " "
                    sql += "WHERE id_Capturador = '" & Format(Val(txtCodigo.Text), "00") & "'"
                    Call execUpdate(sql, csql)
                    Call btnUndo_Click(sender, e)
                Catch ex As Exception
                    MsgBox("Error de Aplicación: " & ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Capturadores")
                End Try
        End Select
    End Sub
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
    Private Sub erpEdicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles erpEdicion.Click
    End Sub
    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
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
        resp = MsgBox("Esta acción limpia los datos del Capturador " & "para retransmitir todo " & vbCrLf & vbCrLf & "Este proceso es irreversible" & vbCrLf & vbCrLf & "        Esta seguro de esto ?", MsgBoxStyle.YesNo)
        If resp = MsgBoxResult.Yes Then
            For Each dg In dtaGrid.SelectedRows
                execUpdate("UPDATE productos set transmitido = replace(transmitido,';" & dg.Cells(0).Value & ";','')", csql)
                execUpdate("UPDATE documentos_entrada set transmitido = replace(transmitido,';" & dg.Cells(0).Value & ";','')", csql)
                'execUpdate("UPDATE documentos_entrada_detalles set transmitido = replace(transmitido,';" & dg.Cells(0).Value & ";','')", csql)
                'execUpdate("UPDATE documentos_entrada_guias set transmitido = replace(transmitido,';" & dg.Cells(0).Value & ";','')", csql)
                execUpdate("UPDATE documentos_salida set transmitido = replace(transmitido,';" & dg.Cells(0).Value & ";','')", csql)
                'execUpdate("UPDATE documentos_salida_detalles set transmitido = replace(transmitido,';" & dg.Cells(0).Value & ";','')", csql)
                execUpdate("UPDATE ubicaciones set transmitido = replace(transmitido,';" & dg.Cells(0).Value & ";','')", csql)
                execUpdate("UPDATE existencias set transmitido = replace(transmitido,';" & dg.Cells(0).Value & ";','')", csql)
                'execUpdate("UPDATE bodegas set transmitido = replace(transmitido,';" & dg.Cells(0).Value & ";','')", csql)
                'execUpdate("UPDATE inventarios set transmitido = replace(transmitido,';" & dg.Cells(0).Value & ";','')", csql)
            Next
            Call btnUndo_Click(sender, e)
            Call Cargar_Datos()
            MsgBox("Equipo quedo listo para recuperar información")
        End If
    End Sub
    Private Sub txtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged
        txtDescripcion.Text = UCase(txtDescripcion.Text)
        txtDescripcion.SelectionStart = Me.txtDescripcion.Text.Length + 1
    End Sub
End Class