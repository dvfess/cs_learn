using helper;
using System;
using System.IO;

namespace PairsFromMassive
{
    #region Задача 2
    //2. Реализуйте задачу 1 в виде статического класса StaticClass;
    //    а)  Класс должен  содержать статический  метод,  который
    //        принимает на вход массив и решает задачу 1;
    //    б)  *Добавьте статический  метод для считывания массива из
    //         текстового файла. Метод должен возвращать массив целых чисел;
    //    в)  **Добавьте обработку ситуации отсутствия файла на диске.
    //Дмитрий Волков

    public static class Pairs
    {
        /// <summary>
        /// Метод, возвращающий количество пар массива, в которых только одно число делится на 3.
        /// </summary>
        /// <param name="a">Массив.</param>
        /// <returns>Количество пар, в которых только одно число делится на 3.</returns>
        public static int Solve(int[] a)
        {
            int divider = 3;
            int divided = 0;
            for (int i = 0; i < a.Length - 2; i++)
            {
                if (Helper.isDividedBy(a[i], divider) ^ Helper.isDividedBy(a[i + 1], divider))
                {
                    divided++;
                }
            }
            return divided;
        }

        /// <summary>
        /// Метод для считывания массива из текстового файла.
        /// </summary>
        /// <param name="a">Заполняемый массив.</param>
        /// <param name="size">Размерность массива.</param>
        /// <returns>Возвращает true при успешном считывании данных из файла.</returns>
        public static bool ReadFromFile(out int[] a, int size = 20)
        {
            string filename = "input.txt";
            int i = 0;
            a = new int[size];
            a.Initialize();
            try
            {
                using (var sr = new StreamReader(filename))
                {
                    while (!sr.EndOfStream || i == size)
                    {
                        if (int.TryParse(sr.ReadLine(), out int number))
                        {
                            a[i] = number;
                        }
                        i++;
                    }
                }
                return true;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл {0} не найден!", filename);
            }
            return false;
        }

    }
    #endregion

    #region Задача 1
    // Дан целочисленный  массив из 20 элементов. Элементы массива могут
    // принимать целые значения от –10 000 до 10 000 включительно. Заполнить
    // случайными числами. Написать программу, позволяющую найти и вывести
    // количество пар элементов массива, в которых только одно число делится на 3.
    // В данной задаче под парой подразумевается два подряд идущих элемента массива.
    // Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.
    //Дмитрий Волков

    class Program
    {
        static void Main(string[] args)
        {
            const int ARRAY_RANGE = 10;
            const int DIVIDER = 3;

            int[] myArray = new int[20];
            Helper.InitRnd(ref myArray, ARRAY_RANGE);

            Console.Write("Массив: ");
            Helper.Print(myArray);

            int divided = 0;
            for (int i = 0; i < myArray.Length - 2; i++)
            {
                if (Helper.isDividedBy(myArray[i], DIVIDER) ^ Helper.isDividedBy(myArray[i + 1], DIVIDER))
                {
                    divided++;
                    Console.WriteLine("Только {0,6} или {1,6} делятся на {2} без остатка!", myArray[i], myArray[i + 1], DIVIDER);
                }
            }
            Console.WriteLine("\nКоличество пар, делящихся на {0}: {1}", DIVIDER, divided);
        }
    }
    #endregion
}