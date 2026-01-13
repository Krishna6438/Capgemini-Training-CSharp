using System;
using System.Reflection;

/*
Reflection allows a program to discover and use a class’s internal structure at runtime, even private members.

*/


public class Department
{
    // Private fields
    private int deptId = 101;
    private string deptName = "IT";
    private double budget = 50000;
}

public class ReflectionExample
{
    public static void Run()
    {
        // Create object
        Department obj = new Department();
        var props = obj.GetType().GetFields(BindingFlags.NonPublic|BindingFlags.Instance).ToList();

        foreach(var prop in props)
        {
            Console.WriteLine(prop.Name);
        }
        Console.ReadLine();
    }
}

