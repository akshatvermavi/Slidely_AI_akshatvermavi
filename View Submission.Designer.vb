<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_Submission
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
        Previous = New Button()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label1 = New Label()
        TextBox5 = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Previous
        ' 
        Previous.BackColor = SystemColors.GradientActiveCaption
        Previous.Location = New Point(62, 267)
        Previous.Name = "Previous"
        Previous.Size = New Size(191, 23)
        Previous.TabIndex = 22
        Previous.Text = "TOGGLE STOPWATCH (CTRL + T)"
        Previous.UseVisualStyleBackColor = False
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(203, 197)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(195, 23)
        TextBox4.TabIndex = 20
        TextBox4.Text = "https://github.com/akshatvermavi/Slidely_AI_akshatvermavi"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(203, 154)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(195, 23)
        TextBox3.TabIndex = 19
        TextBox3.Text = "+917634066879"
        ' 
        ' TextBox2
        ' 
        TextBox2.AccessibleDescription = ""
        TextBox2.Location = New Point(203, 106)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(195, 23)
        TextBox2.TabIndex = 18
        TextBox2.Tag = ""
        TextBox2.Text = "akshatvermanike@gmail.com"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(98, 157)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 15)
        Label4.TabIndex = 16
        Label4.Text = "Phone Num"
        Label4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(76, 200)
        Label3.Name = "Label3"
        Label3.Size = New Size(121, 15)
        Label3.TabIndex = 15
        Label3.Text = "Github Link for Task 2"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(112, 109)
        Label2.Name = "Label2"
        Label2.Size = New Size(36, 15)
        Label2.TabIndex = 14
        Label2.Text = "Email"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(203, 58)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(195, 23)
        TextBox1.TabIndex = 13
        TextBox1.Text = "Akshat Verma"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(112, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 12
        Label1.Text = "Name"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(259, 267)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(139, 23)
        TextBox5.TabIndex = 23
        TextBox5.Text = "00.00.00"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.Location = New Point(112, 319)
        Button1.Name = "Button1"
        Button1.Size = New Size(228, 23)
        Button1.TabIndex = 24
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' View_Submission
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(475, 380)
        Controls.Add(Button1)
        Controls.Add(TextBox5)
        Controls.Add(Previous)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "View_Submission"
        Text = "View_Submission"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Previous As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button1 As Button
End Class
