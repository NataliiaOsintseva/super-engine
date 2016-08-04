using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            Random rand = new Random();

            for (int x = 0; x < 10; x++)
            {
                list.Add(rand.Next(1, 50));
            }

            Console.WriteLine(list.Count);
            Console.ReadLine();
        }
    }
}
