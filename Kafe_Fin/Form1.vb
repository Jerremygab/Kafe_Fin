Imports System.Windows
Imports System.Windows.Forms.DataFormats
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ListView1.View = View.Details
    End Sub
    Private Sub C_But1_Click(sender As Object, e As EventArgs) Handles C_But1.Click
        Dim qty, price As Integer
        Dim label As String
        qty = C_Txt1.Text
        label = Coffee1.Text

        If C_Rad1.Checked Then
            price = qty * Val(C_Price1.Text)
            Dim otherItems As String() = {"Hot " & label, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If C_Rad2.Checked Then
            price = qty * Val(C_Price1.Text)
            Dim otherItems As String() = {"Iced " & label, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If


    End Sub

    Private Sub C_But2_Click(sender As Object, e As EventArgs) Handles C_But2.Click
        Dim qty, price As Integer
        Dim label As String
        qty = C_Txt2.Text
        label = Coffee2.Text

        If C_Rad3.Checked Then
            price = qty * Val(C_Price2.Text)
            Dim otherItems As String() = {"Hot " & label, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If C_Rad4.Checked Then
            price = qty * Val(C_Price2.Text)
            Dim otherItems As String() = {"Iced " & label, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub

    Private Sub C_But3_Click(sender As Object, e As EventArgs) Handles C_But3.Click
        Dim qty, price As Integer
        Dim label As String
        qty = C_Txt3.Text
        label = Coffee3.Text

        If C_Rad5.Checked Then
            price = qty * Val(C_Price3.Text)
            Dim otherItems As String() = {"Hot " & label, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If C_Rad6.Checked Then
            price = qty * Val(C_Price3.Text)
            Dim otherItems As String() = {"Iced " & label, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub

    Private Sub C_But4_Click(sender As Object, e As EventArgs) Handles C_But4.Click
        Dim qty, price As Integer
        Dim label As String
        qty = C_Txt4.Text
        label = Coffee4.Text

        If C_Rad7.Checked Then
            price = qty * Val(C_Price4.Text)
            Dim otherItems As String() = {"Hot " & label, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If C_Rad8.Checked Then
            price = qty * Val(C_Price4.Text)
            Dim otherItems As String() = {"Iced " & label, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub

    Private Sub C_But5_Click(sender As Object, e As EventArgs) Handles C_But5.Click
        Dim qty, price As Integer
        Dim label As String
        qty = C_Txt5.Text
        label = Coffee5.Text

        If C_Rad9.Checked Then
            price = qty * Val(C_Price5.Text)
            Dim otherItems As String() = {"Hot " & label, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If C_Rad10.Checked Then
            price = qty * Val(C_Price5.Text)
            Dim otherItems As String() = {"Iced " & label, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub

    Private Sub C_But6_Click(sender As Object, e As EventArgs) Handles C_But6.Click
        Dim qty, price As Integer
        Dim label As String
        qty = C_Txt6.Text
        label = Coffee6.Text

        If C_Rad11.Checked Then
            price = qty * Val(C_Price6.Text)
            Dim otherItems As String() = {"Hot " & label, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If C_Rad12.Checked Then
            price = qty * Val(C_Price6.Text)
            Dim otherItems As String() = {"Iced " & label, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub

    Private Sub M_But1_Click(sender As Object, e As EventArgs) Handles M_But1.Click
        Dim qty, price As Integer
        Dim label As String
        qty = M_Txt1.Text
        label = Milk1.Text

        If M_Rad1.Checked Then
            price = qty * Val(M_Price1.Text)
            Dim otherItems As String() = {"Hot " & label, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If M_Rad2.Checked Then
            price = qty * Val(M_Price1.Text)
            Dim otherItems As String() = {"Iced " & label, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub

    Private Sub M_But2_Click(sender As Object, e As EventArgs) Handles M_But2.Click
        Dim qty, price As Integer
        Dim label As String
        qty = M_Txt2.Text
        label = Milk2.Text

        If M_Rad3.Checked Then
            price = qty * Val(M_Price2.Text)
            Dim otherItems As String() = {"Hot " & label, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If M_Rad4.Checked Then
            price = qty * Val(M_Price2.Text)
            Dim otherItems As String() = {"Iced " & label, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub

    Private Sub M_But3_Click(sender As Object, e As EventArgs) Handles M_But3.Click
        Dim qty, price As Integer
        Dim label As String
        qty = M_Txt3.Text
        label = Milk3.Text

        If M_Rad5.Checked Then
            price = qty * Val(M_Price3.Text)
            Dim otherItems As String() = {label, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If M_Rad6.Checked Then
            price = qty * Val(M_Price3.Text)
            Dim otherItems As String() = {label, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub

    Private Sub M_But4_Click(sender As Object, e As EventArgs) Handles M_But4.Click
        Dim qty, price As Integer
        Dim label As String
        qty = M_Txt4.Text
        label = Milk4.Text

        If M_Rad7.Checked Then
            price = qty * Val(M_Price4.Text)
            Dim otherItems As String() = {label, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If M_Rad8.Checked Then
            price = qty * Val(M_Price4.Text)
            Dim otherItems As String() = {label, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub

    Private Sub J_But1_Click(sender As Object, e As EventArgs) Handles J_But1.Click
        Dim qty, price As Integer
        Dim label As String
        qty = J_Txt1.Text
        label = Juice1.Text

        price = qty * Val(J_Price1.Text)
        Dim otherItems As String() = {label, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)

    End Sub

    Private Sub J_But2_Click(sender As Object, e As EventArgs) Handles J_But2.Click
        Dim qty, price As Integer
        Dim label As String
        qty = J_Txt2.Text
        label = Juice2.Text

        price = qty * Val(J_Price2.Text)
        Dim otherItems As String() = {label, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub J_But3_Click(sender As Object, e As EventArgs) Handles J_But3.Click
        Dim qty, price As Integer
        Dim label As String
        qty = J_Txt3.Text
        label = Juice3.Text

        price = qty * Val(J_Price3.Text)
        Dim otherItems As String() = {label, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub P_But1_Click(sender As Object, e As EventArgs) Handles P_But1.Click
        Dim qty, price As Integer
        Dim label As String
        qty = P_Txt1.Text
        label = Pastry1.Text

        price = qty * Val(P_Price1.Text)
        Dim otherItems As String() = {label, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub P_But2_Click(sender As Object, e As EventArgs) Handles P_But2.Click
        Dim qty, price As Integer
        Dim label As String
        qty = P_Txt2.Text
        label = Pastry2.Text

        price = qty * Val(P_Price1.Text)
        Dim otherItems As String() = {label, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Addon1_but.Click
        Dim qty, price As Integer
        Dim label As String
        qty = Addon1_qty.Text
        label = Addon1.Text

        price = qty * Val(Addon1_but.Text)
        Dim otherItems As String() = {label, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Addon2_but.Click
        Dim qty, price As Integer
        Dim label As String
        qty = Addon2_qty.Text
        label = Addon2.Text

        price = qty * Val(Addon2_but.Text)
        Dim otherItems As String() = {label, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Addon4_but.Click
        Dim qty, price As Integer
        Dim label As String
        qty = Addon3_qty.Text
        label = Addon3.Text

        price = qty * Val(Addon3_but.Text)
        Dim otherItems As String() = {label, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Addon3_but.Click
        Dim qty, price As Integer
        Dim label As String
        qty = Addon4_qty.Text
        label = Addon4.Text

        price = qty * Val(Addon4_but.Text)
        Dim otherItems As String() = {label, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Addon5_but.Click
        Dim qty, price As Integer
        Dim label As String
        qty = Addon5_qty.Text
        label = Addon5.Text

        price = qty * Val(Addon5_but.Text)
        Dim otherItems As String() = {label, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Addon6_but.Click
        Dim qty, price As Integer
        Dim label As String
        qty = Addon6_qty.Text
        label = Addon6.Text

        price = qty * Val(Addon6_but.Text)
        Dim otherItems As String() = {label, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub



    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Remove_but.Click
        For Each item As ListViewItem In ListView1.SelectedItems
            ListView1.Items.Remove(item)
        Next
    End Sub
    Public Sub ClearTextBox(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            ClearTextBox(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            End If
        Next ctrl
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Repeat_but.Click
        ListView1.Items.Clear()
        ClearTextBox(Me)

    End Sub


    Private Sub Proceed_but_Click_1(sender As Object, e As EventArgs) Handles Proceed_but.Click
        Dim Index As Integer
        Dim TotalValue As Double

        For Index = 1 To Me.ListView1.Items.Count - 1
            Dim X As Double = CDbl(Me.ListView1.Items.Item(Index).SubItems(2).Text)
            TotalValue = TotalValue + X
        Next

        Dim vats, tot_vat As Single

        vats = (TotalValue * 12) / 100
        tot_vat = TotalValue + vats

        sub_tot.Text = TotalValue
        tot_due.Text = tot_vat
        vat.Text = vats
    End Sub

    Private Sub Panel27_Paint(sender As Object, e As PaintEventArgs) Handles Panel27.Paint
        If pwd.Checked Or senior.Checked Then
            Panel28.Visible = True
        End If
    End Sub


    Private Sub num_discounted_MouseLeave(sender As Object, e As EventArgs) Handles num_discounted.MouseLeave
        Dim noD, noC As Integer
        noC = Val(num_customer.Text)
        noD = Val(num_discounted.Text)

        If noD > noC Then
            MsgBox("Invalid Number")
        End If

        Dim disc, due As Single
        Dim no_discount As Integer

        due = Val(sub_tot.Text)
        no_discount = Val(num_discounted.Text)

        If pwd.Checked Or senior.Checked Then
            disc = (((due * 0.2) - Val(vat.Text)) * no_discount)
        End If
        discounted_amount.Text = disc
    End Sub

    Private Sub bayad_MouseLeave(sender As Object, e As EventArgs) Handles bayad.MouseLeave
        Dim due, binayad As Single
        due = Val(tot_due.Text)
        binayad = Val(bayad.Text)
        If due > binayad Then
            MsgBox("Invalid Amount")
        End If
        sukli.Text = (Val(bayad.Text) - Val(tot_due.Text)) + Val(discounted_amount.Text)
    End Sub

    Private Sub Done_but_Click(sender As Object, e As EventArgs) Handles Done_but.Click
        Dim cname As String
        cname = Val(Costumer_name.Text)

        MsgBox(vbTab & Space(10) & "KAFE NAYON" & vbCrLf & vbTab & Space(6) & "G-Spot Food Park" & vbCrLf & vbTab & Space(3) & "Tanuan City, Batangas" & vbCrLf & vbCrLf &
               My.Computer.Clock.LocalTime & vbCrLf & vbCrLf &
               "Name:" & vbTab & vbTab & cname & vbCrLf &
               "Guest:" & vbTab & vbTab & Val(num_customer.Text) & Space(3) & Val(num_discounted.Text) & "Discounted" & vbCrLf &
               "Subtotal:" & vbTab & vbTab & Val(sub_tot.Text) & vbCrLf &
               "VAT:" & vbTab & vbTab & Val(vat.Text) & vbCrLf &
               "Discounted:" & vbTab & Val(discounted_amount.Text) & vbCrLf &
               "Total Due:" & vbTab & Val(tot_due.Text) & vbCrLf &
               "Paid:" & vbTab & vbTab & Val(bayad.Text) & vbCrLf &
               "Change:" & vbTab & vbTab & Val(sukli.Text) & vbCrLf & vbCrLf &
               "THANK YOU FOR DINING WITH US! " & vbCrLf & vbTab & Space(2) & "PLEASE COME AGAIN")
        Me.Close()
    End Sub
End Class
