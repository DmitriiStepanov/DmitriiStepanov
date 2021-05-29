using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    //На вход функции подается одномерный массив строк, которые содержат фамилии имена и отчества студентов.
    //Необходимо, чтобы функция разбивала всех студентов на подмножества по принципу - все студенты с одинаковыми инициалами помещаются в одно подмножество.


    //Пирожков Артур Иванович
    //Пригожин Алексей Игоревич
    //Плинтусов Андрей Андреевич
    //Путин Антон Иванович
    //Полуэктов Александр Алексеевич
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество первокурсников: ");
            int count = int.Parse(Console.ReadLine());
            string[] students = new string[count];
            for (int i = 0; i < count; i++)
            {
                string student = Console.ReadLine();
                students[i] = student;
            }
            Dictionary<string, List<string>> sortStudents = SortStudents(students);
            Display(sortStudents);

            Console.ReadLine();
        }

        public static Dictionary<string, List<string>> SortStudents(string[] students)
        {
            Dictionary<string, List<string>> sortStudents = new Dictionary<string, List<string>>();
            foreach (string student in students)
            {
                string[] words = student.Split(' ');
                string initials = words[0].Substring(0, 1) + words[1].Substring(0, 1) + words[2].Substring(0, 1);
                try
                {
                    sortStudents.Add(initials, new List<string>());
                    sortStudents[initials].Add(student);
                }
                catch (Exception e)
                {
                    sortStudents[initials].Add(student);
                }
            }

            return sortStudents;
        }

        public static void Display(Dictionary<string, List<string>> sortStudents)
        {
            foreach (var keyValue in sortStudents)
            {
                Console.WriteLine(keyValue.Key);
                foreach (var student in keyValue.Value) Console.WriteLine(student);

                Console.WriteLine();
            }
        }
    }
}
