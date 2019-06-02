Module GUITool
    Dim main As MainGUI = New MainGUI()
    Dim login As LoginGUI = New LoginGUI()
    Dim order As OrderGUI = New OrderGUI()
    Dim signup As SignupGUI = New SignupGUI()
    Dim chooseseat As ChooseSeatGUI = New ChooseSeatGUI()

    Enum GUINAME As Integer
        MainGUI = 0
        LoginGUI = 1
        OrderGUI = 2
        SignupGUI = 3
        ChooseSeatGUI = 4
    End Enum

    Public Sub switchGUI(ByVal guiname As GUINAME)
        main.Hide()
        login.Hide()
        order.Hide()
        signup.Hide()
        chooseseat.Hide()
        Select Case guiname
            Case GUINAME.MainGUI
                main.Show()
            Case GUINAME.LoginGUI
                login.Show()
            Case GUINAME.OrderGUI
                order.Show()
            Case GUINAME.SignupGUI
                signup.Show()
            Case GUINAME.ChooseSeatGUI
                chooseseat.Show()
            Case Else
                Throw New ApplicationException("GUI is invalid: " & guiname.ToString)
        End Select
    End Sub

End Module
