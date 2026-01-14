public class ThreadingExample
{
    public static void Task1()
    {
        for(int i = 0; i < 100; i++)
        {
            Console.WriteLine(i+ " ");
        }
    }

    public static void Task2()
    {
        for(int i = 100; i < 300; i++)
        {
            Console.WriteLine(i+ " ");
        }
    }
    public static void Run()
    {
        Thread t1 = new Thread(Task1);
        Thread t2 = new Thread(Task2);

        t1.Start();
        t2.Start();

    }
}