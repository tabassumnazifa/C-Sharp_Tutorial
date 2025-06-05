using System;

public class Student
{
    // Encapsulated fields with properties
    private int age;

    public string Name { get; set; }

    public int Age
    {
        get { return age; }
        set
        {
            if (value > 0 && value <= 100)
                age = value;
        }
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student();
        student.Name = "Nazifa";
        student.Age = 24;

        Console.WriteLine("Name: " + student.Name);
        Console.WriteLine("Age: " + student.Age);
    }
}
