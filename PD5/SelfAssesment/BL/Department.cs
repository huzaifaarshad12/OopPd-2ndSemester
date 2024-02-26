using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssesment.BL
{
    internal class Department
    {
        public string Name;
        public List<Program> Programs;

        // Constructor
        public Department()
        {
            Programs = new List<Program>();
        }
    }
}
