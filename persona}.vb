Public Class persona_

    Protected nombre As String
    Protected fechadenacimiento As DateTime?



    Public Property nombre_ As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property fechadenacimiento_ As DateTime

        Get
            Return fechadenacimiento
        End Get
        Set(value As DateTime
            )
            fechadenacimiento = value
        End Set
    End Property
    Public ReadOnly Property Edad() As String

        Get
            Dim edad_ As String
            edad_ = (DateTime.Now.Year - fechadenacimiento.Value.Year)
            Return edad_
        End Get

    End Property


    Sub persona(nombre_, fechadenacimiento_)

        nombre = nombre_
        fechadenacimiento = fechadenacimiento_


    End Sub

    Public Overrides Function ToString() As String

        Return nombre.ToUpper() + " " + Edad
    End Function

End Class

