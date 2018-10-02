using System;
using System.Collections;
using System.Collections.Generic;

namespace SelfModul3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stude1 = new Student("João", 11);
            Student stude2 = new Student("Joãzinho", 12);
            Student stude3 = new Student("Joãozão", 13);

            for (int i = 0; i < 5; i++)
            {
                stude1.AddGrade(i*1);
                stude2.AddGrade(i*2);
                stude3.AddGrade(i*3);
            }

            ArrayList StudeArray = new ArrayList();
            StudeArray.Add(stude1);
            StudeArray.Add(stude2);
            StudeArray.Add(stude3);

            foreach (var item in StudeArray)
            {
                Student tempStudent = (Student)item;
                Console.WriteLine("Student name: {0}, age: {1}" + Environment.NewLine, tempStudent.Name, tempStudent.Age);
            }
        }
    }
}
