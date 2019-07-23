using System;
namespace Complex
{
    /// <summary>
    /// Класс работы с комплексными числами. Взят из методички.
    /// </summary>
    class Complex
    {
        private double im;

        private double re;

        public Complex()
        {
            im = 0;
            re = 0;
        }

        public Complex(double _im, double re)
        {
            im = _im;
            this.re = re;
        }

        public Complex Plus(Complex x2)
        {
            Complex x3 = new Complex();

            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }
        #region Подзадача Б
        // б) Дописать класс Complex, добавив методы вычитания и произведения
        //    чисел. Проверить работу класса;
        
        /// <summary>
        /// Метод вычитания комплексного числа.
        /// </summary>
        /// <param name="x2">Вычитаемое комплексное число.</param>
        /// <returns>Комплексное число.</returns>
        public Complex Subtract(Complex x2)
        {
            // (a + bi) - (c + di) = (a - c) +(b - d)i
            Complex x3 = new Complex();
            x3.im = this.im - x2.im;
            x3.re = this.re - x2.re;
            return x3;
        }

        /// <summary>
        /// Метод умножения комплексного числа.
        /// </summary>
        /// <param name="x2">Множитель типа Complex.</param>
        /// <returns>Комплексное число.</returns>
        public Complex Multi(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = this.re * x2.im + this.im * x2.re;
            x3.re = this.re * x2.re - this.im * x2.im;
            return x3;
        }
        #endregion

        public double Im
        {
            get => im;
            set
            {
                if (value >= 0)
                {
                    im = value;
                }
            }
        }

        public override string ToString()
        {
            return re + "+" + im + "i";

        }
    }


     /// <summary>
    /// Реализация структуры из методички.
    /// </summary>
    struct ComplexStruct
    {
        public double im;
        public double re;
        // в C# в структурах могут храниться также действия над данными
        public ComplexStruct Plus(ComplexStruct x)
        {
            ComplexStruct y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        // Пример произведения двух комплексных чисел
        public ComplexStruct Multi(ComplexStruct x)
        {
            ComplexStruct y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }

        #region Подзадача
        // 1. а) Дописать структуру Complex, добавив метод вычитания комплексных
        //       чисел. Продемонстрировать работу структуры;
        // Дмитрий Волков
        #endregion
        /// <summary>
        /// Функция вычитания комплексного числа.
        /// </summary>
        /// <param name="x">Вычитаемое комплексное число.</param>
        /// <returns>Результирующее комплексное число.</returns>
        public ComplexStruct Subtract(ComplexStruct x)
        {
            // (a + bi) - (c + di) = (a - c) +(b - d)i
            ComplexStruct y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }

        public override string ToString()
        {
            return re + "+" + im + "i";
        }
    }



    class Odd
    {
        #region Задача
        // 1. а) Дописать структуру Complex, добавив метод вычитания комплексных
        //       чисел. Продемонстрировать работу структуры;
        //    б) Дописать класс Complex, добавив методы вычитания и произведения
        //       чисел. Проверить работу класса;
        // Дмитрий Волков
        #endregion

        private static void Main(string[] args)
        {
            #region Подзадача А
            /// Демонстрация работы структуры.

            ComplexStruct a, b;
            a.im = 1;
            a.re = 1;
            b.im = 2;
            b.re = 2;


            Console.WriteLine("Демонстрация работы структуры.");
            System.Console.WriteLine($"Вычитание: {a.Subtract(b).ToString()}");
            System.Console.WriteLine($"Умножение: {a.Multi(b).ToString()}");
            #endregion

            Console.WriteLine("----------------------------------------");


            #region Подзадача Б
            // Демонстрация работы класса.

            Complex cp1 = new Complex(1, 1);
            Complex cp2 = new Complex(2, 2);

            Console.WriteLine("Демонстрация работы класса.");
            Console.WriteLine($"Вычитание: {cp1.Subtract(cp2).ToString()}");
            Console.WriteLine($"Умножение: {cp1.Multi(cp2).ToString()}");
            #endregion
        }
    }
}
