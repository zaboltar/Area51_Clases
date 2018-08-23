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
        string[] opciones;

        public void Run() {
            Initialize();

            while (!isDone) {
                UpdateDraw();
            }
        }

        void Initialize() {

            enunciadoHistoria = new string[4];
            opciones = new string[4];

            enunciadoHistoria[0] = "Tomaste una mala decision y has perdido";
            enunciadoHistoria[1] = "Has entrado a la taberna. \n1. Pedir cerveza. \n2. Buscar problemas.";
            enunciadoHistoria[2] = "Pides cerveza, puedes oir una pelea de orcos. \n1. Ignorarlo. \n2. Entrometerse.";
            enunciadoHistoria[3] = "algo3";

            opciones[1] = "1";
                //agregar

            
            Console.WriteLine("Bienvenido a una aventura linear \nPresiona Enter para iniciar");
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
