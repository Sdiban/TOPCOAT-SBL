<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIngresaProducto
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
        Me.erpEdicion = New Klik.Windows.Forms.v1.EntryLib.ELRichPanel()
        Me.txtCodigoInt = New Klik.Windows.Forms.v1.EntryLib.ELEntryBox()
        Me.btnBack = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.btnSave = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.txtDescripcion = New Klik.Windows.Forms.v1.EntryLib.ELEntryBox()
        Me.txtCodigo = New Klik.Windows.Forms.v1.EntryLib.ELEntryBox()
        Me.ElDivider1 = New Klik.Windows.Forms.v1.EntryLib.ELDivider()
        Me.KFormManager1 = New Klik.Windows.Forms.v1.Common.KFormManager(Me.components)
        Me.tmrMensaje = New System.Windows.Forms.Timer(Me.components)
        CType(Me.erpEdicion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.erpEdicion.SuspendLayout()
        CType(Me.txtCodigoInt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElDivider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KFormManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'erpEdicion
        '
        Me.erpEdicion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.erpEdicion.ContainerStyle.BackgroundStyle.GradientAngle = 45.0!
        Me.erpEdicion.Controls.Add(Me.txtCodigoInt)
        Me.erpEdicion.Controls.Add(Me.btnBack)
        Me.erpEdicion.Controls.Add(Me.btnSave)
        Me.erpEdicion.Controls.Add(Me.txtDescripcion)
        Me.erpEdicion.Controls.Add(Me.txtCodigo)
        Me.erpEdicion.Controls.Add(Me.ElDivider1)
        Me.erpEdicion.Expanded = True
        Me.erpEdicion.FooterStyle.BackgroundStyle.GradientAngle = 45.0!
        Me.erpEdicion.FooterStyle.FlashStyle.GradientAngle = 0!
        Me.erpEdicion.FooterStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.erpEdicion.FooterStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.erpEdicion.FooterStyle.Height = 20
        Me.erpEdicion.FooterStyle.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.erpEdicion.FooterStyle.TextStyle.ForeColor = System.Drawing.Color.Red
        Me.erpEdicion.HeaderStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.erpEdicion.HeaderStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.erpEdicion.HeaderStyle.Height = 24
        Me.erpEdicion.HeaderStyle.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.erpEdicion.Location = New System.Drawing.Point(4, 5)
        Me.erpEdicion.Name = "erpEdicion"
        Me.erpEdicion.Padding = New System.Windows.Forms.Padding(1, 24, 1, 20)
        Me.erpEdicion.Size = New System.Drawing.Size(500, 205)
        Me.erpEdicion.TabIndex = 1
        '
        'txtCodigoInt
        '
        Me.txtCodigoInt.CaptionStyle.CaptionSize = 115
        Me.txtCodigoInt.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.txtCodigoInt.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtCodigoInt.CaptionStyle.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoInt.CaptionStyle.TextStyle.Text = "CÓDIGO INTERNO"
        Me.txtCodigoInt.EditBoxStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoInt.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCodigoInt.Location = New System.Drawing.Point(4, 119)
        Me.txtCodigoInt.Name = "txtCodigoInt"
        Me.txtCodigoInt.Size = New System.Drawing.Size(354, 25)
        Me.txtCodigoInt.TabIndex = 3
        Me.txtCodigoInt.ValidationStyle.MaxLength = 50
        Me.txtCodigoInt.ValidationStyle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCodigoInt.Value = ""
        '
        'btnBack
        '
        Me.btnBack.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnBack.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnBack.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnBack.Location = New System.Drawing.Point(385, 30)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(109, 23)
        Me.btnBack.TabIndex = 6
        Me.btnBack.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.TextStyle.Text = "VOLVER"
        Me.btnBack.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSave
        '
        Me.btnSave.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnSave.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnSave.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSave.Location = New System.Drawing.Point(4, 30)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(109, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.TextStyle.Text = "GRABAR"
        Me.btnSave.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CaptionStyle.CaptionSize = 115
        Me.txtDescripcion.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.txtDescripcion.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtDescripcion.CaptionStyle.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.CaptionStyle.TextStyle.Text = "DESCRIPCIÓN"
        Me.txtDescripcion.EditBoxStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDescripcion.Location = New System.Drawing.Point(4, 150)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(492, 25)
        Me.txtDescripcion.TabIndex = 4
        Me.txtDescripcion.ValidationStyle.MaxLength = 50
        Me.txtDescripcion.ValidationStyle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcion.Value = ""
        '
        'txtCodigo
        '
        Me.txtCodigo.CaptionStyle.CaptionSize = 115
        Me.txtCodigo.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.txtCodigo.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtCodigo.CaptionStyle.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.CaptionStyle.TextStyle.Text = "CÓDIGO DE BARRA"
        Me.txtCodigo.EditBoxStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCodigo.Location = New System.Drawing.Point(4, 86)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(354, 25)
        Me.txtCodigo.TabIndex = 2
        Me.txtCodigo.ValidationStyle.MaxLength = 50
        Me.txtCodigo.ValidationStyle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCodigo.Value = ""
        '
        'ElDivider1
        '
        Me.ElDivider1.LineSize = 3
        Me.ElDivider1.Location = New System.Drawing.Point(4, 54)
        Me.ElDivider1.Name = "ElDivider1"
        Me.ElDivider1.Size = New System.Drawing.Size(456, 23)
        Me.ElDivider1.TabIndex = 7
        '
        'KFormManager1
        '
        Me.KFormManager1.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle
        Me.KFormManager1.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle
        Me.KFormManager1.MainContainer = Me
        '
        'tmrMensaje
        '
        Me.tmrMensaje.Interval = 10000
        '
        'FrmIngresaProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 214)
        Me.Controls.Add(Me.erpEdicion)
        Me.DoubleBuffered = True
        Me.Name = "FrmIngresaProducto"
        Me.Text = "INGRESO PRODUCTO"
        CType(Me.erpEdicion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.erpEdicion.ResumeLayout(False)
        CType(Me.txtCodigoInt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElDivider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KFormManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents erpEdicion As Klik.Windows.Forms.v1.EntryLib.ELRichPanel
    Friend WithEvents txtCodigoInt As Klik.Windows.Forms.v1.EntryLib.ELEntryBox
    Friend WithEvents btnBack As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents btnSave As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents txtDescripcion As Klik.Windows.Forms.v1.EntryLib.ELEntryBox
    Friend WithEvents txtCodigo As Klik.Windows.Forms.v1.EntryLib.ELEntryBox
    Friend WithEvents ElDivider1 As Klik.Windows.Forms.v1.EntryLib.ELDivider
    Friend WithEvents KFormManager1 As Klik.Windows.Forms.v1.Common.KFormManager
    Friend WithEvents tmrMensaje As Timer
End Class
