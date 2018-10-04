using System;
using System.Collections.Generic;

namespace GenericList
{

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Program { get; set; }

        public Student(string firstName, string lastName, int age, string program)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Program = program;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            List<Student> Students = new List<Student>();

            Student student1 = new Student("Tom", "Thumb", 12, "Computer Science");
            Student student2 = new Student("Fred", "Flintstone", 45, "Geology");
            Student student3 = new Student("Mickey", "Mouse", 35, "Animation");

            Students.AddRange(new List<Student> { new Student("Tom", "Thumb", 12, "Computer Science"),
             new Student("Fred", "Flintstone", 45, "Geology"), new Student("Mickey", "Mouse", 35, "Animation") });

            foreach (Student item in Students)
            {
                Console.WriteLine(item.FirstName);
                Console.WriteLine(item.LastName);
                Console.WriteLine(item.Age);
                Console.WriteLine(item.Program);
            }
        }
    }
}
