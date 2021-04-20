using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processing
{
    public class Process
    {
        private static int width = 0;
        private static int height = 0;
        private static String size_time;
        private static String input_string;
        private static String output_string;

        public static void Print()
        {
            DateTime Time = DateTime.Now;
            if (width != Console.WindowWidth || height != Console.WindowHeight) {
                Console.CursorVisible = false;
                width = Console.WindowWidth;
                height = Console.WindowHeight;
                size_time = "[" + width + " x " + height + "]" + "  Ввод/Вывод: [" + width + "x" + (height - 1)/2 +"]";
                int length = size_time.Length;
                for (int i = 0; i < (width - length); i++) {
                    size_time += " ";
                }
                if (Console.WindowWidth > 0 && Console.WindowHeight > 0) Console.Clear();
                if (Console.WindowWidth > 0 && Console.WindowHeight > 0) PrintStrings();
            }
            Char[] main_string = size_time.ToCharArray();
            main_string[width - 8] = (char)('0' + Time.Hour / 10);
            main_string[width - 7] = (char)('0' + Time.Hour % 10);
            main_string[width - 6] = ':';
            main_string[width - 5] = (char)('0' + Time.Minute / 10);
            main_string[width - 4] = (char)('0' + Time.Minute % 10);
            main_string[width - 3] = ':';
            main_string[width - 2] = (char)('0' + Time.Second / 10);
            main_string[width - 1] = (char)('0' + Time.Second % 10);
            size_time = new string(main_string);
            if (Console.WindowWidth != 0 && Console.WindowHeight != 0) {
                Console.SetCursorPosition(0, 0);
                Console.Write(size_time);
                PrintStrings();
            }
        }
        public static void InputChar(char a)
        {
            input_string += a;
            if (!Char.IsDigit(a)) {
                output_string += a;
            }
        }

        private static void WriteString(String tmp)
        {
            if (tmp != null && (Console.WindowHeight - 1) / 2 * Console.WindowWidth < tmp.Length) {
                Console.Write(tmp.Substring(tmp.Length - ((Console.WindowHeight - 1) / 2 * Console.WindowWidth) + 1));
            }
            else Console.Write(tmp);
        }

        private static void PrintStrings()
        {
            if (Console.WindowWidth >= 1 && Console.WindowHeight >= 3 && input_string != null) {
                Console.SetCursorPosition(0, 1);
                WriteString(output_string);
                if (Console.WindowHeight % 2 == 0) Console.SetCursorPosition(0, Console.WindowHeight / 2);
                else Console.SetCursorPosition(0, Console.WindowHeight / 2 + 1);
                WriteString(input_string);
            }
        }
    }
}


    

