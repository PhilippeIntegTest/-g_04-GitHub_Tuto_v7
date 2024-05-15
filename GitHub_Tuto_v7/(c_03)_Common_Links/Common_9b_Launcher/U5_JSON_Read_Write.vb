Option Strict On

'===============================================================================
'====   U_Add_Popup_Menu :  Ajout Popup on Mouse                            ====
'===============================================================================
#Const Flag_Mode_Debug_Full = "No"
#Const Flag_Mode_Debug_Medium = "No"
#Const Flag_Mode_Opengl_Present = "No"
#Const Flag_Dbg_Add_Popup_Menu_Min_Max = "Yes"


Public Class U5_JSON_Read_Write

    '*************************************************************************************
    '**** Définition des structures de données pour la state Machine (Lu 18 mars 2024) ***
    '*************************************************************************************
    Public Structure Store_State_Info
        Dim State_Name As String
        Dim UUID_Of_State As String
        Dim Table_Of_Events_Linked_To_This_State As Collection_Of_Events
    End Structure

    Public Structure Store_Event_Info
        Dim Event_Name As String
        Dim UUID_Of_Event As String
        Dim Table_Of_States_Linked_To_This_State As Collection_Of_States
    End Structure

    Public Structure Collection_Of_Events
        Dim Count As Integer
        Dim Table_Of_Event_Info() As Store_Event_Info
    End Structure

    Public Structure Collection_Of_States
        Dim Count As Integer
        Dim Table_Of_State_Info() As Store_State_Info
    End Structure

    '*******************************************************************************
    '**** Définition de la structure contenant les données de la state Machine   ***
    '*******************************************************************************
    Public Structure Store_Info_On_State_Machine
        Dim Collect_of_States As Collection_Of_States
        Dim Collect_of_Events As Collection_Of_Events
    End Structure

    '*******************************************************************************
    '**** Réservation de l'objet pour une state machine (instance)               ***
    '**** Note1: les tailles des objets sont à redimentionner en fonction        ***
    '****        du besoin par redim preserve                                    *** 
    '*******************************************************************************
    Dim Store_S_Equivalent As Store_Info_On_State_Machine
    Dim Store_S_Equivalent_Read As Store_Info_On_State_Machine



    Private Sub Button_Create_Json_From_Variable_Click(sender As Object, e As EventArgs) Handles Button_Create_Json_From_Variable.Click
        On Error GoTo Errhandler_Avec_Diagnostic

        '---------------------------------------------------------------------------------
        '---    Note1: Use of Newtonsoft instead of System.Text.Json !     (Mars 2024) ---
        '---           ==> Better to use Microsoft Lib but seems not compatible        ---
        '---               with this project (To be checked !)                         ---
        '---                                                                           ---
        '---    Note2: This function is part of Unitary tests for JSON UserControl     ---
        '---------------------------------------------------------------------------------


        Dim Compteur_Test_Json As Integer
        Compteur_Test_Json = Integer.Parse(U_Memo_Txt_Value_Variable1.Memo1_Text)
        Dim String_Json_From_Variable As String
        String_Json_From_Variable = Newtonsoft.Json.JsonConvert.SerializeObject(Compteur_Test_Json, Newtonsoft.Json.Formatting.Indented)
        TextBox1.Text = String_Json_From_Variable
        TextBox1.BackColor = Color.YellowGreen
        TextBox2.BackColor = Color.YellowGreen
        Dim Converted_text As String = Newtonsoft.Json.JsonConvert.DeserializeObject(Of String)(String_Json_From_Variable)

        Dim Table_Text_String As String()
        ReDim Table_Text_String(5)
        Table_Text_String(1) = "Première_Chaine"
        Table_Text_String(2) = "Chaine 2"
        Table_Text_String(3) = "Chaine 3"
        RichTextBox_Structure.Lines = Table_Text_String
        TextBox2.Text = Newtonsoft.Json.JsonConvert.SerializeObject(Table_Text_String, Newtonsoft.Json.Formatting.Indented)
        Dim Converted_table As String()
        ReDim Converted_table(5)
        Converted_table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of String())(TextBox2.Text)
        'RichTextBox_Structure.Text = Converted_table(1) & Converted_table(2) & Converted_table(3) & Converted_table(4) & Converted_table(5)
        'RichTextBox_Structure.Lines = Converted_table
        lblConvert.Text = "Converted with success!"

        Exit Sub
        '-------------------------------------------------------------------------------
        '------------             Traitement des erreurs                      ----------
        '-------------------------------------------------------------------------------
