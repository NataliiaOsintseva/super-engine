using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSort
{
    class Program
    {
        public static int[] ShellSort(int[] intArray)
        {
            int gap = intArray.Length / 2;
            while (gap > 0)
            {
                for(int i = 0; i < intArray.Length - gap; i++)
                {
                    int j = i + gap;
                    int temp = intArray[j];

                    while (j >= gap && temp > intArray[j - gap])
                    {
                        intArray[j] = intArray[j - gap];
                        j -= gap;
                    }
                    intArray[j] = temp;
                }
                if (gap == 2)
                {
                    gap = 1;
                }
                else
                {
                    gap = (int)(gap / 2.2);
                }
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

            intArray = ShellSort(intArray);

            timer.Stop();

            // Uncomment this section, if you want to print array
            Console.WriteLine("-------Array After Shell Sort-------");
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
