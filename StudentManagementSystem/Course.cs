using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    internal class Course
    {
        public Course(string courseID, string title, Instructor instructor)
        {
            CourseID = courseID;
            Title = title;
            Instructor = instructor;
        }
        public bool PrintDetails(string title, Instructor instructor)
        {
            return true;
        }


        public string CourseID { get; set; }
        public string Title { get; set; }
        public Instructor Instructor { get; set; }
    }
}
