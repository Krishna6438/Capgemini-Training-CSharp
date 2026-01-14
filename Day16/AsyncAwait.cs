

using System;
using System.Threading.Tasks;

class AsyncAwaitExample
{
    public static async System.Threading.Tasks.Task AsyncMethod()

    {
        Console.WriteLine("TASK STARTED...");
        await System.Threading.Tasks.Task.Delay(3000);

        Console.WriteLine("Task completed after 3 seconds");
    }

    private async Task<string> FetchDataAsync(string input)
    {
        await Task.Delay(1000);
        return "Data fetched successfully";
    }

    public async Task CallMethod()
    {
        string result = await FetchDataAsync("https://jsonplaceholder.typicode.com/todos/1");
        Console.WriteLine(result);
        await AsyncMethod();
    }

    public static async Task Run()
    {
        AsyncAwaitExample a = new AsyncAwaitExample();
        await a.CallMethod();
    }
}
