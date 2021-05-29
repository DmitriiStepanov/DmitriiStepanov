using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string txtPath = @"C:\Users\megas\Desktop\Прога Экзамен\Задачи\Задача 7\text.txt";
            if (File.Exists(txtPath))
            {
                List<string> sortList = SortBy(txtPath);
                Display(sortList);
            }
            else Console.WriteLine("Указанного файла не существует.");

            Console.ReadLine();
        }

        public static List<string> SortBy(string txtPath)
        {
            List<string> sortList = new List<string>();
            FileStream fileStream = new FileStream(txtPath, FileMode.Open);
            using (StreamReader streamReader = new StreamReader(fileStream))
            {
                while (!streamReader.EndOfStream)
                {
                    string str = streamReader.ReadLine();
                    sortList.Add(str.Split(':')[0]);
                }
            }
            sortList.Sort();

            return sortList;
        }

        public static void Display(List<string> sortList)
        {
            foreach (string a in sortList)
            {
                Console.WriteLine(a);
            }
        }
    }
}
