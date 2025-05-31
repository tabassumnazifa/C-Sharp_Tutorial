using System;

class Program
{
    static void Main(string[] args)
    {
        // Input
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your total marks (0-100): ");
        double marks = Convert.ToDouble(Console.ReadLine());

        // Validate and determine grade
        if (marks < 0 || marks > 100)
        {
            Console.WriteLine("Invalid marks! Please enter between 0 and 100.");
        }
        else
        {
            string grade = "";

            if (marks >= 90) grade = "A+";
            else if (marks >= 80) grade = "A";
            else if (marks >= 70) grade = "B";
            else if (marks >= 60) grade = "C";
            else if (marks >= 50) grade = "D";
            else grade = "F";

            // Output
            Console.WriteLine($"\n{name}, your grade is: {grade}");
        }
    }
}
