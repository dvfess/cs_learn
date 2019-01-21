using System;
using helper;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace location
{
    class location
    {
        #region
        //5. а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
        //   б) *Сделать задание, только вывод организовать в центре экрана.
        //   в) **Сделать задание б с использованием собственных методов(
        //       например, Print(string ms, int x, int y).
        //Дмитрий Волков           
        #endregion

        static void Main(string[] args)
        {
            string msg = "Дмитрий Волков Мурманск";
            int Coordx = (int)((Console.BufferWidth / 2 ) - (msg.Length / 2));
            int Coordy = (int)(Console.WindowHeight / 2);
            Helper.Print(msg, Coordx, Coordy);
            Helper.Pause();
        }
    }
}
