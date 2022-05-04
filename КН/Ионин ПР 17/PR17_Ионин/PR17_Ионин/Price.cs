using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PR17_Ионин
{
    class Price
    {
        private string name;
        private string shop;
        private double price;
        private int amount;
        private double summa;

        public string NAME
        {
            get { return name; }
            set { name = value; }
        }
        public string SHOP
        {
            get { return shop; }
            set { shop = value; }
        }
        public double PRICE
        {
            get { return price; }
            set { price = value; }
        }
        public int AMOUNT
        {
            get { return amount; }
            set { amount = value; }
        }
        public double SUMMA
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
        public Price(string n, string sh, double pr, int am) // Конструктор с параметром
        {
            name = n;
            shop = sh;
            price = pr;
            amount = am;
            summa = pr * am;
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
            summa = price * amount;
        }

        public string PrintInfo()
        {
            return $"Название товара: {name}  \nНазвание магазина: {shop}  \nЦена товара: {price}  \nКоличество товара: {amount}  \nСумма всех товаров: {summa}\n";
        }

        // Метод записи в файл Result.txt
        public void Save()
        {
            StreamWriter sw = new StreamWriter(@"Result.txt", true, Encoding.Default);
            sw.WriteLine($"{name};{shop};{price};{amount};{summa}");
            sw.Close();
        }
    }
}
