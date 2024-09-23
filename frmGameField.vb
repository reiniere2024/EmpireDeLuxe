
Public Class frmGameField
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tb01 As System.Windows.Forms.PictureBox
    Friend WithEvents tb02 As System.Windows.Forms.PictureBox
    Friend WithEvents tb03 As System.Windows.Forms.PictureBox
    Friend WithEvents tb04 As System.Windows.Forms.PictureBox
    Friend WithEvents tb05 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cb1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents cb6 As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pb6 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents cb5 As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents pb5 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents cb4 As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pb4 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents cb3 As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pb3 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cb2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pb2 As System.Windows.Forms.PictureBox
    Friend WithEvents pb1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl6 As System.Windows.Forms.Label
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents tbUnits As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents cbFight As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tbSA As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbNA As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tbAUS As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tbAS As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tbAFR As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tbEUR As System.Windows.Forms.TextBox
    Friend WithEvents cb03 As System.Windows.Forms.CheckBox
    Friend WithEvents cb02 As System.Windows.Forms.CheckBox
    Friend WithEvents cb01 As System.Windows.Forms.CheckBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cb04 As System.Windows.Forms.CheckBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents tbMax As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents tbRest As System.Windows.Forms.TextBox
    Friend WithEvents P02 As System.Windows.Forms.Panel
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents P01 As System.Windows.Forms.Panel
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents tbHome As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents tbC01 As System.Windows.Forms.TextBox
    Friend WithEvents tbC02 As System.Windows.Forms.TextBox
    Friend WithEvents tbA02 As System.Windows.Forms.TextBox
    Friend WithEvents tbA01 As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGameField))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button5 = New System.Windows.Forms.Button
        Me.tbRest = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.tbMax = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.cb04 = New System.Windows.Forms.CheckBox
        Me.cb03 = New System.Windows.Forms.CheckBox
        Me.cb02 = New System.Windows.Forms.CheckBox
        Me.cb01 = New System.Windows.Forms.CheckBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.tbAUS = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.tbAS = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.tbAFR = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.tbEUR = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.tbSA = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.tbNA = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.tb01 = New System.Windows.Forms.PictureBox
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.lbl4 = New System.Windows.Forms.Label
        Me.cb4 = New System.Windows.Forms.CheckBox
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.lbl5 = New System.Windows.Forms.Label
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.lbl6 = New System.Windows.Forms.Label
        Me.cb6 = New System.Windows.Forms.CheckBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.lbl3 = New System.Windows.Forms.Label
        Me.cb3 = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.pb3 = New System.Windows.Forms.PictureBox
        Me.pb6 = New System.Windows.Forms.PictureBox
        Me.cb5 = New System.Windows.Forms.CheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.pb5 = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.pb4 = New System.Windows.Forms.PictureBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.lbl2 = New System.Windows.Forms.Label
        Me.cb2 = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.pb2 = New System.Windows.Forms.PictureBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.Label22 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.lbl1 = New System.Windows.Forms.Label
        Me.pb1 = New System.Windows.Forms.PictureBox
        Me.cb1 = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.tb05 = New System.Windows.Forms.PictureBox
        Me.tb02 = New System.Windows.Forms.PictureBox
        Me.tb04 = New System.Windows.Forms.PictureBox
        Me.tb03 = New System.Windows.Forms.PictureBox
        Me.cbFight = New System.Windows.Forms.CheckBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.tbUnits = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.P01 = New System.Windows.Forms.Panel
        Me.Label24 = New System.Windows.Forms.Label
        Me.P02 = New System.Windows.Forms.Panel
        Me.Label25 = New System.Windows.Forms.Label
        Me.tbHome = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.Label28 = New System.Windows.Forms.Label
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.tbC01 = New System.Windows.Forms.TextBox
        Me.tbC02 = New System.Windows.Forms.TextBox
        Me.tbA02 = New System.Windows.Forms.TextBox
        Me.tbA01 = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        CType(Me.tb01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.pb3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb05, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb04, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb03, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.P01.SuspendLayout()
        Me.P02.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.tbRest)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.tbMax)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.cb04)
        Me.Panel1.Controls.Add(Me.cb03)
        Me.Panel1.Controls.Add(Me.cb02)
        Me.Panel1.Controls.Add(Me.cb01)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.tbAUS)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.tbAS)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.tbAFR)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.tbEUR)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.tbSA)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.tbNA)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.tb01)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.tb05)
        Me.Panel1.Controls.Add(Me.tb02)
        Me.Panel1.Controls.Add(Me.tb04)
        Me.Panel1.Controls.Add(Me.tb03)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 693)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1311, 106)
        Me.Panel1.TabIndex = 3
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(442, 55)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(66, 23)
        Me.Button5.TabIndex = 37
        Me.Button5.Text = "MAP"
        Me.Button5.Visible = False
        '
        'tbRest
        '
        Me.tbRest.Location = New System.Drawing.Point(353, 57)
        Me.tbRest.Name = "tbRest"
        Me.tbRest.Size = New System.Drawing.Size(28, 20)
        Me.tbRest.TabIndex = 36
        Me.tbRest.Text = "3"
        Me.tbRest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(352, 35)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(33, 13)
        Me.Label20.TabIndex = 35
        Me.Label20.Text = "Rest"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(348, 21)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(42, 13)
        Me.Label21.TabIndex = 34
        Me.Label21.Text = "Bonus"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(278, 35)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 13)
        Me.Label19.TabIndex = 33
        Me.Label19.Text = "Countries:"
        '
        'tbMax
        '
        Me.tbMax.Location = New System.Drawing.Point(297, 58)
        Me.tbMax.Name = "tbMax"
        Me.tbMax.Size = New System.Drawing.Size(28, 20)
        Me.tbMax.TabIndex = 32
        Me.tbMax.Text = "3"
        Me.tbMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(291, 21)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(34, 13)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "Max."
        '
        'cb04
        '
        Me.cb04.AutoSize = True
        Me.cb04.Location = New System.Drawing.Point(1154, 66)
        Me.cb04.Name = "cb04"
        Me.cb04.Size = New System.Drawing.Size(85, 17)
        Me.cb04.TabIndex = 30
        Me.cb04.Text = "Total Victory"
        Me.cb04.UseVisualStyleBackColor = True
        '
        'cb03
        '
        Me.cb03.AutoSize = True
        Me.cb03.Location = New System.Drawing.Point(1070, 66)
        Me.cb03.Name = "cb03"
        Me.cb03.Size = New System.Drawing.Size(85, 17)
        Me.cb03.TabIndex = 29
        Me.cb03.Text = "30 Countries"
        Me.cb03.UseVisualStyleBackColor = True
        '
        'cb02
        '
        Me.cb02.AutoSize = True
        Me.cb02.Location = New System.Drawing.Point(981, 66)
        Me.cb02.Name = "cb02"
        Me.cb02.Size = New System.Drawing.Size(85, 17)
        Me.cb02.TabIndex = 28
        Me.cb02.Text = "5 Continents"
        Me.cb02.UseVisualStyleBackColor = True
        '
        'cb01
        '
        Me.cb01.AutoSize = True
        Me.cb01.Checked = True
        Me.cb01.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb01.Location = New System.Drawing.Point(893, 66)
        Me.cb01.Name = "cb01"
        Me.cb01.Size = New System.Drawing.Size(85, 17)
        Me.cb01.TabIndex = 27
        Me.cb01.Text = "4 Continents"
        Me.cb01.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(1025, 30)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(103, 13)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "Victory Condition"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(660, 24)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 13)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "Continent Bonus:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(806, 48)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(36, 13)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "AUS:"
        '
        'tbAUS
        '
        Me.tbAUS.Location = New System.Drawing.Point(809, 66)
        Me.tbAUS.Name = "tbAUS"
        Me.tbAUS.Size = New System.Drawing.Size(28, 20)
        Me.tbAUS.TabIndex = 23
        Me.tbAUS.Text = "2"
        Me.tbAUS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(763, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(27, 13)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "AS:"
        '
        'tbAS
        '
        Me.tbAS.Location = New System.Drawing.Point(763, 66)
        Me.tbAS.Name = "tbAS"
        Me.tbAS.Size = New System.Drawing.Size(28, 20)
        Me.tbAS.TabIndex = 21
        Me.tbAS.Text = "9"
        Me.tbAS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(715, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "AFR:"
        '
        'tbAFR
        '
        Me.tbAFR.Location = New System.Drawing.Point(717, 66)
        Me.tbAFR.Name = "tbAFR"
        Me.tbAFR.Size = New System.Drawing.Size(28, 20)
        Me.tbAFR.TabIndex = 19
        Me.tbAFR.Text = "3"
        Me.tbAFR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(670, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "EUR:"
        '
        'tbEUR
        '
        Me.tbEUR.Location = New System.Drawing.Point(674, 66)
        Me.tbEUR.Name = "tbEUR"
        Me.tbEUR.Size = New System.Drawing.Size(28, 20)
        Me.tbEUR.TabIndex = 17
        Me.tbEUR.Text = "5"
        Me.tbEUR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(633, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "SA:"
        '
        'tbSA
        '
        Me.tbSA.Location = New System.Drawing.Point(631, 66)
        Me.tbSA.Name = "tbSA"
        Me.tbSA.Size = New System.Drawing.Size(28, 20)
        Me.tbSA.TabIndex = 15
        Me.tbSA.Text = "2"
        Me.tbSA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(588, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "NA:"
        '
        'tbNA
        '
        Me.tbNA.Location = New System.Drawing.Point(586, 66)
        Me.tbNA.Name = "tbNA"
        Me.tbNA.Size = New System.Drawing.Size(28, 20)
        Me.tbNA.TabIndex = 13
        Me.tbNA.Text = "7"
        Me.tbNA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(176, 60)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(66, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Start"
        '
        'tb01
        '
        Me.tb01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb01.Image = CType(resources.GetObject("tb01.Image"), System.Drawing.Image)
        Me.tb01.Location = New System.Drawing.Point(18, 117)
        Me.tb01.Name = "tb01"
        Me.tb01.Size = New System.Drawing.Size(30, 30)
        Me.tb01.TabIndex = 0
        Me.tb01.TabStop = False
        Me.tb01.Visible = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Yellow
        Me.Panel5.Controls.Add(Me.lbl4)
        Me.Panel5.Controls.Add(Me.cb4)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.pb4)
        Me.Panel5.Location = New System.Drawing.Point(1186, 8)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(71, 61)
        Me.Panel5.TabIndex = 9
        Me.Panel5.Visible = False
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Location = New System.Drawing.Point(4, 44)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(0, 13)
        Me.lbl4.TabIndex = 5
        '
        'cb4
        '
        Me.cb4.AutoSize = True
        Me.cb4.Location = New System.Drawing.Point(7, 27)
        Me.cb4.Name = "cb4"
        Me.cb4.Size = New System.Drawing.Size(15, 14)
        Me.cb4.TabIndex = 2
        Me.cb4.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Orange
        Me.Panel6.Controls.Add(Me.lbl5)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Controls.Add(Me.cb5)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Controls.Add(Me.pb5)
        Me.Panel6.Location = New System.Drawing.Point(10, 13)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(71, 61)
        Me.Panel6.TabIndex = 10
        Me.Panel6.Visible = False
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Location = New System.Drawing.Point(6, 44)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(0, 13)
        Me.lbl5.TabIndex = 5
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Purple
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.lbl6)
        Me.Panel7.Controls.Add(Me.cb6)
        Me.Panel7.Controls.Add(Me.Label6)
        Me.Panel7.Controls.Add(Me.Panel4)
        Me.Panel7.Controls.Add(Me.pb6)
        Me.Panel7.Location = New System.Drawing.Point(9, 9)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(71, 61)
        Me.Panel7.TabIndex = 11
        Me.Panel7.Visible = False
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.Location = New System.Drawing.Point(6, 44)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(0, 13)
        Me.lbl6.TabIndex = 5
        '
        'cb6
        '
        Me.cb6.AutoSize = True
        Me.cb6.Location = New System.Drawing.Point(7, 27)
        Me.cb6.Name = "cb6"
        Me.cb6.Size = New System.Drawing.Size(15, 14)
        Me.cb6.TabIndex = 2
        Me.cb6.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "6"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightBlue
        Me.Panel4.Controls.Add(Me.lbl3)
        Me.Panel4.Controls.Add(Me.cb3)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.pb3)
        Me.Panel4.Location = New System.Drawing.Point(9, 9)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(71, 61)
        Me.Panel4.TabIndex = 8
        Me.Panel4.Visible = False
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(6, 44)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(0, 13)
        Me.lbl3.TabIndex = 5
        '
        'cb3
        '
        Me.cb3.AutoSize = True
        Me.cb3.Location = New System.Drawing.Point(7, 27)
        Me.cb3.Name = "cb3"
        Me.cb3.Size = New System.Drawing.Size(15, 14)
        Me.cb3.TabIndex = 2
        Me.cb3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "3"
        '
        'pb3
        '
        Me.pb3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb3.Image = CType(resources.GetObject("pb3.Image"), System.Drawing.Image)
        Me.pb3.Location = New System.Drawing.Point(28, 11)
        Me.pb3.Name = "pb3"
        Me.pb3.Size = New System.Drawing.Size(30, 30)
        Me.pb3.TabIndex = 0
        Me.pb3.TabStop = False
        Me.pb3.Tag = "pc"
        '
        'pb6
        '
        Me.pb6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb6.Image = CType(resources.GetObject("pb6.Image"), System.Drawing.Image)
        Me.pb6.Location = New System.Drawing.Point(28, 11)
        Me.pb6.Name = "pb6"
        Me.pb6.Size = New System.Drawing.Size(30, 30)
        Me.pb6.TabIndex = 0
        Me.pb6.TabStop = False
        Me.pb6.Tag = "pc"
        '
        'cb5
        '
        Me.cb5.AutoSize = True
        Me.cb5.Location = New System.Drawing.Point(7, 27)
        Me.cb5.Name = "cb5"
        Me.cb5.Size = New System.Drawing.Size(15, 14)
        Me.cb5.TabIndex = 2
        Me.cb5.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "5"
        '
        'pb5
        '
        Me.pb5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb5.Image = CType(resources.GetObject("pb5.Image"), System.Drawing.Image)
        Me.pb5.Location = New System.Drawing.Point(28, 11)
        Me.pb5.Name = "pb5"
        Me.pb5.Size = New System.Drawing.Size(30, 30)
        Me.pb5.TabIndex = 0
        Me.pb5.TabStop = False
        Me.pb5.Tag = "pc"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "4"
        '
        'pb4
        '
        Me.pb4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb4.Image = CType(resources.GetObject("pb4.Image"), System.Drawing.Image)
        Me.pb4.Location = New System.Drawing.Point(28, 11)
        Me.pb4.Name = "pb4"
        Me.pb4.Size = New System.Drawing.Size(30, 30)
        Me.pb4.TabIndex = 0
        Me.pb4.TabStop = False
        Me.pb4.Tag = "pc"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Red
        Me.Panel3.Controls.Add(Me.lbl2)
        Me.Panel3.Controls.Add(Me.cb2)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.pb2)
        Me.Panel3.Location = New System.Drawing.Point(88, 8)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(71, 74)
        Me.Panel3.TabIndex = 7
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(6, 44)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(0, 13)
        Me.lbl2.TabIndex = 5
        '
        'cb2
        '
        Me.cb2.AutoSize = True
        Me.cb2.Checked = True
        Me.cb2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb2.Enabled = False
        Me.cb2.Location = New System.Drawing.Point(7, 34)
        Me.cb2.Name = "cb2"
        Me.cb2.Size = New System.Drawing.Size(15, 14)
        Me.cb2.TabIndex = 2
        Me.cb2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "2"
        '
        'pb2
        '
        Me.pb2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb2.Image = CType(resources.GetObject("pb2.Image"), System.Drawing.Image)
        Me.pb2.Location = New System.Drawing.Point(28, 18)
        Me.pb2.Name = "pb2"
        Me.pb2.Size = New System.Drawing.Size(30, 30)
        Me.pb2.TabIndex = 0
        Me.pb2.TabStop = False
        Me.pb2.Tag = "people"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Lime
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Controls.Add(Me.lbl1)
        Me.Panel2.Controls.Add(Me.pb1)
        Me.Panel2.Controls.Add(Me.cb1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(11, 8)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(71, 74)
        Me.Panel2.TabIndex = 6
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Lime
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel8.Controls.Add(Me.Label22)
        Me.Panel8.Controls.Add(Me.PictureBox2)
        Me.Panel8.Controls.Add(Me.CheckBox1)
        Me.Panel8.Controls.Add(Me.Label23)
        Me.Panel8.Location = New System.Drawing.Point(-2, -2)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(71, 74)
        Me.Panel8.TabIndex = 7
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 44)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(0, 13)
        Me.Label22.TabIndex = 4
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(32, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "people"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Location = New System.Drawing.Point(7, 33)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(6, 15)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(14, 13)
        Me.Label23.TabIndex = 1
        Me.Label23.Text = "1"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(6, 44)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(0, 13)
        Me.lbl1.TabIndex = 4
        '
        'pb1
        '
        Me.pb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb1.Image = CType(resources.GetObject("pb1.Image"), System.Drawing.Image)
        Me.pb1.Location = New System.Drawing.Point(32, 17)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(30, 30)
        Me.pb1.TabIndex = 3
        Me.pb1.TabStop = False
        Me.pb1.Tag = "people"
        '
        'cb1
        '
        Me.cb1.AutoSize = True
        Me.cb1.Checked = True
        Me.cb1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb1.Enabled = False
        Me.cb1.Location = New System.Drawing.Point(7, 33)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(15, 14)
        Me.cb1.TabIndex = 2
        Me.cb1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(243, 124)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Button1"
        Me.Button1.Visible = False
        '
        'tb05
        '
        Me.tb05.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb05.Image = CType(resources.GetObject("tb05.Image"), System.Drawing.Image)
        Me.tb05.Location = New System.Drawing.Point(197, 117)
        Me.tb05.Name = "tb05"
        Me.tb05.Size = New System.Drawing.Size(40, 32)
        Me.tb05.TabIndex = 4
        Me.tb05.TabStop = False
        Me.tb05.Visible = False
        '
        'tb02
        '
        Me.tb02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb02.Image = CType(resources.GetObject("tb02.Image"), System.Drawing.Image)
        Me.tb02.Location = New System.Drawing.Point(54, 115)
        Me.tb02.Name = "tb02"
        Me.tb02.Size = New System.Drawing.Size(40, 32)
        Me.tb02.TabIndex = 1
        Me.tb02.TabStop = False
        Me.tb02.Visible = False
        '
        'tb04
        '
        Me.tb04.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb04.Image = CType(resources.GetObject("tb04.Image"), System.Drawing.Image)
        Me.tb04.Location = New System.Drawing.Point(146, 115)
        Me.tb04.Name = "tb04"
        Me.tb04.Size = New System.Drawing.Size(40, 32)
        Me.tb04.TabIndex = 3
        Me.tb04.TabStop = False
        Me.tb04.Visible = False
        '
        'tb03
        '
        Me.tb03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb03.Image = CType(resources.GetObject("tb03.Image"), System.Drawing.Image)
        Me.tb03.Location = New System.Drawing.Point(100, 115)
        Me.tb03.Name = "tb03"
        Me.tb03.Size = New System.Drawing.Size(40, 32)
        Me.tb03.TabIndex = 2
        Me.tb03.TabStop = False
        Me.tb03.Visible = False
        '
        'cbFight
        '
        Me.cbFight.AutoSize = True
        Me.cbFight.Location = New System.Drawing.Point(166, 722)
        Me.cbFight.Name = "cbFight"
        Me.cbFight.Size = New System.Drawing.Size(15, 14)
        Me.cbFight.TabIndex = 5
        Me.cbFight.UseVisualStyleBackColor = True
        Me.cbFight.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(159, 706)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "fight:"
        Me.Label9.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(156, 693)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Quick"
        Me.Label8.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(84, 711)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(66, 23)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "End Turn"
        '
        'tbUnits
        '
        Me.tbUnits.Location = New System.Drawing.Point(27, 712)
        Me.tbUnits.Name = "tbUnits"
        Me.tbUnits.Size = New System.Drawing.Size(49, 20)
        Me.tbUnits.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.HotPink
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 697)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Units:"
        Me.Label7.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1280, 793)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'P01
        '
        Me.P01.BackColor = System.Drawing.Color.Lime
        Me.P01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.P01.Controls.Add(Me.Label24)
        Me.P01.Location = New System.Drawing.Point(206, 704)
        Me.P01.Name = "P01"
        Me.P01.Size = New System.Drawing.Size(32, 33)
        Me.P01.TabIndex = 37
        Me.P01.Visible = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 44)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(0, 13)
        Me.Label24.TabIndex = 4
        '
        'P02
        '
        Me.P02.BackColor = System.Drawing.Color.OrangeRed
        Me.P02.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.P02.Controls.Add(Me.Label25)
        Me.P02.Location = New System.Drawing.Point(206, 704)
        Me.P02.Name = "P02"
        Me.P02.Size = New System.Drawing.Size(32, 33)
        Me.P02.TabIndex = 37
        Me.P02.Visible = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(6, 44)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(0, 13)
        Me.Label25.TabIndex = 5
        '
        'tbHome
        '
        Me.tbHome.Location = New System.Drawing.Point(84, 739)
        Me.tbHome.Name = "tbHome"
        Me.tbHome.Size = New System.Drawing.Size(106, 20)
        Me.tbHome.TabIndex = 38
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(32, 743)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(43, 13)
        Me.Label26.TabIndex = 39
        Me.Label26.Text = "Home:"
        Me.Label26.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(205, 739)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(51, 23)
        Me.Button4.TabIndex = 40
        Me.Button4.Text = "change"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Lime
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel10.Controls.Add(Me.Label28)
        Me.Panel10.Location = New System.Drawing.Point(786, 712)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(20, 20)
        Me.Panel10.TabIndex = 41
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(6, 44)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(0, 13)
        Me.Label28.TabIndex = 4
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel11.Controls.Add(Me.Label29)
        Me.Panel11.Location = New System.Drawing.Point(786, 739)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(20, 20)
        Me.Panel11.TabIndex = 38
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(6, 44)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(0, 13)
        Me.Label29.TabIndex = 5
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(948, 742)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(60, 13)
        Me.Label27.TabIndex = 42
        Me.Label27.Text = "Countries"
        Me.Label27.Visible = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(948, 739)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(60, 13)
        Me.Label30.TabIndex = 43
        Me.Label30.Text = "Countries"
        Me.Label30.Visible = False
        '
        'tbC01
        '
        Me.tbC01.Location = New System.Drawing.Point(813, 712)
        Me.tbC01.Name = "tbC01"
        Me.tbC01.Size = New System.Drawing.Size(54, 20)
        Me.tbC01.TabIndex = 44
        '
        'tbC02
        '
        Me.tbC02.Location = New System.Drawing.Point(814, 739)
        Me.tbC02.Name = "tbC02"
        Me.tbC02.Size = New System.Drawing.Size(54, 20)
        Me.tbC02.TabIndex = 45
        '
        'tbA02
        '
        Me.tbA02.Location = New System.Drawing.Point(882, 739)
        Me.tbA02.Name = "tbA02"
        Me.tbA02.Size = New System.Drawing.Size(54, 20)
        Me.tbA02.TabIndex = 47
        '
        'tbA01
        '
        Me.tbA01.Location = New System.Drawing.Point(882, 712)
        Me.tbA01.Name = "tbA01"
        Me.tbA01.Size = New System.Drawing.Size(54, 20)
        Me.tbA01.TabIndex = 46
        '
        'frmGameField
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1311, 799)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tbA01)
        Me.Controls.Add(Me.tbA02)
        Me.Controls.Add(Me.tbC02)
        Me.Controls.Add(Me.tbC01)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.tbHome)
        Me.Controls.Add(Me.P01)
        Me.Controls.Add(Me.P02)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.tbUnits)
        Me.Controls.Add(Me.cbFight)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmGameField"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "World Empires"
        Me.TransparencyKey = System.Drawing.Color.HotPink
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.tb01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.pb3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb05, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb04, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb03, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.P01.ResumeLayout(False)
        Me.P01.PerformLayout()
        Me.P02.ResumeLayout(False)
        Me.P02.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private MyGame As clsGame
    Private posx, posy As Integer

    Public toolbar_visible As Boolean = False
    Public showgrid As Boolean = False
    Public MyMouse As String

    Public Sub PaintLabels()

        Dim graphback As Graphics

        graphback = Graphics.FromImage(PictureBox1.Image)
        graphback.DrawString("Units", New Font("arial", 10, FontStyle.Bold), New SolidBrush(Color.FromName("Black")), 29, 697)
        graphback.DrawString("Home:", New Font("arial", 10, FontStyle.Bold), New SolidBrush(Color.FromName("Black")), 29, 740)

        'graphback.DrawString("quick", New Font("arial", 8, FontStyle.Bold), New SolidBrush(Color.FromName("Black")), 157, 693)
        'graphback.DrawString("fight", New Font("arial", 8, FontStyle.Bold), New SolidBrush(Color.FromName("Black")), 160, 706)

        graphback.DrawString("countries", New Font("arial", 8, FontStyle.Bold), New SolidBrush(Color.FromName("Black")), 812, 694)
        graphback.DrawString("armies", New Font("arial", 8, FontStyle.Bold), New SolidBrush(Color.FromName("Black")), 886, 694)

    End Sub


    Private Sub frmGameField_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim r As Integer

        MyGame = New clsGame(Me)
        Me.Width = 1280
        Me.Height = 800
        'Me.Location = New Point(0, 0)

        r = Rand(1, 4)
        If r < 0 Then
            r = 1
        ElseIf r > 4 Then
            r = 4
        End If
        Select Case r
            Case 1
                TargetDirection = "W"

            Case 2
                TargetDirection = "N"

            Case 3
                TargetDirection = "E"

            Case 4
                TargetDirection = "S"


        End Select


        PictureBox1.Width = 1280
        PictureBox1.Height = 800
        'PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.SizeMode = PictureBoxSizeMode.Normal

        PictureBox1.Location = New Point(0, 0)

        Dim Mypict As Bitmap

        Mypict = Bitmap.FromFile(CurDir() + "\map\WORLD0.JPG")
        PictureBox1.Image = Mypict

        tbC01.Enabled = False
        tbC02.Enabled = False

        Label7.BackColor = System.Drawing.Color.Transparent
        Me.PaintLabels()

        Me.Refresh()


    End Sub


    Public Function Rand(ByVal Low As Long, ByVal High As Long) As Long

        Randomize()
        Rand = Int((High - Low + 1) * Rnd()) + Low

    End Function


    Public ReadOnly Property grid()
        Get
            Return showgrid

        End Get
    End Property

    Protected Overrides Function ProcessCmdKey( _
    ByRef msg As Message, _
    ByVal keyData As Keys _
                            ) As Boolean

        Const WM_KEYDOWN As Integer = &H100
        Const WM_SYSKEYDOWN As Integer = &H104



        If ((msg.Msg = WM_KEYDOWN) Or (msg.Msg = WM_SYSKEYDOWN)) Then
            Select Case (keyData)
                'local key handling
                Case Keys.Tab
                    If toolbar_visible = False Then
                        Panel1.Visible = True
                        toolbar_visible = True
                    Else
                        Panel1.Visible = False
                        toolbar_visible = False
                    End If
                    'remote key handling
                Case Else
                    MyGame.Process_Keys(keyData)

            End Select
        End If

    End Function

    Private Sub frmGameField_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint

        'MyGame.ProcessToolbar(1)

    End Sub

    Private Sub tb01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb01.Click
        MyGame.ProcessToolbar(1)

        If showgrid = False Then
            showgrid = True
            tb01.BorderStyle = BorderStyle.Fixed3D
        Else
            showgrid = False
            tb01.BorderStyle = BorderStyle.FixedSingle
            Me.Refresh()
        End If
        MyGame.ProcessToolbar(1)

    End Sub

    Private Sub tb02_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb02.Click
        MyGame.ProcessToolbar(2)


    End Sub


    Private Sub frmGameField_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click
        'MyGame.ProcessMovement(posx, posy)


    End Sub

    Private Sub frmGameField_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        posx = e.X()
        posy = e.Y()

    End Sub


    Private Sub tb03_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb03.Click
        MyGame.ProcessToolbar(3)

    End Sub

    Private Sub tb04_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb04.Click
        MyGame.ProcessToolbar(4)

    End Sub

    Private Sub tb05_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb05.Click
        MyGame.ProcessToolbar(5)

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click


        MyGame.ProcessMovement(posx, posy, MyMouse)

    End Sub

    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        posx = e.X()
        posy = e.Y()
        MyMouse = e.Button.ToString()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Me.PictureBox1.Image.FromFile("D:\projects\games\gdi+\Axis and Allies\bin\units\map\WORLD2.jpg")
        Me.Refresh()

    End Sub


    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub pb2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb2.Click
        Dim Mypict As Bitmap

        If pb2.Tag = "pc" Then
            Mypict = Bitmap.FromFile(CurDir() + "\units\people.jpg")
            pb2.Image = Mypict
            pb2.Tag = "people"
            Me.Refresh()
        Else
            Mypict = Bitmap.FromFile(CurDir() + "\units\pc.jpg")
            pb2.Image = Mypict
            pb2.Tag = "pc"
            Me.Refresh()
        End If

    End Sub

    Private Sub pb3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb3.Click
        Dim Mypict As Bitmap

        If pb3.Tag = "pc" Then
            Mypict = Bitmap.FromFile(CurDir() + "\units\people.jpg")
            pb3.Image = Mypict
            pb3.Tag = "people"
            Me.Refresh()
        Else
            Mypict = Bitmap.FromFile(CurDir() + "\units\pc.jpg")
            pb3.Image = Mypict
            pb3.Tag = "pc"
            Me.Refresh()
        End If


    End Sub

    Private Sub pb4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb4.Click
        Dim Mypict As Bitmap

        If pb4.Tag = "pc" Then
            Mypict = Bitmap.FromFile(CurDir() + "\units\people.jpg")
            pb4.Image = Mypict
            pb4.Tag = "people"
            Me.Refresh()
        Else
            Mypict = Bitmap.FromFile(CurDir() + "\units\pc.jpg")
            pb4.Image = Mypict
            pb4.Tag = "pc"
            Me.Refresh()
        End If

    End Sub

    Private Sub pb5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb5.Click
        Dim Mypict As Bitmap

        If pb5.Tag = "pc" Then
            Mypict = Bitmap.FromFile(CurDir() + "\units\people.jpg")
            pb5.Image = Mypict
            pb5.Tag = "people"
            Me.Refresh()
        Else
            Mypict = Bitmap.FromFile(CurDir() + "\units\pc.jpg")
            pb5.Image = Mypict
            pb5.Tag = "pc"
            Me.Refresh()
        End If

    End Sub

    Private Sub pb6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb6.Click
        Dim Mypict As Bitmap

        If pb6.Tag = "pc" Then
            Mypict = Bitmap.FromFile(CurDir() + "\units\people.jpg")
            pb6.Image = Mypict
            pb6.Tag = "people"
            Me.Refresh()
        Else
            Mypict = Bitmap.FromFile(CurDir() + "\units\pc.jpg")
            pb6.Image = Mypict
            pb6.Tag = "pc"
            Me.Refresh()
        End If

    End Sub

    Private Sub ReadParameters()

        MaxCountries = CInt(tbMax.Text)
        BonusRest = CInt(tbRest.Text)

        BonusNA = CInt(tbNA.Text)
        BonusSA = CInt(tbSA.Text)
        BonusEUR = CInt(tbEUR.Text)
        BonusAFR = CInt(tbAFR.Text)
        BonusAS = CInt(tbAS.Text)
        BonusAUS = CInt(tbAUS.Text)


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim cid As Integer


        If GameStarted = False Then

            Me.ReadParameters()

            P02.Visible = False
            P01.Visible = True

            MyGame.Start_Game(cb1.Checked, cb2.Checked, cb3.Checked, cb4.Checked, cb5.Checked, cb6.Checked)

            Panel1.Visible = False
            toolbar_visible = False

            tbNA.Enabled = False
            tbSA.Enabled = False
            tbEUR.Enabled = False
            tbAFR.Enabled = False
            tbAS.Enabled = False
            tbAUS.Enabled = False

            tbMax.Enabled = False
            tbRest.Enabled = False

            cb01.Enabled = False
            cb02.Enabled = False
            cb03.Enabled = False
            cb04.Enabled = False

            cid = HomeCountries(curplayer - 1)
            tbHome.Text = MyGame.MyMap.MyCountries(cid).mname

            OwnedCountries(0) = 1
            OwnedCountries(1) = 1
            tbC01.Text = OwnedCountries(0).ToString()
            tbC02.Text = OwnedCountries(1).ToString()

            OwnedArmies(0) = StartUnits
            OwnedArmies(1) = StartUnits
            tbA01.Text = OwnedArmies(0).ToString()
            tbA02.Text = OwnedArmies(1).ToString()

            GameStarted = True

        End If



    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        MyGame.Switch_Player()

    End Sub


    Private Sub cb01_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb01.Click

        cb01.Checked = True

        cb02.Checked = False
        cb03.Checked = False
        cb04.Checked = False

    End Sub


    Private Sub cb02_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb02.Click

        cb02.Checked = True

        cb01.Checked = False
        cb03.Checked = False
        cb04.Checked = False

    End Sub

    Private Sub cb03_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb03.Click

        cb03.Checked = True

        cb01.Checked = False
        cb02.Checked = False
        cb04.Checked = False

    End Sub


    Private Sub cb04_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb04.Click

        cb04.Checked = True

        cb01.Checked = False
        cb02.Checked = False
        cb03.Checked = False

    End Sub


    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label18.Click

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        If curcountry > 0 Then 'country geselecteerd
            HomeCountries(curplayer - 1) = curcountry
            tbHome.Text = MyGame.MyMap.MyCountries(curcountry).mname

        End If


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        'If MyGame.MyMap.MyTacticalMap Is Nothing Then
        '    MyGame.MyMap.MyTacticalMap = New frmTacticalMap(MyGame.MyMap)
        'End If
        'MyGame.MyMap.MyTacticalMap.Show()
        'MyGame.MyMap.MyTacticalMap.Focus()

        If mapsize > 0 Then
            mapsize -= 1
        End If
        MyGame.MyMap.define_map()
        MyGame.MyMap.ShowMap()



    End Sub
End Class
