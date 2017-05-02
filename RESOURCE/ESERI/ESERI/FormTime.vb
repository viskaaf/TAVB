Public Class FormTime

    Public Shared jam_alarm As String
    Dim MyX As Integer
    Dim MyY As Integer

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Label1.Text = TimeOfDay

        If Label1.Text = Label4.Text Then
            Timer1.Enabled = False
            Button3.Enabled = True
            My.Computer.Audio.Play(My.Resources.BTS___I_NEED_U, AudioPlayMode.Background)
            System.Windows.Forms.MessageBox.Show("Stretching!!!")
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label4.Text = TextBox1.Text
        Button1.Enabled = False
        If Label4.Text = "" Then
            MsgBox("Please set alarm", MsgBoxStyle.Exclamation)
            Button1.Enabled = True
            TextBox1.Enabled = False
        End If
        TextBox1.Enabled = False
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        MyX = Me.Location.X
        MyY = Me.Location.Y
    End Sub

End Class