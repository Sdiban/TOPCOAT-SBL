<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFamilia
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
        Me.KFormManager1 = New Klik.Windows.Forms.v1.Common.KFormManager(Me.components)
        Me.erpEdicion = New Klik.Windows.Forms.v1.EntryLib.ELRichPanel()
        Me.txtID_Familia = New Klik.Windows.Forms.v1.EntryLib.ELEntryBox()
        Me.btnBack = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.btnUndo = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.btnSave = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.btnDel = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.btnCrear = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.txtFamilia = New Klik.Windows.Forms.v1.EntryLib.ELEntryBox()
        Me.erpResultados = New Klik.Windows.Forms.v1.EntryLib.ELRichPanel()
        Me.dtaGrid = New Klik.Windows.Forms.v1.EntryLib.ELDataGridView()
        Me.tmrMensaje = New System.Windows.Forms.Timer(Me.components)
        CType(Me.KFormManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erpEdicion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.erpEdicion.SuspendLayout()
        CType(Me.txtID_Familia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUndo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCrear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFamilia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erpResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.erpResultados.SuspendLayout()
        CType(Me.dtaGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KFormManager1
        '
        Me.KFormManager1.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle
        Me.KFormManager1.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle
        Me.KFormManager1.MainContainer = Me
        '
        'erpEdicion
        '
        Me.erpEdicion.ContainerStyle.BackgroundStyle.GradientAngle = 45.0!
        Me.erpEdicion.Controls.Add(Me.txtID_Familia)
        Me.erpEdicion.Controls.Add(Me.btnBack)
        Me.erpEdicion.Controls.Add(Me.btnUndo)
        Me.erpEdicion.Controls.Add(Me.btnSave)
        Me.erpEdicion.Controls.Add(Me.btnDel)
        Me.erpEdicion.Controls.Add(Me.btnCrear)
        Me.erpEdicion.Controls.Add(Me.txtFamilia)
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
        Me.erpEdicion.HeaderStyle.TextStyle.Text = "EDICION"
        Me.erpEdicion.Location = New System.Drawing.Point(410, 2)
        Me.erpEdicion.Name = "erpEdicion"
        Me.erpEdicion.Padding = New System.Windows.Forms.Padding(1, 24, 1, 20)
        Me.erpEdicion.Size = New System.Drawing.Size(368, 437)
        Me.erpEdicion.TabIndex = 9
        '
        'txtID_Familia
        '
        Me.txtID_Familia.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.txtID_Familia.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtID_Familia.CaptionStyle.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID_Familia.CaptionStyle.TextStyle.Text = "ID"
        Me.txtID_Familia.EditBoxStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID_Familia.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtID_Familia.Enabled = False
        Me.txtID_Familia.Location = New System.Drawing.Point(4, 124)
        Me.txtID_Familia.Name = "txtID_Familia"
        Me.txtID_Familia.Size = New System.Drawing.Size(339, 25)
        Me.txtID_Familia.TabIndex = 2
        Me.txtID_Familia.ValidationStyle.MaxLength = 15
        Me.txtID_Familia.ValidationStyle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtID_Familia.Value = ""
        '
        'btnBack
        '
        Me.btnBack.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnBack.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnBack.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnBack.Location = New System.Drawing.Point(119, 60)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(109, 25)
        Me.btnBack.TabIndex = 8
        Me.btnBack.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.TextStyle.Text = "VOLVER"
        Me.btnBack.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnUndo
        '
        Me.btnUndo.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnUndo.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnUndo.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnUndo.Location = New System.Drawing.Point(234, 29)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(109, 25)
        Me.btnUndo.TabIndex = 6
        Me.btnUndo.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUndo.TextStyle.Text = "LIMPIAR"
        Me.btnUndo.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSave
        '
        Me.btnSave.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnSave.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnSave.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSave.Location = New System.Drawing.Point(4, 60)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(109, 25)
        Me.btnSave.TabIndex = 7
        Me.btnSave.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.TextStyle.Text = "GRABAR"
        Me.btnSave.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDel
        '
        Me.btnDel.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnDel.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnDel.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnDel.Location = New System.Drawing.Point(119, 29)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(109, 25)
        Me.btnDel.TabIndex = 5
        Me.btnDel.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.TextStyle.Text = "ELIMINAR"
        Me.btnDel.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCrear
        '
        Me.btnCrear.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnCrear.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnCrear.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnCrear.Location = New System.Drawing.Point(4, 29)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(109, 25)
        Me.btnCrear.TabIndex = 4
        Me.btnCrear.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrear.TextStyle.Text = "NUEVO"
        Me.btnCrear.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFamilia
        '
        Me.txtFamilia.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.txtFamilia.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtFamilia.CaptionStyle.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFamilia.CaptionStyle.TextStyle.Text = "FAMILIA"
        Me.txtFamilia.EditBoxStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFamilia.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFamilia.Enabled = False
        Me.txtFamilia.Location = New System.Drawing.Point(4, 155)
        Me.txtFamilia.Name = "txtFamilia"
        Me.txtFamilia.Size = New System.Drawing.Size(339, 25)
        Me.txtFamilia.TabIndex = 3
        Me.txtFamilia.ValidationStyle.MaxLength = 50
        Me.txtFamilia.ValidationStyle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFamilia.Value = ""
        '
        'erpResultados
        '
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
        Me.erpResultados.Location = New System.Drawing.Point(1, 2)
        Me.erpResultados.Name = "erpResultados"
        Me.erpResultados.Padding = New System.Windows.Forms.Padding(1, 24, 1, 20)
        Me.erpResultados.Size = New System.Drawing.Size(403, 437)
        Me.erpResultados.TabIndex = 0
        '
        'dtaGrid
        '
        Me.dtaGrid.AllowUserToAddRows = False
        Me.dtaGrid.AllowUserToDELETERows = False
        Me.dtaGrid.AllowUserToResizeRows = False
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
        Me.dtaGrid.Location = New System.Drawing.Point(4, 29)
        Me.dtaGrid.Name = "dtaGrid"
        Me.dtaGrid.ReadOnly = True
        Me.dtaGrid.Size = New System.Drawing.Size(393, 385)
        Me.dtaGrid.TabIndex = 1
        '
        'tmrMensaje
        '
        Me.tmrMensaje.Interval = 2000
        '
        'frmFamilia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 442)
        Me.ControlBox = False
        Me.Controls.Add(Me.erpEdicion)
        Me.Controls.Add(Me.erpResultados)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFamilia"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FAMILIA"
        CType(Me.KFormManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erpEdicion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.erpEdicion.ResumeLayout(False)
        CType(Me.txtID_Familia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUndo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCrear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFamilia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erpResultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.erpResultados.ResumeLayout(False)
        CType(Me.dtaGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KFormManager1 As Klik.Windows.Forms.v1.Common.KFormManager
    Friend WithEvents erpEdicion As Klik.Windows.Forms.v1.EntryLib.ELRichPanel
    Friend WithEvents btnBack As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents btnUndo As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents btnSave As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents btnDel As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents btnCrear As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents txtFamilia As Klik.Windows.Forms.v1.EntryLib.ELEntryBox
    Friend WithEvents erpResultados As Klik.Windows.Forms.v1.EntryLib.ELRichPanel
    Friend WithEvents dtaGrid As Klik.Windows.Forms.v1.EntryLib.ELDataGridView
    Friend WithEvents tmrMensaje As System.Windows.Forms.Timer
    Friend WithEvents txtID_Familia As Klik.Windows.Forms.v1.EntryLib.ELEntryBox
End Class
