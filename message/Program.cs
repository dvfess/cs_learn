using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace message
{
    //2. Разработать статический  класс  ​Message,​ содержащий следующие
    //   статические методы для обработки текста: 
    //   а) Вывести только те слова сообщения,  которые содержат не более n букв.
    //   б) Удалить из сообщения все слова, которые заканчиваются на заданный
    //      символ.
    //   в) Найти самое длинное слово сообщения.
    //   г) Сформировать строку с помощью StringBuilder из самых длинных слов
    //      сообщения.
    //   д) *** Создать метод, который производит частотный анализ текста.
    //      В качестве параметра в него передается массив слов и текст, в качестве
    //      результата метод возвращает сколько раз каждое из слов массива входит
    //      в этот текст. Здесь требуется использовать класс Dictionary.
    // Дмитрий Волков
    static class Message
    {

        /// <summary>
        /// Возвращает только те слова сообщения, которые содержат не более n букв.
        /// </summary>
        /// <param name="msg">Строка для анализа.</param>
        /// <param name="n">Длина интересующих слов.</param>
        /// <returns>Слова, длины n</returns>
        static public string NLength(string msg, int n)
        {
            List<string> tmp = new List<string>();
            foreach (var item in msg.Split(' '))
            {
                if (item.Length <= n && item.Length != 0)
                {
                    tmp.Add(item);
                }
            }
            return String.Join(" ", tmp);
        }

        /// <summary>
        /// Возвращает только те слова сообщения, которые не заканчиваются на заданный символ.
        /// </summary>
        /// <param name="msg">Строка для анализа.</param>
        /// <param name="n">Искомый символ.</param>
        /// <returns>Строка, с отсутствующими словами, заканчивающимися на заданный символ.</returns>
        static public string DelEndWith(string msg, char n)
        {
            List<string> tmp = new List<string>();
            foreach (var item in msg.Split(' '))
            {
                if(!item.EndsWith(n.ToString()) && item.Length != 0)
                    tmp.Add(item);
            }
            return String.Join(" ", tmp);
        }

        /// <summary>
        /// Возвращает слово максимальной длины.
        /// </summary>
        /// <param name="msg">Строка для анализа.</param>
        /// <returns>Слово максимальной длины.</returns>
        static public string MaxLength(string msg)
        {
            string max = "";
            foreach (var item in msg.Split(' '))
            {
                if (max.Length < item.Length) max = item;
            }
            return max;
        }

        /// <summary>
        /// Метод формирует строку из самых длинных слов сообщения.
        /// </summary>
        /// <param name="msg">Сообщение.</param>
        /// <returns>Строка из самых длинных слов сообщения.</returns>
        static public string MaxLengthWords(string msg)
        {
            //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
            int maxLength = 0; // максимальная длина слова.
            int count = 0; // количество слов максимальной длины.
            string[] words = msg.Split(' ');
            foreach (var item in words)
            {
                if (maxLength < item.Length)
                {
                    maxLength = item.Length;
                    count = 1;
                }
                else if (maxLength == item.Length) count++;
            }
            StringBuilder sb = new StringBuilder(maxLength*count+(count-1));
            foreach (var item in words)
            {
                if (item.Length == maxLength)
                {
                    sb.Append(item);
                    count--;
                    if (count>0) sb.Append(" ");
                }
                    
            }
            return sb.ToString();
        }

        /// <summary>
        /// Метод, проводит частотный анализ сообщения.
        /// </summary>
        /// <param name="words">Массив интересующих слов.</param>
        /// <param name="msg">Сообщение.</param>
        /// <returns>Возвращает количество вхождений каждого из слов в переданное сообщение.</returns>
        static public Dictionary<string, int> FreqAnalysis(string[] words, string msg)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                Regex word = new Regex(words[i]);
                result[words[i]] = word.Matches(msg).Count;
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            // Список тестовых сообщений
            List<string> a = new List<string>()
            {
                "//2. Разработать статический  класс  ​Message,​ содержащий следующие",
                "//   статические методы для обработки текста: ",
                "//   а) Вывести только те слова сообщения,  которые содержат не более n букв.",
                "//   б) Удалить из сообщения все слова, которые заканчиваются на заданный",
                "//      символ.",
                "//   в) Найти самое длинное слово сообщения.",
                "//   г) Сформировать строку с помощью StringBuilder из самых длинных слов",
                "//      сообщения.",
                "//   д) *** Создать метод, который производит частотный анализ текста.",
                "//      В качестве параметра в него передается массив слов и текст, в качестве",
                "//      результата метод возвращает сколько раз каждое из слов массива входит",
                "//      в этот текст. Здесь требуется использовать класс Dictionary.",
                "// Дмитрий Волков",
            };

            // Тест класса
            foreach (var item in a)
            {
                Console.WriteLine("Рассматриваем сообщение: '{0}'", item);
                Console.WriteLine("a) Слова сообщения, которые содержат не более n букв");
                Console.WriteLine(Message.NLength(item, 5));
                char symbol = 'ь';
                Console.WriteLine("\nб) Слова сообщения, которые не заканчиваются на заданный символ('{0}'): ", symbol);
                Console.WriteLine(Message.DelEndWith(item, symbol));
                Console.Write("\nв) Самое длинное слово сообщения: ");
                Console.WriteLine(Message.MaxLength(item));
                Console.WriteLine("\nг) Сформировать строку с помощью самых длинных слов сообщения.");
                Console.WriteLine(Message.MaxLengthWords(item));
                Console.WriteLine();
                Console.WriteLine(new string('-', 80));
            }

            Console.WriteLine("д) *** Создать метод, который производит частотный анализ текста.\n" +
                              "В качестве параметра в него передается массив слов и текст, в качестве\n" +
                              "результата метод возвращает сколько раз каждое из слов массива входит\n" +
                              "в этот текст. Здесь требуется использовать класс Dictionary.");
            Console.WriteLine();
            string msg = String.Join("\n", a);
            Console.WriteLine("Сообщение: '{0}'", msg);
            string[] words =
{
                    "сообщения",
                    "раз",
                };

            Console.WriteLine();
            Console.WriteLine("Результат:");
            foreach (KeyValuePair<string, int> kvp in Message.FreqAnalysis( words, msg ))
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
        }
    }
}
