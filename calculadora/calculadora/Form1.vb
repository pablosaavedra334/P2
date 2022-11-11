Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label3.Click, Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()


    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged, TextBox3.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num1 As Integer
        Dim num2 As Integer
        Dim resultado As Integer

        num1 = Val(TextBox1.Text)
        num2 = Val(TextBox2.Text)
        resultado = Val(TextBox3.Text)

        resultado = Val(num1) + Val(num2)

        TextBox3.Text = resultado


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim num1 As Integer
        Dim num2 As Integer
        Dim resultado As Integer

        num1 = Val(TextBox1.Text)
        num2 = Val(TextBox2.Text)
        resultado = Val(TextBox3.Text)

        resultado = Val(num1) - Val(num2)

        TextBox3.Text = resultado
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim num1 As Integer
        Dim num2 As Integer
        Dim resultado As Integer

        num1 = Val(TextBox1.Text)
        num2 = Val(TextBox2.Text)
        resultado = Val(TextBox3.Text)

        resultado = Val(num1) * Val(num2)

        TextBox3.Text = resultado
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim num1 As Integer
        Dim num2 As Integer
        Dim resultado As Integer

        num1 = Val(TextBox1.Text)
        num2 = Val(TextBox2.Text)
        resultado = Val(TextBox3.Text)

        resultado = Val(num1) / Val(num2)

        TextBox3.Text = resultado
    End Sub
End Class



