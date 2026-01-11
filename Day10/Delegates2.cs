using System;

public delegate int DelegateAdd(int a, int b);

public class Example
{
    public int ADD1(int a ,int b){
        return a+b+40;
    }
    
    public int ADD2(int a , int b){
        return a+b+50;
    }

    public void Implementation()
    {
        DelegateAdd d = ADD1;
        Console.WriteLine(d(5,10));
        
        DelegateAdd d2 = ADD2;
        Console.WriteLine(d2(5,10));
    }
}
public class Delegates2
{
    
    
    public static void Run()
    {
        Example e = new Example();
        e.Implementation();
    }
}