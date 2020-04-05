Module mdlDatabase

    Public Function GetConnection() As SqlClient.SqlConnection
        Dim cn As New SqlClient.SqlConnection
        cn.ConnectionString = My.Settings.BPESCnString
        cn.Open()
        GetConnection = cn
    End Function

End Module
