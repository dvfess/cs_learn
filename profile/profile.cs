using System;

namespace Profile
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задача
            // 1.Написать программу «Анкета».
            // Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).
            // В результате вся информация выводится в одну строчку.
            // Дмитрий Волков
            #endregion

            Console.Write("Имя: ");
            string name = Console.ReadLine();
            Console.Write("Фамилия: ");
            string surname = Console.ReadLine();
            Console.Write("Возраст: ");
            string age = Console.ReadLine();
            Console.Write("Рост: ");
            string height = Console.ReadLine();
            Console.Write("Вес: ");
            string weight = Console.ReadLine();
            Console.WriteLine("\nВывод в одну строку используя");
            Console.WriteLine("склеивание:\n\t\"" + name + " " + surname + "\" Возраст: " + age + " Рост: " + height + " Вес: " + weight + "\n");
            Console.WriteLine("форматированный вывод:\n\t\"{0} {1}\" Возраст: {2} Рост: {3} Вес: {4}\n", name, surname, age, height, weight);
            Console.Write($"вывод со знаком $:\n\t\"{name} {surname}\" Возраст: {age} Рост: {height} Вес: {weight}\n");
            Console.ReadKey();
        }
    }
}
