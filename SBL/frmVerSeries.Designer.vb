<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerSeries
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.erpBusquedas = New Klik.Windows.Forms.v1.EntryLib.ELRichPanel()
        Me.txtSerie = New Klik.Windows.Forms.v1.EntryLib.ELEntryBox()
        Me.txtObservacion = New Klik.Windows.Forms.v1.EntryLib.ELEntryBox()
        Me.btnExcel = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.btnFind = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.btnBack = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.txtUbicacion = New Klik.Windows.Forms.v1.EntryLib.ELEntryBox()
        Me.txtDescripcion = New Klik.Windows.Forms.v1.EntryLib.ELEntryBox()
        Me.txtCodigo = New Klik.Windows.Forms.v1.EntryLib.ELEntryBox()
        Me.ElDivider2 = New Klik.Windows.Forms.v1.EntryLib.ELDivider()
        Me.dtaGrid = New Klik.Windows.Forms.v1.EntryLib.ELDataGridView()
        Me.KFormManager1 = New Klik.Windows.Forms.v1.Common.KFormManager(Me.components)
        Me.erpResultados = New Klik.Windows.Forms.v1.EntryLib.ELRichPanel()
        CType(Me.erpBusquedas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.erpBusquedas.SuspendLayout()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnFind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUbicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElDivider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtaGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KFormManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erpResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.erpResultados.SuspendLayout()
        Me.SuspendLayout()
        '
        'erpBusquedas
        '
        Me.erpBusquedas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.erpBusquedas.AutoPadding = False
        Me.erpBusquedas.ContainerStyle.BackgroundStyle.GradientAngle = 45.0!
        Me.erpBusquedas.Controls.Add(Me.txtSerie)
        Me.erpBusquedas.Controls.Add(Me.txtObservacion)
        Me.erpBusquedas.Controls.Add(Me.btnExcel)
        Me.erpBusquedas.Controls.Add(Me.btnFind)
        Me.erpBusquedas.Controls.Add(Me.btnBack)
        Me.erpBusquedas.Controls.Add(Me.txtUbicacion)
        Me.erpBusquedas.Controls.Add(Me.txtDescripcion)
        Me.erpBusquedas.Controls.Add(Me.txtCodigo)
        Me.erpBusquedas.Controls.Add(Me.ElDivider2)
        Me.erpBusquedas.Expanded = True
        Me.erpBusquedas.FooterStyle.BackgroundStyle.GradientAngle = 45.0!
        Me.erpBusquedas.FooterStyle.FlashStyle.GradientAngle = 0!
        Me.erpBusquedas.FooterStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.erpBusquedas.FooterStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.erpBusquedas.FooterStyle.Height = 20
        Me.erpBusquedas.FooterStyle.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.erpBusquedas.FooterStyle.TextStyle.ForeColor = System.Drawing.Color.Red
        Me.erpBusquedas.HeaderStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.erpBusquedas.HeaderStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.erpBusquedas.HeaderStyle.Height = 24
        Me.erpBusquedas.HeaderStyle.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.erpBusquedas.HeaderStyle.TextStyle.Text = "BUSQUEDAS"
        Me.erpBusquedas.Location = New System.Drawing.Point(3, 3)
        Me.erpBusquedas.Name = "erpBusquedas"
        Me.erpBusquedas.Padding = New System.Windows.Forms.Padding(1, 24, 1, 20)
        Me.erpBusquedas.Size = New System.Drawing.Size(298, 542)
        Me.erpBusquedas.TabIndex = 9
        '
        'txtSerie
        '
        Me.txtSerie.AutoSize = False
        Me.txtSerie.CaptionStyle.CaptionSize = 90
        Me.txtSerie.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.txtSerie.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtSerie.CaptionStyle.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerie.CaptionStyle.TextStyle.Text = "SERIE"
        Me.txtSerie.EditBoxStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerie.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSerie.Location = New System.Drawing.Point(5, 56)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(286, 23)
        Me.txtSerie.TabIndex = 67
        Me.txtSerie.ValidationStyle.MaxLength = 100
        Me.txtSerie.ValidationStyle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSerie.Value = ""
        '
        'txtObservacion
        '
        Me.txtObservacion.AutoSize = False
        Me.txtObservacion.CaptionStyle.CaptionSize = 90
        Me.txtObservacion.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.txtObservacion.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtObservacion.CaptionStyle.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacion.CaptionStyle.TextStyle.Text = "DESCRIPCIÓN"
        Me.txtObservacion.EditBoxStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacion.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtObservacion.Location = New System.Drawing.Point(4, 114)
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(286, 23)
        Me.txtObservacion.TabIndex = 66
        Me.txtObservacion.ValidationStyle.MaxLength = 100
        Me.txtObservacion.ValidationStyle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtObservacion.Value = ""
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExcel.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnExcel.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnExcel.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnExcel.Location = New System.Drawing.Point(145, 489)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(133, 23)
        Me.btnExcel.TabIndex = 65
        Me.btnExcel.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcel.TextStyle.Text = "EXCEL"
        Me.btnExcel.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnFind
        '
        Me.btnFind.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnFind.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnFind.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnFind.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnFind.Location = New System.Drawing.Point(5, 180)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(134, 23)
        Me.btnFind.TabIndex = 36
        Me.btnFind.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFind.TextStyle.Text = "BUSCAR"
        Me.btnFind.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnBack.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnBack.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnBack.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnBack.Location = New System.Drawing.Point(4, 489)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(135, 23)
        Me.btnBack.TabIndex = 4
        Me.btnBack.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.TextStyle.Text = "VOLVER"
        Me.btnBack.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUbicacion
        '
        Me.txtUbicacion.AutoSize = False
        Me.txtUbicacion.CaptionStyle.CaptionSize = 90
        Me.txtUbicacion.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.txtUbicacion.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtUbicacion.CaptionStyle.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUbicacion.CaptionStyle.TextStyle.Text = "UBICACIÓN"
        Me.txtUbicacion.EditBoxStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUbicacion.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtUbicacion.Location = New System.Drawing.Point(4, 143)
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.Size = New System.Drawing.Size(286, 23)
        Me.txtUbicacion.TabIndex = 7
        Me.txtUbicacion.ValidationStyle.MaxLength = 20
        Me.txtUbicacion.ValidationStyle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUbicacion.Value = ""
        '
        'txtDescripcion
        '
        Me.txtDescripcion.AutoSize = False
        Me.txtDescripcion.CaptionStyle.CaptionSize = 90
        Me.txtDescripcion.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.txtDescripcion.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtDescripcion.CaptionStyle.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.CaptionStyle.TextStyle.Text = "DESCRIPCIÓN"
        Me.txtDescripcion.EditBoxStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDescripcion.Location = New System.Drawing.Point(4, 85)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(286, 23)
        Me.txtDescripcion.TabIndex = 6
        Me.txtDescripcion.ValidationStyle.MaxLength = 100
        Me.txtDescripcion.ValidationStyle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcion.Value = ""
        '
        'txtCodigo
        '
        Me.txtCodigo.AutoSize = False
        Me.txtCodigo.CaptionStyle.CaptionSize = 110
        Me.txtCodigo.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.txtCodigo.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtCodigo.CaptionStyle.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.CaptionStyle.TextStyle.Text = "COD PRODUCTO"
        Me.txtCodigo.EditBoxStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCodigo.Location = New System.Drawing.Point(4, 27)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(286, 23)
        Me.txtCodigo.TabIndex = 5
        Me.txtCodigo.ValidationStyle.MaxLength = 100
        Me.txtCodigo.ValidationStyle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCodigo.Value = ""
        '
        'ElDivider2
        '
        Me.ElDivider2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ElDivider2.LineSize = 3
        Me.ElDivider2.Location = New System.Drawing.Point(0, 460)
        Me.ElDivider2.Name = "ElDivider2"
        Me.ElDivider2.Size = New System.Drawing.Size(278, 23)
        Me.ElDivider2.TabIndex = 40
        '
        'dtaGrid
        '
        Me.dtaGrid.AllowUserToAddRows = False
        Me.dtaGrid.AllowUserToDeleteRows = False
        Me.dtaGrid.AllowUserToResizeRows = False
        Me.dtaGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtaGrid.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.dtaGrid.BackgroundStyle.SolidColor = System.Drawing.SystemColors.Window
        Me.dtaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtaGrid.DefaultCellStyle = DataGridViewCellStyle1
        Me.dtaGrid.GridColor = System.Drawing.Color.LightGray
        Me.dtaGrid.Location = New System.Drawing.Point(4, 24)
        Me.dtaGrid.Name = "dtaGrid"
        Me.dtaGrid.ReadOnly = True
        Me.dtaGrid.RowHeadersWidth = 51
        Me.dtaGrid.Size = New System.Drawing.Size(973, 500)
        Me.dtaGrid.TabIndex = 1
        '
        'KFormManager1
        '
        Me.KFormManager1.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle
        Me.KFormManager1.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle
        Me.KFormManager1.MainContainer = Me
        '
        'erpResultados
        '
        Me.erpResultados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.erpResultados.ContainerStyle.BackgroundStyle.GradientAngle = 45.0!
        Me.erpResultados.Controls.Add(Me.dtaGrid)
        Me.erpResultados.Expanded = True
        Me.erpResultados.FooterStyle.BackgroundStyle.GradientAngle = 45.0!
        Me.erpResultados.FooterStyle.FlashStyle.GradientAngle = 0!
        Me.erpResultados.FooterStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.erpResultados.FooterStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.erpResultados.FooterStyle.Height = 20
        Me.erpResultados.HeaderStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.erpResultados.HeaderStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.erpResultados.HeaderStyle.Height = 24
        Me.erpResultados.HeaderStyle.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.erpResultados.HeaderStyle.TextStyle.Text = "RESULTADOS"
        Me.erpResultados.Location = New System.Drawing.Point(303, 3)
        Me.erpResultados.Name = "erpResultados"
        Me.erpResultados.Padding = New System.Windows.Forms.Padding(1, 24, 1, 20)
        Me.erpResultados.Size = New System.Drawing.Size(981, 542)
        Me.erpResultados.TabIndex = 8
        '
        'frmVerSeries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1288, 547)
        Me.Controls.Add(Me.erpBusquedas)
        Me.Controls.Add(Me.erpResultados)
        Me.DoubleBuffered = True
        Me.Name = "frmVerSeries"
        Me.Text = "frmVerSeries"
        CType(Me.erpBusquedas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.erpBusquedas.ResumeLayout(False)
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExcel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnFind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUbicacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElDivider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtaGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KFormManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erpResultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.erpResultados.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents erpBusquedas As Klik.Windows.Forms.v1.EntryLib.ELRichPanel
    Friend WithEvents btnExcel As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents btnFind As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents btnBack As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents txtUbicacion As Klik.Windows.Forms.v1.EntryLib.ELEntryBox
    Friend WithEvents txtDescripcion As Klik.Windows.Forms.v1.EntryLib.ELEntryBox
    Friend WithEvents txtCodigo As Klik.Windows.Forms.v1.EntryLib.ELEntryBox
    Friend WithEvents ElDivider2 As Klik.Windows.Forms.v1.EntryLib.ELDivider
    Friend WithEvents dtaGrid As Klik.Windows.Forms.v1.EntryLib.ELDataGridView
    Friend WithEvents KFormManager1 As Klik.Windows.Forms.v1.Common.KFormManager
    Friend WithEvents erpResultados As Klik.Windows.Forms.v1.EntryLib.ELRichPanel
    Friend WithEvents txtObservacion As Klik.Windows.Forms.v1.EntryLib.ELEntryBox
    Friend WithEvents txtSerie As Klik.Windows.Forms.v1.EntryLib.ELEntryBox
End Class
