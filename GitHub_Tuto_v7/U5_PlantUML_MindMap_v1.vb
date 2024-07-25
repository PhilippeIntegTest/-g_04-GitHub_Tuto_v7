Option Strict On

Public Class U5_PlantUML_MindMap_v1

    Public Global_String_Path_For_Exe As String
    Public Global_String_Path_For_Jar As String
    Public Global_Flag_Jar_File_Is_OK As Boolean = False




    '**********************************************************************************
    '****   Definition of STATE Structure                                        ******
    '****                                                                        ******
    '**** Note1: the Class SortedList store info with a  (1) Key and a (2) type  ******
    '****       ==> Usefull to store States, Transitions, Indexes ...            ******
    '****                                                                        ******
    '**** Note2: Better than "Collection" in VB because there is a check of type ****** 
    '****        (but "Collection" is more powerfull !)                          ****** 
    '**********************************************************************************
    Public Structure Store_State_Info
        Dim Unique_State_Name As String
        Dim State_Code_for_DFB As Integer    '**** This is the number used in the specification (Open PLC Safety)
        Dim Type_of_State As Type_of_State
        Dim Table_Of_Transitions_Linked_to_this_State As System.Collections.Generic.SortedList(Of String, Store_Index_On_Transition_And_Next_State)  '#####  Attention: c'est du type:  Store_Index_On_Transition_And_Next_State   ##########
        Dim Current_Depth_Level As Type_Depth_Level
        Dim Parent_State_Machine_Index As Store_Index_On_State  '**** in case this machine is included in a composite state
        Dim Color_of_State_in_PlantUML As System.Drawing.Color
    End Structure


    '*********************************************************************************
    '****   Definition of Transition Structure                                 *******
    '*********************************************************************************
    Public Structure Store_Transition_Info
        Dim Unique_Transition_Name As String
        Dim Transition_Name_Short_Version As String
        '***** Table to be used for All test case generation    ******************
        Dim Table_of_States_Using_this_Transition As System.Collections.Generic.SortedList(Of String, Store_Index_On_State)
    End Structure


    '*********************************************************************************
    '****   Definition of Depth Level                           [PCh, 2024-07-25] ****
    '****                                                                         ****
    '**** Note1: Level_1 is Upper Level =1   (Should be a "Region" ?)             ****
    '**** Note2: Level_4 , 5, 6 have no Const definition but can be used          ****
    '****           --> Use directly the number                                   ****
    '*********************************************************************************
    Public Enum Type_Depth_Level
        Upper_Level_1 = 1
        Level_2 = 2
        Level_3 = 3
        Level_4 = 4
    End Enum

    '*********************************************************************************
    '****   Definition of Trasition Priority                    [PCh, 2024-07-25] ****
    '****                                                                         ****
    '**** Note1: Level_1 is priority max                                          ****
    '**** Note2: Level_4 , 5, 6 have no Const definition but can be used          ****
    '****           --> Use directly the number                                   ****
    '*********************************************************************************
    Public Enum Type_Transition_Priority
        Level_1 = 1
        Level_2 = 2
        Level_3 = 3
        Level_4 = 4
        Level_5 = 5
        Level_6 = 6
    End Enum

    '*********************************************************************************
    '****   Definition of State_Type (Start, End,...)           [PCh, 2024-07-25] ****
    '****                                                                         ****
    '**** Note1: Normal State is a state without embedded states                  ****
    '****                                                                         ****
    '*********************************************************************************
    Public Enum Type_of_State
        Start_State = 1  '*******   This is the starting point
        End_State = 2
        Composite_State = 3
        Normal_State = 4
    End Enum


    '*********************************************************************************
    '****   Definition of Link Index on States                  [PCh, 2024-07-25] ****
    '****                                                                         ****
    '**** Note1: Used to store a link to a state (Cf "Pointer")                   ****
    '**** Note2: 2 information are strored and wiil be Checked for Consistency    ****
    '****        of the stored structure                                          ****
    '*********************************************************************************
    Public Structure Store_Index_On_State
        Dim Unique_State_Name As String
        Dim State_Index_In_Table As Integer
    End Structure


    '*********************************************************************************
    '****   Definition of Link Index on Transitions             [PCh, 2024-07-25] ****
    '****                                                                         ****
    '**** Note1: Used to store a link to a state (Cf "Pointer")                   ****
    '**** Note2: 2 information are strored and wiil be Checked for Consistency    ****
    '****        of the stored structure                                          ****
    '*********************************************************************************
    Public Structure Store_Index_On_Transition_And_Next_State
        Dim Unique_Transition_Name As String
        Dim Transition_Index_In_Table As Integer
        Dim Next_State_for_this_Transition As Store_Index_On_State
        Dim Priority_of_this_Transition As Type_Transition_Priority
    End Structure

    '*********************************************************************************
    '****   Definition of Link to States by depth               [PCh, 2024-07-25] ****
    '****                                                                         ****
    '**** Note1: Used to store a link to a state (Cf "Pointer")                   ****
    '**** Note2: 2 information are strored and wiil be Checked for Consistency    ****
    '****        of the stored structure                                          ****
    '****                                                                         ****
    '**** Note3: Mettre dans une Classe pour éviter de faire un Init()            ****
    '****           à chaque niveau de profondeur !!!!!                           ****
    '*********************************************************************************
    Public Structure Store_Index_On_State_Plus_Depth
        Dim Unique_State_Name As String
        Dim State_Index_In_Table As Integer
        Dim Current_Level_Of_Depth As Type_Depth_Level   '******* At each level there is a collection of states !
        Dim Tree_Structure_Next_Depth_Level As System.Collections.Generic.SortedList(Of String, Store_Index_On_State_Plus_Depth)  '********* Ré-entrant: l'idée c'est de stocker un TreeView (Arborescent)
        '********* Note: pas vraiment besoin de mettre le nom du state en index !
    End Structure



    '*********************************************************************************
    '****   Definition State Machine Structure                  [PCh, 2024-07-25] ****
    '****                                                                         ****
    '**** Note1: Full structure of the State machine                              ****
    '**** Note2: 2 information are strored and wiil be Checked for Consistency    ****
    '****        of the stored structure                                          ****
    '*********************************************************************************
    Public Structure Store_Info_On_State_Machine
        Dim Unique_State_Machine_Name As String
        Dim Coll_of_States As System.Collections.Generic.SortedList(Of String, Store_State_Info)                                          '*********  Type = Store_State_Info  
        Dim Coll_of_Transitions As System.Collections.Generic.SortedList(Of String, Store_Transition_Info)                                '*********  Type = Store_Transition_Info
        Dim Root_Tree_Structure_Of_Machine_By_Depth As System.Collections.Generic.SortedList(Of String, Store_Index_On_State_Plus_Depth)  '*********  Type = Store_Index_On_State_Plus_Depth
    End Structure

    '######################################################################################################################################
    '#####   Note: (#ToDo) Passer cette structure en Classe et faire les Init des collections sur le New() ou l'Init_Collections()  #######
    '######################################################################################################################################


    '------     Static definition For State Machine Structure                  -------

    Public Info_Full_State_Mach_S_EQU_v1 As Store_Info_On_State_Machine
















    Private Sub Button_Load_State_Machine_Exemple_2_States_Click(sender As Object, e As EventArgs) Handles Button_Load_State_Machine_Exemple_2_States.Click
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


        PictureBox_UML_Result.Image = Image.FromFile("C:\User_Prog\(p_03)_Plant_UML\Input_PlantUML.png")


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


    Private Sub Button_Check_Directory_for_Java_Click(sender As Object, e As EventArgs) Handles Button_Check_Directory_for_Java.Click

        Button_Check_Directory_for_Java.BackColor = Color.Gold
        Check_Java_Directory_Is_Present()

    End Sub

    Private Sub Check_Java_Directory_Is_Present()
        On Error GoTo Errhandler_Avec_Diagnostic
        '------------------------------------------------------------------------------------
        '-----  Check if Java subDir exists  (Next: check Java is responding)             ---
        '------------------------------------------------------------------------------------
        Dim String_Path_For_Java As String
        String_Path_For_Java = "C:\Program Files\Java"
        '---- Original Path= C:\Program Files\Java\jre1.8.0_201\bin\java.exe           ------
        '---- Check if file is in this subDir        ---------------------------------------- 
        Dim Directory_Exists As Boolean
        Directory_Exists = System.IO.Directory.Exists(String_Path_For_Java)

        Label_Java_Directory.Text = "Path for Java Appli= " & String_Path_For_Java
        If (Directory_Exists = False) Then
            Button_Check_Directory_for_Java.BackColor = Color.OrangeRed
            Label_Java_Directory.BackColor = Color.OrangeRed
            '---- Could Exit Sub here !       -----------------------------------------------
        Else
            Button_Check_Directory_for_Java.BackColor = Color.YellowGreen
            Label_Java_Directory.BackColor = Color.YellowGreen
        End If

        '---- Check if file (PlanUML.jar) exists       --------------------------------------


        Exit Sub
        '-------------------------------------------------------------------------------
        '------------             Traitement des erreurs                      ----------
        '-------------------------------------------------------------------------------
