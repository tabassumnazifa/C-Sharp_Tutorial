using System;
public class mobile
{
    public int price;
    public string name;
   public mobile() //Default constructor
    {
        Console.WriteLine("Mobile Constracture Called\n");
    }
    public mobile(string n,int p) //parameterized constructor
    {
        name = n;
        price = p;
    }
    public mobile(mobile m)  //copy constructor
    {
        Console.WriteLine("Copy Constructor Called\n");
        name = m.name;
        price = m.price;
    }
    public void showdetail()
    {
        Console.WriteLine("Name:" + name);
        Console.WriteLine("Price:" + price);
    }
    public void copyshowdetail()
    {
        Console.WriteLine("Name:" + name);
        Console.WriteLine("Price:" + price);
    }
}
public class MyClass
{
    // Private constructor
    private MyClass()
    {
        Console.WriteLine("Private constructor called!");
    }

    // Static method to create object
    public static void CreateObject()
    {
        MyClass obj = new MyClass();
        Console.WriteLine("Object created using private constructor.");
    }
}

class program
{
    static void Main()
    {
        Console.WriteLine("Show detail:\n");
        mobile m = new mobile(); //default constructor called
        mobile n = new mobile("Samsung", 25000); //parameterized constructor called
        mobile o = new mobile(n); //copy constructor called
        n.showdetail();
        o.copyshowdetail();
        MyClass.CreateObject();
    }
}
