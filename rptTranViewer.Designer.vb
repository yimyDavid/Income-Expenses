<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptTranViewer
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExpensesDataSet2 = New Expenses.ExpensesDataSet2()
        Me.rptPrintTran = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.rptAccountDate = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.rptEntity = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.EEXPENTableAdapter = New Expenses.ExpensesDataSet2TableAdapters.EEXPENTableAdapter()
        Me.DataTable1TableAdapter = New Expenses.ExpensesDataSet2TableAdapters.DataTable1TableAdapter()
        Me.DataTable1TableAdapter1 = New Expenses.ExpensesDataSet2TableAdapters.DataTable1TableAdapter()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpensesDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.ExpensesDataSet2
        '
        'ExpensesDataSet2
        '
        Me.ExpensesDataSet2.DataSetName = "ExpensesDataSet2"
        Me.ExpensesDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rptPrintTran
        '
        Me.rptPrintTran.AutoSize = True
        Me.rptPrintTran.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rptPrintTran.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rptPrintTran.DocumentMapWidth = 1
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.DataTable1BindingSource
        Me.rptPrintTran.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rptPrintTran.LocalReport.ReportEmbeddedResource = "Expenses.rptTransactions.rdlc"
        Me.rptPrintTran.Location = New System.Drawing.Point(0, 0)
        Me.rptPrintTran.Name = "rptPrintTran"
        Me.rptPrintTran.Size = New System.Drawing.Size(809, 494)
        Me.rptPrintTran.TabIndex = 0
        Me.rptPrintTran.Visible = False
        '
        'rptAccountDate
        '
        Me.rptAccountDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rptAccountDate.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataByAccountDate"
        ReportDataSource2.Value = Me.DataTable1BindingSource
        Me.rptAccountDate.LocalReport.DataSources.Add(ReportDataSource2)
        Me.rptAccountDate.LocalReport.ReportEmbeddedResource = "Expenses.rptAccountDate.rdlc"
        Me.rptAccountDate.Location = New System.Drawing.Point(0, 0)
        Me.rptAccountDate.Name = "rptAccountDate"
        Me.rptAccountDate.Size = New System.Drawing.Size(809, 494)
        Me.rptAccountDate.TabIndex = 1
        '
        'rptEntity
        '
        Me.rptEntity.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "TransEntityDate"
        ReportDataSource3.Value = Me.DataTable1BindingSource
        Me.rptEntity.LocalReport.DataSources.Add(ReportDataSource3)
        Me.rptEntity.LocalReport.ReportEmbeddedResource = "Expenses.rptEntityDate.rdlc"
        Me.rptEntity.Location = New System.Drawing.Point(0, 0)
        Me.rptEntity.Name = "rptEntity"
        Me.rptEntity.Size = New System.Drawing.Size(809, 494)
        Me.rptEntity.TabIndex = 2
        Me.rptEntity.Visible = False
        '
        'EEXPENTableAdapter
        '
        Me.EEXPENTableAdapter.ClearBeforeFill = True
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'DataTable1TableAdapter1
        '
        Me.DataTable1TableAdapter1.ClearBeforeFill = True
        '
        'rptTranViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 494)
        Me.Controls.Add(Me.rptEntity)
        Me.Controls.Add(Me.rptAccountDate)
        Me.Controls.Add(Me.rptPrintTran)
        Me.Name = "rptTranViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TCMY Reports"
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpensesDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rptPrintTran As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents EEXPENTableAdapter As Expenses.ExpensesDataSet2TableAdapters.EEXPENTableAdapter
    Friend WithEvents ExpensesDataSet2 As Expenses.ExpensesDataSet2
    Friend WithEvents DataTable1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataTable1TableAdapter As Expenses.ExpensesDataSet2TableAdapters.DataTable1TableAdapter
    Friend WithEvents rptAccountDate As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents rptEntity As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DataTable1TableAdapter1 As Expenses.ExpensesDataSet2TableAdapters.DataTable1TableAdapter
End Class
