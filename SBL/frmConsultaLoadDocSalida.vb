Imports System.Data.SqlClient
Imports QRCoder
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Public Class frmConsultaLoadDocSalida
    Dim szLogo As String
    Private Sub cargarDatosEntrada()
        Dim ds As New DataSet
        Dim dta As New DataTable
        Dim sqla As String = ""
        sql = "select id_documento_salida,documentos_tipo.descripcion,documentos_salida.tipo_documento,desc_estado,observaciones,clientes.id_cliente,clientes.nombre,fecha_creacion  "
        sql += "from documentos_salida "
        sql += "inner join estados "
        sql += "on estados.id_estado=documentos_salida.estado_documento and estados.id_tabla='DC' "
        sql += "inner join clientes "
        sql += "on clientes.id_cliente=documentos_salida.id_cliente "
        sql += "inner join documentos_tipo "
        sql += "on documentos_tipo.tipo = documentos_salida.tipo_documento "

        dta.TableName = "registros"
        dta = execDataSet(sql & sqla, csql).Tables("Sql")
        erpResultados.FooterText = dta.Rows.Count.ToString & " resultado(s)"
        dtaGrid.AutoGenerateColumns = False
        dtaGrid.Columns.Clear()
        dtaGrid.Columns.Add("descripcion", "Tipo Doc.")
        dtaGrid.Columns.Add("id_documento_salida", "Número Doc.")
        dtaGrid.Columns.Add("id_cliente", "Rut Cliente")
        dtaGrid.Columns.Add("nombre", "Cliente")
        dtaGrid.Columns.Add("fecha_creacion", "Fecha")
        dtaGrid.Columns.Add("observaciones", "Observaciones")
        dtaGrid.Columns.Add("desc_estado", "Estado")
        dtaGrid.Columns.Add("tipo_documento", "Estado")
        dtaGrid.Columns(0).DataPropertyName = "descripcion"
        dtaGrid.Columns(1).DataPropertyName = "id_documento_salida"
        dtaGrid.Columns(2).DataPropertyName = "id_cliente"
        dtaGrid.Columns(3).DataPropertyName = "nombre_cliente"
        dtaGrid.Columns(4).DataPropertyName = "fecha_creacion"
        dtaGrid.Columns(5).DataPropertyName = "Observaciones"
        dtaGrid.Columns(6).DataPropertyName = "desc_estado"
        dtaGrid.Columns(7).DataPropertyName = "tipo_documento"

        dtaGrid.Columns(0).Width = 60
        dtaGrid.Columns(1).Width = 70
        dtaGrid.Columns(2).Width = 80
        dtaGrid.Columns(3).Width = 150
        dtaGrid.Columns(4).Width = 90
        dtaGrid.Columns(5).Width = 170
        dtaGrid.Columns(6).Width = 80


        dtaGrid.Columns(7).Visible = False




        dtaGrid.DataSource = dta
    End Sub
    Private Sub frmConsultaLoadDocSalida_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ReleaseVentana(Me)
    End Sub
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Tag = "CANCEL"
        Me.Close()
    End Sub
    Private Sub frmConsultaLoadDocSalida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call cargarDatosEntrada()
    End Sub
    Private Sub dtaGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtaGrid.DoubleClick
        If dtaGrid.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        Me.Tag = dtaGrid.SelectedRows(0).Cells(0).Value & ";" & dtaGrid.SelectedRows(0).Cells(1).Value
        Me.Close()
    End Sub
    Private Sub btnImprimir_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImprimir.Click
        ' Usamos una clase del tipo PrintDocument
        Dim printDoc As New PrintDocument
        ' asignamos el método de evento para cada página a imprimir
        AddHandler printDoc.PrintPage, AddressOf print_PrintPage
        ' indicamos que queremos imprimir
        printDoc.Print()
    End Sub
    Private Sub print_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        ' imprimimos la cadena en el margen izquierdo
        Dim xPos As Single = e.MarginBounds.Left
        ' La fuente a usar
        Dim prFont As New Font("Arial", 10, FontStyle.Bold)
        Dim prFont1 As New Font("QR-Code", 60, FontStyle.Regular)
        ' la posición superior
        Dim yPos As Single = prFont.GetHeight(e.Graphics)
        Dim cod_producto As String
        xPos = 20
        ' imprimimos la cadena
        For Each dg In dtaGrid.SelectedRows
            cod_producto = GenerarQR(dg.Cells("id_documento_salida").value, True)
            e.Graphics.DrawImage(pictureBoxQRCode.BackgroundImage, xPos, yPos, 100, 100)
            yPos = yPos + 100
            e.Graphics.DrawString(dg.Cells("id_documento_salida").value, prFont, Brushes.Black, xPos, yPos)
            yPos = yPos + 15
            e.Graphics.DrawString("CLIENTE", prFont, Brushes.Black, xPos, yPos)
            yPos = yPos + 15
            e.Graphics.DrawString(dg.Cells("nombre_cliente").Value, prFont, Brushes.Black, xPos, yPos)
            yPos = yPos + 15
            e.Graphics.DrawString("DIRECCION", prFont, Brushes.Black, xPos, yPos)
            yPos = yPos + 15
            e.Graphics.DrawString(dg.Cells("direccion_1").Value & " " & dg.Cells("ciudad_1").Value, prFont, Brushes.Black, xPos, yPos)
            yPos = yPos + 90
        Next
        ' indicamos que ya no hay nada más que imprimir
        ' (el valor predeterminado de esta propiedad es False)
        e.HasMorePages = False

    End Sub
    Function GenerarQR(codigo As String, Optional bEscribe As Boolean = False) As String
        Dim level As String = "M"
        Dim cod_producto As String = codigo.Replace(" ", "")
        Dim eccLevel As QRCodeGenerator.ECCLevel = CType(0, QRCodeGenerator.ECCLevel)
        Dim qrGenerator As QRCodeGenerator = New QRCodeGenerator
        Dim qrCodeData As QRCodeData = qrGenerator.CreateQrCode(codigo, eccLevel)
        Dim qrCode As QRCode = New QRCode(qrCodeData)
        pictureBoxQRCode.BackgroundImage = qrCode.GetGraphic(20, panelPreviewPrimaryColor.BackColor,
                                                             panelPreviewBackgroundColor.BackColor, GetIconBitmap(),
                                                            IIf(ExisteArchivo(szLogo), 15, 0))
        Me.pictureBoxQRCode.Size = New System.Drawing.Size(pictureBoxQRCode.Width, pictureBoxQRCode.Height)
        'Set the SizeMode to center the image.
        Me.pictureBoxQRCode.SizeMode = PictureBoxSizeMode.CenterImage
        pictureBoxQRCode.SizeMode = PictureBoxSizeMode.StretchImage
        Dim mdoc As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        If bEscribe Then
            mdoc += "\SBL_WMS\" & cod_producto & ".png"
            Dim fs As FileStream = File.Create(mdoc)
            pictureBoxQRCode.BackgroundImage.Save(fs, ImageFormat.Png)
            Application.DoEvents()
            'pictureBoxQRCode.BackgroundImage.Dispose()
            'pictureBoxQRCode.BackgroundImage = Nothing
        End If
        Return mdoc
    End Function
    Private Function GetIconBitmap() As Bitmap
        szLogo = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        szLogo += "\SBL_WMS\logo.png"
        If (Not ExisteArchivo(szLogo)) Then
            Return Nothing
        End If
        Try
            Return New Bitmap(szLogo)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class