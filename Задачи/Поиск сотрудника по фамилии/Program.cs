using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> people = new List<List<string>>(4);
            people.Add(new List<string>());
            people.Add(new List<string>());
            people.Add(new List<string>());
            people.Add(new List<string>());
            people[0].Add("Комарова");
            people[0].Add("Комарова");
            people[0].Add("Щукин");
            people[1].Add("Комарова");
            people[1].Add("Щукин");
            people[2].Add("Комарова");
            people[3].Add("Комарова");
            people[3].Add("Комарова");
            people[3].Add("Комарова");
            people[3].Add("Щукин");
            List<int> result = FindWorker(people, "Щукин");
            foreach (int group in result)
            {
                Console.WriteLine(group);
            }

            Console.ReadLine();
        }
        public static List<int> FindWorker(List<List<string>> allworkers, string worker)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < allworkers.Count(); i++)
            {
                if (BinarySearch(allworkers[i], worker))
                {
                    result.Add(i);
                }
            }
            return result;
        }
        static bool BinarySearch(List<string> group, string worker)
        {
            int left = 0;
            int right = group.Count() - 1;
            int mid;
            while (left <= right)
            {
                mid = (left + right) / 2;
                if (group[mid].Equals(worker))
                {
                    return true;
                }
                if (String.Compare(group[mid], worker) < 0)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return false;
        }
    }
}
