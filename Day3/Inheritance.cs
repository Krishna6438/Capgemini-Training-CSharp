class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    // Person(int id , string name , int age){
    //         Id = id;
    //         Name = name;
    //         Age = age;
    //     }

    public void GetPersonDetail(Person p)
    {
        //Console.WriteLine($"Id: {p.Id}, Name: {p.Name}, Age: {p.Age}");
        string result = "";

        

        if(p is Man)
        {
            Man man = (Man) p;
            result = $"Id = {man.Id} Name = {man.Name} Age = {man.Age} PlayGame = {man.PlayGame} ";
        }

        if(p is Woman)
        {
            Woman woman = (Woman) p;
            result = $"Id = {woman.Id} Name = {woman.Name} Age = {woman.Age} PlayAndManage = {woman.PlayAndManage} ";
            
        }

        Console.WriteLine(result);

    
    }
}

class Man : Person
{
    
    public string PlayGame { get; set; }

    public void GetManDetail(Man input)
    {
        Console.WriteLine($"Plays Game: {input.PlayGame}");
    }
}

class Woman : Person
{
    public bool PlayAndManage { get; set; }

    public void GetWomanDetail(Woman input)
    {
        Console.WriteLine($"Can Play & Manage: {input.PlayAndManage}");
    }
}


class Inheritance
{
    public static void Run()
    {
        Man m = new Man
        {
            Id = 1,
            Name = "Ayush",
            Age = 20,
            PlayGame = "Cricket"
        };

        Woman w = new Woman
        {
            Id = 2,
            Name = "Anita",
            Age = 21,
            PlayAndManage = true
        };

        m.GetPersonDetail(m);
        w.GetPersonDetail(w);
        
    }
}