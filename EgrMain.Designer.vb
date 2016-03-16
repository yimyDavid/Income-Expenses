<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IngMain))
        Me.tsExpenses = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tls_btnUpdate = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tls_btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.lstTransactions = New System.Windows.Forms.ListView()
        Me.clmID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmAccount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmAmount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmCompany = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtId = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tsExpenses.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsExpenses
        '
        Me.tsExpenses.BackColor = System.Drawing.SystemColors.Control
        Me.tsExpenses.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.tsExpenses.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.tls_btnUpdate, Me.ToolStripSeparator2, Me.tls_btnDelete})
        Me.tsExpenses.Location = New System.Drawing.Point(0, 0)
        Me.tsExpenses.Name = "tsExpenses"
        Me.tsExpenses.Size = New System.Drawing.Size(723, 31)
        Me.tsExpenses.TabIndex = 0
        Me.tsExpenses.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.Expenses.My.Resources.Resources._New
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(28, 28)
        Me.ToolStripButton1.Text = "Create New Record"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'tls_btnUpdate
        '
        Me.tls_btnUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tls_btnUpdate.Image = Global.Expenses.My.Resources.Resources.Edit
        Me.tls_btnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tls_btnUpdate.Name = "tls_btnUpdate"
        Me.tls_btnUpdate.Size = New System.Drawing.Size(28, 28)
        Me.tls_btnUpdate.Text = "Edit Record"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'tls_btnDelete
        '
        Me.tls_btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tls_btnDelete.Image = CType(resources.GetObject("tls_btnDelete.Image"), System.Drawing.Image)
        Me.tls_btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tls_btnDelete.Name = "tls_btnDelete"
        Me.tls_btnDelete.Size = New System.Drawing.Size(28, 28)
        Me.tls_btnDelete.Text = "Delete One Record"
        '
        'lstTransactions
        '
        Me.lstTransactions.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmID, Me.clmDate, Me.clmAccount, Me.clmAmount, Me.clmCompany})
        Me.lstTransactions.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTransactions.FullRowSelect = True
        Me.lstTransactions.GridLines = True
        Me.lstTransactions.Location = New System.Drawing.Point(23, 75)
        Me.lstTransactions.Name = "lstTransactions"
        Me.lstTransactions.Size = New System.Drawing.Size(677, 360)
        Me.lstTransactions.TabIndex = 1
        Me.lstTransactions.UseCompatibleStateImageBehavior = False
        Me.lstTransactions.View = System.Windows.Forms.View.Details
        '
        'clmID
        '
        Me.clmID.Text = "Trans. ID"
        Me.clmID.Width = 100
        '
        'clmDate
        '
        Me.clmDate.Text = "Date"
        Me.clmDate.Width = 100
        '
        'clmAccount
        '
        Me.clmAccount.Text = "Account"
        Me.clmAccount.Width = 220
        '
        'clmAmount
        '
        Me.clmAmount.Text = "Amount"
        Me.clmAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.clmAmount.Width = 100
        '
        'clmCompany
        '
        Me.clmCompany.Text = "Company"
        Me.clmCompany.Width = 153
        '
        'txtId
        '
        Me.txtId.AutoSize = True
        Me.txtId.Location = New System.Drawing.Point(431, 18)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(0, 13)
        Me.txtId.TabIndex = 2
        Me.txtId.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(17, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "List of Transactions"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IngMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(723, 462)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lstTransactions)
        Me.Controls.Add(Me.tsExpenses)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "IngMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Egresos"
        Me.tsExpenses.ResumeLayout(False)
        Me.tsExpenses.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsExpenses As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tls_btnUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tls_btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents lstTransactions As System.Windows.Forms.ListView
    Friend WithEvents clmID As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmAccount As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmAmount As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmCompany As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtId As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
