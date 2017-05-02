Public Class FormMenu

    Private Sub BTTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTTime.Click
        Me.Visible = False
        FormTime.Visible = True
    End Sub

    Private Sub BTSound_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTSound.Click
        Me.Visible = False
        FormSound.Visible = True
    End Sub
End Class