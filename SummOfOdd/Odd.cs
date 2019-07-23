using System;
using System.Collections.Generic;

namespace SummOfOdd
{
    class Odd
    {
        #region Задача
        //2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число
        //    в новой строке). Требуется подсчитать сумму всех нечетных
        //    положительных чисел. Сами числа и сумму вывести на экран, используя
        //    tryParse;
        //   б) Добавить обработку исключительных ситуаций на то, что могут быть
        //    введены некорректные данные. При возникновении ошибки вывести сообщение.
        //    Напишите соответствующую функцию;
        //Дмитрий Волков
        #endregion

        static List<decimal> numbers = new List<decimal>();

        public static List<decimal> Numbers { get => numbers; set => numbers = value; }

        /// <summary>
        /// Метод-обёртка для ввода и парсинга целого числа.
        /// </summary>
        /// <param name="x">Переменная, в которую выведется число, введённое пользователем.</param>
        /// <returns>В случае удачного парсинга, метод вернёт true. Иначе, - false.</returns>
        static bool InputDecimal(out decimal x)
        {
            Console.Write("Введите число: ");
            return decimal.TryParse(Console.ReadLine(), out x);
        }

        static void Main(string[] args)
        {
            decimal summ = 0;
            int odd = 1;
            Console.WriteLine("Введите 0 - для выхода.");
            while (true)
            {
                if (InputDecimal(out decimal inNum))
                {
                    if (inNum == 0) break;
                    if (odd % 2 != 0 && inNum > 0)
                    {
                        summ += inNum;
                        Numbers.Add(inNum);
                    }
                    odd += 1;
                } else
                {
                    Console.WriteLine("Пожалуйста, введите число!");
                }
            }
            Console.Write("Если суммировать все не чётные, положительные числа: ");
            foreach (var number in Numbers)
            {
                Console.Write($"{number}, ");
            }            
            Console.WriteLine($"\n...их сумма будет равна: {summ}");
        }
    }
}
