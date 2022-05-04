using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace PR15_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа №16");
            Console.WriteLine("Выполнила студентка 2 курса группы ИСП.20А");
            Console.WriteLine("Немтырёва Ксения");
            Console.WriteLine("Вариант №7");
            Console.WriteLine();

            Price price = new Price();
            price.Name = "Кетчуп";
            price.Shop = "Пятёрочка";
            Console.WriteLine(price.PrintInfo());
            price.Save(@"Data.txt");
            StreamReader sr = new StreamReader(@"Result.txt", Encoding.Default);
            price.InputFromFile(sr);
            Console.WriteLine(price.PrintInfo());
            sr.Close();
            Price price1 = new Price("Сырный соус", "Магнит", 80, 200);
            Console.WriteLine(price1.PrintInfo());

            Console.Write("Введите количество товаров: N=");
            int N = int.Parse(Console.ReadLine());
            Price[] prices = new Price[N];
            for (int i = 0; i < N; i++)
            {
                prices[i] = new Price();
                prices[i].InputFromKeyboard();
                prices[i].Save(@"Result.txt");
            }
            foreach (Price calc in prices)
            {
                Console.WriteLine(calc.PrintInfo());
            }

            Console.Write("Введите название магазина для поиска: ");
            string search_word = Console.ReadLine();
            Search(prices, search_word);

            


            Console.ReadKey();
        }
        public static void Search(Price[] prices, string search_word)
        {
            bool flag = false;
            for (int i = 0; i < prices.Length; i++)
            {
                if (Convert.ToString(prices[i].Shop) == search_word)
                {
                    Console.WriteLine(prices[i].PrintInfo());
                    flag = true;
                }
            }
            if(flag == false)
                Console.WriteLine("Магазина с таким названием не найдено");
        }
    }
}
