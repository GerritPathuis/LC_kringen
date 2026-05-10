Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, TabPage1.Enter, NumericUpDown1.ValueChanged, NumericUpDown4.ValueChanged, NumericUpDown3.ValueChanged, NumericUpDown2.ValueChanged
        Dim I As Double = NumericUpDown2.Value      '[A]    
        Dim V As Double = NumericUpDown3.Value      '[V]
        Dim tr = NumericUpDown4.Value / 10 ^ 6      '[us]->[s]
        Dim f = NumericUpDown1.Value * 1000         '[Hz]

        Dim C = I * tr / V
        Dim R = 1 / (2 * Math.PI * f * C)

        TextBox1.Text = (C * 10 ^ 9).ToString("F0")        '[nF]
        TextBox2.Text = R.ToString("F1")                   '[ohm]
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click, NumericUpDown9.ValueChanged, NumericUpDown10.ValueChanged
        Dim L = NumericUpDown9.Value / 10 ^ 6    '[uH]->[H]    
        Dim C = NumericUpDown10.Value / 10 ^ 6   '[uF]->[F]

        Dim f = 1 / (2 * Math.PI * Math.Sqrt(L * C))       '[Hz]
        TextBox4.Text = (f / 1000).ToString("F1")          '[kHz]
        Label15.Text = "1u= 1000n= 1000000p"
        TextBox5.Text = "https://www.wa4dsy.net/filter/filterdesign.html"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click, NumericUpDown11.ValueChanged, NumericUpDown14.ValueChanged, NumericUpDown13.ValueChanged
        Dim I = NumericUpDown11.Value           '[A]    
        Dim Diam = NumericUpDown14.Value        '[mm]    
        Dim Length = NumericUpDown13.Value      '[m]    
        Dim Area = Math.PI / 4 * Diam ^ 2       '[mm2]
        Dim ro = 0.01724                        '[ohm*m] for copper

        Dim R = ro * Length / Area              '[ohm]
        Dim pow = I * I * R                     '[W]
        TextBox6.Text = pow.ToString("F1")      '[W]
        TextBox7.Text = R.ToString("F3")        '[ohm]
        TextBox8.Text = Area.ToString("F2")     '[mm2]
    End Sub
End Class
