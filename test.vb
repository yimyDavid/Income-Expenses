
Public Class test
    Private access As New DBControl
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        addCategory()
    End Sub

    Private Sub addCategory()
        access.AddParam("@name", txtName.Text)
        access.AddParam("@number", txtNumber.Text)

        access.ExecQuery("INSERT INTO EACCNT (Description, typeID) " & _
                         "VALUES (@name, @number); ")

        If Not String.IsNullOrEmpty(access.Exception) Then MsgBox(access.Exception) : Exit Sub

        MsgBox("Saved Successfully")
    End Sub
End Class