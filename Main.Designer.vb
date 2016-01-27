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
        Me.ClasificacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDeIngresoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlsBarMain = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.tlsIngreso = New System.Windows.Forms.ToolStripButton()
        Me.tslBEgresos = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1.SuspendLayout()
        Me.tlsBarMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresosToolStripMenuItem, Me.ClasificacionesToolStripMenuItem, Me.ExitToolStripMenuItem, Me.ProgramadorToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(567, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'IngresosToolStripMenuItem
        '
        Me.IngresosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresosToolStripMenuItem1, Me.EgresosToolStripMenuItem})
        Me.IngresosToolStripMenuItem.Name = "IngresosToolStripMenuItem"
        Me.IngresosToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.IngresosToolStripMenuItem.Text = "&Operaciones"
        '
        'IngresosToolStripMenuItem1
        '
        Me.IngresosToolStripMenuItem1.Name = "IngresosToolStripMenuItem1"
        Me.IngresosToolStripMenuItem1.Size = New System.Drawing.Size(118, 22)
        Me.IngresosToolStripMenuItem1.Text = "Ingresos"
        '
        'EgresosToolStripMenuItem
        '
        Me.EgresosToolStripMenuItem.Name = "EgresosToolStripMenuItem"
        Me.EgresosToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.EgresosToolStripMenuItem.Text = "Egresos"
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
        Me.TiendaToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.TiendaToolStripMenuItem.Text = "&Entidad"
        '
        'TipoDeIngresoToolStripMenuItem
        '
        Me.TipoDeIngresoToolStripMenuItem.Name = "TipoDeIngresoToolStripMenuItem"
        Me.TipoDeIngresoToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.TipoDeIngresoToolStripMenuItem.Text = "&Cuentas"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.ExitToolStripMenuItem.Text = "&Salir"
        '
        'ProgramadorToolStripMenuItem
        '
        Me.ProgramadorToolStripMenuItem.Name = "ProgramadorToolStripMenuItem"
        Me.ProgramadorToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.ProgramadorToolStripMenuItem.Text = "Pro&gramador"
        '
        'tlsBarMain
        '
        Me.tlsBarMain.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.tlsBarMain.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tlsBarMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlsIngreso, Me.ToolStripSeparator1, Me.tslBEgresos, Me.ToolStripSeparator2, Me.ToolStripButton1})
        Me.tlsBarMain.Location = New System.Drawing.Point(0, 24)
        Me.tlsBarMain.Name = "tlsBarMain"
        Me.tlsBarMain.Padding = New System.Windows.Forms.Padding(3)
        Me.tlsBarMain.Size = New System.Drawing.Size(567, 89)
        Me.tlsBarMain.TabIndex = 3
        Me.tlsBarMain.Text = "Menu Bar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 83)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 83)
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
        'tlsIngreso
        '
        Me.tlsIngreso.Image = Global.Expenses.My.Resources.Resources.coin_add
        Me.tlsIngreso.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsIngreso.Margin = New System.Windows.Forms.Padding(5)
        Me.tlsIngreso.Name = "tlsIngreso"
        Me.tlsIngreso.Padding = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.tlsIngreso.Size = New System.Drawing.Size(69, 73)
        Me.tlsIngreso.Text = "Ingresos"
        Me.tlsIngreso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tslBEgresos
        '
        Me.tslBEgresos.Image = Global.Expenses.My.Resources.Resources.coin_delete
        Me.tslBEgresos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tslBEgresos.Margin = New System.Windows.Forms.Padding(5)
        Me.tslBEgresos.Name = "tslBEgresos"
        Me.tslBEgresos.Padding = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.tslBEgresos.Size = New System.Drawing.Size(66, 73)
        Me.tslBEgresos.Text = "Egresos"
        Me.tslBEgresos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.Expenses.My.Resources.Resources.LogOut
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Margin = New System.Windows.Forms.Padding(5)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Padding = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.ToolStripButton1.Size = New System.Drawing.Size(66, 73)
        Me.ToolStripButton1.Text = "Salir"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgramadorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlsBarMain As System.Windows.Forms.ToolStrip
    Friend WithEvents tlsIngreso As System.Windows.Forms.ToolStripButton
    Friend WithEvents tslBEgresos As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton

End Class
