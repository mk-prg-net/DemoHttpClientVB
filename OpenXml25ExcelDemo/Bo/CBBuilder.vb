Public Class CBBuilder
    Implements ICBBuilder

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


    Public WriteOnly Property AequatorialDiameterInKm As Double Implements ICBBuilder.AequatorialDiameterInKm
        Set(value As Double)
            _AequatorialDiameterInKm = value
        End Set
    End Property

    Public WriteOnly Property CBType As String Implements ICBBuilder.CBType
        Set(value As String)
            _CBType = value
        End Set
    End Property

    Public Function Create() As ICB Implements ICBBuilder.Create
        Return New CB(_ID, _Name, _CBType, _MassInEarthmasses, _MassInEarthmoonMasses, _HasRings, _GravityInMeterPerSecSec, _AequatorialDiameterInKm, _PolarDiameterInKm, _OrbitRadiusInAu, _OrbitalSpeedInKilometerPerSec)
    End Function

    Public WriteOnly Property GravityInMeterPerSecSec As Double Implements ICBBuilder.GravityInMeterPerSecSec
        Set(value As Double)
            _GravityInMeterPerSecSec = value
        End Set
    End Property

    Public WriteOnly Property HasRings As Boolean Implements ICBBuilder.HasRings
        Set(value As Boolean)
            _HasRings = value
        End Set
    End Property

    Public WriteOnly Property ID As Integer Implements ICBBuilder.ID
        Set(value As Integer)
            _ID = value
        End Set
    End Property

    Public WriteOnly Property MassInEarthmasses As Double Implements ICBBuilder.MassInEarthmasses
        Set(value As Double)
            _MassInEarthmasses = value
        End Set
    End Property

    Public WriteOnly Property MassInEarthmoonMasses As Double Implements ICBBuilder.MassInEarthmoonMasses
        Set(value As Double)
            _MassInEarthmoonMasses = value
        End Set
    End Property

    Public WriteOnly Property Name As String Implements ICBBuilder.Name
        Set(value As String)
            _Name = value
        End Set
    End Property

    Public WriteOnly Property OrbitalSpeedInKilometerPerSec As Double Implements ICBBuilder.OrbitalSpeedInKilometerPerSec
        Set(value As Double)
            _OrbitalSpeedInKilometerPerSec = value
        End Set
    End Property

    Public WriteOnly Property OrbitRadiusInAu As Double Implements ICBBuilder.OrbitRadiusInAu
        Set(value As Double)
            _OrbitRadiusInAu = value
        End Set
    End Property

    Public WriteOnly Property PolarDiameterInKm As Double Implements ICBBuilder.PolarDiameterInKm
        Set(value As Double)
            _PolarDiameterInKm = value
        End Set
    End Property

    Public Sub Reset() Implements ICBBuilder.Reset
        _ID = -1
        _Name = Nothing
        _CBType = Nothing
        _MassInEarthmasses = 0.0
        _MassInEarthmoonMasses = 0.0
        _HasRings = False
        _GravityInMeterPerSecSec = 0.0
        _AequatorialDiameterInKm = 0.0
        _PolarDiameterInKm = 0.0
        _OrbitRadiusInAu = 0.0
        _OrbitalSpeedInKilometerPerSec = 0.0

    End Sub
End Class
