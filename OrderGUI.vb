Public Class OrderGUI
    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub onShow(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        lbl_name.Text = UserData.getMovieData(MovieDataName.MovieName)
        lbl_time.Text = UserData.getMovieData(MovieDataName.MovieTime)
        lbl_place.Text = UserData.getMovieData(MovieDataName.MoviePlace)
        countMoney()
    End Sub

    Private Sub Ticket_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged, NumericUpDown2.ValueChanged, NumericUpDown3.ValueChanged, NumericUpDown4.ValueChanged
        Dim total As Integer = 0
        total += NumericUpDown1.Value * 230
        total += NumericUpDown2.Value * 200
        total += NumericUpDown3.Value * 150
        total += NumericUpDown4.Value * 150
        lbl_total.Text = total
        countMoney()
    End Sub

    Private Sub countMoney()
        Dim needToPay As Integer = lbl_total.Text
        Dim payCash As Integer = inp_paycash.Text

        If rdb_cash.Checked Then
            If payCash > needToPay Then
                btn_next.Enabled = True
            Else
                btn_next.Enabled = False
            End If
        Else
            btn_next.Enabled = True
        End If

        If payCash > needToPay Then
            payCash -= needToPay
            setCash(lbl_500, payCash, 500)
            setCash(lbl_100, payCash, 100)
            setCash(lbl_50, payCash, 50)
            setCash(lbl_10, payCash, 10)
            setCash(lbl_5, payCash, 5)
            setCash(lbl_1, payCash, 1)
        End If

        If lbl_total.Text = 0 Then
            btn_next.Enabled = False
        End If

    End Sub

    Private Sub rdb_payment_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_cash.CheckedChanged, rdb_MagicCard.CheckedChanged
        Dim rdb As RadioButton = sender
        GB_cash.Enabled = rdb_cash.Checked
        Try
            countMoney()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub inp_checkNumberic(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles inp_paycash.KeyPress
        '48 - 57  = Ascii codes for numbers
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
        End If
    End Sub

    Private Sub inp_paycash_TextChanged(sender As Object, e As EventArgs) Handles inp_paycash.TextChanged
        countMoney()
    End Sub

    Private Sub setCash(ByRef lbl As Label, ByRef left As Integer, ByVal money As Integer)
        lbl.Text = left \ money
        left = left Mod money
    End Sub

    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click
        Dim normal As Integer = NumericUpDown1.Value
        Dim student As Integer = NumericUpDown2.Value
        Dim children As Integer = NumericUpDown3.Value
        Dim older As Integer = NumericUpDown4.Value
        UserData.setTicketData(normal, student, children, older)
        GUITool.switchGUI(GUINAME.ChooseSeatGUI)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        GUITool.switchGUI(GUINAME.MainGUI)
    End Sub
End Class