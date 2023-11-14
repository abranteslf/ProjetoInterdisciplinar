Public Class frm_menu_gerente
    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Me.Close()
        frm_login.Show()
    End Sub
End Class