<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddItemCompra
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim PaintStyle1 As Klik.Windows.Forms.v1.Common.PaintStyle = New Klik.Windows.Forms.v1.Common.PaintStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddItemCompra))
        Me.erpDetalle = New Klik.Windows.Forms.v1.EntryLib.ELRichPanel()
        Me.btnLimpiar = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.txtBuscar = New Klik.Windows.Forms.v1.EntryLib.ELEntryBox()
        Me.dtaGrid = New Klik.Windows.Forms.v1.EntryLib.ELDataGridView()
        Me.lblDescripcion = New Klik.Windows.Forms.v1.EntryLib.ELLabel()
        Me.btnAdd = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.btnBack = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.txtCantidad = New Klik.Windows.Forms.v1.EntryLib.ELEntryBox()
        CType(Me.erpDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.erpDetalle.SuspendLayout()
        CType(Me.btnLimpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtaGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'erpDetalle
        '
        Me.erpDetalle.ContainerStyle.BackgroundStyle.GradientAngle = 45.0!
        Me.erpDetalle.ContainerStyle.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.erpDetalle.Controls.Add(Me.btnLimpiar)
        Me.erpDetalle.Controls.Add(Me.txtBuscar)
        Me.erpDetalle.Controls.Add(Me.dtaGrid)
        Me.erpDetalle.Controls.Add(Me.lblDescripcion)
        Me.erpDetalle.Controls.Add(Me.btnAdd)
        Me.erpDetalle.Controls.Add(Me.btnBack)
        Me.erpDetalle.Controls.Add(Me.txtCantidad)
        Me.erpDetalle.Expanded = True
        Me.erpDetalle.FooterStyle.BackgroundStyle.GradientAngle = 0!
        Me.erpDetalle.FooterStyle.FlashStyle.GradientAngle = 0!
        Me.erpDetalle.FooterStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.erpDetalle.FooterStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.erpDetalle.FooterStyle.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.erpDetalle.FooterStyle.TextStyle.ForeColor = System.Drawing.Color.Black
        Me.erpDetalle.HeaderStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.erpDetalle.HeaderStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.erpDetalle.HeaderStyle.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.erpDetalle.HeaderStyle.Height = 24
        Me.erpDetalle.HeaderStyle.TextStyle.ForeColor = System.Drawing.Color.Black
        Me.erpDetalle.HeaderStyle.TextStyle.Text = "AGREGAR ITEMS"
        Me.erpDetalle.Location = New System.Drawing.Point(-1, 0)
        Me.erpDetalle.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.erpDetalle.Name = "erpDetalle"
        Me.erpDetalle.Padding = New System.Windows.Forms.Padding(1, 24, 1, 16)
        Me.erpDetalle.Size = New System.Drawing.Size(784, 425)
        Me.erpDetalle.TabIndex = 31
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BorderStyle.EdgeRadius = 7
        Me.btnLimpiar.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.btnLimpiar.DropDownArrowColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnLimpiar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnLimpiar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnLimpiar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnLimpiar.Location = New System.Drawing.Point(682, 32)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(98, 25)
        Me.btnLimpiar.TabIndex = 77
        Me.btnLimpiar.TextStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnLimpiar.TextStyle.Text = "LIMPIAR"
        Me.btnLimpiar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBuscar
        '
        Me.txtBuscar.CaptionStyle.CaptionSize = 120
        Me.txtBuscar.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.txtBuscar.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtBuscar.CaptionStyle.TextStyle.ForeColor = System.Drawing.Color.Black
        Me.txtBuscar.CaptionStyle.TextStyle.Text = "BUSCAR"
        Me.txtBuscar.EditBoxStyle.BorderStyle.BorderType = Klik.Windows.Forms.v1.Common.BorderTypes.None
        Me.txtBuscar.EditBoxStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBuscar.Location = New System.Drawing.Point(0, 29)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(676, 25)
        Me.txtBuscar.TabIndex = 1
        Me.txtBuscar.ValidationStyle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBuscar.Value = ""
        '
        'dtaGrid
        '
        Me.dtaGrid.AllowUserToAddRows = False
        Me.dtaGrid.AllowUserToDeleteRows = False
        Me.dtaGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.dtaGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtaGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtaGrid.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.dtaGrid.BackgroundStyle.SolidColor = System.Drawing.SystemColors.Window
        Me.dtaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtaGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtaGrid.GridColor = System.Drawing.Color.LightGray
        Me.dtaGrid.Location = New System.Drawing.Point(4, 61)
        Me.dtaGrid.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtaGrid.Name = "dtaGrid"
        Me.dtaGrid.ReadOnly = True
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtaGrid.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dtaGrid.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtaGrid.Size = New System.Drawing.Size(774, 283)
        Me.dtaGrid.TabIndex = 72
        '
        'lblDescripcion
        '
        Me.lblDescripcion.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        PaintStyle1.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        PaintStyle1.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.lblDescripcion.FlashStyle = PaintStyle1
        Me.lblDescripcion.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDescripcion.Location = New System.Drawing.Point(6, 349)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(770, 20)
        Me.lblDescripcion.TabIndex = 70
        Me.lblDescripcion.TabStop = False
        Me.lblDescripcion.TextStyle.ForeColor = System.Drawing.Color.Black
        Me.lblDescripcion.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAdd
        '
        Me.btnAdd.BorderStyle.EdgeRadius = 7
        Me.btnAdd.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.btnAdd.DropDownArrowColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAdd.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnAdd.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnAdd.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAdd.Location = New System.Drawing.Point(452, 377)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(98, 25)
        Me.btnAdd.TabIndex = 68
        Me.btnAdd.TextStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAdd.TextStyle.Text = "AGREGAR"
        Me.btnAdd.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBack
        '
        Me.btnBack.BorderStyle.EdgeRadius = 7
        Me.btnBack.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.btnBack.DropDownArrowColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnBack.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnBack.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnBack.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnBack.Location = New System.Drawing.Point(562, 377)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(98, 25)
        Me.btnBack.TabIndex = 67
        Me.btnBack.TextStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnBack.TextStyle.Text = "VOLVER"
        Me.btnBack.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCantidad
        '
        Me.txtCantidad.CaptionStyle.CaptionSize = 120
        Me.txtCantidad.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.txtCantidad.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtCantidad.CaptionStyle.TextStyle.ForeColor = System.Drawing.Color.Black
        Me.txtCantidad.CaptionStyle.TextStyle.Text = "CANTIDAD"
        Me.txtCantidad.EditBoxStyle.BorderStyle.BorderType = Klik.Windows.Forms.v1.Common.BorderTypes.None
        Me.txtCantidad.EditBoxStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCantidad.Location = New System.Drawing.Point(121, 374)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(205, 25)
        Me.txtCantidad.TabIndex = 1
        Me.txtCantidad.ValidationStyle.MaxLength = 7
        Me.txtCantidad.ValidationStyle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCantidad.ValidationStyle.ValidationType = Klik.Windows.Forms.v1.EntryLib.ValidationTypes.Numeric
        Me.txtCantidad.Value = 0
        '
        'frmAddItemCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 426)
        Me.Controls.Add(Me.erpDetalle)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "frmAddItemCompra"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AGREGAR ITEM COMPRA"
        CType(Me.erpDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.erpDetalle.ResumeLayout(False)
        CType(Me.btnLimpiar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtaGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents erpDetalle As Klik.Windows.Forms.v1.EntryLib.ELRichPanel
    Friend WithEvents btnLimpiar As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents txtBuscar As Klik.Windows.Forms.v1.EntryLib.ELEntryBox
    Friend WithEvents dtaGrid As Klik.Windows.Forms.v1.EntryLib.ELDataGridView
    Friend WithEvents lblDescripcion As Klik.Windows.Forms.v1.EntryLib.ELLabel
    Friend WithEvents btnAdd As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents btnBack As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents txtCantidad As Klik.Windows.Forms.v1.EntryLib.ELEntryBox
End Class
