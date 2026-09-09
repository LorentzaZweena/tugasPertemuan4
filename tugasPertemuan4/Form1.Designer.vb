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
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        groupBoxDataPribadi = New GroupBox()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        Label4 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label3 = New Label()
        TempatLahir = New TextBox()
        Label2 = New Label()
        NamaTextBox = New TextBox()
        Label1 = New Label()
        TabPage2 = New TabPage()
        Panel1 = New Panel()
        TextBox2 = New TextBox()
        Label7 = New Label()
        MaskedTextBox1 = New MaskedTextBox()
        Label6 = New Label()
        TextBox1 = New TextBox()
        Label5 = New Label()
        TabPage3 = New TabPage()
        Button1 = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        Label8 = New Label()
        ComboBox1 = New ComboBox()
        Label9 = New Label()
        NumericUpDown1 = New NumericUpDown()
        Label10 = New Label()
        CheckBox1 = New CheckBox()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        groupBoxDataPribadi.SuspendLayout()
        TabPage2.SuspendLayout()
        Panel1.SuspendLayout()
        TabPage3.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(12, 12)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(776, 413)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(groupBoxDataPribadi)
        TabPage1.Location = New Point(4, 34)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(768, 375)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Data Pribadi"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' groupBoxDataPribadi
        ' 
        groupBoxDataPribadi.Controls.Add(RadioButton2)
        groupBoxDataPribadi.Controls.Add(RadioButton1)
        groupBoxDataPribadi.Controls.Add(Label4)
        groupBoxDataPribadi.Controls.Add(DateTimePicker1)
        groupBoxDataPribadi.Controls.Add(Label3)
        groupBoxDataPribadi.Controls.Add(TempatLahir)
        groupBoxDataPribadi.Controls.Add(Label2)
        groupBoxDataPribadi.Controls.Add(NamaTextBox)
        groupBoxDataPribadi.Controls.Add(Label1)
        groupBoxDataPribadi.Location = New Point(6, 15)
        groupBoxDataPribadi.Name = "groupBoxDataPribadi"
        groupBoxDataPribadi.Size = New Size(756, 354)
        groupBoxDataPribadi.TabIndex = 0
        groupBoxDataPribadi.TabStop = False
        groupBoxDataPribadi.Text = "Data Pribadi"
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(222, 225)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(91, 29)
        RadioButton2.TabIndex = 8
        RadioButton2.TabStop = True
        RadioButton2.Text = "Wanita"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(136, 225)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(66, 29)
        RadioButton1.TabIndex = 7
        RadioButton1.TabStop = True
        RadioButton1.Text = "Pria"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(15, 225)
        Label4.Name = "Label4"
        Label4.Size = New Size(115, 25)
        Label4.TabIndex = 6
        Label4.Text = "Jenis kelamin"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(133, 164)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(300, 31)
        DateTimePicker1.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(15, 164)
        Label3.Name = "Label3"
        Label3.Size = New Size(111, 25)
        Label3.TabIndex = 4
        Label3.Text = "Tanggal lahir"
        ' 
        ' TempatLahir
        ' 
        TempatLahir.Location = New Point(133, 102)
        TempatLahir.Name = "TempatLahir"
        TempatLahir.Size = New Size(300, 31)
        TempatLahir.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(15, 102)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 25)
        Label2.TabIndex = 2
        Label2.Text = "Tempat Lahir"
        ' 
        ' NamaTextBox
        ' 
        NamaTextBox.Location = New Point(114, 42)
        NamaTextBox.Name = "NamaTextBox"
        NamaTextBox.Size = New Size(319, 31)
        NamaTextBox.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(15, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 25)
        Label1.TabIndex = 0
        Label1.Text = "Nama"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Panel1)
        TabPage2.Location = New Point(4, 34)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(768, 375)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Kontak"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(MaskedTextBox1)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label5)
        Panel1.Location = New Point(6, 6)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(756, 363)
        Panel1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(118, 211)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(270, 31)
        TextBox2.TabIndex = 5
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(18, 211)
        Label7.Name = "Label7"
        Label7.Size = New Size(54, 25)
        Label7.TabIndex = 4
        Label7.Text = "Email"
        ' 
        ' MaskedTextBox1
        ' 
        MaskedTextBox1.Location = New Point(118, 145)
        MaskedTextBox1.Mask = "000-0000"
        MaskedTextBox1.Name = "MaskedTextBox1"
        MaskedTextBox1.Size = New Size(270, 31)
        MaskedTextBox1.TabIndex = 3
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(18, 145)
        Label6.Name = "Label6"
        Label6.Size = New Size(64, 25)
        Label6.TabIndex = 2
        Label6.Text = "No HP"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(118, 22)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(270, 91)
        TextBox1.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(18, 22)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 25)
        Label5.TabIndex = 0
        Label5.Text = "Alamat"
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(Button1)
        TabPage3.Controls.Add(TableLayoutPanel1)
        TabPage3.Location = New Point(4, 34)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(768, 375)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Pekerjaan"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(371, 16)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 1
        Button1.Text = "Simpan"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(Label8, 0, 0)
        TableLayoutPanel1.Controls.Add(ComboBox1, 1, 0)
        TableLayoutPanel1.Controls.Add(Label9, 0, 1)
        TableLayoutPanel1.Controls.Add(NumericUpDown1, 1, 1)
        TableLayoutPanel1.Controls.Add(Label10, 0, 2)
        TableLayoutPanel1.Controls.Add(CheckBox1, 1, 2)
        TableLayoutPanel1.Location = New Point(19, 16)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 24.5954685F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 75.40453F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 131F))
        TableLayoutPanel1.Size = New Size(318, 313)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(3, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(72, 25)
        Label8.TabIndex = 0
        Label8.Text = "Jabatan"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Staff", "Supervisor", "Manager", "Direktur"})
        ComboBox1.Location = New Point(162, 3)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(153, 33)
        ComboBox1.TabIndex = 1
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(3, 44)
        Label9.Name = "Label9"
        Label9.Size = New Size(115, 25)
        Label9.TabIndex = 2
        Label9.Text = "Lama Bekerja"
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(162, 47)
        NumericUpDown1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(153, 31)
        NumericUpDown1.TabIndex = 3
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(3, 181)
        Label10.Name = "Label10"
        Label10.Size = New Size(60, 25)
        Label10.TabIndex = 4
        Label10.Text = "Status"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(162, 184)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(75, 29)
        CheckBox1.TabIndex = 5
        CheckBox1.Text = "Aktif"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TabControl1)
        Name = "Form1"
        Text = "Form1"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        groupBoxDataPribadi.ResumeLayout(False)
        groupBoxDataPribadi.PerformLayout()
        TabPage2.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TabPage3.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents groupBoxDataPribadi As GroupBox
    Friend WithEvents TempatLahir As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NamaTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox1 As CheckBox

End Class
