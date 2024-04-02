Public Class Form1
    Dim QSNs() As String = {"What is 10 x 14", "Give answer for 32 - 16", "76 / 3", "21 + 21", "", ""}
    Dim Ans() As String = {"(c)", "(b)", "(a)", "(d)"}
    Dim Qsn_1_ans() As String = {"(a) 21", "(b) 80", "(c) 140", "(d) 120"}
    Dim Qsn_2_ans() As String = {"(a) 11", "(b) 16 ", "(c) 14", "(d) 77"}
    Dim Qsn_3_ans() As String = {"(a) 25.3", "(b) 22.2", "(c) 30.3", "(d) 21.5"}
    Dim Qsn_4_ans() As String = {"(a) 41", "(b) 21", "(c) 52", "(d) 42"}
    Dim Qsn_Num As Integer = 1
    Dim index As Integer = 0
    Dim Score As Integer = 0
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txt_P_answers.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_correct_answer.SelectedIndexChanged

    End Sub

    Private Sub btn_Next_Click(sender As Object, e As EventArgs) Handles btn_Next.Click
        txt_P_answers.Text = ""
        Qsn_Num = Qsn_Num + 1
        index = index + 1
        If Qsn_Num > 5 Then
            MessageBox.Show("You scored : " & Score & "/" & "4")
        Else

            If txt_correct_answer.Text = Ans(index - 1) Then
                MessageBox.Show("Correct")
                Score = Score + 1
            Else
                MessageBox.Show("You have selected : " & txt_correct_answer.Text & " The correct answer is : " & Ans(index - 1))
            End If

            txt_Qsn_Num.Text = Qsn_Num
            txt_Question.Text = QSNs(index)

            If Qsn_Num = 5 Then
                txt_Qsn_Num.Text = "Click next to see your score"
            End If

            For i = 0 To 3
                If Qsn_Num = 2 Then
                    txt_P_answers.AppendText(Qsn_2_ans(i))
                ElseIf Qsn_Num = 3 Then
                    txt_P_answers.AppendText(Qsn_3_ans(i))
                ElseIf Qsn_Num = 4 Then
                    txt_P_answers.AppendText(Qsn_4_ans(i))
                End If
                txt_P_answers.AppendText(vbNewLine)
            Next
        End If
        txt_correct_answer.Text = ""

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_Qsn_Num.Text = Qsn_Num
        txt_Question.Text = QSNs(index)
        For i = 0 To 3
            txt_P_answers.AppendText(Qsn_1_ans(i))
            txt_P_answers.AppendText(vbNewLine)
        Next
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Me.Close()
    End Sub
End Class
