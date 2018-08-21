using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectAlpha
{
    class SingleWordSystem
    {
        string hiddenWord;
        string shownWord;
        public string word { get { return shownWord; } }
        public bool isDone { get { return shownWord == hiddenWord || attemptsLeft <= 0; } }

        int attemptsLeft = 3;
        public int attemptsNumber { get { return attemptsLeft; } }

        public SingleWordSystem()
        {
            CreateWordSystem();
           
            
        }

        public void CreateWordSystem()
        {
            AssignWord();

            Console.WriteLine("Elige un caracter para ocultar la palabra");

            FillShownWithChar(Console.ReadLine()[0]);

        }

        void AssignWord ()
        {
            Console.WriteLine("Elige una palabra:");
            hiddenWord = Console.ReadLine();
        }



        void FillShownWithChar(char shownChar)
        {
            for (int i = 0; i < hiddenWord.Length; i++)
            {
                shownWord += shownChar;
            }
        }

       public bool EvaluateAttempt(string attempt)
        {
            // si es palabra el intento
            if (attempt.Length != 1)
            {
                if (attempt == hiddenWord)
                {
                    shownWord = hiddenWord;
                    return true;
                }
                else 
                {
                    if (attempt != string.Empty)
                    {
                        attemptsLeft--;
                       
                    }
                        return false;
                }
            }
            else // si es letra el intnto
            {
                if (hiddenWord.Contains(attempt))
                {
                    //Console.WriteLine("Acertaste!");
                    string tempWord = "";
                    for (int i = 0; i < hiddenWord.Length; i++)
                    {
                        if (hiddenWord[i] == attempt[0])
                        {
                            tempWord += hiddenWord[i];
                        }
                        else
                        {
                            tempWord += shownWord[i];
                        }
                    }
                    shownWord = tempWord;
                    return true;
                }
                else
                {
                    attemptsLeft--;
                    return false;
                }
                
            }
        }

        public void ShowFieldValues()
        {
            Console.WriteLine("Palabra: " + hiddenWord + "\nMostrar: " + shownWord + ("no se que carajos porq no puedo leer tan rapido" + isDone) );
        }
    }
}
