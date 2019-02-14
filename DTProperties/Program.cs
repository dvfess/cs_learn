using System;
using System.Reflection;
class Program
{
    // 1. С помощью рефлексии выведите все свойства структуры DateTime
    // Дмитрий Волков


    static void Main(string[] args)
    {
        Type dt = typeof(DateTime);

        foreach (PropertyInfo item in dt.GetProperties())
        {
            Console.WriteLine(item.ToString());
        }
    }
}
