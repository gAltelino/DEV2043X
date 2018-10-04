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
        public Stack<float> Grades = new Stack<float>();
        public List<float> AnotherGrade = new List<float>();

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

            Students.Add(student1);
            Students.Add(student2);
            Students.Add(student3);

            //to quick add the grades and do the required work
            for (int i = 0; i < 5; i++)
            {
                foreach (Student stud in Students)
                {
                    stud.Grades.Push(i);
                }
            }

            foreach (Student item in Students)
            {
                Console.WriteLine(item.FirstName);
                Console.WriteLine(item.LastName);
                Console.WriteLine(item.Age);
                Console.WriteLine(item.Program);

                foreach (var grande in item.Grades)
                {
                    Console.WriteLine(grande);
                }
            }

            float lastGrande = 87;
            foreach (Student stud in Students)
            {
                stud.Grades.Pop();
                stud.Grades.Push(lastGrande);
                lastGrande = lastGrande + 28;

                foreach (var grande in stud.Grades)
                {
                    stud.AnotherGrade.Add(grande);
                }

                stud.AnotherGrade.Sort();
            }

            Console.WriteLine("Sorted data bellow");
            foreach (Student item in Students)
            {
                Console.WriteLine(item.FirstName);
                Console.WriteLine(item.LastName);
                Console.WriteLine(item.Age);
                Console.WriteLine(item.Program);

                foreach (var grande in item.AnotherGrade)
                {
                    Console.WriteLine(grande);
                }
            }

        }
    }
}
