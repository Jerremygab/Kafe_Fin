Imports System.Windows
Imports System.Windows.Forms.DataFormats
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

Public Class Form1
    Private Sub C_But1_Click(sender As Object, e As EventArgs) Handles C_But1.Click
        Dim qty, price As Integer
        Dim label As String
        qty = C_Txt1.Text
        label = Coffee1.Text

        price = Val(C_Txt1.Text) * Val(C_Price1.Text)
        Form2.ListBox2.Items.Add(price)
        If C_Rad1.Checked Then
            Form2.orders.Items.Add(qty & vbTab & C_Rad1.Text & Space(1) & label & vbTab & price)
        End If
        If C_Rad2.Checked Then
            Form2.orders.Items.Add(qty & vbTab & C_Rad2.Text & Space(1) & label & vbTab & price)
        End If

    End Sub

    Private Sub C_But2_Click(sender As Object, e As EventArgs) Handles C_But2.Click
        Dim qty, price As Integer
        Dim label As String
        qty = C_Txt2.Text
        label = Coffee2.Text

        price = Val(C_Txt2.Text) * Val(C_Price2.Text)
        Form2.ListBox2.Items.Add(price)
        If C_Rad3.Checked Then
            Form2.orders.Items.Add(qty & vbTab & C_Rad3.Text & Space(1) & label & vbTab & vbTab & price)
        End If
        If C_Rad4.Checked Then
            Form2.orders.Items.Add(qty & vbTab & C_Rad4.Text & Space(1) & label & vbTab & vbTab & price)
        End If
    End Sub

    Private Sub C_But3_Click(sender As Object, e As EventArgs) Handles C_But3.Click
        Dim qty, price As Integer
        Dim label As String
        qty = C_Txt3.Text
        label = Coffee3.Text

        price = Val(C_Txt3.Text) * Val(C_Price3.Text)
        Form2.ListBox2.Items.Add(price)
        If C_Rad5.Checked Then
            Form2.orders.Items.Add(qty & vbTab & C_Rad5.Text & Space(1) & label & vbTab & vbTab & price)
        End If
        If C_Rad6.Checked Then
            Form2.orders.Items.Add(qty & vbTab & C_Rad6.Text & Space(1) & label & vbTab & vbTab & price)
        End If
    End Sub

    Private Sub C_But4_Click(sender As Object, e As EventArgs) Handles C_But4.Click
        Dim qty, price As Integer
        Dim label As String
        qty = C_Txt4.Text
        label = Coffee4.Text

        price = Val(C_Txt4.Text) * Val(C_Price4.Text)
        Form2.ListBox2.Items.Add(price)
        If C_Rad7.Checked Then
            Form2.orders.Items.Add(qty & vbTab & C_Rad7.Text & Space(1) & label & vbTab & vbTab & price)
        End If
        If C_Rad8.Checked Then
            Form2.orders.Items.Add(qty & vbTab & C_Rad8.Text & Space(1) & label & vbTab & vbTab & price)
        End If
    End Sub

    Private Sub C_But5_Click(sender As Object, e As EventArgs) Handles C_But5.Click
        Dim qty, price As Integer
        Dim label As String
        qty = C_Txt5.Text
        label = Coffee5.Text

        price = Val(C_Txt5.Text) * Val(C_Price5.Text)
        Form2.ListBox2.Items.Add(price)
        If C_Rad9.Checked Then
            Form2.orders.Items.Add(qty & vbTab & C_Rad9.Text & Space(1) & label & vbTab & vbTab & price)
        End If
        If C_Rad10.Checked Then
            Form2.orders.Items.Add(qty & vbTab & C_Rad10.Text & Space(1) & label & vbTab & vbTab & price)
        End If
    End Sub

    Private Sub C_But6_Click(sender As Object, e As EventArgs) Handles C_But6.Click
        Dim qty, price As Integer
        Dim label As String
        qty = C_Txt6.Text
        label = Coffee6.Text

        price = Val(C_Txt6.Text) * Val(C_Price6.Text)
        Form2.ListBox2.Items.Add(price)
        If C_Rad11.Checked Then
            Form2.orders.Items.Add(qty & vbTab & C_Rad11.Text & Space(1) & label & vbTab & vbTab & price)
        End If
        If C_Rad12.Checked Then
            Form2.orders.Items.Add(qty & vbTab & C_Rad12.Text & Space(1) & label & vbTab & vbTab & price)
        End If
    End Sub

    Private Sub M_But1_Click(sender As Object, e As EventArgs) Handles M_But1.Click
        Dim qty, price As Integer
        Dim label As String
        qty = M_Txt1.Text
        label = Milk1.Text

        price = Val(M_Txt1.Text) * Val(M_Price1.Text)
        Form2.ListBox2.Items.Add(price)
        If M_Rad1.Checked Then
            Form2.orders.Items.Add(qty & vbTab & M_Rad1.Text & Space(1) & label & vbTab & vbTab & price)
        End If
        If M_Rad2.Checked Then
            Form2.orders.Items.Add(qty & vbTab & M_Rad2.Text & Space(1) & label & vbTab & price)
        End If
    End Sub

    Private Sub M_But2_Click(sender As Object, e As EventArgs) Handles M_But2.Click
        Dim qty, price As Integer
        Dim label As String
        qty = M_Txt2.Text
        label = Milk2.Text

        price = Val(M_Txt2.Text) * Val(M_Price2.Text)
        Form2.ListBox2.Items.Add(price)
        If M_Rad3.Checked Then
            Form2.orders.Items.Add(qty & vbTab & M_Rad3.Text & Space(1) & label & vbTab & price)
        End If
        If M_Rad2.Checked Then
            Form2.orders.Items.Add(qty & vbTab & M_Rad4.Text & Space(1) & label & vbTab & price)
        End If
    End Sub

    Private Sub M_But3_Click(sender As Object, e As EventArgs) Handles M_But3.Click
        Dim qty, price As Integer
        Dim label As String
        qty = M_Txt3.Text
        label = Milk3.Text

        price = Val(M_Txt3.Text) * Val(M_Price3.Text)
        Form2.ListBox2.Items.Add(price)
        If M_Rad5.Checked Then
            Form2.orders.Items.Add(qty & vbTab & M_Rad5.Text & Space(1) & label & vbTab & price)
        End If
        If M_Rad6.Checked Then
            Form2.orders.Items.Add(qty & vbTab & M_Rad6.Text & Space(1) & label & vbTab & price)
        End If
    End Sub

    Private Sub M_But4_Click(sender As Object, e As EventArgs) Handles M_But4.Click
        Dim qty, price As Integer
        Dim label As String
        qty = M_Txt4.Text
        label = Milk4.Text

        price = Val(M_Txt4.Text) * Val(M_Price4.Text)
        Form2.ListBox2.Items.Add(price)
        If M_Rad7.Checked Then
            Form2.orders.Items.Add(qty & vbTab & M_Rad7.Text & Space(1) & label & vbTab & vbTab & price)
        End If
        If M_Rad8.Checked Then
            Form2.orders.Items.Add(qty & vbTab & M_Rad8.Text & Space(1) & label & vbTab & vbTab & price)
        End If
    End Sub

    Private Sub J_But1_Click(sender As Object, e As EventArgs) Handles J_But1.Click
        Dim qty, price As Integer
        Dim label As String
        qty = J_Txt1.Text
        label = Juice1.Text

        price = Val(J_Txt1.Text) * Val(J_Price1.Text)
        Form2.orders.Items.Add(qty & vbTab & label & vbTab & vbTab & price)
        Form2.ListBox2.Items.Add(price)

    End Sub

    Private Sub J_But2_Click(sender As Object, e As EventArgs) Handles J_But2.Click
        Dim qty, price As Integer
        Dim label As String
        qty = J_Txt2.Text
        label = Juice2.Text

        price = Val(J_Txt2.Text) * Val(J_Price2.Text)
        Form2.orders.Items.Add(qty & vbTab & label & vbTab & price)
        Form2.ListBox2.Items.Add(price)
    End Sub

    Private Sub J_But3_Click(sender As Object, e As EventArgs) Handles J_But3.Click
        Dim qty, price As Integer
        Dim label As String
        qty = J_Txt3.Text
        label = Juice3.Text

        price = Val(J_Txt3.Text) * Val(J_Price3.Text)
        Form2.orders.Items.Add(qty & vbTab & label & vbTab & vbTab & price)
        Form2.ListBox2.Items.Add(price)
    End Sub

    Private Sub P_But1_Click(sender As Object, e As EventArgs) Handles P_But1.Click
        Dim qty, price As Integer
        Dim label As String
        qty = P_Txt1.Text
        label = Pastry1.Text

        price = Val(P_Txt1.Text) * Val(P_Price1.Text)
        Form2.orders.Items.Add(qty & vbTab & label & vbTab & vbTab & price)
        Form2.ListBox2.Items.Add(price)
    End Sub

    Private Sub P_But2_Click(sender As Object, e As EventArgs) Handles P_But2.Click
        Dim qty, price As Integer
        Dim label As String
        qty = P_Txt2.Text
        label = Pastry2.Text

        price = Val(P_Txt2.Text) * Val(P_Price2.Text)
        Form2.orders.Items.Add(qty & vbTab & label & vbTab & vbTab & price)
        Form2.ListBox2.Items.Add(price)
    End Sub

    Private Sub Proceed_But_Click(sender As Object, e As EventArgs) Handles Proceed_But.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class
