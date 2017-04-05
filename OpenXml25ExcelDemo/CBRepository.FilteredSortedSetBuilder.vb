Public Class CBRepository_FilteredSortedSetBuilder
    Implements mko.BI.Repositories.Interfaces.IFilteredSortedSetBuilder(Of ICB)


    Dim cbList As IQueryable(Of ICB)
    Dim defSortOrders As New List(Of mko.BI.Repositories.DefSortOrder(Of ICB))

    Public Sub New(cbList As IEnumerable(Of ICB))
        Me.cbList = cbList.AsQueryable
    End Sub

    Public Enum CBType
        All
        Star
        Planet
        Moon
        Asteroid
    End Enum

    Dim restrictToCbType As String = Nothing
    Public WriteOnly Property DefCBType As CBType
        Set(value As CBType)
            If value <> CBType.All Then
                restrictToCbType = value.ToString()
            Else
                restrictToCbType = Nothing
            End If

        End Set
    End Property

    Public WriteOnly Property DefMassRangeInEarthmasses As mko.BI.Bo.Interval(Of Double)
        Set(value As mko.BI.Bo.Interval(Of Double))
            cbList = cbList.Where(Function(cb) cb.MassInEarthmasses >= value.Begin And cb.MassInEarthmasses <= value.End)
        End Set
    End Property


    Dim OrbitOrderAsc As New mko.BI.Repositories.DefSortOrderCol(Of ICB, Double)(Function(cb) CB.OrbitRadiusInAu, False)
    Dim OrbitOrderDesc As New mko.BI.Repositories.DefSortOrderCol(Of ICB, Double)(Function(cb) CB.OrbitRadiusInAu, True)

    Public WriteOnly Property DefOrbitOrderAsc As Boolean
        Set(value As Boolean)
            If value Then
                If Not defSortOrders.Contains(OrbitOrderAsc) Then
                    defSortOrders.Add(OrbitOrderAsc)
                End If

                If defSortOrders.Contains(OrbitOrderDesc) Then
                    defSortOrders.Remove(OrbitOrderDesc)
                End If
            Else
                If defSortOrders.Contains(OrbitOrderAsc) Then
                    defSortOrders.Remove(OrbitOrderAsc)
                End If
            End If
            
        End Set
    End Property

        
    Public WriteOnly Property DefOrbitOrderDesc As Boolean
        Set(value As Boolean)
            If value Then
                If Not defSortOrders.Contains(OrbitOrderDesc) Then
                    defSortOrders.Add(OrbitOrderDesc)
                End If

                If defSortOrders.Contains(OrbitOrderAsc) Then
                    defSortOrders.Remove(OrbitOrderAsc)
                End If
            Else
                If defSortOrders.Contains(OrbitOrderDesc) Then
                    defSortOrders.Remove(OrbitOrderDesc)
                End If
            End If
        End Set
    End Property



    Public Function GetSet() As mko.BI.Repositories.Interfaces.IFilteredSortedSet(Of ICB) Implements mko.BI.Repositories.Interfaces.IFilteredSortedSetBuilder(Of ICB).GetSet

        If Not restrictToCbType Is Nothing Then
            cbList = cbList.Where(Function(cb) cb.CBType = restrictToCbType)
        End If

        If Not defSortOrders.Any() Then
            defSortOrders.Add(OrbitOrderAsc)
        End If

        Return New mko.BI.Repositories.FilteredSortedSet(Of ICB)(cbList, defSortOrders)

    End Function
End Class
