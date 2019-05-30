
Imports System.Drawing.Drawing2D
Public Class MainGUI
    Dim btnArr() As Button = {}

    Private Sub onShow(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Module1.getUser() = "" Then
            lbl_login.Text = "登入/註冊"
            setBtnEnable(False)
        Else
            lbl_login.Text = Module1.getUser() & "(登出)"
            setBtnEnable(True)
        End If
    End Sub

    Private Sub onLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        btnArr = {}
        Dim a As New GraphicsPath()
        a.AddEllipse(0, 0, 45, 45)
        PictureBox1.Region = New Region(a)
        PictureBox1.Height = 45
        PictureBox1.Width = 45
        PictureBox1.Image = Module1.getUserPicture()
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.Refresh()
        setBtnEnable(False)
    End Sub

    Private Sub setBtnEnable(ByVal enable As Boolean)
        Button1.Enabled = enable
        Button2.Enabled = enable
        Button3.Enabled = enable
        Button4.Enabled = enable
        Button5.Enabled = enable
        Button6.Enabled = enable
        Button7.Enabled = enable
        Button8.Enabled = enable
        Button9.Enabled = enable
        Button10.Enabled = enable
        Button11.Enabled = enable
        Button12.Enabled = enable
        Button13.Enabled = enable
        Button14.Enabled = enable
        Button15.Enabled = enable
        Button16.Enabled = enable
        Button17.Enabled = enable
        Button18.Enabled = enable
        Button19.Enabled = enable
        Button20.Enabled = enable
    End Sub

    Private Sub timeBtnClicked(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click,
                                                                            Button5.Click, Button6.Click, Button7.Click, Button8.Click,
                                                                            Button9.Click, Button10.Click, Button11.Click, Button12.Click,
                                                                            Button13.Click, Button14.Click, Button15.Click, Button16.Click,
                                                                            Button17.Click, Button18.Click, Button19.Click, Button20.Click
        Dim btn As Button = sender
        Dim movName As String = btn.Tag.Split(",")(0)
        Dim movPlace As String = btn.Tag.Split(",")(1)
        Module1.setMovieData(movName, btn.Text, movPlace)
        Module1.switchGUI(Module1.GUINAME.OrderGUI)
    End Sub

    Private Sub lbl_login_Click(sender As Object, e As EventArgs) Handles lbl_login.Click
        If lbl_login.Text = "登入/註冊" Then
            Module1.switchGUI(GUINAME.LoginGUI)
            Me.Hide()
        Else
            lbl_login.Text = "登入/註冊"
            Module1.logout()
            setBtnEnable(False)
            PictureBox1.Image = Image.FromFile("../../Image/NotLogin.png")
        End If
    End Sub
End Class
