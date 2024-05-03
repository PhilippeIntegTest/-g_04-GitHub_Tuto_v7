<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class U5_GitHub_Tuto_v7
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
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.DarkViolet
		Me.Label1.Location = New System.Drawing.Point(80, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(219, 20)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "GitHub Tuto v7 (Je 2 mai 2024)"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.Maroon
		Me.Label2.Location = New System.Drawing.Point(23, 30)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(434, 16)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Git: AVANT Origin (Base)"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Label2.UseCompatibleTextRendering = True
		'
		'Label3
		'
		Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.Maroon
		Me.Label3.Location = New System.Drawing.Point(45, 51)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(412, 16)
		Me.Label3.TabIndex = 3
		Me.Label3.Text = "Git: AVANT Origin - Add Common 2013 \ Backup: (z_06) Backup Add Common2013 .Net 4" &
	".7.2"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Label3.UseCompatibleTextRendering = True
		'
		'Label4
		'
		Me.Label4.BackColor = System.Drawing.Color.Yellow
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.ForeColor = System.Drawing.Color.Maroon
		Me.Label4.Location = New System.Drawing.Point(45, 72)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(412, 16)
		Me.Label4.TabIndex = 4
		Me.Label4.Text = "Git: Branch Feature -->  Add Label Yellow"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Label4.UseCompatibleTextRendering = True
		'
		'Label5
		'
		Me.Label5.BackColor = System.Drawing.Color.Aqua
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.ForeColor = System.Drawing.Color.Maroon
		Me.Label5.Location = New System.Drawing.Point(45, 93)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(412, 16)
		Me.Label5.TabIndex = 5
		Me.Label5.Text = "Git: Branch Feature -->  Add Shared Structure in U5 UserCtrl"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Label5.UseCompatibleTextRendering = True
		'
		'U5_GitHub_Tuto_v7
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Name = "U5_GitHub_Tuto_v7"
		Me.Size = New System.Drawing.Size(502, 148)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
End Class
