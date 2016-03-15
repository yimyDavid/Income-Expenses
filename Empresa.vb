
Public Class frm_Empresa
    Private dbAccess As New DBControl

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

        ' Fill ListView
        For Each R As DataRow In dbAccess.DBDT.Rows
            Dim new_row As New ListViewItem(R("CompanyID").ToString)
            new_row.SubItems.Add(R("Description").ToString)
            lstData.Items.Add(new_row)
        Next

    End Sub
End Class