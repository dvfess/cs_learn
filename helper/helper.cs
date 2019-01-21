using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helper
{
    public class Helper
    {
        #region Задача
        //6. *Создать класс с методами, которые могут пригодиться в вашей учебе(Print, Pause).
        //Дмитрий Волков
        #endregion

        static public void Print(string msg, int x=0, int y=0)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }

        static public void Pause()
        {
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
        }
    }
}
