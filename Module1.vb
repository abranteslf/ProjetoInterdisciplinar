Imports System.Data.SqlClient
Imports System.Data.SQLite

Module Module1

    'Conexões com o banco de dados
    Public dbCommand As String = ""
    Public bindingSrc As BindingSource
    Public dbName As String = "db_moveis.db"
    Public dbPath As String = Application.StartupPath & "\" & dbName
    Public conString As String = "Data Source=" & dbPath & ";Version=3"
    Public connection As New SQLiteConnection(conString)
    Public command As New SQLiteCommand("", connection)
    'Fim das conexõescreate table tb_usuarios 

    Sub logar(cpf, senha)
        connection.Open()
        Try
            If connection.State = ConnectionState.Open Then
                command.Connection = connection
                command.CommandText = "SELECT * FROM tb_usuarios WHERE cpf='" & cpf & "' AND senha='" & senha & "'"

                Dim reader As SQLiteDataReader = command.ExecuteReader()

                If reader.HasRows Then
                    MsgBox("Login realizado com sucesso!")
                    frm_cadastro_funcionarios.Show()
                Else
                    MsgBox("CPF ou senha inválidos!")
                End If
                reader.Close()
            End If
        Catch ex As Exception
            MsgBox("Erro de conexão!")
        End Try
        connection.Close()
    End Sub

    Sub limpar_campos_login()
        With Form1
            .txt_cpf.Clear()
            .txt_senha.Clear()
        End With
    End Sub

    Sub limpar_campos_cadastro()
        With frm_cadastro_funcionarios
            '.txt_senha.Clear()
            '.txt_usuario.Clear()
            '.cmb_acesso.ResetText()
        End With
    End Sub
End Module

'EXEMPLO DE READER

'If connection.State = ConnectionState.Open Then
'    command.Connection = connection 'por que preciso disso?
'    command.CommandText = "select * from tb_usuarios"

'    Dim rdr As SQLiteDataReader = command.ExecuteReader
'    Using rdr
'        While (rdr.Read())
'            MsgBox((rdr.GetString(0) & rdr.GetString(1)))
'        End While
'    End Using
'End If
'connection.Close()