using System;

namespace BMI
{
    class Program
    {
        #region Задача
        //5. а) Написать программу, которая запрашивает массу и рост человека,
        //      вычисляет его индекс массы и сообщает, нужно ли человеку похудеть,
        //      набрать вес или все в норме;

                //16 и менее  Выраженный дефицит массы тела
                //16—18,5	Недостаточная(дефицит) масса тела
                //18,5—24,99	Норма
                //25—30	Избыточная масса тела(предожирение)
                //30—35	Ожирение
                //35—40	Ожирение резкое
                //40 и более  Очень резкое ожирение
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

            if (bmi >=1 && bmi <= 16)
                Console.WriteLine("Выраженный дефицит массы тела. Поесть бы.");
            else if (bmi >= 16.1 && bmi <= 18.59)
                    Console.WriteLine("Недостаточная(дефицит) масса тела. Приглядитесь к печенькам ;)");
            else if (bmi >= 18.5 && bmi <= 24.99)
                    Console.WriteLine("Норма.");
            else if (bmi >= 25 && bmi <= 30)
                    Console.WriteLine("Избыточная масса тела(предожирение). Разнесёт ведь.");
            else if (bmi >= 30.1 && bmi <= 35)
                    Console.WriteLine("Ожирение. А ты солидный мужчина!");
            else if (bmi >= 35.1 && bmi <= 40.1)
                    Console.WriteLine("Ожирение(резкое). Хватит точить!");
            else if (bmi >= 40)
                    Console.WriteLine("Очень резкое ожирение, - слишком медленный способ самоубийства.");
            Console.ReadKey();
        }
    }
}