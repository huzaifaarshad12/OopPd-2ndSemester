using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ocean;

namespace ocean
{
    internal class Angle
    {
      

        public int degrees;
        public float minutes;
        public char direction;


        public void Changeangle()
        {
            Console.Write("Enter degrees:");
             degrees = int.Parse(Console.ReadLine());
            Console.Write("Enter minutes:");
            minutes = float.Parse(Console.ReadLine());
            Console.Write("Enter direction:");
             direction = char.Parse(Console.ReadLine());
            
        }

        public string viewangle()
        {
            string location=$"{degrees}\u00b0{minutes}'{direction}";
            return location;
        }
    }
}
