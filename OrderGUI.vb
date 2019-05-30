Public Class OrderGUI
    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub onShow(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        Dim movieData() As String = Module1.getMovieData()
        If movieData(0) = "mov01" Then
            lbl_name.Text = "復活的魯路修"
        ElseIf movieData(0) = "mov02" Then
            lbl_name.Text = "哥吉拉 II 怪獸之王"
        ElseIf movieData(0) = "mov03" Then
            lbl_name.Text = "狗狗的旅程"
        Else
            lbl_name.Text = "五月天 人生無限公司"
        End If
        lbl_time.Text = movieData(1)
        lbl_place.Text = movieData(2)

    End Sub

    Private Sub Ticket_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged, NumericUpDown2.ValueChanged, NumericUpDown3.ValueChanged, NumericUpDown4.ValueChanged
        Dim total As Integer = 0
        total += NumericUpDown1.Value * 230
        total += NumericUpDown2.Value * 200
        total += NumericUpDown3.Value * 150
        total += NumericUpDown4.Value * 150
        lbl_total.Text = total
    End Sub

    Private Sub countMoney()
        Dim pay As Integer = inp_paycash.Text

    End Sub

    Private Sub rdb_payment_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_cash.CheckedChanged, rdb_MagicCard.CheckedChanged
        Dim rdb As RadioButton = sender
        GB_cash.Enabled = rdb_cash.Checked
    End Sub

    Private Sub inp_checkNumberic(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles inp_paycash.KeyPress
        '48 - 57  = Ascii codes for numbers
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
        End If
    End Sub

    Private Sub inp_paycash_TextChanged(sender As Object, e As EventArgs) Handles inp_paycash.TextChanged
        Dim needToPay As Integer = lbl_total.Text
        Dim payCash As Integer = inp_paycash.Text
        If payCash > needToPay Then

        End If
    End Sub
End Class