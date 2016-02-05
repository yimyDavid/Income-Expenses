Imports System.Data.OleDb


Public Class IngMain
    Dim cnnOLEDB As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Expenses.accdb;")
    Dim cmdOLEDB As New OleDbCommand
    Dim cmdInsert As New OleDbCommand



    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim frm_Expense As New frm_Egresos(Me)
        'set main form to be parent of frm_expense
        frm_Expense.MdiParent = frm_Main
        frm_Expense.Show()
    End Sub

    Private Sub IngMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnnOLEDB.Open()
        Dim selectQuery As String

        selectQuery = "SELECT EEXPEN.ExpenseID, EEXPEN.ExpDate, EACCNT.Description, EEXPEN.Amount, ECOMP.Description " _
                      + "FROM (EEXPEN INNER JOIN EACCNT ON EEXPEN.AccountID = EACCNT.AccountID) INNER JOIN ECOMP ON EEXPEN.CompanyID = ECOMP.CompanyID"
        Dim cmd As New OleDbCommand(selectQuery, cnnOLEDB)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        Dim dtTable As DataTable = New DataTable()
        dtTable.Columns.Add("ID", GetType(Integer))
        dtTable.Columns.Add("Description", GetType(String))
        While dr.Read
            Dim formatDate As String
            Dim formatAmount As String
            Dim new_item As New ListViewItem(dr.Item("ExpenseID").ToString)
            formatDate = Format(dr.Item("ExpDate"), "MM/dd/yyyy")
            formatAmount = Format(dr.Item("Amount"), "###,###.00")
            new_item.SubItems.Add(formatDate)
            new_item.SubItems.Add(dr.Item("EACCNT.Description").ToString)
            'new_item.SubItems.Add(dr.Item("Amount").ToString)
            new_item.SubItems.Add(formatAmount)

            new_item.SubItems.Add(dr.Item("ECOMP.Description").ToString)
            lstTransactions.Items.Add(new_item)

        End While

        dr.Close()
        cnnOLEDB.Close()
    End Sub

    Public Sub udpateList(detailList As ListViewItem)
        lstTransactions.Items.Add(detailList)
        lstTransactions.Refresh()
    End Sub
End Class