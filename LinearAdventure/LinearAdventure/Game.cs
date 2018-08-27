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

 _._     _,-'""`-._
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
   |\     ._ ,-""  `.
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
            enunciadoHistoria[24] = "Felicidades. Has ganado el juego. \nHabrán memes sobre tus hazañas lineares. \n1. Continuar aventura. \n2. Perder en el último segundo.";
            opciones[24] = "1";

            enunciadoHistoria[25] = "Un rey muy poderoso requiere de tu presencia. \n1.  \n2. ";
            opciones[25] = "1";

            enunciadoHistoria[26] = "Te someterá a 3 pruebas\n1.  \n2. ";
            opciones[26] = "1"; 
            enunciadoHistoria[27] = "de fuerza \n1.  \n2. ";
            opciones[27] = "1";
            enunciadoHistoria[28] = "de sabiduría \n1.  \n2. ";
            opciones[28] = "1"; 
            enunciadoHistoria[29] = "de nobleza \n1.  \n2. ";
            opciones[29] = "1";
            enunciadoHistoria[30] = "\n1.  \n2. ";
            opciones[30] = "1"; 
            enunciadoHistoria[31] = "\n1.  \n2. ";
            opciones[31] = "1";
            enunciadoHistoria[32] = "\n1.  \n2. ";
            opciones[32] = "1"; 
            enunciadoHistoria[33] = "\n1.  \n2. ";
            opciones[33] = "1";
            enunciadoHistoria[34] = "\n1.  \n2. ";
            opciones[34] = "1"; 
            enunciadoHistoria[35] = "\n1.  \n2. ";
            opciones[35] = "1";
            enunciadoHistoria[36] = "\n1.  \n2. ";
            opciones[36] = "1"; 
            enunciadoHistoria[37] = "\n1.  \n2. ";
            opciones[37] = "1";
            enunciadoHistoria[38] = "\n1.  \n2. ";
            opciones[38] = "1"; 
            enunciadoHistoria[39] = "\n1.  \n2. ";
            opciones[39] = "1";
            enunciadoHistoria[40] = "\n1.  \n2. ";
            opciones[40] = "1"; 
            enunciadoHistoria[41] = "\n1.  \n2. ";
            opciones[41] = "1";
            enunciadoHistoria[42] = "\n1.  \n2. ";
            opciones[42] = "1"; 
            enunciadoHistoria[43] = "\n1.  \n2. ";
            opciones[43] = "1";
            enunciadoHistoria[44] = "\n1.  \n2. ";
            opciones[44] = "1"; 
            enunciadoHistoria[45] = "\n1.  \n2. ";
            opciones[45] = "1";
            enunciadoHistoria[46] = "\n1.  \n2. ";
            opciones[46] = "1"; 
            enunciadoHistoria[47] = "\n1.  \n2. ";
            opciones[47] = "1";
            enunciadoHistoria[48] = "\n1.  \n2. ";
            opciones[48] = "1"; 
            enunciadoHistoria[49] = "\n1.  \n2. ";
            opciones[49] = "1";
            enunciadoHistoria[50] = "\n1.  \n2. ";
            opciones[50] = "1"; 
            enunciadoHistoria[51] = "\n1.  \n2. ";
            opciones[51] = "1";
            enunciadoHistoria[52] = "\n1.  \n2. ";
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