Errhandler_Avec_Diagnostic:
        Call U_Msg_Local1.Affiche_Erreur(" Button_Create_Json_From_Variable_Click()")
        Resume Next
        '------------         Fin traitement des erreurs                   -------------
    End Sub

    Private Sub Button_Create_JSON_From_Collection_Click(sender As Object, e As EventArgs) Handles Button_Create_JSON_From_Collection.Click
        On Error GoTo Errhandler_Avec_Diagnostic

        '---------------------------------------------------------------------------------
        '---    Note1: Use of Newtonsoft instead of System.Text.Json !     (Mars 2024) ---
        '---           ==> Better to use Microsoft Lib but seems not compatible        ---
        '---               with this project (To be checked !)                         ---
        '---                                                                           ---
        '---    Note2: This function is part of Unitary tests for JSON UserControl     ---
        '---------------------------------------------------------------------------------

        Dim Counter_Of_States As Integer
        '*** Exemple de chaine de mise au point:    ************************************** 
        Call U_Msg_Local1.Aff_Coul_RGB(Common_All_2013_a.U_Msg_Local.Type_Warning.Aff_INFO_GRAS, Color.Blue, "   === Mise au point non filtrée ! || Nombre d'états= " & Str(Counter_Of_States) & vbCrLf)

        '*** Exemple de chaine de mise au point (Filtrée):    ************************************** 
#If Flag_Mode_Debug_Medium = "Yes" Then
        Call U_Msg_Local1.Aff_Coul_RGB(U_Msg_Local.Type_Warning.Aff_INFO_GRAS, Color.Red, "   === Mise au point filtrée ! || Nombre d'états= " & Str(Counter_Of_States) & vbCrLf)
#End If


        '-----  Mise en place de 3 états    ---------------------------------------------------------
        Store_S_Equivalent.Collect_of_States.Count = 3
        ReDim Store_S_Equivalent.Collect_of_States.Table_Of_State_Info(4)  '=== Attention +1 si on commence à 1 en VB  ====
        Store_S_Equivalent.Collect_of_States.Table_Of_State_Info(1).State_Name = "Etat n° 1"
        Store_S_Equivalent.Collect_of_States.Table_Of_State_Info(2).State_Name = "Etat n° 2"
        Store_S_Equivalent.Collect_of_States.Table_Of_State_Info(3).State_Name = "Etat n° 3"

        '-----------------------------------------------------------------------------------------------------
        '-----  Mise en place de 2 transitions                                                           -----
        '----- Note1: On réserve 20 emplacements pour ne pas avoir à augmenter la taille à chaque fois   -----
        '-----------------------------------------------------------------------------------------------------
        Store_S_Equivalent.Collect_of_Events.Count = 2
        ReDim Store_S_Equivalent.Collect_of_Events.Table_Of_Event_Info(20)  '=== Attention +1 si on commence à 1 en VB  ====
        Store_S_Equivalent.Collect_of_Events.Table_Of_Event_Info(1).Event_Name = "Event n° 1"
        Store_S_Equivalent.Collect_of_Events.Table_Of_Event_Info(2).Event_Name = "Event n° 2"

        '-----  Mise en place d'une transition liée à l'état n°1                                --------------
        '-----  Note1: le preserve ne sert pas la première fois car la table est vide !         --------------
        ReDim Preserve Store_S_Equivalent.Collect_of_States.Table_Of_State_Info(1).Table_Of_Events_Linked_To_This_State.Table_Of_Event_Info(2)
        Store_S_Equivalent.Collect_of_States.Table_Of_State_Info(1).Table_Of_Events_Linked_To_This_State.Count = 1
        '##### Remarque: on place l'évennement crée au dessus                                   ##############
        Store_S_Equivalent.Collect_of_States.Table_Of_State_Info(1).Table_Of_Events_Linked_To_This_State.Table_Of_Event_Info(1) = Store_S_Equivalent.Collect_of_Events.Table_Of_Event_Info(1)

        Dim String_Json_From_Variable As String
        String_Json_From_Variable = Newtonsoft.Json.JsonConvert.SerializeObject(Store_S_Equivalent, Newtonsoft.Json.Formatting.Indented)
        RichTextBox2.Text = String_Json_From_Variable
        RichTextBox2.BackColor = Color.YellowGreen


        '### TODO n°1: sauvegarder la structure dans un fichier !      ###############
        '### TODO n°2: Relire la structure à partir du fichier JSON    ###############


        Exit Sub
        '-------------------------------------------------------------------------------
        '------------             Traitement des erreurs                      ----------
        '-------------------------------------------------------------------------------
