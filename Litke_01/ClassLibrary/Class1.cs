using System;

namespace ClassLibrary {
    public static class Calculations {
        public static int A;
        public static int B;
        public static int C;
        public static int D;
        public static int E;

        public static double X;
        public static double X1;
        public static double X2;
        public static double X3;
        public static double X4;
        public static bool check;

        public static int inputInt() {
            int number = 0;
            while (!int.TryParse(Console.ReadLine(), out number)) {
                Console.Write("Ошибка! Необходимо целое значение переменной: ");
            }
            return number;
        }

        public static double inputDouble() {
            double num = 0;
            while (!double.TryParse(Console.ReadLine(), out num))
            {
                Console.Write("Ошибка! Необходимо дробное значение переменной(через запятую): ");
            }
            return num;
        }

        public static void inputVariables() {
            Console.Write("Введите А: ");
            A = inputInt();
            Console.Write("Введите В: ");
            B = inputInt();
            Console.Write("Введите C: ");
            C = inputInt();
            Console.Write("Введите D: ");
            D = inputInt();
            Console.Write("Введите E: ");
            E = inputInt();
            while (E == 0) {
                Console.Write("На ноль делить нельзя! Введите заново: ");
                E = inputInt();
            }

            Console.Write("Введите X: ");
            X = inputDouble();
            Console.Write("Введите X2: ");
            X2 = inputDouble();
            Console.Write("Введите X3: ");
            X3 = inputDouble();
            Console.Write("Введите X4: ");
            X4 = inputDouble();
            check = true;

        }

    public static void calculateAndShowResult() {
            if (!check)
            {
                Console.WriteLine("Мы не можем произвести вычисление, не имея значений переменных!\nВыберите первый пункт, чтобы ввести значения переменных: ");
            }
            else
            {
                Console.WriteLine("Вычислим:\nA * X4 + B * X3 + C * X2 + (D * X)/E");
                Console.Write("Результат вычисления: ");
                Console.WriteLine(A * X4 + B * X3 + C * X2 + (double)((D * X) / E));
            }
        }

    }
}
