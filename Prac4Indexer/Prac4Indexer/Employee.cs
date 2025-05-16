using System;

namespace MyApp
{
    abstract class Student
    {
        // Properties with get and set
        public string Name { get; set; }
        public int Age { get; set; }

        // Abstract property
        public abstract string Category { get; }

        public void DisplayStudent()
        {
            Console.WriteLine("Student Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Category: " + Category);
        }
    }

    class SportsStudent : Student
    {
        public override string Category => "Sports";
    }

    class RankStudent : Student
    {
        public override string Category => "Academic Rank";
    }

}
