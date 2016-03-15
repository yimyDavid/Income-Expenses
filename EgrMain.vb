
Public Class IngMain
    Private dbAccess As New DBControl

  

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

    Private Sub fillList()
        dbAccess.ExecQuery("SELECT EEXPEN.ExpenseID, EEXPEN.ExpDate, EACCNT.Description, EEXPEN.Amount, ECOMP.Description " & _
                           "FROM (EEXPEN INNER JOIN EACCNT ON EEXPEN.AccountID = EACCNT.AccountID) " & _
                           "INNER JOIN ECOMP ON EEXPEN.CompanyID = ECOMP.CompanyID; ")

        ' This will make the following to execute if it fails to access the db.
        If Not String.IsNullOrEmpty(dbAccess.Exception) Then MsgBox(dbAccess.Exception) : Exit Sub


        For Each R As DataRow In dbAccess.DBDT.Rows
            Dim new_row As New ListViewItem(R("ExpenseID").ToString)
            new_row.SubItems.Add(Format(R("ExpDate"), "MM/dd/yyyy"))
            new_row.SubItems.Add(R("EACCNT.Description").ToString)
            new_row.SubItems.Add(Format(R("Amount"), "###,###.00"))

            new_row.SubItems.Add(R("ECOMP.Description").ToString)
            lstTransactions.Items.Add(new_row)
        Next

    End Sub


    Private Sub IngMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        fillList()
       
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


    Private Sub deleteItemFromList()

        dbAccess.AddParam("@deleteId", deleteId)
        dbAccess.ExecQuery("DELETE FROM EEXPEN WHERE ExpenseID = @deleteId; ")

        ' This will make the following to execute if it fails to access the db.
        If Not String.IsNullOrEmpty(dbAccess.Exception) Then MsgBox(dbAccess.Exception) : Exit Sub
      
        lstTransactions.FocusedItem.Remove()
        lstTransactions.Refresh()

        tls_btnDelete.Enabled = False

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
            txtId.Text = ""
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

    Public Function getId() As String
        Return txtId.Text
    End Function


    Private Sub tls_btnUpdate_Click(sender As Object, e As EventArgs) Handles tls_btnUpdate.Click
        frmEgresoToFill = New frm_Egresos(Me)
        frmEgresoToFill.MdiParent = frm_Main
        If (txtId.Text = "") Then
            MsgBox("Select a Row/Record first", MsgBoxStyle.Information, "Select Record")
        Else
            frmEgresoToFill.Show()
            frmEgresoToFill.fillFieldsToUpdate()
            frmEgresoToFill.lblUpdateId.Visible = True
            frmEgresoToFill.tls_btnUpdate.Enabled = True
            frmEgresoToFill.tlsGuardar.Enabled = False
            frmEgresoToFill.tlsNuevo.Enabled = False
        End If
       
    End Sub

   
End Class