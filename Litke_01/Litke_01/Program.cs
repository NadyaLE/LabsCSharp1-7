
using ClassLibrary;
using System;

namespace Litke_01
{
    class Program {
        public static void Main() {
            while (true) {
                ConsoleKeyInfo c;
                Console.WriteLine();
                Console.WriteLine("Нажмите 1, чтобы ввести значения\nНажмите 2, чтобы вывести результат\nНажмите 3, чтобы выйти");
                c = Console.ReadKey(true);
                switch (c.KeyChar)
                {
                    case '1':
                        Console.Clear();
                        Calculations.inputVariables();
                        break;
                    case '2':
                        Console.Clear();
                        Calculations.calculateAndShowResult();
                        break;
                    case '3':
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Такого варианта нет! Введите заново: ");
                        break;

                }

            }
        }
    }
}
