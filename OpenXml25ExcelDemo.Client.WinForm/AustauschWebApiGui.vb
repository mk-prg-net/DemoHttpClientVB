''' <summary>
''' Stuttgart, den 4.7.2016
''' Martin Korneffel
''' Globale Objekte zum Austausch von Daten zwischen WebApi und Anwendung
''' </summary>
''' <remarks></remarks>
Module AustauschWebApiGui

    Dim _info As String

    Dim _lockObj As New Object

    ''' <summary>
    ''' Übbergabepunkt von Daten zwischen WebAPI und Anwendung
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Info As String
        Get
            SyncLock (_lockObj)
                Return _info
            End SyncLock
        End Get
        Set(value As String)
            SyncLock (_lockObj)
                _info = value
                RaiseEvent NeuEvent(_info)
            End SyncLock
        End Set
    End Property


    Public Event NeuEvent As Action(Of String)


End Module
