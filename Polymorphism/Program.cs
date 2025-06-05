using System;                          // Importing the System namespace, which provides fundamental classes like Console.
using System.Runtime.InteropServices;  // Imports types that support COM interop and platform invocation services (not used in this code).

// A class named 'Add' for demonstrating method overloading.
public class Add
{
    // Method with no parameters that adds two predefined numbers.
    public void Addition()
    {
        int a = 10, b = 5;                     // Declares two integers a and b.
        int sum = a + b;                       // Adds a and b.
        Console.WriteLine("The Result Is: " + sum);  // Prints the result.
    }

    // Overloaded method that takes two integers as parameters.
    public void Addition(int a, int b)
    {
        int sum = a + b;                       // Adds the provided integers.
        Console.WriteLine("The Result Is: " + sum);  // Prints the result.
    }
}

// A base class named 'first'.
public class first
{
    // A method named 'show' that prints a welcome message.
    public void show()
    {
        Console.WriteLine("Welcome Here first");
    }
}

// A derived class 'second' that inherits from 'first'.
public class second : first
{
    // This method hides the base class method using method hiding (not overriding).
    public void show()
    {
        base.show();                           // Calls the 'show' method of the base class 'first'.
        Console.WriteLine("Welcome Here second");  // Prints the second message.
        base.show();                           // Calls base class 'show' again.
    }
}

// Main Program class
class Program
{
    // Main method: entry point of the program.
    static void Main()
    {
        Add obj = new Add();                   // Creates an object of class 'Add'.
        obj.Addition();                        // Calls the parameterless Addition method.

        Console.WriteLine("Enter Value:");     // Prompts the user for input.

        int n1 = Convert.ToInt32(Console.ReadLine());  // Reads first integer input from user.
        int n2 = Convert.ToInt32(Console.ReadLine());  // Reads second integer input from user.

        obj.Addition(n1, n2);                  // Calls the overloaded Addition method with user inputs.

        second s = new second();               // Creates an object of derived class 'second'.
        s.show();                              // Calls the 'show' method of class 'second'.
                                               // This calls base.show(), then prints, then base.show() again.
    }
}
