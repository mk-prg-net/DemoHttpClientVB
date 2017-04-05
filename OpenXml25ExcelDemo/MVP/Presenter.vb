''' <summary>
''' MVP- Pattern
''' Presenter, der 
''' </summary>
''' <remarks></remarks>
Public Class Presenter

    Dim view As IView
    Dim model As CBRepository
    Dim fltBld As CBRepository_FilteredSortedSetBuilder


    Public Sub New(Model As CBRepository, View As IView)
        Me.view = View
        Me.model = Model
        fltBld = Model.GetFilteredSortedSetBuilder()
    End Sub

    Public Sub Requery()

        ' Neuen Builder für gefilterte Mengen erstellen
        fltBld = model.GetFilteredSortedSetBuilder()

        ' Soll auf einen bestimmten Himmelskörpertyp eingeschränkt werden
        fltBld.DefCBType = view.CBType

        ' Sin die Himmelskörper auf jene einzuschränken, deren Orbits in einem definierten Bereich liegen ?
        If view.HasOrbitDiaInAURngFlt Then
            fltBld.DefMassRangeInEarthmasses = view.OrbitDiaInAURngFlt
        End If

        Dim res = fltBld.GetSet()

        view.CBList = res.Get()
        view.Count = res.Count()

    End Sub

    Sub OrderByOrbitAsc()
        fltBld.DefOrbitOrderAsc = True

        Dim res = fltBld.GetSet()
        view.CBList = res.Get()
        view.Count = res.Count()

    End Sub

    Sub OrderByOrbitDesc()
        fltBld.DefOrbitOrderDesc = True

        Dim res = fltBld.GetSet()
        view.CBList = res.Get()
        view.Count = res.Count()

    End Sub




End Class
