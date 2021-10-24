<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Anggota
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.tbNAMA = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbKTP = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.tbHOBI = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.tbTLP = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.tbALAMAT = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.tbIBU = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.radioWanita = New System.Windows.Forms.RadioButton()
        Me.radioPria = New System.Windows.Forms.RadioButton()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.comboGOLDAR = New System.Windows.Forms.ComboBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.comboAGAMA = New System.Windows.Forms.ComboBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.tbUMUR = New System.Windows.Forms.TextBox()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.comboSTATUSNIKAH = New System.Windows.Forms.ComboBox()
        Me.btnSAVE = New System.Windows.Forms.Button()
        Me.btnDELETE = New System.Windows.Forms.Button()
        Me.btnCLOSE = New System.Windows.Forms.Button()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.dataGridAnggota = New System.Windows.Forms.DataGridView()
        Me.IdAnggotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaAnggotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoKtpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JenisKelaminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlamatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GolDarahDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoTlpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgamaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UmurDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HobiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaIbuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusPerkawinanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblAnggotaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbQuizDataSet = New _201901251039_TOBI_QUIZ.dbQuizDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.TblAnggotaTableAdapter = New _201901251039_TOBI_QUIZ.dbQuizDataSetTableAdapters.tblAnggotaTableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        CType(Me.dataGridAnggota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblAnggotaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbQuizDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox14.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.tbID)
        Me.GroupBox1.Font = New System.Drawing.Font("Tw Cen MT Condensed", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(72, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(124, 61)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ID Anggota"
        '
        'tbID
        '
        Me.tbID.BackColor = System.Drawing.Color.White
        Me.tbID.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbID.Location = New System.Drawing.Point(6, 17)
        Me.tbID.Name = "tbID"
        Me.tbID.Size = New System.Drawing.Size(110, 34)
        Me.tbID.TabIndex = 0
        Me.tbID.Text = "TI-00002019"
        '
        'tbNAMA
        '
        Me.tbNAMA.BackColor = System.Drawing.Color.White
        Me.tbNAMA.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNAMA.Location = New System.Drawing.Point(6, 17)
        Me.tbNAMA.Name = "tbNAMA"
        Me.tbNAMA.Size = New System.Drawing.Size(296, 34)
        Me.tbNAMA.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.tbNAMA)
        Me.GroupBox2.Font = New System.Drawing.Font("Tw Cen MT Condensed", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(72, 121)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(310, 61)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nama"
        '
        'tbKTP
        '
        Me.tbKTP.BackColor = System.Drawing.Color.White
        Me.tbKTP.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbKTP.Location = New System.Drawing.Point(6, 17)
        Me.tbKTP.Name = "tbKTP"
        Me.tbKTP.Size = New System.Drawing.Size(167, 34)
        Me.tbKTP.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.tbKTP)
        Me.GroupBox3.Font = New System.Drawing.Font("Tw Cen MT Condensed", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(201, 61)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(181, 61)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "No. KTP"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.tbHOBI)
        Me.GroupBox4.Font = New System.Drawing.Font("Tw Cen MT Condensed", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(72, 428)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(310, 61)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Hobi"
        '
        'tbHOBI
        '
        Me.tbHOBI.BackColor = System.Drawing.Color.White
        Me.tbHOBI.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbHOBI.Location = New System.Drawing.Point(6, 17)
        Me.tbHOBI.Name = "tbHOBI"
        Me.tbHOBI.Size = New System.Drawing.Size(296, 34)
        Me.tbHOBI.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.tbTLP)
        Me.GroupBox5.Font = New System.Drawing.Font("Tw Cen MT Condensed", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(72, 365)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(310, 61)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "No. Telp"
        '
        'tbTLP
        '
        Me.tbTLP.BackColor = System.Drawing.Color.White
        Me.tbTLP.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTLP.Location = New System.Drawing.Point(6, 17)
        Me.tbTLP.Name = "tbTLP"
        Me.tbTLP.Size = New System.Drawing.Size(296, 34)
        Me.tbTLP.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.tbALAMAT)
        Me.GroupBox6.Font = New System.Drawing.Font("Tw Cen MT Condensed", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.White
        Me.GroupBox6.Location = New System.Drawing.Point(72, 244)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(310, 61)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Alamat"
        '
        'tbALAMAT
        '
        Me.tbALAMAT.BackColor = System.Drawing.Color.White
        Me.tbALAMAT.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbALAMAT.Location = New System.Drawing.Point(6, 17)
        Me.tbALAMAT.Name = "tbALAMAT"
        Me.tbALAMAT.Size = New System.Drawing.Size(296, 34)
        Me.tbALAMAT.TabIndex = 0
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox9.Controls.Add(Me.tbIBU)
        Me.GroupBox9.Font = New System.Drawing.Font("Tw Cen MT Condensed", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.ForeColor = System.Drawing.Color.White
        Me.GroupBox9.Location = New System.Drawing.Point(72, 488)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(310, 61)
        Me.GroupBox9.TabIndex = 2
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Nama Ibu"
        '
        'tbIBU
        '
        Me.tbIBU.BackColor = System.Drawing.Color.White
        Me.tbIBU.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbIBU.Location = New System.Drawing.Point(6, 17)
        Me.tbIBU.Name = "tbIBU"
        Me.tbIBU.Size = New System.Drawing.Size(296, 34)
        Me.tbIBU.TabIndex = 0
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox7.Controls.Add(Me.radioWanita)
        Me.GroupBox7.Controls.Add(Me.radioPria)
        Me.GroupBox7.Font = New System.Drawing.Font("Tw Cen MT Condensed", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.White
        Me.GroupBox7.Location = New System.Drawing.Point(72, 182)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(310, 61)
        Me.GroupBox7.TabIndex = 3
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Jenis Kelamin"
        '
        'radioWanita
        '
        Me.radioWanita.AutoSize = True
        Me.radioWanita.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioWanita.Location = New System.Drawing.Point(151, 20)
        Me.radioWanita.Name = "radioWanita"
        Me.radioWanita.Size = New System.Drawing.Size(136, 33)
        Me.radioWanita.TabIndex = 1
        Me.radioWanita.Text = "Perempuan"
        Me.radioWanita.UseVisualStyleBackColor = True
        '
        'radioPria
        '
        Me.radioPria.AutoSize = True
        Me.radioPria.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioPria.Location = New System.Drawing.Point(30, 20)
        Me.radioPria.Name = "radioPria"
        Me.radioPria.Size = New System.Drawing.Size(106, 33)
        Me.radioPria.TabIndex = 0
        Me.radioPria.Text = "Laki-laki"
        Me.radioPria.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox8.Controls.Add(Me.comboGOLDAR)
        Me.GroupBox8.Font = New System.Drawing.Font("Tw Cen MT Condensed", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.ForeColor = System.Drawing.Color.White
        Me.GroupBox8.Location = New System.Drawing.Point(72, 304)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(105, 61)
        Me.GroupBox8.TabIndex = 3
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Golongan Darah"
        '
        'comboGOLDAR
        '
        Me.comboGOLDAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.comboGOLDAR.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboGOLDAR.FormattingEnabled = True
        Me.comboGOLDAR.Items.AddRange(New Object() {"A", "A+", "AB", "B", "B+", "O"})
        Me.comboGOLDAR.Location = New System.Drawing.Point(19, 19)
        Me.comboGOLDAR.Name = "comboGOLDAR"
        Me.comboGOLDAR.Size = New System.Drawing.Size(60, 35)
        Me.comboGOLDAR.TabIndex = 0
        Me.comboGOLDAR.Text = "A"
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox10.Controls.Add(Me.comboAGAMA)
        Me.GroupBox10.Font = New System.Drawing.Font("Tw Cen MT Condensed", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox10.ForeColor = System.Drawing.Color.White
        Me.GroupBox10.Location = New System.Drawing.Point(180, 304)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(120, 61)
        Me.GroupBox10.TabIndex = 4
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Agama"
        '
        'comboAGAMA
        '
        Me.comboAGAMA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.comboAGAMA.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboAGAMA.FormattingEnabled = True
        Me.comboAGAMA.Items.AddRange(New Object() {"ISLAM", "KRISTEN", "HINDU", "BUDHA", "KONGHUCU"})
        Me.comboAGAMA.Location = New System.Drawing.Point(6, 19)
        Me.comboAGAMA.Name = "comboAGAMA"
        Me.comboAGAMA.Size = New System.Drawing.Size(106, 35)
        Me.comboAGAMA.TabIndex = 0
        Me.comboAGAMA.Text = "ISLAM"
        '
        'GroupBox11
        '
        Me.GroupBox11.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox11.Controls.Add(Me.tbUMUR)
        Me.GroupBox11.Font = New System.Drawing.Font("Tw Cen MT Condensed", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox11.ForeColor = System.Drawing.Color.White
        Me.GroupBox11.Location = New System.Drawing.Point(304, 304)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(78, 61)
        Me.GroupBox11.TabIndex = 3
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Umur"
        '
        'tbUMUR
        '
        Me.tbUMUR.BackColor = System.Drawing.Color.White
        Me.tbUMUR.Font = New System.Drawing.Font("Arial Narrow", 13.8!)
        Me.tbUMUR.Location = New System.Drawing.Point(7, 19)
        Me.tbUMUR.Name = "tbUMUR"
        Me.tbUMUR.Size = New System.Drawing.Size(66, 34)
        Me.tbUMUR.TabIndex = 0
        Me.tbUMUR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox12
        '
        Me.GroupBox12.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox12.Controls.Add(Me.comboSTATUSNIKAH)
        Me.GroupBox12.Font = New System.Drawing.Font("Tw Cen MT Condensed", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox12.ForeColor = System.Drawing.Color.White
        Me.GroupBox12.Location = New System.Drawing.Point(72, 550)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(310, 61)
        Me.GroupBox12.TabIndex = 3
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Status Perkawinan"
        '
        'comboSTATUSNIKAH
        '
        Me.comboSTATUSNIKAH.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.comboSTATUSNIKAH.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboSTATUSNIKAH.FormattingEnabled = True
        Me.comboSTATUSNIKAH.Items.AddRange(New Object() {"SINGLE", "MENIKAH", "BERCERAI"})
        Me.comboSTATUSNIKAH.Location = New System.Drawing.Point(6, 18)
        Me.comboSTATUSNIKAH.Name = "comboSTATUSNIKAH"
        Me.comboSTATUSNIKAH.Size = New System.Drawing.Size(294, 35)
        Me.comboSTATUSNIKAH.TabIndex = 1
        Me.comboSTATUSNIKAH.Text = "SINGLE"
        '
        'btnSAVE
        '
        Me.btnSAVE.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnSAVE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSAVE.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSAVE.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSAVE.Location = New System.Drawing.Point(89, 629)
        Me.btnSAVE.Name = "btnSAVE"
        Me.btnSAVE.Size = New System.Drawing.Size(85, 32)
        Me.btnSAVE.TabIndex = 5
        Me.btnSAVE.Text = "SAVE"
        Me.btnSAVE.UseVisualStyleBackColor = False
        '
        'btnDELETE
        '
        Me.btnDELETE.BackColor = System.Drawing.Color.Red
        Me.btnDELETE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDELETE.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDELETE.ForeColor = System.Drawing.SystemColors.Control
        Me.btnDELETE.Location = New System.Drawing.Point(180, 629)
        Me.btnDELETE.Name = "btnDELETE"
        Me.btnDELETE.Size = New System.Drawing.Size(85, 32)
        Me.btnDELETE.TabIndex = 6
        Me.btnDELETE.Text = "DELETE"
        Me.btnDELETE.UseVisualStyleBackColor = False
        '
        'btnCLOSE
        '
        Me.btnCLOSE.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCLOSE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCLOSE.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCLOSE.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCLOSE.Location = New System.Drawing.Point(271, 629)
        Me.btnCLOSE.Name = "btnCLOSE"
        Me.btnCLOSE.Size = New System.Drawing.Size(85, 32)
        Me.btnCLOSE.TabIndex = 7
        Me.btnCLOSE.Text = "CLOSE"
        Me.btnCLOSE.UseVisualStyleBackColor = False
        '
        'GroupBox13
        '
        Me.GroupBox13.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox13.Controls.Add(Me.dataGridAnggota)
        Me.GroupBox13.Controls.Add(Me.Label1)
        Me.GroupBox13.Controls.Add(Me.ShapeContainer1)
        Me.GroupBox13.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox13.ForeColor = System.Drawing.Color.White
        Me.GroupBox13.Location = New System.Drawing.Point(536, 45)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(959, 687)
        Me.GroupBox13.TabIndex = 4
        Me.GroupBox13.TabStop = False
        '
        'dataGridAnggota
        '
        Me.dataGridAnggota.AutoGenerateColumns = False
        Me.dataGridAnggota.BackgroundColor = System.Drawing.Color.White
        Me.dataGridAnggota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridAnggota.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdAnggotaDataGridViewTextBoxColumn, Me.NamaAnggotaDataGridViewTextBoxColumn, Me.NoKtpDataGridViewTextBoxColumn, Me.JenisKelaminDataGridViewTextBoxColumn, Me.AlamatDataGridViewTextBoxColumn, Me.GolDarahDataGridViewTextBoxColumn, Me.NoTlpDataGridViewTextBoxColumn, Me.AgamaDataGridViewTextBoxColumn, Me.UmurDataGridViewTextBoxColumn, Me.HobiDataGridViewTextBoxColumn, Me.NamaIbuDataGridViewTextBoxColumn, Me.StatusPerkawinanDataGridViewTextBoxColumn})
        Me.dataGridAnggota.DataSource = Me.TblAnggotaBindingSource
        Me.dataGridAnggota.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dataGridAnggota.Location = New System.Drawing.Point(25, 173)
        Me.dataGridAnggota.Name = "dataGridAnggota"
        Me.dataGridAnggota.RowTemplate.Height = 24
        Me.dataGridAnggota.Size = New System.Drawing.Size(908, 486)
        Me.dataGridAnggota.TabIndex = 2
        '
        'IdAnggotaDataGridViewTextBoxColumn
        '
        Me.IdAnggotaDataGridViewTextBoxColumn.DataPropertyName = "idAnggota"
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.IdAnggotaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.IdAnggotaDataGridViewTextBoxColumn.HeaderText = "idAnggota"
        Me.IdAnggotaDataGridViewTextBoxColumn.Name = "IdAnggotaDataGridViewTextBoxColumn"
        '
        'NamaAnggotaDataGridViewTextBoxColumn
        '
        Me.NamaAnggotaDataGridViewTextBoxColumn.DataPropertyName = "namaAnggota"
        Me.NamaAnggotaDataGridViewTextBoxColumn.HeaderText = "namaAnggota"
        Me.NamaAnggotaDataGridViewTextBoxColumn.Name = "NamaAnggotaDataGridViewTextBoxColumn"
        '
        'NoKtpDataGridViewTextBoxColumn
        '
        Me.NoKtpDataGridViewTextBoxColumn.DataPropertyName = "noKtp"
        Me.NoKtpDataGridViewTextBoxColumn.HeaderText = "noKtp"
        Me.NoKtpDataGridViewTextBoxColumn.Name = "NoKtpDataGridViewTextBoxColumn"
        '
        'JenisKelaminDataGridViewTextBoxColumn
        '
        Me.JenisKelaminDataGridViewTextBoxColumn.DataPropertyName = "jenisKelamin"
        Me.JenisKelaminDataGridViewTextBoxColumn.HeaderText = "jenisKelamin"
        Me.JenisKelaminDataGridViewTextBoxColumn.Name = "JenisKelaminDataGridViewTextBoxColumn"
        '
        'AlamatDataGridViewTextBoxColumn
        '
        Me.AlamatDataGridViewTextBoxColumn.DataPropertyName = "alamat"
        Me.AlamatDataGridViewTextBoxColumn.HeaderText = "alamat"
        Me.AlamatDataGridViewTextBoxColumn.Name = "AlamatDataGridViewTextBoxColumn"
        '
        'GolDarahDataGridViewTextBoxColumn
        '
        Me.GolDarahDataGridViewTextBoxColumn.DataPropertyName = "golDarah"
        Me.GolDarahDataGridViewTextBoxColumn.HeaderText = "golDarah"
        Me.GolDarahDataGridViewTextBoxColumn.Name = "GolDarahDataGridViewTextBoxColumn"
        '
        'NoTlpDataGridViewTextBoxColumn
        '
        Me.NoTlpDataGridViewTextBoxColumn.DataPropertyName = "noTlp"
        Me.NoTlpDataGridViewTextBoxColumn.HeaderText = "noTlp"
        Me.NoTlpDataGridViewTextBoxColumn.Name = "NoTlpDataGridViewTextBoxColumn"
        '
        'AgamaDataGridViewTextBoxColumn
        '
        Me.AgamaDataGridViewTextBoxColumn.DataPropertyName = "agama"
        Me.AgamaDataGridViewTextBoxColumn.HeaderText = "agama"
        Me.AgamaDataGridViewTextBoxColumn.Name = "AgamaDataGridViewTextBoxColumn"
        '
        'UmurDataGridViewTextBoxColumn
        '
        Me.UmurDataGridViewTextBoxColumn.DataPropertyName = "umur"
        Me.UmurDataGridViewTextBoxColumn.HeaderText = "umur"
        Me.UmurDataGridViewTextBoxColumn.Name = "UmurDataGridViewTextBoxColumn"
        '
        'HobiDataGridViewTextBoxColumn
        '
        Me.HobiDataGridViewTextBoxColumn.DataPropertyName = "hobi"
        Me.HobiDataGridViewTextBoxColumn.HeaderText = "hobi"
        Me.HobiDataGridViewTextBoxColumn.Name = "HobiDataGridViewTextBoxColumn"
        '
        'NamaIbuDataGridViewTextBoxColumn
        '
        Me.NamaIbuDataGridViewTextBoxColumn.DataPropertyName = "namaIbu"
        Me.NamaIbuDataGridViewTextBoxColumn.HeaderText = "namaIbu"
        Me.NamaIbuDataGridViewTextBoxColumn.Name = "NamaIbuDataGridViewTextBoxColumn"
        '
        'StatusPerkawinanDataGridViewTextBoxColumn
        '
        Me.StatusPerkawinanDataGridViewTextBoxColumn.DataPropertyName = "statusPerkawinan"
        Me.StatusPerkawinanDataGridViewTextBoxColumn.HeaderText = "statusPerkawinan"
        Me.StatusPerkawinanDataGridViewTextBoxColumn.Name = "StatusPerkawinanDataGridViewTextBoxColumn"
        '
        'TblAnggotaBindingSource
        '
        Me.TblAnggotaBindingSource.DataMember = "tblAnggota"
        Me.TblAnggotaBindingSource.DataSource = Me.DbQuizDataSet
        '
        'DbQuizDataSet
        '
        Me.DbQuizDataSet.DataSetName = "dbQuizDataSet"
        Me.DbQuizDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(259, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(578, 71)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DATA ANGGOTA TI 2019"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 23)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape5, Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(953, 661)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape5
        '
        Me.LineShape5.BorderColor = System.Drawing.Color.White
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 331
        Me.LineShape5.X2 = 641
        Me.LineShape5.Y1 = 125
        Me.LineShape5.Y2 = 125
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.Color.White
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 332
        Me.LineShape4.X2 = 642
        Me.LineShape4.Y1 = 12
        Me.LineShape4.Y2 = 12
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.White
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 290
        Me.LineShape3.X2 = 686
        Me.LineShape3.Y1 = 32
        Me.LineShape3.Y2 = 32
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.White
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 278
        Me.LineShape2.X2 = 674
        Me.LineShape2.Y1 = -3
        Me.LineShape2.Y2 = -3
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.White
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 289
        Me.LineShape1.X2 = 685
        Me.LineShape1.Y1 = 105
        Me.LineShape1.Y2 = 105
        '
        'GroupBox14
        '
        Me.GroupBox14.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox14.Controls.Add(Me.GroupBox3)
        Me.GroupBox14.Controls.Add(Me.btnCLOSE)
        Me.GroupBox14.Controls.Add(Me.GroupBox1)
        Me.GroupBox14.Controls.Add(Me.btnDELETE)
        Me.GroupBox14.Controls.Add(Me.GroupBox6)
        Me.GroupBox14.Controls.Add(Me.btnSAVE)
        Me.GroupBox14.Controls.Add(Me.GroupBox2)
        Me.GroupBox14.Controls.Add(Me.GroupBox12)
        Me.GroupBox14.Controls.Add(Me.GroupBox5)
        Me.GroupBox14.Controls.Add(Me.GroupBox11)
        Me.GroupBox14.Controls.Add(Me.GroupBox9)
        Me.GroupBox14.Controls.Add(Me.GroupBox10)
        Me.GroupBox14.Controls.Add(Me.GroupBox4)
        Me.GroupBox14.Controls.Add(Me.GroupBox8)
        Me.GroupBox14.Controls.Add(Me.GroupBox7)
        Me.GroupBox14.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox14.ForeColor = System.Drawing.Color.White
        Me.GroupBox14.Location = New System.Drawing.Point(43, 33)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(447, 699)
        Me.GroupBox14.TabIndex = 8
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "REGISTRATION FORM"
        '
        'TblAnggotaTableAdapter
        '
        Me.TblAnggotaTableAdapter.ClearBeforeFill = True
        '
        'Form_Anggota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._201901251039_TOBI_QUIZ.My.Resources.Resources.photo_2021_10_22_22_54_14
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1549, 1055)
        Me.Controls.Add(Me.GroupBox13)
        Me.Controls.Add(Me.GroupBox14)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimizeBox = False
        Me.Name = "Form_Anggota"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        CType(Me.dataGridAnggota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblAnggotaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbQuizDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox14.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbID As System.Windows.Forms.TextBox
    Friend WithEvents tbNAMA As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tbKTP As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents tbHOBI As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents tbTLP As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents tbALAMAT As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents tbIBU As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents radioWanita As System.Windows.Forms.RadioButton
    Friend WithEvents radioPria As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents comboGOLDAR As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents comboAGAMA As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents tbUMUR As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents comboSTATUSNIKAH As System.Windows.Forms.ComboBox
    Friend WithEvents btnSAVE As System.Windows.Forms.Button
    Friend WithEvents btnDELETE As System.Windows.Forms.Button
    Friend WithEvents btnCLOSE As System.Windows.Forms.Button
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents dataGridAnggota As System.Windows.Forms.DataGridView
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents DbQuizDataSet As _201901251039_TOBI_QUIZ.dbQuizDataSet
    Friend WithEvents TblAnggotaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblAnggotaTableAdapter As _201901251039_TOBI_QUIZ.dbQuizDataSetTableAdapters.tblAnggotaTableAdapter
    Friend WithEvents IdAnggotaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaAnggotaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoKtpDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JenisKelaminDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlamatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GolDarahDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoTlpDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgamaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UmurDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HobiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaIbuDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusPerkawinanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
