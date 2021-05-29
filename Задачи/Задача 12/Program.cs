using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //True
            char[] firstArray = new char[] { 'G', 'T', 'U', 'W', 'G', 'A', 'O', 'K', 'T' };
            char[] secondArray = new char[] { 'A', 'O', 'K', 'T', 'G', 'T', 'U', 'W', 'G' };

            //False
            //char[] firstArray = new char[] { 'G', 'T', 'U', 'W', 'G', 'A', 'O', 'K', 'T' };
            //char[] secondArray = new char[] { 'A', 'O', 'Z', 'T', 'G', 'T', 'U', 'A', 'G' };
            Console.WriteLine(AreArraysSame(firstArray, secondArray));

            Console.ReadLine();
        }

        public static bool AreArraysSame(char[] firstArray, char[] secondArray)
        {
            foreach (char a in firstArray)
            {
                bool flag = false;
                for (int i = 0; i < secondArray.Length; i++)
                {
                    if (secondArray[i] == a)
                    {
                        secondArray[i] = '-';
                        flag = true;
                        break;
                    }
                }

                if (flag == false) return false;
            }

            return true;
        }
    }
}
