Public Class Form1
    Implements IView

    Dim log As New mko.Log.LogServer
    Dim lbxLogHnd As mko.Log.WinFormListBoxLogHnd

    Dim cbRepo As CBRepository
    Dim presenter As OpenXml25ExcelDemo.Presenter

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbxLogHnd = New mko.Log.WinFormListBoxLogHnd(lbxLog)
        log.registerLogHnd(lbxLogHnd)

        log.Log(mko.Log.RC.CreateStatus("Programm gestartet"))

        CbxCBTypeItemBindingSource.DataSource = New cbxCBTypeItem() { _
                                New cbxCBTypeItem(CBRepository_FilteredSortedSetBuilder.CBType.All), _
                                New cbxCBTypeItem(CBRepository_FilteredSortedSetBuilder.CBType.Asteroid), _
                                New cbxCBTypeItem(CBRepository_FilteredSortedSetBuilder.CBType.Moon), _
                                New cbxCBTypeItem(CBRepository_FilteredSortedSetBuilder.CBType.Planet), _
                                New cbxCBTypeItem(CBRepository_FilteredSortedSetBuilder.CBType.Star)}


        cbRepo = New CBRepository(New List(Of CB))
        presenter = New Presenter(cbRepo, Me)


        AddHandler AustauschWebApiGui.NeuEvent, Sub(info As String) log.Log(mko.Log.RC.CreateMsg("Neue Meldung von Remote Client (WebAPI): " & info))

    End Sub

    Private Sub btnOrderCBsAsc_Click(sender As Object, e As EventArgs) Handles btnOrderCBsAsc.Click
        presenter.OrderByOrbitAsc()
    End Sub

    Public Property CBList As IEnumerable(Of ICB) Implements IView.CBList
        Get
            Return CBListBindingSource.DataSource
        End Get
        Set(value As IEnumerable(Of ICB))

            CBListBindingSource.DataSource = value
            CBListBindingSource.ResetBindings(False)
        End Set
    End Property

    Public Property CBType As CBRepository_FilteredSortedSetBuilder.CBType Implements IView.CBType
        Get
            Return CType(cbxCBTyp.SelectedItem, cbxCBTypeItem).CBType
        End Get
        Set(value As CBRepository_FilteredSortedSetBuilder.CBType)

        End Set
    End Property

    Public Property Count As Long Implements IView.Count
        Set(value As Long)
            tbxCount.Text = value.ToString()
        End Set
        Get
            Return 0
        End Get
    End Property

    Public Property HasOrbitDiaInAURngFlt As Boolean Implements IView.HasOrbitDiaInAURngFlt

    Public Property OrbitDiaInAURngFlt As mko.BI.Bo.Interval(Of Double) Implements IView.OrbitDiaInAURngFlt

    Private Sub ÖffnenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÖffnenToolStripMenuItem.Click
        If OpenExcelFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim FileName = OpenExcelFileDialog.FileName
            lblFileName.Text = FileName
            Dim reader = New KeplerBIReader()
            Dim cbList = reader.ReadAll(New CBBuilder(), FileName)

            cbRepo = New CBRepository(cbList)
            presenter = New Presenter(cbRepo, Me)
            presenter.Requery()

        End If
    End Sub

    Private Sub btnOrderCBsDesc_Click(sender As Object, e As EventArgs) Handles btnOrderCBsDesc.Click
        presenter.OrderByOrbitDesc()
    End Sub

    Private Sub btnRequery_Click(sender As Object, e As EventArgs) Handles btnRequery.Click
        presenter.Requery()
    End Sub

    Private Sub btnLeseVonAustausch_Click(sender As Object, e As EventArgs) Handles btnLeseVonAustausch.Click
        log.Log(mko.Log.RC.CreateMsg("Letzte Meldung vom WebAPI- Klient: " & AustauschWebApiGui.Info))
    End Sub
End Class
