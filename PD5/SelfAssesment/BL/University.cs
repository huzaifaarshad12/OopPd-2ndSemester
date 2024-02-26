using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssesment.BL
{
    internal class University
    {
        public string Name;
        public List<Department> Departments;

        // Constructor
        public University()
        {
            Departments = new List<Department>();
        }
    }
}
