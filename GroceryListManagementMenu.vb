Imports System.Runtime.CompilerServices

Public Class GroceryListManagementMenu
    Private OldX As Integer
    Private OldY As Integer
    Private NewX As Integer
    Private NewY As Integer
    Private newListButton As Button
    Private groceryLists As New Dictionary(Of Button, GroceryListMenu)
    Private ButtonList As New List(Of Button)
    Private Removing As Boolean = False
    Private MakingRoutine As Boolean = False
    Private MakingRoutineOnCreation As Boolean = False
    Private Editing As Boolean = False
    Private ItineraryItemsMenu As ItineraryContentsMenu
    Private SplittingItinerary As Boolean = False
    Private ConvertingItinerary As Boolean = False
    Public Sub CreateNewList(sender As Object, e As EventArgs) Handles createNewListButton.Click
        If (Not SplittingItinerary And Not ConvertingItinerary) Then
            newListButton = New Button
            Dim ListItems = New GroceryListMenu
            Dim SetNameBox = New setNameForm(newListButton, ListItems)
            SetNameBox.ShowDialog()
        ElseIf (ConvertingItinerary) Then
            OldX = createNewListButton.Location.X
            OldY = createNewListButton.Location.Y
            NewX = createNewListButton.Location.X
            NewY = createNewListButton.Location.Y

            If OldX < 200 Then
                NewX += 120
            Else
                NewX = 35
                NewY += 90
            End If

            Dim ListItems = New GroceryListMenu
            Dim itemBoxes As List(Of RichTextBox) = ItineraryItemsMenu.getItemBoxes()
            For Each itemBox As RichTextBox In itemBoxes
                ListItems.ModifyListWithExternalItems(itemBox, False)
            Next
            newListButton = New Button
            newListButton.BackColor = Color.White

            newListButton.Size = New Size(117, 86)

            createNewListButton.Location = New Point(NewX, NewY)
            newListButton.Location = New Point(OldX, OldY)


            newListButton.Visible = True

            Dim convertedList As New SetSplitListName(newListButton, ListItems)
            convertedList.Text = "FarmBoy and WholeFoods Shopping List Specifications"
            convertedList.ShowDialog()

            groceryLists.Add(newListButton, ListItems)
            ButtonList.Add(newListButton)

            OldX = NewX
            OldY = NewY

            AddHandler newListButton.Click, AddressOf GroceryListButton_Click

            Me.ItineraryButton.Visible = False

            Me.Controls.Add(newListButton)
            OurMealsMainForm.Controls.Add(ListItems)
            ConvertingItinerary = False
        ElseIf (SplittingItinerary) Then
            Dim NumberOfListsToCreate As Integer = ItineraryItemsMenu.getItemBoxes().Count()
            Dim itemBoxes As List(Of RichTextBox) = ItineraryItemsMenu.getItemBoxes()
            For i = 0 To NumberOfListsToCreate - 1
                OldX = createNewListButton.Location.X
                OldY = createNewListButton.Location.Y
                NewX = createNewListButton.Location.X
                NewY = createNewListButton.Location.Y

                If OldX < 200 Then
                    NewX += 120
                Else
                    NewX = 35
                    NewY += 90
                End If

                Dim ListItems = New GroceryListMenu
                ListItems.ModifyListWithExternalItems(itemBoxes(i), False)

                newListButton = New Button
                newListButton.BackColor = Color.White

                newListButton.Size = New Size(117, 86)

                createNewListButton.Location = New Point(NewX, NewY)
                newListButton.Location = New Point(OldX, OldY)


                newListButton.Visible = True

                Dim SplitListForm As New SetSplitListName(newListButton, ListItems)
                If (itemBoxes(i).Name = "AppleItemBox") Then
                    SplitListForm.Text = "WholeFoods Shopping List Specifications"
                ElseIf (itemBoxes(i).Name = "TomatoItemBox") Then
                    SplitListForm.Text = "FarmBoy Shopping List Specifications"
                End If
                SplitListForm.ShowDialog()

                groceryLists.Add(newListButton, ListItems)
                ButtonList.Add(newListButton)

                OldX = NewX
                OldY = NewY

                AddHandler newListButton.Click, AddressOf GroceryListButton_Click

                Me.ItineraryButton.Visible = False

                Me.Controls.Add(newListButton)
                OurMealsMainForm.Controls.Add(ListItems)

            Next
            SplittingItinerary = False
        End If
    End Sub

    Public Sub CreateOrdinaryList(ListItems As GroceryListMenu)

        OldX = createNewListButton.Location.X
        OldY = createNewListButton.Location.Y
        NewX = createNewListButton.Location.X
        NewY = createNewListButton.Location.Y

        If OldX < 200 Then
            NewX += 120
        Else
            Debug.Print(OldX)
            NewX = 35
            NewY += 90
        End If


        newListButton.BackColor = Color.White

        newListButton.Size = New Size(117, 86)

        createNewListButton.Location = New Point(NewX, NewY)
        newListButton.Location = New Point(OldX, OldY)


        newListButton.Visible = True

        Controls.Add(newListButton)
        OurMealsMainForm.Controls.Add(ListItems)

        groceryLists.Add(newListButton, ListItems)
        ButtonList.Add(newListButton)

        OldX = NewX
        OldY = NewY

        AddHandler newListButton.Click, AddressOf GroceryListButton_Click
    End Sub
    Public Sub CreateRecipeList(recipeListButton As Button, servings As Integer)
        For i = 0 To servings - 1
            Dim recipeListItemsMenu As GroceryListMenu = groceryLists(recipeListButton)
            Dim ListItem1 = New RichTextBox
            ListItem1.Size = New Point(222, 60)
            ListItem1.Location = New Point(27, 102)
            ListItem1.ReadOnly = True
            ListItem1.Enabled = True
            ListItem1.Text = "Apple"
            ListItem1.BackColor = Color.White
            recipeListItemsMenu.ModifyListWithExternalItems(ListItem1, False)

            Dim ListItem2 = New RichTextBox
            ListItem2.Size = New Point(222, 60)
            ListItem2.Location = New Point(27, 204)
            ListItem2.ReadOnly = True
            ListItem2.Enabled = True
            ListItem2.Text = "Apple"
            ListItem2.BackColor = Color.White
            recipeListItemsMenu.ModifyListWithExternalItems(ListItem2, False)

            Dim ListItem3 = New RichTextBox
            ListItem3.Size = New Point(222, 60)
            ListItem3.Location = New Point(290, 102)
            ListItem3.ReadOnly = True
            ListItem3.Enabled = True
            ListItem3.Text = "Tomato"
            ListItem3.BackColor = Color.White
            recipeListItemsMenu.ModifyListWithExternalItems(ListItem3, False)


            Dim ListItem4 = New RichTextBox
            ListItem4.Size = New Point(222, 60)
            ListItem4.Location = New Point(290, 204)
            ListItem4.ReadOnly = True
            ListItem4.Enabled = True
            ListItem4.Text = "Tomato"
            ListItem4.BackColor = Color.White
            recipeListItemsMenu.ModifyListWithExternalItems(ListItem4, False)
        Next
    End Sub
    Public Sub AddIngredientsToExistingList(recipeListButton As Button, servings As Integer)
        For i = 0 To servings - 1
            Dim recipeListItemsMenu As GroceryListMenu = groceryLists(recipeListButton)
            Dim ListItem1 = New RichTextBox
            ListItem1.Size = New Point(222, 60)
            ListItem1.Location = New Point(27, 102)
            ListItem1.ReadOnly = False
            ListItem1.Enabled = True
            ListItem1.Text = "Apple"
            recipeListItemsMenu.ModifyListWithExternalItems(ListItem1, False)

            Dim ListItem2 = New RichTextBox
            ListItem2.Size = New Point(222, 60)
            ListItem2.Location = New Point(27, 204)
            ListItem2.ReadOnly = False
            ListItem2.Enabled = True
            ListItem2.Text = "Apple"
            recipeListItemsMenu.ModifyListWithExternalItems(ListItem2, False)

            Dim ListItem3 = New RichTextBox
            ListItem3.Size = New Point(222, 60)
            ListItem3.Location = New Point(290, 102)
            ListItem3.ReadOnly = False
            ListItem3.Enabled = True
            ListItem3.Text = "Tomato"
            recipeListItemsMenu.ModifyListWithExternalItems(ListItem3, False)


            Dim ListItem4 = New RichTextBox
            ListItem4.Size = New Point(222, 60)
            ListItem4.Location = New Point(290, 204)
            ListItem4.ReadOnly = False
            ListItem4.Enabled = True
            ListItem4.Text = "Tomato"
            recipeListItemsMenu.ModifyListWithExternalItems(ListItem4, False)
        Next
    End Sub
    Public Function getGroceryLists()
        Return groceryLists
    End Function
    Public Sub setSplittingItinerary(T As Boolean)
        SplittingItinerary = T
    End Sub

    Public Sub setConvertingItinerary(T As Boolean)
        ConvertingItinerary = T
    End Sub
    Public Sub setMakingRoutine(T As Boolean)
        MakingRoutine = T
    End Sub
    Public Sub setMakingRoutineOnCreation(T As Boolean)
        MakingRoutineOnCreation = T
    End Sub
    Public Sub GroceryListButton_Click(sender As Object, e As EventArgs)
        If (Removing) Then
            Dim ConfirmDeletionForm = New ConfirmDeletionForm(sender)
            ConfirmDeletionForm.ShowDialog()
        ElseIf (MakingRoutineOnCreation) Then
            MakeRoutine(sender)
            MakingRoutineOnCreation = False
        ElseIf (MakingRoutine) Then
            Dim ConfirmRoutineForm = New ConfirmRoutineForm(sender)
            ConfirmRoutineForm.ShowDialog()
        ElseIf (Editing) Then
            Dim EditListForm = New EditListForm(sender, groceryLists(sender))
            EditListForm.Text = "Edits For " + sender.Text
            EditListForm.ShowDialog()
        Else
            Dim clickedButton As Button = sender
            Dim currentGroceryListMenu As GroceryListMenu = groceryLists(clickedButton)
            Me.Visible = False
            currentGroceryListMenu.Visible = True
        End If

    End Sub

    Public Sub DeleteList(buttonClicked As Button)
        Dim Found = False
        Dim ButtonsToOffset As New List(Of Button)
        MyBase.Controls.Remove(buttonClicked)
        OurMealsMainForm.GroceryListManagementMenu.Controls.Remove(groceryLists(buttonClicked))
        groceryLists.Remove(buttonClicked)

        'Ordered List traversal to add buttons that were created after the removed one to the offset list containing buttons to offset
        'Must be traversed backwards due to element removal occuring during traversal of list
        For i = ButtonList.Count - 1 To 0 Step -1
            If Not ButtonList(i) Is buttonClicked Then
                ButtonsToOffset.Add(ButtonList(i))
            Else
                ButtonList.Remove(ButtonList(i))
                Exit For
            End If
        Next

        For Each ButtonToOffset In ButtonsToOffset
            Dim x = ButtonToOffset.Location.X
            Dim y = ButtonToOffset.Location.Y
            If x = 35 Then
                ButtonToOffset.Location = New Point(275, y - 90)
            Else
                ButtonToOffset.Location = New Point(x - 120, y)
            End If
        Next

        If createNewListButton.Location.X = 35 Then
            createNewListButton.Location = New Point(275, createNewListButton.Location.Y - 90)
        Else
            createNewListButton.Location = New Point(createNewListButton.Location.X - 120, createNewListButton.Location.Y)
        End If
        OurMealsMainForm.notificationMsg.ForeColor = Color.Red
        OurMealsMainForm.notificationMsg.Text = buttonClicked.Text + " has been deleted"
    End Sub
    Public Sub MakeRoutine(buttonClicked As Button)
        Dim FirstButton As Button
        For Each listButtonAndPanel In groceryLists
            If listButtonAndPanel.Key.Location.X = 35 And listButtonAndPanel.Key.Location.Y = 168 Then
                FirstButton = listButtonAndPanel.Key
                Exit For
            End If
        Next
        FirstButton.Location = New Point(buttonClicked.Location.X, buttonClicked.Location.Y)
        FirstButton.BackColor = Color.White
        buttonClicked.Location = New Point(35, 168)
        buttonClicked.BackColor = Color.FromArgb(144, 213, 255)

        For i = 0 To ButtonList.Count
            If ButtonList(i) Is buttonClicked Then
                ButtonList(i) = FirstButton
                ButtonList(0) = buttonClicked
                Exit For
            End If
        Next
        OurMealsMainForm.notificationMsg.ForeColor = Color.Green
        OurMealsMainForm.notificationMsg.Text = buttonClicked.Text + " has been made into routine"
    End Sub
    Private Sub BackToMainMenuButton_Click(sender As Object, e As EventArgs) Handles BackToMainMenuButton.Click
        Removing = False
        MakingRoutine = False
        Editing = False
        EnableDeletionButton.Enabled = True
        MakeRoutineButton.Enabled = True
        EnableEditButton.Enabled = True
        DisableRemovalButton.Enabled = False
        DisableMakingRoutine.Enabled = False
        DisableEditButton.Enabled = False

        OurMealsMainForm.GroceryListManagementMenu.Visible = False
        OurMealsMainForm.NotificationBar.Visible = False
        OurMealsMainForm.notificationMsg.Text = ""
        OurMealsMainForm.MainMenu.Visible = True
    End Sub

    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles EnableDeletionButton.Click
        Removing = True
        EnableDeletionButton.Enabled = False
        MakeRoutineButton.Enabled = False
        EnableEditButton.Enabled = False
        DisableRemovalButton.Enabled = True
    End Sub

    Private Sub MakeRoutineButton_Click(sender As Object, e As EventArgs) Handles MakeRoutineButton.Click
        MakingRoutine = True
        MakeRoutineButton.Enabled = False
        EnableDeletionButton.Enabled = False
        EnableEditButton.Enabled = False
        DisableMakingRoutine.Enabled = True
    End Sub
    Private Sub EnableEditButton_Click(sender As Object, e As EventArgs) Handles EnableEditButton.Click
        Editing = True
        EnableEditButton.Enabled = False
        EnableDeletionButton.Enabled = False
        MakeRoutineButton.Enabled = False
        DisableEditButton.Enabled = True
    End Sub

    Private Sub DisableRemovalButton_Click(sender As Object, e As EventArgs) Handles DisableRemovalButton.Click
        Removing = False
        EnableDeletionButton.Enabled = True
        MakeRoutineButton.Enabled = True
        EnableEditButton.Enabled = True
        DisableRemovalButton.Enabled = False
    End Sub

    Private Sub DisableMakingRoutine_Click(sender As Object, e As EventArgs) Handles DisableMakingRoutine.Click
        MakingRoutine = False
        MakeRoutineButton.Enabled = True
        EnableDeletionButton.Enabled = True
        EnableEditButton.Enabled = True
        DisableMakingRoutine.Enabled = False
    End Sub
    Private Sub DisableEditButton_Click(sender As Object, e As EventArgs) Handles DisableEditButton.Click
        Editing = False
        DisableEditButton.Enabled = False
        EnableEditButton.Enabled = True
        EnableDeletionButton.Enabled = True
        MakeRoutineButton.Enabled = True
    End Sub

    Private Sub ItineraryButton_Click(sender As Object, e As EventArgs) Handles ItineraryButton.Click
        ItineraryItemsMenu = New ItineraryContentsMenu
        ItineraryItemsMenu.ItineraryNameLabel.Text = sender.Text
        OurMealsMainForm.Controls.Add(ItineraryItemsMenu)
        Me.Visible = False
        ItineraryItemsMenu.Visible = True
    End Sub

End Class
