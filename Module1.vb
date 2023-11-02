Module Module1
    Public diretorio, SQL As String
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public caminho = Application.StartupPath & "\Banco\moveis_ld1.mdb"
    'testando testando push
    Sub conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & caminho)
        Catch ex As Exception
            MsgBox("Erro de Conexão", MsgBoxStyle.Critical + vbOKOnly, "AVISO")
        End Try
    End Sub
    Sub limpar_campos_login()
        With Form1
            .txt_usuario.Clear()
            .txt_senha.Clear()
        End With
    End Sub


    Sub limpar_campos_cadastro()
        With frm_cadastro_funcionarios
            .txt_senha.Clear()
            .txt_usuario.Clear()
            .cmb_acesso.ResetText()
        End With
    End Sub
End Module
