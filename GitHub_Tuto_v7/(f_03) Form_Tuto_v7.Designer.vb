﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Tuto_v7
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
		Dim U_Memo_Check1 As Common_All_2013_a.U_Memo_Check
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TabControl1 = New System.Windows.Forms.TabControl()
		Me.TabPage1 = New System.Windows.Forms.TabPage()
		Me.U_Memo_Txt_Mirror1 = New Common_All_2013_a.U_Memo_Txt_Mirror()
		Me.TabPage2 = New System.Windows.Forms.TabPage()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TabPage3 = New System.Windows.Forms.TabPage()
		Me.U5_GitHub_Tuto_v71 = New GitHub_Tuto_v7.U5_GitHub_Tuto_v7()
		U_Memo_Check1 = New Common_All_2013_a.U_Memo_Check()
		Me.TabControl1.SuspendLayout()
		Me.TabPage1.SuspendLayout()
		Me.TabPage2.SuspendLayout()
		Me.TabPage3.SuspendLayout()
		Me.SuspendLayout()
		'
		'U_Memo_Check1
		'
		U_Memo_Check1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		U_Memo_Check1.Checked = False
		U_Memo_Check1.Design_Appli_Path = Nothing
		U_Memo_Check1.Design_Current_Mode = "Mode = Design"
		U_Memo_Check1.Design_First_Init_Design = "Design_Mode - Init déjà faite=jeudi 2 mai 2024 17:46:31 8185"
		U_Memo_Check1.Design_Ident_Date = "jeudi 2 mai 2024 17:46:31 8185"
		U_Memo_Check1.Design_Ident_Double = Nothing
		U_Memo_Check1.Design_Me_Name = "(Design) Chaine Me.Name = U_Memo_Check"
		U_Memo_Check1.Design_Parent_Name = "(Design) Parent.Name = TabPage1"
		U_Memo_Check1.ForeColor = System.Drawing.Color.Coral
		U_Memo_Check1.Location = New System.Drawing.Point(18, 40)
		U_Memo_Check1.Name = "U_Memo_Check1"
		U_Memo_Check1.Parent_Name = Nothing
		U_Memo_Check1.Parent_Parent_Name = Nothing
		U_Memo_Check1.Size = New System.Drawing.Size(197, 19)
		U_Memo_Check1.TabIndex = 2
		U_Memo_Check1.Text_Memo_Check = "MemoCheck simple"
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.DarkViolet
		Me.Label1.Location = New System.Drawing.Point(76, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(326, 23)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "GitHub Tuto v7 (Je 2 mai 2024)"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TabControl1
		'
		Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
		Me.TabControl1.Controls.Add(Me.TabPage1)
		Me.TabControl1.Controls.Add(Me.TabPage2)
		Me.TabControl1.Controls.Add(Me.TabPage3)
		Me.TabControl1.Location = New System.Drawing.Point(2, 38)
		Me.TabControl1.Name = "TabControl1"
		Me.TabControl1.SelectedIndex = 0
		Me.TabControl1.Size = New System.Drawing.Size(659, 304)
		Me.TabControl1.TabIndex = 1
		'
		'TabPage1
		'
		Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TabPage1.Controls.Add(U_Memo_Check1)
		Me.TabPage1.Controls.Add(Me.U_Memo_Txt_Mirror1)
		Me.TabPage1.Location = New System.Drawing.Point(4, 25)
		Me.TabPage1.Name = "TabPage1"
		Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage1.Size = New System.Drawing.Size(651, 275)
		Me.TabPage1.TabIndex = 0
		Me.TabPage1.Text = "Main Page"
		'
		'U_Memo_Txt_Mirror1
		'
		Me.U_Memo_Txt_Mirror1.A_Memo_Text_First_Init = "First_Init_String"
		Me.U_Memo_Txt_Mirror1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.U_Memo_Txt_Mirror1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.U_Memo_Txt_Mirror1.Location = New System.Drawing.Point(18, 62)
		Me.U_Memo_Txt_Mirror1.Margin = New System.Windows.Forms.Padding(0)
		Me.U_Memo_Txt_Mirror1.Memo1_Text = "Texte Mémorisé"
		Me.U_Memo_Txt_Mirror1.Mirrored_Control = Nothing
		Me.U_Memo_Txt_Mirror1.Mirrored_Control_Exits = False
		Me.U_Memo_Txt_Mirror1.Mode_Memo = True
		Me.U_Memo_Txt_Mirror1.Mode_Mirror = False
		Me.U_Memo_Txt_Mirror1.Name = "U_Memo_Txt_Mirror1"
		Me.U_Memo_Txt_Mirror1.Original_Control = Nothing
		Me.U_Memo_Txt_Mirror1.Size = New System.Drawing.Size(322, 16)
		Me.U_Memo_Txt_Mirror1.TabIndex = 1
		Me.U_Memo_Txt_Mirror1.UControl_Border_Size = 0
		Me.U_Memo_Txt_Mirror1.UControl_Text_Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.U_Memo_Txt_Mirror1.UCtl_Text_BackColor = System.Drawing.SystemColors.Window
		Me.U_Memo_Txt_Mirror1.UCtl_Text_Color = System.Drawing.SystemColors.WindowText
		'
		'TabPage2
		'
		Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.TabPage2.Controls.Add(Me.Label3)
		Me.TabPage2.Location = New System.Drawing.Point(4, 25)
		Me.TabPage2.Name = "TabPage2"
		Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage2.Size = New System.Drawing.Size(651, 275)
		Me.TabPage2.TabIndex = 1
		Me.TabPage2.Text = "Version Tree (GitHub)"
		'
		'Label3
		'
		Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.DarkViolet
		Me.Label3.Location = New System.Drawing.Point(102, 14)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(211, 16)
		Me.Label3.TabIndex = 1
		Me.Label3.Text = "Origin (Avant Common 2013)"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TabPage3
		'
		Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.TabPage3.Controls.Add(Me.U5_GitHub_Tuto_v71)
		Me.TabPage3.Location = New System.Drawing.Point(4, 25)
		Me.TabPage3.Name = "TabPage3"
		Me.TabPage3.Size = New System.Drawing.Size(651, 275)
		Me.TabPage3.TabIndex = 2
		Me.TabPage3.Text = "VersionTree (UserControl)"
		'
		'U5_GitHub_Tuto_v71
		'
		Me.U5_GitHub_Tuto_v71.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.U5_GitHub_Tuto_v71.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.U5_GitHub_Tuto_v71.Location = New System.Drawing.Point(16, 3)
		Me.U5_GitHub_Tuto_v71.Name = "U5_GitHub_Tuto_v71"
		Me.U5_GitHub_Tuto_v71.Size = New System.Drawing.Size(550, 190)
		Me.U5_GitHub_Tuto_v71.TabIndex = 0
		'
		'Form_Tuto_v7
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(665, 354)
		Me.Controls.Add(Me.TabControl1)
		Me.Controls.Add(Me.Label1)
		Me.Name = "Form_Tuto_v7"
		Me.Text = "GitHub Tuto_V7 (CherryPeek)"
		Me.TabControl1.ResumeLayout(False)
		Me.TabPage1.ResumeLayout(False)
		Me.TabPage2.ResumeLayout(False)
		Me.TabPage3.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents TabControl1 As TabControl
	Friend WithEvents TabPage1 As TabPage
	Friend WithEvents TabPage2 As TabPage
	Friend WithEvents Label3 As Label
	Friend WithEvents TabPage3 As TabPage
	Friend WithEvents U5_GitHub_Tuto_v71 As U5_GitHub_Tuto_v7
	Friend WithEvents U_Memo_Txt_Mirror1 As Common_All_2013_a.U_Memo_Txt_Mirror
End Class
