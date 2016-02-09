Imports System.Data.OleDb


Public Class IngMain
    Dim cnnOLEDB As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Expenses.accdb;")
    Dim cmdOLEDB As New OleDbCommand
    Dim cmdInsert As New OleDbCommand

    Dim deleteId As String = -1
    Dim deleteRecord As String
    Dim indexList As String

    Private frmEgresoToFill As frm_Egresos

    Sub New(ByVal mainEgr As frm_Egresos)
        InitializeComponent()
        frmEgresoToFill = mainEgr

    End Sub

    Sub New()
        ' TODO: Complete member initialization 
        InitializeComponent()
    End Sub


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

    Public Sub updateList(detailList As ListViewItem)
        Dim id As String
        Dim findItem As ListViewItem
        'Dim indexList As String
        id = detailList.SubItems(0).Text
        'MsgBox(id)
        findItem = lstTransactions.FindItemWithText(id)
        'indexList = lstTransactions.Items.IndexOf(lstTransactions.SelectedItems(0))
        MsgBox(detailList.SubItems(0).Text)
        If (findItem IsNot Nothing) Then
            lstTransactions.Items.RemoveAt(indexList)
            lstTransactions.Items.Insert(indexList, detailList)
        Else
            lstTransactions.Items.Add(detailList)
        End If


        lstTransactions.Refresh()
    End Sub

    Public Sub refreshListView(updateID As Integer)
        Dim findItem() As ListViewItem
        findItem = lstTransactions.Items.Find(updateID.ToString, False)
      
    End Sub

    Public Sub deleteItemFromList()
        Dim deleteQuery As String

        Try
            cnnOLEDB.Open()

            deleteQuery = "DELETE FROM EEXPEN WHERE ExpenseID = " & deleteId & ""
            ' Dim cmd As New OleDbCommand(deleteQuery, cnnOLEDB)

            cmdOLEDB = New OleDbCommand(deleteQuery, cnnOLEDB)
            cmdOLEDB.ExecuteNonQuery()
            lstTransactions.FocusedItem.Remove()
            lstTransactions.Refresh()
            ' txtId.Text = lstTransactions.FocusedItem.SubItems(0).ToString
            tls_btnDelete.Enabled = False
        Catch ex As Exception
            MessageBox.Show("Select Record to Delete" & ex.Message, "Delete Records")
        Finally
            cnnOLEDB.Close()
        End Try

    End Sub

   
    Private Sub lstTransactions_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles lstTransactions.ItemSelectionChanged
        If e.IsSelected Then
            deleteId = lstTransactions.FocusedItem.SubItems(0).Text
            deleteRecord = lstTransactions.FocusedItem.SubItems(1).Text _
                          + " " + lstTransactions.FocusedItem.SubItems(2).Text _
                          + " " + lstTransactions.FocusedItem.SubItems(3).Text _
                          + " " + lstTransactions.FocusedItem.SubItems(4).Text


            txtId.Text = deleteId
            tls_btnDelete.Enabled = True
            'index to update listview used by updateList
            indexList = lstTransactions.Items.IndexOf(lstTransactions.SelectedItems(0))

        Else
            tls_btnDelete.Enabled = False
        End If
    End Sub

    Private Sub tls_btnDelete_Click(sender As Object, e As EventArgs) Handles tls_btnDelete.Click
        Dim Answer As Integer
        If (deleteId >= 0) Then
            Answer = MsgBox("Confirm Irreversible Deletion?" + vbCrLf + deleteRecord, MsgBoxStyle.YesNo + vbQuestion, "Delete Record")
        Else
            MsgBox("Select Record from the list first", MsgBoxStyle.Information, "Select Record")
        End If


        If (Answer = vbYes And deleteId >= 0) Then
            deleteItemFromList()
            txtId.Text = ""
            deleteId = -1
        End If

    End Sub


    Public Function getId()
        Return txtId.Text
    End Function


    Private Sub tls_btnUpdate_Click(sender As Object, e As EventArgs) Handles tls_btnUpdate.Click
        'Dim frm_Expense As New frm_Egresos(Me)
        'set main form to be parent of frm_expense
        'frm_Expense.MdiParent = frm_Main
        'frm_Expense.Show()
        frmEgresoToFill = New frm_Egresos(Me)
        frmEgresoToFill.MdiParent = frm_Main
        frmEgresoToFill.Show()
        frmEgresoToFill.fillFieldsToUpdate()
        frmEgresoToFill.lblUpdateId.Visible = True
        frmEgresoToFill.tls_btnUpdate.Enabled = True
        frmEgresoToFill.tlsGuardar.Enabled = False
        frmEgresoToFill.tlsNuevo.Enabled = False
    End Sub

End Class