using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_13
{
    class Program
    {
        public struct Student
        {
            public string fullName;
            public double bestResult;
        }
        static void Main(string[] args)
        {
            Student[] firstClass = new Student[5];
            Student[] secondClass = new Student[6];
            firstClass[0].fullName = "Белов";
            firstClass[0].bestResult = 2.6;
            firstClass[1].fullName = "Рыжова";
            firstClass[1].bestResult = 3.6;
            firstClass[2].fullName = "Носов";
            firstClass[2].bestResult = 4.1;
            firstClass[3].fullName = "Пупкин";
            firstClass[3].bestResult = 5.7;
            firstClass[4].fullName = "Зайцев";
            firstClass[4].bestResult = 6.4;
            secondClass[0].fullName = "Круглов";
            secondClass[0].bestResult = 2.2;
            secondClass[1].fullName = "Зелькин";
            secondClass[1].bestResult = 3.9;
            secondClass[2].fullName = "Романов";
            secondClass[2].bestResult = 4.3;
            secondClass[3].fullName = "Тухель";
            secondClass[3].bestResult = 5.3;
            secondClass[4].fullName = "Малышко";
            secondClass[4].bestResult = 6;
            secondClass[5].fullName = "Петров";
            secondClass[5].bestResult = 7.8;
            Student[] bestStudents = BestStudents(firstClass, secondClass);
            Display(bestStudents);
            
            Console.ReadLine();
        }

        public static Student[] BestStudents(Student[] firstClass, Student[] secondClass)
        {

            int length = firstClass.Length;
            Student[] bestStudents = new Student[length];
            firstClass.CopyTo(bestStudents, 0);
            if (firstClass.Length < secondClass.Length)
            {
                length = secondClass.Length;
                Array.Resize(ref bestStudents, secondClass.Length);
                secondClass.CopyTo(bestStudents, 0);
                Sort(ref bestStudents, firstClass);
            }
            else Sort(ref bestStudents, secondClass);

            return bestStudents;
        }

        public static void Sort(ref Student[] bestStudents, Student[] studentsClass)
        {
            for (int i = studentsClass.Length - 1; i >= 0; i--)
            {
                double bestResultOfClass = studentsClass[i].bestResult;
                for (int j = bestStudents.Length - 1; j >= 0; j--)
                {
                    if (bestResultOfClass > bestStudents[j].bestResult)
                    {
                        bestResultOfClass = bestStudents[j].bestResult;
                        Swap(ref bestStudents[j], ref studentsClass[i]);
                    }
                }
            }
        }

        public static void Swap(ref Student firstStudent, ref Student secondStudent)
        {
            Student temp = secondStudent;
            secondStudent = firstStudent;
            firstStudent = temp;
        }

        public static void Display(Student[] bestStudents)
        {
            for (int i = bestStudents.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("Имя: " + bestStudents[i].fullName + " Лучший результат: " + bestStudents[i].bestResult);
            }
        }
    }
}
