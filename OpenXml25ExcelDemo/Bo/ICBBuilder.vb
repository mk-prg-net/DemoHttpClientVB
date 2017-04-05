Public Interface ICBBuilder

    ''' <summary>
    ''' Löscht alle Vorausgegangenen Einstellungen
    ''' </summary>
    ''' <remarks></remarks>
    Sub Reset()

    ''' <summary>
    ''' Erzeugt ein neues Himmelskörperobjekt aus den vorausgegangenen Einstellungen
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function Create() As ICB

    '---------------------------------------------------------------------------------------
    ' Einstellungen

    WriteOnly Property ID As Integer

    WriteOnly Property Name As String

    WriteOnly Property CBType As String

    WriteOnly Property MassInEarthmasses As Double

    WriteOnly Property MassInEarthmoonMasses As Double

    WriteOnly Property HasRings As Boolean

    WriteOnly Property GravityInMeterPerSecSec As Double

    WriteOnly Property AequatorialDiameterInKm As Double

    WriteOnly Property PolarDiameterInKm As Double

    WriteOnly Property OrbitRadiusInAu As Double

    WriteOnly Property OrbitalSpeedInKilometerPerSec As Double




End Interface
