<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim PaintStyle1 As Klik.Windows.Forms.v1.Common.PaintStyle = New Klik.Windows.Forms.v1.Common.PaintStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.KFormManager1 = New Klik.Windows.Forms.v1.Common.KFormManager(Me.components)
        Me.lblDescripcion = New Klik.Windows.Forms.v1.EntryLib.ELLabel()
        Me.txtPassword = New Klik.Windows.Forms.v1.EntryLib.ELEntryBox()
        Me.txtUsuario = New Klik.Windows.Forms.v1.EntryLib.ELEntryBox()
        Me.btnEnd = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.btnLogin = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.KFormManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblInfo
        '
        Me.lblInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblInfo.ForeColor = System.Drawing.Color.White
        Me.lblInfo.Location = New System.Drawing.Point(37, 208)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(126, 91)
        Me.lblInfo.TabIndex = 43
        Me.lblInfo.Text = "1.1.1.1"
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'KFormManager1
        '
        Me.KFormManager1.BackgroundImageStyle.Alpha = 100
        Me.KFormManager1.BackgroundImageStyle.Image = Global.SBL.My.Resources.Resources.loginfondo
        Me.KFormManager1.BackgroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.KFormManager1.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Transparent
        Me.KFormManager1.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle
        Me.KFormManager1.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle
        Me.KFormManager1.MainContainer = Me
        '
        'lblDescripcion
        '
        Me.lblDescripcion.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        PaintStyle1.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        PaintStyle1.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.lblDescripcion.FlashStyle = PaintStyle1
        Me.lblDescripcion.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDescripcion.Location = New System.Drawing.Point(71, 32)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(366, 36)
        Me.lblDescripcion.TabIndex = 78
        Me.lblDescripcion.TabStop = False
        Me.lblDescripcion.TextStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.TextStyle.ForeColor = System.Drawing.Color.Black
        Me.lblDescripcion.TextStyle.Text = "Acceso a Sistema SBL"
        Me.lblDescripcion.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPassword
        '
        Me.txtPassword.CaptionStyle.BackgroundStyle.GradientEndColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtPassword.CaptionStyle.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.CaptionStyle.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Transparent
        Me.txtPassword.CaptionStyle.BorderStyle.BorderType = Klik.Windows.Forms.v1.Common.BorderTypes.None
        Me.txtPassword.CaptionStyle.BorderStyle.GradientEndColor = System.Drawing.Color.Transparent
        Me.txtPassword.CaptionStyle.BorderStyle.GradientStartColor = System.Drawing.Color.Transparent
        Me.txtPassword.CaptionStyle.BorderStyle.SolidColor = System.Drawing.Color.Transparent
        Me.txtPassword.CaptionStyle.CaptionSize = 110
        Me.txtPassword.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.txtPassword.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtPassword.CaptionStyle.TextStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.CaptionStyle.TextStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.CaptionStyle.TextStyle.Text = "CONTRASEÑA"
        Me.txtPassword.EditBoxStyle.BorderStyle.BorderType = Klik.Windows.Forms.v1.Common.BorderTypes.None
        Me.txtPassword.EditBoxStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPassword.Location = New System.Drawing.Point(168, 135)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(269, 28)
        Me.txtPassword.TabIndex = 73
        Me.txtPassword.ValidationStyle.MaxLength = 20
        Me.txtPassword.ValidationStyle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Value = ""
        '
        'txtUsuario
        '
        Me.txtUsuario.CaptionStyle.BackgroundStyle.GradientEndColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtUsuario.CaptionStyle.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsuario.CaptionStyle.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Transparent
        Me.txtUsuario.CaptionStyle.BorderStyle.BorderType = Klik.Windows.Forms.v1.Common.BorderTypes.None
        Me.txtUsuario.CaptionStyle.BorderStyle.GradientEndColor = System.Drawing.Color.Transparent
        Me.txtUsuario.CaptionStyle.BorderStyle.GradientStartColor = System.Drawing.Color.Transparent
        Me.txtUsuario.CaptionStyle.BorderStyle.SolidColor = System.Drawing.Color.Transparent
        Me.txtUsuario.CaptionStyle.CaptionSize = 110
        Me.txtUsuario.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.txtUsuario.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtUsuario.CaptionStyle.TextStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.CaptionStyle.TextStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsuario.CaptionStyle.TextStyle.Text = "USUARIO"
        Me.txtUsuario.EditBoxStyle.BorderStyle.BorderType = Klik.Windows.Forms.v1.Common.BorderTypes.None
        Me.txtUsuario.EditBoxStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtUsuario.Location = New System.Drawing.Point(168, 101)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(269, 28)
        Me.txtUsuario.TabIndex = 72
        Me.txtUsuario.ValidationStyle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsuario.Value = ""
        '
        'btnEnd
        '
        Me.btnEnd.BackgroundImageStyle.Alpha = 100
        Me.btnEnd.BackgroundImageStyle.Image = Global.SBL.My.Resources.Resources.terminar
        Me.btnEnd.BackgroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEnd.BorderStyle.EdgeRadius = 20
        Me.btnEnd.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.btnEnd.DropDownArrowColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEnd.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnEnd.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnEnd.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnEnd.Location = New System.Drawing.Point(349, 192)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(88, 84)
        Me.btnEnd.TabIndex = 77
        Me.btnEnd.TextStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnd.TextStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEnd.TextStyle.Text = "Salir"
        Me.btnEnd.TextStyle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnLogin
        '
        Me.btnLogin.BackgroundImageStyle.Alpha = 100
        Me.btnLogin.BackgroundImageStyle.Image = Global.SBL.My.Resources.Resources.sesiones64
        Me.btnLogin.BackgroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLogin.BorderStyle.EdgeRadius = 20
        Me.btnLogin.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.btnLogin.DropDownArrowColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnLogin.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnLogin.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnLogin.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnLogin.Location = New System.Drawing.Point(169, 191)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(88, 84)
        Me.btnLogin.TabIndex = 76
        Me.btnLogin.TextStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.TextStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnLogin.TextStyle.Text = "Iniciar"
        Me.btnLogin.TextStyle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(58, 86)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(89, 110)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 75
        Me.PictureBox1.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = Global.SBL.My.Resources.Resources.loginfondo
        Me.ClientSize = New System.Drawing.Size(497, 330)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lblInfo)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acceso SBL"
        CType(Me.KFormManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEnd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents KFormManager1 As Klik.Windows.Forms.v1.Common.KFormManager
    Friend WithEvents lblDescripcion As Klik.Windows.Forms.v1.EntryLib.ELLabel
    Friend WithEvents btnEnd As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents btnLogin As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents txtPassword As Klik.Windows.Forms.v1.EntryLib.ELEntryBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtUsuario As Klik.Windows.Forms.v1.EntryLib.ELEntryBox
End Class
