<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Categoria
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Categoria))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAccount = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.lstCategory = New System.Windows.Forms.ListView()
        Me.Account = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tlsNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tlsGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.ETYPEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.accId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ETYPEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Account"
        '
        'txtAccount
        '
        Me.txtAccount.Location = New System.Drawing.Point(118, 40)
        Me.txtAccount.Name = "txtAccount"
        Me.txtAccount.Size = New System.Drawing.Size(233, 20)
        Me.txtAccount.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlsNuevo, Me.tlsGuardar, Me.btnDelete})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(397, 25)
        Me.ToolStrip1.TabIndex = 47
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Tipo"
        '
        'cboType
        '
        Me.cboType.AutoCompleteCustomSource.AddRange(New String() {"INCOME", "EXPENSE"})
        Me.cboType.DisplayMember = "typeID"
        Me.cboType.FormattingEnabled = True
        Me.cboType.Location = New System.Drawing.Point(118, 65)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(159, 21)
        Me.cboType.TabIndex = 49
        Me.cboType.ValueMember = "typeID"
        '
        'lstCategory
        '
        Me.lstCategory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Account, Me.Type, Me.accId})
        Me.lstCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lstCategory.FullRowSelect = True
        Me.lstCategory.GridLines = True
        Me.lstCategory.LabelEdit = True
        Me.lstCategory.Location = New System.Drawing.Point(46, 108)
        Me.lstCategory.Name = "lstCategory"
        Me.lstCategory.Size = New System.Drawing.Size(305, 219)
        Me.lstCategory.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lstCategory.TabIndex = 50
        Me.lstCategory.UseCompatibleStateImageBehavior = False
        Me.lstCategory.View = System.Windows.Forms.View.Details
        '
        'Account
        '
        Me.Account.Text = "Account"
        Me.Account.Width = 200
        '
        'Type
        '
        Me.Type.Text = "Type"
        Me.Type.Width = 101
        '
        'tlsNuevo
        '
        Me.tlsNuevo.Image = CType(resources.GetObject("tlsNuevo.Image"), System.Drawing.Image)
        Me.tlsNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsNuevo.Name = "tlsNuevo"
        Me.tlsNuevo.Size = New System.Drawing.Size(62, 22)
        Me.tlsNuevo.Text = "Nuevo"
        '
        'tlsGuardar
        '
        Me.tlsGuardar.Image = CType(resources.GetObject("tlsGuardar.Image"), System.Drawing.Image)
        Me.tlsGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsGuardar.Name = "tlsGuardar"
        Me.tlsGuardar.Size = New System.Drawing.Size(69, 22)
        Me.tlsGuardar.Text = "Guardar"
        '
        'btnDelete
        '
        Me.btnDelete.Image = Global.Expenses.My.Resources.Resources.delete
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(70, 22)
        Me.btnDelete.Text = "Eliminar"
        '
        'ETYPEBindingSource
        '
        Me.ETYPEBindingSource.DataMember = "ETYPE"
        '
        'accId
        '
        Me.accId.Text = "iD"
        '
        'frm_Categoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(397, 339)
        Me.Controls.Add(Me.lstCategory)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txtAccount)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_Categoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Categoria"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ETYPEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAccount As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tlsNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlsGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboType As System.Windows.Forms.ComboBox

    Friend WithEvents ETYPEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents lstCategory As System.Windows.Forms.ListView
    Friend WithEvents Account As System.Windows.Forms.ColumnHeader
    Friend WithEvents Type As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents accId As System.Windows.Forms.ColumnHeader

End Class
