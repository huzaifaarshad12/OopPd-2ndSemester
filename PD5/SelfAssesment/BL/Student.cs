using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssesment.BL
{
    internal class Student
    {
        public string Name;
        public int Age;
        public string EducationalQualifications;
        public int EcatMarks;
        public List<string> Preferences;
        public List<Subject> RegisteredSubjects;

        // Constructor
        public Student()
        {
            Preferences = new List<string>();
            RegisteredSubjects = new List<Subject>();
        }
    }
}
