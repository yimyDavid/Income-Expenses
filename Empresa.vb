
Public Class frm_Empresa
    Private dbAccess As New DBControl
    Private entityId As String = -1
    Private selectItemList As String

    Private Sub frm_Empresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillList()
    End Sub

    Private Sub tlsGuardar_Click(sender As Object, e As EventArgs) Handles tlsGuardar.Click

        'If there are empty required fields don't do anything
        If (Not txtCompany.Text = "") Then

            addEntity()
            'add new inserted row to list view. I didn't want to retrieve the data to refresh the
            'listview.
            lstData.Items.Add(New ListViewItem(New String() {dbAccess.auto_increment_value, txtCompany.Text}))

            clearFields()

        Else
            MsgBox("Fill the Required Fields before Saving!", MsgBoxStyle.Critical, "Empty Required Field/s")
        End If

    End Sub

    Private Sub clearFields()
        txtCompany.Text = ""
        txtCompany.Focus()
    End Sub

    Private Sub addEntity()
        dbAccess.AddParam("@name", txtCompany.Text)

        dbAccess.ExecQuery("INSERT INTO ECOMP (Description) VALUES (@name); ")

        If Not String.IsNullOrEmpty(dbAccess.Exception) Then MsgBox(dbAccess.Exception) : Exit Sub

        MsgBox("Saved Successfully")

    End Sub

    Private Sub fillList()
        dbAccess.ExecQuery("SELECT * FROM ECOMP; ")

        If Not String.IsNullOrEmpty(dbAccess.Exception) Then MsgBox(dbAccess.Exception) : Exit Sub
        ' Fill ListView
        For Each R As DataRow In dbAccess.DBDT.Rows
            Dim new_row As New ListViewItem(R("CompanyID").ToString)
            new_row.SubItems.Add(R("Description").ToString)
            new_row.SubItems.Add(R("CompanyID").ToString)
            lstData.Items.Add(new_row)
        Next

    End Sub
    Private Sub deleteRecord()
        dbAccess.AddParam("@entityId", entityId)

        dbAccess.ExecQuery("DELETE FROM ECOMP WHERE CompanyID = @entityId; ")

        ' This will make the following to execute if it fails to access the db.
        If Not String.IsNullOrEmpty(dbAccess.Exception) Then MsgBox(dbAccess.Exception) : Exit Sub
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim Answer As Integer
        If (entityId >= 0) Then
            Answer = MsgBox("All Records Associated with this Entity (" + entityId + ") also be Deleted" + vbCrLf + _
                            "Would you like to Continue?", MsgBoxStyle.YesNo + vbExclamation, "Delete Record")
        Else
            MsgBox("Select Record from the list first", MsgBoxStyle.Information, "Select Record")
        End If

        If (Answer = vbYes And entityId >= 0) Then
            deleteRecord()
            lstData.Items.RemoveAt(selectItemList)
            entityId = -1
        End If

    End Sub

    Private Sub lstData_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles lstData.ItemSelectionChanged
        If e.IsSelected Then
            entityId = lstData.FocusedItem.SubItems(2).Text
            selectItemList = lstData.FocusedItem.Index
        End If
    End Sub
End Class