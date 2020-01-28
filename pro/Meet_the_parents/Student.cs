using System;
namespace classAssignment
{
    public class Student : Person{

        public Student(string name, string education, int age) : base(name, age){
            //constructor
            Console.WriteLine(" You're studying "+education);

        }
    }
}