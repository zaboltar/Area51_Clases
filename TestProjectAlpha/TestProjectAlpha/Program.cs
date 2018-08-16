using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectAlpha {
    class Program {
        static void Main(string[] args) {

            // palabra a advinar & palabra a mostrar
            string hiddenWord = Console.ReadLine();
            string shownWord = "";
            int attemptsLeft = 5;

            // Manejo de Arrays
            int[] numbers = new int [4];
            numbers[2] = 7;
            char letter = hiddenWord[0];
            
            // limpiamos pantalla
            Console.Clear();
            
            // llamado a un for, por cada letra de palabra a adivinar agrega un * a la palabra mostrada
            for (int i = 0; i < hiddenWord.Length; i++) {
                shownWord += '*';
            } 
            
            // Palabra a mostrar en consola
           Console.WriteLine(shownWord);

            // Loop
            while (shownWord != hiddenWord && attemptsLeft > 0)
            {
                // Update
                string attempt = Console.ReadLine();
                if (attempt.Length != 1)
                {
                    if (attempt == hiddenWord)
                    {
                        shownWord = hiddenWord;
                    }
                    else
                    {
                        if (attempt != string.Empty)
                        {
                            attemptsLeft--;
                        }
                        
                    }
                } else
                {
                  if (hiddenWord.Contains (attempt))
                    {
                        Console.WriteLine("Acertaste!");
                        string tempWord = "";
                        for(int i =0; i<hiddenWord.Length; i++)
                        {
                            if (hiddenWord[i] == attempt[0])
                            {
                                tempWord += hiddenWord[i];
                            }else
                            {
                                tempWord += shownWord[i];
                            }
                        }
                        shownWord = tempWord;
                    }else
                    {
                        attemptsLeft--;
                    }
                }
                // draw
                Console.Clear();
                Console.WriteLine("Te quedan " + attemptsLeft + " intentos");
                Console.WriteLine(shownWord);
            }

          
            
        }
    }
}
