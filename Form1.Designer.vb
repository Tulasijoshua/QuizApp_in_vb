<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Label5 = New Label()
        txt_P_answers = New TextBox()
        Label4 = New Label()
        txt_correct_answer = New ComboBox()
        txt_Question = New TextBox()
        Label3 = New Label()
        txt_Qsn_Num = New TextBox()
        Label2 = New Label()
        Panel2 = New Panel()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Panel3 = New Panel()
        btn_Exit = New Button()
        btn_Next = New Button()
        Label6 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlLight
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(txt_P_answers)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(txt_correct_answer)
        Panel1.Controls.Add(txt_Question)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txt_Qsn_Num)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(36, 203)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(579, 289)
        Panel1.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Narrow", 10F)
        Label5.Location = New Point(28, 247)
        Label5.Name = "Label5"
        Label5.Size = New Size(123, 24)
        Label5.TabIndex = 9
        Label5.Text = "Correct Answer"
        ' 
        ' txt_P_answers
        ' 
        txt_P_answers.Location = New Point(208, 122)
        txt_P_answers.Multiline = True
        txt_P_answers.Name = "txt_P_answers"
        txt_P_answers.Size = New Size(291, 108)
        txt_P_answers.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Narrow", 10F)
        Label4.Location = New Point(28, 152)
        Label4.Name = "Label4"
        Label4.Size = New Size(138, 24)
        Label4.TabIndex = 8
        Label4.Text = "Possible Answers"
        ' 
        ' txt_correct_answer
        ' 
        txt_correct_answer.FormattingEnabled = True
        txt_correct_answer.Items.AddRange(New Object() {"(a)", "(b)", "(c)", "(d)"})
        txt_correct_answer.Location = New Point(208, 243)
        txt_correct_answer.Name = "txt_correct_answer"
        txt_correct_answer.Size = New Size(182, 33)
        txt_correct_answer.TabIndex = 6
        ' 
        ' txt_Question
        ' 
        txt_Question.Location = New Point(208, 56)
        txt_Question.Multiline = True
        txt_Question.Name = "txt_Question"
        txt_Question.Size = New Size(291, 47)
        txt_Question.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Narrow", 10F)
        Label3.Location = New Point(28, 78)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 24)
        Label3.TabIndex = 5
        Label3.Text = "Question"
        ' 
        ' txt_Qsn_Num
        ' 
        txt_Qsn_Num.Location = New Point(208, 14)
        txt_Qsn_Num.Name = "txt_Qsn_Num"
        txt_Qsn_Num.Size = New Size(291, 31)
        txt_Qsn_Num.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Narrow", 10F)
        Label2.Location = New Point(28, 20)
        Label2.Name = "Label2"
        Label2.Size = New Size(139, 24)
        Label2.TabIndex = 3
        Label2.Text = "Question Number"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlLight
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(36, 92)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(579, 95)
        Panel2.TabIndex = 3
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(170, 29)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(279, 37)
        TextBox1.TabIndex = 2
        TextBox1.Text = "Maths Test One"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Narrow", 10F)
        Label1.Location = New Point(38, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 24)
        Label1.TabIndex = 3
        Label1.Text = "Name of Test"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ControlLight
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(btn_Exit)
        Panel3.Controls.Add(btn_Next)
        Panel3.Location = New Point(36, 498)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(579, 101)
        Panel3.TabIndex = 4
        ' 
        ' btn_Exit
        ' 
        btn_Exit.FlatStyle = FlatStyle.Popup
        btn_Exit.Font = New Font("Bahnschrift SemiBold", 11F, FontStyle.Bold)
        btn_Exit.Location = New Point(38, 36)
        btn_Exit.Name = "btn_Exit"
        btn_Exit.Size = New Size(142, 39)
        btn_Exit.TabIndex = 1
        btn_Exit.Text = "Exit"
        btn_Exit.UseVisualStyleBackColor = True
        ' 
        ' btn_Next
        ' 
        btn_Next.FlatStyle = FlatStyle.Popup
        btn_Next.Font = New Font("Bahnschrift SemiBold", 11F, FontStyle.Bold)
        btn_Next.Location = New Point(380, 36)
        btn_Next.Name = "btn_Next"
        btn_Next.Size = New Size(129, 39)
        btn_Next.TabIndex = 0
        btn_Next.Text = "Next"
        btn_Next.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(226, 30)
        Label6.Name = "Label6"
        Label6.Size = New Size(349, 29)
        Label6.TabIndex = 5
        Label6.Text = "QUIZ APPLICATION VB.NET"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 611)
        Controls.Add(Label6)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_Question As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Qsn_Num As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_P_answers As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_correct_answer As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_Next As Button
    Friend WithEvents btn_Exit As Button
    Friend WithEvents Label6 As Label

End Class
