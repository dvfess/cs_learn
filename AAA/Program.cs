using System;

namespace AAA
{
    class Program
    {
        #region
        //4. Реализовать метод проверки логина и пароля. На вход подается логин и пароль.
        //На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
        //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль,
        // программа пропускает его дальше или не пропускает.
        //С помощью цикла do while ограничить ввод пароля тремя попытками.
        //Дмитрий Волков
        #endregion

        static bool chkAuth(string login, string passwd)
        {
            //root GeekBrains
            if (login == "root")
            {
                if (passwd == "GeekBrains")
                    return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите логин: ");
            string login = Console.ReadLine();
            int attempts = 3;
            do
            {
                attempts -= 1;
                Console.Write("Введите пароль: ");
                string passwd = Console.ReadLine();
                if (chkAuth(login, passwd)) {
                    Console.WriteLine("Авторизованы!");
                    break;
                }
            } while (attempts > 0);
        }
    }
}
