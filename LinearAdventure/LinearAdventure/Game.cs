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
            enunciadoHistoria[52] = "La bruja habita en pueblo Tetralinear. \n1. Ir.  \n2. Finalizar aventura.";
            opciones[52] = "1"; 
            enunciadoHistoria[53] = "\n1.  \n2. ";
            opciones[53] = "1";
            enunciadoHistoria[54] = "\n1.  \n2. ";
            opciones[54] = "1"; 
            enunciadoHistoria[55] = "\n1.  \n2. ";
            opciones[55] = "1";
            enunciadoHistoria[56] = "\n1.  \n2. ";
            opciones[56] = "1"; 











            Console.WriteLine(@"Bienvenido a una Aventura Linear

Presiona ENTER para continuar
   
    _____________________
   /  __________________()
  /  /|_________________ 
 /  /_/________________()
/______________________
|_____________________()   
Escher art by Michael Naylor

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
