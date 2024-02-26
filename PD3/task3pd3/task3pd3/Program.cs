using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3pd3.BL;

namespace task3pd3
{
    internal class Program
    {
        static void Main()
        {
            Shiritori shiritoriGame = new Shiritori();

            Console.WriteLine("Shiritori Game Started!");

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nMenu Options:");
                Console.WriteLine("1. Play");
                Console.WriteLine("2. Restart");
                Console.WriteLine("3. Exit");

                Console.Write("Enter your choice (1-3): ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter a word to play: ");
                        string userWord = Console.ReadLine();
                        List<string> result = shiritoriGame.Play(userWord);

                        if (result != null)
                        {
                            Console.WriteLine("Words said: " + string.Join(" -> ", result));
                        }
                        break;

                    case 2:
                        Console.WriteLine(shiritoriGame.Restart());
                        break;

                    case 3:
                        Console.WriteLine("Exiting the program.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
                        break;
                }
            }
        }
    }
}
