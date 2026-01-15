using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

public class FindItem
{
    // In your template this is already provided.
    public static SortedDictionary<string, long> itemDetails = new SortedDictionary<string, long>()
    {
        { "Pen", 120 },
        { "Pencil", 80 },
        { "Notebook", 250 },
        { "Eraser", 60 }
    };

    public SortedDictionary<string,long>FindItemDetails(long soldCount)
    {
        var result = new SortedDictionary<string,long>();

        foreach(var kv in itemDetails)
        {
            if(kv.Value == soldCount)
            {
                result[kv.Key] = soldCount;
            }    
        }
        return result;
    }

    public List<String> FindMinandMaxSoldItems()
    {
        var result = new List<string>();
        if (itemDetails.Count == 0) return result;

        var minValue = itemDetails.OrderBy(kv=>kv.Value).First();
        var maxValue = itemDetails.OrderByDescending(kv=>kv.Value).First();

        result.Add(minValue.Key);
        result.Add(maxValue.Key);

        return result;
    }

    public Dictionary<string, long> SortByCount()
    {
        return itemDetails.OrderBy(kv=>kv.Value).ToDictionary(kv => kv.Key, kv => kv.Value);
    }

    
    // Sample Main to test
    public static void Run()
    {
        FindItem p = new FindItem();

        Console.Write("Enter sold count to search: ");
        long soldCount = long.Parse(Console.ReadLine());

        var found = p.FindItemDetails(soldCount);
        if (found.Count == 0)
        {
            Console.WriteLine("Invalid sold count");
        }
        else
        {
            foreach (var kv in found)
                Console.WriteLine($"{kv.Key} : {kv.Value}");
        }

        var minMax = p.FindMinandMaxSoldItems();
        if (minMax.Count >= 2)
            Console.WriteLine($"Min Sold Item: {minMax[0]}, Max Sold Item: {minMax[1]}");

        Console.WriteLine("Sorted by sold count:");
        var sorted = p.SortByCount();
        foreach (var kv in sorted)
            Console.WriteLine($"{kv.Key} : {kv.Value}");
    }
}






