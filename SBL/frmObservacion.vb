Imports System.Data.SqlClient

Public Class frmObservaciones

    Dim existe As Boolean = False
    Public frmpadre As frmLoadDocEntrada

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Dim sql As String

        sql = "INSERT INTO inventarios (id_inventario, fecha_creacion, usuario_creacion, numero_conteo, observaciones, estado_inventario) VALUES("
        sql += txtInv.Text & ",GETDATE(), '" & username & "',1,'" & txtObservacion.Text & "','CRE')"
        Call execUpdate(sql, csql)

        Me.Close()

    End Sub

End Class