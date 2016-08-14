using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        public static int[] InsertionSort(int[] intArray)
        {

            int temp;
            int j;
            for (int i = 1; i < intArray.Length; i++)
            {
                temp = intArray[i];
                j = i - 1;

                while (j >= 0 && intArray[j] > temp)
                {
                    intArray[j + 1] = intArray[j];
                    j--;
                }

                intArray[j + 1] = temp;
            }

            return intArray;
        }

        public static TimeSpan Benchmark(int elNum)
        {
            int[] intArray = new int[elNum];

            Random rand = new Random();

            for (int x = 0; x < intArray.Length; x++)
            {
                intArray[x] = rand.Next(1, elNum);
            }

            // Uncomment this section, if you want to print array
            Console.WriteLine("-------UnSorted Array Input-------");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }

            var timer = System.Diagnostics.Stopwatch.StartNew();

            intArray = InsertionSort(intArray);

            timer.Stop();

            // Uncomment this section, if you want to print array
            Console.WriteLine("-------Array After Isertion Sort-------");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }

            return timer.Elapsed;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Benchmark(5));

            Console.ReadKey();
        }
    }
}
