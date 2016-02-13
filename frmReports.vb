Public Class frmReports

    Enum wichReport
        TransactionDate = 0
        AccountAndDate = 1
        EntityAndDate = 2
    End Enum

    Private rptViwerInstance As rptTranViewer

    Sub New(ByVal rptViewer As rptTranViewer)
        InitializeComponent()
        rptViwerInstance = rptViewer

    End Sub

    Sub New()
        InitializeComponent()
        ' TODO: Complete member initialization 
    End Sub

    Private Sub frmReports_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        rdoAccount.Checked = False
        rdoEntity.Checked = False
    End Sub
    Private Sub frmReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ExpensesDataSet21.ECOMP' table. You can move, or remove it, as needed.
        Me.ECOMPTableAdapter.Fill(Me.ExpensesDataSet21.ECOMP)
        'TODO: This line of code loads data into the 'ExpensesDataSet2.EACCNT' table. You can move, or remove it, as needed.
        Me.EACCNTTableAdapter.Fill(Me.ExpensesDataSet2.EACCNT)
        'TODO: This line of code loads data into the 'ExpensesDataSet2.EACCNT' table. You can move, or remove it, as needed.
        Me.EACCNTTableAdapter.Fill(Me.ExpensesDataSet2.EACCNT)
        'TODO: This line of code loads data into the 'ExpensesDataSet2.EACCNT' table. You can move, or remove it, as needed.
        Me.EACCNTTableAdapter.Fill(Me.ExpensesDataSet2.EACCNT)

    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        If rdoAccount.Checked = True Then
            printPickedReport(wichReport.AccountAndDate)
        ElseIf rdoEntity.Checked = True Then
            printPickedReport(wichReport.EntityAndDate)
        Else
            printPickedReport(wichReport.TransactionDate)
        End If
    End Sub

    Private Sub printPickedReport(pickReport As Integer)
        Dim rptTran As New rptTranViewer(Me)
        rptTran.MdiParent = frm_Main
        rptTran.Show()
        Select Case pickReport
            Case wichReport.TransactionDate

                rptTran.printTransByDate(dpiDate.Text, dpeDate.Text)
                rptTran.rptPrintTran.RefreshReport()
            Case wichReport.AccountAndDate
                rptTran.printTransByAccountDate(dpiDate.Text, dpeDate.Text, cboiAccount.SelectedValue, cboeAccount.SelectedValue)
                rptTran.rptAccountDate.RefreshReport()
            Case wichReport.EntityAndDate
                rptTran.printTransByEntityDate(dpiDate.Text, dpeDate.Text, cboiEntity.SelectedValue, cboeEntity.SelectedValue)
                rptTran.rptAccountDate.RefreshReport()
            Case Else
                Throw New ApplicationException("Invalid Option: " & pickReport.ToString)
        End Select
    End Sub

End Class