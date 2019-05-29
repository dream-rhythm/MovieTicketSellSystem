
Imports System.Drawing.Drawing2D
Public Class MainGUI



    Private Sub onShow(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged, MyBase.Load
        Dim a As New GraphicsPath()
        a.AddEllipse(0, 0, 45, 45)
        PictureBox1.Region = New Region(a)
        PictureBox1.Height = 45
        PictureBox1.Width = 45
        PictureBox1.Image = Module1.getUserPicture()
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.Refresh()
        If Module1.getUser() = "" Then
            lbl_login.Text = "登入/註冊"
        Else
            lbl_login.Text = Module1.getUser() & "(登出)"
        End If
    End Sub

    Private Sub lbl_login_Click(sender As Object, e As EventArgs) Handles lbl_login.Click
        If lbl_login.Text = "登入/註冊" Then
            Module1.switchGUI(GUINAME.LoginGUI)
            Me.Hide()
        Else
            lbl_login.Text = "登入/註冊"
            Module1.logout()
            PictureBox1.Image = Image.FromFile("../../Image/NotLogin.png")
        End If
    End Sub
End Class
