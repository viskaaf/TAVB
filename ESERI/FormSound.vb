Public Class FormSound

    Private Sub BTLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTLogin.Click
        Me.Visible = False
        FormMenu.Visible = True
    End Sub

    Private Sub FormSound_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.BTS___I_NEED_U, AudioPlayMode.Background)
    End Sub
End Class