using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssesment.BL
{
    internal class program
    {
        public string Title;
        public int Duration;
        public List<Subject> Subjects { get; set; }
        public int AvailableSeats;

        // Constructor
        public program()
        {
            Subjects = new List<Subject>();
        }
    }
}
