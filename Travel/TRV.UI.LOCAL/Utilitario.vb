Imports System.Security.Cryptography
Imports System.Text.RegularExpressions

Public class Utilitario

    Public Function ValidarEnBlanco(ByVal lista As List(Of String)) As Boolean
        For i As Integer = 0 To lista.Capacity
            If not lista(i) <> String.Empty
                Return false
            Else
                Return true
            End If
        Next
    End Function

    Public Function ValidarEnteroYDecimal(numero As String) As Boolean
        Dim ER As New Text.RegularExpressions.Regex("^(\d|-)?(\d|,)*\.?\d*$")
        Return (ER.IsMatch(numero))
    End Function

    Public Function ValidarFecha(fecha As String) As Boolean
        Return (IsDate(fecha))
    End Function

    Public Function ValidarTexto(texto As String) As Boolean
        Dim ER As New Text.RegularExpressions.Regex("([A-Za-zÑñáéíóúÁÉÍÓÚ]+)")
        Return (ER.IsMatch(texto))
    End Function

    Public Function ValidarEmail(email As String) As Boolean
        Dim ER As New Text.RegularExpressions.Regex("^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,3})$")
        Return (ER.IsMatch(email))
    End Function

    Public Function ValidarComboBox(combo As String) As Boolean
        Return (combo <> "")
    End Function

    '' LOGIN AND RECOVERY PASSWORD
    Public Function emailaddresscheck(ByVal emailaddress As String) As Boolean

        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(emailaddress, pattern)
        If emailAddressMatch.Success Then
            emailaddresscheck = True
        Else
            emailaddresscheck = False
        End If

    End Function

    Public Function passwordGenerator() As String

        Dim combination, n, passwordLenght, newPass, j As Object

        combination = "1234567890abcdefghijkrstuvwxyzABCDEFGHIJKUVWXYZ"
        n = Len(combination)
        passwordLenght = 5 '' Lenght of Password

        Randomize()
        newPass = ""

        For intstep = 1 To passwordLenght
            j = Int((n * Rnd()) + 1)
            newPass = newPass & Mid(combination, j, 1)
        Next

        passwordGenerator = newPass

    End Function

    Sub Speak(ByVal text As String)

        Dim audio = CreateObject("SAPI.spvoice")
        audio.volume = 100
        audio.rate = 0
        audio.speak(text)

    End Sub

    Public Function PorcentajeKilometroActual(ByVal km As Integer, totalKm As Integer) As Double

        PorcentajeKilometroActual = km / totalKm * 100
    End Function

    Public Function PorcentajeDeTiempo(ByVal porcentajeKm As Double, tiempoEstimado As Integer) As Double

        PorcentajeDeTiempo = porcentajeKm * tiempoEstimado / 100
    End Function

    Public Function ValidatePassword(ByVal pass As String,ByVal confirm As String)  As Boolean
        
           If(pass.Equals(confirm)) Then
            Return True
            Else
            Return false
           End If
        
    End Function

    Public Function ValidarHora(hora As String) As Boolean
        Dim ER As New Text.RegularExpressions.Regex("^([0-9]|0[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$")
        Return (ER.IsMatch(hora))
    End Function
    
End class