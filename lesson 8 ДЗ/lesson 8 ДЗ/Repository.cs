using System;
using System.Collections.Generic;

namespace lesson_8_ДЗ
{
    public class Repository
    {
        List<int> list = new List<int>();

        /// <summary>
        /// метод заполнения случайными числами
        /// </summary>
        public void RandomList()
        {
            Random r = new Random();
            for (int i = 0; i < 100; i++)
            {
                list.Add(r.Next(0, 100));
            }
        }
        /// <summary>
        /// метод вывода на экран
        /// </summary>
        public void Print()
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadLine();
        }
        /// <summary>
        /// метод удаления диапазона элементов
        /// </summary>
        public void Delete()
        {
            list.RemoveRange(26, 50);
        }
    }
}
