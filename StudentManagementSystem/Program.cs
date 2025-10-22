namespace StudentManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instructor instances
            Instructor instructor1 = new Instructor(Guid.NewGuid().ToString().Substring(0, 7), "Ahmed", "Math");
            instructor1.PrintDetails("Ahmed", "Math");
            Instructor instructor2 = new Instructor(Guid.NewGuid().ToString().Substring(0, 7), "Ali", "English");
            instructor2.PrintDetails("Ali", "English");
            Instructor instructor3 = new Instructor(Guid.NewGuid().ToString().Substring(0, 7), "Sara", "Arabic");
            instructor3.PrintDetails("Sara", "Arabic");
            Instructor instructor4 = new Instructor(Guid.NewGuid().ToString().Substring(0, 7), "Nora", "Science");
            instructor4.PrintDetails("Nora", "Science");
            Instructor instructor5 = new Instructor(Guid.NewGuid().ToString().Substring(0, 7), "Mohamed", "Social Studies");
            instructor5.PrintDetails("Mohamed", "Social Studies");

            //Course instances
            Course course1 = new Course(Guid.NewGuid().ToString().Substring(0, 7), "Mathematics", instructor1);
            course1.PrintDetails("Mathematics", instructor1);
            Course course2 = new Course(Guid.NewGuid().ToString().Substring(0, 7), "English Literature", instructor2);
            course2.PrintDetails("English Literature", instructor2);
            Course course3 = new Course(Guid.NewGuid().ToString().Substring(0, 7), "Arabic Language", instructor3);
            course3.PrintDetails("Arabic Language", instructor3);
            Course course4 = new Course(Guid.NewGuid().ToString().Substring(0, 7), "Science", instructor4);
            course4.PrintDetails("Science", instructor4);
            Course course5 = new Course(Guid.NewGuid().ToString().Substring(0, 7), "Social Studies", instructor5);
            course5.PrintDetails("Social Studies", instructor5);

            //Student instances
            Student student1 = new Student(Guid.NewGuid().ToString().Substring(0, 7), "Omar", 20, new List<Course> { course1, course2 });
            student1.PrintDetails("Omar", 20, new List<Course> { course1, course2 });
            student1.EnrollInCourse(course1);
            student1.EnrollInCourse(course2);
            Student student2 = new Student(Guid.NewGuid().ToString().Substring(0, 7), "Laila", 22, new List<Course> { course3, course4 });
            student2.PrintDetails("Laila", 22, new List<Course> { course3, course4 });
            student2.EnrollInCourse(course3);
            student2.EnrollInCourse(course4);
            Student student3 = new Student(Guid.NewGuid().ToString().Substring(0, 7), "Youssef", 21, new List<Course> { course5 });
            student3.PrintDetails("Youssef", 21, new List<Course> { course5 });
            student3.EnrollInCourse(course5);

            //StudentManager instance
            StudentManager studentManager = new StudentManager(new List<Student> { student1, student2, student3 }, new List<Instructor> { instructor1, instructor2, instructor3, instructor4, instructor5 }, new List<Course> { course1, course2, course3, course4, course5 });
            studentManager.AddStudent(student1);
            studentManager.AddStudent(student2);
            studentManager.AddStudent(student3);
            //---------------------------------------------------------------------------------------------------
            studentManager.RemoveStudent(student3);
            //----------------------------------------------------------------------------------------------------
            studentManager.AddInstructor(instructor1);
            studentManager.AddInstructor(instructor2);
            studentManager.AddInstructor(instructor3);
            studentManager.AddInstructor(instructor4);
            studentManager.AddInstructor(instructor5);
            //---------------------------------------------------------------------------------------------------
            studentManager.AddCourse(course1);
            studentManager.AddCourse(course2);
            studentManager.AddCourse(course3);
            studentManager.AddCourse(course4);
            studentManager.AddCourse(course5);
            //---------------------------------------------------------------------------------------------------
            studentManager.EnrollStudentInCourse(student1.StudentID, course1.CourseID);
            studentManager.EnrollStudentInCourse(student1.StudentID, course2.CourseID);
            studentManager.EnrollStudentInCourse(student2.StudentID, course3.CourseID);
            studentManager.EnrollStudentInCourse(student2.StudentID, course4.CourseID);
            studentManager.EnrollStudentInCourse(student3.StudentID, course5.CourseID);
            //---------------------------------------------------------------------------------------------------
            studentManager.FindStudent(student1.StudentID);
            studentManager.FindStudent(student2.StudentID);
            studentManager.FindStudent(student3.StudentID);
            //---------------------------------------------------------------------------------------------------
            studentManager.FindInstructor(instructor1.InstructorID);
            studentManager.FindInstructor(instructor2.InstructorID);
            studentManager.FindInstructor(instructor3.InstructorID);
            studentManager.FindInstructor(instructor4.InstructorID);
            studentManager.FindInstructor(instructor5.InstructorID);
            //---------------------------------------------------------------------------------------------------
            studentManager.FindCourse(course1.CourseID);
            studentManager.FindCourse(course2.CourseID);
            studentManager.FindCourse(course3.CourseID);
            studentManager.FindCourse(course4.CourseID);
            studentManager.FindCourse(course5.CourseID);
            //---------------------------------------------------------------------------------------------------
            studentManager.EnrollStudentInCourse(student1.StudentID, course1.CourseID);
            studentManager.EnrollStudentInCourse(student1.StudentID, course2.CourseID);
            studentManager.EnrollStudentInCourse(student2.StudentID, course3.CourseID);
            studentManager.EnrollStudentInCourse(student2.StudentID, course4.CourseID);
            studentManager.EnrollStudentInCourse(student3.StudentID, course5.CourseID);
            //---------------------------------------------------------------------------------------------------
            studentManager.ShowAllStudents();
            //---------------------------------------------------------------------------------------------------
            studentManager.ShowAllInstructors();
            //---------------------------------------------------------------------------------------------------
            studentManager.ShowAllCourses();



        }
    }
       
    }
