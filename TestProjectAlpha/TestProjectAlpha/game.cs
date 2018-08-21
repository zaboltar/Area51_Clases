using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectAlpha
{
    class game
    {

        bool isDone;
        SingleWordSystem currentWordSystem;
        string message;

        public void Run()
        {
            Initialize();
            while (!isDone)
            {
                Update();
                Draw();
            }


        }
        bool Retry()
        {
            Console.WriteLine(Se acabo el juego, jugar de nuevo? y/n);
            string compare = Console.ReadLine();
            return compare == "y";
        }



        void Initialize ()
        {

            Console.Clear();
            currentWordSystem = new SingleWordSystem();
            Console.Clear();
            currentWordSystem.ShowFieldValues();
            Console.Write("\nPresiona Cualquier tecla para desatar la infinita diversión...");
            Console.ReadKey();
            Console.Clear();
        }

        void Update()
        {
            if (currentWordSystem.EvaluateAttempt(Console.ReadLine()))
            {
                message = "Si";
            } else
            {
                message = "No";
            }
            
            if (currentWordSystem.isDone)
            {
                isDone = Retry();
                if (isDone)
                {
                    Initialize();
                    isDone = false;
                    
                }
            }
          
        }

        void Draw ()
        {
            Console.Clear();
            Console.WriteLine("Tienes " + currentWordSystem.attemptsNumber + "intentos.");
            Console.WriteLine(currentWordSystem.word);
        }

    }
}
