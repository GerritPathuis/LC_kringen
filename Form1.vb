Imports System.IO
Imports System.Text


Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, TabPage1.Enter, NumericUpDown1.ValueChanged, NumericUpDown4.ValueChanged, NumericUpDown3.ValueChanged, NumericUpDown2.ValueChanged
        Dim I As Double = NumericUpDown2.Value      '[A]    
        Dim V As Double = NumericUpDown3.Value      '[V]
        Dim tr = NumericUpDown4.Value / 10 ^ 6      '[us]->[s]
        Dim f = NumericUpDown1.Value * 10 ^ 2       '[Hz]

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
        TextBox32.Text = (f / 1000).ToString("F1")          '[kHz]
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click, NumericUpDown5.ValueChanged, NumericUpDown6.ValueChanged, NumericUpDown8.ValueChanged, NumericUpDown12.ValueChanged, NumericUpDown16.ValueChanged, NumericUpDown15.ValueChanged
        Dim sb As New StringBuilder
        Dim C = NumericUpDown8.Value / 10 ^ 6         '[uF]->[F]
        Dim L = NumericUpDown5.Value / 10 ^ 6           '[uH]->[H]
        Dim R = NumericUpDown6.Value                    '[ohm]

        Dim fact = NumericUpDown12.Value                '[Hz]
        Dim Pow = NumericUpDown15.Value                 '[W]
        Dim vac = NumericUpDown16.Value                 '[V]
        Dim Qfac As Double = 0                          '[-]

        If L > 0 AndAlso C > 0 Then
            Dim omega = 1 / Math.Sqrt(L * C)           '[rad/s]
            Dim f = omega / (2 * Math.PI)                   '[Hz]
            Dim xl = omega * L                              '[ohm]
            Dim xc = 1 / (omega * C)                   '[ohm]
            Dim z = Math.Sqrt(R ^ 2 + xl ^ 2 + xc ^ 2)      '[ohm]
            Dim phase = Math.Atan((xl - xc) / R) ' * 180 / Math.PI '[degree]
            Dim q As Double = 0
            If L > 0 Then q = 1 / (R * Math.Sqrt(C / L)) '[-]
            '====== Actual numbers ======
            Dim xcAct = 1 / (2 * Math.PI * fact * C)                '[ohm]
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

            '====== Q factor ======
            Qfac = 1.0 / R * Math.Sqrt(L / C)
            TextBox23.Text = (C * 10 ^ 9).ToString("F1")    '[uF] 
            TextBox24.Text = (L * 10 ^ 9).ToString("F1")            '[uH]
            TextBox25.Text = R.ToString("F2")                       '[ohm] 
            TextBox26.Text = Qfac.ToString("F1")                    '[-]   
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
        NumericUpDown8.Value = 0.33       'Cx2[uF]->[F]
        NumericUpDown5.Value = 96         'L[uH]->[H]
        NumericUpDown6.Value = 1.0        'R [ohm]
        NumericUpDown12.Value = 28069     'f [Hz]
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ' For 28 kHz Piezo
        NumericUpDown8.Value = 0.692      'Cx2[uF]->[F]
        NumericUpDown5.Value = 34.0       'L[uH]->[H]
        NumericUpDown6.Value = 0.08       'R [ohm]
        NumericUpDown12.Value = 32696     'f [Hz]
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ' For 28 kHz Piezo
        NumericUpDown8.Value = 1.5        'Cx2[uF]->[F]
        NumericUpDown5.Value = 21.4       'L[uH]->[H]
        NumericUpDown6.Value = 0.5        'R [ohm]
        NumericUpDown12.Value = 28045     'f [Hz]
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ' For 28 kHz Piezo
        NumericUpDown8.Value = 2.2        'Cx2[uF]->[F]
        NumericUpDown5.Value = 14.7       'L[uH]->[H]
        NumericUpDown6.Value = 0.5        'R [ohm]
        NumericUpDown12.Value = 27955     'f [Hz]
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sb As New StringBuilder
        sb.AppendLine("Common @ 22mHz")
        sb.AppendLine("R= 3.3/4.7 Ohm")
        sb.AppendLine("C= 220/470 p")
        TextBox27.Text = sb.ToString

        sb.Clear()
        sb.AppendLine("Zs, Zp")
        sb.AppendLine("One is L and one is C")
        sb.AppendLine("The paralles sits at Rmax")
        sb.AppendLine("Impedance Piezo Cleaning element is 20-40 ohm at resonance upto 200 when mounted and loaded")
        sb.AppendLine("")
        TextBox44.Text = sb.ToString

        sb.Clear()
        sb.AppendLine("Use 2 caps for DC isolation of the coil")
        sb.AppendLine("If you split it into two capacitors, each capacitor must have twice the capacitance of the single calculated value ")
        sb.AppendLine("")
        sb.AppendLine("(since capacitors in series halve their total capacitance: \(\frac{1}{C_{total}} = \frac{1}{C_1} + \frac{1}{C_2}\))")
        sb.AppendLine("")
        TextBox48.Text = sb.ToString

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click, NumericUpDown20.ValueChanged, NumericUpDown19.ValueChanged, NumericUpDown17.ValueChanged, NumericUpDown18.ValueChanged, NumericUpDown21.ValueChanged, NumericUpDown22.ValueChanged, NumericUpDown23.ValueChanged, NumericUpDown24.ValueChanged
        PrimaryTrafoCoil()
        SecondaryTrafoCoil()
    End Sub

    Private Sub PrimaryTrafoCoil()
        Dim C = NumericUpDown18.Value / 10 ^ 9           '[nF]->[F]
        Dim L = NumericUpDown17.Value / 10 ^ 6           '[uH]->[H]
        Dim R = NumericUpDown19.Value                    '[ohm]
        Dim f = NumericUpDown20.Value * 10 ^ 3           '[Hz]

        Dim w = 2 * Math.PI * f                          '[rad/s]

        Dim Xl = w * L
        Dim Xc = 1 / (w * C)
        Dim z_serie = Math.Sqrt(R ^ 2 + (Xl - Xc) ^ 2)      '[ohm]
        Dim z_parallel = 1 / (Math.Sqrt(1 / R ^ 2 + (1 / Xl - 1 / Xc) ^ 2))     '[ohm]

        TextBox28.Text = z_serie.ToString("F1")
        TextBox29.Text = z_parallel.ToString("F1")
    End Sub
    Private Sub SecondaryTrafoCoil()
        Dim C = NumericUpDown21.Value / 10 ^ 9           '[nF]->[F]
        Dim L = NumericUpDown24.Value / 10 ^ 6           '[uH]->[H]
        Dim R = NumericUpDown23.Value                    '[ohm]
        Dim f = NumericUpDown22.Value * 10 ^ 3           '[Hz]

        Dim w = 2 * Math.PI * f                          '[rad/s]

        Dim Xl = w * L
        Dim Xc = 1 / (w * C)
        Dim z_serie = Math.Sqrt(R ^ 2 + (Xl - Xc) ^ 2)      '[ohm]
        Dim z_parallel = 1 / (Math.Sqrt(1 / R ^ 2 + (1 / Xl - 1 / Xc) ^ 2))     '[ohm]
        TextBox31.Text = z_serie.ToString("F1")
        TextBox30.Text = z_parallel.ToString("F1")
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click, NumericUpDown29.ValueChanged, NumericUpDown26.ValueChanged, NumericUpDown25.ValueChanged
        NetworkMatching()
    End Sub
    Private Sub NetworkMatching()
        'based on https://www.youtube.com/watch?v=-_T587mucaI
        ' https://www.youtube.com/watch?v=cW1Qn0DQwJM
        ' https://www.youtube.com/watch?v=-cG8Q1Mgrtc

        'Matching network impedance for Rmin to Rmax at frequency f
        Dim f = NumericUpDown25.Value * 10 ^ 3      '[Hz]
        Dim R1 = NumericUpDown26.Value              '[ohm]
        Dim R2 = NumericUpDown29.Value              '[ohm]


        If f > 0 AndAlso R1 > 0 AndAlso R2 > 0 Then

            Dim Rmin As Double = Math.Min(R1, R2)
            Dim Rmax As Double = Math.Max(R1, R2)

            Dim omg = 2 * Math.PI * f                   '[rad/s]
            Dim QEL = Math.Sqrt(Rmax / Rmin - 1)
            Dim Q = QEL / 2                             'Network
            'L-Parallel and C-series
            Dim Lp = (Rmax / omg) * QEL * 10 ^ 6        '[uH]
            Dim Cs = 1 / (omg * QEL * Rmin) * 10 ^ 6    '[uF]
            ' C-series and L-Parallel
            Dim Cp = QEL / (omg * Rmax) * 10 ^ 6        '[uF]
            Dim Ls = (QEL * Rmin) / omg * 10 ^ 6        '[uH]

            TextBox49.Text = Rmax.ToString      '[ohm]
            TextBox50.Text = Rmin.ToString      '[ohm]

            TextBox38.Text = QEL.ToString("F3") '[-]
            TextBox39.Text = Q.ToString("F3")   '[-]

            TextBox40.Text = (Lp).ToString("F1") '[uH] parallel
            TextBox41.Text = (Cs).ToString("F3") '[uF] series

            TextBox42.Text = (Cp).ToString("F3") '[uF] series
            TextBox43.Text = (Ls).ToString("F1") '[uH] parallel
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click, NumericUpDown28.ValueChanged, NumericUpDown30.ValueChanged
        Dim f = NumericUpDown30.Value * 10 ^ 3        '[Hz]
        Dim L = NumericUpDown28.Value / 10 ^ 6        '[uH]->[H]

        Dim c = 1 / (4 * Math.PI ^ 2 * f ^ 2 * L)           '[F]
        TextBox45.Text = (c * 10 ^ 12).ToString("F0")       '[pF] series
        TextBox46.Text = (c * 10 ^ 9).ToString("F1")        '[nF] series
        TextBox47.Text = (c * 10 ^ 6).ToString("F2")        '[uF] series
    End Sub
End Class