Errhandler_Avec_Diagnostic:
        Call U_Msg_Local1.Affiche_Erreur(" Button_Create_Json_From_Variable_Click()")
        Resume Next
        '------------         Fin traitement des erreurs                   -------------








    End Sub

    Private Sub btnConvertJasonToStructure_Click(sender As Object, e As EventArgs) Handles btnConvertJasonToStructure.Click

        On Error GoTo Errhandler_Avec_Diagnostic

        '-------------------------------------------------------------------------------
        '--------------- Création de l'objet Store_S_Equivalent_READ -------------------
        '-------------------------------------------------------------------------------
        Dim Store_S_Equivalent_Read_test As Store_Info_On_State_Machine
        Store_S_Equivalent_Read_test.Collect_of_States.Count = 3
        ReDim Store_S_Equivalent_Read_test.Collect_of_States.Table_Of_State_Info(4)
        Store_S_Equivalent_Read_test.Collect_of_Events.Count = 2
        ReDim Store_S_Equivalent_Read_test.Collect_of_Events.Table_Of_Event_Info(20)

        '------- Conversion le String Json en format Store_Info_On_State_Machine -------

        Store_S_Equivalent_Read_test = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Store_Info_On_State_Machine)(RichTextBox2.Text)

        '--------------------- Affichage -----------------------------------------------

        RichTextBoxConvertJasonStructure.Text = Store_S_Equivalent_Read_test.Collect_of_States.Table_Of_State_Info(1).State_Name
        RichTextBoxConvertJasonStructure.Text = RichTextBoxConvertJasonStructure.Text & " " & Store_S_Equivalent_Read_test.Collect_of_States.Table_Of_State_Info(2).State_Name
        RichTextBoxConvertJasonStructure.Text = RichTextBoxConvertJasonStructure.Text & " " & Store_S_Equivalent_Read_test.Collect_of_Events.Table_Of_Event_Info(1).Event_Name
        RichTextBoxConvertJasonStructure.Text = RichTextBoxConvertJasonStructure.Text & " " & Store_S_Equivalent_Read_test.Collect_of_Events.Table_Of_Event_Info(2).Event_Name
        'RichTextBoxConvertJasonStructure.Text = JsonConvert.SerializeObject(Store_S_Equivalent_READ, Newtonsoft.Json.Formatting.Indented)
        RichTextBoxConvertJasonStructure.BackColor = Color.YellowGreen

        Exit Sub
        '-------------------------------------------------------------------------------
        '------------             Traitement des erreurs                      ----------
        '-------------------------------------------------------------------------------
