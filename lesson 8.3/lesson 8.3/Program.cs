using System;
using System.Collections.Generic;

namespace lesson_8._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> collection = new HashSet<int>();

            bool decision;
            int number;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Введите число: ");
                decision = collection.Contains(number = int.Parse(Console.ReadLine()));
                if (decision)
                {
                    Console.WriteLine("Число уже было введено");
                }
                else
                {
                    collection.Add(number);
                    Console.WriteLine("Число успешно добавлено");
                }
            }
            
        }
    }
}
