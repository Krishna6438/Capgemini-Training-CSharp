using System.Collections;

public class MeditationCenter
{
    public int MemberId;
    public int Age;
    public double Weight;
    public double Height;
    public string Goal;
    public double BMI;
}


public class YogaMeditation
{

    public static ArrayList memberList = new ArrayList();

    public void AddYogaMember(int id, int age, double weight, double height, string goal)
    {
        MeditationCenter m = new MeditationCenter()
        {
            MemberId = id,
            Age = age,
            Weight = weight,
            Height = height,
            Goal = goal,

        };
        memberList.Add(m);
    }

    public double CalculateBMI(int id)
    {
        foreach (MeditationCenter m in memberList)
        {
            if (m.MemberId == id)
            {
                double heightInMeters = m.Height / 100;
                double bmi = m.Weight / (heightInMeters * heightInMeters);

                bmi = Math.Round(bmi, 2);
                m.BMI = bmi;
                return bmi;
            }
        }
        return -1;
    }


    public int CalculateYogaFee(int id)
    {
        foreach (MeditationCenter m in memberList)
        {
            if (m.MemberId == id)
            {
                if (m.BMI == 0)
                {
                    CalculateBMI(id);
                }

                if (m.Goal == "Weight Gain")
                {
                    return 2500;
                }
                if (m.Goal == "Weight Loss")
                {
                    if (m.BMI >= 25 && m.BMI < 30) return 2000;
                    if (m.BMI >= 30 && m.BMI < 35) return 2500;
                    if (m.BMI >= 35) return 3000;
                }

                return 0;
            }

        }
        return 0;
    }



    public static void Run()
    {
        YogaMeditation p = new YogaMeditation();

        // Add a few sample members
        p.AddYogaMember(101, 26, 78, 168, "Weight Loss"); // 168 cm
        p.AddYogaMember(102, 30, 55, 164, "Weight Gain"); // 164 cm


        Console.Write("Enter MemberId to calculate BMI: ");
        int id = int.Parse(Console.ReadLine());

        double bmi = p.CalculateBMI(id);
        if (bmi == -1)
        {
            Console.WriteLine($"MemberId '{id}' is not present");
            return;
        }

        Console.WriteLine($"BMI: {bmi}");

        int fee = p.CalculateYogaFee(id);
        Console.WriteLine($"Yoga Fee: {fee}");
    }
}