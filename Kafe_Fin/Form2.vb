Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles proceed_but.Click

        Dim Total As Integer
        Dim vat, tprice As Single

        For Each Str As String In ListBox2.Items
            Total += CInt(Str)
        Next

        vat = Total * 0.12
        tprice = Total + vat

        vat12.Text = vat
        totals.Text = tprice


    End Sub

    Private Sub paid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles paid.KeyPress
        change.Text = Val(paid.Text) - Val(totals.Text)
    End Sub

    Private Sub done_but_Click(sender As Object, e As EventArgs) Handles done_but.Click
        Dim Totalp As Integer

        For Each Str As String In ListBox2.Items
            Totalp += CInt(Str)
        Next

        MsgBox("KAFE NAYON" & vbCrLf & "Tanauan City, Batangas" & vbCrLf & "Date: " & My.Computer.Clock.LocalTime & vbCrLf & vbCrLf & "Price:" & vbTab & vbTab & Totalp & vbCrLf & "VAT:" & vbTab & vbTab & Val(vat12.Text) & vbCrLf & "Total:" & vbTab & vbTab & Val(totals.Text) & vbCrLf & "Paid:" & vbTab & vbTab & Val(paid.Text) & vbCrLf & "Change:" & vbTab & vbTab & Val(change.Text))
        Me.Close()
        Form1.Close()
    End Sub

    Private Sub repeat_but_Click(sender As Object, e As EventArgs) Handles repeat_but.Click
        orders.Items.Clear()
        ListBox2.Items.Clear()
        totals.Text = ""
        paid.Text = ""
        change.Text = ""
        Me.Hide()
        Form1.Show()

        For Each ctl In Form1.Controls
            If TypeOf ctl Is TextBox Then ctl.Text = ""
        Next ctl
    End Sub
End Class