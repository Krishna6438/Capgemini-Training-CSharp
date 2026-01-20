using System.Reflection.Metadata;

public class User1
{
    public string Name { get; set; }
    public string Number { get; set; }
}
public class InvalidPhoneNumberException : Exception
{
    public InvalidPhoneNumberException(string message) : base(message) { }
}
class UserVerification
{
    public User1 ValidatePhoneNumber(string name, string number)
    {
        if (number.Length == 10)
        {
            User1 u = new User1()
            {
                Name = name,
                Number = number
            };
            return u;
        }
        throw new InvalidPhoneNumberException("Invalid Phone Number");
    }

    public static void Run()
    {
        UserVerification p = new UserVerification();

        Console.Write("Enter name: ");
        string ?name = Console.ReadLine();

        Console.Write("Enter phone number: ");
        string ?phone = Console.ReadLine();

        try
        {
            User1 u = p.ValidatePhoneNumber(name, phone);
            Console.WriteLine("User Verified");
        }
        catch (InvalidPhoneNumberException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}