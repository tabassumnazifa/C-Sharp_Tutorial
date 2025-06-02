using System;
class Program
{
    static void Main()
    {
        // 1️⃣ Pass by Value
        int a = 10;
        Console.WriteLine("Before PassByValue: " + a);
        PassByValue(a);
        Console.WriteLine("After PassByValue: " + a + "\n");

        // 2️⃣ Pass by Reference - ref
        int b = 10;
        Console.WriteLine("Before PassByRef: " + b);
        PassByRef(ref b);
        Console.WriteLine("After PassByRef: " + b + "\n");

        // 3️⃣ Pass by Reference - out
        int c;
        PassByOut(out c);
        Console.WriteLine("After PassByOut: " + c + "\n");

        // 4️⃣ Default Parameter
        Greet();             // Hello, Guest
        Greet("Nazifa");     // Hello, Nazifa
        Console.WriteLine();

        // 5️⃣ params
        int total = Sum(1, 2, 3, 4, 5);
        Console.WriteLine("Sum using params: " + total + "\n");

        // 6️⃣ Return Type
        int result = Multiply(6, 7);
        Console.WriteLine("Multiply Result: " + result);
    }

    // Pass by Value
    static void PassByValue(int x)
    {
        x = x + 5;
        Console.WriteLine("Inside PassByValue: " + x);
    }

    // Pass by Reference using ref
    static void PassByRef(ref int x)
    {
        x = x + 5;
        Console.WriteLine("Inside PassByRef: " + x);
    }

    // Pass by Reference using out
    static void PassByOut(out int x)
    {
        x = 100;
        Console.WriteLine("Inside PassByOut: " + x);
    }

    // Default Parameter
    static void Greet(string name = "Guest")
    {
        Console.WriteLine("Hello, " + name);
    }

    // params
    static int Sum(params int[] numbers)
    {
        int total = 0;
        foreach (int n in numbers)
            total += n;
        return total;
    }

    // Return type method
    static int Multiply(int a, int b)
    {
        return a * b;
    }
}
