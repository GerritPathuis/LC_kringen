<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        NumericUpDown2 = New NumericUpDown()
        Label2 = New Label()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        NumericUpDown1 = New NumericUpDown()
        Label11 = New Label()
        TextBox2 = New TextBox()
        Label10 = New Label()
        TextBox1 = New TextBox()
        Button1 = New Button()
        Label6 = New Label()
        NumericUpDown4 = New NumericUpDown()
        Label4 = New Label()
        NumericUpDown3 = New NumericUpDown()
        Label3 = New Label()
        TabPage2 = New TabPage()
        Button2 = New Button()
        PictureBox2 = New PictureBox()
        NumericUpDown5 = New NumericUpDown()
        Label5 = New Label()
        NumericUpDown6 = New NumericUpDown()
        Label7 = New Label()
        NumericUpDown7 = New NumericUpDown()
        Label8 = New Label()
        Label9 = New Label()
        NumericUpDown8 = New NumericUpDown()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown4, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown3, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown5, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown6, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown7, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown8, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Right
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(512, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(696, 682)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(76, 256)
        Label1.Name = "Label1"
        Label1.Size = New Size(229, 32)
        Label1.TabIndex = 1
        Label1.Text = "CS, Capacitance [uF]"
        ' 
        ' NumericUpDown2
        ' 
        NumericUpDown2.DecimalPlaces = 1
        NumericUpDown2.Location = New Point(322, 122)
        NumericUpDown2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumericUpDown2.Name = "NumericUpDown2"
        NumericUpDown2.Size = New Size(131, 35)
        NumericUpDown2.TabIndex = 4
        NumericUpDown2.TextAlign = HorizontalAlignment.Center
        NumericUpDown2.Value = New Decimal(New Integer() {5, 0, 0, 0})
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(76, 122)
        Label2.Name = "Label2"
        Label2.Size = New Size(204, 32)
        Label2.TabIndex = 3
        Label2.Text = "I; Current Peak [A]"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1219, 731)
        TabControl1.TabIndex = 5
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(NumericUpDown1)
        TabPage1.Controls.Add(Label11)
        TabPage1.Controls.Add(TextBox2)
        TabPage1.Controls.Add(Label10)
        TabPage1.Controls.Add(TextBox1)
        TabPage1.Controls.Add(Button1)
        TabPage1.Controls.Add(Label6)
        TabPage1.Controls.Add(NumericUpDown4)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(NumericUpDown3)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(PictureBox1)
        TabPage1.Controls.Add(NumericUpDown2)
        TabPage1.Controls.Add(Label1)
        TabPage1.Controls.Add(Label2)
        TabPage1.Location = New Point(4, 39)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1211, 688)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Snubber"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.DecimalPlaces = 1
        NumericUpDown1.Location = New Point(322, 78)
        NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(131, 35)
        NumericUpDown1.TabIndex = 16
        NumericUpDown1.TextAlign = HorizontalAlignment.Center
        NumericUpDown1.Value = New Decimal(New Integer() {282, 0, 0, 65536})
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(76, 78)
        Label11.Name = "Label11"
        Label11.Size = New Size(186, 32)
        Label11.TabIndex = 15
        Label11.Text = "Frequency [kHz]"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(322, 303)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(131, 35)
        TextBox2.TabIndex = 14
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(76, 298)
        Label10.Name = "Label10"
        Label10.Size = New Size(237, 32)
        Label10.TabIndex = 13
        Label10.Text = "RS, Resistance [Ohm]"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(322, 259)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(131, 35)
        TextBox1.TabIndex = 12
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(76, 536)
        Button1.Name = "Button1"
        Button1.Size = New Size(131, 40)
        Button1.TabIndex = 11
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(58, 631)
        Label6.Name = "Label6"
        Label6.Size = New Size(308, 32)
        Label6.TabIndex = 10
        Label6.Text = " 1 uH = 1000 nH= 10^6 pH"
        ' 
        ' NumericUpDown4
        ' 
        NumericUpDown4.DecimalPlaces = 1
        NumericUpDown4.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        NumericUpDown4.Location = New Point(322, 209)
        NumericUpDown4.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        NumericUpDown4.Name = "NumericUpDown4"
        NumericUpDown4.Size = New Size(131, 35)
        NumericUpDown4.TabIndex = 8
        NumericUpDown4.TextAlign = HorizontalAlignment.Center
        NumericUpDown4.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(76, 209)
        Label4.Name = "Label4"
        Label4.Size = New Size(211, 32)
        Label4.TabIndex = 7
        Label4.Text = "tr; Voltage rise [us]"
        ' 
        ' NumericUpDown3
        ' 
        NumericUpDown3.Location = New Point(322, 167)
        NumericUpDown3.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        NumericUpDown3.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumericUpDown3.Name = "NumericUpDown3"
        NumericUpDown3.Size = New Size(131, 35)
        NumericUpDown3.TabIndex = 6
        NumericUpDown3.TextAlign = HorizontalAlignment.Center
        NumericUpDown3.Value = New Decimal(New Integer() {12, 0, 0, 0})
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(76, 167)
        Label3.Name = "Label3"
        Label3.Size = New Size(215, 32)
        Label3.TabIndex = 5
        Label3.Text = "V; Voltage peak [V]"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Button2)
        TabPage2.Controls.Add(PictureBox2)
        TabPage2.Controls.Add(NumericUpDown5)
        TabPage2.Controls.Add(Label5)
        TabPage2.Controls.Add(NumericUpDown6)
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(NumericUpDown7)
        TabPage2.Controls.Add(Label8)
        TabPage2.Controls.Add(Label9)
        TabPage2.Controls.Add(NumericUpDown8)
        TabPage2.Location = New Point(4, 39)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1211, 688)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Series LC resonance"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(179, 499)
        Button2.Name = "Button2"
        Button2.Size = New Size(141, 41)
        Button2.TabIndex = 18
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Dock = DockStyle.Right
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(547, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(661, 682)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 17
        PictureBox2.TabStop = False
        ' 
        ' NumericUpDown5
        ' 
        NumericUpDown5.Location = New Point(359, 218)
        NumericUpDown5.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        NumericUpDown5.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumericUpDown5.Name = "NumericUpDown5"
        NumericUpDown5.Size = New Size(131, 35)
        NumericUpDown5.TabIndex = 16
        NumericUpDown5.TextAlign = HorizontalAlignment.Center
        NumericUpDown5.Value = New Decimal(New Integer() {472, 0, 0, 0})
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(21, 218)
        Label5.Name = "Label5"
        Label5.Size = New Size(324, 32)
        Label5.TabIndex = 15
        Label5.Text = "Piezo Parelle Inductance [nH]"
        ' 
        ' NumericUpDown6
        ' 
        NumericUpDown6.Location = New Point(359, 176)
        NumericUpDown6.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        NumericUpDown6.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumericUpDown6.Name = "NumericUpDown6"
        NumericUpDown6.Size = New Size(131, 35)
        NumericUpDown6.TabIndex = 14
        NumericUpDown6.TextAlign = HorizontalAlignment.Center
        NumericUpDown6.Value = New Decimal(New Integer() {300, 0, 0, 0})
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(21, 176)
        Label7.Name = "Label7"
        Label7.Size = New Size(322, 32)
        Label7.TabIndex = 13
        Label7.Text = "Piezo Serie Resistance [Ohm]"
        ' 
        ' NumericUpDown7
        ' 
        NumericUpDown7.DecimalPlaces = 1
        NumericUpDown7.Location = New Point(359, 131)
        NumericUpDown7.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumericUpDown7.Name = "NumericUpDown7"
        NumericUpDown7.Size = New Size(131, 35)
        NumericUpDown7.TabIndex = 12
        NumericUpDown7.TextAlign = HorizontalAlignment.Center
        NumericUpDown7.Value = New Decimal(New Integer() {22, 0, 0, 0})
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(21, 90)
        Label8.Name = "Label8"
        Label8.Size = New Size(186, 32)
        Label8.TabIndex = 9
        Label8.Text = "Frequency [kHz]"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(21, 131)
        Label9.Name = "Label9"
        Label9.Size = New Size(253, 32)
        Label9.TabIndex = 11
        Label9.Text = "Piezo Capacitance [nF]"
        ' 
        ' NumericUpDown8
        ' 
        NumericUpDown8.DecimalPlaces = 1
        NumericUpDown8.Location = New Point(359, 90)
        NumericUpDown8.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumericUpDown8.Name = "NumericUpDown8"
        NumericUpDown8.Size = New Size(131, 35)
        NumericUpDown8.TabIndex = 10
        NumericUpDown8.TextAlign = HorizontalAlignment.Center
        NumericUpDown8.Value = New Decimal(New Integer() {228, 0, 0, 65536})
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1219, 731)
        Controls.Add(TabControl1)
        Name = "Form1"
        Text = "LC kringen"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown4, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown3, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown5, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown6, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown7, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown8, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents NumericUpDown4 As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents NumericUpDown3 As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents NumericUpDown5 As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents NumericUpDown6 As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents NumericUpDown7 As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents NumericUpDown8 As NumericUpDown
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label11 As Label

End Class
