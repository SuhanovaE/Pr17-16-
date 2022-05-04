using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PR17
{
    class PRICE
    {
        /// <summary>
        /// поля
        /// </summary>
        private string name;
        private string shop;
        private double price;
        private int amount;
        private double summa;
        /// <summary>
        /// свойства
        /// </summary>
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
        public double Price
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
        /// <summary>
        /// конструкторы
        /// </summary>
        public PRICE() // Конструктор по умолчанию
        {
            name = "";
            shop = "";
            price = 0;
            amount = 0;
            summa = price * amount;
        }
        public PRICE(string name, string shop, double price, int amount) // Конструктор с параметром
        {
            Name = name;
            Shop = shop;
            Price = price;
            Amount = amount;
            Summa = price * amount;
        }        


        public string PrintInfo()
        {
            return $"\nНазвание товара: {name}  \nНазвание магазина: {shop}  \nСтоимость товара: {price} " +
                $" \nКоличество товара: {amount}  \nСумма всех товаров: {price * amount}\n";
        }

        public void Save(string filename)
        {
            StreamWriter sw = new StreamWriter(filename, true, Encoding.UTF8);
            sw.WriteLine($"{name},{shop},{price},{amount},{price*amount}");
            sw.Close();
        }

    }
}
