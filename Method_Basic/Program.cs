using System;
class newclass
{
    public static void greet(string name)
    {
        Console.WriteLine("Welcome " + name + '\n');
    }
}
class program
{
    static void Main()
    {
        newclass.greet("Nazifa");
    }
}
    