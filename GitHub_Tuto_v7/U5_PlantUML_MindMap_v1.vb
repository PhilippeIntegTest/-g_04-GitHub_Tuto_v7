Option Strict On

Public Class U5_PlantUML_MindMap_v1

    Public Global_String_Path_For_Exe As String
    Public Global_String_Path_For_Jar As String
    Public Global_Flag_Jar_File_Is_OK As Boolean = False


    Private Sub Button_Load_State_Machine_Exemple_2_States_Click(sender As Object, e As EventArgs) Handles Button_Load_State_Machine_Exemple_2_States.Click


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


        PictureBox_UML_Result.Image = Image.FromFile("C:\User_Prog\(p_03)_Plant_UML\Input_PlantUML.png")


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        'System.IO.Compression.


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        On Error GoTo Errhandler_Avec_Diagnostic
        '------------------------------------------------------------------------------------
        '-----  Button to Check Path for Exe file                                         ---
        '------------------------------------------------------------------------------------
        Button6.BackColor = Color.Gold
        Check_Path_for_Exe_File()

        Exit Sub
        '-------------------------------------------------------------------------------
        '------------             Traitement des erreurs                      ----------
        '-------------------------------------------------------------------------------
Errhandler_Avec_Diagnostic:
        Call U_Msg_Local1.Affiche_Erreur("Error Launcher: Read_Exe_File_Path() ")
        Resume Next
        '------------         Fin traitement des erreurs                   -------------
    End Sub

    Private Sub Check_Path_for_Exe_File()
        On Error GoTo Errhandler_Avec_Diagnostic
        '------------------------------------------------------------------------------------
        '-----  Init Objects for startup other pages in Sub-Control "U3_Read_GCode.vb"    ---
        '------------------------------------------------------------------------------------
        Dim String_Path_For_Exe As String
        String_Path_For_Exe = My.Application.Info.DirectoryPath

        Dim String_For_Exe_Name As String
        String_For_Exe_Name = My.Application.Info.AssemblyName

        '----  Set public var  -------------------------------------------------------------
        Global_String_Path_For_Exe = String_Path_For_Exe

        Label_Full_Path_Exe.Text = String_Path_For_Exe + "; Assembly= " + String_For_Exe_Name
        Label_Full_Path_Exe.BackColor = Color.GreenYellow
        Button6.BackColor = Color.GreenYellow

        Exit Sub
        '-------------------------------------------------------------------------------
        '------------             Traitement des erreurs                      ----------
        '-------------------------------------------------------------------------------
Errhandler_Avec_Diagnostic:
        Call U_Msg_Local1.Affiche_Erreur("Error Launcher: Check_Path_for_Exe_File() ")
        Resume Next
        '------------         Fin traitement des erreurs                   -------------
    End Sub


    Private Sub Button_Check_PlantUML_Is_Present_Click(sender As Object, e As EventArgs) Handles Button_Check_PlantUML_Is_Present.Click
        Button_Check_PlantUML_Is_Present.BackColor = Color.Gold
        Check_Jar_File_Is_Present()
    End Sub


    Private Sub Check_Jar_File_Is_Present()
        On Error GoTo Errhandler_Avec_Diagnostic
        '------------------------------------------------------------------------------------
        '-----  Init Objects for startup other pages in Sub-Control "U3_Read_GCode.vb"    ---
        '------------------------------------------------------------------------------------
        Dim String_Path_For_Jar As String
        String_Path_For_Jar = My.Application.Info.DirectoryPath

        '---- Original Path= W:\Disk\Dev_2024-TGB\(p_04)_U5_PlanUML_VB_v2\GitHub_Tuto_v7\bin\Debug\(c_03)_Common_Links\(c_01) Common_0\plantuml-1.2024.4.jar
        Dim SubString_Path_For_Common_Files As String
        SubString_Path_For_Common_Files = "\(c_03)_Common_Links\(c_01) Common_0\plantuml-1.2024.4.jar"

        Dim String_Path_For_Directory_Common_Files As String
        String_Path_For_Directory_Common_Files = String_Path_For_Jar & "\(c_03)_Common_Links\(c_01) Common_0"
        '---- Check if file is in this subDir        ---------------------------------------- 
        Dim Directory_Exists As Boolean
        Directory_Exists = System.IO.Directory.Exists(String_Path_For_Directory_Common_Files)
        If (Directory_Exists = False) Then
            Button_Check_PlantUML_Is_Present.BackColor = Color.Red
            '---- Could Exit Sub here !       -----------------------------------------------
        End If

        '---- Check if file (PlanUML.jar) exists       --------------------------------------
        Dim Local_File_Exists As Boolean
        SubString_Path_For_Common_Files = My.Application.Info.DirectoryPath & SubString_Path_For_Common_Files
        Local_File_Exists = System.IO.File.Exists(SubString_Path_For_Common_Files)

        Label_Path_For_Jar_File.Text = SubString_Path_For_Common_Files
        If (Local_File_Exists = False) Then
            Label_Path_For_Jar_File.BackColor = Color.Red
            Global_Flag_Jar_File_Is_OK = False
        Else
            Label_Path_For_Jar_File.BackColor = Color.YellowGreen
            Global_Flag_Jar_File_Is_OK = True
            Global_String_Path_For_Jar = SubString_Path_For_Common_Files
        End If


        Exit Sub
        '-------------------------------------------------------------------------------
        '------------             Traitement des erreurs                      ----------
        '-------------------------------------------------------------------------------
Errhandler_Avec_Diagnostic:
        Call U_Msg_Local1.Affiche_Erreur("Error Launcher: Check_Jar_File_Is_Present() ")
        Resume Next
        '------------         Fin traitement des erreurs                   -------------
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class
