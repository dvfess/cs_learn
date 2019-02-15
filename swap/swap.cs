using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace swap
{
    class swap
    {
        static void Main(string[] args)
        {
            #region Задача
            //4.Написать программу обмена значениями двух переменных:
            //    а) с использованием третьей переменной;
            //    б) *без использования третьей переменной.
            //Дмитрий Волков
            #endregion
            #region Первый вариант
            int a = 1;
            int b = 2;
            Console.WriteLine($"a={a} b={b}");
            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"a={a} b={b}");
            #endregion

            #region Второй вариант
            a = 1;
            b = 2;
            Console.WriteLine($"a={a} b={b}");
            // только для числовых переменных :-(
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"a={a} b={b}");
            #endregion
            Console.ReadKey();
        }
    }
}
