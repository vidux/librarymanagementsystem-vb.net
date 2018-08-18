Module SQLcmdSender
    ' this is the module of SQL command sending to the data base.
    ' coded by DEH/HNDIT/2016 V1br2t3
    ' errors not handled by this module . you should put 'addrow' command in try catch block to handle them
    'set the connection string  text to constr 
    ' addrow command not only for add rows.. it send any sql command in command text  
    Private Const connstr As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\LibraryData.mdb;Persist Security Info=True;Jet OLEDB:Database Password=wasd"




    Public Sub Addrow(comm As String)

        Dim bname As String
        bname = comm
        Dim cnn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand

        cnn.ConnectionString = connstr
        cnn.Open()
        cmd.Connection = cnn
        cmd.CommandText = comm
        cmd.ExecuteNonQuery()
        cnn.Close()


    End Sub

    Public Function Getsqlvalue(comm As String) As String
        Dim cnn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim res As String = ""
        cnn.ConnectionString = connstr
        
        cnn.Open()

        cmd = New OleDb.OleDbCommand(comm, cnn)

        Return cmd.ExecuteScalar()
        
    End Function






End Module
