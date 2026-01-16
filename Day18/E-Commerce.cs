using System.Security.AccessControl;

public class EcommerceShop
{
    public string UserName { get; set; }
    public double WalletBalance { get; set;}
    public double TotalPurchaseAmount { get; set; }
}

public class InsufficientWalletBalanceException : Exception
{
    public InsufficientWalletBalanceException(string message) : base(message) { }
}

public class Ecommerce
{
    public EcommerceShop MakePayment(string name, double balance, double amount)
    {
        if (balance < amount)
        {
            throw new InsufficientExecutionStackException("Insufficient Balance");
        }


        EcommerceShop e = new EcommerceShop()
        {
            UserName = name,
            WalletBalance = balance - amount,
            TotalPurchaseAmount = amount
        };
        return e;


    }

    public static void Run()
    {
        Ecommerce p = new Ecommerce();

        Console.Write("Enter user name: ");
        string name = Console.ReadLine();

        Console.Write("Enter wallet balance: ");
        double balance = double.Parse(Console.ReadLine());

        Console.Write("Enter purchase amount: ");
        double amount = double.Parse(Console.ReadLine());

        try
        {
            EcommerceShop shop = p.MakePayment(name, balance, amount);
            Console.WriteLine("Payment successful");
        }
        catch (InsufficientWalletBalanceException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}