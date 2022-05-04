using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Суханова16
{
    class STUDENT
    {
        private string fio;
        private string group;
        private int math;
        private int english;
        private int physics;
        private int biology;
        private int chemistry;

        public string FIO
        {
            get { return fio; }
            set { fio = value; }
        }
        public string Group
        {
            get { return group; }
            set { group = value; }
        }
        public int Physics
        {
            get { return physics; }
            set { physics = value; }
        }
        public int Biology
        {
            get { return biology; }
            set { biology = value; }
        }
        public int Math
        {
            get { return math; }
            set { math = value; }
        }
        public int English
        {
            get { return english; }
            set { english = value; }
        }
        public int Chemistry
        {
            get { return chemistry; }
            set { chemistry = value; }
        }

        public STUDENT()
        {
            FIO = "Иванов И.И.";
            group = "ИСП.20";
            math = 4;
            english = 5;
            physics = 3;
            biology = 5;
            chemistry = 5;
        }
        public STUDENT(string fio, string gr, int m, int eng, int ph, int bio, int ch)
        {
            FIO = fio;
            group = gr;
            math = m;
            english = eng;
            physics = ph;
            biology = bio;
            chemistry = ch;
        }
        public void InputFromFile(StreamReader sr)
        {

            string input = sr.ReadLine();
            string[] info = input.Split(',');
            FIO = info[0];
            group = info[1];
            math = int.Parse(info[2]);
            english = int.Parse(info[3]);
            biology = int.Parse(info[4]);
            chemistry = int.Parse(info[5]);
            physics = int.Parse(info[6]);

        }
        public string Output()
        {
            return $"Студент {FIO} " +
                $"группа {group} \n" +
                $"Оценка по математике {math} \n" +
                $"Оценка по английскому языку {english} \n" +
                $"Оценка по физике {physics} \n" +
                $"Оценка по химии {chemistry} \n" +
                $"Оценка по биологии {biology} ";
        }
        public string PrintInfo()
        {
            return $"Студент {FIO} " +
                $"группа {group} ";
        }
        public void Save()
        {
            StreamWriter sr = new StreamWriter(@"Result.txt", true);
            sr.WriteLine($"{FIO},{group}");
            sr.Close();
        }
        
    }
    
}

