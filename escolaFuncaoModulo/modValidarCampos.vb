Module modValidarCampos

    ' funcao para validar entrada de dados
    Public Function validarCampos(aluno, curso, disciplina) As Boolean
        ' ifs: se tiver algum campo invalido, retornar falso
        If (aluno = Nothing Or IsNumeric(aluno)) Then
            MsgBox("O campo aluno está em branco ou não é válido. Por favor, verifique.", MsgBoxStyle.Critical, "Atenção!")
            Return False
        End If

        If (curso = Nothing Or IsNumeric(curso)) Then
            MsgBox("O campo curso está em branco ou não é válido. Por favor, verifique.", MsgBoxStyle.Critical, "Atenção!")
            Return False
        End If

        If (disciplina = Nothing Or IsNumeric(disciplina)) Then
            MsgBox("O disciplina curso está em branco ou não é válido. Por favor, verifique.", MsgBoxStyle.Critical, "Atenção!")
            Return False
        End If

        ' se estiver tudo certo, exibir msg ao usuario e retornar verdadeiro
        MsgBox("Campos validados com sucesso!", MsgBoxStyle.OkOnly, "Confirmação de validação")
        Return True
    End Function
End Module
