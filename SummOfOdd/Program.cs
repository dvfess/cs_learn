using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummOfOdd
{
    class Program
    {
        #region Задача
        //3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
        //Дмитрий Волков
        #endregion
        static void Main(string[] args)
        {
            decimal summ = 0;
            decimal inNum = 0;
            int odd = 1;
            while (true) {
                Console.Write("Введите число: ");
                inNum = Convert.ToDecimal(Console.ReadLine());
                if (inNum == 0) break;
                if (odd % 2 == 0 && inNum >= 0) summ += inNum;
                odd += 1;
            }
            Console.WriteLine($"Сумма нечётных чисел: {summ}");
        }
    }
}
