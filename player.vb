Imports System.Text
Public Class frm_player
    ''' <summary>
    ''' Array peliculas.
    ''' </summary>
    ''' <remarks>Vector de películas que albergarán las películas a adivinar para la partida de 1 jugador.</remarks>
    Private peliculas() = {"LA VIDA DE BRIAN", "EL LABERINTO DEL FAUNO", "EL PUENTE SOBRE EL RIO KWAI", "BEN HUR", "WEST SIDE STORY", "MY FAIR LADY", "SONRISAS Y LAGRIMAS", "EL PADRINO", "ALGUIEN VOLO SOBRE EL NIDO DEL CUCO", "ROCKY", "CARROS DE FUEGO", "AMADEUS", "MEMORIAS DE AFRICA", "PASEANDO A MISS DAISY", "BAILANDO CON LOBOS", "EL SILENCIO DE LOS CORDEROS", "LA LISTA DE SCHINDLER", "FORREST GUMP", "BRAVEHEART", "EL PACIENTE INGLES", "TITANIC", "SHAKESPEARE IN LOVE", "AMERICAN BEAUTY", "GLADIATOR", "UNA MENTE MARAVILLOSA", "CHICAGO", "EL RETORNO DEL REY", "MILLION DOLLAR BABY", "EL GRAN DICTADOR", "EL GOLPE", "PULP FICTION", "GHOST", "CASABLANCA", "CON LA MUERTE EN LOS TALONES", "SHREK", "LA GUERRA DE LAS GALAXIAS", "LA GUERRA DE LOS MUNDOS", "LOS CUATRO JINETES DEL APOCALIPSIS", "LOS DOS LADOS DE LA CAMA", "LOS LUNES AL SOL", "LOS PUENTES DE MADISON", "LUCIA Y EL SEXO", "MARS ATTACK", "INDEPENDENCE DAY", "AMERICAN HISTORY X", "EL ILUSIONISTA", "AMELIE", "LOS CHICOS DEL CORO", "SALVAR AL SOLDADO RYAN", "CARTAS DESDE IWO JIMA", "LOS CUATRO FANTASTICOS", "NO ES PAIS PARA VIEJOS", "A TODO GAS", "HELLBOY", "LOS CRIMENES DE OXFORD", "AMERICAN GANGSTER", "PIRATAS DEL CARIBE", "SPIDERMAN", "BROKEBACK MOUNTAIN", "BABEL", "EL AVIADOR", "KRAMER CONTRA KRAMER", "EL EXORCISTA", "ESPARTACO", "LA TUNICA SAGRADA", "DREAMGIRLS", "LOST IN TRANSLATION", "MOULIN ROUGE", "EVITA", "AMERICAN GRAFFITTI", "MAR ADENTRO", "HABLE CON ELLA", "TIGRE Y DRAGON", "TODO SOBRE MI MADRE", "ABRE LOS OJOS", "AGARRALO COMO PUEDAS", "AIR FORCE ONE", "ALATRISTE", "ARMAGEDDON", "AZUL OSCURO CASI NEGRO" _
    , "EL CABALLERO OSCURO", "BELLE EPOQUE", "BLADE", "CAMINO A LA PERDICION", "COMO DIOS", "CON AIR", "DIAMANTE DE SANGRE", "DIARIOS DE MOTOCICLETA", "DRAGONFLY", "EDUARDO MANOSTIJERAS", "EL BOSQUE", "EL CASO BOURNE", "EL CLUB DE LA LUCHA", "EL CURIOSO CASO DE BENJAMIN BUTTON", "EL DIABLO VISTE DE PRADA", "EL GUERRERO NUMERO TRECE", "EL INCIDENTE", "EL INCREIBLE HULK", "MATRIX REVOLUTIONS", "MAX PAYNE", "MEMORIAS DE UNA GEISHA", "MEN IN BLACK", "MENTES PELIGROSAS", "MINORITY REPORT", "MISION IMPOSIBLE", "EL CODIGO DA VINCI", "EL NIÑO CON EL PIJAMA DE RAYAS", "EL ORFANATO", "EL PIANISTA", "EL PROYECTO DE LA BRUJA DE BLAIR", "EL REY ESCORPION", "EL SARGENTO DE HIERRO", "EL SHOW DE TRUMAN", "ELEKTRA", "EN EL VALLE DE ELAH", "GANGS OF NEW YORK", "GODZILLA", "GREASE", "HANCOCK", "HIGH SCHOOL MUSICAL", "HITMAN", "IRON MAN", "JERRY MAGUIRE", "JURASSIC PARK", "KARATE KID", "KILL BILL", "LA CHAQUETA METALICA", "LA HISTORIA INTERMINABLE", "LA JUNGLA DE CRISTAL", "LA LEYENDA DEL ZORRO", "LA ROCA", "LA VIDA ES BELLA", "LAS CRONICAS DE NARNIA", "LAS HERMANAS BOLENA", "LOCA ACADEMIA DE POLICIA", "LOS CAZAFANTASMAS", "MASTER AND COMMANDER", "NOTTING HILL", "NOVIA A LA FUGA", "TWISTER", "OCEANS ELEVEN", "OPERACION SWORDFISH", "PAPA CANGURO", "PESADILLA ANTES DE NAVIDAD", "POSEIDON", "PRETTY WOMAN", "QUARANTINE", "JOHN RAMBO", "REQUIEM POR UN SUEÑO", "RESERVOIR DOGS", "RESIDENT EVIL", "ROBOCOP", "ROCKY BALBOA", "SCARY MOVIE", "SEGURIDAD NACIONAL", "HORA PUNTA", "SIN CITY", "SLEEPY HOLLOW", "EL SOLDADO UNIVERSAL", "EL PATRIOTA", "SOLO EN CASA", "SEÑOR Y SEÑORA SMITH", "SUPERMAN RETURNS", "SYRIANA", "TAXI DRIVER" _
    , "LA GUARIDA", "LA SEÑAL", "TRAINING DAY", "TRANSFORMERS", "TROPIC THUNDER", "TROYA", "ULTIMATUM A LA TIERRA", "UN PEZ LLAMADO WANDA", "UNDERWORLD", "V DE VENDETTA", "VAN HELSING", "VIAJE AL CENTRO DE LA TIERRA", "AEON FLUX", "AIRBAG", "ALGO PASA CON MARY", "EL BUENO EL FEO Y EL MALO", "ALIEN EL OCTAVO PASAJERO", "COCOON", "APOCALYPSE NOW", "ARMA LETAL", "AUSTRALIA", "BAJO EL SOL DE LA TOSCANA", "VICKY CRISTINA BARCELONA", "BIG FISH", "BLADE", "BLADE RUNNER", "EL METODO", "EL JARDINERO FIEL", "EL NEGOCIADOR", "CHARLIE Y LA FABRICA DE CHOCOLATE", "CHE EL ARGENTINO", "CONOCES A JOE BLACK", "LA MILLA VERDE", "NAUFRAGO", "LOS CABALLEROS DE LA MESA CUADRADA", "LA TERMINAL", "THE LADYKILLERS", "MENTIROSO COMPULSIVO", "EL DIARIO DE BRIDGET JONES", "CUATRO BODAS Y UN FUNERAL", "EN BUSCA DEL ARCA PERDIDA", "REGRESO AL FUTURO", "QUIEN ENGAÑO A ROGER RABBIT", "EL CABO DEL MIEDO", "DEEP IMPACT", "ARMAGEDDON", "VANILLA SKY", "MUNICH", "TIBURON", "DEEP BLUE SEA", "ENCUENTROS EN LA TERCERA FASE", "ET EL EXTRATERRESTRE", "LOS FANTASMAS DE GOYA", "CLOSER", "COLD MOUNTAIN", "THE EYE", "EL LENGUAJE DE LOS SUEÑOS", "SIN NOTICIAS DE DIOS", "CARNE TREMULA", "EL SEXTO SENTIDO", "SPY KIDS", "TACONES LEJANOS", "SAHARA", "THE ITALIAN JOB", "EL INDOMABLE WILL HUNTING", "EL SEÑOR DE LA GUERRA", "WINDTALKERS", "LA LIGA DE LOS HOMBRES EXTRAORDINARIOS", "LA NOVENA PUERTA", "PESADILLA EN ELM STREET", "EL PLANETA DE LOS SIMIOS", "ERIN BROCKOVICH", "ALGUNOS HOMBRES BUENOS", "EL RESPLANDOR", "DURMIENDO CON SU ENEMIGO", "EL INFORME PELICANO", "AL FINAL DEL EDEN", "ANGELES Y DEMONIOS", "APOCALYPTO", "ASESINATO EN OCHO MILIMETROS" _
    , "ATERRIZA COMO PUEDAS", "BLACK HAWK DERRIBADO", "CARA A CARA", "CATWOMAN", "COACH CARTER", "HURACAN CARTER", "LA TORMENTA PERFECTA", "CONAN EL BARBARO", "HARRY POTTER", "DAREDEVIL", "DELTA FORCE", "DIRTY DANCING", "DOS POLICIAS REBELDES", "DOCTOR DOLITTLE", "EJECUTIVO AGRESIVO", "EL BAR COYOTE", "EL CLUB DE LOS POETAS MUERTOS", "EL ESCANDALO DE LARRY FLINT", "EL GUARDAESPALDAS", "EL HOMBRE BICENTENARIO", "EL QUINTO ELEMENTO", "ESPIA COMO PUEDAS", "FLASHDANCE", "FULL MONTY", "GOOD MORNING VIETNAM", "HISTORIAS DEL KRONEN", "HOT MILK", "INSTINTO BASICO", "JUMANJI", "LA FUERZA DEL CARIÑO", "LA ISLA DE LAS CABEZAS CORTADAS", "LA LENGUA DE LAS MARIPOSAS", "LA MALA EDUCACION", "LA PLAYA", "LA SOMBRA DEL DIABLO", "LA TRAMPA", "LAS CRONICAS DE RIDDICK", "LOS ANGELES DE CHARLIE", "LOS SANTOS INOCENTES", "LOVE ACTUALLY", "MAD MAX", "MISS AGENTE ESPECIAL", "MORTAL KOMBAT", "NUEVE SEMANAS Y MEDIA", "PATCH ADAMS", "PEARL HARBOR", "ROBIN HOOD PRINCIPE DE LOS LADRONES", "SEVEN", "SOLDADOS DE SALAMINA", "SPACE COWBOYS", "SPY GAME", "STAR TREK", "STARGATE", "SUPERDETECTIVE EN HOLLYWOOD", "SWEET HOME ALABAMA", "TWO MUCH", "TERMINATOR", "LA PROFECIA", "TOMB RAIDER", "TRAINSPOTTING", "TRAS LA LINEA ENEMIGA", "LA MOMIA", "TROYA", "XXX", "ALIEN VERSUS PREDATOR", "EL MOTORISTA FANTASMA", "HANNIBAL EL ORIGEN DEL MAL", "JUNO", "LA ISLA DE LAS ALMAS PERDIDAS", "LA TORRE DE SUSO", "LA VIDA EN ROSA", "LAS TRECE ROSAS", "LAS CRONICAS DE SPIDERWICK", "NEXT", "EL MOTORISTA FANTASMA", "EL ULTIMATUM DE BOURNE"}
    ''' <summary>
    ''' Array de bitmap horca.
    ''' </summary>
    ''' <remarks>Array que contendrá los dibujos de las horcas.</remarks>
    Private horca() As System.Drawing.Bitmap
    ''' <summary>
    ''' Variable stringbuilder asteriscos
    ''' </summary>
    ''' <remarks>Variable que mantendrá oculta la palabra a adivinar a base de #. Según el jugador vaya acertando la palabra esta variable irá cambiando sus # por los de la palabra original.</remarks>
    Private asteriscos As StringBuilder
    ''' <summary>
    ''' Variable entera fallos
    ''' </summary>
    ''' <remarks>Almacenará el número de fallos del jugador.</remarks>
    Private fallos As Integer
    ''' <summary>
    ''' Variable string palabra
    ''' </summary>
    ''' <remarks>Palabra a adivinar</remarks>
    Private palabra As String
    ''' <summary>
    ''' Evento load del formulario frm_player
    ''' </summary>
    ''' <remarks>
    ''' Al iniciar la partida, se cargan todos los dibujos de la horca en su array correspondiente, colocándose visible el primero de ellos, se carga la variable que contendrá los # en caso del juego de 2 jugadores o se inicializará aleatoriamente una de las películas en el caso del de 1 jugador.
    ''' Se mostrará al usuario la palabra entre # para que la adivine y se inicializarán las variables de fallos y el stringbuilder que contiene los #.
    ''' </remarks>
    Private Sub frm_player_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        Dim aleatorio As New System.Random()

        fallos = 0
        asteriscos = New StringBuilder()

        ReDim horca(6)
        horca(0) = My.Resources.horca0
        horca(1) = My.Resources.horca1
        horca(2) = My.Resources.horca2
        horca(3) = My.Resources.horca3
        horca(4) = My.Resources.horca4
        horca(5) = My.Resources.horca5
        horca(6) = My.Resources.horca6

        Me.pbx_horca.Image = My.Resources.horca0

        If frm_main.dosPlayers = True Then
            palabra = frm_main.palabra
            For i = 0 To palabra.Length - 1
                If Char.IsLetter(palabra.Chars(i)) Then
                    asteriscos.Insert(i, "#")
                Else
                    asteriscos.Insert(i, palabra.Chars(i))
                End If
            Next
        Else
            palabra = peliculas(aleatorio.Next(0, peliculas.GetUpperBound(0)))
            For i = 0 To palabra.Length - 1
                If Char.IsLetter(palabra.Chars(i)) Then
                    asteriscos.Insert(i, "#")
                Else
                    asteriscos.Insert(i, palabra.Chars(i))
                End If
            Next
        End If

        Me.txt_frase.Text = asteriscos.ToString.ToUpper
    End Sub
    ''' <summary>
    ''' Evento click del botón salir
    ''' </summary>
    ''' <remarks>Sale de la aplicación actual.</remarks>
    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub
    ''' <summary>
    ''' Evento click del botón resolver.
    ''' </summary>
    ''' <remarks>Botón que colocará en el textbox la palabra que se intentaba adivinar.</remarks>
    Private Sub btn_resolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_resolver.Click
        Me.txt_frase.Text = Me.palabra
        bloquearLetras()
    End Sub
    ''' <summary>
    ''' Método bloquearLetras
    ''' </summary>
    ''' <remarks>Método sub que no recibe parámetros y que se encargará de bloquear todos los botones del tablero de juego excepto el de salir, para así evitar que el jugador siga pulsando letras cuando la palabra esté ya descubierta o ya se haya perdido.</remarks>
    Private Sub bloquearLetras()
        Dim objeto As Control

        For Each objeto In Me.Controls
            If TypeOf objeto Is Button AndAlso objeto IsNot btn_Salir Then
                objeto.Enabled = False
            End If
        Next
    End Sub
    ''' <summary>
    ''' Evento click del botón A.
    ''' </summary>
    ''' <remarks>Enviará al método buscarLetra el botón A y se bloqueará para que no se vuelva a pulsar.</remarks>
    Private Sub btn_A_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_A.Click
        buscarLetra(sender)
        Me.btn_A.Enabled = False
        Me.btn_A.BackColor = Color.Azure
    End Sub
    ''' <summary>
    ''' Evento click del botón B.
    ''' </summary>
    ''' <remarks>Enviará al método buscarLetra el botón B y se bloqueará para que no se vuelva a pulsar.</remarks>
    Private Sub btn_B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_B.Click
        buscarLetra(sender)
        Me.btn_B.Enabled = False
        Me.btn_B.BackColor = Color.Azure
    End Sub
    ''' <summary>
    ''' Evento click del botón C.
    ''' </summary>
    ''' <remarks>Enviará al método buscarLetra el botón C y se bloqueará para que no se vuelva a pulsar.</remarks>
    Private Sub btn_C_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_C.Click
        buscarLetra(sender)
        Me.btn_C.Enabled = False
        Me.btn_C.BackColor = Color.Azure
    End Sub
    ''' <summary>
    ''' Evento click del botón D
    ''' </summary>
    ''' <remarks>Enviará al método buscarLetra el botón D y se bloqueará para que no se vuelva a pulsar.</remarks>
    Private Sub btn_D_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_D.Click
        buscarLetra(sender)
        Me.btn_D.Enabled = False
        Me.btn_D.BackColor = Color.Azure
    End Sub
    ''' <summary>
    ''' Evento click del botón E
    ''' </summary>
    ''' <remarks>Enviará al método buscarLetra el botón E y se bloqueará para que no se vuelva a pulsar.</remarks>
    Private Sub btn_E_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_E.Click
        buscarLetra(sender)
        Me.btn_E.Enabled = False
        Me.btn_E.BackColor = Color.Azure
    End Sub
    ''' <summary>
    ''' Evento click del botón F
    ''' </summary>
    ''' <remarks>Enviará al método buscarLetra el botón F y se bloqueará para que no se vuelva a pulsar.</remarks>
    Private Sub btn_F_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_F.Click
        buscarLetra(sender)
        Me.btn_F.Enabled = False
        Me.btn_F.BackColor = Color.Azure
    End Sub
    ''' <summary>
    ''' Evento click del botón G
    ''' </summary>
    ''' <remarks>Enviará al método buscarLetra el botón G y se bloqueará para que no se vuelva a pulsar.</remarks>
    Private Sub btn_G_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_G.Click
        buscarLetra(sender)
        Me.btn_G.Enabled = False
        Me.btn_G.BackColor = Color.Azure
    End Sub
    ''' <summary>
    ''' Evento click del botón H
    ''' </summary>
    ''' <remarks>Enviará al método buscarLetra el botón H y se bloqueará para que no se vuelva a pulsar.</remarks>
    Private Sub btn_H_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_H.Click
        buscarLetra(sender)
        Me.btn_H.Enabled = False
        Me.btn_H.BackColor = Color.Azure
    End Sub
    ''' <summary>
    ''' Evento click del botón I
    ''' </summary>
    ''' <remarks>Enviará al método buscarLetra el botón I y se bloqueará para que no se vuelva a pulsar.</remarks>
    Private Sub btn_I_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_I.Click
        buscarLetra(sender)
        Me.btn_I.Enabled = False
        Me.btn_I.BackColor = Color.Azure
    End Sub
    ''' <summary>
    ''' Evento click del botón J
    ''' </summary>
    ''' <remarks>Enviará al método buscarLetra el botón J y se bloqueará para que no se vuelva a pulsar.</remarks>
    Private Sub btn_J_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_J.Click
        buscarLetra(sender)
        Me.btn_J.Enabled = False
        Me.btn_J.BackColor = Color.Azure
    End Sub
    ''' <summary>
    ''' Evento click del botón K
    ''' </summary>
    ''' <remarks>Enviará al método buscarLetra el botón K y se bloqueará para que no se vuelva a pulsar.</remarks>
    Private Sub btn_K_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_K.Click
        buscarLetra(sender)
        Me.btn_K.Enabled = False
        Me.btn_K.BackColor = Color.Azure
    End Sub
    ''' <summary>
    ''' Evento click del botón L
    ''' </summary>
    ''' <remarks>Enviará al método buscarLetra el botón L y se bloqueará para que no se vuelva a pulsar.</remarks>
    Private Sub btn_L_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_L.Click
        buscarLetra(sender)
        Me.btn_L.Enabled = False
        Me.btn_L.BackColor = Color.Azure
    End Sub
    ''' <summary>
    ''' Evento click del botón M
    ''' </summary>
    ''' <remarks>Enviará al método buscarLetra el botón M y se bloqueará para que no se vuelva a pulsar.</remarks>
    Private Sub btn_M_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_M.Click
        buscarLetra(sender)
        Me.btn_M.Enabled = False
        Me.btn_M.BackColor = Color.Azure
    End Sub
    ''' <summary>
    ''' Evento click del botón N
    ''' </summary>
    ''' <remarks>Enviará al método buscarLetra el botón N y se bloqueará para que no se vuelva a pulsar.</remarks>
    Private Sub btn_N_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_N.Click
        buscarLetra(sender)
        Me.btn_N.Enabled = False
        Me.btn_N.BackColor = Color.Azure
    End Sub
    ''' <summary>
    ''' Evento click del botón Ñ
    ''' </summary>
    ''' <remarks>Enviará al método buscarLetra el botón Ñ y se bloqueará para que no se vuelva a pulsar.</remarks>
    Private Sub btn_Ñ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Ñ.Click
        buscarLetra(sender)
        Me.btn_Ñ.Enabled = False
        Me.btn_Ñ.BackColor = Color.Azure
    End Sub
    ''' <summary>
    ''' Evento click del botón O
    ''' </summary>
    ''' <remarks>Enviará al método buscarLetra el botón O y se bloqueará para que no se vuelva a pulsar.</remarks>
    Private Sub btn_O_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_O.Click
        buscarLetra(sender)
        Me.btn_O.Enabled = False
        Me.btn_O.BackColor = Color.Azure
    End Sub
    ''' <summary>
    ''' Evento click del botón P
    ''' </summary>
    ''' <remarks>Enviará al método buscarLetra el botón P y se bloqueará para que no se vuelva a pulsar.</remarks>
    Private Sub btn_P_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_P.Click
        buscarLetra(sender)
        Me.btn_P.Enabled = False
        Me.btn_P.BackColor = Color.Azure
    End Sub
    ''' <summary>
    ''' Evento click del botón Q
    ''' </summary>
    ''' <remarks>Enviará al método buscarLetra el botón Q y se bloqueará para que no se vuelva a pulsar.</remarks>
    Private Sub btn_Q_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Q.Click
        buscarLetra(sender)
        Me.btn_Q.Enabled = False
        Me.btn_Q.BackColor = Color.Azure
    End Sub
    ''' <summary>
    ''' Evento click del botón R
    ''' </summary>
    ''' <remarks>Enviará al método buscarLetra el botón R y se bloqueará para que no se vuelva a pulsar.</remarks>
    Private Sub btn_R_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_R.Click
        buscarLetra(sender)
        Me.btn_R.Enabled = False
        Me.btn_R.BackColor = Color.Azure
    End Sub
    ''' <summary>
    ''' Evento click del botón S
    ''' </summary>
    ''' <remarks>Enviará al método buscarLetra el botón S y se bloqueará para que no se vuelva a pulsar.</remarks>
    Private Sub btn_S_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_S.Click
        buscarLetra(sender)
        Me.btn_S.Enabled = False
        Me.btn_S.BackColor = Color.Azure
    End Sub
    ''' <summary>
    ''' Evento click del botón T
    ''' </summary>
    ''' <remarks>Enviará al método buscarLetra el botón T y se bloqueará para que no se vuelva a pulsar.</remarks>
    Private Sub btn_T_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_T.Click
        buscarLetra(sender)
        Me.btn_T.Enabled = False
        Me.btn_T.BackColor = Color.Azure
    End Sub
    ''' <summary>
    ''' Evento click del botón U
    ''' </summary>
    ''' <remarks>Enviará al método buscarLetra el botón U y se bloqueará para que no se vuelva a pulsar.</remarks>
    Private Sub btn_U_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_U.Click
        buscarLetra(sender)
        Me.btn_U.Enabled = False
        Me.btn_U.BackColor = Color.Azure
    End Sub
    ''' <summary>
    ''' Evento click del botón V
    ''' </summary>
    ''' <remarks>Enviará al método buscarLetra el botón V y se bloqueará para que no se vuelva a pulsar.</remarks>
    Private Sub btn_V_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_V.Click
        buscarLetra(sender)
        Me.btn_V.Enabled = False
        Me.btn_V.BackColor = Color.Azure
    End Sub
    ''' <summary>
    ''' Evento click del botón W
    ''' </summary>
    ''' <remarks>Enviará al método buscarLetra el botón W y se bloqueará para que no se vuelva a pulsar.</remarks>
    Private Sub btn_W_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_W.Click
        buscarLetra(sender)
        Me.btn_W.Enabled = False
        Me.btn_W.BackColor = Color.Azure
    End Sub
    ''' <summary>
    ''' Evento click del botón X
    ''' </summary>
    ''' <remarks>Enviará al método buscarLetra el botón X y se bloqueará para que no se vuelva a pulsar.</remarks>
    Private Sub btn_X_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_X.Click
        buscarLetra(sender)
        Me.btn_X.Enabled = False
        Me.btn_X.BackColor = Color.Azure
    End Sub
    ''' <summary>
    ''' Evento click del botón Y
    ''' </summary>
    ''' <remarks>Enviará al método buscarLetra el botón Y y se bloqueará para que no se vuelva a pulsar.</remarks>
    Private Sub btn_Y_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Y.Click
        buscarLetra(sender)
        Me.btn_Y.Enabled = False
        Me.btn_Y.BackColor = Color.Azure
    End Sub

    ''' <summary>
    ''' Evento click del botón Z
    ''' </summary>
    ''' <remarks>Enviará al método buscarLetra el botón Z y se bloqueará para que no se vuelva a pulsar.</remarks>
    Private Sub btn_Z_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Z.Click
        buscarLetra(sender)
        Me.btn_Z.Enabled = False
        Me.btn_Z.BackColor = Color.Azure
    End Sub
    ''' <summary>
    ''' Método buscarLetra
    ''' </summary>
    ''' <remarks>
    ''' Método sub buscarLetra que recibe por parámetro el botón pulsado por el usuario.
    ''' Dependiendo del botón, el método buscará en la palabra a adivinar si existe alguna letra que concuerde con la que haya pulsado el usuario.
    ''' En caso de haberlas las inserta en la palabra y la vuelve a mostrar con los nuevos cambios, si no está se cuenta como falló y la horca avanzará.
    ''' En caso de que la horca llegue a 6, el juego finalizará con derrota para el jugador y si la palabra a proponer es igual a la palabra a adivinar, el jugador habrá ganado.
    ''' </remarks>
    Private Sub buscarLetra(ByVal boton As Button)
        Dim hayletra = False
        Dim i As Integer
        Select Case boton.Text
            Case "A"
                For i = 0 To palabra.Length - 1
                    If palabra.Chars(i) = "A" Then
                        asteriscos.Insert(i, "A")
                        asteriscos.Remove(i + 1, 1)
                        hayletra = True
                    End If
                Next

                Me.txt_frase.Text = asteriscos.ToString

                If hayletra = False Then
                    fallos += 1
                    Me.pbx_horca.Image = horca(fallos)
                    If fallos = 6 Then
                        MsgBox("Has perdido.")
                        Me.txt_frase.Text = palabra
                        bloquearLetras()
                    End If
                End If
                If Me.txt_frase.Text = Me.palabra AndAlso fallos <> 6 Then
                    MsgBox("Felicidades, has acertado la palabra.")
                    bloquearLetras()
                End If
            Case "B"
                For i = 0 To palabra.Length - 1
                    If palabra.Chars(i) = "B" Then
                        asteriscos.Insert(i, "B")
                        asteriscos.Remove(i + 1, 1)
                        hayletra = True
                    End If
                Next

                Me.txt_frase.Text = asteriscos.ToString

                If hayletra = False Then
                    fallos += 1
                    Me.pbx_horca.Image = horca(fallos)
                    If fallos = 6 Then
                        MsgBox("Has perdido.")
                        Me.txt_frase.Text = palabra
                        bloquearLetras()
                    End If
                End If
                If Me.txt_frase.Text = Me.palabra AndAlso fallos <> 6 Then
                    MsgBox("Felicidades, has acertado la palabra.")
                    bloquearLetras()
                End If
            Case "C"
                For i = 0 To palabra.Length - 1
                    If palabra.Chars(i) = "C" Then
                        asteriscos.Insert(i, "C")
                        asteriscos.Remove(i + 1, 1)
                        hayletra = True
                    End If
                Next

                Me.txt_frase.Text = asteriscos.ToString

                If hayletra = False Then
                    fallos += 1
                    Me.pbx_horca.Image = horca(fallos)
                    If fallos = 6 Then
                        MsgBox("Has perdido.")
                        Me.txt_frase.Text = palabra
                        bloquearLetras()
                    End If
                End If
                If Me.txt_frase.Text = Me.palabra AndAlso fallos <> 6 Then
                    MsgBox("Felicidades, has acertado la palabra.")
                    bloquearLetras()
                End If
            Case "D"
                For i = 0 To palabra.Length - 1
                    If palabra.Chars(i) = "D" Then
                        asteriscos.Insert(i, "D")
                        asteriscos.Remove(i + 1, 1)
                        hayletra = True
                    End If
                Next

                Me.txt_frase.Text = asteriscos.ToString

                If hayletra = False Then
                    fallos += 1
                    Me.pbx_horca.Image = horca(fallos)
                    If fallos = 6 Then
                        MsgBox("Has perdido.")
                        Me.txt_frase.Text = palabra
                        bloquearLetras()
                    End If
                End If
                If Me.txt_frase.Text = Me.palabra AndAlso fallos <> 6 Then
                    MsgBox("Felicidades, has acertado la palabra.")
                    bloquearLetras()
                End If
            Case "E"
                For i = 0 To palabra.Length - 1
                    If palabra.Chars(i) = "E" Then
                        asteriscos.Insert(i, "E")
                        asteriscos.Remove(i + 1, 1)
                        hayletra = True
                    End If
                Next

                Me.txt_frase.Text = asteriscos.ToString

                If hayletra = False Then
                    fallos += 1
                    Me.pbx_horca.Image = horca(fallos)
                    If fallos = 6 Then
                        MsgBox("Has perdido.")
                        Me.txt_frase.Text = palabra
                        bloquearLetras()
                    End If
                End If
                If Me.txt_frase.Text = Me.palabra AndAlso fallos <> 6 Then
                    MsgBox("Felicidades, has acertado la palabra.")
                    bloquearLetras()
                End If
            Case "F"
                For i = 0 To palabra.Length - 1
                    If palabra.Chars(i) = "F" Then
                        asteriscos.Insert(i, "F")
                        asteriscos.Remove(i + 1, 1)
                        hayletra = True
                    End If
                Next

                Me.txt_frase.Text = asteriscos.ToString

                If hayletra = False Then
                    fallos += 1
                    Me.pbx_horca.Image = horca(fallos)
                    If fallos = 6 Then
                        MsgBox("Has perdido.")
                        Me.txt_frase.Text = palabra
                        bloquearLetras()
                    End If
                End If
                If Me.txt_frase.Text = Me.palabra AndAlso fallos <> 6 Then
                    MsgBox("Felicidades, has acertado la palabra.")
                    bloquearLetras()
                End If
            Case "G"
                For i = 0 To palabra.Length - 1
                    If palabra.Chars(i) = "G" Then
                        asteriscos.Insert(i, "G")
                        asteriscos.Remove(i + 1, 1)
                        hayletra = True
                    End If
                Next

                Me.txt_frase.Text = asteriscos.ToString

                If hayletra = False Then
                    fallos += 1
                    Me.pbx_horca.Image = horca(fallos)
                    If fallos = 6 Then
                        MsgBox("Has perdido.")
                        Me.txt_frase.Text = palabra
                        bloquearLetras()
                    End If
                End If
                If Me.txt_frase.Text = Me.palabra AndAlso fallos <> 6 Then
                    MsgBox("Felicidades, has acertado la palabra.")
                    bloquearLetras()
                End If
            Case "H"
                For i = 0 To palabra.Length - 1
                    If palabra.Chars(i) = "H" Then
                        asteriscos.Insert(i, "H")
                        asteriscos.Remove(i + 1, 1)
                        hayletra = True
                    End If
                Next

                Me.txt_frase.Text = asteriscos.ToString

                If hayletra = False Then
                    fallos += 1
                    Me.pbx_horca.Image = horca(fallos)
                    If fallos = 6 Then
                        MsgBox("Has perdido.")
                        Me.txt_frase.Text = palabra
                        bloquearLetras()
                    End If
                End If
                If Me.txt_frase.Text = Me.palabra AndAlso fallos <> 6 Then
                    MsgBox("Felicidades, has acertado la palabra.")
                    bloquearLetras()
                End If
            Case "I"
                For i = 0 To palabra.Length - 1
                    If palabra.Chars(i) = "I" Then
                        asteriscos.Insert(i, "I")
                        asteriscos.Remove(i + 1, 1)
                        hayletra = True
                    End If
                Next

                Me.txt_frase.Text = asteriscos.ToString

                If hayletra = False Then
                    fallos += 1
                    Me.pbx_horca.Image = horca(fallos)
                    If fallos = 6 Then
                        MsgBox("Has perdido.")
                        Me.txt_frase.Text = palabra
                        bloquearLetras()
                    End If
                End If
                If Me.txt_frase.Text = Me.palabra AndAlso fallos <> 6 Then
                    MsgBox("Felicidades, has acertado la palabra.")
                    bloquearLetras()
                End If
            Case "J"
                For i = 0 To palabra.Length - 1
                    If palabra.Chars(i) = "J" Then
                        asteriscos.Insert(i, "J")
                        asteriscos.Remove(i + 1, 1)
                        hayletra = True
                    End If
                Next

                Me.txt_frase.Text = asteriscos.ToString

                If hayletra = False Then
                    fallos += 1
                    Me.pbx_horca.Image = horca(fallos)
                    If fallos = 6 Then
                        MsgBox("Has perdido.")
                        Me.txt_frase.Text = palabra
                        bloquearLetras()
                    End If
                End If
                If Me.txt_frase.Text = Me.palabra AndAlso fallos <> 6 Then
                    MsgBox("Felicidades, has acertado la palabra.")
                    bloquearLetras()
                End If
            Case "K"
                For i = 0 To palabra.Length - 1
                    If palabra.Chars(i) = "K" Then
                        asteriscos.Insert(i, "K")
                        asteriscos.Remove(i + 1, 1)
                        hayletra = True
                    End If
                Next

                Me.txt_frase.Text = asteriscos.ToString

                If hayletra = False Then
                    fallos += 1
                    Me.pbx_horca.Image = horca(fallos)
                    If fallos = 6 Then
                        MsgBox("Has perdido.")
                        Me.txt_frase.Text = palabra
                        bloquearLetras()
                    End If
                End If
                If Me.txt_frase.Text = Me.palabra AndAlso fallos <> 6 Then
                    MsgBox("Felicidades, has acertado la palabra.")
                    bloquearLetras()
                End If
            Case "L"
                For i = 0 To palabra.Length - 1
                    If palabra.Chars(i) = "L" Then
                        asteriscos.Insert(i, "L")
                        asteriscos.Remove(i + 1, 1)
                        hayletra = True
                    End If
                Next

                Me.txt_frase.Text = asteriscos.ToString

                If hayletra = False Then
                    fallos += 1
                    Me.pbx_horca.Image = horca(fallos)
                    If fallos = 6 Then
                        MsgBox("Has perdido.")
                        Me.txt_frase.Text = palabra
                        bloquearLetras()
                    End If
                End If
                If Me.txt_frase.Text = Me.palabra AndAlso fallos <> 6 Then
                    MsgBox("Felicidades, has acertado la palabra.")
                    bloquearLetras()
                End If
            Case "M"
                For i = 0 To palabra.Length - 1
                    If palabra.Chars(i) = "M" Then
                        asteriscos.Insert(i, "M")
                        asteriscos.Remove(i + 1, 1)
                        hayletra = True
                    End If
                Next

                Me.txt_frase.Text = asteriscos.ToString

                If hayletra = False Then
                    fallos += 1
                    Me.pbx_horca.Image = horca(fallos)
                    If fallos = 6 Then
                        MsgBox("Has perdido.")
                        Me.txt_frase.Text = palabra
                        bloquearLetras()
                    End If
                End If
                If Me.txt_frase.Text = Me.palabra AndAlso fallos <> 6 Then
                    MsgBox("Felicidades, has acertado la palabra.")
                    bloquearLetras()
                End If
            Case "N"
                For i = 0 To palabra.Length - 1
                    If palabra.Chars(i) = "N" Then
                        asteriscos.Insert(i, "N")
                        asteriscos.Remove(i + 1, 1)
                        hayletra = True
                    End If
                Next

                Me.txt_frase.Text = asteriscos.ToString

                If hayletra = False Then
                    fallos += 1
                    Me.pbx_horca.Image = horca(fallos)
                    If fallos = 6 Then
                        MsgBox("Has perdido.")
                        Me.txt_frase.Text = palabra
                        bloquearLetras()
                    End If
                End If
                If Me.txt_frase.Text = Me.palabra AndAlso fallos <> 6 Then
                    MsgBox("Felicidades, has acertado la palabra.")
                    bloquearLetras()
                End If
            Case "Ñ"
                For i = 0 To palabra.Length - 1
                    If palabra.Chars(i) = "Ñ" Then
                        asteriscos.Insert(i, "Ñ")
                        asteriscos.Remove(i + 1, 1)
                        hayletra = True
                    End If
                Next

                Me.txt_frase.Text = asteriscos.ToString

                If hayletra = False Then
                    fallos += 1
                    Me.pbx_horca.Image = horca(fallos)
                    If fallos = 6 Then
                        MsgBox("Has perdido.")
                        Me.txt_frase.Text = palabra
                        bloquearLetras()
                    End If
                End If
                If Me.txt_frase.Text = Me.palabra AndAlso fallos <> 6 Then
                    MsgBox("Felicidades, has acertado la palabra.")
                    bloquearLetras()
                End If
            Case "O"
                For i = 0 To palabra.Length - 1
                    If palabra.Chars(i) = "O" Then
                        asteriscos.Insert(i, "O")
                        asteriscos.Remove(i + 1, 1)
                        hayletra = True
                    End If
                Next

                Me.txt_frase.Text = asteriscos.ToString

                If hayletra = False Then
                    fallos += 1
                    Me.pbx_horca.Image = horca(fallos)
                    If fallos = 6 Then
                        MsgBox("Has perdido.")
                        Me.txt_frase.Text = palabra
                        bloquearLetras()
                    End If
                End If
                If Me.txt_frase.Text = Me.palabra AndAlso fallos <> 6 Then
                    MsgBox("Felicidades, has acertado la palabra.")
                    bloquearLetras()
                End If
            Case "P"
                For i = 0 To palabra.Length - 1
                    If palabra.Chars(i) = "P" Then
                        asteriscos.Insert(i, "P")
                        asteriscos.Remove(i + 1, 1)
                        hayletra = True
                    End If
                Next

                Me.txt_frase.Text = asteriscos.ToString

                If hayletra = False Then
                    fallos += 1
                    Me.pbx_horca.Image = horca(fallos)
                    If fallos = 6 Then
                        MsgBox("Has perdido.")
                        Me.txt_frase.Text = palabra
                        bloquearLetras()
                    End If
                End If
                If Me.txt_frase.Text = Me.palabra AndAlso fallos <> 6 Then
                    MsgBox("Felicidades, has acertado la palabra.")
                    bloquearLetras()
                End If
            Case "Q"
                For i = 0 To palabra.Length - 1
                    If palabra.Chars(i) = "Q" Then
                        asteriscos.Insert(i, "Q")
                        asteriscos.Remove(i + 1, 1)
                        hayletra = True
                    End If
                Next

                Me.txt_frase.Text = asteriscos.ToString

                If hayletra = False Then
                    fallos += 1
                    Me.pbx_horca.Image = horca(fallos)
                    If fallos = 6 Then
                        MsgBox("Has perdido.")
                        Me.txt_frase.Text = palabra
                        bloquearLetras()
                    End If
                End If
                If Me.txt_frase.Text = Me.palabra AndAlso fallos <> 6 Then
                    MsgBox("Felicidades, has acertado la palabra.")
                    bloquearLetras()
                End If
            Case "R"
                For i = 0 To palabra.Length - 1
                    If palabra.Chars(i) = "R" Then
                        asteriscos.Insert(i, "R")
                        asteriscos.Remove(i + 1, 1)
                        hayletra = True
                    End If
                Next

                Me.txt_frase.Text = asteriscos.ToString

                If hayletra = False Then
                    fallos += 1
                    Me.pbx_horca.Image = horca(fallos)
                    If fallos = 6 Then
                        MsgBox("Has perdido.")
                        Me.txt_frase.Text = palabra
                        bloquearLetras()
                    End If
                End If
                If Me.txt_frase.Text = Me.palabra AndAlso fallos <> 6 Then
                    MsgBox("Felicidades, has acertado la palabra.")
                    bloquearLetras()
                End If
            Case "S"
                For i = 0 To palabra.Length - 1
                    If palabra.Chars(i) = "S" Then
                        asteriscos.Insert(i, "S")
                        asteriscos.Remove(i + 1, 1)
                        hayletra = True
                    End If
                Next

                Me.txt_frase.Text = asteriscos.ToString

                If hayletra = False Then
                    fallos += 1
                    Me.pbx_horca.Image = horca(fallos)
                    If fallos = 6 Then
                        MsgBox("Has perdido.")
                        Me.txt_frase.Text = palabra
                        bloquearLetras()
                    End If
                End If
                If Me.txt_frase.Text = Me.palabra AndAlso fallos <> 6 Then
                    MsgBox("Felicidades, has acertado la palabra.")
                    bloquearLetras()
                End If
            Case "T"
                For i = 0 To palabra.Length - 1
                    If palabra.Chars(i) = "T" Then
                        asteriscos.Insert(i, "T")
                        asteriscos.Remove(i + 1, 1)
                        hayletra = True
                    End If
                Next

                Me.txt_frase.Text = asteriscos.ToString

                If hayletra = False Then
                    fallos += 1
                    Me.pbx_horca.Image = horca(fallos)
                    If fallos = 6 Then
                        MsgBox("Has perdido.")
                        Me.txt_frase.Text = palabra
                        bloquearLetras()
                    End If
                End If
                If Me.txt_frase.Text = Me.palabra AndAlso fallos <> 6 Then
                    MsgBox("Felicidades, has acertado la palabra.")
                    bloquearLetras()
                End If
            Case "U"
                For i = 0 To palabra.Length - 1
                    If palabra.Chars(i) = "U" Then
                        asteriscos.Insert(i, "U")
                        asteriscos.Remove(i + 1, 1)
                        hayletra = True
                    End If
                Next

                Me.txt_frase.Text = asteriscos.ToString

                If hayletra = False Then
                    fallos += 1
                    Me.pbx_horca.Image = horca(fallos)
                    If fallos = 6 Then
                        MsgBox("Has perdido.")
                        Me.txt_frase.Text = palabra
                        bloquearLetras()
                    End If
                End If
                If Me.txt_frase.Text = Me.palabra AndAlso fallos <> 6 Then
                    MsgBox("Felicidades, has acertado la palabra.")
                    bloquearLetras()
                End If
            Case "V"
                For i = 0 To palabra.Length - 1
                    If palabra.Chars(i) = "V" Then
                        asteriscos.Insert(i, "V")
                        asteriscos.Remove(i + 1, 1)
                        hayletra = True
                    End If
                Next

                Me.txt_frase.Text = asteriscos.ToString

                If hayletra = False Then
                    fallos += 1
                    Me.pbx_horca.Image = horca(fallos)
                    If fallos = 6 Then
                        MsgBox("Has perdido.")
                        Me.txt_frase.Text = palabra
                        bloquearLetras()
                    End If
                End If
                If Me.txt_frase.Text = Me.palabra AndAlso fallos <> 6 Then
                    MsgBox("Felicidades, has acertado la palabra.")
                    bloquearLetras()
                End If
            Case "W"
                For i = 0 To palabra.Length - 1
                    If palabra.Chars(i) = "W" Then
                        asteriscos.Insert(i, "W")
                        asteriscos.Remove(i + 1, 1)
                        hayletra = True
                    End If
                Next

                Me.txt_frase.Text = asteriscos.ToString

                If hayletra = False Then
                    fallos += 1
                    Me.pbx_horca.Image = horca(fallos)
                    If fallos = 6 Then
                        MsgBox("Has perdido.")
                        Me.txt_frase.Text = palabra
                        bloquearLetras()
                    End If
                End If
                If Me.txt_frase.Text = Me.palabra AndAlso fallos <> 6 Then
                    MsgBox("Felicidades, has acertado la palabra.")
                    bloquearLetras()
                End If
            Case "X"
                For i = 0 To palabra.Length - 1
                    If palabra.Chars(i) = "X" Then
                        asteriscos.Insert(i, "X")
                        asteriscos.Remove(i + 1, 1)
                        hayletra = True
                    End If
                Next

                Me.txt_frase.Text = asteriscos.ToString

                If hayletra = False Then
                    fallos += 1
                    Me.pbx_horca.Image = horca(fallos)
                    If fallos = 6 Then
                        MsgBox("Has perdido.")
                        Me.txt_frase.Text = palabra
                        bloquearLetras()
                    End If
                End If
                If Me.txt_frase.Text = Me.palabra AndAlso fallos <> 6 Then
                    MsgBox("Felicidades, has acertado la palabra.")
                    bloquearLetras()
                End If
            Case "Y"
                For i = 0 To palabra.Length - 1
                    If palabra.Chars(i) = "Y" Then
                        asteriscos.Insert(i, "Y")
                        asteriscos.Remove(i + 1, 1)
                        hayletra = True
                    End If
                Next

                Me.txt_frase.Text = asteriscos.ToString

                If hayletra = False Then
                    fallos += 1
                    Me.pbx_horca.Image = horca(fallos)
                    If fallos = 6 Then
                        MsgBox("Has perdido.")
                        Me.txt_frase.Text = palabra
                        bloquearLetras()
                    End If
                End If
                If Me.txt_frase.Text = Me.palabra AndAlso fallos <> 6 Then
                    MsgBox("Felicidades, has acertado la palabra.")
                    bloquearLetras()
                End If
            Case "Z"
                For i = 0 To palabra.Length - 1
                    If palabra.Chars(i) = "Z" Then
                        asteriscos.Insert(i, "Z")
                        asteriscos.Remove(i + 1, 1)
                        hayletra = True
                    End If
                Next

                Me.txt_frase.Text = asteriscos.ToString

                If hayletra = False Then
                    fallos += 1
                    Me.pbx_horca.Image = horca(fallos)
                    If fallos = 6 Then
                        MsgBox("Has perdido.")
                        Me.txt_frase.Text = palabra
                        bloquearLetras()
                    End If
                End If
                If Me.txt_frase.Text = Me.palabra AndAlso fallos <> 6 Then
                    MsgBox("Felicidades, has acertado la palabra.")
                    bloquearLetras()
                End If
        End Select
    End Sub
End Class