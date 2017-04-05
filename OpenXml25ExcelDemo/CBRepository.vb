Public Class CBRepository
    Implements mko.BI.Repositories.Interfaces.IGet(Of ICB, String)

    Dim cbList As IEnumerable(Of ICB)

    Public Sub New(cbList As IEnumerable(Of ICB))
        Me.cbList = cbList
    End Sub

    Public Function ExistsBo(id As String) As Boolean Implements mko.BI.Repositories.Interfaces.IGet(Of ICB, String).ExistsBo
        Return cbList.Any(Function(cb) cb.Name = id)
    End Function

    Public Function GetBo(id As String) As ICB Implements mko.BI.Repositories.Interfaces.IGet(Of ICB, String).GetBo
        Return cbList.First(Function(cb) cb.Name = id)
    End Function


    Public Function GetFilteredSortedSetBuilder() As CBRepository_FilteredSortedSetBuilder
        Return New CBRepository_FilteredSortedSetBuilder(cbList)
    End Function

End Class
