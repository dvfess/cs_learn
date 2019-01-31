using flatArrayLib;
using helper;

namespace flatArray
{
    class Program
    {
        #region Задача
        //3. б) ** Создать библиотеку содержащую класс для работы с массивом.
        //        Продемонстрировать работу библиотеки
        //Дмитрий Волков
        #endregion

        // Демонстрация работы библиотеки с классом.
        static void Main(string[] args)
        {
            const int SIZE = 20;
            const int START = -10;
            const int STEP = 1;
            System.Console.WriteLine("Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом");
            FlatArray a = new FlatArray(SIZE, START, STEP);
            System.Console.Write("Массив размера {0}, начинается с {1}, с шагом заполнения {2}: ", SIZE, START, STEP);
            for (int i = 0; i < a.Length; i++)
            {
                System.Console.Write("{0} ", a[i]);
            }
            System.Console.WriteLine("\n\nсвойство Sum, которое возвращает сумму элементов массива: {0}", a.Sum);
            System.Console.Write("метод Inverse, возвращающий новый массив с измененными знаками:");
            FlatArray b = a.Inverse();
            for (int i = 0; i < b.Length; i++)
            {
                System.Console.Write("{0} ", b[i]);
            }
            System.Console.WriteLine("\nметод Multi, умножающий каждый элемент массива на определённое число");
            a.Multi(2);
            for (int i = 0; i < a.Length; i++)
            {
                System.Console.Write("{0} ", a[i]);
            }
            System.Console.WriteLine("\nсвойство MaxCount, возвращающее количество максимальных элементов: {0}", a.MaxCount);
        }
    }
}
