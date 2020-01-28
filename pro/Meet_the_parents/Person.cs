using System;
namespace classAssignment
{
    public class Person
    {
        private string name = "noname";
        private int age;

        public Person(string name, int age ){
            //constructor
            this.name = name;

            Console.Write("Hi there "+name );
        

            this.age = age;
            Console.WriteLine("And you are " + age + " years old.");
            Console.WriteLine("");
        }
        
    }
}