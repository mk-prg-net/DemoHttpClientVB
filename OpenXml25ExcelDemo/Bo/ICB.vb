Public Interface ICB

    ReadOnly Property ID As Integer

    ReadOnly Property Name As String

    ''' <summary>
    ''' Typ des Himmelskörpers
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property CBType As String

    ReadOnly Property MassInEarthmasses As Double

    ReadOnly Property MassInEarthmoonMasses As Double

    ReadOnly Property HasRings As Boolean

    ReadOnly Property GravityInMeterPerSecSec As Double

    ReadOnly Property AequatorialDiameterInKm As Double

    ReadOnly Property PolarDiameterInKm As Double

    ReadOnly Property OrbitRadiusInAu As Double

    ReadOnly Property OrbitalSpeedInKilometerPerSec As Double


End Interface
