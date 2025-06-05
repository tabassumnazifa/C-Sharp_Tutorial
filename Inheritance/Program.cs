using System;
public class person
{
    public string name
    { get; set; }
}
public class  student:person
{
    public int id { get; set; }
    public void display()
    {
        Console.WriteLine("Name:"+name);
        Console.WriteLine("ID:" + id);
    }
}
public class academic : student
{
    public decimal cgpa
    { get; set; }
    public void displaycg()
    {
        Console.WriteLine("CGPA:" + cgpa);
    }
}
interface Icurriculum
{
    string curriculum
    {
        get;
        set;
    }
}
interface Isport
{
  string sport
    {
        get;
        set;
    }
}
public class extracurriculur: Icurriculum, Isport
{
    public string curriculum
    {
        get;
        set;
    }
    public string sport
    {
        get;
        set;
    }
    public void displayextra()
    {
        Console.WriteLine("curriculum:" + curriculum);
        Console.WriteLine("sport:" + sport);
    }
}
class program
{
    static void Main()
    {
        Console.WriteLine("Enter Name,ID,CGPA");
        academic a = new academic();
        a.name = Console.ReadLine();
        a.id = Convert.ToInt32(Console.ReadLine());
        a.cgpa= Convert.ToDecimal(Console.ReadLine());
        a.display();
        a.displaycg();
        Console.WriteLine("Enter Extra Curriculum");
        extracurriculur e = new extracurriculur();
        e.curriculum = Console.ReadLine();
        e.sport = Console.ReadLine();
        e.displayextra();
    }
}
