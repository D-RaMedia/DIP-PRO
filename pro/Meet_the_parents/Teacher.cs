using System;
namespace classAssignment
{
    public class Teacher:Person
    {
        private string course;
        private int age;
        public Teacher(string name, string course, int age):base(name, age)
        {
            this.course = course;
            Console.WriteLine(" you teach " + course);

        }
    }
}