Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class KeperDBReaderTests

    <TestMethod()> _
    <DeploymentItem(".\KeplerBI-CBs.xlsx")> _
    Public Sub OpenXml25_KeplerDB_Reader()

        Dim reader As New KeplerBIReader()
        Dim cbBuilder As New CBBuilder

        Dim res = reader.ReadAll(cbBuilder)

        Assert.AreEqual(1557, res.Count)

    End Sub


    <TestMethod()> _
    <DeploymentItem(".\KeplerBI-CBs.xlsx")> _
    Public Sub OpenXml25_CBRepository()

        Dim reader As New KeplerBIReader()
        Dim cbBuilder As New CBBuilder

        Dim res = reader.ReadAll(cbBuilder)

        Assert.AreEqual(1557, res.Count)

        Dim repo As New CBRepository(res)

        Dim fltBld = repo.GetFilteredSortedSetBuilder()
        Dim All = fltBld.GetSet()
        Assert.AreEqual(1557L, All.Count)


        fltBld.DefCBType = CBRepository_FilteredSortedSetBuilder.CBType.Planet
        Dim Planets = fltBld.GetSet()
        Dim PlanetsList = Planets.Get().ToArray()
        Assert.AreEqual(8L, Planets.Count)




    End Sub



End Class