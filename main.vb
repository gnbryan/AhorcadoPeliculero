Public Class frm_main
    ''' <summary>
    ''' variable string palabra
    ''' </summary>
    ''' <remarks>Es la palabra original que hay que adivinar</remarks>
    Friend palabra As String
    ''' <summary>
    ''' Variable booleana dosPlayers
    ''' </summary>
    ''' <remarks>Señala si la partida es de 1 o 2 jugadores.</remarks>
    Friend dosPlayers As Boolean 'Indica si la partida es de 1 o 2 jugadores.
    ''' <summary>
    ''' Evento click del botón salir
    ''' </summary>
    ''' <remarks>Sale de la aplicación actual</remarks>
    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
    ''' <summary>
    ''' Evento click del botón 1player
    ''' </summary>
    ''' <remarks>Al pulsar, comienza la partida para un jugador</remarks>
    Private Sub btn_1player_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_1player.Click
        dosPlayers = False
        frm_player.Show()
    End Sub
    ''' <summary>
    ''' Evento click del botón 2players
    ''' </summary>
    ''' <remarks>Al pulsar, el jugador 1 deberá de introducir una palabra para que el jugador 2 la adivine. Se rellenará de # una segunda palabra que ocultará  a la verdadera y que será lo que verá el jugador 2 y empezará la partida para 2 jugadores.</remarks>
    Private Sub btn_2players_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_2players.Click
        Do
            palabra = InputBox("Introduce la película a adivinar para el jugador 2", "Película a adivinar")
        Loop While palabra = ""
        palabra = palabra.ToUpper()
        dosPlayers = True
        frm_player.Show()
    End Sub
End Class