Errhandler_Avec_Diagnostic:
        Call U_Msg_Local1.Affiche_Erreur(" Button Convert Json String to the existing structure")
        Resume Next
        '------------         Fin traitement des erreurs                   -------------


    End Sub

    Private Sub btnWriteJsonFile_Click(sender As Object, e As EventArgs) Handles btnWriteJsonFile.Click
        On Error GoTo Errhandler_Avec_Diagnostic
        '----------------------- Bouton set to yellow at the beginning of the function ----------------------
        btnWriteJsonFile.BackColor = Color.Yellow


        '---------------------- Preparation of structure for writing in Json file ----------------------------



        '---------------------- Write function call (Functional test) ---------------------------------------- 

        Call Write_Json_To_File("freffezfez")

        Exit Sub
        '-------------------------------------------------------------------------------
        '------------             Traitement des erreurs                      ----------
        '-------------------------------------------------------------------------------
Errhandler_Avec_Diagnostic:
        Call U_Msg_Local1.Affiche_Erreur("*** Erreur fonction btnWriteJsonFile_Click")
        btnConvertJasonToStructure.BackColor = Color.Red
        Resume Next
        '------------         Fin traitement des erreurs                   -------------

    End Sub


    Public Sub Write_Json_To_File(ByRef Object_Input As String)

        On Error GoTo Errhandler_Avec_Diagnostic
        Dim Flag_Written As Boolean = False
        Dim Store_S_Equivalent_Write As Store_Info_On_State_Machine
        Dim Converted_text As String
        Store_S_Equivalent_Write.Collect_of_States.Count = 3
        ReDim Store_S_Equivalent_Write.Collect_of_States.Table_Of_State_Info(4)
        Store_S_Equivalent_Write.Collect_of_States.Table_Of_State_Info(1).State_Name = "Etat n° 1"
        Store_S_Equivalent_Write.Collect_of_States.Table_Of_State_Info(2).State_Name = "Etat n° 2"
        Store_S_Equivalent_Write.Collect_of_States.Table_Of_State_Info(3).State_Name = "Etat n° 3"
        Store_S_Equivalent_Write.Collect_of_Events.Count = 2
        ReDim Store_S_Equivalent_Write.Collect_of_Events.Table_Of_Event_Info(20)
        Store_S_Equivalent_Write.Collect_of_Events.Table_Of_Event_Info(1).Event_Name = "Event n° 1"
        Store_S_Equivalent_Write.Collect_of_Events.Table_Of_Event_Info(2).Event_Name = "Event n° 2"

        '----------- Conversion en format Json String --------------------------------------------------

        Converted_text = Newtonsoft.Json.JsonConvert.SerializeObject(Store_S_Equivalent_Write, Newtonsoft.Json.Formatting.Indented)

        '----------- On procède à l'écriture dans un fichier que l'on choisit dans Browser text --------

        Dim Directory_From_Memo_Browser As String = U_Memo_Directory_Browser1.UC1_Label_AutoEllipses_b1.Text

        If My.Computer.FileSystem.FileExists(Directory_From_Memo_Browser) = True Then
            If My.Computer.FileSystem.ReadAllText(Directory_From_Memo_Browser).Length = 0 Then
                System.IO.File.AppendAllText(Directory_From_Memo_Browser, Converted_text)
            Else
                System.IO.File.Delete(Directory_From_Memo_Browser)
                System.IO.File.AppendAllText(Directory_From_Memo_Browser, Converted_text)

            End If
        Else
            System.IO.File.AppendAllText(Directory_From_Memo_Browser, Converted_text)
        End If
        '----------- Si on la check box est activé on affiche dans le tableau ce qui a été écrit -------



        RichTextBoxWrite_Display.Text = Converted_text


        RichTextBoxWrite_Display.Text = Converted_text
        btnWriteJsonFile.BackColor = Color.Green
        lblTestWriteJson.Text = "Converted with success"





        '----------------- Partie Debug --------------------------------------------------

