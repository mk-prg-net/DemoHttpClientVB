Public Class cbxCBTypeItem


    Public Sub New(cbType As CBRepository_FilteredSortedSetBuilder.CBType)
        Me._CBType = cbType
    End Sub

    Public ReadOnly Property CBTypeName As String
        Get
            Return CBType.ToString()
        End Get
    End Property

    Public ReadOnly Property CBType As CBRepository_FilteredSortedSetBuilder.CBType
        Get
            Return _CBType
        End Get
    End Property

    Dim _CBType As CBRepository_FilteredSortedSetBuilder.CBType

End Class
