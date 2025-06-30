<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreaInventario
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCreaInventario))
        Me.KFormManager1 = New Klik.Windows.Forms.v1.Common.KFormManager(Me.components)
        Me.btnCrear = New Klik.Windows.Forms.v1.EntryLib.ELButton
        Me.erpResultados = New Klik.Windows.Forms.v1.EntryLib.ELRichPanel
        Me.btnCerrarInventario = New Klik.Windows.Forms.v1.EntryLib.ELButton
        Me.btnBack = New Klik.Windows.Forms.v1.EntryLib.ELButton
        Me.dtaGrid = New Klik.Windows.Forms.v1.EntryLib.ELDataGridView
        Me.tmrMensaje = New System.Windows.Forms.Timer(Me.components)
        CType(Me.KFormManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCrear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erpResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.erpResultados.SuspendLayout()
        CType(Me.btnCerrarInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtaGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KFormManager1
        '
        Me.KFormManager1.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle
        Me.KFormManager1.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle
        Me.KFormManager1.MainContainer = Me
        '
        'btnCrear
        '
        Me.btnCrear.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnCrear.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnCrear.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnCrear.Location = New System.Drawing.Point(4, 27)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(109, 23)
        Me.btnCrear.TabIndex = 0
        Me.btnCrear.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrear.TextStyle.Text = "NUEVO"
        Me.btnCrear.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'erpResultados
        '
        Me.erpResultados.ContainerStyle.BackgroundStyle.GradientAngle = 45.0!
        Me.erpResultados.Controls.Add(Me.btnCerrarInventario)
        Me.erpResultados.Controls.Add(Me.btnBack)
        Me.erpResultados.Controls.Add(Me.dtaGrid)
        Me.erpResultados.Controls.Add(Me.btnCrear)
        Me.erpResultados.Expanded = True
        Me.erpResultados.FooterStyle.BackgroundStyle.GradientAngle = 45.0!
        Me.erpResultados.FooterStyle.FlashStyle.GradientAngle = 0.0!
        Me.erpResultados.FooterStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.erpResultados.FooterStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.erpResultados.FooterStyle.Height = 20
        Me.erpResultados.HeaderStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.erpResultados.HeaderStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.erpResultados.HeaderStyle.Height = 24
        Me.erpResultados.HeaderStyle.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.erpResultados.HeaderStyle.TextStyle.Text = "RESULTADOS"
        Me.erpResultados.Location = New System.Drawing.Point(3, 5)
        Me.erpResultados.Name = "erpResultados"
        Me.erpResultados.Padding = New System.Windows.Forms.Padding(1, 24, 1, 20)
        Me.erpResultados.Size = New System.Drawing.Size(772, 537)
        Me.erpResultados.TabIndex = 3
        '
        'btnCerrarInventario
        '
        Me.btnCerrarInventario.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnCerrarInventario.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnCerrarInventario.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnCerrarInventario.Location = New System.Drawing.Point(119, 27)
        Me.btnCerrarInventario.Name = "btnCerrarInventario"
        Me.btnCerrarInventario.Size = New System.Drawing.Size(156, 23)
        Me.btnCerrarInventario.TabIndex = 5
        Me.btnCerrarInventario.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarInventario.TextStyle.Text = "CERRAR INVENTARIO"
        Me.btnCerrarInventario.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBack
        '
        Me.btnBack.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.btnBack.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnBack.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnBack.Location = New System.Drawing.Point(658, 27)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(109, 23)
        Me.btnBack.TabIndex = 4
        Me.btnBack.TextStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.TextStyle.Text = "VOLVER"
        Me.btnBack.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtaGrid
        '
        Me.dtaGrid.AllowUserToAddRows = False
        Me.dtaGrid.AllowUserToDELETERows = False
        Me.dtaGrid.AllowUserToResizeRows = False
        Me.dtaGrid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.dtaGrid.Location = New System.Drawing.Point(4, 56)
        Me.dtaGrid.MultiSelect = False
        Me.dtaGrid.Name = "dtaGrid"
        Me.dtaGrid.ReadOnly = True
        Me.dtaGrid.Size = New System.Drawing.Size(764, 458)
        Me.dtaGrid.TabIndex = 1
        '
        'tmrMensaje
        '
        Me.tmrMensaje.Interval = 10000
        '
        'frmCreaInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 543)
        Me.ControlBox = False
        Me.Controls.Add(Me.erpResultados)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCreaInventario"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INVENTARIOS"
        CType(Me.KFormManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCrear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erpResultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.erpResultados.ResumeLayout(False)
        CType(Me.btnCerrarInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtaGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KFormManager1 As Klik.Windows.Forms.v1.Common.KFormManager
    Friend WithEvents btnCrear As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents erpResultados As Klik.Windows.Forms.v1.EntryLib.ELRichPanel
    Friend WithEvents dtaGrid As Klik.Windows.Forms.v1.EntryLib.ELDataGridView
    Friend WithEvents tmrMensaje As System.Windows.Forms.Timer
    Friend WithEvents btnBack As Klik.Windows.Forms.v1.EntryLib.ELButton
    Friend WithEvents btnCerrarInventario As Klik.Windows.Forms.v1.EntryLib.ELButton
End Class
