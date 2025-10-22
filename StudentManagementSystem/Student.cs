using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    internal class Student
    {
        public Student(string studentID, string name, int age, List<Course> courses)
        {
            StudentID = studentID;
            Name = name;
            Age = age;
            Courses = courses;
        }
        public bool EnrollInCourse(Course course)
        {
            Courses.Add(course);
            return true;
        }
        public bool PrintDetails( string name, int age, List<Course> courses)
        {
            return true;
        }

        public string StudentID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();


    }
}
