using System;
namespace classAssignment
{
    public class Parent:Person
    {
        private int age;
        private int kids;
        public Parent(string name, int age, int kids) : base(name, age)
        {
            this.kids = kids;
            Console.WriteLine(" You have " + kids + " kids,");
            this.age = age;
            Console.WriteLine("And you are " + age + " years old.");
            Console.WriteLine("");
        }

        public int Age
        {
            get { return age;}
            set { age = value;}
        }

        public int Kids
        {
            get { return kids;}
            set { kids = value;}
        }
    }
}