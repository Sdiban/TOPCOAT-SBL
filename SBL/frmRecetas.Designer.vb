<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecetas
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
        Dim ElListBoxSELECTionStyles1 As Klik.Windows.Forms.v1.EntryLib.ELListBoxSelectionStyles = New Klik.Windows.Forms.v1.EntryLib.ELListBoxSelectionStyles()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecetas))
        Me.KFormManager1 = New Klik.Windows.Forms.v1.Common.KFormManager(Me.components)
        Me.tmrMensaje = New System.Windows.Forms.Timer(Me.components)
        Me.erpBusqueda = New Klik.Windows.Forms.v1.EntryLib.ELRichPanel()
        Me.btnBuscar = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.btnDel = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.btnSave = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.cmbUsuario = New Klik.Windows.Forms.v1.EntryLib.ELComboBox()
        Me.txtDescripcion = New Klik.Windows.Forms.v1.EntryLib.ELEntryBox()
        Me.txtProducto = New Klik.Windows.Forms.v1.EntryLib.ELEntryBox()
        Me.btnClose = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.ElDivider1 = New Klik.Windows.Forms.v1.EntryLib.ELDivider()
        Me.btnELimina = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.btnAdd = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.erpResultados = New Klik.Windows.Forms.v1.EntryLib.ELRichPanel()
        Me.dtaGrid = New Klik.Windows.Forms.v1.EntryLib.ELDataGridView()
        Me.erpDetalles = New Klik.Windows.Forms.v1.EntryLib.ELRichPanel()
        Me.btnGrabaItem = New Klik.Windows.Forms.v1.EntryLib.ELButton()
        Me.dtaDetalles = New Klik.Windows.Forms.v1.EntryLib.ELDataGridView()
        CType(Me.KFormManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erpBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.erpBusqueda.SuspendLayout()
        CType(Me.btnBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElDivider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnELimina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erpResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.erpResultados.SuspendLayout()
        CType(Me.dtaGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erpDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.erpDetalles.SuspendLayout()
        CType(Me.btnGrabaItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtaDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'erpBusqueda
        '
        Me.erpBusqueda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.erpBusqueda.ContainerStyle.BackgroundStyle.GradientAngle = 45.0!
        Me.erpBusqueda.ContainerStyle.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.erpBusqueda.Controls.Add(Me.btnBuscar)
        Me.erpBusqueda.Controls.Add(Me.btnDel)
        Me.erpBusqueda.Controls.Add(Me.btnSave)
        Me.erpBusqueda.Controls.Add(Me.cmbUsuario)
        Me.erpBusqueda.Controls.Add(Me.txtDescripcion)
        Me.erpBusqueda.Controls.Add(Me.txtProducto)
        Me.erpBusqueda.Controls.Add(Me.btnClose)
        Me.erpBusqueda.Controls.Add(Me.ElDivider1)
        Me.erpBusqueda.Expanded = True
        Me.erpBusqueda.FooterStyle.BackgroundStyle.GradientAngle = 0!
        Me.erpBusqueda.FooterStyle.FlashStyle.GradientAngle = 0!
        Me.erpBusqueda.FooterStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.erpBusqueda.FooterStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.erpBusqueda.FooterStyle.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.erpBusqueda.FooterStyle.TextStyle.ForeColor = System.Drawing.Color.Black
        Me.erpBusqueda.HeaderStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.erpBusqueda.HeaderStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.erpBusqueda.HeaderStyle.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.erpBusqueda.HeaderStyle.Height = 24
        Me.erpBusqueda.HeaderStyle.TextStyle.ForeColor = System.Drawing.Color.Black
        Me.erpBusqueda.HeaderStyle.TextStyle.Text = "INGRESO RECETA"
        Me.erpBusqueda.Location = New System.Drawing.Point(1, 2)
        Me.erpBusqueda.Name = "erpBusqueda"
        Me.erpBusqueda.Padding = New System.Windows.Forms.Padding(1, 24, 1, 16)
        Me.erpBusqueda.Size = New System.Drawing.Size(334, 525)
        Me.erpBusqueda.TabIndex = 30
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.BorderStyle.EdgeRadius = 7
        Me.btnBuscar.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnBuscar.DropDownArrowColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnBuscar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnBuscar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnBuscar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnBuscar.Location = New System.Drawing.Point(4, 193)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(100, 25)
        Me.btnBuscar.TabIndex = 65
        Me.btnBuscar.TextStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnBuscar.TextStyle.Text = "BUSCAR"
        Me.btnBuscar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnBuscar.UseWaitCursor = True
        '
        'btnDel
        '
        Me.btnDel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDel.BorderStyle.EdgeRadius = 7
        Me.btnDel.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.btnDel.DropDownArrowColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnDel.Enabled = False
        Me.btnDel.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnDel.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnDel.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnDel.Location = New System.Drawing.Point(118, 481)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(100, 25)
        Me.btnDel.TabIndex = 64
        Me.btnDel.TextStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnDel.TextStyle.Text = "CAMBIA EST."
        Me.btnDel.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BorderStyle.EdgeRadius = 7
        Me.btnSave.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSave.DropDownArrowColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnSave.Enabled = False
        Me.btnSave.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnSave.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnSave.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSave.Location = New System.Drawing.Point(4, 481)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 25)
        Me.btnSave.TabIndex = 63
        Me.btnSave.TextStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnSave.TextStyle.Text = "GRABAR"
        Me.btnSave.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbUsuario
        '
        Me.cmbUsuario.AutoSize = False
        Me.cmbUsuario.CaptionStyle.CaptionSize = 135
        Me.cmbUsuario.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.cmbUsuario.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.cmbUsuario.CaptionStyle.TextStyle.ForeColor = System.Drawing.Color.Black
        Me.cmbUsuario.CaptionStyle.TextStyle.Text = "USUARIO"
        Me.cmbUsuario.CheckedDisplaySeparator = Global.Microsoft.VisualBasic.ChrW(44)
        Me.cmbUsuario.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbUsuario.DropDownBackgroundStyle.GradientAngle = 45.0!
        Me.cmbUsuario.DropDownBackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.cmbUsuario.DropDownBackgroundStyle.SolidColor = System.Drawing.SystemColors.Window
        Me.cmbUsuario.DropDownBorderColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        ElListBoxSELECTionStyles1.HotTrackStyle.BorderStyle.EdgeRadius = 4
        ElListBoxSELECTionStyles1.SelectedStyle.BorderStyle.EdgeRadius = 4
        Me.cmbUsuario.DropDownItemSelectionStyle = ElListBoxSELECTionStyles1
        Me.cmbUsuario.DropDownStyle = Klik.Windows.Forms.v1.EntryLib.DropDownStyles.DropDownList
        Me.cmbUsuario.EditBoxStyle.BorderStyle.BorderType = Klik.Windows.Forms.v1.Common.BorderTypes.None
        Me.cmbUsuario.EditBoxStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUsuario.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbUsuario.Location = New System.Drawing.Point(4, 129)
        Me.cmbUsuario.Name = "cmbUsuario"
        Me.cmbUsuario.Size = New System.Drawing.Size(269, 28)
        Me.cmbUsuario.TabIndex = 51
        '
        'txtDescripcion
        '
        Me.txtDescripcion.AutoSize = False
        Me.txtDescripcion.CaptionStyle.CaptionSize = 135
        Me.txtDescripcion.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.txtDescripcion.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtDescripcion.CaptionStyle.TextStyle.ForeColor = System.Drawing.Color.Black
        Me.txtDescripcion.CaptionStyle.TextStyle.Text = "DESCRIPCIÓN"
        Me.txtDescripcion.EditBoxStyle.BorderStyle.BorderType = Klik.Windows.Forms.v1.Common.BorderTypes.None
        Me.txtDescripcion.EditBoxStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(4, 93)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(324, 28)
        Me.txtDescripcion.TabIndex = 49
        Me.txtDescripcion.ValidationStyle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcion.Value = ""
        '
        'txtProducto
        '
        Me.txtProducto.AutoSize = False
        Me.txtProducto.CaptionStyle.CaptionSize = 135
        Me.txtProducto.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.txtProducto.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtProducto.CaptionStyle.TextStyle.ForeColor = System.Drawing.Color.Black
        Me.txtProducto.CaptionStyle.TextStyle.Text = "CÓDIGO PROD."
        Me.txtProducto.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtProducto.EditBoxStyle.BorderStyle.BorderType = Klik.Windows.Forms.v1.Common.BorderTypes.None
        Me.txtProducto.EditBoxStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProducto.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtProducto.Location = New System.Drawing.Point(4, 57)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(269, 28)
        Me.txtProducto.TabIndex = 48
        Me.txtProducto.ValidationStyle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProducto.Value = ""
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BorderStyle.EdgeRadius = 7
        Me.btnClose.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnClose.DropDownArrowColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnClose.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnClose.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnClose.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnClose.Location = New System.Drawing.Point(230, 481)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 25)
        Me.btnClose.TabIndex = 22
        Me.btnClose.TextStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnClose.TextStyle.Text = "VOLVER"
        Me.btnClose.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ElDivider1
        '
        Me.ElDivider1.LineSize = 3
        Me.ElDivider1.Location = New System.Drawing.Point(4, 219)
        Me.ElDivider1.Name = "ElDivider1"
        Me.ElDivider1.Size = New System.Drawing.Size(324, 23)
        Me.ElDivider1.TabIndex = 14
        '
        'btnELimina
        '
        Me.btnELimina.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnELimina.BorderStyle.EdgeRadius = 7
        Me.btnELimina.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.btnELimina.DropDownArrowColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnELimina.Enabled = False
        Me.btnELimina.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnELimina.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnELimina.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnELimina.Location = New System.Drawing.Point(122, 228)
        Me.btnELimina.Name = "btnELimina"
        Me.btnELimina.Size = New System.Drawing.Size(100, 25)
        Me.btnELimina.TabIndex = 66
        Me.btnELimina.TextStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnELimina.TextStyle.Text = "ELIMINAR ITEM"
        Me.btnELimina.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.BorderStyle.EdgeRadius = 7
        Me.btnAdd.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAdd.DropDownArrowColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAdd.Enabled = False
        Me.btnAdd.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnAdd.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnAdd.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAdd.Location = New System.Drawing.Point(8, 228)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 25)
        Me.btnAdd.TabIndex = 65
        Me.btnAdd.TextStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAdd.TextStyle.Text = "AGREGAR ITEM"
        Me.btnAdd.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.erpResultados.FooterStyle.TextStyle.ForeColor = System.Drawing.Color.Black
        Me.erpResultados.HeaderStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.erpResultados.HeaderStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.erpResultados.HeaderStyle.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.erpResultados.HeaderStyle.Height = 24
        Me.erpResultados.HeaderStyle.TextStyle.ForeColor = System.Drawing.Color.Black
        Me.erpResultados.HeaderStyle.TextStyle.Text = "CABECERA RECETA"
        Me.erpResultados.Location = New System.Drawing.Point(336, 3)
        Me.erpResultados.Name = "erpResultados"
        Me.erpResultados.Padding = New System.Windows.Forms.Padding(1, 24, 1, 16)
        Me.erpResultados.Size = New System.Drawing.Size(646, 252)
        Me.erpResultados.TabIndex = 31
        '
        'dtaGrid
        '
        Me.dtaGrid.AllowUserToAddRows = False
        Me.dtaGrid.AllowUserToDELETERows = False
        Me.dtaGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.dtaGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dtaGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtaGrid.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.dtaGrid.BackgroundStyle.SolidColor = System.Drawing.SystemColors.Window
        Me.dtaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtaGrid.DefaultCellStyle = DataGridViewCellStyle4
        Me.dtaGrid.GridColor = System.Drawing.Color.LightGray
        Me.dtaGrid.Location = New System.Drawing.Point(5, 26)
        Me.dtaGrid.Name = "dtaGrid"
        Me.dtaGrid.ReadOnly = True
        Me.dtaGrid.RowHeadersWidth = 51
        Me.dtaGrid.Size = New System.Drawing.Size(631, 208)
        Me.dtaGrid.TabIndex = 15
        '
        'erpDetalles
        '
        Me.erpDetalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.erpDetalles.ContainerStyle.BackgroundStyle.GradientAngle = 45.0!
        Me.erpDetalles.ContainerStyle.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.erpDetalles.Controls.Add(Me.btnGrabaItem)
        Me.erpDetalles.Controls.Add(Me.btnELimina)
        Me.erpDetalles.Controls.Add(Me.btnAdd)
        Me.erpDetalles.Controls.Add(Me.dtaDetalles)
        Me.erpDetalles.Expanded = True
        Me.erpDetalles.FooterStyle.BackgroundStyle.GradientAngle = 0!
        Me.erpDetalles.FooterStyle.FlashStyle.GradientAngle = 0!
        Me.erpDetalles.FooterStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.erpDetalles.FooterStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.erpDetalles.FooterStyle.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.erpDetalles.FooterStyle.TextStyle.ForeColor = System.Drawing.Color.Black
        Me.erpDetalles.HeaderStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.erpDetalles.HeaderStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.erpDetalles.HeaderStyle.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.erpDetalles.HeaderStyle.Height = 24
        Me.erpDetalles.HeaderStyle.TextStyle.ForeColor = System.Drawing.Color.Black
        Me.erpDetalles.HeaderStyle.TextStyle.Text = "DETALLE RECETA"
        Me.erpDetalles.Location = New System.Drawing.Point(336, 257)
        Me.erpDetalles.Name = "erpDetalles"
        Me.erpDetalles.Padding = New System.Windows.Forms.Padding(1, 24, 1, 16)
        Me.erpDetalles.Size = New System.Drawing.Size(646, 270)
        Me.erpDetalles.TabIndex = 32
        '
        'btnGrabaItem
        '
        Me.btnGrabaItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGrabaItem.BorderStyle.EdgeRadius = 7
        Me.btnGrabaItem.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.btnGrabaItem.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnGrabaItem.DropDownArrowColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGrabaItem.Enabled = False
        Me.btnGrabaItem.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnGrabaItem.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnGrabaItem.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnGrabaItem.Location = New System.Drawing.Point(536, 228)
        Me.btnGrabaItem.Name = "btnGrabaItem"
        Me.btnGrabaItem.Size = New System.Drawing.Size(100, 25)
        Me.btnGrabaItem.TabIndex = 68
        Me.btnGrabaItem.TextStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGrabaItem.TextStyle.Text = "GRABAR ITEM"
        Me.btnGrabaItem.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtaDetalles
        '
        Me.dtaDetalles.AllowUserToAddRows = False
        Me.dtaDetalles.AllowUserToDELETERows = False
        Me.dtaDetalles.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.dtaDetalles.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtaDetalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtaDetalles.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.dtaDetalles.BackgroundStyle.SolidColor = System.Drawing.SystemColors.Window
        Me.dtaDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtaDetalles.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtaDetalles.GridColor = System.Drawing.Color.LightGray
        Me.dtaDetalles.Location = New System.Drawing.Point(6, 26)
        Me.dtaDetalles.Name = "dtaDetalles"
        Me.dtaDetalles.ReadOnly = True
        Me.dtaDetalles.RowHeadersWidth = 51
        Me.dtaDetalles.Size = New System.Drawing.Size(631, 198)
        Me.dtaDetalles.TabIndex = 15
        '
        'frmRecetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 530)
        Me.ControlBox = False
        Me.Controls.Add(Me.erpDetalles)
        Me.Controls.Add(Me.erpResultados)
        Me.Controls.Add(Me.erpBusqueda)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRecetas"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RECETA"
        CType(Me.KFormManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erpBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.erpBusqueda.ResumeLayout(False)
        CType(Me.btnBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElDivider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnELimina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erpResultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.erpResultados.ResumeLayout(False)
        CType(Me.dtaGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erpDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.erpDetalles.ResumeLayout(False)
        CType(Me.btnGrabaItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtaDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KFormManager1 As Klik.Windows.Forms.v1.Common.KFormManager
    Friend WithEvents tmrMensaje As Timer
    Friend WithEvents erpDetalles As Klik.Windows.Forms.v1.EntryLib.ELRichPanel
    Friend WithEvents dtaDetalles As Klik.Windows.Forms.v1.EntryLib.ELDataGridView
    Friend WithEvents erpResultados As Klik.Windows.Forms.v1.EntryLib.ELRichPanel
    Friend WithEvents dtaGrid As Klik.Windows.Forms.v1.EntryLib.ELDataGridView
    Friend WithEvents erpBusqueda As Klik.Windows.Forms.v1.EntryLib.ELRichPanel
    Friend WithEvents cmbUsuario As Klik.Windows.Forms.v1.EntryLib.ELComboBox
    Friend WithEvents txtDescripcion As Klik.Windows.Forms.v1.EntryLib.ELEntryBox
    Friend WithEvents txtProducto As Klik.Windows.Forms.v1.EntryLib.ELEntryBox
    Friend WithEvents btnClose As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents ElDivider1 As Klik.Windows.Forms.v1.EntryLib.ELDivider
    Friend WithEvents btnDel As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents btnSave As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents btnAdd As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents btnELimina As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents btnGrabaItem As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents btnBuscar As Klik.Windows.Forms.v1.EntryLib.ELButton
End Class
