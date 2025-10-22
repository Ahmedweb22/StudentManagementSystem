using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    internal class Instructor
    {
        public Instructor(string instructorID, string name, string specialization)
        {
            InstructorID = instructorID;
            Name = name;
            Specialization = specialization;
        }
        public bool PrintDetails( string name, string specialization)
        {
            return true;
        }

        public string InstructorID { get; set; }    
        public string Name { get; set; }
        public string Specialization { get; set; }


    }
}
