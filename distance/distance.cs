using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace distance
{
    class distance
    {
        #region Задача
        //3. а) Написать программу, которая подсчитывает
        //      расстояние между точками с координатами x1, y1 и x2,y2
        //      по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
        //      Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
        //   б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде
        //      метода.        //Дмитрий Волков
        #endregion

        static void getCoords(out double x, out double y, string msg = "Введите координаты точки:")
        {
            Console.Write(msg);
            string[] raw_coord = Console.ReadLine().Split(' ');
            x = Convert.ToDouble(raw_coord[0]);
            y = Convert.ToDouble(raw_coord[1]);
        }

        static void getDistance(double x1, double y1, double x2, double y2)
        {
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Расстояние: {r}");
        }

        static void Main(string[] args)
        {
            double x1 = -1;
            double y1 = 3;
            double x2 = 6;
            double y2 = 2;
            Console.WriteLine("Введите координаты точек, разделяя координаты пробелом (x1 y1):");
            getCoords(out x1, out y1, "Введите координаты первой точки: ");
            getCoords(out x2, out y2, "Введите координаты второй точки: ");
            getDistance(x1, y1, x2, y2);
            Console.ReadKey();
        }
    }
}