Errhandler_Avec_Diagnostic:
        Call U_Msg_Local1.Affiche_Erreur("Error Launcher: Check_Jar_File_Is_Present() ")
        Resume Next
        '------------         Fin traitement des erreurs                   -------------
    End Sub

    Private Sub Button_Check_All_Java_Present_Click(sender As Object, e As EventArgs) Handles Button_Check_All_Java_Present.Click





    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button_Create_Composite_State_Machine_Click(sender As Object, e As EventArgs) Handles Button_Create_Composite_State_Machine.Click
        On Error GoTo Errhandler_Avec_Diagnostic
        '------------------------------------------------------------------------------------
        '-----  Button to Check Path for Exe file                                         ---
        '------------------------------------------------------------------------------------
        Button_Create_Composite_State_Machine.BackColor = Color.Gold
        Create_Struct_For_Composite_State_Machine_Simple_S_EQUIVALENT()

        Exit Sub
        '-------------------------------------------------------------------------------
        '------------             Traitement des erreurs                      ----------
        '-------------------------------------------------------------------------------
Errhandler_Avec_Diagnostic:
        Call U_Msg_Local1.Affiche_Erreur("Error Launcher: Button_Create_Composite_State_Machine() ")
        Resume Next
        '------------         Fin traitement des erreurs                   -------------





    End Sub

    Private Sub Create_Struct_For_Composite_State_Machine_Simple_S_EQUIVALENT()

        On Error GoTo Errhandler_Avec_Diagnostic
        '************************************************************************************
        '****  Init Structure                                                      **********
        '************************************************************************************
        Init_All_Collections_in_Class_or_Struct_Store_Info_On_State_Machine(Info_Full_State_Mach_S_EQU_v1)
        '------------------------------------------------------------------------------------
        '-----  Structure with 3 levels                                                   ---
        '------------------------------------------------------------------------------------
        Info_Full_State_Mach_S_EQU_v1.Unique_State_Machine_Name = "Premier Essai Simple State_Mach"

        '------------------------------------------------------------------------------------
        '-----  Remplissage 1er état                                                      ---
        '------------------------------------------------------------------------------------
        Dim St_Store_State_Info As New Store_State_Info  '#####  pourquoi un new avec cette structure ?   #######

        St_Store_State_Info.Unique_State_Name = "Full Composite Example S_EQUIVALENT"
        St_Store_State_Info.Type_of_State = Type_of_State.Composite_State
        ' Dim Table_Of_Transitions_Linked_to_this_State As Microsoft.VisualBasic.Collection  '#####  Attention: c'est du type:  Store_Index_On_Transition_And_Next_State   ##########
        St_Store_State_Info.Current_Depth_Level = Type_Depth_Level.Upper_Level_1
        St_Store_State_Info.Parent_State_Machine_Index = Nothing    '**** in case this machine is included in a composite state
        St_Store_State_Info.Color_of_State_in_PlantUML = Color.White

        '------------------------------------------------------------------------------------
        '-----  Ajout de l'etat dans la collection                                        ---
        '------------------------------------------------------------------------------------
        Info_Full_State_Mach_S_EQU_v1.Coll_of_States.Add(St_Store_State_Info.Unique_State_Name, St_Store_State_Info)


        Dim St_Store_State_Info_Test As New Store_State_Info  '#####  pourquoi un new avec cette structure ?   #######

        Dim Test_Liste As List(Of Integer)

        '*****  Déclaration de la variable  (First: Key, next Type of value)               *****************
        Dim Test_Sorted_List_Of_States As System.Collections.Generic.SortedList(Of String, Store_State_Info)

        '*****  Initialisation                     *********************************************************
        Test_Sorted_List_Of_States = New System.Collections.Generic.SortedList(Of String, Store_State_Info)
        Test_Sorted_List_Of_States.Add(St_Store_State_Info.Unique_State_Name, St_Store_State_Info)
        St_Store_State_Info_Test = Test_Sorted_List_Of_States.Item("Full Composite Example S_EQUIVALENT")



        ''====== Très dommage de devoir caster !!!!    ================================================================
        'St_Store_State_Info_Test = CType(Info_Full_State_Mach_S_EQU_v1.Coll_of_States.Item("Full Composite Example S_EQUIVALENT"), Store_State_Info)

        Dim Name_State As String
        Name_State = St_Store_State_Info_Test.Unique_State_Name





        Exit Sub
        '-------------------------------------------------------------------------------
        '------------             Traitement des erreurs                      ----------
        '-------------------------------------------------------------------------------
