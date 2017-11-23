using System;

namespace studentsOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //find the number of created student objects, should be zero now
            Console.WriteLine("Number of students created: {0}", Student.StudentsCount());

            //create a new student s1 , providing all five parameters for the first overloaded constructor
            Student s1 = new Student("Ahmed", "ahmed@mans.edu.eg", "Mansoura", "Computer Engineering", 010000000);

            //print all s1 info
            Console.WriteLine("s1 Info:");
            s1.PrintInfo();

            //change s1 email
            s1.SetEmail("ahmed.ali@gmail.com");

            //now, print s1 email to make sure it has been successfully changed
            Console.WriteLine("s1 email now is: {0}", s1.GetEmail());

            //find the number of objects created, should be one now
            Console.WriteLine("Number of students created: {0}", Student.StudentsCount());

            //create a new student s2 using the second version of the overloaded constructor which takes only a string representing the name
            Student s2 = new Student("Mahmoud");

            //print s2 info
            Console.WriteLine("s2 Info:");
            s2.PrintInfo();

            //change s2 field values (other than name) to override default values given by the constructor
            s2.SetEmail("mahmoud@yahoo.com");
            s2.SetMajor("Civil Engineering");
            s2.SetPhone(0120000000);
            s2.SetUniversity("Cairo");

            //print s2 info again after changing its fields values
            Console.WriteLine("s2 Info:");
            s2.PrintInfo();

            //finally, find the number of created objects from Student class
            Console.WriteLine("Number of students created: {0}", Student.StudentsCount());

        }
    }
}
