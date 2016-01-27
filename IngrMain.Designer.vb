<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngrMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IngrMain))
        Me.tsIncomes = New System.Windows.Forms.ToolStrip()
        Me.tlsMonth = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ts_btnNew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ts_btnEdit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ts_btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.gridIngresos = New System.Windows.Forms.DataGridView()
        Me.tsIncomes.SuspendLayout()
        CType(Me.gridIngresos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsIncomes
        '
        Me.tsIncomes.BackColor = System.Drawing.SystemColors.Control
        Me.tsIncomes.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.tsIncomes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlsMonth, Me.ToolStripTextBox1, Me.ts_btnNew, Me.ToolStripSeparator1, Me.ts_btnEdit, Me.ToolStripSeparator2, Me.ts_btnDelete})
        Me.tsIncomes.Location = New System.Drawing.Point(0, 0)
        Me.tsIncomes.Name = "tsIncomes"
        Me.tsIncomes.Size = New System.Drawing.Size(866, 31)
        Me.tsIncomes.TabIndex = 1
        Me.tsIncomes.Text = "ToolStrip1"
        '
        'tlsMonth
        '
        Me.tlsMonth.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tlsMonth.Items.AddRange(New Object() {"Enero", "Febreo", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.tlsMonth.Name = "tlsMonth"
        Me.tlsMonth.Size = New System.Drawing.Size(121, 31)
        Me.tlsMonth.Text = "Elegir Mes"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 31)
        '
        'ts_btnNew
        '
        Me.ts_btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ts_btnNew.Image = Global.Expenses.My.Resources.Resources._New
        Me.ts_btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_btnNew.Name = "ts_btnNew"
        Me.ts_btnNew.Size = New System.Drawing.Size(28, 28)
        Me.ts_btnNew.Text = "Nuevo"
        Me.ts_btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'ts_btnEdit
        '
        Me.ts_btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ts_btnEdit.Image = Global.Expenses.My.Resources.Resources.Edit
        Me.ts_btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_btnEdit.Name = "ts_btnEdit"
        Me.ts_btnEdit.Size = New System.Drawing.Size(28, 28)
        Me.ts_btnEdit.Text = "ToolStripButton2"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'ts_btnDelete
        '
        Me.ts_btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ts_btnDelete.Image = CType(resources.GetObject("ts_btnDelete.Image"), System.Drawing.Image)
        Me.ts_btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_btnDelete.Name = "ts_btnDelete"
        Me.ts_btnDelete.Size = New System.Drawing.Size(28, 28)
        Me.ts_btnDelete.Text = "ToolStripButton3"
        '
        'gridIngresos
        '
        Me.gridIngresos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.gridIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridIngresos.Location = New System.Drawing.Point(0, 62)
        Me.gridIngresos.Name = "gridIngresos"
        Me.gridIngresos.Size = New System.Drawing.Size(866, 334)
        Me.gridIngresos.TabIndex = 2
        '
        'IngrMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 396)
        Me.Controls.Add(Me.gridIngresos)
        Me.Controls.Add(Me.tsIncomes)
        Me.Name = "IngrMain"
        Me.Text = "Listado de Ingresos"
        Me.tsIncomes.ResumeLayout(False)
        Me.tsIncomes.PerformLayout()
        CType(Me.gridIngresos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsIncomes As System.Windows.Forms.ToolStrip
    Friend WithEvents tlsMonth As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ts_btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ts_btnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ts_btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents gridIngresos As System.Windows.Forms.DataGridView
End Class
