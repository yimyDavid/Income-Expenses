Public Class rptTranViewer

    Private _frmReports As frmReports

    Sub New(frmReports As frmReports)
        ' TODO: Complete member initialization 
        InitializeComponent()
        _frmReports = frmReports
    End Sub

    Private Sub rptTranViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim height As Integer
        Dim width As Integer
        Dim x As Integer
        Dim y As Integer
        rptAccountDate.Visible = False
        width = Me.Size.Width()
        height = Me.Size.Height()

        x = (width - rptPrintTran.Size.Width) / 2

        'MsgBox(height & " " & width)
        Me.rptPrintTran.Size = New System.Drawing.Size(width, height)


        'Me.rptPrintTran.Location = New System.Drawing.Point(x, 41)

        'TODO: This line of code loads data into the 'ExpensesDataSet2.DataTable1' table. You can move, or remove it, as needed.
        'Me.DataTable1TableAdapter.Fill(Me.ExpensesDataSet2.DataTable1, "02/08/2016")
        'TODO: This line of code loads data into the 'ExpensesDataSet21.DataTable1' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'ExpensesDataSet21.DataTable1' table. You can move, or remove it, as needed.
        'Me.EEXPENTableAdapter.Fill(ExpensesDataSet2.EEXPEN)
        rptPrintTran.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        rptAccountDate.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        rptEntity.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)

        ' Me.rptPrintTran.RefreshReport()
        'Me.rptAccountDate.RefreshReport()
        'Me.rptEntity.RefreshReport()
    End Sub

    Public Sub printTransByDate(initDate As String, endDate As String)
        rptPrintTran.Visible = True
        Me.DataTable1TableAdapter.Fill(Me.ExpensesDataSet2.DataTable1, ExpDate:=initDate, ExpDate1:=endDate)
        ' Me.rptPrintTran.RefreshReport()
    End Sub

    Public Sub printTransByAccountDate(iniDate As String, endDate As String, iniAccount As Integer, endAccount As Integer)
        rptAccountDate.Visible = True
        Me.DataTable1TableAdapter.FillByDateAccount(Me.ExpensesDataSet2.DataTable1, ExpDate:=iniDate, ExpDate1:=endDate, AccountID:=iniAccount, AccountID1:=endAccount)
        ' Me.rptPrintTran.RefreshReport()
    End Sub

    Public Sub printTransByEntityDate(iniDate As String, endDate As String, iniEntity As Integer, endEntity As Integer)
        rptEntity.Visible = True
        Me.DataTable1TableAdapter.FillByDateEntity(Me.ExpensesDataSet2.DataTable1, ExpDate:=iniDate, ExpDate1:=endDate, CompanyID:=iniEntity, CompanyID1:=endEntity)
    End Sub
  
End Class