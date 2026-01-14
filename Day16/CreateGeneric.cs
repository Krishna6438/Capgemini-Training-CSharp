using System.Runtime.CompilerServices;

public class Student3
{
    public string? Name { get; set; }
}
public class UGStudent : Student3
{
    public int HighSchoolMarks { get; set; }
}
public class PGStudent : Student3
{
    public int UGMarks { get; set; }
}

public class MyGlobalType<T, K>
{
    public string GetObjectType(T t1, K t2)
    {
        return $"Type1: {t1.GetType().Name}, Type2: {t2.GetType().Name}";
    }
}

public class CallerClass
{
    public static void Run()
    {
        // MyGlobalType<Object> my = new MyGlobalType<Object>();
        // Object obj = new object();
        // string result = my.GetObjectType(obj);
        // Console.WriteLine(result);


        MyGlobalType<UGStudent, PGStudent> myGlobalType = new();
        UGStudent obj = new();
        PGStudent obj2 = new();
        string result = myGlobalType.GetObjectType(obj, obj2);
        System.Console.WriteLine(result);

        Predicate<int> isEven = number => number % 2 == 0;
        bool check = isEven(10);
        Console.WriteLine("The number is Even: " + check);

        Action<string> logger = message =>
        {
            Console.WriteLine($"[LOG]: {message} at {DateTime.Now}");
        };
        logger("Application Started"); // Invoking the action 

    }
}


