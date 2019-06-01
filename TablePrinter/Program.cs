using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace TablePrinter
{

    //1. Изменить программу вывода таблицы функции так, чтобы можно было
    //   передавать функции типа double (double, double). Продемонстрировать
    //   работу на функции с функцией a* x^2 и функцией a* sin(x).    // Дмитрий Волков
    // Описываем делегат. В делегате описывается сигнатура методов, на
    // которые он сможет ссылаться в дальнейшем (хранить в себе)
    public delegate double Fun(double x);
    // Делегат для задания.
    public delegate double Fun2(double x, double y);

    class Program
    {
        // Создаем метод, который принимает делегат
        // На практике этот метод сможет принимать любой метод
        // с такой же сигнатурой, как у делегата
        public static void Table(Fun F, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }

        // Перегрузка метода под задание
        public static void Table(Fun2 F, double x, double a, double n)
        {
            Console.WriteLine("----- X ------- A -------- F ----- ");
            while (x <= n)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000} |", x, a, F(x, a));
                x += 1;
            }
            Console.WriteLine("----------------------------------");
        }

        // Создаем метод для передачи его в качестве параметра в Table
        public static double MyFunc(double x)
        {
            return x * x * x;
        }

        public static double MySin(double x, double a)
        {
            return a * Math.Sin(x);
        }

        public static double MySqr(double x, double a)
        {
            return a * (x * x);
        }


        static void Main()
        {
            // Создаем новый делегат и передаем ссылку на него в метод Table
            // Параметры метода и тип возвращаемого значения, должны совпадать с делегатом
            Console.WriteLine("Таблица функции MyFunc:");
            Table(new Fun(MyFunc), -2, 2);
            Console.WriteLine("Еще раз та же таблица, но вызов организован по новому");
            // Упрощение(c C# 2.0). Делегат создается автоматически.            
            Table(MyFunc, -2, 2);
            Console.WriteLine("Таблица функции Sin:");
            Table(Math.Sin, -2, 2);      // Можно передавать уже созданные методы
            Console.WriteLine("Таблица функции x^2:");
            // Упрощение(с C# 2.0). Использование анонимного метода
            Table(delegate (double x) { return x * x; }, 0, 3);

            Console.WriteLine("Домашка:");
            Table(MySin, -2, 5, 2);
            Table(MySqr, -2, 5, 2);
        }
    }
}