#If Flag_Mode_Debug_Medium = "Yes" Then
        '---   Debug for Length of identification string      ----------------------------
        U_Msg_Local1.Aff_Coul_RGB(U_Msg_Local.Type_Warning.Aff_INFO_GRAS, Color.RosyBrown, "Chaine à écrire dans le fichier = " & Converted_text)
#End If

        Exit Sub
        '-------------------------------------------------------------------------------
        '------------             Traitement des erreurs                      ----------
        '-------------------------------------------------------------------------------
Errhandler_Avec_Diagnostic:
        Call U_Msg_Local1.Affiche_Erreur("*** Erreur fonction Write_Json_To_File")
        btnConvertJasonToStructure.BackColor = Color.Red
        Resume Next
        '------------         Fin traitement des erreurs                   -------------
    End Sub




    Public Sub Read_Json(ByRef Object_Struct As Object, Directory As String)

        '---------------------- TEST DE COMPARAISON WRITE READ -----------------------
        '---------------------- LA MÊME PROCEDURE QUE DANS WRITE ---------------------
        On Error GoTo Errhandler_Avec_Diagnostic
        Dim Object_Type As Type
        Object_Type = Object_Struct.GetType()
        Dim Text_read_Json As String


        btnReadJsonFile.BackColor = Color.Yellow
        '=====================   Variables locales      ===============================

        'Dim Store_S_Equivalent_Read As Store_Info_On_State_Machine
        'Dim Directory_From_Memo_Browser As String = U_Memo_Directory_Browser1.UC1_Label_AutoEllipses_b1.Text

        '=====================   Fin Variables locales  ===============================
        '-------------------------------------------------------------------------------
        '--------------- Création de l'objet Store_S_Equivalent_READ -------------------
        '-------------------------------------------------------------------------------

        'Store_S_Equivalent_Read.Collect_of_States.Count = 3
        'ReDim Store_S_Equivalent_Read.Collect_of_States.Table_Of_State_Info(4)
        'Store_S_Equivalent_Read.Collect_of_Events.Count = 2
        'ReDim Store_S_Equivalent_Read.Collect_of_Events.Table_Of_Event_Info(20)

        '------ Partie lécture et conversion en objet S_Equivalent             --------
        '------ On ouvre le file text on stocke le text dans Text_read_Json et --------
        '------                      on le désérialize                         --------

        '-------------------- On choisit cette fonction car 
        If My.Computer.FileSystem.FileExists(Directory) = True Then
            Text_read_Json = System.IO.File.ReadAllText(Directory)

            Dim deserializedMethode = GetType(Newtonsoft.Json.JsonConvert).GetMethod("DeserializedObject", New Type() {GetType(String), GetType(Type)})
            Dim Result = deserializedMethode.Invoke(Nothing, New Object() {Text_read_Json, Object_Type})
            Object_Struct = Result
            'Object_Struct = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Object_Type)(Text_read_Json)

            'If Result.GetType() = Object_Type Then
            '    MsgBox("yes")
            'Else
            '    MsgBox("no")
            'End If
            '-------------------- Affichage du texte lu -----------------------------------

            RichTextBoxRead_Display.Text = Text_read_Json
            btnReadJsonFile.BackColor = Color.Green
            lblTestReadJson.Text = "Lecture done"

        Else
            btnReadJsonFile.BackColor = Color.Red
            lblTestReadJson.Text = "File doesn't exist"
        End If


#If Flag_Mode_Debug_Medium = "Yes" Then
        '---   Debug for Length of identification string      ----------------------------
        'U_Msg_Local1.Aff_Coul_RGB(U_Msg_Local.Type_Warning.Aff_INFO_GRAS, Color.RosyBrown, "Chaine lue dans le fichier = " & )
