using System;
public abstract class CoCurricular
{
    public abstract string ActivityName { get; set; }
    public abstract void DisplayInfo();
}
public class Student
{
    private string? name;
    private int age;
    public string? Name
    {
        get { return name; }
        set
        {
            name = value;
            nameList[0] = value;
        }
    }
    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    private static int size = 5;
    private string[] nameList = new string[size];
    public Student()
    {
        for (int i = 0; i < size; i++)
            nameList[i] = "N.A.";
    }


    public string this[int index]
    {
        get
        {
            if (index >= 0 && index < size)
                return nameList[index];
            else
                return "Invalid Index";
        }
        set
        {
            if (index >= 0 && index < size)
                nameList[index] = value;
        }
    }
}
public class Sports : CoCurricular
{
    private int sportspoint;
    private string activityName;
    public override string ActivityName
    {
        get { return activityName; }
        set { activityName = value; }
    }
    public int Sportspoint
    {
        get { return sportspoint; }
        set { sportspoint = value; }
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"Activity: {ActivityName}, Sportspoint: {sportspoint}");
    }



    public void DisplaySportspoint()
    {
        Console.WriteLine("Sportspoint: " + sportspoint);
    }
}
class MainClass
{
    static void Main()
    {
        Student student1 = new Student();
        student1.Name = "Akshat Mistry";
        student1.Age = 20;
        Console.WriteLine("Student Name: " + student1.Name);
        Console.WriteLine("Student Age: " + student1.Age);
        student1[1] = "Aryika";
        student1[2] = "Dhruv";
        Console.WriteLine("\nStudent Name List:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(student1[i]);
        }
        Sports sports1 = new Sports();
        sports1.Sportspoint = 80;
        sports1.ActivityName = "Basketball";
        sports1.DisplayInfo();
        sports1.DisplaySportspoint();
    }
}
