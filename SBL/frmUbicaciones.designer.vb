<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUbicaciones
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
        Dim ElListBoxSELECTionStyles4 As Klik.Windows.Forms.v1.EntryLib.ELListBoxSelectionStyles = New Klik.Windows.Forms.v1.EntryLib.ELListBoxSelectionStyles()
        Dim PaintStyle1 As Klik.Windows.Forms.v1.Common.PaintStyle = New Klik.Windows.Forms.v1.Common.PaintStyle()
        Dim PaintStyle2 As Klik.Windows.Forms.v1.Common.PaintStyle = New Klik.Windows.Forms.v1.Common.PaintStyle()
        Dim PaintStyle3 As Klik.Windows.Forms.v1.Common.PaintStyle = New Klik.Windows.Forms.v1.Common.PaintStyle()
        Dim ElListBoxSELECTionStyles5 As Klik.Windows.Forms.v1.EntryLib.ELListBoxSelectionStyles = New Klik.Windows.Forms.v1.EntryLib.ELListBoxSelectionStyles()
        Dim ElListBoxSELECTionStyles6 As Klik.Windows.Forms.v1.EntryLib.ELListBoxSelectionStyles = New Klik.Windows.Forms.v1.EntryLib.ELListBoxSelectionStyles()
        Dim ElListBoxSELECTionStyles1 As Klik.Windows.Forms.v1.EntryLib.ELListBoxSelectionStyles = New Klik.Windows.Forms.v1.EntryLib.ELListBoxSelectionStyles()
        Dim ElListBoxSELECTionStyles2 As Klik.Windows.Forms.v1.EntryLib.ELListBoxSelectionStyles = New Klik.Windows.Forms.v1.EntryLib.ELListBoxSelectionStyles()
        Dim ElListBoxSELECTionStyles3 As Klik.Windows.Forms.v1.EntryLib.ELListBoxSelectionStyles = New Klik.Windows.Forms.v1.EntryLib.ELListBoxSelectionStyles()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUbicaciones))
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.KFormManager1 = New Klik.Windows.Forms.v1.Common.KFormManager(Me.components)
        Me.erpEdicion = New Klik.Windows.Forms.v1.EntryLib.ELRichPanel()
        Me.ElTab1 = New Klik.Windows.Forms.v1.EntryLib.ELTab()
        Me.ElTabPage3 = New Klik.Windows.Forms.v1.EntryLib.ELTabPage()
        Me.btnGrabar = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.cmbEstado = New Klik.Windows.Forms.v1.EntryLib.ELComboBox()
        Me.txtDescripcion = New Klik.Windows.Forms.v1.EntryLib.ELEntryBox()
        Me.txtNivel = New Klik.Windows.Forms.v1.EntryLib.ELEntryBox()
        Me.txtColumna = New Klik.Windows.Forms.v1.EntryLib.ELEntryBox()
        Me.txtHilera = New Klik.Windows.Forms.v1.EntryLib.ELEntryBox()
        Me.ElTabPage4 = New Klik.Windows.Forms.v1.EntryLib.ELTabPage()
        Me.upHilera2 = New System.Windows.Forms.NumericUpDown()
        Me.upNiveles2 = New System.Windows.Forms.NumericUpDown()
        Me.upColumnas2 = New System.Windows.Forms.NumericUpDown()
        Me.upHilera1 = New System.Windows.Forms.NumericUpDown()
        Me.ElLabel1 = New Klik.Windows.Forms.v1.EntryLib.ELLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGrabarC = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.btnLimiarC = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.upNiveles1 = New System.Windows.Forms.NumericUpDown()
        Me.ElLabel4 = New Klik.Windows.Forms.v1.EntryLib.ELLabel()
        Me.upColumnas1 = New System.Windows.Forms.NumericUpDown()
        Me.ElLabel3 = New Klik.Windows.Forms.v1.EntryLib.ELLabel()
        Me.ElTabPage1 = New Klik.Windows.Forms.v1.EntryLib.ELTabPage()
        Me.cmbTama = New Klik.Windows.Forms.v1.EntryLib.ELComboBox()
        Me.cmbPrinter = New Klik.Windows.Forms.v1.EntryLib.ELComboBox()
        Me.txtCantidad = New Klik.Windows.Forms.v1.EntryLib.ELEntryBox()
        Me.btnImprimir = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.btnBack = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.btnLimpia = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.btnEliminar = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.erpBusquedas = New Klik.Windows.Forms.v1.EntryLib.ELRichPanel()
        Me.cmbColumnas = New Klik.Windows.Forms.v1.EntryLib.ELComboBox()
        Me.cmbHileras = New Klik.Windows.Forms.v1.EntryLib.ELComboBox()
        Me.cmbBodegas = New Klik.Windows.Forms.v1.EntryLib.ELComboBox()
        Me.dtaGrid = New Klik.Windows.Forms.v1.EntryLib.ELDataGridView()
        Me.tmrMensaje = New System.Windows.Forms.Timer(Me.components)
        CType(Me.KFormManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erpEdicion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.erpEdicion.SuspendLayout()
        CType(Me.ElTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElTab1.SuspendLayout()
        CType(Me.ElTabPage3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElTabPage3.SuspendLayout()
        CType(Me.btnGrabar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNivel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtColumna, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHilera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElTabPage4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElTabPage4.SuspendLayout()
        CType(Me.upHilera2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.upNiveles2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.upColumnas2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.upHilera1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGrabarC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLimiarC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.upNiveles1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.upColumnas1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElTabPage1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElTabPage1.SuspendLayout()
        CType(Me.cmbTama, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPrinter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnImprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLimpia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erpBusquedas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.erpBusquedas.SuspendLayout()
        CType(Me.cmbColumnas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbHileras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbBodegas, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.erpEdicion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.erpEdicion.ContainerStyle.BackgroundStyle.GradientAngle = 45.0!
        Me.erpEdicion.ContainerStyle.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.erpEdicion.Controls.Add(Me.ElTab1)
        Me.erpEdicion.Controls.Add(Me.btnBack)
        Me.erpEdicion.Controls.Add(Me.btnLimpia)
        Me.erpEdicion.Controls.Add(Me.btnEliminar)
        Me.erpEdicion.Expanded = True
        Me.erpEdicion.FooterStyle.BackgroundStyle.GradientAngle = 0!
        Me.erpEdicion.FooterStyle.FlashStyle.GradientAngle = 0!
        Me.erpEdicion.FooterStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.erpEdicion.FooterStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.erpEdicion.FooterStyle.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.erpEdicion.FooterStyle.TextStyle.ForeColor = System.Drawing.Color.Black
        Me.erpEdicion.HeaderStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.erpEdicion.HeaderStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.erpEdicion.HeaderStyle.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.erpEdicion.HeaderStyle.Height = 24
        Me.erpEdicion.HeaderStyle.TextStyle.ForeColor = System.Drawing.Color.Black
        Me.erpEdicion.HeaderStyle.TextStyle.Text = "EDICION"
        Me.erpEdicion.Location = New System.Drawing.Point(528, 8)
        Me.erpEdicion.Name = "erpEdicion"
        Me.erpEdicion.Padding = New System.Windows.Forms.Padding(1, 24, 1, 16)
        Me.erpEdicion.Size = New System.Drawing.Size(471, 439)
        Me.erpEdicion.TabIndex = 95
        '
        'ElTab1
        '
        Me.ElTab1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ElTab1.Location = New System.Drawing.Point(11, 62)
        Me.ElTab1.Name = "ElTab1"
        Me.ElTab1.Size = New System.Drawing.Size(455, 358)
        Me.ElTab1.TabCaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElTab1.TabCaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElTab1.TabCaptionStyle.StateStyles.FocusStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElTab1.TabCaptionStyle.StateStyles.FocusStyle.BackgroundSolidColor = System.Drawing.SystemColors.ActiveCaption
        Me.ElTab1.TabIndex = 95
        Me.ElTab1.TabPages.Add(Me.ElTabPage3)
        Me.ElTab1.TabPages.Add(Me.ElTabPage4)
        Me.ElTab1.TabPages.Add(Me.ElTabPage1)
        '
        'ElTabPage3
        '
        Me.ElTabPage3.BackgroundStyle.GradientAngle = 45.0!
        Me.ElTabPage3.CaptionImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ElTabPage3.CaptionTextStyle.ForeColor = System.Drawing.Color.Black
        Me.ElTabPage3.CaptionTextStyle.Text = "Mantención"
        Me.ElTabPage3.Controls.Add(Me.btnGrabar)
        Me.ElTabPage3.Controls.Add(Me.cmbEstado)
        Me.ElTabPage3.Controls.Add(Me.txtDescripcion)
        Me.ElTabPage3.Controls.Add(Me.txtNivel)
        Me.ElTabPage3.Controls.Add(Me.txtColumna)
        Me.ElTabPage3.Controls.Add(Me.txtHilera)
        Me.ElTabPage3.Location = New System.Drawing.Point(1, 23)
        Me.ElTabPage3.Name = "ElTabPage3"
        Me.ElTabPage3.Size = New System.Drawing.Size(453, 334)
        '
        'btnGrabar
        '
        Me.btnGrabar.BorderStyle.EdgeRadius = 7
        Me.btnGrabar.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.btnGrabar.DropDownArrowColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGrabar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnGrabar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnGrabar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnGrabar.Location = New System.Drawing.Point(59, 189)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(199, 25)
        Me.btnGrabar.TabIndex = 54
        Me.btnGrabar.TextStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGrabar.TextStyle.Text = "Grabar"
        Me.btnGrabar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbEstado
        '
        Me.cmbEstado.AutoSize = False
        '
        '
        '
        Me.cmbEstado.ButtonStyle.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstado.CaptionStyle.CaptionSize = 90
        Me.cmbEstado.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.cmbEstado.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.cmbEstado.CaptionStyle.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstado.CaptionStyle.TextStyle.Text = "Estado"
        Me.cmbEstado.CheckedDisplaySeparator = Global.Microsoft.VisualBasic.ChrW(44)
        Me.cmbEstado.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbEstado.DropDownBackgroundStyle.GradientAngle = 45.0!
        Me.cmbEstado.DropDownBackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.cmbEstado.DropDownBackgroundStyle.SolidColor = System.Drawing.SystemColors.Window
        Me.cmbEstado.DropDownDescriptionFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ElListBoxSELECTionStyles4.HotTrackStyle.BorderStyle.EdgeRadius = 4
        ElListBoxSELECTionStyles4.SelectedStyle.BorderStyle.EdgeRadius = 4
        Me.cmbEstado.DropDownItemSelectionStyle = ElListBoxSELECTionStyles4
        Me.cmbEstado.DropDownStyle = Klik.Windows.Forms.v1.EntryLib.DropDownStyles.DropDownList
        Me.cmbEstado.EditBoxStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstado.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbEstado.Enabled = False
        Me.cmbEstado.Location = New System.Drawing.Point(13, 150)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(245, 28)
        Me.cmbEstado.TabIndex = 53
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CaptionStyle.CaptionSize = 90
        Me.txtDescripcion.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.txtDescripcion.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtDescripcion.CaptionStyle.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.CaptionStyle.TextStyle.Text = "Descripción"
        Me.txtDescripcion.EditBoxStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(13, 116)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(430, 28)
        Me.txtDescripcion.TabIndex = 10
        Me.txtDescripcion.ValidationStyle.MaxLength = 50
        Me.txtDescripcion.ValidationStyle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcion.Value = ""
        '
        'txtNivel
        '
        Me.txtNivel.AutoSize = False
        Me.txtNivel.CaptionStyle.CaptionSize = 90
        Me.txtNivel.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.txtNivel.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtNivel.CaptionStyle.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNivel.CaptionStyle.TextStyle.Text = "Nivel"
        Me.txtNivel.EditBoxStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNivel.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNivel.Enabled = False
        Me.txtNivel.Location = New System.Drawing.Point(13, 82)
        Me.txtNivel.Name = "txtNivel"
        Me.txtNivel.Size = New System.Drawing.Size(245, 28)
        Me.txtNivel.TabIndex = 9
        Me.txtNivel.ValidationStyle.MaxLength = 3
        Me.txtNivel.ValidationStyle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNivel.Value = ""
        '
        'txtColumna
        '
        Me.txtColumna.AutoSize = False
        Me.txtColumna.CaptionStyle.CaptionSize = 90
        Me.txtColumna.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.txtColumna.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtColumna.CaptionStyle.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColumna.CaptionStyle.TextStyle.Text = "Columna"
        Me.txtColumna.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtColumna.EditBoxStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColumna.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtColumna.Enabled = False
        Me.txtColumna.Location = New System.Drawing.Point(13, 48)
        Me.txtColumna.Name = "txtColumna"
        Me.txtColumna.Size = New System.Drawing.Size(245, 28)
        Me.txtColumna.TabIndex = 8
        Me.txtColumna.ValidationStyle.MaxLength = 3
        Me.txtColumna.ValidationStyle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtColumna.Value = ""
        '
        'txtHilera
        '
        Me.txtHilera.AutoSize = False
        Me.txtHilera.CaptionStyle.CaptionSize = 90
        Me.txtHilera.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.txtHilera.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtHilera.CaptionStyle.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHilera.CaptionStyle.TextStyle.Text = "Hilera"
        Me.txtHilera.EditBoxStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHilera.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHilera.Enabled = False
        Me.txtHilera.Location = New System.Drawing.Point(13, 14)
        Me.txtHilera.Name = "txtHilera"
        Me.txtHilera.Size = New System.Drawing.Size(245, 28)
        Me.txtHilera.TabIndex = 7
        Me.txtHilera.ValidationStyle.MaxLength = 3
        Me.txtHilera.ValidationStyle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtHilera.Value = ""
        '
        'ElTabPage4
        '
        Me.ElTabPage4.BackgroundStyle.GradientAngle = 45.0!
        Me.ElTabPage4.CaptionImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ElTabPage4.CaptionTextStyle.ForeColor = System.Drawing.Color.Black
        Me.ElTabPage4.CaptionTextStyle.Text = "Crear"
        Me.ElTabPage4.Controls.Add(Me.upHilera2)
        Me.ElTabPage4.Controls.Add(Me.upNiveles2)
        Me.ElTabPage4.Controls.Add(Me.upColumnas2)
        Me.ElTabPage4.Controls.Add(Me.upHilera1)
        Me.ElTabPage4.Controls.Add(Me.ElLabel1)
        Me.ElTabPage4.Controls.Add(Me.Label2)
        Me.ElTabPage4.Controls.Add(Me.Label1)
        Me.ElTabPage4.Controls.Add(Me.btnGrabarC)
        Me.ElTabPage4.Controls.Add(Me.btnLimiarC)
        Me.ElTabPage4.Controls.Add(Me.upNiveles1)
        Me.ElTabPage4.Controls.Add(Me.ElLabel4)
        Me.ElTabPage4.Controls.Add(Me.upColumnas1)
        Me.ElTabPage4.Controls.Add(Me.ElLabel3)
        Me.ElTabPage4.Location = New System.Drawing.Point(1, 23)
        Me.ElTabPage4.Name = "ElTabPage4"
        Me.ElTabPage4.Size = New System.Drawing.Size(453, 334)
        '
        'upHilera2
        '
        Me.upHilera2.Location = New System.Drawing.Point(212, 47)
        Me.upHilera2.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.upHilera2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.upHilera2.Name = "upHilera2"
        Me.upHilera2.Size = New System.Drawing.Size(66, 23)
        Me.upHilera2.TabIndex = 40
        Me.upHilera2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'upNiveles2
        '
        Me.upNiveles2.Location = New System.Drawing.Point(211, 119)
        Me.upNiveles2.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.upNiveles2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.upNiveles2.Name = "upNiveles2"
        Me.upNiveles2.Size = New System.Drawing.Size(66, 23)
        Me.upNiveles2.TabIndex = 39
        Me.upNiveles2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'upColumnas2
        '
        Me.upColumnas2.Location = New System.Drawing.Point(212, 84)
        Me.upColumnas2.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.upColumnas2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.upColumnas2.Name = "upColumnas2"
        Me.upColumnas2.Size = New System.Drawing.Size(66, 23)
        Me.upColumnas2.TabIndex = 38
        Me.upColumnas2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'upHilera1
        '
        Me.upHilera1.Location = New System.Drawing.Point(102, 47)
        Me.upHilera1.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.upHilera1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.upHilera1.Name = "upHilera1"
        Me.upHilera1.Size = New System.Drawing.Size(66, 23)
        Me.upHilera1.TabIndex = 37
        Me.upHilera1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ElLabel1
        '
        Me.ElLabel1.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        PaintStyle1.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        PaintStyle1.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElLabel1.FlashStyle = PaintStyle1
        Me.ElLabel1.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ElLabel1.Location = New System.Drawing.Point(8, 44)
        Me.ElLabel1.Name = "ElLabel1"
        Me.ElLabel1.Size = New System.Drawing.Size(280, 24)
        Me.ElLabel1.TabIndex = 36
        Me.ElLabel1.TabStop = False
        Me.ElLabel1.TextStyle.ForeColor = System.Drawing.Color.Black
        Me.ElLabel1.TextStyle.Text = "Hilera"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(224, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Final"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(106, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Inicial"
        '
        'btnGrabarC
        '
        Me.btnGrabarC.BorderStyle.EdgeRadius = 7
        Me.btnGrabarC.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.btnGrabarC.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnGrabarC.DropDownArrowColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGrabarC.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnGrabarC.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnGrabarC.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnGrabarC.Location = New System.Drawing.Point(10, 172)
        Me.btnGrabarC.Name = "btnGrabarC"
        Me.btnGrabarC.Size = New System.Drawing.Size(80, 25)
        Me.btnGrabarC.TabIndex = 32
        Me.btnGrabarC.TextStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGrabarC.TextStyle.Text = "Grabar"
        Me.btnGrabarC.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLimiarC
        '
        Me.btnLimiarC.BorderStyle.EdgeRadius = 7
        Me.btnLimiarC.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.btnLimiarC.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnLimiarC.DropDownArrowColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnLimiarC.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnLimiarC.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnLimiarC.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnLimiarC.Location = New System.Drawing.Point(208, 172)
        Me.btnLimiarC.Name = "btnLimiarC"
        Me.btnLimiarC.Size = New System.Drawing.Size(80, 25)
        Me.btnLimiarC.TabIndex = 31
        Me.btnLimiarC.TextStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnLimiarC.TextStyle.Text = "Limpiar"
        Me.btnLimiarC.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'upNiveles1
        '
        Me.upNiveles1.Location = New System.Drawing.Point(101, 119)
        Me.upNiveles1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.upNiveles1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.upNiveles1.Name = "upNiveles1"
        Me.upNiveles1.Size = New System.Drawing.Size(66, 23)
        Me.upNiveles1.TabIndex = 30
        Me.upNiveles1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ElLabel4
        '
        Me.ElLabel4.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        PaintStyle2.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        PaintStyle2.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElLabel4.FlashStyle = PaintStyle2
        Me.ElLabel4.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ElLabel4.Location = New System.Drawing.Point(8, 116)
        Me.ElLabel4.Name = "ElLabel4"
        Me.ElLabel4.Size = New System.Drawing.Size(280, 24)
        Me.ElLabel4.TabIndex = 29
        Me.ElLabel4.TabStop = False
        Me.ElLabel4.TextStyle.ForeColor = System.Drawing.Color.Black
        Me.ElLabel4.TextStyle.Text = "Nivel"
        '
        'upColumnas1
        '
        Me.upColumnas1.Location = New System.Drawing.Point(102, 84)
        Me.upColumnas1.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.upColumnas1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.upColumnas1.Name = "upColumnas1"
        Me.upColumnas1.Size = New System.Drawing.Size(66, 23)
        Me.upColumnas1.TabIndex = 28
        Me.upColumnas1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ElLabel3
        '
        Me.ElLabel3.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        PaintStyle3.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        PaintStyle3.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElLabel3.FlashStyle = PaintStyle3
        Me.ElLabel3.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ElLabel3.Location = New System.Drawing.Point(8, 81)
        Me.ElLabel3.Name = "ElLabel3"
        Me.ElLabel3.Size = New System.Drawing.Size(280, 24)
        Me.ElLabel3.TabIndex = 27
        Me.ElLabel3.TabStop = False
        Me.ElLabel3.TextStyle.ForeColor = System.Drawing.Color.Black
        Me.ElLabel3.TextStyle.Text = "Columna"
        '
        'ElTabPage1
        '
        Me.ElTabPage1.BackgroundStyle.GradientAngle = 45.0!
        Me.ElTabPage1.CaptionImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ElTabPage1.CaptionTextStyle.Text = "Imprimir"
        Me.ElTabPage1.Controls.Add(Me.cmbTama)
        Me.ElTabPage1.Controls.Add(Me.cmbPrinter)
        Me.ElTabPage1.Controls.Add(Me.txtCantidad)
        Me.ElTabPage1.Controls.Add(Me.btnImprimir)
        Me.ElTabPage1.Location = New System.Drawing.Point(1, 23)
        Me.ElTabPage1.Name = "ElTabPage1"
        Me.ElTabPage1.Size = New System.Drawing.Size(453, 334)
        '
        'cmbTama
        '
        '
        '
        '
        Me.cmbTama.ButtonStyle.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTama.CaptionStyle.CaptionSize = 120
        Me.cmbTama.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.cmbTama.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.cmbTama.CaptionStyle.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTama.CaptionStyle.TextStyle.Text = "Tamaño de Etiqueta"
        Me.cmbTama.CheckedDisplaySeparator = Global.Microsoft.VisualBasic.ChrW(44)
        Me.cmbTama.DropDownBackgroundStyle.GradientAngle = 45.0!
        Me.cmbTama.DropDownBackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.cmbTama.DropDownBackgroundStyle.SolidColor = System.Drawing.SystemColors.Window
        Me.cmbTama.DropDownDescriptionFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ElListBoxSELECTionStyles5.HotTrackStyle.BorderStyle.EdgeRadius = 4
        ElListBoxSELECTionStyles5.SelectedStyle.BorderStyle.EdgeRadius = 4
        Me.cmbTama.DropDownItemSelectionStyle = ElListBoxSELECTionStyles5
        Me.cmbTama.DropDownStyle = Klik.Windows.Forms.v1.EntryLib.DropDownStyles.DropDownList
        Me.cmbTama.EditBoxStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTama.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTama.Location = New System.Drawing.Point(10, 47)
        Me.cmbTama.Name = "cmbTama"
        Me.cmbTama.Size = New System.Drawing.Size(333, 28)
        Me.cmbTama.TabIndex = 53
        '
        'cmbPrinter
        '
        Me.cmbPrinter.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.cmbPrinter.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.cmbPrinter.CaptionStyle.TextStyle.ForeColor = System.Drawing.Color.Black
        Me.cmbPrinter.CaptionStyle.TextStyle.Text = "Impresora"
        Me.cmbPrinter.CheckedDisplaySeparator = Global.Microsoft.VisualBasic.ChrW(44)
        Me.cmbPrinter.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbPrinter.DropDownBackgroundStyle.GradientAngle = 45.0!
        Me.cmbPrinter.DropDownBackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.cmbPrinter.DropDownBackgroundStyle.SolidColor = System.Drawing.SystemColors.Window
        Me.cmbPrinter.DropDownBorderColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        ElListBoxSELECTionStyles6.HotTrackStyle.BorderStyle.EdgeRadius = 4
        ElListBoxSELECTionStyles6.SelectedStyle.BorderStyle.EdgeRadius = 4
        Me.cmbPrinter.DropDownItemSelectionStyle = ElListBoxSELECTionStyles6
        Me.cmbPrinter.DropDownStyle = Klik.Windows.Forms.v1.EntryLib.DropDownStyles.DropDownList
        Me.cmbPrinter.EditBoxStyle.BorderStyle.BorderType = Klik.Windows.Forms.v1.Common.BorderTypes.None
        Me.cmbPrinter.EditBoxStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPrinter.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbPrinter.Location = New System.Drawing.Point(9, 13)
        Me.cmbPrinter.Name = "cmbPrinter"
        Me.cmbPrinter.Size = New System.Drawing.Size(334, 28)
        Me.cmbPrinter.TabIndex = 35
        '
        'txtCantidad
        '
        Me.txtCantidad.CaptionStyle.CaptionSize = 110
        Me.txtCantidad.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.txtCantidad.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtCantidad.CaptionStyle.TextStyle.ForeColor = System.Drawing.Color.Black
        Me.txtCantidad.CaptionStyle.TextStyle.Text = "Copias a Imprimir"
        Me.txtCantidad.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtCantidad.EditBoxStyle.BorderStyle.BorderType = Klik.Windows.Forms.v1.Common.BorderTypes.None
        Me.txtCantidad.EditBoxStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCantidad.Location = New System.Drawing.Point(9, 82)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(181, 28)
        Me.txtCantidad.TabIndex = 34
        Me.txtCantidad.ValidationStyle.MaxLength = 20
        Me.txtCantidad.ValidationStyle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCantidad.Value = ""
        '
        'btnImprimir
        '
        Me.btnImprimir.BorderStyle.EdgeRadius = 7
        Me.btnImprimir.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnImprimir.DropDownArrowColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnImprimir.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnImprimir.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnImprimir.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnImprimir.Location = New System.Drawing.Point(263, 82)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(80, 25)
        Me.btnImprimir.TabIndex = 33
        Me.btnImprimir.TextStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnImprimir.TextStyle.Text = "IMPRIMIR"
        Me.btnImprimir.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBack
        '
        Me.btnBack.BorderStyle.EdgeRadius = 7
        Me.btnBack.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.btnBack.DropDownArrowColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnBack.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnBack.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnBack.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnBack.Location = New System.Drawing.Point(190, 28)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(80, 25)
        Me.btnBack.TabIndex = 7
        Me.btnBack.TextStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnBack.TextStyle.Text = "Salir"
        Me.btnBack.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLimpia
        '
        Me.btnLimpia.BorderStyle.EdgeRadius = 7
        Me.btnLimpia.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.btnLimpia.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnLimpia.DropDownArrowColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnLimpia.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnLimpia.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnLimpia.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnLimpia.Location = New System.Drawing.Point(11, 28)
        Me.btnLimpia.Name = "btnLimpia"
        Me.btnLimpia.Size = New System.Drawing.Size(80, 25)
        Me.btnLimpia.TabIndex = 5
        Me.btnLimpia.TextStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnLimpia.TextStyle.Text = "Limpiar"
        Me.btnLimpia.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEliminar
        '
        Me.btnEliminar.BorderStyle.EdgeRadius = 7
        Me.btnEliminar.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnEliminar.DropDownArrowColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEliminar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnEliminar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnEliminar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnEliminar.Location = New System.Drawing.Point(100, 27)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(80, 25)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.TextStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEliminar.TextStyle.Text = "Eliminar"
        Me.btnEliminar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'erpBusquedas
        '
        Me.erpBusquedas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.erpBusquedas.ContainerStyle.BackgroundStyle.GradientAngle = 45.0!
        Me.erpBusquedas.ContainerStyle.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.erpBusquedas.Controls.Add(Me.cmbColumnas)
        Me.erpBusquedas.Controls.Add(Me.cmbHileras)
        Me.erpBusquedas.Controls.Add(Me.cmbBodegas)
        Me.erpBusquedas.Controls.Add(Me.dtaGrid)
        Me.erpBusquedas.Expanded = True
        Me.erpBusquedas.FooterStyle.BackgroundStyle.GradientAngle = 0!
        Me.erpBusquedas.FooterStyle.FlashStyle.GradientAngle = 0!
        Me.erpBusquedas.FooterStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.erpBusquedas.FooterStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.erpBusquedas.FooterStyle.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.erpBusquedas.FooterStyle.TextStyle.ForeColor = System.Drawing.Color.Black
        Me.erpBusquedas.HeaderStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.erpBusquedas.HeaderStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.erpBusquedas.HeaderStyle.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.erpBusquedas.HeaderStyle.Height = 24
        Me.erpBusquedas.HeaderStyle.TextStyle.ForeColor = System.Drawing.Color.Black
        Me.erpBusquedas.HeaderStyle.TextStyle.Text = "BUSQUEDAS"
        Me.erpBusquedas.Location = New System.Drawing.Point(3, 8)
        Me.erpBusquedas.Name = "erpBusquedas"
        Me.erpBusquedas.Padding = New System.Windows.Forms.Padding(1, 24, 1, 16)
        Me.erpBusquedas.Size = New System.Drawing.Size(519, 439)
        Me.erpBusquedas.TabIndex = 96
        '
        'cmbColumnas
        '
        Me.cmbColumnas.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.cmbColumnas.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.cmbColumnas.CaptionStyle.TextStyle.ForeColor = System.Drawing.Color.Black
        Me.cmbColumnas.CaptionStyle.TextStyle.Text = "Columnas"
        Me.cmbColumnas.CheckedDisplaySeparator = Global.Microsoft.VisualBasic.ChrW(44)
        Me.cmbColumnas.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbColumnas.DropDownBackgroundStyle.GradientAngle = 45.0!
        Me.cmbColumnas.DropDownBackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.cmbColumnas.DropDownBackgroundStyle.SolidColor = System.Drawing.SystemColors.Window
        Me.cmbColumnas.DropDownBorderColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        ElListBoxSELECTionStyles1.HotTrackStyle.BorderStyle.EdgeRadius = 4
        ElListBoxSELECTionStyles1.SelectedStyle.BorderStyle.EdgeRadius = 4
        Me.cmbColumnas.DropDownItemSelectionStyle = ElListBoxSELECTionStyles1
        Me.cmbColumnas.DropDownStyle = Klik.Windows.Forms.v1.EntryLib.DropDownStyles.DropDownList
        Me.cmbColumnas.EditBoxStyle.BorderStyle.BorderType = Klik.Windows.Forms.v1.Common.BorderTypes.None
        Me.cmbColumnas.EditBoxStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbColumnas.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbColumnas.Location = New System.Drawing.Point(197, 60)
        Me.cmbColumnas.Name = "cmbColumnas"
        Me.cmbColumnas.Size = New System.Drawing.Size(165, 28)
        Me.cmbColumnas.TabIndex = 38
        '
        'cmbHileras
        '
        Me.cmbHileras.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.cmbHileras.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.cmbHileras.CaptionStyle.TextStyle.ForeColor = System.Drawing.Color.Black
        Me.cmbHileras.CaptionStyle.TextStyle.Text = "Hilera"
        Me.cmbHileras.CheckedDisplaySeparator = Global.Microsoft.VisualBasic.ChrW(44)
        Me.cmbHileras.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbHileras.DropDownBackgroundStyle.GradientAngle = 45.0!
        Me.cmbHileras.DropDownBackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.cmbHileras.DropDownBackgroundStyle.SolidColor = System.Drawing.SystemColors.Window
        Me.cmbHileras.DropDownBorderColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        ElListBoxSELECTionStyles2.HotTrackStyle.BorderStyle.EdgeRadius = 4
        ElListBoxSELECTionStyles2.SelectedStyle.BorderStyle.EdgeRadius = 4
        Me.cmbHileras.DropDownItemSelectionStyle = ElListBoxSELECTionStyles2
        Me.cmbHileras.DropDownStyle = Klik.Windows.Forms.v1.EntryLib.DropDownStyles.DropDownList
        Me.cmbHileras.EditBoxStyle.BorderStyle.BorderType = Klik.Windows.Forms.v1.Common.BorderTypes.None
        Me.cmbHileras.EditBoxStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbHileras.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbHileras.Location = New System.Drawing.Point(9, 60)
        Me.cmbHileras.Name = "cmbHileras"
        Me.cmbHileras.Size = New System.Drawing.Size(174, 28)
        Me.cmbHileras.TabIndex = 37
        '
        'cmbBodegas
        '
        Me.cmbBodegas.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.cmbBodegas.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.cmbBodegas.CaptionStyle.TextStyle.ForeColor = System.Drawing.Color.Black
        Me.cmbBodegas.CaptionStyle.TextStyle.Text = "Bodega"
        Me.cmbBodegas.CheckedDisplaySeparator = Global.Microsoft.VisualBasic.ChrW(44)
        Me.cmbBodegas.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbBodegas.DropDownBackgroundStyle.GradientAngle = 45.0!
        Me.cmbBodegas.DropDownBackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.cmbBodegas.DropDownBackgroundStyle.SolidColor = System.Drawing.SystemColors.Window
        Me.cmbBodegas.DropDownBorderColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        ElListBoxSELECTionStyles3.HotTrackStyle.BorderStyle.EdgeRadius = 4
        ElListBoxSELECTionStyles3.SelectedStyle.BorderStyle.EdgeRadius = 4
        Me.cmbBodegas.DropDownItemSelectionStyle = ElListBoxSELECTionStyles3
        Me.cmbBodegas.DropDownStyle = Klik.Windows.Forms.v1.EntryLib.DropDownStyles.DropDownList
        Me.cmbBodegas.EditBoxStyle.BorderStyle.BorderType = Klik.Windows.Forms.v1.Common.BorderTypes.None
        Me.cmbBodegas.EditBoxStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBodegas.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbBodegas.Location = New System.Drawing.Point(9, 31)
        Me.cmbBodegas.Name = "cmbBodegas"
        Me.cmbBodegas.Size = New System.Drawing.Size(506, 28)
        Me.cmbBodegas.TabIndex = 36
        '
        'dtaGrid
        '
        Me.dtaGrid.AllowUserToAddRows = False
        Me.dtaGrid.AllowUserToDELETERows = False
        Me.dtaGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.dtaGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtaGrid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.dtaGrid.Location = New System.Drawing.Point(4, 96)
        Me.dtaGrid.Name = "dtaGrid"
        Me.dtaGrid.ReadOnly = True
        Me.dtaGrid.RowHeadersWidth = 51
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtaGrid.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dtaGrid.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtaGrid.Size = New System.Drawing.Size(511, 323)
        Me.dtaGrid.TabIndex = 1
        '
        'tmrMensaje
        '
        Me.tmrMensaje.Interval = 10000
        '
        'frmUbicaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.erpBusquedas)
        Me.Controls.Add(Me.erpEdicion)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmUbicaciones"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UBICACIONES"
        CType(Me.KFormManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erpEdicion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.erpEdicion.ResumeLayout(False)
        CType(Me.ElTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElTab1.ResumeLayout(False)
        CType(Me.ElTabPage3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElTabPage3.ResumeLayout(False)
        CType(Me.btnGrabar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNivel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtColumna, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHilera, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElTabPage4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElTabPage4.ResumeLayout(False)
        Me.ElTabPage4.PerformLayout()
        CType(Me.upHilera2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.upNiveles2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.upColumnas2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.upHilera1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGrabarC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLimiarC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.upNiveles1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.upColumnas1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElTabPage1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElTabPage1.ResumeLayout(False)
        CType(Me.cmbTama, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPrinter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnImprimir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLimpia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erpBusquedas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.erpBusquedas.ResumeLayout(False)
        CType(Me.cmbColumnas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbHileras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbBodegas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtaGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SerialPort As System.IO.Ports.SerialPort
    Friend WithEvents KFormManager1 As Klik.Windows.Forms.v1.Common.KFormManager
    Friend WithEvents erpEdicion As Klik.Windows.Forms.v1.EntryLib.ELRichPanel
    Friend WithEvents btnBack As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents btnLimpia As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents btnEliminar As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents ElTab1 As Klik.Windows.Forms.v1.EntryLib.ELTab
    Friend WithEvents ElTabPage3 As Klik.Windows.Forms.v1.EntryLib.ELTabPage
    Friend WithEvents ElTabPage4 As Klik.Windows.Forms.v1.EntryLib.ELTabPage
    Friend WithEvents ElTabPage1 As Klik.Windows.Forms.v1.EntryLib.ELTabPage
    Friend WithEvents cmbPrinter As Klik.Windows.Forms.v1.EntryLib.ELComboBox
    Friend WithEvents txtCantidad As Klik.Windows.Forms.v1.EntryLib.ELEntryBox
    Friend WithEvents btnImprimir As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents txtDescripcion As Klik.Windows.Forms.v1.EntryLib.ELEntryBox
    Friend WithEvents txtNivel As Klik.Windows.Forms.v1.EntryLib.ELEntryBox
    Friend WithEvents txtColumna As Klik.Windows.Forms.v1.EntryLib.ELEntryBox
    Friend WithEvents txtHilera As Klik.Windows.Forms.v1.EntryLib.ELEntryBox
    Friend WithEvents cmbEstado As Klik.Windows.Forms.v1.EntryLib.ELComboBox
    Friend WithEvents btnGrabar As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents erpBusquedas As Klik.Windows.Forms.v1.EntryLib.ELRichPanel
    Friend WithEvents dtaGrid As Klik.Windows.Forms.v1.EntryLib.ELDataGridView
    Friend WithEvents cmbHileras As Klik.Windows.Forms.v1.EntryLib.ELComboBox
    Friend WithEvents cmbBodegas As Klik.Windows.Forms.v1.EntryLib.ELComboBox
    Friend WithEvents cmbColumnas As Klik.Windows.Forms.v1.EntryLib.ELComboBox
    Friend WithEvents upNiveles1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents ElLabel4 As Klik.Windows.Forms.v1.EntryLib.ELLabel
    Friend WithEvents upColumnas1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents ElLabel3 As Klik.Windows.Forms.v1.EntryLib.ELLabel
    Friend WithEvents btnGrabarC As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents btnLimiarC As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents cmbTama As Klik.Windows.Forms.v1.EntryLib.ELComboBox
    Friend WithEvents upHilera1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents ElLabel1 As Klik.Windows.Forms.v1.EntryLib.ELLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents upHilera2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents upNiveles2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents upColumnas2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents tmrMensaje As Timer
End Class