#End If

        Exit Sub
        '-------------------------------------------------------------------------------
        '------------             Traitement des erreurs                      ----------
        '-------------------------------------------------------------------------------
Errhandler_Avec_Diagnostic:
        Call U_Msg_Local1.Affiche_Erreur("*** Erreur fonction Read_Json")
        btnReadJsonFile.BackColor = Color.Red
        Resume Next
        '------------         Fin traitement des erreurs                   -------------
    End Sub





    Private Sub BtnReadJsonFile_Click(sender As Object, e As EventArgs) Handles btnReadJsonFile.Click
        On Error GoTo Errhandler_Avec_Diagnostic
        Dim Store_S_Equivalent_Read As Store_Info_On_State_Machine

        Dim Directory_From_Memo_Browser As String = U_Memo_Directory_Browser1.UC1_Label_AutoEllipses_b1.Text
        '----------------------- Bouton set to yellow at the beginning of the function ----------------------
        Store_S_Equivalent_Read.Collect_of_States.Count = 3
        ReDim Store_S_Equivalent_Read.Collect_of_States.Table_Of_State_Info(4)
        Store_S_Equivalent_Read.Collect_of_States.Table_Of_State_Info(1).State_Name = "Etat n° 1"
        Store_S_Equivalent_Read.Collect_of_States.Table_Of_State_Info(2).State_Name = "Etat n° 2"
        Store_S_Equivalent_Read.Collect_of_States.Table_Of_State_Info(3).State_Name = "Etat n° 3"
        Store_S_Equivalent_Read.Collect_of_Events.Count = 2
        ReDim Store_S_Equivalent_Read.Collect_of_Events.Table_Of_Event_Info(20)
        Store_S_Equivalent_Read.Collect_of_Events.Table_Of_Event_Info(1).Event_Name = "Event n° 1"
        Store_S_Equivalent_Read.Collect_of_Events.Table_Of_Event_Info(2).Event_Name = "Event n° 2"

        btnReadJsonFile.BackColor = Color.Yellow

        '---------------------- Preparation of structure for reading in Json file ----------------------------

        Dim Object_To_Transmit As Object
        Object_To_Transmit = CType(Store_S_Equivalent_Read, System.Object)

        '---------------------- Read function call (Functional test) ---------------------------------------- 

        Call Read_Json(Object_To_Transmit, Directory_From_Memo_Browser)

        Exit Sub
        '-------------------------------------------------------------------------------
        '------------             Traitement des erreurs                      ----------
        '-------------------------------------------------------------------------------
