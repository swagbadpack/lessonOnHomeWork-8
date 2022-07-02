using System;
using System.Collections.Generic;

namespace lesson_8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string keyEnd = "";
            int enterKey;
            string enterValue;
            bool end = true;
            

            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            do
            {
                Console.WriteLine("Введите номер");
                string enter = Console.ReadLine();
                
                if (enter != keyEnd)
                {
                    enterKey = int.Parse(enter);
                    Console.WriteLine("Введите ФИО");
                    enterValue = Console.ReadLine();
                    dictionary.Add(enterKey, enterValue);
                }

                if (enter == keyEnd)
                {
                    Console.WriteLine("Введите номер телефона, чтобы найти владельца");
                    string find = Console.ReadLine();

                    if (dictionary.TryGetValue(int.Parse(find), out string value))
                    {
                        Console.WriteLine($"ФИО: { value}");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Номера нет в книжке");
                        Console.ReadKey();
                    }
                    end = false;
                }

                
            } while (end);


        }
    }
}
