Imports System.Data.OleDb

    Public Class frm_Empresa
    Dim cnnOLEDB As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Expenses.accdb;")
    Dim cmdOLEDB As New OleDbCommand
    Dim cmdInsert As New OleDbCommand
        Private Sub frm_Empresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnnOLEDB.Open()
        Dim cmd As New OleDbCommand("SELECT * FROM ECOMP", cnnOLEDB)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        Dim dtTable As DataTable = New DataTable()
        dtTable.Columns.Add("ID", GetType(Integer))
        dtTable.Columns.Add("Description", GetType(String))

        While dr.Read
            Dim new_item As New ListViewItem(dr.Item("CompanyID").ToString)
            new_item.SubItems.Add(dr.Item("Description").ToString)
            lstData.Items.Add(new_item)
        End While

        dr.Close()
        cnnOLEDB.Close()
        End Sub

    Private Sub tlsGuardar_Click(sender As Object, e As EventArgs) Handles tlsGuardar.Click
        Dim InsertQuery As String


        Dim companyName As String
        Dim auto_increment As Integer

        'If there are empty required fields don't do anything
        If (Not txtCompany.Text = "") Then
            cnnOLEDB.Open()
            'Variables to insert to database
            companyName = txtCompany.Text

            'Adding Record to listview
            '  Dim new_item As New ListViewItem(.Text)


            'Most examples have the following statement
            'cmd.Parameters.AddWithValue("@id", 1) but it didn't work for me sofar I decided to do 
            'the following

            InsertQuery = "INSERT INTO [ECOMP] ([Description]) VALUES (" & "'" & companyName & "'" & ")"
            Dim cmd As OleDbCommand = New OleDbCommand(InsertQuery, cnnOLEDB)

            cmdOLEDB = New OleDbCommand(InsertQuery, cnnOLEDB)
            cmdOLEDB.ExecuteNonQuery()
            cmd.CommandText = "SELECT @@identity"
            auto_increment = cmd.ExecuteScalar()
            cnnOLEDB.Close()
            lstData.Items.Add(New ListViewItem(New String() {auto_increment.ToString, companyName}))
            'Me.Refresh()

            MsgBox("Entity Saved!", MsgBoxStyle.Information, "Saved")
            MsgBox(auto_increment)


            txtCompany.Text = ""
            txtCompany.Focus()

        Else
            MsgBox("Fill the Required Fields before Saving!", MsgBoxStyle.Critical, "Empty Required Fields")
        End If

    End Sub


End Class