using System.Collections;
using System.Collections.Generic; 

/*
Dispose() does NOT free memory.
Garbage Collector does that.
Dispose() only frees unmanaged resources.




*/
interface IDisposable
{
    public void Dispose();
}
public class BigBoy : IDisposable
{
    public BigBoy()
    {

    }
    public ArrayList Names  { get; set; }
    public void Dispose()
    {
        // Forces garbage collection for all generations
        // (In practice, this is not recommended, GC should run automatically)
        
        GC.Collect(); // Forces an immediate garbage collection of all generations
    }
}
public class GarbageCollectionExample
{
    public static void Run ()
    {
        BigBoy bigboy = new();
        try
        {
            bigboy.Names = new System.Collections.ArrayList();
            for (int i = 0; i < 10; i++)
            {
                bigboy.Names.Add(i.ToString());
            }

        }
        catch (System.Exception)
        {
            throw;
        }
        finally
        {
            bigboy.Dispose();
        }
    }
}
