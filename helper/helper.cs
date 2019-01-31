using System;

namespace helper
{
    public class Helper
    {

        /// <summary>
        /// Метод, вычисляющий делимость числа без остатка.
        /// </summary>
        /// <param name="num">Проверяемое число.</param>
        /// <param name="delim">Делитель</param>
        /// <returns>Возвращает true, если число делится на делитель без остатка. Иначе, - false.</returns>
        static public bool isDividedBy(int num, int delim)
        {
            if (num == 0) return false;
            if (Math.Abs(num) % delim == 0) return true;
            else return false;
        }

        /// <summary>
        /// Метод инициализации одномерного массива произвольными, целочисленными значениями.
        /// </summary>
        /// <param name="a">Ссылка на массив</param>
        /// <param name="factor">Множитель, задающий диапазон(-factor .. +factor) получаемых значений.</param>
        static public void InitRnd(ref int[] a, int factor)
        {
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(-1 * factor, factor);
            }
        }

        /// <summary>
        /// Метод выводит строку в консоли, по координатам X, Y.
        /// </summary>
        /// <param name="msg">Сообщение</param>
        /// <param name="x">Координата Х</param>
        /// <param name="y">Координата У</param>
        static public void Print(string msg, int x = 0, int y = 0)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }

        /// <summary>
        /// Метод выводит на консоль массив целых чисел.
        /// </summary>
        /// <param name="a">Массив</param>
        static public void Print(int[] a)
        {
            foreach (var item in a)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Метод выводит на консоль массив десятичных чисел.
        /// </summary>
        /// <param name="a">Массив.</param>
        static public void Print(decimal[] a)
        {
            foreach (var item in a)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Метод выводит на консоль массив строк.
        /// </summary>
        /// <param name="a">Массив.</param>
        static public void Print(string[] a)
        {
            foreach (var item in a)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Пауза перед закрытием программы. Ждёт нажатия любой клавиши.
        /// </summary>
        static public void Pause()
        {
            Console.ReadKey();
        }

        /// <summary>
        /// Метод возвращает максимальное значение из 2х.
        /// </summary>
        /// <returns>Максимальное значение.</returns>
        static public decimal Max(decimal a, decimal b)
        {
            if (a > b) return a;
            else return b;
        }

        /// <summary>
        /// Метод возвращает минимальное значение из 2х.
        /// </summary>
        /// <returns>Минимальное значение.</returns>
        static public decimal Min(decimal a, decimal b)
        {
            if (a < b) return a;
            else return b;
        }

        /// <summary>
        /// метод возвращает количество цифр в числе.
        /// </summary>
        /// <param name="num">Целочисленное значение.</param>
        /// <returns>Количество цифр в числе.</returns>
        static public int NumbersAmount(int num)
        {
            return (int)Math.Log10(num) + 1;
        }

        static void Main(string[] args) { }
    }
}
