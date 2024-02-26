using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1,5,7,3,9,4,8};
               foreach (int i in list)
            {
                Console.Write($"{i} ");
            }
               Console.WriteLine();
            list.Sort();
            foreach (int i in list)
            {
                Console.Write($"{i} ");
            }
            Console.ReadKey();
        }
    }
}
