
using System.ComponentModel.Design.Serialization;
using System.Data.Common;
using System.Security.Principal;

public class Linq_Example
{

    public void LinqExample()
    {
        string[] names = ["Anna", "B", "C"];
        foreach (var v in names)
        {
            if (v == "B")
                Console.WriteLine("B Exists");
        }

        var findName = from n in names
                       // where n == "B" 
                       orderby n ascending
                       select IsPalindrome(n);
        // select n.ToUpper();

        // if (findName != null) Console.WriteLine("found");

        foreach (var item in findName)
        {
            Console.WriteLine(item);
        }
        Console.ReadLine();
    }
    public static string IsPalindrome(string name)
    {
        // if (name.Reverse() == name)
        // {
        //     return name +" is Palindrome";
        // }
        // return name+" is not a palindrome";

        string reversed = new string(name.Reverse().ToArray());

        if (string.Equals(name, reversed, StringComparison.OrdinalIgnoreCase))
        {
            return name + " is a Palindrome";
        }

        return name + " is not a Palindrome";
    }

    public static void LinqExample2()
    {
        var proCollection = from p in System.Diagnostics.Process.GetProcesses()
                            select new MyProcess() { Name = p.ProcessName, Id = p.Id };

        foreach (var proc in proCollection)
        {
            Console.WriteLine($"Process Name: {proc.Name}, Id: {proc.Id}");
        }
    }
}

public class LinqExample
{
    public static void Run()
    {
        Linq_Example lq = new();
        lq.LinqExample();   // now LINQ runs

        Linq_Example.LinqExample2();

    }
}

internal class MyProcess
{
    public MyProcess()
    {
    }

    public object? Name { get; set; }
    public int Id { get; internal set; }
}

public class Employee5
{
    public int Roll_No{get; set;}
    public string Name{get; set;}

    public decimal Average(int a, int b)
    {
        return (a+b)/2;
    }
    
}

