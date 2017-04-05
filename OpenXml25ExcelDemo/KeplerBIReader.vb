Imports System.Linq
Imports DocumentFormat.OpenXml
Imports DocumentFormat.OpenXml.Packaging
Imports DocumentFormat.OpenXml.Spreadsheet
''' <summary>
''' Einlesen von astronomischen Daten aus der KeplerBI-CBs.xslx- Excel- Datei
''' </summary>
''' <remarks></remarks>
Public Class KeplerBIReader

    Public Function ReadAll(cbBuilder As ICBBuilder, Optional FileName As String = "KeplerBI-CBs.xlsx") As IEnumerable(Of ICB)

        Dim ciBackup = System.Threading.Thread.CurrentThread.CurrentCulture
        Dim ci = New System.Globalization.CultureInfo("en-US")
        System.Threading.Thread.CurrentThread.CurrentCulture = ci

        Try
            Dim Result As New List(Of ICB)

            Using document = SpreadsheetDocument.Open(FileName, False)

                Dim sheets = document.WorkbookPart.Workbook.Descendants(Of Sheet).First(Function(s) s.Name = "KeplerBI-CBs") '.First()

                If sheets.Count > 0 Then
                    Return Result
                End If


                Dim worksheetPart = CType(document.WorkbookPart.GetPartById(sheets.Id), WorksheetPart)
                Dim worksheet = worksheetPart.Worksheet

                Dim stringTabPart As SharedStringTablePart = document.WorkbookPart.SharedStringTablePart

                ' Diese Klasse habe ich selbst definiert, um die Arbeit mit der SharedString... zu vereinfachen
                Dim StringTab As New SharedStringTabWrapper(stringTabPart)

                Dim _1stRow As Boolean = True

                For Each Row In worksheet.Descendants(Of Row)()

                    Dim _1stCell As Cell = Row.First()

                    If String.IsNullOrWhiteSpace(_1stCell.CellValue.InnerText) Then
                        Return Result
                    End If

                    If _1stRow Then
                        _1stRow = False
                        Continue For
                    End If

                    ' Einlesen der nachfolgenden Zeilen

                    Dim Id = GetCellValueInt(Row, 0)

                    ' Achtung: Anstelle Strings werden Ressourcennummern in der Tabelle gepspeichert,
                    '          die auf Strings in der SharedStringTab verweisen
                    Dim Name = StringTab.GetString(GetCellValueInt(Row, 1))
                    Dim CBTyp = StringTab.GetString(GetCellValueInt(Row, 2))

                    Dim MassInEarthmasses = GetCellValueDbl(Row, 3)
                    Dim MassInErarthMoonMasses = GetCellValueDbl(Row, 4)
                    Dim Gravity = GetCellValueDbl(Row, 5)
                    Dim AequatorialDiameter = GetCellValueDbl(Row, 6)
                    Dim PolarDiameter = GetCellValueDbl(Row, 7)
                    Dim SurfaceTemp = GetCellValueDbl(Row, 8)
                    Dim HasRings = GetCellValueInt(Row, 9)
                    Dim OrbitalSpeed = GetCellValueDbl(Row, 10)
                    Dim OrbitDia = GetCellValueDbl(Row, 11)
                    Dim MoonCount = GetCellValueInt(Row, 12)

                    With cbBuilder
                        .Reset()
                        .ID = Id
                        .Name = Name
                        .CBType = CBTyp
                        .MassInEarthmasses = MassInEarthmasses
                        .MassInEarthmoonMasses = MassInErarthMoonMasses
                        .GravityInMeterPerSecSec = Gravity
                        .AequatorialDiameterInKm = AequatorialDiameter
                        .PolarDiameterInKm = PolarDiameter
                        .HasRings = IIf(HasRings = 1, True, False)
                        .OrbitalSpeedInKilometerPerSec = OrbitalSpeed
                        .OrbitRadiusInAu = OrbitDia

                        Result.Add(cbBuilder.Create())
                    End With

                Next
            End Using

            Return Result
        Catch ex As Exception
            Throw New Exception(mko.TraceHlp.FormatErrMsg(Me, "ReadAll"), ex)
        Finally
            System.Threading.Thread.CurrentThread.CurrentCulture = ciBackup
        End Try
    End Function


    Function GetCellValue(Row As Row, ColNumber As Integer) As CellValue
        Return CType(Row(ColNumber), Cell).CellValue
    End Function

    Function GetCellValueInt(Row As Row, ColNumber As Integer) As Integer
        Return Integer.Parse(GetCellValue(Row, ColNumber).Text)
    End Function

    Function GetCellValueDbl(Row As Row, ColNumber As Integer) As Double
        Return Double.Parse(GetCellValue(Row, ColNumber).Text)
    End Function



End Class
