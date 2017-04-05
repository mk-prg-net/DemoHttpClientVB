Public Class CB
    Implements ICB

    Dim _ID As Integer
    Dim _Name As String
    Dim _CBType As String
    Dim _MassInEarthmasses As Double
    Dim _MassInEarthmoonMasses As Double
    Dim _HasRings As Boolean
    Dim _GravityInMeterPerSecSec As Double
    Dim _AequatorialDiameterInKm As Double
    Dim _PolarDiameterInKm As Double
    Dim _OrbitRadiusInAu As Double
    Dim _OrbitalSpeedInKilometerPerSec As Double


    Sub New(
        ID As Integer, _
        Name As String, _
        CBType As String, _
        MassInEarthmasses As Double, _
        MassInEarthmoonMasses As Double, _
        HasRings As Boolean, _
        GravityInMeterPerSecSec As Double, _
        AequatorialDiameterInKm As Double, _
        PolarDiameterInKm As Double, _
        OrbitRadiusInAu As Double, _
        OrbitalSpeedInKilometerPerSec As Double)

        _ID = ID
        _Name = Name
        _CBType = CBType
        _MassInEarthmasses = MassInEarthmasses
        _MassInEarthmoonMasses = MassInEarthmoonMasses
        _HasRings = HasRings
        _GravityInMeterPerSecSec = GravityInMeterPerSecSec
        _AequatorialDiameterInKm = AequatorialDiameterInKm
        _PolarDiameterInKm = PolarDiameterInKm
        _OrbitRadiusInAu = OrbitRadiusInAu
        _OrbitalSpeedInKilometerPerSec = OrbitalSpeedInKilometerPerSec

    End Sub


    Public ReadOnly Property AequatorialDiameterInKm As Double Implements ICB.AequatorialDiameterInKm
        Get
            Return _AequatorialDiameterInKm
        End Get
    End Property

    Public ReadOnly Property CBType As String Implements ICB.CBType
        Get
            Return _CBType
        End Get
    End Property

    Public ReadOnly Property GravityInMeterPerSecSec As Double Implements ICB.GravityInMeterPerSecSec
        Get
            Return _GravityInMeterPerSecSec
        End Get
    End Property

    Public ReadOnly Property HasRings As Boolean Implements ICB.HasRings
        Get
            Return _HasRings
        End Get
    End Property

    Public ReadOnly Property ID As Integer Implements ICB.ID
        Get
            Return _ID
        End Get
    End Property

    Public ReadOnly Property MassInEarthmasses As Double Implements ICB.MassInEarthmasses
        Get
            Return _MassInEarthmasses
        End Get
    End Property

    Public ReadOnly Property MassInEarthmoonMasses As Double Implements ICB.MassInEarthmoonMasses
        Get
            Return _MassInEarthmoonMasses
        End Get
    End Property

    Public ReadOnly Property Name As String Implements ICB.Name
        Get
            Return _Name
        End Get
    End Property

    Public ReadOnly Property OrbitalSpeedInKilometerPerSec As Double Implements ICB.OrbitalSpeedInKilometerPerSec
        Get
            Return _OrbitalSpeedInKilometerPerSec
        End Get
    End Property

    Public ReadOnly Property OrbitRadiusInAu As Double Implements ICB.OrbitRadiusInAu
        Get
            Return _OrbitRadiusInAu
        End Get
    End Property

    Public ReadOnly Property PolarDiameterInKm As Double Implements ICB.PolarDiameterInKm
        Get
            Return _PolarDiameterInKm
        End Get
    End Property
End Class
