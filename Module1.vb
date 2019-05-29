Module Module1
    Dim main As MainGUI = New MainGUI()
    Dim login As LoginGUI = New LoginGUI()
    Dim username As String = ""
    Dim sex As String = "?"

    Enum GUINAME As Integer
        MainGUI = 0
        LoginGUI = 1
    End Enum

    Public Sub setuser(ByVal name As String, ByVal usersex As String)
        username = name
        sex = usersex
    End Sub

    Public Function getUser()
        Return username
    End Function

    Public Function getUserPicture()
        If sex = "B" Then
            Return Image.FromFile("../../Image/Boy.png")
        ElseIf sex = "G" Then
            Return Image.FromFile("../../Image/Girl.png")
        Else
            Return Image.FromFile("../../Image/NotLogin.png")
        End If
    End Function

    Public Sub logout()
        setuser("", "?")
    End Sub


    Public Sub switchGUI(ByVal guiname As GUINAME)
        main.Hide()
        login.Hide()
        Select Case guiname
            Case GUINAME.MainGUI
                main.Show()
            Case GUINAME.LoginGUI
                login.Show()
            Case Else
                Throw New ApplicationException("GUI is invalid: " & guiname.ToString)
        End Select
    End Sub
End Module
