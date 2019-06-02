Module UserData

    Dim username As String = ""
    Dim sex As String = "?"
    Dim movData(3) As String
    Dim ticketData(4) As Integer
    Dim movieName() As String = {"復活的魯路修", "哥吉拉 II 怪獸之王", "狗狗的旅程", "五月天 人生無限公司"}

    Enum TicketName As Integer
        Normal = 0
        Student = 1
        Children = 2
        Older = 3
    End Enum

    Enum MovieDataName As Integer
        MovieName = 0
        MovieTime = 1
        MoviePlace = 2
    End Enum

    Public Sub setMovieData(ByVal name As String, ByVal time As String, ByVal place As String)
        If name = "mov01" Then
            name = movieName(0)
        ElseIf name = "mov02" Then
            name = movieName(1)
        ElseIf name = "mov03" Then
            name = movieName(2)
        Else
            name = movieName(3)
        End If
        movData(MovieDataName.MovieName) = name
        movData(MovieDataName.MovieTime) = time
        movData(MovieDataName.MoviePlace) = place
    End Sub

    Public Function getMovieData(ByVal dataType As MovieDataName)
        Return movData(dataType)
    End Function

    Public Sub setTicketData(ByVal normal As Integer, ByVal student As Integer, ByVal children As Integer, ByVal older As Integer)
        ticketData(TicketName.Normal) = normal
        ticketData(TicketName.Student) = student
        ticketData(TicketName.Children) = children
        ticketData(TicketName.Older) = older
    End Sub

    Public Function getTickerData(ByVal ticketType As TicketName)
        Return ticketData(ticketType)
    End Function

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

End Module
