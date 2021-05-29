using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задачи
{
    //Напишите функцию, которая получает на вход два слова. Необходимо, чтобы эта подпрограмма
    //возвращала только те буквы слов, которые встречаются только в одном слове, но не в обоих.
    //Например, если заданные слова процессор и информация, то ответом должно быть: п е ф м а я с н и.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое слово: ");
            string strFirst = Console.ReadLine();
            Console.Write("Введите второе слово: ");
            string strSecond = Console.ReadLine();

            string uniqueChars = FindUniqueChar(strFirst, strSecond);
            Display(uniqueChars);

            Console.ReadLine();
        }

        public static string FindUniqueChar(string strFirst, string strSecond)
        {
            strFirst = new string(strFirst.Distinct().ToArray());
            strSecond = new string(strSecond.Distinct().ToArray());
            string answer = strFirst + strSecond;
            foreach (char letter in strFirst)
            {
                if (strSecond.Contains(letter))
                {
                    answer = answer.Remove(answer.IndexOf(letter), 1);
                    answer = answer.Remove(answer.IndexOf(letter), 1);
                }
            }
            return (answer);
        }

        public static void Display(string uniqueChars)
        {
            foreach (char a in uniqueChars)
            {
                Console.Write(a);
                Console.Write(" ");
            }
        }
        
    }
}
