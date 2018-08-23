using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicBoxConsole {
    class Program {
        static void Main(string[] args) {

            int[] fq = { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493};
            int duration = 250;
            while (true) {
                switch (Console.ReadKey().Key) {
                    case ConsoleKey.A:
                        Console.Beep(fq[7], duration);
                        break;
                    case ConsoleKey.S:
                        Console.Beep(fq[9], duration);
                        break;
                    case ConsoleKey.D:
                        Console.Beep(fq[11], duration);
                        break;
                    case ConsoleKey.F:
                        Console.Beep(fq[0], duration);
                        break;
                    case ConsoleKey.G:
                        Console.Beep(fq[2], duration);
                        break;
                    case ConsoleKey.H:
                        Console.Beep(fq[4], duration);
                        break;
                    case ConsoleKey.J:
                        Console.Beep(fq[5], duration);
                        break;

                }
            }
        }
    }
}
