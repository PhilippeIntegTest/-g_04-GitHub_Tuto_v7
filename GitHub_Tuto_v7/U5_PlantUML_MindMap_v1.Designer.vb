﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class U5_PlantUML_MindMap_v1
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TabControl1 = New System.Windows.Forms.TabControl()
		Me.TabPage1 = New System.Windows.Forms.TabPage()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.U_Memo_Use_Local_Data = New Common_All_2013_a.U_Memo_Check()
		Me.U_Memo_Check1 = New Common_All_2013_a.U_Memo_Check()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TabPage2 = New System.Windows.Forms.TabPage()
		Me.Button_Load_State_Machine_Exemple_2_States = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.U_Memo_Text_With_Browser1 = New Common_All_2013_a.U_Memo_Text_With_Browser()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
		Me.TabControl1.SuspendLayout()
		Me.TabPage1.SuspendLayout()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.DarkViolet
		Me.Label1.Location = New System.Drawing.Point(75, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(471, 16)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "U5_PlantUML Application for MindMap and States Machines (Mai 2024)"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TabControl1
		'
		Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
		Me.TabControl1.Controls.Add(Me.TabPage1)
		Me.TabControl1.Controls.Add(Me.TabPage2)
		Me.TabControl1.Location = New System.Drawing.Point(-1, 22)
		Me.TabControl1.Name = "TabControl1"
		Me.TabControl1.SelectedIndex = 0
		Me.TabControl1.Size = New System.Drawing.Size(1079, 507)
		Me.TabControl1.TabIndex = 5
		'
		'TabPage1
		'
		Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.TabPage1.Controls.Add(Me.RichTextBox1)
		Me.TabPage1.Controls.Add(Me.GroupBox1)
		Me.TabPage1.Controls.Add(Me.Button_Load_State_Machine_Exemple_2_States)
		Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
		Me.TabPage1.Controls.Add(Me.Label2)
		Me.TabPage1.Location = New System.Drawing.Point(4, 25)
		Me.TabPage1.Name = "TabPage1"
		Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage1.Size = New System.Drawing.Size(1071, 478)
		Me.TabPage1.TabIndex = 0
		Me.TabPage1.Text = "Prepare Data to PlanUML"
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
		Me.TableLayoutPanel1.ColumnCount = 2
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.U_Memo_Use_Local_Data, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.U_Memo_Check1, 1, 0)
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(122, 22)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 1
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(444, 29)
		Me.TableLayoutPanel1.TabIndex = 6
		'
		'U_Memo_Use_Local_Data
		'
		Me.U_Memo_Use_Local_Data.Checked = False
		Me.U_Memo_Use_Local_Data.Design_Appli_Path = Nothing
		Me.U_Memo_Use_Local_Data.Design_Current_Mode = "Mode = Design"
		Me.U_Memo_Use_Local_Data.Design_First_Init_Design = "Design_Mode - Init déjà faite=dimanche 5 mai 2024 01:07:42 1662"
		Me.U_Memo_Use_Local_Data.Design_Ident_Date = "dimanche 5 mai 2024 01:07:42 1662"
		Me.U_Memo_Use_Local_Data.Design_Ident_Double = Nothing
		Me.U_Memo_Use_Local_Data.Design_Me_Name = "(Design) Chaine Me.Name = U_Memo_Check"
		Me.U_Memo_Use_Local_Data.Design_Parent_Name = "(Design) Parent.Name = TableLayoutPanel1"
		Me.U_Memo_Use_Local_Data.Location = New System.Drawing.Point(4, 4)
		Me.U_Memo_Use_Local_Data.Name = "U_Memo_Use_Local_Data"
		Me.U_Memo_Use_Local_Data.Parent_Name = Nothing
		Me.U_Memo_Use_Local_Data.Parent_Parent_Name = Nothing
		Me.U_Memo_Use_Local_Data.Size = New System.Drawing.Size(214, 19)
		Me.U_Memo_Use_Local_Data.TabIndex = 8
		Me.U_Memo_Use_Local_Data.Text_Memo_Check = "Use LOCAL Data (Démo)"
		'
		'U_Memo_Check1
		'
		Me.U_Memo_Check1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.U_Memo_Check1.Checked = False
		Me.U_Memo_Check1.Design_Appli_Path = Nothing
		Me.U_Memo_Check1.Design_Current_Mode = "Mode = Design"
		Me.U_Memo_Check1.Design_First_Init_Design = "Design_Mode - Init déjà faite=dimanche 5 mai 2024 01:07:42 1662"
		Me.U_Memo_Check1.Design_Ident_Date = "dimanche 5 mai 2024 01:07:42 1662"
		Me.U_Memo_Check1.Design_Ident_Double = Nothing
		Me.U_Memo_Check1.Design_Me_Name = "(Design) Chaine Me.Name = U_Memo_Check"
		Me.U_Memo_Check1.Design_Parent_Name = "(Design) Parent.Name = TableLayoutPanel1"
		Me.U_Memo_Check1.Location = New System.Drawing.Point(225, 4)
		Me.U_Memo_Check1.Name = "U_Memo_Check1"
		Me.U_Memo_Check1.Parent_Name = Nothing
		Me.U_Memo_Check1.Parent_Parent_Name = Nothing
		Me.U_Memo_Check1.Size = New System.Drawing.Size(196, 19)
		Me.U_Memo_Check1.TabIndex = 7
		Me.U_Memo_Check1.Text_Memo_Check = "MemoCheck"
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.Maroon
		Me.Label2.Location = New System.Drawing.Point(55, 3)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(434, 16)
		Me.Label2.TabIndex = 5
		Me.Label2.Text = "Create Script and send to PlantUML"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Label2.UseCompatibleTextRendering = True
		'
		'TabPage2
		'
		Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TabPage2.Location = New System.Drawing.Point(4, 25)
		Me.TabPage2.Name = "TabPage2"
		Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage2.Size = New System.Drawing.Size(724, 349)
		Me.TabPage2.TabIndex = 1
		Me.TabPage2.Text = "Show PLANTUML Graph"
		'
		'Button_Load_State_Machine_Exemple_2_States
		'
		Me.Button_Load_State_Machine_Exemple_2_States.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Button_Load_State_Machine_Exemple_2_States.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button_Load_State_Machine_Exemple_2_States.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button_Load_State_Machine_Exemple_2_States.Location = New System.Drawing.Point(122, 94)
		Me.Button_Load_State_Machine_Exemple_2_States.Name = "Button_Load_State_Machine_Exemple_2_States"
		Me.Button_Load_State_Machine_Exemple_2_States.Size = New System.Drawing.Size(309, 22)
		Me.Button_Load_State_Machine_Exemple_2_States.TabIndex = 7
		Me.Button_Load_State_Machine_Exemple_2_States.Text = "Load 2 states - STATE MACHINE example"
		Me.Button_Load_State_Machine_Exemple_2_States.UseVisualStyleBackColor = False
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button1.Location = New System.Drawing.Point(6, 19)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(309, 22)
		Me.Button1.TabIndex = 8
		Me.Button1.Text = "Check PlantUML.Jar is present"
		Me.Button1.UseVisualStyleBackColor = False
		'
		'Label3
		'
		Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.Maroon
		Me.Label3.Location = New System.Drawing.Point(6, 90)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(434, 16)
		Me.Label3.TabIndex = 9
		Me.Label3.Text = "Place where PlantUML is: (1st Init=)  C:\User_PlantUML"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Label3.UseCompatibleTextRendering = True
		'
		'U_Memo_Text_With_Browser1
		'
		Me.U_Memo_Text_With_Browser1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.U_Memo_Text_With_Browser1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.U_Memo_Text_With_Browser1.File_Exists_On_Disk = False
		Me.U_Memo_Text_With_Browser1.Filter = "All Files (*.*)|*.*"
		Me.U_Memo_Text_With_Browser1.Location = New System.Drawing.Point(6, 109)
		Me.U_Memo_Text_With_Browser1.Name = "U_Memo_Text_With_Browser1"
		Me.U_Memo_Text_With_Browser1.Size = New System.Drawing.Size(440, 19)
		Me.U_Memo_Text_With_Browser1.TabIndex = 10
		'
		'GroupBox1
		'
		Me.GroupBox1.BackColor = System.Drawing.Color.Bisque
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Controls.Add(Me.U_Memo_Text_With_Browser1)
		Me.GroupBox1.Controls.Add(Me.Button1)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Location = New System.Drawing.Point(488, 75)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(577, 152)
		Me.GroupBox1.TabIndex = 11
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Check PlantUML EXE File"
		'
		'Label4
		'
		Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.ForeColor = System.Drawing.Color.Black
		Me.Label4.Location = New System.Drawing.Point(137, 44)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(434, 16)
		Me.Label4.TabIndex = 11
		Me.Label4.Text = "Box Storage for ALL additional files (PlantUML.jar)"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Label4.UseCompatibleTextRendering = True
		'
		'RichTextBox1
		'
		Me.RichTextBox1.Location = New System.Drawing.Point(488, 244)
		Me.RichTextBox1.Name = "RichTextBox1"
		Me.RichTextBox1.Size = New System.Drawing.Size(571, 157)
		Me.RichTextBox1.TabIndex = 12
		Me.RichTextBox1.Text = "@startuml" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "[*] --> State1" & Global.Microsoft.VisualBasic.ChrW(10) & "State1 --> [*]" & Global.Microsoft.VisualBasic.ChrW(10) & "State1 : this is a string" & Global.Microsoft.VisualBasic.ChrW(10) & "State1 : this " &
	"is another string" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "State1 -> State2" & Global.Microsoft.VisualBasic.ChrW(10) & "State2 --> [*]" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "@enduml"
		'
		'U5_PlantUML_MindMap_v1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoScroll = True
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Controls.Add(Me.TabControl1)
		Me.Controls.Add(Me.Label1)
		Me.Name = "U5_PlantUML_MindMap_v1"
		Me.Size = New System.Drawing.Size(1099, 532)
		Me.TabControl1.ResumeLayout(False)
		Me.TabPage1.ResumeLayout(False)
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.GroupBox1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents TabControl1 As TabControl
	Friend WithEvents TabPage1 As TabPage
	Friend WithEvents U_Memo_Check1 As Common_All_2013_a.U_Memo_Check
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents Label2 As Label
	Friend WithEvents TabPage2 As TabPage
	Friend WithEvents U_Memo_Use_Local_Data As Common_All_2013_a.U_Memo_Check
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents Label4 As Label
	Friend WithEvents U_Memo_Text_With_Browser1 As Common_All_2013_a.U_Memo_Text_With_Browser
	Friend WithEvents Button1 As Button
	Friend WithEvents Label3 As Label
	Friend WithEvents Button_Load_State_Machine_Exemple_2_States As Button
	Friend WithEvents RichTextBox1 As RichTextBox
End Class
