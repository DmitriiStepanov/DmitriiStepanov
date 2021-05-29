using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[7][];
            arr[0] = new int[6];
            arr[1] = new int[3];
            arr[2] = new int[5];
            arr[3] = new int[8];
            arr[4] = new int[3];
            arr[5] = new int[2];
            arr[6] = new int[4];
            QuickSort(arr);
            Display(arr);

            Console.ReadLine();
        }

        public static void QuickSort(int[][] arr)
        {
            QuickSort(arr, 0, arr.Length - 1);
        }
        public static void QuickSort(int[][] arr, int left, int right)
        {
            int l = left, r = right;
            int pivot = arr[l].Length;
            while (l <= r)
            {
                while (arr[l].Length < pivot) l++;
                while (arr[r].Length > pivot) r--;
                if (l <= r) Swap(ref arr[l++], ref arr[r--]);
            }
            if (left < r) QuickSort(arr, left, r);
            if (right > l) QuickSort(arr, l, right);
        }
        public static void Swap(ref int[] first, ref int[] second)
        {
            int[] temp = first;
            first = second;
            second = temp;
        }

        public static void Display(int[][] arr)
        {
            foreach (int[] arrA in arr)
            {
                Console.WriteLine(arrA.Length);
            }
        }
    }
}
