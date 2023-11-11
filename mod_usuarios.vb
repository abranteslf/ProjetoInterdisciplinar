Imports System.Data.SqlClient
Imports System.Data.SQLite

Module mod_usuarios

    'Conexões com o banco de dados
    Public dbCommand As String = ""
    Public bindingSrc As BindingSource
    Public dbName As String = "db_moveis.db"
    Public dbPath As String = Application.StartupPath & "\" & dbName
    Public conString As String = "Data Source=" & dbPath & ";Version=3"
    Public connection As New SQLiteConnection(conString)
    Public command As New SQLiteCommand("", connection)
    'Fim das conexões
    Public cpfLogado

    Sub logar(cpf As String, senha As String)

        Using connection As New SQLiteConnection(conString)
            connection.Open()
            Try
                If connection.State = ConnectionState.Open Then
                    Dim commandText As String = "SELECT * FROM tb_usuarios WHERE cpf=@cpf AND senha=@senha"
                    Using command As New SQLiteCommand(commandText, connection)
                        command.Parameters.AddWithValue("@cpf", cpf)
                        command.Parameters.AddWithValue("@senha", senha)

                        Dim reader As SQLiteDataReader = command.ExecuteReader()

                        Using reader
                            If reader.HasRows Then
                                MsgBox("Login realizado com sucesso!")
                                cpfLogado = cpf
                                frm_menu_funcionario.Show()
                                frm_login.Hide()
                            Else
                                MsgBox("CPF ou senha inválidos!")
                                limpar_campos_login()
                            End If
                        End Using
                    End Using
                End If
            Catch ex As Exception
                MsgBox("Erro de conexão: " & ex.Message)
            End Try
        End Using
    End Sub


    Sub cadastrar(cpf As String, nome As String, senha As String, acesso As String)

        Using connection As New SQLiteConnection(conString)
            connection.Open()

            If connection.State = ConnectionState.Open Then
                Dim commandText As String = "INSERT INTO tb_usuarios VALUES (@cpf, @nome, @senha, @acesso)"
                Using command As New SQLiteCommand(commandText, connection)
                    command.Parameters.AddWithValue("@cpf", cpf)
                    command.Parameters.AddWithValue("@nome", nome)
                    command.Parameters.AddWithValue("@senha", senha)
                    command.Parameters.AddWithValue("@acesso", acesso)
                    command.ExecuteNonQuery()
                End Using
                MsgBox("Cadastro realizado com sucesso!")
            End If

            connection.Close()
        End Using
    End Sub

    Sub procurar_usuario(cpf As String)
        Using connection As New SQLiteConnection(conString)
            connection.Open()
            Try
                If connection.State = ConnectionState.Open Then
                    Dim commandText As String = "SELECT * FROM tb_usuarios WHERE cpf=@cpf"
                    Using command As New SQLiteCommand(commandText, connection)
                        command.Parameters.AddWithValue("@cpf", cpf)

                        Using reader As SQLiteDataReader = command.ExecuteReader()
                            If reader.Read() Then
                                'MsgBox("Esse funcionário já está cadastrado!")
                                With frm_cadastro_funcionarios
                                    .txt_nome.Text = reader.GetString(1)
                                    .txt_senha.Text = reader.GetString(2)
                                    .cmb_acesso.Text = reader.GetString(3)
                                    .btn_excluir.Enabled = True
                                    .btn_atualizar.Enabled = True
                                    .lbl_novocpf.Visible = True
                                    .txt_novocpf.Visible = True
                                End With
                            Else
                                limpar_campos_cadastro()
                                With frm_cadastro_funcionarios
                                    .btn_excluir.Enabled = False
                                    .btn_atualizar.Enabled = False
                                End With
                            End If
                        End Using
                    End Using
                End If
            Catch ex As SQLiteException
                MsgBox("Erro de SQLite: " & ex.Message)
            Catch ex As Exception
                MsgBox("Erro: " & ex.Message)
            End Try
        End Using
    End Sub

    Sub atualizar_cadastro(novoCpf As String, cpf As String, nome As String, senha As String, acesso As String)
        Using connection As New SQLiteConnection(conString)
            connection.Open()
            Try
                If connection.State = ConnectionState.Open Then
                    Dim commandText As String = "UPDATE tb_usuarios SET cpf=@novoCpf, nome=@nome, senha=@senha, acesso=@acesso WHERE cpf=@cpf"
                    Using command As New SQLiteCommand(commandText, connection)
                        command.Parameters.AddWithValue("@novoCpf", novoCpf)
                        command.Parameters.AddWithValue("@cpf", cpf)
                        command.Parameters.AddWithValue("@nome", nome)
                        command.Parameters.AddWithValue("@senha", senha)
                        command.Parameters.AddWithValue("@acesso", acesso)
                        command.ExecuteNonQuery()
                    End Using
                    MsgBox("Cadastro atualizado com sucesso!")
                    limpar_campos_cadastro()
                    frm_cadastro_funcionarios.txt_novocpf.Visible = False
                End If
            Catch ex As SQLiteException
                MsgBox("Erro de SQLite: " & ex.Message)
            Catch ex As Exception
                MsgBox("Erro: " & ex.Message)
            End Try
        End Using
    End Sub

    Sub excluir_cadastro(cpf As String)
        Using connection As New SQLiteConnection(conString)
            connection.Open()
            Try
                If connection.State = ConnectionState.Open Then
                    Dim commandText As String = "DELETE FROM tb_usuarios WHERE cpf=@cpf"
                    Using command As New SQLiteCommand(commandText, connection)
                        command.Parameters.AddWithValue("@cpf", cpf)
                        command.ExecuteNonQuery()
                    End Using
                    MsgBox("Cadastro excluido com sucesso!")
                    limpar_campos_cadastro()
                    frm_cadastro_funcionarios.txt_novocpf.Visible = False
                End If
            Catch ex As SQLiteException
                MsgBox("Erro de SQLite: " & ex.Message)
            Catch ex As Exception
                MsgBox("Erro: " & ex.Message)
            End Try
        End Using
    End Sub

    Sub alterar_senha(novaSenha)
        Using connection As New SQLiteConnection(conString)
            connection.Open()
            Try
                If connection.State = ConnectionState.Open Then
                    Dim commandText As String = "UPDATE tb_usuarios SET senha = @novaSenha WHERE cpf = @cpfLogado"
                    Using command As New SQLiteCommand(commandText, connection)
                        command.Parameters.AddWithValue("@novaSenha", novaSenha)
                        command.Parameters.AddWithValue("@cpfLogado", cpfLogado)
                        command.ExecuteNonQuery()
                    End Using
                End If
            Catch ex As SQLiteException
                MsgBox("Erro de SQLite: " & ex.Message)
            Catch ex As Exception
                MsgBox("Erro: " & ex.Message)
            End Try
        End Using
    End Sub

    Function checar_senha(senha) As Boolean
        Using connection As New SQLiteConnection(conString)
            connection.Open()
            Try
                If connection.State = ConnectionState.Open Then
                    Dim commandText As String = "SELECT senha FROM tb_usuarios WHERE cpf = @cpf"
                    Using command As New SQLiteCommand(commandText, connection)
                        command.Parameters.AddWithValue("@cpf", cpfLogado)
                        Using reader As SQLiteDataReader = command.ExecuteReader
                            If reader.HasRows Then
                                reader.Read()
                                If senha = reader.GetString(0) Then
                                    Return True
                                Else
                                    Return False
                                End If
                            Else
                                Return False
                            End If
                        End Using
                    End Using
                Else
                    Return False
                End If
            Catch ex As SQLiteException
                MsgBox("Erro de SQLite: " & ex.Message)
                Return False
            Catch ex As Exception
                MsgBox("Erro: " & ex.Message)
                Return False
            End Try
        End Using
    End Function

    'subs para limpar campos
    Sub limpar_campos_login()
        With frm_login
            .txt_cpf.Clear()
            .txt_senha.Clear()
        End With
    End Sub

    Sub limpar_campos_cadastro()
        With frm_cadastro_funcionarios
            .txt_novocpf.Clear()
            .txt_nome.Clear()
            .txt_senha.Clear()
            .cmb_acesso.ResetText()
        End With
    End Sub

    Sub limpar_campos_alterar_senha()
        With frm_alterar_senha
            .txt_senha.Clear()
            .txt_nova_senha.Clear()
            .txt_confirmar_senha.Clear()
        End With
    End Sub
End Module