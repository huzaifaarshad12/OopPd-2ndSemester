using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Ludo;
namespace Ludo
{
    internal class Program
    {
        static Ludo l = new Ludo();
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a player name: ");
            for (int i = 0; i < 4; i++) 
            {
                Console.WriteLine(i);
                l.name = Console.ReadLine();
                l.names.Add(l.name);

            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("/t Ludo");

            for(int i = 0;i < l.names.Count; i++)
            {
                Console.WriteLine("Player " + (i+1) + "turn");
           
                int randomNumber = GetRandomNumber(1,6);
                Console.WriteLine("Random Number: " + randomNumber);
                l.N.Add(randomNumber);
                Console.ReadKey();


            }
            Console.Clear();
            Console.WriteLine("/t Ludo");
            int max = l.N[0];
            int idx = 0;
            for(int i = 0;i<l.N.Count;i++)
            {
                if (l.N[i] > max)
                {
                    max = l.N[i];
                    idx = i;
                }
            }
            Console.WriteLine("Winner is :");
            Console.WriteLine(l.names[idx] + ": " + l.N[idx]);
            Console.ReadKey();

        }
        static int GetRandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
