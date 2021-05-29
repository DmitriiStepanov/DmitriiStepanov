using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_11
{
    class Program
    {
        public struct Сhange
        {
            public byte operation; //0 - удаление, 1- добавление, 2 - изменение
            public int index;
            public int value;
            public int previousValue;
            public Сhange(byte operation, int index, int value, int previousValue)
            {
                this.operation = operation;
                this.index = index;
                this.value = value;
                this.previousValue = previousValue;
            }
        }
        static void Main(string[] args)
        {
            List<int> arrData = new List<int> { 2, 5, 8, 2, 6 };
            List<Сhange> arrChanges = new List<Сhange>();
            arrChanges.Add(new Сhange(0, 3, 2, 5));
            arrChanges.Add(new Сhange(1, 4, 6, 0));
            arrChanges.Add(new Сhange(2, 1, 5, 3));
            BackToTheFuture(arrChanges, arrData);
            foreach (int i in arrData)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
        public static void BackToTheFuture(List<Сhange> arrChanges, List<int> arrData)
        {
            arrChanges.Reverse();
            foreach (Сhange change in arrChanges)
            {
                switch (change.operation)
                {
                    case 0:
                        arrData.Insert(change.index, change.previousValue);
                        break;
                    case 1:
                        arrData.RemoveAt(change.index);
                        break;
                    case 2:
                        arrData[change.index] = change.previousValue;
                        break;
                }
            }
        }
    }
}
