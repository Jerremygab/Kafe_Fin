Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        UI.Show()
        Me.Hide()
    End Sub

    Private Sub Caramel_mac_price_Click(sender As Object, e As EventArgs) Handles Caramel_mac_price.Click
        Dim qty, price, presyo As Integer
        Dim label As String
        qty = Caramel_mac_qty.Text
        label = Caramel_mac.Text
        presyo = Caramel_mac_price.Text

        If Caramel_mac_hot.Checked Then
            price = qty * presyo
            Dim otherItems As String() = {"HOT " & label, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Caramel_mac_iced.Checked Then
            price = qty * presyo
            Dim otherItems As String() = {"ICED " & label, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub

    Private Sub Cafe_mocha_price_Click(sender As Object, e As EventArgs) Handles Cafe_mocha_price.Click
        Dim qty, price, presyo As Integer
        Dim label As String
        qty = Cafe_mocha_qty.Text
        label = Cafe_mocha.Text
        presyo = Cafe_mocha_price.Text

        If Cafe_mocha_hot.Checked Then
            price = qty * presyo
            Dim otherItems As String() = {"HOT " & label, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Cafe_mocha_iced.Checked Then
            price = qty * presyo
            Dim otherItems As String() = {"ICED " & label, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub

    Private Sub Cafe_latte_price_Click(sender As Object, e As EventArgs) Handles Cafe_latte_price.Click
        Dim qty, price, presyo As Integer
        Dim label As String
        qty = Cafe_latte_qty.Text
        label = Cafe_latte.Text
        presyo = Cafe_latte_price.Text

        If Cafe_latte_hot.Checked Then
            price = qty * presyo
            Dim otherItems As String() = {"HOT " & label, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Cafe_latte_iced.Checked Then
            price = qty * presyo
            Dim otherItems As String() = {"ICED " & label, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub

    Private Sub Vanilla_coffee_price_Click(sender As Object, e As EventArgs) Handles Vanilla_coffee_price.Click
        Dim qty, price, presyo As Integer
        Dim label As String
        qty = Vanilla_coffee_qty.Text
        label = Vanilla_coffee.Text
        presyo = Vanilla_coffee_price.Text

        If Vanilla_coffee_hot.Checked Then
            price = qty * presyo
            Dim otherItems As String() = {"HOT " & label, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Vanilla_coffee_iced.Checked Then
            price = qty * presyo
            Dim otherItems As String() = {"ICED " & label, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub

    Private Sub Americano_price_Click(sender As Object, e As EventArgs) Handles Americano_price.Click
        Dim qty, price, presyo As Integer
        Dim label As String
        qty = Americano_qty.Text
        label = Americano.Text
        presyo = Americano_price.Text

        If Americano_hot.Checked Then
            price = qty * presyo
            Dim otherItems As String() = {"HOT " & label, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Americano_iced.Checked Then
            price = qty * presyo
            Dim otherItems As String() = {"ICED " & label, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub

    Private Sub Coffee_caramel_price_Click(sender As Object, e As EventArgs) Handles Coffee_caramel_price.Click
        Dim qty, price, presyo As Integer
        Dim label As String
        qty = Coffee_caramel_qty.Text
        label = Coffee_caramel.Text
        presyo = Coffee_caramel_price.Text

        If Coffee_caramel_hot.Checked Then
            price = qty * presyo
            Dim otherItems As String() = {"HOT " & label, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Coffee_caramel_iced.Checked Then
            price = qty * presyo
            Dim otherItems As String() = {"ICED " & label, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub

    Private Sub Classic_choco_price_Click(sender As Object, e As EventArgs) Handles Classic_choco_price.Click
        Dim qty, price, presyo As Integer
        Dim label As String
        qty = Classic_choco_qty.Text
        label = Classic_choco.Text
        presyo = Classic_choco_price.Text

        If Classic_choco_hot.Checked Then
            price = qty * presyo
            Dim otherItems As String() = {"HOT " & label, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Classic_choco_iced.Checked Then
            price = qty * presyo
            Dim otherItems As String() = {"ICED " & label, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub

    Private Sub Strawberry_milk_price_Click(sender As Object, e As EventArgs) Handles Strawberry_milk_price.Click
        Dim qty, price, presyo As Integer
        Dim label As String
        qty = Strawberry_milk_qty.Text
        label = Strawberry_milk.Text
        presyo = Strawberry_milk_price.Text

        If Strawberry_milk_hot.Checked Then
            price = qty * presyo
            Dim otherItems As String() = {"HOT " & label, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Strawberry_milk_iced.Checked Then
            price = qty * presyo
            Dim otherItems As String() = {"ICED " & label, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub

    Private Sub Strawberries_cream_price_Click(sender As Object, e As EventArgs) Handles Strawberries_cream_price.Click
        Dim qty, price, presyo As Integer
        Dim label As String
        qty = Strawberries_cream_qty.Text
        label = Strawberries_cream.Text
        presyo = Strawberries_cream_price.Text

        If Strawberries_cream_hot.Checked Then
            price = qty * presyo
            Dim otherItems As String() = {"HOT " & label, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Strawberries_cream_iced.Checked Then
            price = qty * presyo
            Dim otherItems As String() = {"ICED " & label, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub

    Private Sub Matcha_latte_price_Click(sender As Object, e As EventArgs) Handles Matcha_latte_price.Click
        Dim qty, price, presyo As Integer
        Dim label As String
        qty = Matcha_latte_qty.Text
        label = Matcha_latte.Text
        presyo = Matcha_latte_price.Text

        If Matcha_latte_hot.Checked Then
            price = qty * presyo
            Dim otherItems As String() = {"HOT " & label, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Matcha_latte_iced.Checked Then
            price = qty * presyo
            Dim otherItems As String() = {"ICED " & label, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub
    Private Sub Classic_brownies_price_Click(sender As Object, e As EventArgs) Handles Classic_brownies_price.Click
        Dim qty, price, presyo As Integer
        Dim label As String
        qty = Classic_brownies_qty.Text
        label = Classic_brownies.Text
        presyo = Classic_brownies_price.Text

        price = qty * presyo
        Dim otherItems As String() = {label, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)

    End Sub
    Private Sub Choco_chips_price_Click(sender As Object, e As EventArgs) Handles Choco_chips_price.Click
        Dim qty, price, presyo As Integer
        Dim label As String
        qty = Choco_chips_qty.Text
        label = Choco_chips.Text
        presyo = Choco_chips_price.Text

        price = qty * presyo
        Dim otherItems As String() = {label, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Tropical_apple_price_Click(sender As Object, e As EventArgs) Handles Tropical_apple_price.Click
        Dim qty, price, presyo As Integer
        Dim label As String
        qty = Tropical_apple_qty.Text
        label = Tropical_apple.Text
        presyo = Tropical_apple_price.Text

        price = qty * presyo
        Dim otherItems As String() = {label, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Strawberry_slush_price_Click(sender As Object, e As EventArgs) Handles Strawberry_slush_price.Click
        Dim qty, price, presyo As Integer
        Dim label As String
        qty = Strawberry_slush_qty.Text
        label = Strawberry_slush.Text
        presyo = Strawberry_slush_price.Text

        price = qty * presyo
        Dim otherItems As String() = {label, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Lemon_slush_price_Click(sender As Object, e As EventArgs) Handles Lemon_slush_price.Click
        Dim qty, price, presyo As Integer
        Dim label As String
        qty = Lemon_slush_qty.Text
        label = Lemon_slush.Text
        presyo = Lemon_slush_price.Text

        price = qty * presyo
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
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Addon3_but.Click
        Dim qty, price As Integer
        Dim label As String
        qty = Addon4_qty.Text
        label = Addon4.Text

        price = qty * Val(Addon4_but.Text)
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

    Private Sub Proceed_but_Click(sender As Object, e As EventArgs) Handles Proceed_but.Click
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

    Private Sub Remove_but_Click(sender As Object, e As EventArgs) Handles Remove_but.Click
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