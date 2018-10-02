using System;
using System.Collections;
using System.Collections.Generic;

namespace SelfModul3
{
    public class Student
    {
        public int Id { get; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Stack<int> Grades { get; set; }
        static int _id = 0;

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Id = _id;
            Grades = new Stack<int>();
            _id++;
        }

        public void AddGrade(int grade)
        {
            this.Grades.Push(grade);
        }
    }
}