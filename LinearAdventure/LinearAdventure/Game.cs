using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearAdventure {
    class Game {

        bool isDone;
        string [] enunciadoHistoria;
        int storyProgression = 1;
        string [] opciones;

        public void Run() {
            Initialize();

            while (!isDone) {
                UpdateDraw();
            }
        }

        void Initialize() {

            enunciadoHistoria = new string[400];
            opciones = new string[400];

            enunciadoHistoria[0] = @"Tomaste una mala decision y has perdido la Línea de la Victoria.
             ___          
            /   \\        
       /\\ | . . \\       
     ////\\|     ||       
   ////   \\ ___//\       
  ///      \\      \      
 ///       |\\      |     
//         | \\  \   \    
/          |  \\  \   \   
           |   \\ /   /   
           |    \/   /    
           |     \\/|     
           |      \\|     
           |       \\     
           |        |     
           |_________\    
     from Dustin Slater";

            enunciadoHistoria[1] = "Has entrado a la taberna. \n1. Pedir cerveza. \n2. Buscar problemas.";
            opciones[1] = "1";
            enunciadoHistoria[2] = @"Pides una pinta de cerveza. Unos borrachos empiezan a pelear.

 .   *   ..  . *  *
*  * @()Ooc()*   o  .
   (Q@*0CG*O()  ___
  |\_________/|/ _ \
  |  |  |  |  | / | |
  |  |  |  |  | | | |
  |  |  |  |  | | | |
  |  |  |  |  | | | |
  |  |  |  |  | | | |
  |  |  |  |  | \_| |
  |  |  |  |  |\___/  by: Elissa Potier
  |\_|__|__|_/|       
   \_________/

1. Ignorarlo.
2. Entrometerse.";
            opciones[2] = "1";
            enunciadoHistoria[3] = "La violencia empieza a viralizarse en el local \n1. Seguir Tomando. \n2. Buscar otro lugar.";
            opciones[3] = "2";
            enunciadoHistoria[4] = @"Sales a una callejuela con diversos locales. 

~         ~~          __
       _T      .,,.    ~--~ ^^
 ^^   // \                    ~
      ][O]    ^^      ,-~ ~
   /''-I_I         _II____
__/_  /   \ ______/ ''   /'\_,__
  | II--'''' \,--:--..,_/,.-{ },
; '/__\,.--';|   |[] .-.| O{ _ }
:' |  | []  -|   ''--:.;[,.'\,/
'  |[]|,.--'' '',   ''-,.    |
  ..    ..-''    ;       ''. '

1. Ir al templo de caníbales.
2. Ir al cruce de caminos.";

            opciones[4] = "2";
            enunciadoHistoria[5] = "Hay dos caminos en el cruce. \n1. Hacia Pueblo Sangriento.  \n2. Hacia Pueblo Linear.";
            opciones[5] = "2";
            enunciadoHistoria[6] = "Bienvenido a pueblo linear. \n1. Seguir la línea del camino. \n2. Circular la plaza central.";
            opciones[6] = "1";            
            enunciadoHistoria[7] = @"El camino conduce a un lejano volcán.
                                               _
                 ___                          (_)
               _/XXX\
_             /XXXXXX\_                                    __
X\__    __   /X XXXX XX\                          _       /XX\__      ___
    \__/  \_/__       \ \                       _/X\__   /XX XXX\____/XXX\
  \  ___   \/  \_      \ \               __   _/      \_/  _/  -   __  -  \__/
 ___/   \__/   \ \__     \\__           /  \_//  _ _ \  \     __  /  \____//
/  __    \  /     \ \_   _//_\___     _/    //           \___/  \/     __/
__/_______\________\__\_/________\_ _/_____/_____________/_______\____/_______
                                  /|\
                                 / | \
                                /  |  \
                               /   |   \
                              /    |    \
                 ------      /     |     \
                 |    |     /      |      \
                 |    |    /       |       \
                 ------   /        |        \
                   |     /         |         \
1. Leer el letrero.
2. Ignorar el letrero.";

            opciones[7] = "1";            
            enunciadoHistoria[8] = @"NO IR AL VOLCÁN 

 ____________________
/         NO         \
!        IR AL       !
!       VOLCÁN !!!   !
\____________________/
         !  !
         !  !
         L_ !
        / _)!
       / /__L
 _____/ (____)
        (____)
 _____  (____)
      \_(____)
         !  !
         !  !
         \__/   

1. Oblígame, Prro. Ir al volcán.
2. Regresar al camino linear.";

            opciones[8] = "2";           
            enunciadoHistoria[9] = "Al volver, notas un importante objeto. \n1. Inspeccionar el importante objeto. \n2. Bah, no es importante.";
            opciones[9] = "1";            
            enunciadoHistoria[10] = "Felicidades. Has encontrado un arma. \n1. Observar detenidamente. \n2. Ignorar. \n3. Reiniciar Partida.";
            opciones[10] = "1";            
            enunciadoHistoria[11] = @"El arma es una espada larga de acero. 

      /|
     |\|
     |||
     |||
     |||
     |||
     |||
     |||
  ~-[{o}]-~
     |/|
     |/|
     `0'    

1. Elevar a los cielos y calcular su poder.
2. Probar el filo con el cuello.";

            opciones[11] = "1";            
            enunciadoHistoria[12] = "Mientras sopesas su gran poder un grito se oye a lo lejos. \n1. Huir despavorido de modo sospechoso. \n2. Mantener la postura y esperar.";
            opciones[12] = "2";            
            enunciadoHistoria[13] = @"Una anciana te confunde con un paladín y reclama que salves a su gato.

 _._     _,-'´´`-._
(,-.`._,'(       |\`-/|
    `-.-' \ )-`( , o o)
          `-    \`_`¨'-

1. Negarse rotundamente.
2. Ayudarla noblemente.";

            opciones[13] = "2";            
            enunciadoHistoria[14] = @"Su gato está en lo alto de una torre.

                                      |>>>
                                      |
                                  _  _|_  _
                                 |;|_|;|_|;|
                                 \\.    .  /
                                  \\:  .  /
                                   ||:   |
                                   ||:.  |
                                   ||:  .|
                                   ||:   |       \,/
                                   ||: , |            /`\
                                   ||:   |
                                   ||: . |
    __                            _||_   |
`~    '--~~__            __ ----~    ~`---,              ___
            ~---__ ,--~'                  ~~----_____-~'   `~----~~

1. Trepar por los muros.
2. Usar las escaleras.";

            opciones[14] = "2";            
            enunciadoHistoria[15] = @"Desde una ventana logras alcanzar al gato.

Art by Marcin Glinski
                   .-.
                  / /
                 / |
   |\     ._ ,-´´  `.
   | |,,_/  7        ;
 `;=     ,=(     ,  /
  |`q  q  ` |    \_,|
 .=; <> _ ; /  ,/'/ |
';|\,j_ \;=\ ,/   `-'
    `--'_|\  )
   ,' | /  ;'
  (,,/ (,,/      

1. Extenderle el brazo amigablemente.
2. Asustarlo con gritos demoníacos.";

            opciones[15] = "1";            
            enunciadoHistoria[16] = @"Felicidades la anciana te ha recompensado con 1 moneda de oro.

          __-----__
     ..;;;--'~~~`--;;;..
   /;-~IN LINE WE TRUST~-.\
  //      ,;;;;;;;;      \\
.//      ;;;;;    \       \\
||       ;;;;(   /.|       ||
||       ;;;;;;;   _\      ||
||       ';;  ;;;;=        ||
||AREA 51 | ''\;;;;;;      ||
 \\     ,| '\  '|><| 2018 //
  \\   |     |      \   //
   `;.,|.    |      '\.-'/
     ~~;;;,._|___.,-;;;~'
         ''=--'

1. Agradecerle.
2. Amenazarla por más.";

            opciones[16] = "1";            
            enunciadoHistoria[17] = "Un mercader errante ha visto tus proezas y te ofrece algo único. \n1. Mandarlo al infierno. \n2. Atender su oferta.";
            opciones[17] = "2";            
            enunciadoHistoria[18] = "Por una moneda, puede darte una armadura. \n1. Clavarle la espada y robarle. \n2. Aceptar su oferta.";
            opciones[18] = "2";            
            enunciadoHistoria[19] = @"Ahora estas cubierto de placas de metal.
  __  __
 )HH\/HH(
|XXXXXXXX|
|HHHHHHHH|
|XXXXXXXX|
 ||||||||

1. Ir a nadar.
2. Buscar Aventuras.";

            opciones[19] = "2";            
            enunciadoHistoria[20] = "No hay aventuras disponibles, pero siempre queda el pillaje. \n1. Incendiar la aldea. \n2. Esperar un momento oportuno.";
            opciones[20] = "2";            
            enunciadoHistoria[21] = "Luego de descansar y desayunar apropiadamente, estás listo. \n1. Mantener la línea. \n2. Poner punto final a la aventura.";
            opciones[21] = "1";            
            enunciadoHistoria[22] = @"Un sacerdote del pueblo ha visto el potencial en ti.
    _     _
   /.\   ( )
  / T \   \\
  \,-./    \
  ( oo)  /\{}
   \_=/ /  \ \
  //  \/ ,'   \
 ||    |'      \
 ||    |        \
 m|    |
  |____|
    `-`-

1. Pedir la bendición.";

            opciones[22] = "1";            
            enunciadoHistoria[23] = "Felicidades. Ahora eres conocido como el paladín de la línea. \n1. Ganar el juego. \n2. Reiniciar aventura.";
            opciones[23] = "1";
            enunciadoHistoria[24] = @"Felicidades. Has ganado el juego. 
Habrán memes sobre tus hazañas lineares.

     _______________
    |@@@@| 666 |####|
    |@@@@|     |####|
    |@@@@|     |####|
    \@@@@|     |####/
     \@@@|     |###/
      `@@|_____|##'
           (O)
        .-'''''-.
      .'  * * *  `.
     :  *       *  :
    : ~  LINEAR   ~ :
    : ~ ADVENTURE ~ :
     :  *       *  :
jgs   `.  * * *  .'
        `-.....-'

 1. Continuar aventura.
 2. Perder en el último segundo.";

            opciones[24] = "1";

            enunciadoHistoria[25] = @"Un rey muy poderoso requiere de tu presencia.

Art by Joan Stark
       _.+._
     (^\/^\/^)
      \@*@*@/
      {_____}

1. Asistir sin dudar.
2. Mandar al demonio al rey; VIVA LA REVOLUCIÖN!";

            opciones[25] = "1";
            enunciadoHistoria[26] = "El rey desea probar tus habilidades. Te someterá a 3 pruebas \n1. Comenzar pruebas \n2. Cometer regicidio.";
            opciones[26] = "1"; 
            enunciadoHistoria[27] = @"En primer lugar, debes demostrar tu fuerza. 

             X
      |_O   / \  O_\
        |`-/   \-'\
        |\       / |
       /  |      |  \

1. Retar a su mejor guerrero.
2. Cargar a la reina en peso.";

            opciones[27] = "1";
            enunciadoHistoria[28] = @"Lograste vencerlo, ahora un anciano de su concejo te pregunta:
Cuál de estos nombres NO es un filosofo?

,         ,
|\\\\ ////|
| \\\V/// |
|  |~~~|  |
|  |===|  |
|  |e  |  |
|  | g |  |
 \ |  c! /
  \|===|/
   '---'

1. Aristóteles.
2. Hegel.
3. El gordo Cassaretto.";
            opciones[28] = "3"; 
            enunciadoHistoria[29] = "Ciertamente eres de un saber adecuado. Debes prepararte para la prueba final. \n1. Oblígame, Prro!  \n2. Prepararse.";
            opciones[29] = "2";
            enunciadoHistoria[30] = "Debes ir a un viejo castillo y rescatar a la princesa. \n1. Pos ni modo. \n2. Romper la línea del compromiso.";
            opciones[30] = "1"; 
            enunciadoHistoria[31] = @"Un arquero espera para combatirte.

                   .;;,.
                  ; '. ;\ \//
                 \|a (a|7 \//
                 j| ..  | ||/
                //'.--.')\-,/
              .-||- '' ||/  `-.
             ;  | \ |/ |/ L.  ,|
             f\ |\| Y  || \ '._\
            j | \|     (| |   | |
           |  L_\         L.__: |
            \(  '-.,-,    |   ; |Shanaka Dias
             |'-.'.L_rr>  f--f  |
.-=,,______,--------- J-. ;  ;__ 
   ``.-,__   |  |      h  |  f  '--.__
       `--;;--,_       h  f-j   |   __;==-.
            / `-''-,,__J,'  \_..--:'-'     '
            | |    `' --L7//'-'`|
            | ,     ||  h    |  (
            | ;     | \ J    j   |
            | L__   | |  L_.'    |

1. Quedarse parado.
2. Aniquilarlo heroicamente.";

            opciones[31] = "2";
            enunciadoHistoria[32] = @"Llegas al castillo. Es una bella fortaleza. 

               T~~
               |
              /¨\
      T~~     |'| T~~
  T~~ |    T~ WWWW|
  |  /´\   |  |  |/\T~~
 /´\ WWW  /´\ |' |WW|
WWWWW/\| /   \|'/\|/´\
|   /__\/]WWW[\/__\WWWW
|   WWWW'|I_I|'WWWW'  |
|   |' |/  -  \|' |'  |
|'  |  |LI=H=LI|' |   |
|   |' | |[_]| |  |'  |
|   |  |_|###|_|  |   |
'---'--'-/___\-'--'---'

1. Tocar la puerta.
2. Gritar insolencias para ser atendido. ";

            opciones[32] = "1"; 
            enunciadoHistoria[33] = "Una monja te deja pasar y te pregunta tus intenciones. \n1. Salvar a la princesa. \n2. Asesinar a la princesa.";
            opciones[33] = "1";
            enunciadoHistoria[34] = @"Para salvar a la princesa, debes vencer al Conde del Tríangulo.

Art by llizard
             /
       /_O  X
        /`-/ \   O_\
       | \    \-'_\
      /  /       \ |_

1. Aplicar el teorema de Pitágoras.";

            opciones[34] = "1"; 
            enunciadoHistoria[35] = @"Felicidades, has rescatado a la princesa.
              ___
            ,'/|\`.
           :,',^.`.:
           |,'_ _`.|
           |:`*)*';|
           ;|\ _ /|:
        ,-(||.)-(.||)-.
       |'  \|(\ /)|/  `|
       `:. (  `|'  ) .;'
        | : \ ,^. / : |
       ,'`'\-`.._/_/; |
       `:=..-...______;_
       \`\ \'`. .-'\`: /
       ;' \ \/|  \_,\ `:
      /  / \ \;   \  \ .\
     / //  _) `.'--`-----,

1. Pedirla como recompensa.
2. Regresar al Rey.";

            opciones[35] = "2";
            enunciadoHistoria[36] = "El rey está satisfecho con los resultados. Te ofrece una misión. \n1. Atender";
            opciones[36] = "1"; 
            enunciadoHistoria[37] = "Debes buscar 3 arañas. Matarlas y regresar. \n1. Andate bien lejos, Rey Abusivo.  \n2. Cumplir la misión real.";
            opciones[37] = "2";
            enunciadoHistoria[38] = @"La primera araña está en un sótano. 
 
 ||  ||  
 \\()// 
//(__)\\
||    ||

1. Matarla.
2. Perdonarle la vida.";
            opciones[38] = "1"; 
            enunciadoHistoria[39] = @"La segunda araña está en un viejo templo.

  / _ \
\_\(_)/_/
 _//¨\\_  Max
  /   \

1. Matarla
2. Dejarse morder por ella. ";

            opciones[39] = "1";
            enunciadoHistoria[40] = @"La última araña está escondida.
1.Encontrarla y matarla.
2.Perder la partida. ";

            opciones[40] = "1"; 
            enunciadoHistoria[41] = "Bien hecho. Al regresar, el rey está complacido. \n1. Continuar.";
            opciones[41] = "1";
            enunciadoHistoria[42] = @"Con las tres arañas, un mago realiza una poción.

      )  (
     (   ) )
      ) ( (
 mrf_______)_
   '---------|  
   |/\/\/\/\/|
   ./\/\/\/\/|
   '_________'
    '-------'

1. Esperar a que termine.
2. Beberla incompleta.";

            opciones[42] = "1"; 
            enunciadoHistoria[43] = @"El rey te pide que lleves esa poción al bosque encantado. 

           (                 ,&&&.
            )                .,.&&
           (  (              \=__/
               )             ,'-'.
         (    (  ,,      _.__|/ /|
          ) /\ -((------((_|___/ |
        (  // | (`'      ((  `'--|
      _ -.;_/ \\--._      \\ \-._/.
     (_;-// | \ \-'.\    <_,\_\`--'|
     ( `.__ _  ___,')      <_,-'__,'
jrei  `'(_ )_)(_)_)'

1. Y luego qué? ";

            opciones[43] = "1";
            enunciadoHistoria[44] = "Debes buscar el arbol más hermoso. Usar la poción en él. \n1. Aceptar. \n2. Hacer un reclamo ecologista.";
            opciones[44] = "1"; 
            enunciadoHistoria[45] = "Tienes la misión.... a donde ir ? \n1. Al volcán.  \n2. Al bosque encantado. \n3. Al congreso de la república.  ";
            opciones[45] = "2";
            enunciadoHistoria[46] = "Estás en el bosque encantado, que buscas? \n1. El árbol más hermoso. \n2. El árbol mas frondoso.";
            opciones[46] = "1"; 
            enunciadoHistoria[47] = "Lo has encontrado ... Qué hacer? \n1. Verter la poción.  \n2. Tomarse la poción.";
            opciones[47] = "1";
            enunciadoHistoria[48] = @"Al hacerlo, el árbol se convierte en un sapo.

         o  o   o  o
         |\/ \^/ \/|
         |,-------.|
       ,-.(|)   (|),-.
       \_*._ ' '_.* _/
        /`-.`--' .-'\
   ,--./    `---'    \,--.
   \   |(  )     (  )|   /
hjw \  | ||       || |  /
`97  \ | /|\     /|\ | /
     /  \-._     _,-/  \
    //| \\  `---'  // |\\
   /,-.,-.\       /,-.,-.\
  o   o   o      o   o    o

1. Tomar al sapo y regresar.  
2. Lamer al sapo antes comerlo.";

            opciones[48] = "1"; 
            enunciadoHistoria[49] = "Ante el rey, presentas al sapo. \n1. Continuar.";
            opciones[49] = "1";
            enunciadoHistoria[50] = "Este es un viejo amigo, un rey lejano, pero está bajo un hechizo. \n1. Preguntar cómo deshacer el embrujo. \n2. Hacerse el loco y retirarse silenciosamente.";
            opciones[50] = "1"; 
            enunciadoHistoria[51] = "Para revertir la magia, hay que asesinar a la bruja Cuadrada. \n1. Preguntar por su ubicación. \n2. Negarse, las brujas tienen sentimientos. ";
            opciones[51] = "1";




            // hasta aquí la 1era entrega....a continuación: la línea se extiende.





            enunciadoHistoria[52] = "La bruja habita en pueblo Tetralinear. \n1. Ir.  \n2. Finalizar aventura.";
            opciones[52] = "1"; 
            enunciadoHistoria[53] = "Bienvenido al lejano pueblo Tetralinear, Hogar de la bruja Cuadrada \n1. Circular la plaza central. \n2. Triangular las torres de vigilancia. \n3. Cuadrar la carreta con los caballos.";
            opciones[53] = "3";
            enunciadoHistoria[54] = "En el establo un sujeto se admira por tu gallarda presencia. \n1. Asesinarlo. \n2. Saludarlo cordialmente.";
            opciones[54] = "2"; 
            enunciadoHistoria[55] = "El extraño te pregunta por tu visita al pueblo Tetralinear. \n1. Vengo de compras.  \n2. Vengo de vacaciones. \n3. Vengo en una importante misión.";
            opciones[55] = "3";
            enunciadoHistoria[56] = "El extraño se entusiasma. Te advierte que tengas cuidado con la bruja del pueblo. \n1. Preguntar a qué se refiere.";
            opciones[56] = "1"; 
            enunciadoHistoria[57] = "Hay una bruja que atormenta aldeanos; incluso se dice que hechizó al rey y lo reemplazó. \n1. Clavarle la espada antes que devele información esencial.  \n2. Seguir escuchando.";
            opciones[57] = "2";
            enunciadoHistoria[58] = "La bruja gusta disfrazarse de niña ciega y pedir ayuda en la taberna. \n1. Agradecerle y partir a la taberna. \n2. Agradecerle y partirlo a la mitad. \n3. Agradecerle e ir caminando al volcán lejano.";
            opciones[58] = "1";
            enunciadoHistoria[59] = "La taberna parece un lugar muy tranquilo. \n1. Pedir una cerveza. \n2. Buscar problemas injustificadamente.";
            opciones[59] = "1";
            enunciadoHistoria[60] = "Unos orcos pelean entre sí. La violencia empieza a viralizarse. \n1. Un momento...ya he estado en una situación similar. \n2. Reventar la pinta de cerveza en la cabeza del cantinero.";
            opciones[60] = "1";
            enunciadoHistoria[61] = "Mientras te envuelves en los recuerdos de un pasado a-cíclico una vieja se acerca a pedirte ayuda. \n1. Olvidar misión y ayudarla. \n2. Disculparse y prometer ayuda luego.";
            opciones[61] = "2";
            enunciadoHistoria[62] = "La vieja se retira triste y se acerca una niña aparentemente ciega. \n1. Empuñar la espada. \n2. Salir a hacer yoga.";
            opciones[62] = "1";
            enunciadoHistoria[63] = "La niña ciega te ha pedido ayuda. \n1. Ayudarla ciegamente. \n2. Atacar a la niña ciega.";
            opciones[63] = "2";
            enunciadoHistoria[64] = "De un espadazo la regresas a su forma de Bruja. \n1. Dejarse enamorar por la bruja y rendirse. \n2. Convertir a la bruja Cuadrada en dos triángulos iguales.";
            opciones[64] = "2";
            enunciadoHistoria[65] = "La bruja cuadrada ahora consiste en dos triángulos \n1. Aplicar el teorema de Pitágoras e integrar ambos triángulos.";
            opciones[65] = "1";
            enunciadoHistoria[66] = "La bruja ha sido debilitada y se rinde. \n1. Exhortarla a deshacer el hechizo del rey sapo. \n2. Pedir que te convierta en dragón.";
            opciones[66] = "1";
            enunciadoHistoria[67] = "La bruja accede, y se alivia de que no seas otro loquito que busca ser un dragón. \n1. Si, eso nunca resulta bien.";
            opciones[67] = "1";
            enunciadoHistoria[68] = "Felicidades, has derrotado a la bruja y has deshecho su maleficio. \n1. Volver triunfante a pueblo Linear. \n2. Perder el sentido de la dirección de la vida y arrebatarse el aliento.";
            opciones[68] = "1";
            enunciadoHistoria[69] = "Felicidades, te has sobrepuesto a la angustia existencial \n1. Ok, el tormento humano se manifestará de otras formas.";
            opciones[69] = "1";
            enunciadoHistoria[70] = "Felicidades, te has vuelto consciente de la condición humana. \n1. Trascender este juego y dejar de jugar. \n2. Trascender este juego y continuar la aventura.";
            opciones[70] = "2";
            enunciadoHistoria[71] = "Bienvenido a Pueblo Linear, eres recibido como un héroe. \n1. Saludar con gracia.  \n2. Plottwist: deschavetarse y asesinar inocentes.";
            opciones[71] = "1";
            enunciadoHistoria[72] = "Justo antes de llegar a la sala del trono, la vieja del pueblo Tetralinear te alcanza \n1. Oh.. olvidé la promesa.";
            opciones[72] = "1";
            enunciadoHistoria[73] = "La pobre vieja interpone la dignidad de la palabra por sobre la solemnidad de atender al mismísimo Rey. \n1. No puedes colocarme en una situación tan compleja cuando se ofrecen opciones limitadas.";
            opciones[73] = "1";
            enunciadoHistoria[74] = "La vieja se limita a rogarte de que te encargues de la malvada bruja Cuadrada \n1. Olvídalo, afronta tus propios problemas. \n2. La bruja Cuadrada ya no es un problema!";
            opciones[74] = "2";
            enunciadoHistoria[75] = "La anciana llora de alegría y te deja paso a la sala del trono. \n1. Entrar ceremoniosamente como un paladín. \n2. Empezar todo el juego desde el inicio.";
            opciones[75] = "1";
            enunciadoHistoria[76] = "Ambos reyes te saludan, has demostrado gran sagacidad y noble discernimiento. \n1.Solo tuve que presionar botones. \n2. Matar a ambos reyes y hacerse de dos pueblos.";
            opciones[76] = "1";
            enunciadoHistoria[77] = "Tu bondad y humildad admiran al rey de pueblo Tetralinear. Te ofrece casarse con su hija, la princesa. \n1. No estaba en mis planes, pero acepto. \n2. Si es bonita, podría aceptar, se parece a ud.?";
            opciones[77] = "1";
            enunciadoHistoria[78] = "Ahora serás conocido como el Paladín de la Línea, heredero al trono de pueblo Tetralinear. \n1. Organizar un banquete.";
            opciones[78] = "1";
            enunciadoHistoria[79] = "Pocas celebraciones han tenido tanta pompa y exhuberancia como el festejo de sus nupcias. \n1. Confesar que sólo eres un aldeano que se encontró una espada. \n2. Servirse postre! ";
            opciones[79] = "2";
            enunciadoHistoria[80] = "El postre está delicioso ... un sirviente te ofrece más. \n1. Aceptar dos o tres porciones más \n2. No aceptar; hay que mantener la línea.";
            opciones[80] = "2";
            enunciadoHistoria[81] = "Felicidades ... has completado la aventura linear y has formado una familia con sangre real. \n1. Yeeee.";
            opciones[81] = "1";
            enunciadoHistoria[82] = "Gracias por llegar tan lejos. Muchos beneficiados recordarán para siempre tus bondadosos actos. \n1. Finalizar.";
            opciones[82] = "6";









            Console.WriteLine(@"Bienvenido a una Aventura Linear

Presiona ENTER para continuar
   
    _____________________
   /  __________________()
  /  /|_________________ 
 /  /_/________________()
/______________________
|_____________________()   

Escher art by Michael Naylor

StoryLine by Cleto Thar

Web Adaptation by Esen Espinoza


");
            Console.ReadLine();
            Console.Clear();
        }

        void UpdateDraw() {
            string choice;

            Console.WriteLine(enunciadoHistoria[storyProgression]);
            
            choice = Console.ReadLine();

            if (choice == opciones[storyProgression]) {
                storyProgression++;
            } else {
                storyProgression = 0;
                isDone = true;
                Console.Clear();
                Console.WriteLine(enunciadoHistoria[storyProgression]);
            }

            Console.ReadKey();
        }


        
        
    }
}
