Imports System.Data.OleDb

Public Class frm_Ingreso

    Dim cnnOLEDB As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Expenses.accdb;")
    Dim cmdOLEDB As New OleDbCommand
    Dim cmdInsert As New OleDbCommand
    Dim cmdUpdate As New OleDbCommand
    Dim cmdDelete As New OleDbCommand


   
    Private Sub ts_btnSave_Click(sender As Object, e As EventArgs) Handles ts_btnSave.Click
        Dim InsertQuery As String


        Dim incDate As String
        Dim companyId As Integer
        Dim accountId As Integer
        Dim income As Integer
        Dim comments As String

        'If there are empty required fields don't to anything
        If (checkRequiredFields() = True) Then
            cnnOLEDB.Open()
            'Variables to insert to database
            incDate = txtDate.Text
            companyId = Convert.ToInt32(txtCompanyId.Text)
            accountId = Convert.ToInt32(txtAccId.Text)
            income = Convert.ToDouble(txtAmount.Text)
            comments = txtComments.Text
            'Most examples have the following statement
            'cmd.Parameters.AddWithValue("@id", 1) but it didn't work for me sofar I decided to do 
            'the following

            InsertQuery = "INSERT INTO [ERCRD] ([IncDate],[CompanyID],[AccountID],[Income],[Comments]) VALUES (" & "'" & incDate & "'" & "," & companyId & "," & accountId & "," & income & "," & "'" & comments & "'" & ")"
            'Dim cmd As OleDbCommand = New OleDbCommand(InsertQuery, cnnOLEDB)


            cmdOLEDB = New OleDbCommand(InsertQuery, cnnOLEDB)
            cmdOLEDB.ExecuteNonQuery()
            cnnOLEDB.Close()

            MsgBox("Transaction Saved!", MsgBoxStyle.Information, "Saved")

            clearFields()
            txtDate.Focus()

        Else
            MsgBox("Fill the Required Fields before Saving!", MsgBoxStyle.Critical, "Empty Required Fields")
        End If


    End Sub


    Private Function checkRequiredFields()
        Dim empty As Boolean
        If ((txtDate.Text = "") Or
            (txtCompanyId.Text = "") Or
            (txtAccId.Text = "") Or
            (txtAmount.Text = "")) Then
            empty = False
            Return empty
        End If
        Return True
    End Function

    Private Sub clearFields()
        txtDate.Text = ""
        txtCompanyId.Text = ""
        txtAccId.Text = ""
        txtAmount.Text = ""
        txtComments.Text = ""
    End Sub

    Private Sub ts_btnNew_Click(sender As Object, e As EventArgs) Handles ts_btnNew.Click
        clearFields()
    End Sub

    Private Sub frm_Ingreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Objective: Fill comboboxes from 
    End Sub
End Class