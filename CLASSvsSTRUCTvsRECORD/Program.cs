namespace CLASSvsSTRUCTvsRECORD
{
    class StudentClass
    {
        public string Name;
        public int Age;

        public StudentClass(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    struct StudentStruct
    {
        public string Name;
        public int Age;

        public StudentStruct(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    record StudentRecord
    {
        public string Name;
        public int Age;

        public StudentRecord(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("class:");
            StudentClass student1 = new("Ahmed", 20);
            var student2 = student1;
            student2.Name = "Ali";
            Console.WriteLine(student1.Name); // Output: Ali
            //-----------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("struct:");
            StudentStruct student3 = new("Mohamed", 22);
            var student4 = student3;
            student4.Name = "Omar";
            Console.WriteLine(student3.Name); // Output: Mohamed
            //-----------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("record:");
            StudentRecord student5 = new("Sara", 21);
            StudentRecord student6 = new("Sara", 21);
            StudentRecord student7 = student5 with { Name = "Nora" };
            Console.WriteLine($"student5 == student6:{student5 == student6}");
            Console.WriteLine($"student5 == student7:{student5 == student7}");

        }
    }
}
