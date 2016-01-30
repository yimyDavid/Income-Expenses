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
        Me.mtxtDate = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtAmount = New System.Windows.Forms.TextBox()
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlsNuevo, Me.tlsGuardar, Me.ToolStripSeparator1, Me.tlsVerEgresos})
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
        Me.mtxtAmount.Location = New System.Drawing.Point(151, 135)
        Me.mtxtAmount.Name = "mtxtAmount"
        Me.mtxtAmount.Size = New System.Drawing.Size(100, 20)
        Me.mtxtAmount.TabIndex = 49
        '
        'frm_Egresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(460, 268)
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
        Me.Name = "frm_Egresos"
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
End Class
