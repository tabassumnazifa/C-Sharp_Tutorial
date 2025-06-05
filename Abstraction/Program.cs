using System;

// Abstract base class
abstract class Animal
{
    public abstract void MakeSound(); // Abstract method
}

// Derived class 1
class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog says: Woof!");
    }
}

// Derived class 2
class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat says: Meow!");
    }
}

// Main program
class Program
{
    static void Main()
    {
        Animal myDog = new Dog();
        Animal myCat = new Cat();

        myDog.MakeSound(); // Output: Dog says: Woof!
        myCat.MakeSound(); // Output: Cat says: Meow!
    }
}
