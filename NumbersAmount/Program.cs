using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersAmount
{
    class Program
    {
        #region Задача
        //2. Написать метод подсчета количества цифр числа.
        //Дмитрий Волков
        #endregion
        static int Amount(int nums)
        {
            return (int)Math.Log10(nums) + 1;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Количество символов в числе: {0}", Amount(number));
        }
    }
}
