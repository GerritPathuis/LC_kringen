Imports System.Text

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
        Label6.Text = "1u= 1000n= 1000000p"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click, NumericUpDown9.ValueChanged, NumericUpDown10.ValueChanged
        Dim L = NumericUpDown9.Value / 10 ^ 6           '[uH]->[H]    
        Dim C = NumericUpDown10.Value / 10 ^ 6          '[uF]->[F]

        Dim f = 1 / (2 * Math.PI * Math.Sqrt(L * C))       '[Hz]
        TextBox4.Text = (f / 1000).ToString("F1")          '[kHz]
        TextBox5.Text = "https://www.wa4dsy.net/filter/filterdesign.html"
        Label15.Text = "1u= 1000n= 1000000p"
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click, NumericUpDown5.ValueChanged, NumericUpDown6.ValueChanged, NumericUpDown7.ValueChanged, NumericUpDown8.ValueChanged
        Dim sb As New StringBuilder
        Dim C = NumericUpDown7.Value / 10 ^ 9           '[nF]->[F]
        Dim Cx2 = NumericUpDown8.Value / 10 ^ 6         '[uF]->[F]
        Dim L = NumericUpDown5.Value / 10 ^ 6           '[uH]->[H]
        Dim R = NumericUpDown6.Value                    '[ohm]
        Dim Ctotal = C + Cx2                            '[F]

        Dim f = 1 / (2 * Math.PI * Math.Sqrt(L * Ctotal)) '[Hz]
        Dim xl = 2 * Math.PI * f * L                    '[ohm]
        Dim xc = 1 / (2 * Math.PI * f * Ctotal)         '[ohm]
        Dim z = Math.Sqrt(R ^ 2 + xl ^ 2 + xc ^ 2)      '[ohm]
        Dim phase = Math.Atan((xl - xc) / R) * 180 / Math.PI '[degree]
        Dim q As Double = 0
        If L > 0 Then q = 1 / (R * Math.Sqrt(Ctotal / L)) '[-]

        TextBox9.Text = (f / 1000).ToString("F1")       '[kHz]
        TextBox10.Text = xc.ToString("F1")              '[ohm]
        TextBox11.Text = xl.ToString("F1")              '[ohm]
        TextBox12.Text = z.ToString("F1")               '[ohm]
        TextBox14.Text = phase.ToString("F1")           '[degree]
        TextBox16.Text = q.ToString("F1")           '[-]

        sb.AppendLine("Piezo Capacity 4.9nF @1kHz")
        sb.AppendLine("Piezo series inductor 5.5uH")
        TextBox13.Text = sb.ToString
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click, TabPage5.Enter
        Dim sb As New StringBuilder
        sb.AppendLine("C= C1+C2+...+Cx")
        TextBox15.Text = sb.ToString
    End Sub


End Class
