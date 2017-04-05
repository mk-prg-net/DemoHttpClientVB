Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class MVP

    Dim CBList As IEnumerable(Of ICB)


    ''' <summary>
    ''' Diese Methode wird vor jedem Test ausgeführt
    ''' </summary>
    ''' <remarks></remarks>
    <TestInitialize()> _
    Public Sub TestInit()

        ' Laden der CBListe aus der Excel- Datei
        Dim reader As New KeplerBIReader()
        CBList = reader.ReadAll(New CBBuilder())

    End Sub

    ''' <summary>
    ''' Diese MEthode wird nach jedem Test ausgeführt
    ''' </summary>
    ''' <remarks></remarks>
    <TestCleanup()> _
    Public Sub Cleanup()
        CBList = Nothing
    End Sub


    Class ViewMockUp
        Implements IView

        Public Property CBList As IEnumerable(Of ICB) Implements IView.CBList

        Public Property CBType As CBRepository_FilteredSortedSetBuilder.CBType Implements IView.CBType

        Public Property Count As Long Implements IView.Count

        Public Property HasOrbitDiaInAURngFlt As Boolean Implements IView.HasOrbitDiaInAURngFlt

        Public Property OrbitDiaInAURngFlt As mko.BI.Bo.Interval(Of Double) Implements IView.OrbitDiaInAURngFlt
    End Class

    <TestMethod()> _
    Public Sub KeplerBI_MVP()

        Dim repository As New CBRepository(CBList)
        Dim view As New ViewMockUp()

        Dim presenter As New Presenter(repository, view)

        ' Aktionen auf der Benutzeroberfläche simuliert
        ' Initialisieren der Oberfläche
        presenter.Requery()

        ' Wenn Requery erfolgreich war
        Assert.AreEqual(view.CBList.Count(), CBList.Count, "Die Oberfläche sollte die gleiche Anzahl an Datensätzen darstellen, wie die liefernde Quelle besitzt")
        Assert.AreEqual(view.Count, CType(CBList.Count(), Long), "Die in der Oberfläche angezeite Anzahl an Datensätzen sollte gleich der Datensätze in der Quelle sein")

        view.CBType = CBRepository_FilteredSortedSetBuilder.CBType.Planet
        presenter.Requery()

        Assert.AreEqual(8, view.CBList.Count(), "Die Oberfläche sollte die gleiche Anzahl an Datensätzen darstellen, wie die liefernde Quelle besitzt")
        Assert.AreEqual(8L, view.Count, "Die in der Oberfläche angezeite Anzahl an Datensätzen sollte gleich der Datensätze in der Quelle sein")

        ' Einschränken auf Himmelskörper, die zwischen 1 und 6 Astronomischen Einheiten um die Sonne kreisen
        view.OrbitDiaInAURngFlt = New mko.BI.Bo.Interval(Of Double)(1.0, 6.0)
        view.HasOrbitDiaInAURngFlt = True
        presenter.Requery()

        'Assert.AreEqual(3, view.CBList.Count(), "Die Oberfläche sollte die gleiche Anzahl an Datensätzen darstellen, wie die liefernde Quelle besitzt")
        'Assert.AreEqual(3L, view.Count, "Die in der Oberfläche angezeite Anzahl an Datensätzen sollte gleich der Datensätze in der Quelle sein")

    End Sub

End Class