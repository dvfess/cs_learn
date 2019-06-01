using System;
using System.Collections.Generic;
using System.IO;

namespace FuncMinimum
{

    //2. Модифицировать программу нахождения минимума функции так, чтобы можно
    //   было передавать функцию в виде делегата.
    //    а) Сделать меню с различными функциями и представить пользователю
    //       выбор, для какой функции и на каком отрезке находить минимум.
    //       Использовать массив(или список) делегатов, в котором хранятся
    //       различные функции.
    //    б) * Переделать функцию Load, чтобы она возвращала массив считанных
    //       значений. Пусть она возвращает минимум через параметр
    //       (с использованием модификатора out).
    // Дмитрий Волков

    public delegate double Func(double x);

    class Program
    {
        //public static double F(double x)
        //{
        //    return x * x - 50 * x + 10;
        //}

        public static void SaveFunc(Func F, string fileName, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }

        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }

        /// <summary>
        /// Метод возвращает выбор пользователя в виде функции и отрезок, на котором применить функцию.
        /// </summary>
        /// <param name="sel">Словарь<"имя функции","функция">></param>
        /// <param name="a">Начало диапазона</param>
        /// <param name="b">Конец диапазона</param>
        /// <returns>Func</returns>
        private static Func Menu(Dictionary<string, Func> sel, out double a, out double b)
        {
            Console.WriteLine("Выберите функцию:");
            int i = 0;
            Func selectedFunc;

            Dictionary<int, string> n = new Dictionary<int, string>();

            foreach (KeyValuePair<string, Func> kvp in sel)
            {
                Console.WriteLine($"{i}. {kvp.Key};");
                n.Add(i, kvp.Key);
                i++;
            }

            if (int.TryParse(Console.ReadLine(), out i))
                selectedFunc = sel[n[i]];
            else
                selectedFunc = sel[n[0]];

            Console.WriteLine("Выберите диапазон отрезка, на котором необходимо найти функцию:");
            Console.Write("От:");
            if (!double.TryParse(Console.ReadLine(), out a)) a = -5;
            Console.Write("До:");
            if (!double.TryParse(Console.ReadLine(), out b)) b = 5;
            return selectedFunc;
        }

        static void Main(string[] args)
        {


            // Список функций и их описание для вывода в меню.
            Dictionary<string, Func> dct = new Dictionary<string, Func>
            {
                { "x^2", delegate (double x) { return x * x; } },
                { "x^3", delegate (double x) { return x * x * x; } },
                { "sqrt(x)", delegate (double x) { return Math.Sqrt(x); } }
            };

            SaveFunc(Menu(dct, out double a, out double b), "data.bin", a, b, 0.5);
            Console.WriteLine(Load("data.bin"));
            Console.ReadKey();
        }
    }
}