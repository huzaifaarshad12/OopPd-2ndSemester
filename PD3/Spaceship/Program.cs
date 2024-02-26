using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Spaceship
{
    internal class Program
    {
        static Ship s1 = new Ship(); 
        static List<Person> list = new List<Person>();
        static List<Ship> ship = new List<Ship>();
        static void Main(string[] args)
        {
            string option = Menu();
            if(option == "1")
            {

                Console.Clear();
                Ship s2 = s1;
                Console.WriteLine("Enter Ship Name: ");
                s2.ShipName = Console.ReadLine();
                Console.WriteLine("Enter Driver: ");
                s2.Driver = Console.ReadLine();
                Console.WriteLine("Enter Destination: ");
                s2.Destination = Console.ReadLine();
                Console.ReadKey();
            }
            if (option == "2")
            {
                if(s1.ShipName !=null)
                {

                }


            }
            if (option == "3")
            {

            }
            if (option == "4")
            {

            }
            if (option == "5")
            {

            }


        }
        static string Menu()
        {
            string option;
            Console.WriteLine("1.Add Ship ");
            Console.WriteLine("2.Add Passenger");
            Console.WriteLine("3.Remove Ship ");
            Console.WriteLine("4.View Ship");
            Console.WriteLine("5.Passenger");
            option = (Console.ReadLine());

            return option;

        }
    }
}
