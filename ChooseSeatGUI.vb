Public Class ChooseSeatGUI
    Dim normal, student, children, older As Integer
    Dim movieData(3) As String
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
    End Sub

End Class