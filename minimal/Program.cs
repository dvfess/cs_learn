using System;
using helper;

namespace minimal
{
    class Program
    {
        #region Задача
        //1. Написать метод, возвращающий минимальное из трех чисел.
        //Дмитрий волков
        #endregion

        static byte Min3(byte a, byte b, byte c)
        {
            byte min = a;
            if (b < min) min = b;
            else if (c < min) min = c;
            return min;
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            byte[] rndNums = new byte[3];
            rnd.NextBytes(rndNums);

            Console.Write("Ищем минимальное число из: ");
            foreach (byte vl in rndNums) Console.Write($"{vl} ");

            Console.WriteLine("\nМинимальное число: " + Min3(rndNums[0], rndNums[1], rndNums[2]));
        }
    }
}
