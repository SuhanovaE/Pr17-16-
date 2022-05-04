using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PR17
{
    class Worker
    {
        // Поля класса
        private string fio;
        private string post;
        private int entrance;
        private int experience;

        // Свойства для доступа к полям
        public string FIO
        {
            get { return fio; }
            set { fio = value; }
        }
        public string POST
        {
            get { return post; }
            set { post = value; }
        }
        public int ENTRANCE
        {
            get { return entrance; }
            set { entrance = value; }
        }
        public int EXPERIENCE
        {
            get { return experience; }
            set { experience = value; }
        }

        // Конструктор по умолчанию
        public Worker()
        {
            fio = "Иванов И.И.";
            post = "Грузчик";
            entrance = 2020;
            experience = DateTime.Today.Year - entrance;
        }

        // Конструктор с параметрами
        public Worker(string f, string p, int entr)
        {
            fio = f;
            post = p;
            entrance = entr;
            experience = DateTime.Today.Year - entr;
        }

        public void InputFromKeyboard()
        {
            Console.Write("Введите фамилию и инициалы работника: ");
            fio = Console.ReadLine();
            Console.Write("Введите название занимаемой должности: ");
            post = Console.ReadLine();
            Console.Write("Введите год поступления на работу: ");
            entrance = Convert.ToInt32(Console.ReadLine());
            experience = DateTime.Today.Year - entrance;
        }

        public string PrintInfo()
        {
            return $"Фамилия и инициалы работника: {fio} \nНазвание занимаемой должности: {post} \nГод поступления на работу: {entrance} \nСтаж работы: {experience}\n";
        }

        // Метод записи в файл Result.txt
        public void Save()
        {
            StreamWriter sw = new StreamWriter(@"Result.txt", true, Encoding.Default);
            sw.WriteLine($"{fio};{post};{entrance};{experience}");
            sw.Close();
        }
    }
}
