using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PR17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа №17");
            Console.WriteLine("Выполнила студентка 2 курса группы ИСП.20А");
            Console.WriteLine("Немтырёва Ксения");
            Console.WriteLine("Вариант №7");
            Console.WriteLine();           
         
            List<PRICE> prices = new List<PRICE>();
            
            StreamReader streamReader = new StreamReader(@"ListPrices.txt", Encoding.UTF8);
            while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();
                string[] items = line.Split(';');
                PRICE pric = new PRICE()
                {
                    Name = items[0].Trim(),
                    Shop = items[1].Trim(),
                    Price = double.Parse(items[2].Trim()),
                    Amount = int.Parse(items[3].Trim()),                    
                    };
                prices.Add(pric);
                pric.Save(@"Result.txt");
            }            

            foreach (PRICE c in prices)
            {
                Console.WriteLine(c.PrintInfo());
            }

            Console.Write("Введите название магазина для поиска: ");
            string search_word = Console.ReadLine();
            Search(prices, search_word);
            Console.ReadKey();
        }
        public static void Search(List<PRICE> prices, string search_word)
        {
            bool flag = false;
            for (int i = 0; i < prices.Count; i++)
            {
                if (Convert.ToString(prices[i].Shop) == search_word)
                {
                    Console.WriteLine(prices[i].PrintInfo());
                    flag = true;
                }
            }
            if (flag == false)
                Console.WriteLine("Магазина с таким названием не найдено");
        }
    }
}

