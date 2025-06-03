using System;
class mobile
{
    int price;
    string name;
    void call()
    {
        Console.WriteLine("Calling");
    }
    static void Main()
    {
        mobile m = new mobile();
        m.price = 10000;
        m.name = "Samsung";
        m.call();
        Console.WriteLine("Mobile name=" + m.name);
        Console.WriteLine("Mobile price" + m.price);
    }
}
