﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLoadDocEntrada
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim PaintStyle1 As Klik.Windows.Forms.v1.Common.PaintStyle = New Klik.Windows.Forms.v1.Common.PaintStyle()
        Dim ElListBoxSelectionStyles1 As Klik.Windows.Forms.v1.EntryLib.ELListBoxSelectionStyles = New Klik.Windows.Forms.v1.EntryLib.ELListBoxSelectionStyles()
        Dim ElListBoxSelectionStyles2 As Klik.Windows.Forms.v1.EntryLib.ELListBoxSelectionStyles = New Klik.Windows.Forms.v1.EntryLib.ELListBoxSelectionStyles()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoadDocEntrada))
        Me.KFormManager1 = New Klik.Windows.Forms.v1.Common.KFormManager(Me.components)
        Me.erpResultados = New Klik.Windows.Forms.v1.EntryLib.ELRichPanel()
        Me.btnELimina = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.btnAdd = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.dtaGrid = New System.Windows.Forms.DataGridView()
        Me.btnSave = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.btnUndo = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.dtpFecIni = New System.Windows.Forms.DateTimePicker()
        Me.ElLabel1 = New Klik.Windows.Forms.v1.EntryLib.ELLabel()
        Me.erpBusquedas = New Klik.Windows.Forms.v1.EntryLib.ELRichPanel()
        Me.btnAprobar = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.cmbEstado = New Klik.Windows.Forms.v1.EntryLib.ELComboBox()
        Me.txtObservaciones = New Klik.Windows.Forms.v1.EntryLib.ELEntryBox()
        Me.ElDivider2 = New Klik.Windows.Forms.v1.EntryLib.ELDivider()
        Me.btnConsultar = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.ElButton1 = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.btnDel = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.txtRut = New Klik.Windows.Forms.v1.EntryLib.ELEntryBox()
        Me.cmbTipoDoc = New Klik.Windows.Forms.v1.EntryLib.ELComboBox()
        Me.txtCliente = New Klik.Windows.Forms.v1.EntryLib.ELEntryBox()
        Me.txtNumero = New Klik.Windows.Forms.v1.EntryLib.ELEntryBox()
        CType(Me.KFormManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erpResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.erpResultados.SuspendLayout()
        CType(Me.btnELimina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtaGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUndo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erpBusquedas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.erpBusquedas.SuspendLayout()
        CType(Me.btnAprobar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElDivider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTipoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.erpResultados.Controls.Add(Me.btnELimina)
        Me.erpResultados.Controls.Add(Me.btnAdd)
        Me.erpResultados.Controls.Add(Me.dtaGrid)
        Me.erpResultados.Controls.Add(Me.btnSave)
        Me.erpResultados.Controls.Add(Me.btnUndo)
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
        Me.erpResultados.HeaderStyle.TextStyle.Text = "Detallle"
        Me.erpResultados.Location = New System.Drawing.Point(469, 4)
        Me.erpResultados.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.erpResultados.Name = "erpResultados"
        Me.erpResultados.Padding = New System.Windows.Forms.Padding(1, 24, 1, 20)
        Me.erpResultados.Size = New System.Drawing.Size(1008, 528)
        Me.erpResultados.TabIndex = 3
        '
        'btnELimina
        '
        Me.btnELimina.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnELimina.BorderStyle.EdgeRadius = 7
        Me.btnELimina.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.btnELimina.DropDownArrowColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnELimina.Enabled = False
        Me.btnELimina.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnELimina.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnELimina.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnELimina.Location = New System.Drawing.Point(204, 471)
        Me.btnELimina.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnELimina.Name = "btnELimina"
        Me.btnELimina.Size = New System.Drawing.Size(191, 28)
        Me.btnELimina.TabIndex = 11
        Me.btnELimina.TextStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnELimina.TextStyle.Text = "ELIMINAR ITEM"
        Me.btnELimina.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.BorderStyle.EdgeRadius = 7
        Me.btnAdd.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAdd.DropDownArrowColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAdd.Enabled = False
        Me.btnAdd.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnAdd.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnAdd.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAdd.Location = New System.Drawing.Point(5, 471)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(191, 28)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.TextStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAdd.TextStyle.Text = "AGREGAR ITEM"
        Me.btnAdd.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtaGrid
        '
        Me.dtaGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtaGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtaGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtaGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtaGrid.Enabled = False
        Me.dtaGrid.Location = New System.Drawing.Point(5, 24)
        Me.dtaGrid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtaGrid.Name = "dtaGrid"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtaGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtaGrid.RowHeadersWidth = 51
        Me.dtaGrid.Size = New System.Drawing.Size(997, 445)
        Me.dtaGrid.TabIndex = 49
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Enabled = False
        Me.btnSave.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnSave.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnSave.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSave.Location = New System.Drawing.Point(704, 471)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(145, 28)
        Me.btnSave.TabIndex = 12
        Me.btnSave.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.TextStyle.Text = "GRABAR"
        Me.btnSave.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnUndo
        '
        Me.btnUndo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnUndo.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnUndo.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnUndo.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnUndo.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnUndo.Location = New System.Drawing.Point(857, 471)
        Me.btnUndo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(145, 28)
        Me.btnUndo.TabIndex = 13
        Me.btnUndo.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUndo.TextStyle.Text = "LIMPIAR"
        Me.btnUndo.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpFecIni
        '
        Me.dtpFecIni.Enabled = False
        Me.dtpFecIni.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecIni.Location = New System.Drawing.Point(145, 235)
        Me.dtpFecIni.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpFecIni.Name = "dtpFecIni"
        Me.dtpFecIni.ShowCheckBox = True
        Me.dtpFecIni.Size = New System.Drawing.Size(141, 23)
        Me.dtpFecIni.TabIndex = 6
        '
        'ElLabel1
        '
        Me.ElLabel1.Enabled = False
        PaintStyle1.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        PaintStyle1.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElLabel1.FlashStyle = PaintStyle1
        Me.ElLabel1.Location = New System.Drawing.Point(7, 231)
        Me.ElLabel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ElLabel1.Name = "ElLabel1"
        Me.ElLabel1.Size = New System.Drawing.Size(321, 31)
        Me.ElLabel1.TabIndex = 33
        Me.ElLabel1.TabStop = False
        Me.ElLabel1.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ElLabel1.TextStyle.Text = "FECHA"
        '
        'erpBusquedas
        '
        Me.erpBusquedas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.erpBusquedas.ContainerStyle.BackgroundStyle.GradientAngle = 45.0!
        Me.erpBusquedas.Controls.Add(Me.btnAprobar)
        Me.erpBusquedas.Controls.Add(Me.cmbEstado)
        Me.erpBusquedas.Controls.Add(Me.txtObservaciones)
        Me.erpBusquedas.Controls.Add(Me.ElDivider2)
        Me.erpBusquedas.Controls.Add(Me.btnConsultar)
        Me.erpBusquedas.Controls.Add(Me.ElButton1)
        Me.erpBusquedas.Controls.Add(Me.btnDel)
        Me.erpBusquedas.Controls.Add(Me.txtRut)
        Me.erpBusquedas.Controls.Add(Me.cmbTipoDoc)
        Me.erpBusquedas.Controls.Add(Me.dtpFecIni)
        Me.erpBusquedas.Controls.Add(Me.ElLabel1)
        Me.erpBusquedas.Controls.Add(Me.txtCliente)
        Me.erpBusquedas.Controls.Add(Me.txtNumero)
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
        Me.erpBusquedas.HeaderStyle.TextStyle.Text = "Cabecera"
        Me.erpBusquedas.Location = New System.Drawing.Point(1, 4)
        Me.erpBusquedas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.erpBusquedas.Name = "erpBusquedas"
        Me.erpBusquedas.Padding = New System.Windows.Forms.Padding(1, 24, 1, 20)
        Me.erpBusquedas.Size = New System.Drawing.Size(467, 528)
        Me.erpBusquedas.TabIndex = 4
        '
        'btnAprobar
        '
        Me.btnAprobar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAprobar.Enabled = False
        Me.btnAprobar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnAprobar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnAprobar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAprobar.Location = New System.Drawing.Point(312, 427)
        Me.btnAprobar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAprobar.Name = "btnAprobar"
        Me.btnAprobar.Size = New System.Drawing.Size(145, 28)
        Me.btnAprobar.TabIndex = 62
        Me.btnAprobar.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAprobar.TextStyle.Text = "APROBAR"
        Me.btnAprobar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbEstado
        '
        Me.cmbEstado.AutoSize = False
        '
        '
        '
        Me.cmbEstado.ButtonStyle.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstado.CaptionStyle.CaptionSize = 100
        Me.cmbEstado.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.cmbEstado.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.cmbEstado.CaptionStyle.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstado.CaptionStyle.TextStyle.Text = "ESTADO"
        Me.cmbEstado.CheckedDisplaySeparator = Global.Microsoft.VisualBasic.ChrW(44)
        Me.cmbEstado.DropDownBackgroundStyle.GradientAngle = 45.0!
        Me.cmbEstado.DropDownBackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.cmbEstado.DropDownBackgroundStyle.SolidColor = System.Drawing.SystemColors.Window
        Me.cmbEstado.DropDownDescriptionFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ElListBoxSelectionStyles1.HotTrackStyle.BorderStyle.EdgeRadius = 4
        ElListBoxSelectionStyles1.SelectedStyle.BorderStyle.EdgeRadius = 4
        Me.cmbEstado.DropDownItemSelectionStyle = ElListBoxSelectionStyles1
        Me.cmbEstado.DropDownStyle = Klik.Windows.Forms.v1.EntryLib.DropDownStyles.DropDownList
        Me.cmbEstado.EditBoxStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstado.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbEstado.Location = New System.Drawing.Point(7, 300)
        Me.cmbEstado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(321, 28)
        Me.cmbEstado.TabIndex = 60
        '
        'txtObservaciones
        '
        Me.txtObservaciones.AutoSize = False
        Me.txtObservaciones.CaptionStyle.CaptionSize = 100
        Me.txtObservaciones.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.txtObservaciones.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtObservaciones.CaptionStyle.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.CaptionStyle.TextStyle.Text = "OBSERVACIÓN"
        Me.txtObservaciones.EditBoxStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtObservaciones.Enabled = False
        Me.txtObservaciones.Location = New System.Drawing.Point(7, 193)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(451, 31)
        Me.txtObservaciones.TabIndex = 5
        Me.txtObservaciones.ValidationStyle.MaxLength = 500
        Me.txtObservaciones.ValidationStyle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtObservaciones.Value = ""
        '
        'ElDivider2
        '
        Me.ElDivider2.LineSize = 3
        Me.ElDivider2.Location = New System.Drawing.Point(5, 266)
        Me.ElDivider2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ElDivider2.Name = "ElDivider2"
        Me.ElDivider2.Size = New System.Drawing.Size(471, 28)
        Me.ElDivider2.TabIndex = 51
        '
        'btnConsultar
        '
        Me.btnConsultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConsultar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnConsultar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnConsultar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnConsultar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnConsultar.Location = New System.Drawing.Point(7, 427)
        Me.btnConsultar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(145, 28)
        Me.btnConsultar.TabIndex = 7
        Me.btnConsultar.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.TextStyle.Text = "VER DOCS"
        Me.btnConsultar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ElButton1
        '
        Me.ElButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ElButton1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ElButton1.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElButton1.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElButton1.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElButton1.Location = New System.Drawing.Point(312, 470)
        Me.ElButton1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ElButton1.Name = "ElButton1"
        Me.ElButton1.Size = New System.Drawing.Size(145, 28)
        Me.ElButton1.TabIndex = 9
        Me.ElButton1.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ElButton1.TextStyle.Text = "VOLVER"
        Me.ElButton1.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDel
        '
        Me.btnDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDel.Enabled = False
        Me.btnDel.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnDel.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnDel.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnDel.Location = New System.Drawing.Point(7, 470)
        Me.btnDel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(145, 28)
        Me.btnDel.TabIndex = 8
        Me.btnDel.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.TextStyle.Text = "ELIMINAR"
        Me.btnDel.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnDel.Visible = False
        '
        'txtRut
        '
        Me.txtRut.AutoSize = False
        Me.txtRut.CaptionStyle.CaptionSize = 100
        Me.txtRut.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.txtRut.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtRut.CaptionStyle.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRut.CaptionStyle.TextStyle.Text = "RUT  PROV"
        Me.txtRut.EditBoxStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRut.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtRut.Enabled = False
        Me.txtRut.Location = New System.Drawing.Point(7, 118)
        Me.txtRut.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(321, 31)
        Me.txtRut.TabIndex = 3
        Me.txtRut.ValidationStyle.MaxLength = 15
        Me.txtRut.ValidationStyle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRut.Value = ""
        '
        'cmbTipoDoc
        '
        Me.cmbTipoDoc.AutoSize = False
        '
        '
        '
        Me.cmbTipoDoc.ButtonStyle.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoDoc.CaptionStyle.CaptionSize = 100
        Me.cmbTipoDoc.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.cmbTipoDoc.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.cmbTipoDoc.CaptionStyle.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoDoc.CaptionStyle.TextStyle.Text = "TIPO DOC"
        Me.cmbTipoDoc.CheckedDisplaySeparator = Global.Microsoft.VisualBasic.ChrW(44)
        Me.cmbTipoDoc.DropDownBackgroundStyle.GradientAngle = 45.0!
        Me.cmbTipoDoc.DropDownBackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.cmbTipoDoc.DropDownBackgroundStyle.SolidColor = System.Drawing.SystemColors.Window
        Me.cmbTipoDoc.DropDownDescriptionFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ElListBoxSelectionStyles2.HotTrackStyle.BorderStyle.EdgeRadius = 4
        ElListBoxSelectionStyles2.SelectedStyle.BorderStyle.EdgeRadius = 4
        Me.cmbTipoDoc.DropDownItemSelectionStyle = ElListBoxSelectionStyles2
        Me.cmbTipoDoc.DropDownStyle = Klik.Windows.Forms.v1.EntryLib.DropDownStyles.DropDownList
        Me.cmbTipoDoc.EditBoxStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoDoc.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTipoDoc.Location = New System.Drawing.Point(7, 42)
        Me.cmbTipoDoc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbTipoDoc.Name = "cmbTipoDoc"
        Me.cmbTipoDoc.Size = New System.Drawing.Size(321, 31)
        Me.cmbTipoDoc.TabIndex = 1
        '
        'txtCliente
        '
        Me.txtCliente.AutoSize = False
        Me.txtCliente.CaptionStyle.CaptionSize = 100
        Me.txtCliente.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.txtCliente.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtCliente.CaptionStyle.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.CaptionStyle.TextStyle.Text = "PROVEEDOR"
        Me.txtCliente.EditBoxStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCliente.Enabled = False
        Me.txtCliente.Location = New System.Drawing.Point(7, 155)
        Me.txtCliente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(451, 31)
        Me.txtCliente.TabIndex = 4
        Me.txtCliente.ValidationStyle.MaxLength = 50
        Me.txtCliente.ValidationStyle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCliente.Value = ""
        '
        'txtNumero
        '
        Me.txtNumero.AutoSize = False
        Me.txtNumero.CaptionStyle.CaptionSize = 100
        Me.txtNumero.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.txtNumero.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtNumero.CaptionStyle.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.CaptionStyle.TextStyle.Text = "NUMERO DOC"
        Me.txtNumero.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtNumero.EditBoxStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNumero.Location = New System.Drawing.Point(5, 80)
        Me.txtNumero.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(323, 31)
        Me.txtNumero.TabIndex = 2
        Me.txtNumero.ValidationStyle.MaxLength = 15
        Me.txtNumero.ValidationStyle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumero.Value = ""
        '
        'frmLoadDocEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1475, 533)
        Me.Controls.Add(Me.erpBusquedas)
        Me.Controls.Add(Me.erpResultados)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmLoadDocEntrada"
        Me.ShowInTaskbar = False
        Me.Text = "Documentos de Entrada"
        CType(Me.KFormManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erpResultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.erpResultados.ResumeLayout(False)
        CType(Me.btnELimina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtaGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUndo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erpBusquedas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.erpBusquedas.ResumeLayout(False)
        CType(Me.btnAprobar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElDivider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTipoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KFormManager1 As Klik.Windows.Forms.v1.Common.KFormManager
    Friend WithEvents erpResultados As Klik.Windows.Forms.v1.EntryLib.ELRichPanel
    Friend WithEvents erpBusquedas As Klik.Windows.Forms.v1.EntryLib.ELRichPanel
    Friend WithEvents dtpFecIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents ElLabel1 As Klik.Windows.Forms.v1.EntryLib.ELLabel
    Friend WithEvents txtCliente As Klik.Windows.Forms.v1.EntryLib.ELEntryBox
    Friend WithEvents txtNumero As Klik.Windows.Forms.v1.EntryLib.ELEntryBox
    Friend WithEvents cmbTipoDoc As Klik.Windows.Forms.v1.EntryLib.ELComboBox
    Friend WithEvents txtRut As Klik.Windows.Forms.v1.EntryLib.ELEntryBox
    Friend WithEvents ElButton1 As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents btnUndo As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents btnSave As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents btnDel As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents dtaGrid As System.Windows.Forms.DataGridView
    Friend WithEvents ElDivider2 As Klik.Windows.Forms.v1.EntryLib.ELDivider
    Friend WithEvents btnConsultar As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents btnELimina As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents btnAdd As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents txtObservaciones As Klik.Windows.Forms.v1.EntryLib.ELEntryBox
    Friend WithEvents cmbEstado As Klik.Windows.Forms.v1.EntryLib.ELComboBox
    Friend WithEvents btnAprobar As Klik.Windows.Forms.v1.EntryLib.ELButton
End Class
