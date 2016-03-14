<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReports))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dpeDate = New System.Windows.Forms.DateTimePicker()
        Me.dpiDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gboxAccounts = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboeEntity = New System.Windows.Forms.ComboBox()
        Me.ECOMPBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExpensesDataSet21 = New Expenses.ExpensesDataSet2()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboiEntity = New System.Windows.Forms.ComboBox()
        Me.ECOMPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rdoEntity = New System.Windows.Forms.RadioButton()
        Me.rdoAccount = New System.Windows.Forms.RadioButton()
        Me.cboeAccount = New System.Windows.Forms.ComboBox()
        Me.EACCNTBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExpensesDataSet2 = New Expenses.ExpensesDataSet2()
        Me.cboiAccount = New System.Windows.Forms.ComboBox()
        Me.EACCNTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.EACCNTTableAdapter = New Expenses.ExpensesDataSet2TableAdapters.EACCNTTableAdapter()
        Me.ECOMPTableAdapter = New Expenses.ExpensesDataSet2TableAdapters.ECOMPTableAdapter()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.gboxAccounts.SuspendLayout()
        CType(Me.ECOMPBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpensesDataSet21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ECOMPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EACCNTBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpensesDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EACCNTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dpeDate)
        Me.GroupBox1.Controls.Add(Me.dpiDate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 237)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(293, 97)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Between Dates"
        '
        'dpeDate
        '
        Me.dpeDate.CustomFormat = """MM/dd/yyyy"""
        Me.dpeDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpeDate.Location = New System.Drawing.Point(161, 45)
        Me.dpeDate.Name = "dpeDate"
        Me.dpeDate.Size = New System.Drawing.Size(116, 20)
        Me.dpeDate.TabIndex = 5
        '
        'dpiDate
        '
        Me.dpiDate.CustomFormat = """MM/dd/yyyy"""
        Me.dpiDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpiDate.Location = New System.Drawing.Point(20, 46)
        Me.dpiDate.Name = "dpiDate"
        Me.dpiDate.Size = New System.Drawing.Size(116, 20)
        Me.dpiDate.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(158, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "To"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "From"
        '
        'gboxAccounts
        '
        Me.gboxAccounts.Controls.Add(Me.Label5)
        Me.gboxAccounts.Controls.Add(Me.cboeEntity)
        Me.gboxAccounts.Controls.Add(Me.Label6)
        Me.gboxAccounts.Controls.Add(Me.Label7)
        Me.gboxAccounts.Controls.Add(Me.cboiEntity)
        Me.gboxAccounts.Controls.Add(Me.rdoEntity)
        Me.gboxAccounts.Controls.Add(Me.rdoAccount)
        Me.gboxAccounts.Controls.Add(Me.cboeAccount)
        Me.gboxAccounts.Controls.Add(Me.cboiAccount)
        Me.gboxAccounts.Controls.Add(Me.Label3)
        Me.gboxAccounts.Controls.Add(Me.Label4)
        Me.gboxAccounts.Location = New System.Drawing.Point(12, 26)
        Me.gboxAccounts.Name = "gboxAccounts"
        Me.gboxAccounts.Size = New System.Drawing.Size(293, 186)
        Me.gboxAccounts.TabIndex = 6
        Me.gboxAccounts.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(158, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "To"
        '
        'cboeEntity
        '
        Me.cboeEntity.DataSource = Me.ECOMPBindingSource1
        Me.cboeEntity.DisplayMember = "Description"
        Me.cboeEntity.FormattingEnabled = True
        Me.cboeEntity.Location = New System.Drawing.Point(161, 148)
        Me.cboeEntity.Name = "cboeEntity"
        Me.cboeEntity.Size = New System.Drawing.Size(121, 21)
        Me.cboeEntity.TabIndex = 7
        Me.cboeEntity.ValueMember = "CompanyID"
        '
        'ECOMPBindingSource1
        '
        Me.ECOMPBindingSource1.DataMember = "ECOMP"
        Me.ECOMPBindingSource1.DataSource = Me.ExpensesDataSet21
        '
        'ExpensesDataSet21
        '
        Me.ExpensesDataSet21.DataSetName = "ExpensesDataSet2"
        Me.ExpensesDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "From"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label7.Location = New System.Drawing.Point(17, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Or"
        '
        'cboiEntity
        '
        Me.cboiEntity.DataSource = Me.ECOMPBindingSource
        Me.cboiEntity.DisplayMember = "Description"
        Me.cboiEntity.FormattingEnabled = True
        Me.cboiEntity.Location = New System.Drawing.Point(20, 149)
        Me.cboiEntity.Name = "cboiEntity"
        Me.cboiEntity.Size = New System.Drawing.Size(121, 21)
        Me.cboiEntity.TabIndex = 6
        Me.cboiEntity.ValueMember = "CompanyID"
        '
        'ECOMPBindingSource
        '
        Me.ECOMPBindingSource.DataMember = "ECOMP"
        Me.ECOMPBindingSource.DataSource = Me.ExpensesDataSet21
        '
        'rdoEntity
        '
        Me.rdoEntity.AutoSize = True
        Me.rdoEntity.Location = New System.Drawing.Point(6, 114)
        Me.rdoEntity.Name = "rdoEntity"
        Me.rdoEntity.Size = New System.Drawing.Size(104, 17)
        Me.rdoEntity.TabIndex = 10
        Me.rdoEntity.TabStop = True
        Me.rdoEntity.Text = "Between Entities"
        Me.rdoEntity.UseVisualStyleBackColor = True
        '
        'rdoAccount
        '
        Me.rdoAccount.AutoSize = True
        Me.rdoAccount.Location = New System.Drawing.Point(6, 9)
        Me.rdoAccount.Name = "rdoAccount"
        Me.rdoAccount.Size = New System.Drawing.Size(115, 17)
        Me.rdoAccount.TabIndex = 9
        Me.rdoAccount.TabStop = True
        Me.rdoAccount.Text = "Between Accounts"
        Me.rdoAccount.UseVisualStyleBackColor = True
        '
        'cboeAccount
        '
        Me.cboeAccount.DataSource = Me.EACCNTBindingSource1
        Me.cboeAccount.DisplayMember = "Description"
        Me.cboeAccount.FormattingEnabled = True
        Me.cboeAccount.Location = New System.Drawing.Point(161, 46)
        Me.cboeAccount.Name = "cboeAccount"
        Me.cboeAccount.Size = New System.Drawing.Size(121, 21)
        Me.cboeAccount.TabIndex = 5
        Me.cboeAccount.ValueMember = "AccountID"
        '
        'EACCNTBindingSource1
        '
        Me.EACCNTBindingSource1.DataMember = "EACCNT"
        Me.EACCNTBindingSource1.DataSource = Me.ExpensesDataSet2
        '
        'ExpensesDataSet2
        '
        Me.ExpensesDataSet2.DataSetName = "ExpensesDataSet2"
        Me.ExpensesDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboiAccount
        '
        Me.cboiAccount.DataSource = Me.EACCNTBindingSource
        Me.cboiAccount.DisplayMember = "Description"
        Me.cboiAccount.FormattingEnabled = True
        Me.cboiAccount.Location = New System.Drawing.Point(20, 46)
        Me.cboiAccount.Name = "cboiAccount"
        Me.cboiAccount.Size = New System.Drawing.Size(121, 21)
        Me.cboiAccount.TabIndex = 4
        Me.cboiAccount.ValueMember = "AccountID"
        '
        'EACCNTBindingSource
        '
        Me.EACCNTBindingSource.DataMember = "EACCNT"
        Me.EACCNTBindingSource.DataSource = Me.ExpensesDataSet2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(158, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "To"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "From"
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(96, 352)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(112, 34)
        Me.btnPreview.TabIndex = 8
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'EACCNTTableAdapter
        '
        Me.EACCNTTableAdapter.ClearBeforeFill = True
        '
        'ECOMPTableAdapter
        '
        Me.ECOMPTableAdapter.ClearBeforeFill = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label8.Location = New System.Drawing.Point(15, 215)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "And/Or"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label9.Location = New System.Drawing.Point(12, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Choose One Option"
        '
        'frmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 398)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.gboxAccounts)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmReports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reports"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gboxAccounts.ResumeLayout(False)
        Me.gboxAccounts.PerformLayout()
        CType(Me.ECOMPBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpensesDataSet21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ECOMPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EACCNTBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpensesDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EACCNTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dpeDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dpiDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents gboxAccounts As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents cboeAccount As System.Windows.Forms.ComboBox
    Friend WithEvents cboiAccount As System.Windows.Forms.ComboBox
    Friend WithEvents cboeEntity As System.Windows.Forms.ComboBox
    Friend WithEvents cboiEntity As System.Windows.Forms.ComboBox
    Friend WithEvents ExpensesDataSet2 As Expenses.ExpensesDataSet2
    Friend WithEvents EACCNTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EACCNTTableAdapter As Expenses.ExpensesDataSet2TableAdapters.EACCNTTableAdapter
    Friend WithEvents EACCNTBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ExpensesDataSet21 As Expenses.ExpensesDataSet2
    Friend WithEvents ECOMPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ECOMPTableAdapter As Expenses.ExpensesDataSet2TableAdapters.ECOMPTableAdapter
    Friend WithEvents ECOMPBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents rdoAccount As System.Windows.Forms.RadioButton
    Friend WithEvents rdoEntity As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
