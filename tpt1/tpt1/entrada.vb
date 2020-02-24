Public Class entrada
    Public j(6) As String
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt1.TextChanged
        j(1) = txt1.Text
    End Sub

    Private Sub btnp_Click(sender As Object, e As EventArgs) Handles btnp.Click
        jogo.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)
        j(3) = txt3.Text
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)
        j(5) = txt5.Text
    End Sub

    Private Sub txt2_TextChanged(sender As Object, e As EventArgs)
        j(2) = txt2.Text
    End Sub

    Private Sub txt4_TextChanged(sender As Object, e As EventArgs)
        j(4) = txt4.Text
    End Sub

    Private Sub txt6_TextChanged(sender As Object, e As EventArgs)
        j(6) = txt6.Text
    End Sub
End Class