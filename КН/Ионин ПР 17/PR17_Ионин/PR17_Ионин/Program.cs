using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PR17_Ионин
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа №17");
            Console.WriteLine("Выполнил студент 2 курса группы ИСП.20А");
            Console.WriteLine("Ионин Данила");
            Console.WriteLine("Вариант №6");
            Console.WriteLine();

            List<Price> prices = new List<Price>();

            // Считывание из файла Input.txt
            StreamReader sr = new StreamReader(@"Input.txt");
            Console.WriteLine("Информация в файле Input.txt:");
            while (!sr.EndOfStream)
            {
                string[] info = sr.ReadLine().Split(';');
                Price pricesInFile = new Price()
                {
                    NAME = info[0],
                    SHOP = info[1],
                    PRICE = double.Parse(info[2]),
                    AMOUNT = int.Parse(info[3]),
                    SUMMA = double.Parse(info[2]) * int.Parse(info[3])
                };
                prices.Add(pricesInFile);
                Console.WriteLine($"Название товара: {info[0]}  \nНазвание магазина: {info[1]}  \nЦена товара: {info[2]}  \nКоличество товара: {info[3]}  \nСумма всех товаров: {double.Parse(info[2]) * int.Parse(info[3])}\n");
            }

            Console.Write("Введите количество товаров: N=");
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Заполните данные о товаре №{i + 1}.");
                Console.Write("Введите название товара: ");
                string name = Console.ReadLine();
                Console.Write("Введите название магазина: ");
                string shop = Console.ReadLine();
                Console.Write("Введите цену товара: ");
                int price = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите количество товара: ");
                int amount = Convert.ToInt32(Console.ReadLine());
                double summa = amount * price;
                Price price1 = new Price()
                {
                    NAME = name,
                    SHOP = shop,
                    PRICE = price,
                    AMOUNT = amount,
                    SUMMA = summa
                };
                prices.Add(price1);
            }
            Console.WriteLine();
            for (int j = 0; j < prices.Count; j++)
            {
                Console.WriteLine($"Данные о товаре №{j + 1}.");
                Console.WriteLine(prices[j].PrintInfo());
            }

            for (int i = 0; i < prices.Count; i++)
            {
                prices[i].Save();
            }

            Console.Write("Введите название товара для поиска: ");
            string search_word = Console.ReadLine();
            Search(prices, search_word);

            Console.ReadKey();
        }
        // Метод поиска
        public static void Search(List<Price> prices, string search_word)
        {
            bool flag = false ;
            for (int i = 0; i < prices.Count; i++)
            {
                if (Convert.ToString(prices[i].NAME) == search_word)
                {
                    flag = true;
                    Console.WriteLine(prices[i].PrintInfo());
                }
            }
            if (!flag) Console.WriteLine("Товара с таким названием не найдено!");
        }
    }
}
