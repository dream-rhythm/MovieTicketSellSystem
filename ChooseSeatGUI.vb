Imports System.Data
Imports System.Data.OleDb
Public Class ChooseSeatGUI
    Dim normal, student, children, older As Integer
    Dim allLabel(14, 25) As Label
    Dim movieData(3) As String
    Dim DB As Object

    Dim seatWidth As Integer = 40
    Dim seatHeight As Integer = 20
    Dim spaceWidth As Integer = 5
    Dim spaceHeight As Integer = 3
    Dim roadWidth As Integer = 25
    Dim roadHeight As Integer = 25


    Private Sub onShow(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        Dim SQLcmd As String = "SELECT seatdata.seatx,seatdata.seaty "
        SQLcmd &= "FROM orderdata INNER JOIN seatdata ON orderdata.orderid = seatdata.orderid "
        SQLcmd &= "WHERE orderdata.movie='" & UserData.getMovieData(MovieDataName.MovieName) & "' and orderdata.time='" & UserData.getMovieData(MovieDataName.MovieTime) & "';"

        btn_submit.Enabled = False
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

        Dim objCmd = New OleDbCommand(SQLcmd, DB)
        Dim drr As OleDbDataReader
        drr = objCmd.ExecuteReader
        Do While drr.Read()
            allLabel(drr.GetInt32(1), drr.GetInt32(0)).BackColor = Color.Red
        Loop

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        GUITool.switchGUI(GUINAME.OrderGUI)
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        GUITool.switchGUI(GUINAME.MainGUI)
    End Sub

    Private Sub onLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        DB = DBTool.connectDB()
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
        Dim needChoose As Integer = lbl_waitChoose.Text
        Dim choosed As Integer = lbl_chooesed.Text
        Dim lbl As Label = sender
        If needChoose <> 0 Then
            If lbl.BackColor = Color.OrangeRed Then
                MsgBox("這個位置已經被選走了")
            ElseIf lbl.BackColor = Color.LightBlue Then
                lbl.BackColor = Color.Orange
                needChoose -= 1
                choosed += 1
            ElseIf lbl.BackColor = Color.Orange Then
                lbl.BackColor = Color.LightBlue
                needChoose += 1
                choosed -= 1
            End If
        ElseIf needChoose = 0 And lbl.BackColor = Color.Orange Then
            lbl.BackColor = Color.LightBlue
            needChoose += 1
            choosed -= 1
        End If

        lbl_chooesed.Text = choosed
        lbl_waitChoose.Text = needChoose

        If needChoose = 0 Then
            btn_submit.Enabled = True
        Else
            btn_submit.Enabled = False
        End If

    End Sub

    Private Sub submit(sender As Object, e As EventArgs) Handles btn_submit.Click
        Dim serialID As Integer
        Dim isStart As Boolean = False

        Dim SQLcmd As String = "Insert into orderdata(`account`,`normal`,`student`,`children`,`older`,`movie`,`time`,`place`)"
        SQLcmd &= String.Format("values('{0}',{1},{2},{3},{4},", getAccount(), getTickerData(TicketName.Normal), getTickerData(TicketName.Student), getTickerData(TicketName.Children), getTickerData(TicketName.Older))
        SQLcmd &= String.Format("'{0}','{1}','{2}');", getMovieData(MovieDataName.MovieName), getMovieData(MovieDataName.MovieTime), getMovieData(MovieDataName.MoviePlace))

        Dim objCmd = New OleDbCommand(SQLcmd, DB)
        objCmd.ExecuteNonQuery()
        objCmd.CommandText = "SELECT @@IDENTITY as ID_NEW;"
        Dim dr = objCmd.ExecuteReader()
        If dr.Read() Then
            serialID = dr.GetInt32(0)
        Else
            MsgBox("購票失敗:無法取得訂單編號")
            Return
        End If
        dr.Close()

        SQLcmd = "Insert into seatdata(`orderid`,`seatx`,`seaty`) values"
        For y As Integer = 0 To 13
            For x As Integer = 0 To 24
                If allLabel(y, x).BackColor = Color.Orange Then
                    If isStart Then
                        SQLcmd &= ","
                    End If
                    SQLcmd &= String.Format("({0},{1},{2})", serialID, x, y)
                    isStart = True
                End If
            Next
        Next
        objCmd.CommandText = SQLcmd & ";"
        If isStart Then
            objCmd.ExecuteNonQuery()
            MsgBox("訂票成功")
            GUITool.switchGUI(GUINAME.MainGUI)
        End If
    End Sub

End Class