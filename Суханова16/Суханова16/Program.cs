using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Суханова16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа №16");
            Console.WriteLine("Выполнила: студентка группы ИСП.20А");
            Console.WriteLine("Суханова Екатерина");
            Console.WriteLine("Вариант №3");
            Console.WriteLine();
            Console.WriteLine("Введите количество студентов:");
            int N = int.Parse(Console.ReadLine());
            STUDENT[] student = new STUDENT[N];
            StreamReader sr = new StreamReader(@"Input.txt");
            for (int i = 0; i < N; i++)
            {
                student[i] = new STUDENT();
                student[i].InputFromFile(sr);               
                Console.WriteLine(student[i].Output());
            }
            Console.WriteLine();
            bool flag = false;
            Console.WriteLine("Студенты, у которых есть хотя бы одна 2");
            for (int i = 0; i < N; i++)
            {
                if (student[i].English == 2 || student[i].Math == 2 || student[i].Biology == 2 || student[i].Chemistry == 2 || student[i].Physics == 2 )
                {
                    Console.WriteLine(student[i].PrintInfo());
                    student[i].Save();
                    flag = true;

                }
                

            }
            if (flag==false)
                Console.WriteLine("нет студентов, у которых есть 2");
            Console.ReadKey();
        }
    }
}
