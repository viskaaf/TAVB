<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRegister))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TBNamaBelakang = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.RBPerempuan = New System.Windows.Forms.RadioButton
        Me.RBLaki = New System.Windows.Forms.RadioButton
        Me.dtpTTL = New System.Windows.Forms.DateTimePicker
        Me.TBPassword = New System.Windows.Forms.TextBox
        Me.TBUsername = New System.Windows.Forms.TextBox
        Me.TBBerat = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.BTRegister = New System.Windows.Forms.Button
        Me.TBTinggi = New System.Windows.Forms.TextBox
        Me.TBNamaDepan = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TBNamaBelakang)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.RBPerempuan)
        Me.GroupBox1.Controls.Add(Me.RBLaki)
        Me.GroupBox1.Controls.Add(Me.dtpTTL)
        Me.GroupBox1.Controls.Add(Me.TBPassword)
        Me.GroupBox1.Controls.Add(Me.TBUsername)
        Me.GroupBox1.Controls.Add(Me.TBBerat)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BTRegister)
        Me.GroupBox1.Controls.Add(Me.TBTinggi)
        Me.GroupBox1.Controls.Add(Me.TBNamaDepan)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(42, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(364, 438)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'TBNamaBelakang
        '
        Me.TBNamaBelakang.Location = New System.Drawing.Point(130, 110)
        Me.TBNamaBelakang.Name = "TBNamaBelakang"
        Me.TBNamaBelakang.Size = New System.Drawing.Size(200, 20)
        Me.TBNamaBelakang.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 15)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Nama Belakang"
        '
        'RBPerempuan
        '
        Me.RBPerempuan.AutoSize = True
        Me.RBPerempuan.Location = New System.Drawing.Point(224, 256)
        Me.RBPerempuan.Name = "RBPerempuan"
        Me.RBPerempuan.Size = New System.Drawing.Size(79, 17)
        Me.RBPerempuan.TabIndex = 22
        Me.RBPerempuan.TabStop = True
        Me.RBPerempuan.Text = "Perempuan"
        Me.RBPerempuan.UseVisualStyleBackColor = True
        '
        'RBLaki
        '
        Me.RBLaki.AutoSize = True
        Me.RBLaki.Location = New System.Drawing.Point(134, 256)
        Me.RBLaki.Name = "RBLaki"
        Me.RBLaki.Size = New System.Drawing.Size(64, 17)
        Me.RBLaki.TabIndex = 21
        Me.RBLaki.TabStop = True
        Me.RBLaki.Text = "Laki-laki"
        Me.RBLaki.UseVisualStyleBackColor = True
        '
        'dtpTTL
        '
        Me.dtpTTL.Location = New System.Drawing.Point(126, 144)
        Me.dtpTTL.Name = "dtpTTL"
        Me.dtpTTL.Size = New System.Drawing.Size(204, 20)
        Me.dtpTTL.TabIndex = 20
        '
        'TBPassword
        '
        Me.TBPassword.Location = New System.Drawing.Point(126, 326)
        Me.TBPassword.Name = "TBPassword"
        Me.TBPassword.Size = New System.Drawing.Size(204, 20)
        Me.TBPassword.TabIndex = 19
        Me.TBPassword.UseSystemPasswordChar = True
        '
        'TBUsername
        '
        Me.TBUsername.Location = New System.Drawing.Point(126, 292)
        Me.TBUsername.Name = "TBUsername"
        Me.TBUsername.Size = New System.Drawing.Size(204, 20)
        Me.TBUsername.TabIndex = 18
        '
        'TBBerat
        '
        Me.TBBerat.Location = New System.Drawing.Point(126, 215)
        Me.TBBerat.Name = "TBBerat"
        Me.TBBerat.Size = New System.Drawing.Size(204, 20)
        Me.TBBerat.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 327)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 15)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Password"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 293)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 15)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Username"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 256)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 15)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Jenis Kelamin"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Berat Badan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Tinggi Badan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Tanggal Lahir"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nama Depan"
        '
        'BTRegister
        '
        Me.BTRegister.BackColor = System.Drawing.Color.SeaGreen
        Me.BTRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTRegister.Location = New System.Drawing.Point(134, 382)
        Me.BTRegister.Name = "BTRegister"
        Me.BTRegister.Size = New System.Drawing.Size(94, 33)
        Me.BTRegister.TabIndex = 7
        Me.BTRegister.Text = "REGISTER"
        Me.BTRegister.UseVisualStyleBackColor = False
        '
        'TBTinggi
        '
        Me.TBTinggi.Location = New System.Drawing.Point(126, 180)
        Me.TBTinggi.Name = "TBTinggi"
        Me.TBTinggi.Size = New System.Drawing.Size(204, 20)
        Me.TBTinggi.TabIndex = 6
        '
        'TBNamaDepan
        '
        Me.TBNamaDepan.Location = New System.Drawing.Point(130, 75)
        Me.TBNamaDepan.Name = "TBNamaDepan"
        Me.TBNamaDepan.Size = New System.Drawing.Size(200, 20)
        Me.TBNamaDepan.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(121, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REGISTER"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.ESERI
        Me.PictureBox1.Location = New System.Drawing.Point(180, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(83, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'FormRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(450, 534)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BTRegister As System.Windows.Forms.Button
    Friend WithEvents TBNamaDepan As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RBPerempuan As System.Windows.Forms.RadioButton
    Friend WithEvents RBLaki As System.Windows.Forms.RadioButton
    Friend WithEvents dtpTTL As System.Windows.Forms.DateTimePicker
    Friend WithEvents TBPassword As System.Windows.Forms.TextBox
    Friend WithEvents TBUsername As System.Windows.Forms.TextBox
    Friend WithEvents TBBerat As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TBTinggi As System.Windows.Forms.TextBox
    Friend WithEvents TBNamaBelakang As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
