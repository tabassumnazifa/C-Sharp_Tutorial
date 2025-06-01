using System;
class looptutorial
{
    static void Main()
    {
        Console.WriteLine("Demonstrating different loops in C#:\n");

        // 1. For loop - print numbers 1 to 5
        Console.WriteLine("For loop:");
        for (int i = 1; i <= 5; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("\n");

        // 2. While loop - print numbers 1 to 5
        Console.WriteLine("While loop:");
        int j = 1;
        while (j <= 5)
        {
            Console.Write(j + " ");
            j++;
        }
        Console.WriteLine("\n");

        // 3. Do-while loop - print numbers 1 to 5
        Console.WriteLine("Do-While loop:");
        int k = 1;
        do
        {
            Console.Write(k + " ");
            k++;
        } while (k <= 5);
        Console.WriteLine("\n");

        // 4. Foreach loop - iterate over an array
        Console.WriteLine("Foreach loop:");
        string[] flower = { "Rose", "Lily", "Cherry", "Tulip" };
        foreach (string it in flower)
        {
            Console.Write(it + " ");
        }
        Console.WriteLine();
    }
}
