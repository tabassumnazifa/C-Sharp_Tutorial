using System;

// Base class 'person' - holds common properties for all persons
public class person
{
    // Auto-implemented property for person's name
    public string name { get; set; }
}

// Derived class 'student' inherits from 'person' (Single Inheritance)
public class student : person
{
    // Student-specific property
    public int id { get; set; }

    // Method to display student details
    public void display()
    {
        Console.WriteLine("Name:" + name);
        Console.WriteLine("ID:" + id);
    }
}

// Derived class 'academic' inherits from 'student' (Multilevel Inheritance)
public class academic : student
{
    // Academic-specific property (e.g., CGPA)
    public decimal cgpa { get; set; }

    // Method to display CGPA
    public void displaycg()
    {
        Console.WriteLine("CGPA:" + cgpa);
    }
}

// Interface defining a property 'curriculum'
// Interfaces are used to achieve Multiple Inheritance in C#
interface Icurriculum
{
    string curriculum { get; set; }
}

// Another interface defining a property 'sport'
interface Isport
{
    string sport { get; set; }
}

// Class implementing two interfaces (Multiple Inheritance via interfaces)
public class extracurriculur : Icurriculum, Isport
{
    // Implementation of Icurriculum interface property
    public string curriculum { get; set; }

    // Implementation of Isport interface property
    public string sport { get; set; }

    // Method to display extra curriculum details
    public void displayextra()
    {
        Console.WriteLine("curriculum:" + curriculum);
        Console.WriteLine("sport:" + sport);
    }
}

// Main program class
class program
{
    static void Main()
    {
        // Prompt user for basic academic details
        Console.WriteLine("Enter Name,ID,CGPA");

        // Create object of 'academic' class
        academic a = new academic();

        // Accept user inputs and assign to properties inherited from 'person' and 'student'
        a.name = Console.ReadLine();
        a.id = Convert.ToInt32(Console.ReadLine());
        a.cgpa = Convert.ToDecimal(Console.ReadLine());

        // Call methods to display the entered academic details
        a.display();      // From 'student' class
        a.displaycg();    // From 'academic' class

        // Prompt user for extracurricular details
        Console.WriteLine("Enter Extra Curriculum");

        // Create object of 'extracurriculur' class which implements two interfaces
        extracurriculur e = new extracurriculur();

        // Accept inputs for curriculum and sport, implementing multiple inheritance through interfaces
        e.curriculum = Console.ReadLine();
        e.sport = Console.ReadLine();

        // Display the extra curriculum information
        e.displayextra();
    }
}
