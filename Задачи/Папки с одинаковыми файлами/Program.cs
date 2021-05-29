using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Первый путь: ");
            string strFirstPath = Console.ReadLine();
            Console.Write("Второй путь: ");
            string strSecondPath = Console.ReadLine();

            Console.WriteLine(IsEqual(strFirstPath, strSecondPath));

            Console.ReadLine();
        }

        public static bool IsEqual(string Dir1, string Dir2)
        {
            List<string> filesNamesDir1 = new List<string>();
            List<string> filesNamesDir2 = new List<string>();

            GetFullFilesNames(Dir1, filesNamesDir1);
            GetFullFilesNames(Dir2, filesNamesDir2);

            foreach (string file in filesNamesDir1)
            {
                if (!filesNamesDir2.Contains(file)) return false;
            }

            return filesNamesDir1.Count == filesNamesDir2.Count;
        }

        private static void GetFullFilesNames(string path, List<string> filesNames)
        {
            try
            {
                foreach (string file in Directory.EnumerateFiles(path))
                {
                    filesNames.Add(Path.GetFileName(file));
                }
            }
            catch (Exception) { }
        }
    }
}
