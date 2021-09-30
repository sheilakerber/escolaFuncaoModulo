<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAluno = New System.Windows.Forms.TextBox()
        Me.txtCurso = New System.Windows.Forms.TextBox()
        Me.txtDisciplina = New System.Windows.Forms.TextBox()
        Me.btnMatricular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Aluno:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Disciplina:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Curso:"
        '
        'txtAluno
        '
        Me.txtAluno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAluno.Location = New System.Drawing.Point(121, 46)
        Me.txtAluno.Name = "txtAluno"
        Me.txtAluno.Size = New System.Drawing.Size(129, 24)
        Me.txtAluno.TabIndex = 3
        Me.txtAluno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCurso
        '
        Me.txtCurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurso.Location = New System.Drawing.Point(121, 92)
        Me.txtCurso.Name = "txtCurso"
        Me.txtCurso.Size = New System.Drawing.Size(129, 24)
        Me.txtCurso.TabIndex = 4
        Me.txtCurso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDisciplina
        '
        Me.txtDisciplina.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisciplina.Location = New System.Drawing.Point(121, 140)
        Me.txtDisciplina.Name = "txtDisciplina"
        Me.txtDisciplina.Size = New System.Drawing.Size(129, 24)
        Me.txtDisciplina.TabIndex = 5
        Me.txtDisciplina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnMatricular
        '
        Me.btnMatricular.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMatricular.Location = New System.Drawing.Point(37, 193)
        Me.btnMatricular.Name = "btnMatricular"
        Me.btnMatricular.Size = New System.Drawing.Size(213, 36)
        Me.btnMatricular.TabIndex = 6
        Me.btnMatricular.Text = "Matricular"
        Me.btnMatricular.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 267)
        Me.Controls.Add(Me.btnMatricular)
        Me.Controls.Add(Me.txtDisciplina)
        Me.Controls.Add(Me.txtCurso)
        Me.Controls.Add(Me.txtAluno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Escola"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAluno As System.Windows.Forms.TextBox
    Friend WithEvents txtCurso As System.Windows.Forms.TextBox
    Friend WithEvents txtDisciplina As System.Windows.Forms.TextBox
    Friend WithEvents btnMatricular As System.Windows.Forms.Button

End Class
