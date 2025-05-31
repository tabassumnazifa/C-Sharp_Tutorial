using System;
class Program
{
    static void Main(string[] args)
    {
        // Variable declarations with different data types
        string name;
        int age;
        double height;
        bool isStudent;

        // Input from user
        Console.Write("Enter your name: ");
        name = Console.ReadLine();

        Console.Write("Enter your age: ");
        age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your height in meters (e.g., 1.75): ");
        height = Convert.ToDouble(Console.ReadLine());

        Console.Write("Are you a student? (true/false): ");
        isStudent = Convert.ToBoolean(Console.ReadLine());

        // Output the values
        Console.WriteLine("\n--- User Details ---");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Height: " + height + " meters");
        Console.WriteLine("Student: " + isStudent);

    }
}
