Public Class U5_Share_Global_Structure_Test
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Dim String_State_Name As String
		String_State_Name = Form_Tuto_v7.Global_Store_S_Equivalent.Collect_of_States.Table_Of_State_Info(1).State_Name

		If (Len(String_State_Name) > 1) Then
			Label3.Text = String_State_Name
			Label3.BackColor = Color.YellowGreen
		Else
			Label3.Text = " Non Trouvé "
			Label3.BackColor = Color.OrangeRed
		End If


	End Sub

	Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

	End Sub
End Class
