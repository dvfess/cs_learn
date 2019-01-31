using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace chkLogin
{
    //1. Создать программу, которая будет проверять корректность ввода логина.
    // Корректным логином будет строка от 2 до 10 символов, содержащая только
    // буквы латинского алфавита или цифры, при этом цифра не может быть первой:
    // а) без использования регулярных выражений;
    // б) ** с использованием регулярных выражений.
    //Дмитрий Волков
    class Program
    {
        /// <summary>
        /// Проверяет введённый логин на следующие условия: строка длиной от 2х до 10 символов, содержащая только
        /// буквы латинского алфавита или цифры, при этом цифра не может быть первой.
        /// Для проверки, используется только синтаксис C#
        /// </summary>
        /// <param name="login">Входные данные.</param>
        /// <returns>true - если входная строка удовлетворяет параметрам.</returns>
        static bool ChkLogin(string login)
        {
            // Длина символов 2-10
            if (login.Length > 2 && login.Length < 11)
            {
                // Первый символ не число
                if (!int.TryParse(login[0].ToString(), out int g))
                {
                    //только латинские буквы или цифры
                    for (int i = 0; i < login.Length; i++)
                    {
                        if (!char.IsLetterOrDigit(login[i])) return false;
                    }
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Проверяет введённый логин на следующие условия: строка длиной от 2х до 10 символов, содержащая только
        /// буквы латинского алфавита или цифры, при этом цифра не может быть первой.
        /// Для проверки, используются регулярные выражения.
        /// </summary>
        /// <param name="login">Входные данные.</param>
        /// <returns>true - если входная строка удовлетворяет параметрам.</returns>
        static bool ChkLoginRegex(string login)
        {
            Regex rg = new Regex(@"^(?=\D\w)[\d\w]{1,9}$");
            return rg.IsMatch(login);
        }

        static void Main(string[] args)
        {
            List<string> logins = new List<string>() {
                "4pap",
                "pap",
                "5geedre",
                "qwertyuio",
                "asd23ffpp",
            };

            foreach (var item in logins)
            {
                if (ChkLogin(item))
                    Console.WriteLine("ChkLogin say '{0}' is good login.", item);
                else
                    Console.WriteLine("ChkLogin say '{0}' is BAD login!", item);

                if (ChkLoginRegex(item))
                    Console.WriteLine("ChkLoginRegex say '{0}' is good login.", item);
                else
                    Console.WriteLine("ChkLoginRegex say '{0}' is BAD login!", item);
                Console.WriteLine();
            }

            Console.WriteLine("You can manual checking logins here (Ctrl+C for break).");
            while (true)
            {
                Console.Write("login: ");
                string login = Console.ReadLine();
                if (ChkLogin(login))
                    Console.WriteLine("ChkLogin say '{0}' is good login.", login);
                else
                    Console.WriteLine("ChkLogin say '{0}' is BAD login!", login);

                if (ChkLoginRegex(login))
                    Console.WriteLine("ChkLoginRegex say '{0}' is good login.", login);
                else
                    Console.WriteLine("ChkLoginRegex say '{0}' is BAD login!", login);
            }
        }
    }
}
