<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Create_New_Submission
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
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Previous = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(90, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 0
        Label1.Text = "Name"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.InactiveCaption
        TextBox1.Location = New Point(199, 37)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(195, 23)
        TextBox1.TabIndex = 1
        TextBox1.Text = "Akshat Verma"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(90, 88)
        Label2.Name = "Label2"
        Label2.Size = New Size(36, 15)
        Label2.TabIndex = 2
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(47, 179)
        Label3.Name = "Label3"
        Label3.Size = New Size(121, 15)
        Label3.TabIndex = 3
        Label3.Text = "Github Link for Task 2"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(72, 141)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 15)
        Label4.TabIndex = 4
        Label4.Text = "Phone Num"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(59, 222)
        Label5.Name = "Label5"
        Label5.Size = New Size(96, 15)
        Label5.TabIndex = 5
        Label5.Text = " Stopwatch Time"
        ' 
        ' TextBox2
        ' 
        TextBox2.AccessibleDescription = ""
        TextBox2.BackColor = SystemColors.InactiveCaption
        TextBox2.Location = New Point(199, 85)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(195, 23)
        TextBox2.TabIndex = 6
        TextBox2.Tag = ""
        TextBox2.Text = "akshatvermanike@gmail.com"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.InactiveCaption
        TextBox3.Location = New Point(199, 133)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(195, 23)
        TextBox3.TabIndex = 7
        TextBox3.Text = "+917634066879"
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = SystemColors.InactiveCaption
        TextBox4.Location = New Point(199, 176)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(195, 23)
        TextBox4.TabIndex = 8
        TextBox4.Text = "https://github.com/akshatvermavi/Slidely_AI_akshatvermavi"
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = SystemColors.InactiveCaption
        TextBox5.Location = New Point(199, 219)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(195, 23)
        TextBox5.TabIndex = 9
        TextBox5.Text = "00.01.19"
        ' 
        ' Previous
        ' 
        Previous.BackColor = SystemColors.GradientActiveCaption
        Previous.Location = New Point(72, 279)
        Previous.Name = "Previous"
        Previous.Size = New Size(151, 23)
        Previous.TabIndex = 10
        Previous.Text = "Previous(CTRL + P)"
        Previous.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.GradientInactiveCaption
        Button2.ImageAlign = ContentAlignment.BottomRight
        Button2.Location = New Point(239, 279)
        Button2.Name = "Button2"
        Button2.Size = New Size(155, 23)
        Button2.TabIndex = 11
        Button2.Text = "Next(CTRL + N)"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Create_New_Submission
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(497, 339)
        Controls.Add(Button2)
        Controls.Add(Previous)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "Create_New_Submission"
        Text = "Create_New_Submission"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Previous As Button
    Friend WithEvents Button2 As Button
End Class
