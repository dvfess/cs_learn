using System;

namespace helper
{
    public class Helper
    {
        #region Задача
        //6. *Создать класс с методами, которые могут пригодиться в вашей учебе(Print, Pause).
        //Дмитрий Волков
        #endregion


        static public void Print(string msg, int x = 0, int y = 0)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }

        static public void Pause()
        {
            Console.ReadKey();
        }

        static public decimal Max(decimal a, decimal b)
        {
            if (a > b) return a;
            else return b;
        }

        static public decimal Min(decimal a, decimal b)
        {
            if (a < b) return a;
            else return b;
        }

        static void Main(string[] args) { }
    }
}
