Imports System.Data.OleDb
Public Class SignupGUI
    Private Sub SignupGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbb_sex.Items.AddRange({"男", "女"})
    End Sub
    Private Sub init(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        inp_acc.Text = ""
        inp_name.Text = ""
        inp_pwd.Text = ""
        inp_pwd2.Text = ""
        cbb_sex.SelectedIndex = 0
    End Sub

    Private Sub submit(sender As Object, e As EventArgs) Handles btn_submit.Click
        Dim DB = DBTool.connectDB()
        If check(DB) Then
            MsgBox("這個帳號已經被使用過了")
        Else
            If inp_pwd.Text = inp_pwd2.Text And inp_pwd.Text.Length > 5 And inp_acc.Text.Length <> 0 And inp_name.Text.Length <> 0 Then
                writeToDB(DB)
                MsgBox("註冊成功，請重新登入")
                Module1.switchGUI(GUINAME.LoginGUI)
            ElseIf inp_acc.Text.Length = 0 Or inp_name.Text.Length = 0 Or inp_pwd.Text.Length = 0 Then
                MsgBox("有未完成的項目")
            ElseIf inp_pwd.Text.Length < 6 Then
                MsgBox("密碼要6個字以上唷")
            Else
                MsgBox("兩次密碼不同唷!")
            End If

        End If
    End Sub

    Private Function check(ByRef DB)
        'SQL查詢指令
        Dim sSQL = "SELECT account FROM account where account='" & inp_acc.Text & "';"
        Dim find As Boolean = False
        Dim objCmd = New OleDbCommand(sSQL, DB)
        Dim drr As OleDbDataReader
        drr = objCmd.ExecuteReader
        Do While drr.Read()
            find = True
        Loop
        Return find
    End Function

    Private Sub writeToDB(ByRef DB)
        Dim acc = inp_acc.Text
        Dim pwd = inp_pwd.Text
        Dim name = inp_name.Text
        Dim sex = cbb_sex.SelectedItem.ToString

        If sex = "男" Then
            sex = "B"
        Else
            sex = "G"
        End If

        Dim sSQL = "insert into account(`account`,`password`,`username`,`sex`) values('" & acc & "','" & pwd & "','" & name & "','" & sex & "')"
        Dim find As Boolean = False
        Dim objCmd = New OleDbCommand(sSQL, DB)
        objCmd.ExecuteNonQuery()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Module1.switchGUI(GUINAME.LoginGUI)
    End Sub
End Class