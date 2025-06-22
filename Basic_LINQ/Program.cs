using System;
using System.Collections.Generic;
using System.Linq;
class program
{
    static void Main()
    {
        var numbers = new List<int> { 45, 67, 89, 32, 50, 100, 29 };
        Console.WriteLine("Numbers greater than 50 are:");
        var res = from n in numbers
                  where n > 50
                  select n;
        Console.WriteLine("Final Result:");
        foreach(var it in res)
        {
            Console.WriteLine(it);
        }
        Console.WriteLine("Sorted numbers are:");
        var res1 = from n in numbers
                   orderby n
                   select n;
        Console.WriteLine("Final Result:");
        foreach (var it in res1)
        {
            Console.WriteLine(it);
        }
        Console.WriteLine("COnditional result:");
        var res2=(from n in numbers
                 where n>49
                 select n).FirstOrDefault();
        Console.WriteLine(res2);
        Console.WriteLine("Count result:");
        var res3 = (from n in numbers
                   where (n % 2 == 0)
                   select n).Count();
        Console.WriteLine(res3);
    }
}