using System;

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

class Program
{
    static void Main()
    {
        SportsStudent student1 = new SportsStudent();
        student1.Name = "Akshat";
        student1.Age = 20;

        RankStudent student2 = new RankStudent();
        student2.Name = "Akx";
        student2.Age = 19;

        Console.WriteLine("Sports Student Details:");
        student1.DisplayStudent();
        Console.WriteLine();

        Console.WriteLine("Ranked Student Details:");
        student2.DisplayStudent();
    }
}
