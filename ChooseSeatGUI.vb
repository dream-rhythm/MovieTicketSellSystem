Public Class ChooseSeatGUI
    Dim normal, student, children, older As Integer
    Dim allLabel(14, 25) As Label
    Dim movieData(3) As String

    Dim seatWidth As Integer = 40
    Dim seatHeight As Integer = 20
    Dim spaceWidth As Integer = 5
    Dim spaceHeight As Integer = 3
    Dim roadWidth As Integer = 25

    Dim roadHeight As Integer = 25


    Private Sub onShow(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        normal = UserData.getTickerData(TicketName.Normal)
        student = UserData.getTickerData(TicketName.Student)
        children = UserData.getTickerData(TicketName.Children)
        older = UserData.getTickerData(TicketName.Older)
        lbl_waitChoose.Text = normal + student + children + older
        lbl_chooesed.Text = 0
        lbl_name.Text = UserData.getMovieData(MovieDataName.MovieName)
        lbl_time.Text = UserData.getMovieData(MovieDataName.MovieTime)
        lbl_place.Text = UserData.getMovieData(MovieDataName.MoviePlace)
        For y As Integer = 0 To 13
            For x As Integer = 0 To 24
                allLabel(y, x).BackColor = Color.LightBlue
            Next
        Next
    End Sub

    Private Sub onLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim xPoint, yPoint As Integer
        For y As Integer = 0 To 13
            yPoint = y * (seatHeight + spaceHeight) + 169
            If y > 5 Then
                yPoint += roadHeight
            End If
            For x As Integer = 0 To 24
                allLabel(y, x) = New Label
                allLabel(y, x).Width = seatWidth
                allLabel(y, x).Height = seatHeight
                allLabel(y, x).Text = Chr(y + Asc("A")) & Format(x, "00")
                allLabel(y, x).Tag = Chr(y + Asc("A")) & Format(x, "00")
                allLabel(y, x).Font = New Font("Consolas", 14, allLabel(y, x).Font.Style)
                AddHandler allLabel(y, x).Click, AddressOf onLblClick
                xPoint = x * (seatWidth + spaceWidth) + 39
                If x > 7 Then
                    xPoint += roadWidth
                End If
                If x > 18 Then
                    xPoint += roadWidth
                End If
                allLabel(y, x).Location = New Point(xPoint, yPoint)
                Me.Controls.Add(allLabel(y, x))
                allLabel(y, x).Show()
            Next
        Next
    End Sub

    Private Sub onLblClick(sender As Object, e As EventArgs)
        Dim lbl As Label = sender
        If lbl.BackColor = Color.OrangeRed Then
            MsgBox("這個位置已經被選走了")
        Else
            lbl.BackColor = Color.Orange
        End If
    End Sub

    Private Sub submit(sender As Object, e As EventArgs) Handles btn_submit.Click

    End Sub

End Class