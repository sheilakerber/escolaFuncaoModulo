Public Class mainForm

    Private Sub btnMatricular_Click(sender As Object, e As EventArgs) Handles btnMatricular.Click

        ' salva os dados em variaveis
        Dim aluno As String = txtAluno.Text
        Dim curso As String = txtCurso.Text
        Dim disciplina As String = txtDisciplina.Text

        ' passa as variaveis na funcao
        modValidarCampos.validarCampos(aluno, curso, disciplina)

        ' limpa todos os campos
        txtAluno.Text = Nothing
        txtCurso.Text = Nothing
        txtDisciplina.Text = Nothing
    End Sub
End Class
