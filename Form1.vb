Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, TabPage1.Enter, NumericUpDown1.ValueChanged, NumericUpDown4.ValueChanged, NumericUpDown3.ValueChanged, NumericUpDown2.ValueChanged
        Dim I As Double = NumericUpDown2.Value      '[A]    
        Dim V As Double = NumericUpDown3.Value      '[V]
        Dim tr = NumericUpDown4.Value / 10 ^ 6      '[s]
        Dim f = NumericUpDown1.Value * 1000         '[Hz]

        Dim C = I * tr / V
        Dim R = 1 / (2 * Math.PI * f * C)

        TextBox1.Text = (C * 10 ^ 6).ToString("F3")        '[uF]
        TextBox2.Text = R.ToString("F1")                   '[ohm]
    End Sub
End Class
