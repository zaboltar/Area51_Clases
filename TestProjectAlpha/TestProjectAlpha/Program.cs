using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectAlpha {
    class Program {
        static void Main(string[] args) {
            string hiddenWord = Console.ReadLine();
            string shownWord = "";

            Console.Clear();

            for (int i = 0, i < hiddenWord.Length, i++) {
                shownWord += '*'
            }

           Console.WriteLine(shownWord);
            
        }
    }
}
