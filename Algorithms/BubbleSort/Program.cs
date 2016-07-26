using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        public static int[] Sort(int[] intArray)
        {
            for (int i = intArray.Length - 1; i > 0; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    if (intArray[j] > intArray[j + 1])
                    {
                        int higherValue = intArray[j];

                        intArray[j] = intArray[j + 1];
                        intArray[j + 1] = higherValue;
                    }
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
            //Console.WriteLine("-------UnSorted Array Input-------");
            //for (int i = 0; i < intArray.Length; i++)
            //{
            //    Console.WriteLine(intArray[i]);
            //}

            var timer = Stopwatch.StartNew();

            intArray = Sort(intArray);

            timer.Stop();

            // Uncomment this section, if you want to print array
            //Console.WriteLine("-------Array After Bubble Sort-------");
            //for (int i = 0; i < intArray.Length; i++)
            //{
            //    Console.WriteLine(intArray[i]);
            //}

            return timer.Elapsed;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(Benchmark(5));

            Console.WriteLine(Benchmark(100));

            Console.WriteLine(Benchmark(500));

            Console.WriteLine(Benchmark(10000));

            Console.WriteLine(Benchmark(100000));

            Console.ReadKey();
        }
    }
}
