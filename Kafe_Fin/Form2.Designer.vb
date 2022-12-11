<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.proceed_but = New System.Windows.Forms.Button()
        Me.done_but = New System.Windows.Forms.Button()
        Me.change = New System.Windows.Forms.TextBox()
        Me.paid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.repeat_but = New System.Windows.Forms.Button()
        Me.orders = New System.Windows.Forms.ListBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.totals = New System.Windows.Forms.TextBox()
        Me.vat12 = New System.Windows.Forms.TextBox()
        Me.label = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(678, 17)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(269, 190)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'ListBox2
        '
        Me.ListBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 15
        Me.ListBox2.Location = New System.Drawing.Point(777, 127)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(56, 15)
        Me.ListBox2.TabIndex = 49
        '
        'proceed_but
        '
        Me.proceed_but.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.proceed_but.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.proceed_but.Location = New System.Drawing.Point(192, 479)
        Me.proceed_but.Name = "proceed_but"
        Me.proceed_but.Size = New System.Drawing.Size(125, 32)
        Me.proceed_but.TabIndex = 48
        Me.proceed_but.Text = "Proceed"
        Me.proceed_but.UseVisualStyleBackColor = False
        '
        'done_but
        '
        Me.done_but.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.done_but.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.done_but.Location = New System.Drawing.Point(777, 461)
        Me.done_but.Name = "done_but"
        Me.done_but.Size = New System.Drawing.Size(93, 38)
        Me.done_but.TabIndex = 46
        Me.done_but.Text = "DONE"
        Me.done_but.UseVisualStyleBackColor = False
        '
        'change
        '
        Me.change.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.change.Location = New System.Drawing.Point(733, 416)
        Me.change.Name = "change"
        Me.change.Size = New System.Drawing.Size(152, 23)
        Me.change.TabIndex = 45
        '
        'paid
        '
        Me.paid.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.paid.Location = New System.Drawing.Point(733, 387)
        Me.paid.Name = "paid"
        Me.paid.Size = New System.Drawing.Size(152, 23)
        Me.paid.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(578, 408)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 29)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Change"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(561, 379)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 29)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Paid Amount"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(561, 321)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 29)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Total Amount"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Calligraphy", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(525, 252)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(376, 39)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "—-— PAYMENT —-—"
        '
        'repeat_but
        '
        Me.repeat_but.BackColor = System.Drawing.Color.Crimson
        Me.repeat_but.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.repeat_but.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.repeat_but.Location = New System.Drawing.Point(595, 461)
        Me.repeat_but.Name = "repeat_but"
        Me.repeat_but.Size = New System.Drawing.Size(146, 38)
        Me.repeat_but.TabIndex = 39
        Me.repeat_but.Text = "REPEAT ORDER"
        Me.repeat_but.UseVisualStyleBackColor = False
        '
        'orders
        '
        Me.orders.BackColor = System.Drawing.Color.Snow
        Me.orders.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.orders.FormattingEnabled = True
        Me.orders.ItemHeight = 20
        Me.orders.Items.AddRange(New Object() {"Qty" & Global.Microsoft.VisualBasic.ChrW(9) & "Product" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "Price", "————————————————————————————————————————"})
        Me.orders.Location = New System.Drawing.Point(46, 185)
        Me.orders.Name = "orders"
        Me.orders.Size = New System.Drawing.Size(435, 264)
        Me.orders.TabIndex = 38
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Lucida Calligraphy", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label23.ForeColor = System.Drawing.Color.Gold
        Me.Label23.Location = New System.Drawing.Point(116, 127)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(284, 39)
        Me.Label23.TabIndex = 37
        Me.Label23.Text = "—-— CART —-—"
        '
        'totals
        '
        Me.totals.Enabled = False
        Me.totals.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.totals.Location = New System.Drawing.Point(733, 329)
        Me.totals.Name = "totals"
        Me.totals.Size = New System.Drawing.Size(152, 23)
        Me.totals.TabIndex = 51
        '
        'vat12
        '
        Me.vat12.Enabled = False
        Me.vat12.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.vat12.Location = New System.Drawing.Point(733, 358)
        Me.vat12.Name = "vat12"
        Me.vat12.Size = New System.Drawing.Size(152, 23)
        Me.vat12.TabIndex = 53
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.BackColor = System.Drawing.Color.Transparent
        Me.label.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.label.ForeColor = System.Drawing.Color.White
        Me.label.Location = New System.Drawing.Point(592, 358)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(70, 19)
        Me.label.TabIndex = 52
        Me.label.Text = "VAT 12%"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Kafe_Fin.My.Resources.Resources.Untitled_design__3_
        Me.ClientSize = New System.Drawing.Size(1002, 651)
        Me.Controls.Add(Me.vat12)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.totals)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.proceed_but)
        Me.Controls.Add(Me.done_but)
        Me.Controls.Add(Me.change)
        Me.Controls.Add(Me.paid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.repeat_but)
        Me.Controls.Add(Me.orders)
        Me.Controls.Add(Me.Label23)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents proceed_but As Button
    Friend WithEvents done_but As Button
    Friend WithEvents change As TextBox
    Friend WithEvents paid As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents repeat_but As Button
    Friend WithEvents orders As ListBox
    Friend WithEvents Label23 As Label
    Friend WithEvents vat12 As TextBox
    Friend WithEvents label As Label
    Friend WithEvents totals As TextBox
End Class
