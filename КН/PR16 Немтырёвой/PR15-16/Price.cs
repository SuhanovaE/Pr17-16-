using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PR15_16
{
    class Price
    {
        private string name;
        private string shop;
        private double price;
        private int amount;
        private double summa;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Shop
        {
            get { return shop; }
            set { shop = value; }
        }
        public double PRICE
        {
            get { return price; }
            set { price = value; }
        }
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public double Summa
        {
            get { return summa; }
            set { summa = value; }
        }

        public Price() // Конструктор по умолчанию
        {
            name = "Товар";
            shop = "Магазин";
            price = 100;
            amount = 1;
            summa = price * amount;
        }
        public Price(string name, string shop, double price, int amount) // Конструктор с параметром
        {
            Name = name;
            Shop = shop;
            PRICE = price;
            Amount = amount;
            summa = price * amount;
        }
        public void InputFromKeyboard()
        {
            Console.Write("Введите название товара: ");
            name = Console.ReadLine();
            Console.Write("Введите название магазина: ");
            shop = Console.ReadLine();
            Console.Write("Введите стоимость товара: ");
            price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите количество товара: ");
            amount = Convert.ToInt32(Console.ReadLine());            
        }
        public void InputFromFile(StreamReader sr)
        {

            string input = sr.ReadLine();
            string[] info = input.Split(',');
            name = info[0];
            shop = info[1];
            price = int.Parse(info[2]);
            amount = int.Parse(info[3]);
            summa = price * amount;
        }

        public string PrintInfo()
        {
            return $"\nНазвание товара: {name}  \nНазвание магазина: {shop}  \nСтоимость товара: {price}  \nКоличество товара: {amount}  \nСумма всех товаров: {price*amount}\n";
        }

        public void Save(string filename)
        {
            StreamWriter sw = new StreamWriter(filename, true, Encoding.Default);
            sw.WriteLine($"{name},{shop},{price},{amount},{summa}");
            sw.Close();
        }

    }
}
