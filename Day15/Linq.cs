namespace Day16_Linq
{
    public class Linq_Example
    {

        public void LinqExample()
        {
            string[] names = ["Anna", "B", "C"];
            foreach (var v in names)
            {
                if (v == "B") 
                Console.WriteLine("B Exists");
            }

            var findName = from n in names 
                // where n == "B" 
                orderby n ascending
                select IsPalindrome(n);
                // select n.ToUpper();
                
            // if (findName != null) Console.WriteLine("found");

            foreach (var item in findName)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        public static string IsPalindrome(string name)
        {
            // if (name.Reverse() == name)
            // {
            //     return name +" is Palindrome";
            // }
            // return name+" is not a palindrome";

            string reversed = new string(name.Reverse().ToArray());

            if (string.Equals(name, reversed, StringComparison.OrdinalIgnoreCase))
            {
                return name + " is a Palindrome";
            }

            return name + " is not a Palindrome";
        }
    }

    public class LinqExample
    {
        public static void Main()
        {
            Linq_Example lq = new();
        }
    }
}