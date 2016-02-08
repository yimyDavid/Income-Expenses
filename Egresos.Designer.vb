<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Egresos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Egresos))
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboAccount = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboEntity = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tlsNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tlsGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlsVerEgresos = New System.Windows.Forms.ToolStripButton()
        Me.tls_btnUpdate = New System.Windows.Forms.ToolStripButton()
        Me.mtxtDate = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtAmount = New System.Windows.Forms.TextBox()
        Me.lblUpdateWarning = New System.Windows.Forms.Label()
        Me.lblUpdateId = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(151, 169)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(251, 68)
        Me.txtComments.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(70, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Comments"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(96, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(98, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Amount"
        '
        'cboAccount
        '
        Me.cboAccount.DisplayMember = "AccountID"
        Me.cboAccount.FormattingEnabled = True
        Me.cboAccount.Location = New System.Drawing.Point(151, 111)
        Me.cboAccount.Name = "cboAccount"
        Me.cboAccount.Size = New System.Drawing.Size(251, 21)
        Me.cboAccount.TabIndex = 20
        Me.cboAccount.ValueMember = "AccountID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(81, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Account"
        '
        'cboEntity
        '
        Me.cboEntity.DisplayMember = "CompanyID"
        Me.cboEntity.FormattingEnabled = True
        Me.cboEntity.Location = New System.Drawing.Point(151, 83)
        Me.cboEntity.Name = "cboEntity"
        Me.cboEntity.Size = New System.Drawing.Size(251, 21)
        Me.cboEntity.TabIndex = 18
        Me.cboEntity.ValueMember = "CompanyID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(85, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Company"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlsNuevo, Me.tlsGuardar, Me.ToolStripSeparator1, Me.tlsVerEgresos, Me.tls_btnUpdate})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(460, 25)
        Me.ToolStrip1.TabIndex = 47
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tlsNuevo
        '
        Me.tlsNuevo.Image = CType(resources.GetObject("tlsNuevo.Image"), System.Drawing.Image)
        Me.tlsNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsNuevo.Name = "tlsNuevo"
        Me.tlsNuevo.Size = New System.Drawing.Size(51, 22)
        Me.tlsNuevo.Text = "New"
        '
        'tlsGuardar
        '
        Me.tlsGuardar.Image = CType(resources.GetObject("tlsGuardar.Image"), System.Drawing.Image)
        Me.tlsGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsGuardar.Name = "tlsGuardar"
        Me.tlsGuardar.Size = New System.Drawing.Size(51, 22)
        Me.tlsGuardar.Text = "Save"
        Me.tlsGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tlsVerEgresos
        '
        Me.tlsVerEgresos.Image = Global.Expenses.My.Resources.Resources.Preview
        Me.tlsVerEgresos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsVerEgresos.Name = "tlsVerEgresos"
        Me.tlsVerEgresos.Size = New System.Drawing.Size(93, 22)
        Me.tlsVerEgresos.Text = "Transactions"
        '
        'tls_btnUpdate
        '
        Me.tls_btnUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tls_btnUpdate.Image = Global.Expenses.My.Resources.Resources.Update
        Me.tls_btnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tls_btnUpdate.Name = "tls_btnUpdate"
        Me.tls_btnUpdate.Size = New System.Drawing.Size(23, 22)
        Me.tls_btnUpdate.Text = "ToolStripButton1"
        '
        'mtxtDate
        '
        Me.mtxtDate.Location = New System.Drawing.Point(151, 49)
        Me.mtxtDate.Mask = "00/00/0000"
        Me.mtxtDate.Name = "mtxtDate"
        Me.mtxtDate.Size = New System.Drawing.Size(100, 20)
        Me.mtxtDate.TabIndex = 48
        Me.mtxtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mtxtDate.ValidatingType = GetType(Date)
        '
        'mtxtAmount
        '
        Me.mtxtAmount.Location = New System.Drawing.Point(151, 140)
        Me.mtxtAmount.Name = "mtxtAmount"
        Me.mtxtAmount.Size = New System.Drawing.Size(100, 20)
        Me.mtxtAmount.TabIndex = 49
        Me.mtxtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblUpdateWarning
        '
        Me.lblUpdateWarning.AutoSize = True
        Me.lblUpdateWarning.ForeColor = System.Drawing.Color.Red
        Me.lblUpdateWarning.Location = New System.Drawing.Point(148, 30)
        Me.lblUpdateWarning.Name = "lblUpdateWarning"
        Me.lblUpdateWarning.Size = New System.Drawing.Size(191, 13)
        Me.lblUpdateWarning.TabIndex = 50
        Me.lblUpdateWarning.Text = "You are Currently Updating this Record"
        Me.lblUpdateWarning.Visible = False
        '
        'lblUpdateId
        '
        Me.lblUpdateId.AutoSize = True
        Me.lblUpdateId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdateId.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblUpdateId.Location = New System.Drawing.Point(290, 48)
        Me.lblUpdateId.Name = "lblUpdateId"
        Me.lblUpdateId.Size = New System.Drawing.Size(19, 20)
        Me.lblUpdateId.TabIndex = 51
        Me.lblUpdateId.Text = "0"
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "MM/dd/yyyy"
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(277, 136)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtpDate.Size = New System.Drawing.Size(116, 20)
        Me.dtpDate.TabIndex = 52
        Me.dtpDate.Value = New Date(2016, 2, 8, 14, 57, 20, 0)
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(397, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm_Egresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(460, 268)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.lblUpdateId)
        Me.Controls.Add(Me.lblUpdateWarning)
        Me.Controls.Add(Me.mtxtAmount)
        Me.Controls.Add(Me.mtxtDate)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txtComments)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboAccount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboEntity)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_Egresos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Egresos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtComments As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboAccount As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboEntity As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tlsNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlsGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlsVerEgresos As System.Windows.Forms.ToolStripButton
    Friend WithEvents mtxtDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxtAmount As System.Windows.Forms.TextBox
    Friend WithEvents tls_btnUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblUpdateWarning As System.Windows.Forms.Label
    Friend WithEvents lblUpdateId As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
