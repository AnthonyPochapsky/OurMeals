Imports System.Windows.Forms.ImageList

Public Class EnterShoppingListNameForm
    Private listToPopulate As GroceryListMenu
    Private groceryLists As Dictionary(Of Button, GroceryListMenu)
    Public Sub New(LTP As GroceryListMenu, GLs As Dictionary(Of Button, GroceryListMenu))

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        listToPopulate = LTP
        groceryLists = GLs
    End Sub
    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        Dim enteredListName = NameTextBox.Text
        For Each kvp As KeyValuePair(Of Button, GroceryListMenu) In groceryLists
            If (kvp.Key.Text = enteredListName And kvp.Value Is listToPopulate) Then
                MsgBox("Cannot populate current list with itself")
                Exit Sub
            ElseIf (kvp.Key.Text = enteredListName) Then
                Dim ItemBoxesToAdd = kvp.Value.getListOfItemBoxes()
                For Each ItemBox As RichTextBox In ItemBoxesToAdd
                    Dim ItemBoxCopy = New RichTextBox
                    ItemBoxCopy.Size = ItemBox.Size
                    ItemBoxCopy.Location = ItemBox.Location
                    ItemBoxCopy.ReadOnly = False
                    ItemBoxCopy.Enabled = True
                    ItemBoxCopy.Text = ItemBox.Text
                    listToPopulate.ModifyListWithExternalItems(ItemBoxCopy, True)
                Next
                Me.Close()
                Exit Sub
            End If
        Next
        MsgBox("No list exists with that name")
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
End Class