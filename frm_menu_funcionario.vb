Public Class frm_menu_funcionario
    Private Sub Sair_Click(sender As Object, e As EventArgs) Handles Sair.Click
        Me.Close()
        frm_login.Show()
    End Sub

    Private Sub btn_alterar_senha_Click(sender As Object, e As EventArgs) Handles btn_alterar_senha.Click
        Me.Hide()
        frm_alterar_senha.Show()
    End Sub
End Class