<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TabControl1 = New System.Windows.Forms.TabControl()
		Me.TabPage1 = New System.Windows.Forms.TabPage()
		Me.TabPage2 = New System.Windows.Forms.TabPage()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.U_Memo_Check1 = New Common_All_2013_a.U_Memo_Check()
		Me.U_Memo_Use_Local_Data = New Common_All_2013_a.U_Memo_Check()
		Me.TabControl1.SuspendLayout()
		Me.TabPage1.SuspendLayout()
		Me.TableLayoutPanel1.SuspendLayout()
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
		Me.Label1.Size = New System.Drawing.Size(359, 16)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "GitHub Tuto v7 (Je 2 mai 2024)"
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
		Me.TabControl1.Size = New System.Drawing.Size(732, 378)
		Me.TabControl1.TabIndex = 5
		'
		'TabPage1
		'
		Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
		Me.TabPage1.Controls.Add(Me.Label2)
		Me.TabPage1.Location = New System.Drawing.Point(4, 25)
		Me.TabPage1.Name = "TabPage1"
		Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage1.Size = New System.Drawing.Size(724, 349)
		Me.TabPage1.TabIndex = 0
		Me.TabPage1.Text = "Prepare Data to PlanUML"
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
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
		Me.TableLayoutPanel1.ColumnCount = 2
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.U_Memo_Use_Local_Data, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.U_Memo_Check1, 1, 0)
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(18, 39)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 1
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(584, 29)
		Me.TableLayoutPanel1.TabIndex = 6
		'
		'U_Memo_Check1
		'
		Me.U_Memo_Check1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.U_Memo_Check1.Checked = False
		Me.U_Memo_Check1.Design_Appli_Path = Nothing
		Me.U_Memo_Check1.Design_Current_Mode = "Mode = Design"
		Me.U_Memo_Check1.Design_First_Init_Design = "Design_Mode - Semble être 1st init (1st Load)"
		Me.U_Memo_Check1.Design_Ident_Date = "dimanche 5 mai 2024 01:07:42 1662"
		Me.U_Memo_Check1.Design_Ident_Double = Nothing
		Me.U_Memo_Check1.Design_Me_Name = "(Design) Chaine Me.Name = U_Memo_Check"
		Me.U_Memo_Check1.Design_Parent_Name = "(Design) Parent.Name = TabPage1"
		Me.U_Memo_Check1.Location = New System.Drawing.Point(295, 4)
		Me.U_Memo_Check1.Name = "U_Memo_Check1"
		Me.U_Memo_Check1.Parent_Name = Nothing
		Me.U_Memo_Check1.Parent_Parent_Name = Nothing
		Me.U_Memo_Check1.Size = New System.Drawing.Size(285, 19)
		Me.U_Memo_Check1.TabIndex = 7
		Me.U_Memo_Check1.Text_Memo_Check = "MemoCheck"
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
		Me.U_Memo_Use_Local_Data.Size = New System.Drawing.Size(284, 19)
		Me.U_Memo_Use_Local_Data.TabIndex = 8
		Me.U_Memo_Use_Local_Data.Text_Memo_Check = "Use LOCAL Data (Démo)"
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
		Me.Size = New System.Drawing.Size(730, 403)
		Me.TabControl1.ResumeLayout(False)
		Me.TabPage1.ResumeLayout(False)
		Me.TableLayoutPanel1.ResumeLayout(False)
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
End Class
