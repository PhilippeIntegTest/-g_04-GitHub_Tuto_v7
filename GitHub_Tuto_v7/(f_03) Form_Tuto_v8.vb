Public Class Form_Tuto_v7

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
    Public Global_Store_S_Equivalent As Store_Info_On_State_Machine
    Dim Global_Store_S_Equivalent_Restore As Store_Info_On_State_Machine






    Private Sub Form_Tuto_v7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '--------------------------------------------------------------------------------
        '----  Première init Structure globale                                     ------
        '----                                                                      ------
        '---- Note1: cette structure est utilisée dans le UserControl:             ------
        '----        U5_Share_Global_Structure_Test.vb                             ------
        '--------------------------------------------------------------------------------
        ReDim Global_Store_S_Equivalent.Collect_of_States.Table_Of_State_Info(5)

        Global_Store_S_Equivalent.Collect_of_States.Table_Of_State_Info(1).State_Name = "Premier_Test"









    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
