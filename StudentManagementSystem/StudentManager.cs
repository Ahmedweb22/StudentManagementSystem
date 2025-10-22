using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    internal class StudentManager
    {
        public StudentManager(List<Student> students, List<Instructor> instructors, List<Course> courses)
        {
            Students = students;
            Instructors = instructors;
            Courses = courses;
        }
        public bool AddStudent(Student student)
        {
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].StudentID == student.StudentID)
                {
                    return false;
                }
            }
            Students.Add(student);
            return true;
        }
        //Bonus
        public bool RemoveStudent(Student student)
        {
            return Students.Remove(student);
        }
        //--------------------------------------------------
        public bool AddInstructor(Instructor instructor)
        {
            for (int i = 0; i < Instructors.Count; i++)
            {
                if (Instructors[i].InstructorID == instructor.InstructorID)
                {
                    return false;
                }
            }
            Instructors.Add(instructor);
            return true;
        }
        public bool AddCourse(Course course)
        {
            for (int i = 0; i < Courses.Count; i++)
            {
                if (Courses[i].CourseID == course.CourseID)
                {
                    return false;
                }
            }
            Courses.Add(course);
            return true;
        }
        public Student FindStudent(string studentID)
            {
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].StudentID == studentID)
                {
                    return Students[i];
                }
            }
            return null;
        }
        public Instructor FindInstructor(string instructorID)
        {
            for (int i = 0; i < Instructors.Count; i++)
            {
                if (Instructors[i].InstructorID == instructorID)
                {
                    return Instructors[i];
                }
            }
            return null;
        }
        public Course FindCourse(string courseID)
        {
            for (int i = 0; i < Courses.Count; i++)
            {
                if (Courses[i].CourseID == courseID)
                {
                    return Courses[i];
                }
            }
            return null;
        }
        public bool EnrollStudentInCourse(string studentID, string courseID)
        {
            Student student = FindStudent(studentID);
            Course course = FindCourse(courseID);
            if (student != null && course != null)
            {
                student.EnrollInCourse(course);
                return true;
            }
            return false;
        }
        public bool ShowAllStudents()
        {
            for (int i = 0; i < Students.Count; i++)
            {
                Console.WriteLine($"Student ID: {Students[i].StudentID}, Name: {Students[i].Name}, Age: {Students[i].Age}");
            }
            return true;
        }
        public bool ShowAllInstructors()
        {
            for (int i = 0; i < Instructors.Count; i++)
            {
                Console.WriteLine($"Instructor ID: {Instructors[i].InstructorID}, Name: {Instructors[i].Name}, Specialization: {Instructors[i].Specialization}");
            }
            return true;
        }
        public bool ShowAllCourses()
        {
            for (int i = 0; i < Courses.Count; i++)
            {
                Console.WriteLine($"Course ID: {Courses[i].CourseID}, Title: {Courses[i].Title}, Instructor: {Courses[i].Instructor.Name}");
            }
            return true;
        }


        public List<Student> Students { get; set; } = new List<Student>();
        public List<Instructor> Instructors { get; set; } = new List<Instructor>();
        public List<Course> Courses { get; set; } = new List<Course>();

    }
}
