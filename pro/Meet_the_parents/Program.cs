using System;

namespace classAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher t1 = new Teacher("Erwin", "PRO2", 35);
            Teacher t2 = new Teacher("Erik", "PRO2", 34);
            Teacher t3 = new Teacher("Theo", "PRO1", 95);
            Teacher t4 = new Teacher("Gretha", "PROJ", 45);

            Student s1 = new Student("Harry", "Mediadeveloper", 23);
            Student s2 = new Student("Donny", "Gamedeveloper", 42);
            Student s3 = new Student("Diego", "Gamedeveloper", 17);

            Parent p1 = new Parent("Victor", 50, 5);
        }
    }
}
