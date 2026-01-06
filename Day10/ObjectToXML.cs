using System.IO;
using System.Xml.Serialization;
public class Student2
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

public class XmlConverter
{
    public static string ConvertToXml<T>(T obj)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(T));

        using StringWriter writer = new StringWriter();
        serializer.Serialize(writer, obj);

        return writer.ToString();
    }
}

public class ObjectToXML
{
    public static void Run()
    {
        Student2 student = new Student2
        {
            Id = 1,
            Name = "Krishna",
            Age = 22
        };

        string xmlData = XmlConverter.ConvertToXml(student);
        Console.WriteLine(xmlData);
    }
}