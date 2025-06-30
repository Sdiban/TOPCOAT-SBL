Public NotInheritable Class frmImpresora

    Public aImpresora(20) As String
    Public iImpresora As Short
    Public acImpresora As Short

    Sub getInformacionImpresora()
        For Each printerName As String In System.Drawing.Printing.PrinterSettings.InstalledPrinters()
            If printerName.IndexOf("PL") > 0 Then cmbPrinter.Items.Add(printerName)
        Next
        If cmbPrinter.Items.Count > 0 Then
            cmbPrinter.SelectedIndex = 0
        End If

    End Sub
    Private Sub frmImpresora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getInformacionImpresora()
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub erpResultados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles erpResultados.Click

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Tag = "cancel"
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.Tag = cmbPrinter.Text
        Me.Close()
    End Sub
End Class
