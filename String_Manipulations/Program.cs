using System;
class StringManipulation
{
    static void Main()
    {
        string original = " Hello, Nazifa! Welcome to C# programming. ";
        // Trim whitespace from both ends
        string trim = original.Trim();
        Console.WriteLine("Trimmed: " + trim);
        // Convert to uppercase
        string up = trim.ToUpper();
        Console.WriteLine("Uppercase: " + up);
        // Convert to lowercase
        string low = trim.ToLower();
        Console.WriteLine("Lowercase: " + low);
        // Replace a word
        string replaced = trim.Replace("Nazifa", "Tabassum");
        Console.WriteLine("Replaced: " + replaced);
        // Substring
        string sub = trim.Substring(7, 6); // Get "Nazifa"
        Console.WriteLine("Substring: " + sub);
        // Split by space
        string[] words = trim.Split(' ');
        Console.WriteLine("Words:");
        foreach (string it in words)
        {
            Console.WriteLine(it);
        }
        // String length
        Console.WriteLine("Length: " + trim.Length);
    }
}
