using System.Reflection.Metadata.Ecma335;

public class EstimateDetails
{
    public float ConstructionArea{get; set;}
    public float SiteArea{get; set;}
}

public class ConstructionEstimateException : Exception
{
    public ConstructionEstimateException(string message) : base(message){}
}
public class Construction
{
    public EstimateDetails ValidateConstructionEstimate(float cArea , float sArea)
    {
        if(cArea > sArea)
        {
            throw new ConstructionEstimateException("Sorry but site area is small");
        }

        EstimateDetails e = new EstimateDetails()
        {
            ConstructionArea = cArea,
            SiteArea = sArea
        };

        return e;
    }

    public static void Run()
    {
        Construction p = new Construction();

        Console.Write("Enter Construction Area: ");
        float cArea = float.Parse(Console.ReadLine());

        Console.Write("Enter Site Area: ");
        float sArea = float.Parse(Console.ReadLine());

        try
        {
            EstimateDetails ed = p.ValidateConstructionEstimate(cArea, sArea);
            Console.WriteLine("Construction Estimate Approved");
        }
        catch (ConstructionEstimateException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}