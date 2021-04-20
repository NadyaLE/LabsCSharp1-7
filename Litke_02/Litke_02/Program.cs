using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Litke_02
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.Title = "Выводим только буквы (й1ц2у3к4 – йцук)";
                Processing.Process.Print();
                ConsoleKeyInfo Key;
                Console.TreatControlCAsInput = true;
                if (Console.KeyAvailable) {
                    Key = Console.ReadKey(true);
                    if (Key.Key == ConsoleKey.Escape) return;
                    else if (Key.Key == ConsoleKey.Backspace || Key.Key == ConsoleKey.Enter) System.Threading.Thread.Sleep(0);
                    else Processing.Process.InputChar(Key.KeyChar);
                }
                System.Threading.Thread.Sleep(50);
            }
        }
    }
}





