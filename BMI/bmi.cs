using System;

namespace BMI
{
    class Program
    {
        #region Задача
        //2. Ввести вес и рост человека.
        //Рассчитать и вывести индекс массы тела(ИМТ) по формуле
        //    I=m/(h* h);
        //    где m — масса тела в килограммах,
        //    h — рост в метрах
        //Дмитрий Волков
        #endregion

        static void Main(string[] args)
        {
            Console.Write("Введите вес в килограммах: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите рост в метрах: ");
            double height = Convert.ToDouble(Console.ReadLine());
            double bmi = weight / Math.Pow(height, 2);
            Console.WriteLine($"Индекс массы тела: {bmi:F2}");
            Console.ReadKey();
        }
    }
}
