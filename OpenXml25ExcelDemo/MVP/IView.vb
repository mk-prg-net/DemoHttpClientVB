''' <summary>
''' Sicht aus einem MVP- Muster, das zur Impelemntierung eines graphischen Clients über
''' einem CBRepository dient
''' </summary>
''' <remarks></remarks>
Public Interface IView

    ''' <summary>
    ''' Filtern nach Himmelskörpertyp: Einstellung aus Gui lesen oder setzen
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property CBType As CBRepository_FilteredSortedSetBuilder.CBType

    ''' <summary>
    ''' Filtern nach Himmelskörpern, deren Orbit innerhalb eines Bereiches liegt: Einstellung aus Gui lesen oder setzen
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property OrbitDiaInAURngFlt As mko.BI.Bo.Interval(Of Double)

    Property HasOrbitDiaInAURngFlt As Boolean

    ''' <summary>
    ''' Liste der Himmelskörper, die den aktuellen Filtereinstellungen genügen
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property CBList As IEnumerable(Of ICB)

    ''' <summary>
    ''' Aktuelle Anzahl der Datensätze
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property Count As Long


End Interface
