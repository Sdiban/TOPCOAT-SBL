﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMantProveedor
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.erpEdicion = New Klik.Windows.Forms.v1.EntryLib.ELRichPanel()
        Me.btnBack = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.btnUndo = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.btnSave = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.btnDel = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.btnCrear = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.txtNombre = New Klik.Windows.Forms.v1.EntryLib.ELEntryBox()
        Me.txtId = New Klik.Windows.Forms.v1.EntryLib.ELEntryBox()
        Me.erpResultados = New Klik.Windows.Forms.v1.EntryLib.ELRichPanel()
        Me.dtaGrid = New Klik.Windows.Forms.v1.EntryLib.ELDataGridView()
        CType(Me.erpEdicion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.erpEdicion.SuspendLayout()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUndo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCrear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erpResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.erpResultados.SuspendLayout()
        CType(Me.dtaGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'erpEdicion
        '
        Me.erpEdicion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.erpEdicion.ContainerStyle.BackgroundStyle.GradientAngle = 45.0!
        Me.erpEdicion.ContainerStyle.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.erpEdicion.Controls.Add(Me.btnBack)
        Me.erpEdicion.Controls.Add(Me.btnUndo)
        Me.erpEdicion.Controls.Add(Me.btnSave)
        Me.erpEdicion.Controls.Add(Me.btnDel)
        Me.erpEdicion.Controls.Add(Me.btnCrear)
        Me.erpEdicion.Controls.Add(Me.txtNombre)
        Me.erpEdicion.Controls.Add(Me.txtId)
        Me.erpEdicion.Expanded = True
        Me.erpEdicion.FooterStyle.BackgroundStyle.GradientAngle = 0!
        Me.erpEdicion.FooterStyle.FlashStyle.GradientAngle = 0!
        Me.erpEdicion.FooterStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.erpEdicion.FooterStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.erpEdicion.FooterStyle.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.erpEdicion.FooterStyle.Height = 20
        Me.erpEdicion.FooterStyle.TextStyle.ForeColor = System.Drawing.Color.Black
        Me.erpEdicion.HeaderStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.erpEdicion.HeaderStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.erpEdicion.HeaderStyle.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.erpEdicion.HeaderStyle.Height = 24
        Me.erpEdicion.HeaderStyle.TextStyle.ForeColor = System.Drawing.Color.Black
        Me.erpEdicion.HeaderStyle.TextStyle.Text = "EDICION"
        Me.erpEdicion.Location = New System.Drawing.Point(547, 2)
        Me.erpEdicion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.erpEdicion.Name = "erpEdicion"
        Me.erpEdicion.Padding = New System.Windows.Forms.Padding(1, 24, 1, 20)
        Me.erpEdicion.Size = New System.Drawing.Size(483, 538)
        Me.erpEdicion.TabIndex = 17
        '
        'btnBack
        '
        Me.btnBack.BorderStyle.EdgeRadius = 7
        Me.btnBack.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.btnBack.DropDownArrowColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnBack.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnBack.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnBack.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnBack.Location = New System.Drawing.Point(159, 74)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(145, 31)
        Me.btnBack.TabIndex = 4
        Me.btnBack.TextStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnBack.TextStyle.Text = "VOLVER"
        Me.btnBack.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnUndo
        '
        Me.btnUndo.BorderStyle.EdgeRadius = 7
        Me.btnUndo.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.btnUndo.DropDownArrowColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnUndo.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnUndo.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnUndo.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnUndo.Location = New System.Drawing.Point(312, 36)
        Me.btnUndo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(145, 31)
        Me.btnUndo.TabIndex = 2
        Me.btnUndo.TextStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnUndo.TextStyle.Text = "LIMPIAR"
        Me.btnUndo.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSave
        '
        Me.btnSave.BorderStyle.EdgeRadius = 7
        Me.btnSave.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSave.DropDownArrowColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnSave.Enabled = False
        Me.btnSave.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnSave.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnSave.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSave.Location = New System.Drawing.Point(5, 74)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(145, 31)
        Me.btnSave.TabIndex = 3
        Me.btnSave.TextStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnSave.TextStyle.Text = "GRABAR"
        Me.btnSave.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDel
        '
        Me.btnDel.BorderStyle.EdgeRadius = 7
        Me.btnDel.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.btnDel.DropDownArrowColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnDel.Enabled = False
        Me.btnDel.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnDel.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnDel.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnDel.Location = New System.Drawing.Point(159, 36)
        Me.btnDel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(145, 31)
        Me.btnDel.TabIndex = 1
        Me.btnDel.TextStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnDel.TextStyle.Text = "ELIMINAR"
        Me.btnDel.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCrear
        '
        Me.btnCrear.BorderStyle.EdgeRadius = 7
        Me.btnCrear.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.btnCrear.DropDownArrowColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCrear.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnCrear.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnCrear.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnCrear.Location = New System.Drawing.Point(5, 36)
        Me.btnCrear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(145, 31)
        Me.btnCrear.TabIndex = 0
        Me.btnCrear.TextStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCrear.TextStyle.Text = "NUEVO"
        Me.btnCrear.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombre
        '
        Me.txtNombre.CaptionStyle.CaptionSize = 120
        Me.txtNombre.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.txtNombre.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtNombre.CaptionStyle.TextStyle.ForeColor = System.Drawing.Color.Black
        Me.txtNombre.CaptionStyle.TextStyle.Text = "NOMBRE PROV."
        Me.txtNombre.EditBoxStyle.BorderStyle.BorderType = Klik.Windows.Forms.v1.Common.BorderTypes.None
        Me.txtNombre.EditBoxStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(5, 190)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(472, 28)
        Me.txtNombre.TabIndex = 6
        Me.txtNombre.ValidationStyle.MaxLength = 50
        Me.txtNombre.ValidationStyle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.ValidationStyle.StringValidationStyle.InvalidCharacters = "'"",.?¿\/%!#$()=´^{}[]|°-_:;+*<>"
        Me.txtNombre.Value = ""
        '
        'txtId
        '
        Me.txtId.AutoSize = False
        Me.txtId.CaptionStyle.CaptionSize = 120
        Me.txtId.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.txtId.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtId.CaptionStyle.TextStyle.ForeColor = System.Drawing.Color.Black
        Me.txtId.CaptionStyle.TextStyle.Text = "RUT PROV."
        Me.txtId.EditBoxStyle.BorderStyle.BorderType = Klik.Windows.Forms.v1.Common.BorderTypes.None
        Me.txtId.EditBoxStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(5, 149)
        Me.txtId.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(299, 28)
        Me.txtId.TabIndex = 5
        Me.txtId.ValidationStyle.MaxLength = 15
        Me.txtId.ValidationStyle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtId.ValidationStyle.StringValidationStyle.CharacterCasing = Klik.Windows.Forms.v1.EntryLib.CharacterCasing.Upper
        Me.txtId.ValidationStyle.StringValidationStyle.InvalidCharacters = "'"",.?¿\/%!#$()=´^{}[]|°_:;+*<>"
        Me.txtId.Value = ""
        '
        'erpResultados
        '
        Me.erpResultados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.erpResultados.ContainerStyle.BackgroundStyle.GradientAngle = 45.0!
        Me.erpResultados.ContainerStyle.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.erpResultados.Controls.Add(Me.dtaGrid)
        Me.erpResultados.Expanded = True
        Me.erpResultados.FooterStyle.BackgroundStyle.GradientAngle = 0!
        Me.erpResultados.FooterStyle.FlashStyle.GradientAngle = 0!
        Me.erpResultados.FooterStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.erpResultados.FooterStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.erpResultados.FooterStyle.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.erpResultados.FooterStyle.Height = 20
        Me.erpResultados.FooterStyle.TextStyle.ForeColor = System.Drawing.Color.Black
        Me.erpResultados.HeaderStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.erpResultados.HeaderStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.erpResultados.HeaderStyle.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.erpResultados.HeaderStyle.Height = 24
        Me.erpResultados.HeaderStyle.TextStyle.ForeColor = System.Drawing.Color.Black
        Me.erpResultados.HeaderStyle.TextStyle.Text = "RESULTADOS"
        Me.erpResultados.Location = New System.Drawing.Point(3, 2)
        Me.erpResultados.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.erpResultados.Name = "erpResultados"
        Me.erpResultados.Padding = New System.Windows.Forms.Padding(1, 24, 1, 20)
        Me.erpResultados.Size = New System.Drawing.Size(541, 538)
        Me.erpResultados.TabIndex = 18
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
        Me.dtaGrid.Location = New System.Drawing.Point(5, 24)
        Me.dtaGrid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtaGrid.Name = "dtaGrid"
        Me.dtaGrid.ReadOnly = True
        Me.dtaGrid.RowHeadersWidth = 51
        Me.dtaGrid.Size = New System.Drawing.Size(531, 496)
        Me.dtaGrid.TabIndex = 1
        '
        'frmMantProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 545)
        Me.Controls.Add(Me.erpResultados)
        Me.Controls.Add(Me.erpEdicion)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmMantProveedor"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MANTENEDOR PROVEEDORES"
        CType(Me.erpEdicion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.erpEdicion.ResumeLayout(False)
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUndo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCrear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erpResultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.erpResultados.ResumeLayout(False)
        CType(Me.dtaGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents erpEdicion As Klik.Windows.Forms.v1.EntryLib.ELRichPanel
    Friend WithEvents btnBack As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents btnUndo As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents btnSave As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents btnDel As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents btnCrear As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents txtNombre As Klik.Windows.Forms.v1.EntryLib.ELEntryBox
    Friend WithEvents txtId As Klik.Windows.Forms.v1.EntryLib.ELEntryBox
    Friend WithEvents erpResultados As Klik.Windows.Forms.v1.EntryLib.ELRichPanel
    Friend WithEvents dtaGrid As Klik.Windows.Forms.v1.EntryLib.ELDataGridView
End Class
