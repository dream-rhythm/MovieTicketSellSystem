Imports System.Data
Imports System.Data.OleDb

Public Class LoginGUI
    Dim DB As OleDbConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim success As Boolean = False
        Dim SQLcmd As String
        'SQL查詢指令
        SQLcmd = "SELECT username,sex FROM account where account='" & inp_acc.Text & "' and password='" & inp_pwd.Text & "';"
        Dim objCmd = New OleDbCommand(SQLcmd, DB)
        Dim drr As OleDbDataReader
        drr = objCmd.ExecuteReader
        Do While drr.Read()
            Module1.setuser(drr.Item("username"), drr.Item("sex"))
            success = True
        Loop

        If success Then
            Me.Hide()
            Label3.Visible = False
            Module1.switchGUI(Module1.GUINAME.MainGUI)
        Else
            Label3.Visible = True
        End If
    End Sub

    Private Sub LoginGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DB = DBTool.connectDB()
    End Sub
End Class