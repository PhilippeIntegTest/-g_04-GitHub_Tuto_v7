<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class U5_JSON_Read_Write
	Inherits System.Windows.Forms.UserControl

	'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(U5_JSON_Read_Write))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnConvertJasonToStructure = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RichTextBoxConvertJasonStructure = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox_Structure = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.Button_Create_JSON_From_Collection = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label_Variable_Name = New System.Windows.Forms.Label()
        Me.Button_Create_Json_From_Variable = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lbl_Compare_Read_Write = New System.Windows.Forms.Label()
        Me.btn_Compare_Read_Write = New System.Windows.Forms.Button()
        Me.RichTextBox_Compare_Read_Write = New System.Windows.Forms.RichTextBox()
        Me.lblTestReadJson = New System.Windows.Forms.Label()
        Me.RichTextBoxRead_Display = New System.Windows.Forms.RichTextBox()
        Me.btnReadJsonFile = New System.Windows.Forms.Button()
        Me.RichTextBoxWrite_Display = New System.Windows.Forms.RichTextBox()
        Me.lblTestWriteJson = New System.Windows.Forms.Label()
        Me.btnWriteJsonFile = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblConvert = New System.Windows.Forms.Label()
        Me.U_Memo_Directory_Browser1 = New Common_All_2013_a.U_Memo_Directory_Browser()
        Me.U_Draw_Minimize_Maximize1 = New Common_All_2013_a.U_Draw_Minimize_Maximize()
        Me.U_Memo_Text_With_Browser1 = New Common_All_2013_a.U_Memo_Text_With_Browser()
        Me.U_Memo_Txt_Value_Variable1 = New Common_All_2013_a.U_Memo_Txt_Mirror()
        Me.U_Memo_CheckBox_Display = New Common_All_2013_a.U_Memo_Check_Mirror()
        Me.U_Msg_Local1 = New Common_All_2013_a.U_Msg_Local()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(5, 89)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1450, 902)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.lblConvert)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.btnConvertJasonToStructure)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.RichTextBoxConvertJasonStructure)
        Me.TabPage1.Controls.Add(Me.RichTextBox_Structure)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.RichTextBox2)
        Me.TabPage1.Controls.Add(Me.Button_Create_JSON_From_Collection)
        Me.TabPage1.Controls.Add(Me.TextBox2)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.U_Memo_Txt_Value_Variable1)
        Me.TabPage1.Controls.Add(Me.Label_Variable_Name)
        Me.TabPage1.Controls.Add(Me.Button_Create_Json_From_Variable)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(1442, 873)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Functional + Unitary test Read + Write_JSon"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(1028, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 45)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Variable to convert"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1028, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 44)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Structure to convert"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1028, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 43)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Converted to JSON variable"
        '
        'btnConvertJasonToStructure
        '
        Me.btnConvertJasonToStructure.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnConvertJasonToStructure.Location = New System.Drawing.Point(635, 275)
        Me.btnConvertJasonToStructure.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConvertJasonToStructure.Name = "btnConvertJasonToStructure"
        Me.btnConvertJasonToStructure.Size = New System.Drawing.Size(435, 28)
        Me.btnConvertJasonToStructure.TabIndex = 15
        Me.btnConvertJasonToStructure.Text = "Convert Json string to existing structure"
        Me.btnConvertJasonToStructure.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(635, 313)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(383, 19)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Affichage de la conversion de Json en structure d'origine"
        '
        'RichTextBoxConvertJasonStructure
        '
        Me.RichTextBoxConvertJasonStructure.Location = New System.Drawing.Point(635, 336)
        Me.RichTextBoxConvertJasonStructure.Margin = New System.Windows.Forms.Padding(4)
        Me.RichTextBoxConvertJasonStructure.Name = "RichTextBoxConvertJasonStructure"
        Me.RichTextBoxConvertJasonStructure.Size = New System.Drawing.Size(526, 263)
        Me.RichTextBoxConvertJasonStructure.TabIndex = 13
        Me.RichTextBoxConvertJasonStructure.Text = ""
        '
        'RichTextBox_Structure
        '
        Me.RichTextBox_Structure.Location = New System.Drawing.Point(329, 75)
        Me.RichTextBox_Structure.Name = "RichTextBox_Structure"
        Me.RichTextBox_Structure.Size = New System.Drawing.Size(693, 70)
        Me.RichTextBox_Structure.TabIndex = 12
        Me.RichTextBox_Structure.Text = ""
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1028, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 45)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Converted to JSON Structure"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(23, 313)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(298, 19)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Affichage du JSON de la structure"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Location = New System.Drawing.Point(23, 336)
        Me.RichTextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(526, 263)
        Me.RichTextBox2.TabIndex = 7
        Me.RichTextBox2.Text = ""
        '
        'Button_Create_JSON_From_Collection
        '
        Me.Button_Create_JSON_From_Collection.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button_Create_JSON_From_Collection.Location = New System.Drawing.Point(23, 275)
        Me.Button_Create_JSON_From_Collection.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_Create_JSON_From_Collection.Name = "Button_Create_JSON_From_Collection"
        Me.Button_Create_JSON_From_Collection.Size = New System.Drawing.Size(435, 28)
        Me.Button_Create_JSON_From_Collection.TabIndex = 6
        Me.Button_Create_JSON_From_Collection.Text = "Create JSON string from Collection (Exemple State Machines)"
        Me.Button_Create_JSON_From_Collection.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(327, 214)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(693, 22)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(329, 168)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(693, 22)
        Me.TextBox1.TabIndex = 4
        '
        'Label_Variable_Name
        '
        Me.Label_Variable_Name.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label_Variable_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label_Variable_Name.Location = New System.Drawing.Point(8, 30)
        Me.Label_Variable_Name.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_Variable_Name.Name = "Label_Variable_Name"
        Me.Label_Variable_Name.Size = New System.Drawing.Size(298, 19)
        Me.Label_Variable_Name.TabIndex = 2
        Me.Label_Variable_Name.Text = "Variable Compteur1 as  Integer="
        '
        'Button_Create_Json_From_Variable
        '
        Me.Button_Create_Json_From_Variable.Location = New System.Drawing.Point(7, 53)
        Me.Button_Create_Json_From_Variable.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_Create_Json_From_Variable.Name = "Button_Create_Json_From_Variable"
        Me.Button_Create_Json_From_Variable.Size = New System.Drawing.Size(247, 28)
        Me.Button_Create_Json_From_Variable.TabIndex = 1
        Me.Button_Create_Json_From_Variable.Text = "Create JSON string from variable"
        Me.Button_Create_Json_From_Variable.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.SkyBlue
        Me.TabPage2.Controls.Add(Me.lbl_Compare_Read_Write)
        Me.TabPage2.Controls.Add(Me.btn_Compare_Read_Write)
        Me.TabPage2.Controls.Add(Me.RichTextBox_Compare_Read_Write)
        Me.TabPage2.Controls.Add(Me.lblTestReadJson)
        Me.TabPage2.Controls.Add(Me.RichTextBoxRead_Display)
        Me.TabPage2.Controls.Add(Me.btnReadJsonFile)
        Me.TabPage2.Controls.Add(Me.RichTextBoxWrite_Display)
        Me.TabPage2.Controls.Add(Me.lblTestWriteJson)
        Me.TabPage2.Controls.Add(Me.btnWriteJsonFile)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.U_Memo_CheckBox_Display)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(1442, 873)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Developpement READ & WRITE Json"
        '
        'lbl_Compare_Read_Write
        '
        Me.lbl_Compare_Read_Write.AutoSize = True
        Me.lbl_Compare_Read_Write.Font = New System.Drawing.Font("Arial Narrow", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Compare_Read_Write.Location = New System.Drawing.Point(1007, 104)
        Me.lbl_Compare_Read_Write.Name = "lbl_Compare_Read_Write"
        Me.lbl_Compare_Read_Write.Size = New System.Drawing.Size(40, 17)
        Me.lbl_Compare_Read_Write.TabIndex = 115
        Me.lbl_Compare_Read_Write.Text = "Ready"
        '
        'btn_Compare_Read_Write
        '
        Me.btn_Compare_Read_Write.Font = New System.Drawing.Font("Comic Sans MS", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Compare_Read_Write.Location = New System.Drawing.Point(795, 96)
        Me.btn_Compare_Read_Write.Name = "btn_Compare_Read_Write"
        Me.btn_Compare_Read_Write.Size = New System.Drawing.Size(193, 32)
        Me.btn_Compare_Read_Write.TabIndex = 114
        Me.btn_Compare_Read_Write.Text = "Compare Read and Write Text"
        Me.btn_Compare_Read_Write.UseVisualStyleBackColor = True
        '
        'RichTextBox_Compare_Read_Write
        '
        Me.RichTextBox_Compare_Read_Write.Location = New System.Drawing.Point(795, 140)
        Me.RichTextBox_Compare_Read_Write.Name = "RichTextBox_Compare_Read_Write"
        Me.RichTextBox_Compare_Read_Write.Size = New System.Drawing.Size(265, 247)
        Me.RichTextBox_Compare_Read_Write.TabIndex = 113
        Me.RichTextBox_Compare_Read_Write.Text = ""
        '
        'lblTestReadJson
        '
        Me.lblTestReadJson.AutoSize = True
        Me.lblTestReadJson.Font = New System.Drawing.Font("Arial Narrow", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTestReadJson.Location = New System.Drawing.Point(622, 104)
        Me.lblTestReadJson.Name = "lblTestReadJson"
        Me.lblTestReadJson.Size = New System.Drawing.Size(40, 17)
        Me.lblTestReadJson.TabIndex = 111
        Me.lblTestReadJson.Text = "Ready"
        '
        'RichTextBoxRead_Display
        '
        Me.RichTextBoxRead_Display.Location = New System.Drawing.Point(408, 140)
        Me.RichTextBoxRead_Display.Name = "RichTextBoxRead_Display"
        Me.RichTextBoxRead_Display.Size = New System.Drawing.Size(265, 247)
        Me.RichTextBoxRead_Display.TabIndex = 110
        Me.RichTextBoxRead_Display.Text = ""
        '
        'btnReadJsonFile
        '
        Me.btnReadJsonFile.Font = New System.Drawing.Font("Comic Sans MS", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReadJsonFile.Location = New System.Drawing.Point(408, 96)
        Me.btnReadJsonFile.Name = "btnReadJsonFile"
        Me.btnReadJsonFile.Size = New System.Drawing.Size(193, 32)
        Me.btnReadJsonFile.TabIndex = 109
        Me.btnReadJsonFile.Text = "Test read Json file"
        Me.btnReadJsonFile.UseVisualStyleBackColor = True
        '
        'RichTextBoxWrite_Display
        '
        Me.RichTextBoxWrite_Display.Location = New System.Drawing.Point(20, 140)
        Me.RichTextBoxWrite_Display.Name = "RichTextBoxWrite_Display"
        Me.RichTextBoxWrite_Display.Size = New System.Drawing.Size(265, 247)
        Me.RichTextBoxWrite_Display.TabIndex = 107
        Me.RichTextBoxWrite_Display.Text = ""
        '
        'lblTestWriteJson
        '
        Me.lblTestWriteJson.AutoSize = True
        Me.lblTestWriteJson.Font = New System.Drawing.Font("Arial Narrow", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTestWriteJson.Location = New System.Drawing.Point(234, 104)
        Me.lblTestWriteJson.Name = "lblTestWriteJson"
        Me.lblTestWriteJson.Size = New System.Drawing.Size(40, 17)
        Me.lblTestWriteJson.TabIndex = 105
        Me.lblTestWriteJson.Text = "Ready"
        '
        'btnWriteJsonFile
        '
        Me.btnWriteJsonFile.Font = New System.Drawing.Font("Comic Sans MS", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWriteJsonFile.Location = New System.Drawing.Point(20, 96)
        Me.btnWriteJsonFile.Name = "btnWriteJsonFile"
        Me.btnWriteJsonFile.Size = New System.Drawing.Size(193, 32)
        Me.btnWriteJsonFile.TabIndex = 104
        Me.btnWriteJsonFile.Text = "Test write Json file"
        Me.btnWriteJsonFile.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(355, 0)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(363, 41)
        Me.Label6.TabIndex = 103
        Me.Label6.Text = "Mise au point fonction READ et WRITE en fichier Json" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "[E.M Mars 2024]"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.MediumVioletRed
        Me.TabPage3.Controls.Add(Me.RichTextBox1)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1442, 873)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Architecture and Documentation of [Save + Restore JSON]"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.RichTextBox1.ForeColor = System.Drawing.Color.Yellow
        Me.RichTextBox1.Location = New System.Drawing.Point(16, 38)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(1007, 426)
        Me.RichTextBox1.TabIndex = 37
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(157, 14)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(314, 20)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = " Architecture -  Doc   (Added mars 2024)"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.PictureBox1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1442, 873)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Organigrammes des fonctions"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(617, 502)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(83, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(307, 18)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Save + Restore Data to JSON (mars 2024)"
        '
        'lblConvert
        '
        Me.lblConvert.AutoSize = True
        Me.lblConvert.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConvert.Location = New System.Drawing.Point(7, 85)
        Me.lblConvert.Name = "lblConvert"
        Me.lblConvert.Size = New System.Drawing.Size(110, 16)
        Me.lblConvert.TabIndex = 19
        Me.lblConvert.Text = "Click to convert!"
        '
        'U_Memo_Directory_Browser1
        '
        Me.U_Memo_Directory_Browser1.A_Directory_Exists_For_AutoSave = False
        Me.U_Memo_Directory_Browser1.A_Flag_Add_Date_And_Time_to_File = True
        Me.U_Memo_Directory_Browser1.A_Full_File_Name = "Full Name in DESIGN"
        Me.U_Memo_Directory_Browser1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.U_Memo_Directory_Browser1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.U_Memo_Directory_Browser1.Filter = "All Files (*.*)|*.*"
        Me.U_Memo_Directory_Browser1.Location = New System.Drawing.Point(5, 59)
        Me.U_Memo_Directory_Browser1.Margin = New System.Windows.Forms.Padding(5)
        Me.U_Memo_Directory_Browser1.Name = "U_Memo_Directory_Browser1"
        Me.U_Memo_Directory_Browser1.Size = New System.Drawing.Size(917, 32)
        Me.U_Memo_Directory_Browser1.TabIndex = 104
        '
        'U_Draw_Minimize_Maximize1
        '
        Me.U_Draw_Minimize_Maximize1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.U_Draw_Minimize_Maximize1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.U_Draw_Minimize_Maximize1.Location = New System.Drawing.Point(945, 4)
        Me.U_Draw_Minimize_Maximize1.Margin = New System.Windows.Forms.Padding(5)
        Me.U_Draw_Minimize_Maximize1.Name = "U_Draw_Minimize_Maximize1"
        Me.U_Draw_Minimize_Maximize1.Size = New System.Drawing.Size(184, 29)
        Me.U_Draw_Minimize_Maximize1.TabIndex = 103
        '
        'U_Memo_Text_With_Browser1
        '
        Me.U_Memo_Text_With_Browser1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.U_Memo_Text_With_Browser1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.U_Memo_Text_With_Browser1.File_Exists_On_Disk = False
        Me.U_Memo_Text_With_Browser1.Filter = "All Files (*.*)|*.*"
        Me.U_Memo_Text_With_Browser1.Location = New System.Drawing.Point(5, 22)
        Me.U_Memo_Text_With_Browser1.Margin = New System.Windows.Forms.Padding(5)
        Me.U_Memo_Text_With_Browser1.Name = "U_Memo_Text_With_Browser1"
        Me.U_Memo_Text_With_Browser1.Size = New System.Drawing.Size(604, 27)
        Me.U_Memo_Text_With_Browser1.TabIndex = 2
        '
        'U_Memo_Txt_Value_Variable1
        '
        Me.U_Memo_Txt_Value_Variable1.A_Memo_Text_First_Init = "95"
        Me.U_Memo_Txt_Value_Variable1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.U_Memo_Txt_Value_Variable1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.U_Memo_Txt_Value_Variable1.Location = New System.Drawing.Point(327, 30)
        Me.U_Memo_Txt_Value_Variable1.Margin = New System.Windows.Forms.Padding(0)
        Me.U_Memo_Txt_Value_Variable1.Memo1_Text = "117"
        Me.U_Memo_Txt_Value_Variable1.Mirrored_Control = Nothing
        Me.U_Memo_Txt_Value_Variable1.Mirrored_Control_Exits = False
        Me.U_Memo_Txt_Value_Variable1.Mode_Memo = True
        Me.U_Memo_Txt_Value_Variable1.Mode_Mirror = False
        Me.U_Memo_Txt_Value_Variable1.Name = "U_Memo_Txt_Value_Variable1"
        Me.U_Memo_Txt_Value_Variable1.Original_Control = Nothing
        Me.U_Memo_Txt_Value_Variable1.Size = New System.Drawing.Size(105, 20)
        Me.U_Memo_Txt_Value_Variable1.TabIndex = 3
        Me.U_Memo_Txt_Value_Variable1.UControl_Border_Size = 0
        Me.U_Memo_Txt_Value_Variable1.UControl_Text_Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.U_Memo_Txt_Value_Variable1.UCtl_Text_BackColor = System.Drawing.SystemColors.Window
        Me.U_Memo_Txt_Value_Variable1.UCtl_Text_Color = System.Drawing.SystemColors.WindowText
        '
        'U_Memo_CheckBox_Display
        '
        Me.U_Memo_CheckBox_Display.BackColor = System.Drawing.Color.Gainsboro
        Me.U_Memo_CheckBox_Display.Checked = False
        Me.U_Memo_CheckBox_Display.Design_Appli_Path = Nothing
        Me.U_Memo_CheckBox_Display.Design_Current_Mode = Nothing
        Me.U_Memo_CheckBox_Display.Design_First_Init_Design = Nothing
        Me.U_Memo_CheckBox_Display.Design_Ident_Date = Nothing
        Me.U_Memo_CheckBox_Display.Design_Ident_Double = Nothing
        Me.U_Memo_CheckBox_Display.Design_Me_Name = Nothing
        Me.U_Memo_CheckBox_Display.Design_Parent_Name = Nothing
        Me.U_Memo_CheckBox_Display.Font = New System.Drawing.Font("Arial Narrow", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.U_Memo_CheckBox_Display.Location = New System.Drawing.Point(134, 65)
        Me.U_Memo_CheckBox_Display.Mirrored_Control = Nothing
        Me.U_Memo_CheckBox_Display.Mirrored_Control_Exits = False
        Me.U_Memo_CheckBox_Display.Mode_Memo = True
        Me.U_Memo_CheckBox_Display.Mode_Mirror = False
        Me.U_Memo_CheckBox_Display.Name = "U_Memo_CheckBox_Display"
        Me.U_Memo_CheckBox_Display.Original_Control = Nothing
        Me.U_Memo_CheckBox_Display.Parent_Name = Nothing
        Me.U_Memo_CheckBox_Display.Parent_Parent_Name = Nothing
        Me.U_Memo_CheckBox_Display.Size = New System.Drawing.Size(151, 25)
        Me.U_Memo_CheckBox_Display.TabIndex = 112
        Me.U_Memo_CheckBox_Display.Text_Memo_Check = "Display Text"
        Me.U_Memo_CheckBox_Display.UControl_Text_Font = New System.Drawing.Font("Comic Sans MS", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.U_Memo_CheckBox_Display.UCtl_Text_BackColor = System.Drawing.Color.PapayaWhip
        Me.U_Memo_CheckBox_Display.UCtl_Text_Color = System.Drawing.SystemColors.ControlText
        '
        'U_Msg_Local1
        '
        Me.U_Msg_Local1.AutoSize = True
        Me.U_Msg_Local1.BackColor = System.Drawing.Color.Magenta
        Me.U_Msg_Local1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.U_Msg_Local1.Design_Ident_Date = Nothing
        Me.U_Msg_Local1.Location = New System.Drawing.Point(1139, 4)
        Me.U_Msg_Local1.Margin = New System.Windows.Forms.Padding(5)
        Me.U_Msg_Local1.Name = "U_Msg_Local1"
        Me.U_Msg_Local1.Size = New System.Drawing.Size(99, 21)
        Me.U_Msg_Local1.TabIndex = 0
        '
        'U5_JSON_Read_Write
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.U_Memo_Directory_Browser1)
        Me.Controls.Add(Me.U_Draw_Minimize_Maximize1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.U_Memo_Text_With_Browser1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.U_Msg_Local1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "U5_JSON_Read_Write"
        Me.Size = New System.Drawing.Size(1450, 900)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents U_Msg_Local1 As Common_All_2013_a.U_Msg_Local
    Friend WithEvents TabControl1 As TabControl
	Friend WithEvents TabPage1 As TabPage
	Friend WithEvents TabPage2 As TabPage
	Friend WithEvents TabPage3 As TabPage
    Friend WithEvents U_Memo_Text_With_Browser1 As Common_All_2013_a.U_Memo_Text_With_Browser
    Friend WithEvents Label1 As Label
    Friend WithEvents U_Draw_Minimize_Maximize1 As Common_All_2013_a.U_Draw_Minimize_Maximize
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents U_Memo_Txt_Value_Variable1 As Common_All_2013_a.U_Memo_Txt_Mirror
    Friend WithEvents Label_Variable_Name As Label
	Friend WithEvents Button_Create_Json_From_Variable As Button
	Friend WithEvents Label8 As Label
	Friend WithEvents RichTextBox1 As RichTextBox
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents RichTextBox2 As RichTextBox
	Friend WithEvents Button_Create_JSON_From_Collection As Button
    Friend WithEvents U_Memo_Directory_Browser1 As Common_All_2013_a.U_Memo_Directory_Browser
    Friend WithEvents Label4 As Label
    Friend WithEvents RichTextBox_Structure As RichTextBox
    Friend WithEvents btnConvertJasonToStructure As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents RichTextBoxConvertJasonStructure As RichTextBox
    Friend WithEvents btnWriteJsonFile As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTestWriteJson As Label
    Friend WithEvents RichTextBoxWrite_Display As RichTextBox
    Friend WithEvents lblTestReadJson As Label
    Friend WithEvents RichTextBoxRead_Display As RichTextBox
    Friend WithEvents btnReadJsonFile As Button
    Friend WithEvents U_Memo_CheckBox_Display As Common_All_2013_a.U_Memo_Check_Mirror
    Friend WithEvents lbl_Compare_Read_Write As Label
    Friend WithEvents btn_Compare_Read_Write As Button
    Friend WithEvents RichTextBox_Compare_Read_Write As RichTextBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblConvert As Label
End Class
