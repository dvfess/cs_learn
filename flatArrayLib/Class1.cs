namespace flatArrayLib
{
    #region Задача
    //3. а) Дописать класс  для работы с одномерным массивом. Реализовать
    //    конструктор, создающий массив определенного размера и заполняющий
    //    массив числами от начального значения с заданным шагом.
    //    Создать:
    //     - свойство Sum, которое возвращает сумму элементов массива,
    //     - метод Inverse, возвращающий новый массив с измененными знаками
    //       у всех элементов массива(старый массив, остается без изменений),
    //     - метод Multi, умножающий каждый элемент массива на определённое число
    //     - свойство MaxCount, возвращающее количество максимальных элементов.
    //   б) ** Создать библиотеку содержащую класс для работы с массивом.
    //        Продемонстрировать работу библиотеки
    //   е) *** Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary<int, int>)
    //Дмитрий Волков
    #endregion

    public class FlatArray
    {
        int[] a;

        public int Length
        {
            get { return a.Length; }
        }
        public int this[int i]
        {
            get { return a[i]; }
            set { a[i] = value; }
        }

        /// <summary>
        /// Конструктор, создающий массив заданной размерности с заполненными значениями от начального значения, с заданным шагом.
        /// </summary>
        /// <param name="n">Размер массива.</param>
        /// <param name="start">Начальное значение в массиве.</param>
        /// <param name="step">Шаг заполнения массива.</param>
        public FlatArray(int n, int start = 0, int step = 1)
        {
            if (n > 0)
            {
                int counter = start - step;
                a = new int[n];
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = counter + step;
                    counter += step;
                }
            }
        }

        /// <summary>
        /// Метод умножает каждый элемент массива на заданное число.
        /// </summary>
        public void Multi(int factor)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] *= factor;
            }
        }

        /// <summary>
        /// Метод возвращает новый массив с измененными знаками.
        /// </summary>
        /// <returns>Массив с иверсированными знаками значений.</returns>
        public FlatArray Inverse()
        {
            FlatArray b = new FlatArray(a.Length, 0, 0);
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = a[i] * -1;
            }
            return b;
        }

        /// <summary>
        /// Сумма элементов массива.
        /// </summary>
        public int Sum
        {
            get
            {
                int summ = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    summ += a[i];
                }
                return summ;
            }
        }


        /// <summary>
        /// Количество максимальных элементов.
        /// </summary>
        public int MaxCount
        {
            get
            {
                int max = a[0];
                int count = 1;
                for (int i = 1; i < a.Length; i++)
                {
                    if (a[i] > max)
                    {
                        max = a[i];
                        count = 1;
                    }
                    else if (a[i] == max)
                    {
                        count++;
                    }
                }
                return count;
            }
        }
    }
}
