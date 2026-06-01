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
        Dim I = NumericUpDown11.Value           '[A] current through the wire   
        Dim Diam = NumericUpDown14.Value        '[mm] wire diameter   
        Dim Length = NumericUpDown13.Value      '[m] wire length 
        Dim Area = Math.PI / 4 * Diam ^ 2       '[mm2] wire cross-sectional area
        Dim ro = 0.01724                        '[ohm*m] for copper

        Dim R = ro * Length / Area              '[ohm]
        Dim powLoss = I * I * R                 '[W] power loss in the wire

        TextBox6.Text = powLoss.ToString("F1")  '[W] power loss in the wire
        TextBox7.Text = R.ToString("F3")        '[ohm] wire resistance
        TextBox8.Text = Area.ToString("F2")     '[mm2] cross section area of the wire
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click, NumericUpDown5.ValueChanged, NumericUpDown6.ValueChanged, NumericUpDown7.ValueChanged, NumericUpDown8.ValueChanged, NumericUpDown12.ValueChanged, NumericUpDown16.ValueChanged, NumericUpDown15.ValueChanged
        Dim sb As New StringBuilder
        Dim C = NumericUpDown7.Value / 10 ^ 9           '[nF]->[F]
        Dim Cx2 = NumericUpDown8.Value / 10 ^ 6         '[uF]->[F]
        Dim L = NumericUpDown5.Value / 10 ^ 6           '[uH]->[H]
        Dim R = NumericUpDown6.Value                    '[ohm]
        Dim Ctotal = C + Cx2                            '[F]
        Dim fact = NumericUpDown12.Value                '[Hz]
        Dim Pow = NumericUpDown15.Value                 '[W]
        Dim vac = NumericUpDown16.Value                 '[V]

        If L > 0 AndAlso Ctotal > 0 Then
            Dim omega = 1 / Math.Sqrt(L * Ctotal)           '[rad/s]
            Dim f = omega / (2 * Math.PI)                   '[Hz]
            Dim xl = omega * L                              '[ohm]
            Dim xc = 1 / (omega * Ctotal)                   '[ohm]
            Dim z = Math.Sqrt(R ^ 2 + xl ^ 2 + xc ^ 2)      '[ohm]
            Dim phase = Math.Atan((xl - xc) / R) ' * 180 / Math.PI '[degree]
            Dim q As Double = 0
            If L > 0 Then q = 1 / (R * Math.Sqrt(Ctotal / L)) '[-]
            '====== Actual numbers ======
            Dim xcAct = 1 / (2 * Math.PI * fact * Ctotal)         '[ohm]
            Dim xlAct = 2 * Math.PI * fact * L                    '[ohm]
            Dim zAct = Math.Sqrt(R ^ 2 + xlAct ^ 2 + xcAct ^ 2)   '[ohm]
            Dim phaseAct = Math.Atan((xlAct - xcAct) / R) * 180 / Math.PI '[degree] 
            '====== Power, Current ======
            Dim iResonant = 2 * Math.PI * Pow / (vac * Math.Sqrt(2))  '[A]

            TextBox17.Text = omega.ToString("F0")           '[rad/s]
            TextBox9.Text = f.ToString("F0")                '[Hz]
            TextBox10.Text = xc.ToString("F2")              '[ohm]
            TextBox11.Text = xl.ToString("F2")              '[ohm]
            TextBox12.Text = z.ToString("F1")               '[ohm]
            TextBox14.Text = phase.ToString("F1")           '[degree]
            TextBox16.Text = q.ToString("F1")               '[-]
            '====== Actual numbers ======
            TextBox22.Text = xc.ToString("F2")              '[ohm] actual at fact
            TextBox21.Text = xl.ToString("F2")              '[ohm] actual at fact
            TextBox20.Text = zAct.ToString("F1")            '[ohm] actual at fact
            TextBox18.Text = phaseAct.ToString("F1")        '[degree] actual at fact   
            '====== Actual numbers ======
            TextBox19.Text = iResonant.ToString("F1")       '[A] resonant current at given power and voltage

        End If
        sb.AppendLine("Piezo Capacity 4.9nF @1kHz")
        sb.AppendLine("Piezo series inductor 5.5uH")
        TextBox13.Text = sb.ToString
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click, TabPage5.Enter
        Dim sb As New StringBuilder
        sb.AppendLine("C= C1+C2+...+Cx")
        TextBox15.Text = sb.ToString
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' For 28 kHz Piezo
        NumericUpDown7.Value = 4.9        'C[nF]->[F]
        NumericUpDown8.Value = 0.33       'Cx2[uF]->[F]
        NumericUpDown5.Value = 96         'L[uH]->[H]
        NumericUpDown6.Value = 1.0        'R [ohm]
        NumericUpDown12.Value = 28069     'f [Hz]
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ' For 28 kHz Piezo
        NumericUpDown7.Value = 4.9        'C[nF]->[F]
        NumericUpDown8.Value = 0.692      'Cx2[uF]->[F]
        NumericUpDown5.Value = 34.0       'L[uH]->[H]
        NumericUpDown6.Value = 0.08       'R [ohm]
        NumericUpDown12.Value = 32696     'f [Hz]
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ' For 28 kHz Piezo
        NumericUpDown7.Value = 4.9        'C[nF]->[F]
        NumericUpDown8.Value = 1.5        'Cx2[uF]->[F]
        NumericUpDown5.Value = 21.4       'L[uH]->[H]
        NumericUpDown6.Value = 0.5        'R [ohm]
        NumericUpDown12.Value = 28045     'f [Hz]
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ' For 28 kHz Piezo
        NumericUpDown7.Value = 4.9        'C[nF]->[F]
        NumericUpDown8.Value = 2.2        'Cx2[uF]->[F]
        NumericUpDown5.Value = 14.7       'L[uH]->[H]
        NumericUpDown6.Value = 0.5        'R [ohm]
        NumericUpDown12.Value = 27955     'f [Hz]
    End Sub
End Class
