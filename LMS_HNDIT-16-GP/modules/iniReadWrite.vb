Module iniReadWrite

    'ini read write module - redesigned by hndit/2016
    'original code from stackoverflow
 



    Private Declare Ansi Function GetPrivateProfileString Lib "kernel32.dll" Alias "GetPrivateProfileStringA" _
        (ByVal lpApplicationName As String, _
         ByVal lpKeyName As String, _
         ByVal lpDefault As String, _
         ByVal lpReturnedString As System.Text.StringBuilder, _
         ByVal nSize As Integer, _
         ByVal lpFileName As String) _
     As Integer

    Private Declare Ansi Function WritePrivateProfileString Lib "kernel32.dll" Alias "WritePrivateProfileStringA" _
        (ByVal lpApplicationName As String, _
         ByVal lpKeyName As String, _
         ByVal lpString As String, _
         ByVal lpFileName As String) _
    As Integer

  
    
    Public Function InIReadValue(ByVal section As String, ByVal key As String, _Path As String) As String
        On Error Resume Next

        Dim sb As New System.Text.StringBuilder(255)
        Dim i As Integer = GetPrivateProfileString(section, key, "", sb, 255, _Path)
        Return sb.ToString()




    End Function

    Public Sub InIWriteValue(ByVal section As String, ByVal key As String, ByVal value As String, _Path As String)
        Try
            WritePrivateProfileString(section, key, value, _Path)
        Catch ex As Exception


        End Try

    End Sub






End Module
