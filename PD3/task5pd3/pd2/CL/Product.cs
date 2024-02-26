using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pd2.CL
{
    internal class Product
    {
        public static int idCounter = 1;

        public int Id;
        public string Name;
        public decimal Price;

        public Product()
        {
            Id = idCounter++;
        }
    }
}
