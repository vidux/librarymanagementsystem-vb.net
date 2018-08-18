Module publicCodes
    '<public veriables>

    Public fromMainPanel As Boolean = False
    Public IniPath As String = Application.StartupPath & "\settings.ini"


    '</public veriables>




    'simple encript decrript text by hndit/2016









    Public Function encriptedText(textdata As String) As String



        Dim datak As Byte()
        datak = System.Text.ASCIIEncoding.ASCII.GetBytes(textdata)
        Dim d As String = System.Convert.ToBase64String(datak)

        Return d
    End Function


    Public Function decriptedText(textdata As String) As String

        Dim data() As Byte
        data = System.Convert.FromBase64String(textdata)

        Dim d As String = System.Text.ASCIIEncoding.ASCII.GetString(data)
        Return d
    End Function




End Module
