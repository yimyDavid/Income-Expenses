Imports System.Data.OleDb
Public Class DBControl
    Private DBCon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" & _
                                         "Data Source=|DataDirectory|\Expenses.accdb;")
    ' Prepare DB Command
    Private DBCmd As OleDbCommand

    ' DB Data
    Public DBDA As OleDbDataAdapter
    Public DBDT As DataTable

    ' Query Parameters
    Public Params As New List(Of OleDbParameter)

    ' Query Statistics
    Public RecordCount As Integer
    Public Exception As String

    Public Sub ExecQuery(Query As String)
        ' Reset Query Statistics
        RecordCount = 0
        Exception = ""

        Try
            ' Open a Connection
            DBCon.Open()

            ' Create Database Command
            DBCmd = New OleDbCommand(Query, DBCon)

            ' Load Params into DB Command
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))
            ' Does the same thing but differently
            'For Each p As OleDbParameter In Params
            'DBCmd.Parameters.Add(p)
            'Next

            ' Clear params List
            Params.Clear()

            ' Execute Command and fill DataTable
            DBDT = New DataTable
            DBDA = New OleDbDataAdapter(DBCmd)

            'pipes data into dataTable
            RecordCount = DBDA.Fill(DBDT)
        Catch ex As Exception
            Exception = ex.Message
        End Try

        ' Close this connection
        If (DBCon.State = ConnectionState.Open) Then DBCon.Close()
    End Sub

    ' Include Query and Command Parameters
    Public Sub AddParam(Name As String, value As Object)
        Dim newParam As New OleDbParameter(Name, value)
        Params.Add(newParam)
    End Sub
End Class
