using System;
namespace classAssignment
{
    public class Parent:Person
    {
        private string course;
        public Parent(string name, string course) : base(name)
        {
            this.course = course;
            Console.WriteLine(" You work as a " + course);
            Console.WriteLine("");
        }
    }
}