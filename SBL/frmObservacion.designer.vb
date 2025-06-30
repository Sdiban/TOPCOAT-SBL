<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmObservaciones
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
        Me.components = New System.ComponentModel.Container
        Dim PaintStyle1 As Klik.Windows.Forms.v1.Common.PaintStyle = New Klik.Windows.Forms.v1.Common.PaintStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmObservaciones))
        Me.KFormManager1 = New Klik.Windows.Forms.v1.Common.KFormManager(Me.components)
        Me.erpDetalle = New Klik.Windows.Forms.v1.EntryLib.ELRichPanel
        Me.txtObservacion = New System.Windows.Forms.TextBox
        Me.txtInv = New Klik.Windows.Forms.v1.EntryLib.ELEntryBox
        Me.btnGrabar = New Klik.Windows.Forms.v1.EntryLib.ELButton
        Me.btnBack = New Klik.Windows.Forms.v1.EntryLib.ELButton
        Me.lblDescripcion = New Klik.Windows.Forms.v1.EntryLib.ELLabel
        CType(Me.KFormManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erpDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.erpDetalle.SuspendLayout()
        CType(Me.txtInv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGrabar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KFormManager1
        '
        Me.KFormManager1.BackgroundImageStyle.Alpha = 100
        Me.KFormManager1.BackgroundImageStyle.ImageEffect = Klik.Windows.Forms.v1.Common.ImageEffect.Mirror
        Me.KFormManager1.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle
        Me.KFormManager1.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle
        Me.KFormManager1.MainContainer = Me
        '
        'erpDetalle
        '
        Me.erpDetalle.ContainerStyle.BackgroundStyle.GradientAngle = 45.0!
        Me.erpDetalle.ContainerStyle.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.erpDetalle.Controls.Add(Me.txtObservacion)
        Me.erpDetalle.Controls.Add(Me.txtInv)
        Me.erpDetalle.Controls.Add(Me.btnGrabar)
        Me.erpDetalle.Controls.Add(Me.btnBack)
        Me.erpDetalle.Controls.Add(Me.lblDescripcion)
        Me.erpDetalle.Expanded = True
        Me.erpDetalle.FooterStyle.BackgroundStyle.GradientAngle = 0.0!
        Me.erpDetalle.FooterStyle.FlashStyle.GradientAngle = 0.0!
        Me.erpDetalle.FooterStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.erpDetalle.FooterStyle.FlashStyle.SolidColor = System.Drawing.Color.FROMArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.erpDetalle.FooterStyle.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.erpDetalle.FooterStyle.TextStyle.ForeColor = System.Drawing.Color.Black
        Me.erpDetalle.HeaderStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.erpDetalle.HeaderStyle.FlashStyle.SolidColor = System.Drawing.Color.FROMArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.erpDetalle.HeaderStyle.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.erpDetalle.HeaderStyle.Height = 24
        Me.erpDetalle.HeaderStyle.TextStyle.ForeColor = System.Drawing.Color.Black
        Me.erpDetalle.Location = New System.Drawing.Point(2, 3)
        Me.erpDetalle.Name = "erpDetalle"
        Me.erpDetalle.Padding = New System.Windows.Forms.Padding(1, 24, 1, 16)
        Me.erpDetalle.Size = New System.Drawing.Size(784, 175)
        Me.erpDetalle.TabIndex = 30
        '
        'txtObservacion
        '
        Me.txtObservacion.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtObservacion.Location = New System.Drawing.Point(127, 65)
        Me.txtObservacion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(637, 53)
        Me.txtObservacion.TabIndex = 1
        '
        'txtInv
        '
        Me.txtInv.CaptionStyle.CaptionSize = 120
        Me.txtInv.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.txtInv.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FROMArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtInv.CaptionStyle.TextStyle.ForeColor = System.Drawing.Color.Black
        Me.txtInv.CaptionStyle.TextStyle.Text = "Nº INVENTARIO"
        Me.txtInv.EditBoxStyle.BorderStyle.BorderType = Klik.Windows.Forms.v1.Common.BorderTypes.None
        Me.txtInv.EditBoxStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInv.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtInv.Enabled = False
        Me.txtInv.Location = New System.Drawing.Point(4, 32)
        Me.txtInv.Name = "txtInv"
        Me.txtInv.Size = New System.Drawing.Size(256, 25)
        Me.txtInv.TabIndex = 0
        Me.txtInv.ValidationStyle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtInv.Value = ""
        '
        'btnGrabar
        '
        Me.btnGrabar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnGrabar.BorderStyle.EdgeRadius = 7
        Me.btnGrabar.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.btnGrabar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnGrabar.DropDownArrowColor = System.Drawing.Color.FROMArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGrabar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnGrabar.FlashStyle.SolidColor = System.Drawing.Color.FROMArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnGrabar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnGrabar.Location = New System.Drawing.Point(530, 131)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(98, 23)
        Me.btnGrabar.TabIndex = 2
        Me.btnGrabar.TextStyle.ForeColor = System.Drawing.Color.FROMArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGrabar.TextStyle.Text = "GRABAR"
        Me.btnGrabar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnBack.BorderStyle.EdgeRadius = 7
        Me.btnBack.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.btnBack.DropDownArrowColor = System.Drawing.Color.FROMArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnBack.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnBack.FlashStyle.SolidColor = System.Drawing.Color.FROMArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnBack.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnBack.Location = New System.Drawing.Point(676, 131)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(98, 23)
        Me.btnBack.TabIndex = 3
        Me.btnBack.TextStyle.ForeColor = System.Drawing.Color.FROMArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnBack.TextStyle.Text = "CANCELAR"
        Me.btnBack.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDescripcion
        '
        Me.lblDescripcion.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        PaintStyle1.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        PaintStyle1.SolidColor = System.Drawing.Color.FROMArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.lblDescripcion.FlashStyle = PaintStyle1
        Me.lblDescripcion.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDescripcion.Location = New System.Drawing.Point(4, 63)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(770, 57)
        Me.lblDescripcion.TabIndex = 129
        Me.lblDescripcion.TabStop = False
        Me.lblDescripcion.TextStyle.ForeColor = System.Drawing.Color.Black
        Me.lblDescripcion.TextStyle.Text = "OBSERVACIONES"
        '
        'frmObservaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 179)
        Me.Controls.Add(Me.erpDetalle)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmObservaciones"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CREAR INVENTARIO"
        CType(Me.KFormManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erpDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.erpDetalle.ResumeLayout(False)
        Me.erpDetalle.PerformLayout()
        CType(Me.txtInv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGrabar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KFormManager1 As Klik.Windows.Forms.v1.Common.KFormManager
    Friend WithEvents erpDetalle As Klik.Windows.Forms.v1.EntryLib.ELRichPanel
    Friend WithEvents btnBack As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents btnGrabar As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents txtInv As Klik.Windows.Forms.v1.EntryLib.ELEntryBox
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents lblDescripcion As Klik.Windows.Forms.v1.EntryLib.ELLabel
End Class
