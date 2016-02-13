<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.IngresosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EgresosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClasificacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDeIngresoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlsBarMain = New System.Windows.Forms.ToolStrip()
        Me.tlsRecords = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlsAccounts = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlsEntity = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlsClose = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStrip1.SuspendLayout()
        Me.tlsBarMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresosToolStripMenuItem, Me.ClasificacionesToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.ProgramadorToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(567, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'IngresosToolStripMenuItem
        '
        Me.IngresosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresosToolStripMenuItem1, Me.EgresosToolStripMenuItem, Me.ToolStripSeparator3, Me.ExitToolStripMenuItem1})
        Me.IngresosToolStripMenuItem.Name = "IngresosToolStripMenuItem"
        Me.IngresosToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.IngresosToolStripMenuItem.Text = "&Operaciones"
        '
        'IngresosToolStripMenuItem1
        '
        Me.IngresosToolStripMenuItem1.Name = "IngresosToolStripMenuItem1"
        Me.IngresosToolStripMenuItem1.Size = New System.Drawing.Size(138, 22)
        Me.IngresosToolStripMenuItem1.Text = "&New Record"
        '
        'EgresosToolStripMenuItem
        '
        Me.EgresosToolStripMenuItem.Name = "EgresosToolStripMenuItem"
        Me.EgresosToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.EgresosToolStripMenuItem.Text = "&Records"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(135, 6)
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(138, 22)
        Me.ExitToolStripMenuItem1.Text = "&Exit"
        '
        'ClasificacionesToolStripMenuItem
        '
        Me.ClasificacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TiendaToolStripMenuItem, Me.TipoDeIngresoToolStripMenuItem})
        Me.ClasificacionesToolStripMenuItem.Name = "ClasificacionesToolStripMenuItem"
        Me.ClasificacionesToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.ClasificacionesToolStripMenuItem.Text = "&Clasificaciones"
        '
        'TiendaToolStripMenuItem
        '
        Me.TiendaToolStripMenuItem.Name = "TiendaToolStripMenuItem"
        Me.TiendaToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.TiendaToolStripMenuItem.Text = "&Entities"
        '
        'TipoDeIngresoToolStripMenuItem
        '
        Me.TipoDeIngresoToolStripMenuItem.Name = "TipoDeIngresoToolStripMenuItem"
        Me.TipoDeIngresoToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.TipoDeIngresoToolStripMenuItem.Text = "&Accounts"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "Re&ports"
        '
        'ProgramadorToolStripMenuItem
        '
        Me.ProgramadorToolStripMenuItem.Name = "ProgramadorToolStripMenuItem"
        Me.ProgramadorToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.ProgramadorToolStripMenuItem.Text = "A&bout"
        '
        'tlsBarMain
        '
        Me.tlsBarMain.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.tlsBarMain.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tlsBarMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlsRecords, Me.ToolStripSeparator1, Me.tlsAccounts, Me.ToolStripSeparator2, Me.tlsEntity, Me.ToolStripSeparator4, Me.tlsClose, Me.ToolStripSeparator5, Me.ToolStripButton1, Me.ToolStripSeparator6})
        Me.tlsBarMain.Location = New System.Drawing.Point(0, 24)
        Me.tlsBarMain.Name = "tlsBarMain"
        Me.tlsBarMain.Padding = New System.Windows.Forms.Padding(3)
        Me.tlsBarMain.Size = New System.Drawing.Size(567, 89)
        Me.tlsBarMain.TabIndex = 3
        Me.tlsBarMain.Text = "Menu Bar"
        '
        'tlsRecords
        '
        Me.tlsRecords.Image = Global.Expenses.My.Resources.Resources.transaction
        Me.tlsRecords.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsRecords.Margin = New System.Windows.Forms.Padding(5)
        Me.tlsRecords.Name = "tlsRecords"
        Me.tlsRecords.Padding = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.tlsRecords.Size = New System.Drawing.Size(67, 73)
        Me.tlsRecords.Text = "&Records"
        Me.tlsRecords.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 83)
        '
        'tlsAccounts
        '
        Me.tlsAccounts.Image = Global.Expenses.My.Resources.Resources.account
        Me.tlsAccounts.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsAccounts.Margin = New System.Windows.Forms.Padding(5)
        Me.tlsAccounts.Name = "tlsAccounts"
        Me.tlsAccounts.Padding = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.tlsAccounts.Size = New System.Drawing.Size(75, 73)
        Me.tlsAccounts.Text = "&Accounts"
        Me.tlsAccounts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 83)
        '
        'tlsEntity
        '
        Me.tlsEntity.AutoSize = False
        Me.tlsEntity.Image = Global.Expenses.My.Resources.Resources.entity
        Me.tlsEntity.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsEntity.Margin = New System.Windows.Forms.Padding(5)
        Me.tlsEntity.Name = "tlsEntity"
        Me.tlsEntity.Size = New System.Drawing.Size(67, 73)
        Me.tlsEntity.Text = "&Entities"
        Me.tlsEntity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 83)
        '
        'tlsClose
        '
        Me.tlsClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tlsClose.Image = Global.Expenses.My.Resources.Resources.LogOut
        Me.tlsClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsClose.Margin = New System.Windows.Forms.Padding(5)
        Me.tlsClose.Name = "tlsClose"
        Me.tlsClose.Padding = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.tlsClose.Size = New System.Drawing.Size(66, 73)
        Me.tlsClose.Text = "E&xit"
        Me.tlsClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 83)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.Image = Global.Expenses.My.Resources.Resources.reports
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Margin = New System.Windows.Forms.Padding(5)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(67, 73)
        Me.ToolStripButton1.Text = "Re&ports"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 24)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(567, 0)
        Me.FlowLayoutPanel1.TabIndex = 4
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 83)
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 401)
        Me.Controls.Add(Me.tlsBarMain)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_Main"
        Me.Text = "CTMY Expenses v.0"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.tlsBarMain.ResumeLayout(False)
        Me.tlsBarMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents IngresosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EgresosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClasificacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TiendaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipoDeIngresoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgramadorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlsBarMain As System.Windows.Forms.ToolStrip
    Friend WithEvents tlsRecords As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlsAccounts As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlsClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlsEntity As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator

End Class