Errhandler_Avec_Diagnostic:
        Call U_Msg_Local1.Affiche_Erreur("Error Launcher: Create_Struct_For_Composite_State_Machine() ")
        Resume Next
        '------------         Fin traitement des erreurs                   -------------
    End Sub


    Private Sub Init_All_Collections_in_Class_or_Struct_Store_Info_On_State_Machine(ByRef Structure_Info_On_State_Machine As Store_Info_On_State_Machine)
        On Error GoTo Errhandler_Avec_Diagnostic
        '------------------------------------------------------------------------------------
        '-----  Note: (ToDo) à mettre dans le pseudo New() de la classe                   ---
        '------------------------------------------------------------------------------------
        Structure_Info_On_State_Machine.Unique_State_Machine_Name = " "

        Structure_Info_On_State_Machine.Coll_of_States = New System.Collections.Generic.SortedList(Of String, Store_State_Info)
        Structure_Info_On_State_Machine.Coll_of_Transitions = New System.Collections.Generic.SortedList(Of String, Store_Transition_Info)

        '------------------------------------------------------------------------------------
        '-----  TreeView: ça sera fait lors de la création ! (Par programme)              ---
        '------------------------------------------------------------------------------------
        Exit Sub
        '-------------------------------------------------------------------------------
        '------------             Traitement des erreurs                      ----------
        '-------------------------------------------------------------------------------
Errhandler_Avec_Diagnostic:
        Call U_Msg_Local1.Affiche_Erreur("Error Launcher: Init_All_Collections_in_Class_or_Struct_Store_Info_On_State_Machine() ")
        Resume Next
        '------------         Fin traitement des erreurs                   -------------
    End Sub





End Class
