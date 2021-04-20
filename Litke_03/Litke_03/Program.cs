using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Process;

namespace Litke_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Выводим строку с последними 10­ю символами в обратном порядке (фывап1234567890 – фывап0987654321)";
            Thread Time_Size = new Thread(Process.Class3.Time_Size);
            Thread Input = new Thread(Process.Class3.Input);
            Thread Output = new Thread(Process.Class3.PrintStrings);
            Time_Size.IsBackground = true;
            Input.IsBackground = true;
            Output.IsBackground = true;

            Time_Size.Start();
            Input.Start();
            Output.Start();

            while (true) {
                if (Process.Class3.Exit) {
                    Time_Size.Abort();
                    Input.Abort();
                    Output.Abort();
                    return;
                }
            System.Threading.Thread.Sleep(70);
            }
        }
    }
}