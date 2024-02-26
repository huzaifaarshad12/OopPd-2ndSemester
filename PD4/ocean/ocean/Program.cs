using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ocean;

namespace ocean
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ship> shiplist = new List<Ship>();
            while (true)
            {
                int option = menu();
                if (option == 1)
                {
                    Addship(shiplist);
                }
                else if (option==2)
                {
                    Viewshipposition(shiplist);
                }
                else if (option == 3)
                {
                   changeposition(shiplist);
                }
                else if (option == 4)
                {
                    Viewshipposition(shiplist); 
                }
                else
                {
                    continue;
                }
            }
        }
        static int menu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Ship Management System");
            Console.WriteLine("1. Add Ship");
            Console.WriteLine("2. View Ship Position");
            Console.WriteLine("3. Update Ship Position");
            Console.WriteLine("4. View Ship serial number");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter your choice");
            int choice = int.Parse(Console.ReadLine());
            return choice;

        }
        static void Addship(List<Ship> shiplist)
        {
            Ship ship = new Ship();
            Console.Write("Enter Ship Number: ");
            ship.srno = Console.ReadLine();
            ship.latitude();
            ship.longitude();
            shiplist.Add(ship);
        }
        static void Viewshipposition(List<Ship> shiplist)
        {
            Console.Write("Enter ship's seriel number: ");
            string str=Console.ReadLine();
            for (int i = 0; i < shiplist.Count; i++)
            {
                if (shiplist[i].srno == str)
                {
                    shiplist[i].viewshipposition();
                }
            }
        }
        static void Viewshipserialno(List<Ship> shiplist)
        {
            Console.Write("Enter the ship's Latitude: ");
            string latitude=Console.ReadLine();
            Console.Write("Enter the ship's Latitude: ");
            string longitude = Console.ReadLine();
            foreach (Ship ship in shiplist)
            {
                if(ship.checkcoordinates(latitude, longitude))
                {
                    Console.WriteLine($"Ship's serial number is {ship.srno}");
                }
            }
        }

        static void changeposition(List<Ship> shiplist)
        {
            Console.Write("Enter ship's seriel number: ");
            string str = Console.ReadLine();
            for (int i = 0; i < shiplist.Count; i++)
            {
                if (shiplist[i].srno == str)
                {
                    shiplist[i].Changeposition();
                }
            }
        }
    }
}
