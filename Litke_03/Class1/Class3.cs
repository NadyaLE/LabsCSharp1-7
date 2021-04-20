using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Process
{
    public class Class3
    {
        private static Char[] main_string;
        private static int width = 0;
        private static int height = 0;
        private static String input_string;
        private static String output_string;
        public static bool Exit = false;
        static object locker = new object();

        public static void Time_Size()
        {
            while (true) {
                String size_time;
                DateTime Time = DateTime.Now;
                if (width != Console.WindowWidth || height != Console.WindowHeight) {
                    if (Console.WindowHeight > 0 && Console.WindowWidth > 0) Console.Clear();
                    Console.CursorVisible = false;
                    width = Console.WindowWidth;
                    height = Console.WindowHeight;
                    if (width > 15) {
                        main_string = new char[width];
                        size_time = "[" + width + " x " + height + "]";
                        for (int i = 0; i < size_time.Length; i++) {
                            main_string[i] = size_time[i];
                        }
                    }
                }
                main_string[width - 8] = (char)('0' + Time.Hour / 10);
                main_string[width - 7] = (char)('0' + Time.Hour % 10);
                main_string[width - 6] = ':';
                main_string[width - 5] = (char)('0' + Time.Minute / 10);
                main_string[width - 4] = (char)('0' + Time.Minute % 10);
                main_string[width - 3] = ':';
                main_string[width - 2] = (char)('0' + Time.Second / 10);
                main_string[width - 1] = (char)('0' + Time.Second % 10);

                if (width >= 20 && height != 0) {
                    lock (locker) {
                        Console.SetCursorPosition(0, 0);
                        Console.Write(main_string);
                    }
                }
                System.Threading.Thread.Sleep(100);
            }
        }

        public static void Input()
        {
            Console.TreatControlCAsInput = true;
            ConsoleKeyInfo Key;

            while (true) {
                while (Console.KeyAvailable) {
                    Key = Console.ReadKey(true);
                    if (Key.Key == ConsoleKey.Escape) Exit = true;
                    else 
                        input_string += Key.KeyChar;
                        output_string = input_string;
                        if (input_string.Length > 9) {
                            string sort = output_string.Substring(output_string.Length - 10);
                            output_string = output_string.Remove(output_string.Length - 10);
                            for (int i = sort.Length - 1; i >= 0; i--) {
                             output_string += sort[i];
                            }
                        }
                    }
                
                    System.Threading.Thread.Sleep(50);
            }
        }

        private static void WriteString(String tmp)
        {
            lock (locker) {
                if (tmp != null && (Console.WindowHeight - 1) / 2 * Console.WindowWidth + 1 <= tmp.Length) {
                    Console.Write(tmp.Substring(tmp.Length - ((Console.WindowHeight - 1) / 2 * Console.WindowWidth)));
                }
                else Console.Write(tmp);
            }
        }

        public static void PrintStrings()
        {
            while (true) {
                if (Console.WindowWidth >= 1 && Console.WindowHeight >= 3 && input_string != null) {
                    lock (locker) {
                        Console.SetCursorPosition(0, 1);
                        WriteString(output_string);
                        Console.SetCursorPosition(0, (height / 2) + 1);
                        WriteString(input_string);
                    }
                }
                System.Threading.Thread.Sleep(50);
            }
        }
    }
}
