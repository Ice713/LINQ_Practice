Public Class Form1
    Private Sub buttonClick_Click(sender As Object, e As EventArgs) Handles buttonClick.Click
        Dim names As List(Of String) = New List(Of String) From {"Crystal", "Jamaica", "Carmelo", "Angelo", "Tin", "Jo"}

        Dim upperNames = names.Select(Function(n) n.ToUpper())

        Dim outputMessage As String = ""

        For Each namee In upperNames
            outputMessage += namee & " "
        Next

        labelOutput.Text = outputMessage
    End Sub
End Class

