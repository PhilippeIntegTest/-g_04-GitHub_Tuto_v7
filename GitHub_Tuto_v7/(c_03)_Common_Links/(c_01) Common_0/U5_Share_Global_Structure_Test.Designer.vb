<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class U5_Share_Global_Structure_Test
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
		Me.Label4 = New System.Windows.Forms.Label()
		Me.U_Node_Search_Object_By_Name1 = New Common_All_2013_a.U_Node_Search_Object_By_Name()
		Me.TabPage2 = New System.Windows.Forms.TabPage()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TabControl1.SuspendLayout()
		Me.TabPage1.SuspendLayout()
		Me.TabPage2.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.DarkViolet
		Me.Label1.Location = New System.Drawing.Point(130, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(219, 20)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "GitHub Tuto v7 (Je 2 mai 2024)"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TabControl1
		'
		Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
		Me.TabControl1.Controls.Add(Me.TabPage1)
		Me.TabControl1.Controls.Add(Me.TabPage2)
		Me.TabControl1.Location = New System.Drawing.Point(3, 23)
		Me.TabControl1.Name = "TabControl1"
		Me.TabControl1.SelectedIndex = 0
		Me.TabControl1.Size = New System.Drawing.Size(831, 485)
		Me.TabControl1.TabIndex = 5
		'
		'TabPage1
		'
		Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.TabPage1.Controls.Add(Me.Label4)
		Me.TabPage1.Controls.Add(Me.U_Node_Search_Object_By_Name1)
		Me.TabPage1.Location = New System.Drawing.Point(4, 25)
		Me.TabPage1.Name = "TabPage1"
		Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage1.Size = New System.Drawing.Size(823, 456)
		Me.TabPage1.TabIndex = 0
		Me.TabPage1.Text = "Share Struct - Use Search"
		'
		'Label4
		'
		Me.Label4.BackColor = System.Drawing.Color.Chartreuse
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.ForeColor = System.Drawing.Color.Maroon
		Me.Label4.Location = New System.Drawing.Point(3, 13)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(412, 16)
		Me.Label4.TabIndex = 6
		Me.Label4.Text = "Git: Branch Feature -->  Il faut rechercher l'objet U5_GitHub_Tuto_v8"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Label4.UseCompatibleTextRendering = True
		'
		'U_Node_Search_Object_By_Name1
		'
		Me.U_Node_Search_Object_By_Name1.a_Object_LogEvent_Prop = Nothing
		Me.U_Node_Search_Object_By_Name1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.U_Node_Search_Object_By_Name1.Location = New System.Drawing.Point(5, 45)
		Me.U_Node_Search_Object_By_Name1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.U_Node_Search_Object_By_Name1.Name = "U_Node_Search_Object_By_Name1"
		Me.U_Node_Search_Object_By_Name1.Size = New System.Drawing.Size(718, 406)
		Me.U_Node_Search_Object_By_Name1.TabIndex = 5
		'
		'TabPage2
		'
		Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TabPage2.Controls.Add(Me.Label3)
		Me.TabPage2.Controls.Add(Me.Label2)
		Me.TabPage2.Controls.Add(Me.Button1)
		Me.TabPage2.Location = New System.Drawing.Point(4, 25)
		Me.TabPage2.Name = "TabPage2"
		Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage2.Size = New System.Drawing.Size(823, 456)
		Me.TabPage2.TabIndex = 1
		Me.TabPage2.Text = "Exchange Pointer on Object"
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(57, 39)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(235, 23)
		Me.Button1.TabIndex = 0
		Me.Button1.Text = "Accès structure globale"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.Label2.Location = New System.Drawing.Point(54, 93)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(119, 17)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Nom Premier State="
		'
		'Label3
		'
		Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.Label3.Location = New System.Drawing.Point(179, 92)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(119, 18)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = " (Valeur)"
		'
		'U5_Share_Global_Structure_Test
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.LavenderBlush
		Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Controls.Add(Me.TabControl1)
		Me.Controls.Add(Me.Label1)
		Me.Name = "U5_Share_Global_Structure_Test"
		Me.Size = New System.Drawing.Size(847, 511)
		Me.TabControl1.ResumeLayout(False)
		Me.TabPage1.ResumeLayout(False)
		Me.TabPage2.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents TabControl1 As TabControl
	Friend WithEvents TabPage1 As TabPage
	Friend WithEvents U_Node_Search_Object_By_Name1 As Common_All_2013_a.U_Node_Search_Object_By_Name
	Friend WithEvents TabPage2 As TabPage
	Friend WithEvents Label4 As Label
	Friend WithEvents Button1 As Button
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
End Class
