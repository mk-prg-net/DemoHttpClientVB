Imports DocumentFormat.OpenXml
Imports DocumentFormat.OpenXml.Packaging
Imports DocumentFormat.OpenXml.Spreadsheet


''' <summary>
''' Strings werden nicht direkt im Markup der Tabelle, sondern in einer separaten Struktur gehalten,
''' der SharedStringTable. In dieser ist jedem String eine Nummer (ID) zugeordnet.  Die Nummer 
''' wird in den Tabellen anstelle des Strings gespeichert.
''' </summary>
''' <remarks></remarks>
Public Class SharedStringTabWrapper

    Dim TabPart As SharedStringTablePart

    Public Sub New(StringTabPart As SharedStringTablePart)
        TabPart = StringTabPart
    End Sub

    Public Function GetString(id As Integer) As String
        Dim item = TabPart.SharedStringTable.Elements(Of SharedStringItem).ElementAt(id)
        Return item.Text.Text
    End Function

End Class