Errhandler_Avec_Diagnostic:
        Call U_Msg_Local1.Affiche_Erreur("*** Erreur fonction btnReadJsonFile_Click")
        btnReadJsonFile.BackColor = Color.Red
        Resume Next
        '------------         Fin traitement des erreurs                   -------------

    End Sub





    Private Sub Btn_Compare_Read_Write_Click(sender As Object, e As EventArgs) Handles btn_Compare_Read_Write.Click
        'Dim Text_Written As String
        'Dim 
        '---------------------- TEST DE COMPARAISON WRITE READ -----------------------
        '---------------------- LA MÊME PROCEDURE QUE DANS WRITE ---------------------
        On Error GoTo Errhandler_Avec_Diagnostic


        Dim Store_S_Equivalent_Write As Store_Info_On_State_Machine
        Dim Converted_text As String
        Store_S_Equivalent_Write.Collect_of_States.Count = 3
        ReDim Store_S_Equivalent_Write.Collect_of_States.Table_Of_State_Info(4)
        Store_S_Equivalent_Write.Collect_of_States.Table_Of_State_Info(1).State_Name = "Etat n° 1"
        Store_S_Equivalent_Write.Collect_of_States.Table_Of_State_Info(2).State_Name = "Etat n° 2"
        Store_S_Equivalent_Write.Collect_of_States.Table_Of_State_Info(3).State_Name = "Etat n° 3"
        Store_S_Equivalent_Write.Collect_of_Events.Count = 2
        ReDim Store_S_Equivalent_Write.Collect_of_Events.Table_Of_Event_Info(20)
        Store_S_Equivalent_Write.Collect_of_Events.Table_Of_Event_Info(1).Event_Name = "Event n° 1"
        Store_S_Equivalent_Write.Collect_of_Events.Table_Of_Event_Info(2).Event_Name = "Event n° 2"
        Converted_text = Newtonsoft.Json.JsonConvert.SerializeObject(Store_S_Equivalent_Write, Newtonsoft.Json.Formatting.Indented)


        btnReadJsonFile.BackColor = Color.Yellow
        '=====================   Variables locales      ===============================
        Dim Text_read_Json As String
        Dim Store_S_Equivalent_Read As Store_Info_On_State_Machine
        Dim filetext As System.IO.StreamReader
        Dim Directory_From_Memo_Browser As String = U_Memo_Directory_Browser1.UC1_Label_AutoEllipses_b1.Text

        '=====================   Fin Variables locales  ===============================
        '-------------------------------------------------------------------------------
        '--------------- Création de l'objet Store_S_Equivalent_READ -------------------
        '-------------------------------------------------------------------------------

        Store_S_Equivalent_Read.Collect_of_States.Count = 3
        ReDim Store_S_Equivalent_Read.Collect_of_States.Table_Of_State_Info(4)
        Store_S_Equivalent_Read.Collect_of_Events.Count = 2
        ReDim Store_S_Equivalent_Read.Collect_of_Events.Table_Of_Event_Info(20)

        '------ Partie lécture et conversion en objet S_Equivalent             --------
        '------ On ouvre le file text on stocke le text dans Text_read_Json et --------
        '------                      on le désérialize                         --------

        '-------------------- On choisit cette fonction car 

        Text_read_Json = My.Computer.FileSystem.ReadAllText(Directory_From_Memo_Browser)
        Store_S_Equivalent_Read = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Store_Info_On_State_Machine)(Text_read_Json)

        '-------------------- Affichage du texte lu -----------------------------------

        RichTextBoxRead_Display.Text = Text_read_Json
        btnReadJsonFile.BackColor = Color.Green
        lblTestReadJson.Text = "Lecture done"



        If RichTextBoxConvertJasonStructure.Text = RichTextBoxRead_Display.Text Then
            U_Msg_Local1.Aff_Coul_RGB(Common_All_2013_a.U_Msg_Local.Type_Warning.Aff_INFO_GRAS, Color.RosyBrown, "Pareil")
        Else
            U_Msg_Local1.Aff_Coul_RGB(Common_All_2013_a.U_Msg_Local.Type_Warning.Aff_INFO_GRAS, Color.RosyBrown, "Pas équivalent")
        End If

#If Flag_Mode_Debug_Medium = "Yes" Then
        '---   Debug for Length of identification string      ----------------------------
        'U_Msg_Local1.Aff_Coul_RGB(U_Msg_Local.Type_Warning.Aff_INFO_GRAS, Color.RosyBrown, "Chaine lue dans le fichier = " & )
#End If

        Exit Sub
        '-------------------------------------------------------------------------------
        '------------             Traitement des erreurs                      ----------
        '-------------------------------------------------------------------------------
Errhandler_Avec_Diagnostic:
        Call U_Msg_Local1.Affiche_Erreur("*** Erreur fonction Read_Json")
        btnReadJsonFile.BackColor = Color.Red
        Resume Next
        '------------         Fin traitement des erreurs                   -------------
    End Sub

    Private Sub U5_JSON_Read_Write_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Table_Text_String As String()
        ReDim Table_Text_String(5)
        Table_Text_String(1) = "Première_Chaine"
        Table_Text_String(2) = "Chaine 2"
        Table_Text_String(3) = "Chaine 3"
        RichTextBox_Structure.Lines = Table_Text_String
    End Sub
End Class
