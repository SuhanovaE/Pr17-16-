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
            Console.WriteLine("Выполнил студент 2 курса группы ИСП.20А");
            Console.WriteLine("Рылеев Александр");
            Console.WriteLine("Вариант №4");
            Console.WriteLine();

            List<Worker> workers = new List<Worker>();

            // Считывание из файла Input.txt
            StreamReader sr = new StreamReader(@"Input.txt");
            Console.WriteLine("Информация в файле Input.txt:");
            while (!sr.EndOfStream)
            {
                string[] info = sr.ReadLine().Split(';');
                Worker workerInFile = new Worker()
                {
                    FIO = info[0],
                    POST = info[1],
                    ENTRANCE = int.Parse(info[2]),
                    EXPERIENCE = DateTime.Today.Year - int.Parse(info[2])
                };
                workers.Add(workerInFile);
                Console.WriteLine($"Фамилия и инициалы работника: {info[0]} \nНазвание занимаемой должности: {info[1]}" +
                    $"\nГод поступления на работу: {info[2]} \nСтаж работы: {DateTime.Today.Year - int.Parse(info[2])}\n");
            }

            Console.Write("Введите количество работников: N=");
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Заполните данные работника №{i + 1}.");
                Console.Write("Введите фамилию и инициалы работника: ");
                string fio = Console.ReadLine();
                Console.Write("Введите название занимаемой должности: ");
                string post = Console.ReadLine();
                Console.Write("Введите год поступления на работу: ");
                int entrance = Convert.ToInt32(Console.ReadLine());
                int experience = DateTime.Today.Year - entrance;
                Worker worker = new Worker()
                {
                    FIO = fio,
                    POST = post,
                    ENTRANCE = entrance,
                    EXPERIENCE = DateTime.Today.Year - entrance
                };
                workers.Add(worker);
            }
            Console.WriteLine();
            for (int j = 0; j < workers.Count; j++)
            {
                Console.WriteLine($"Данные работника №{j + 1}.");
                Console.WriteLine(workers[j].PrintInfo());
            }

            for (int i = 0; i < workers.Count; i++)
            {
                workers[i].Save();
            }

            // Приложение должно выводить фамилии работников, чей стаж работы в организации превышает значение,
            // введенное с клавиатуры; если таких работников нет, вывести на экран соответствующее сообщение.
            Console.Write("Введите значение стажа: ");
            int search_experience = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nCотрудники, чей стаж работы превышет {search_experience} лет(год):\n");
            Search(workers, search_experience);

            Console.ReadKey();
        }
        // Метод поиска
        public static void Search(List<Worker> workers, int search_experience)
        {
            bool flag = false;
            for (int i = 0; i < workers.Count; i++)
            {
                if (workers[i].EXPERIENCE > search_experience)
                {
                    flag = true;
                    Console.WriteLine(workers[i].PrintInfo());
                }
            }
            if (!flag) Console.WriteLine("Работника(ов) с превышающим стажем введёного значения нет!");
        }
    }
}
