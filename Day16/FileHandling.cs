class FileExample
{
    public static void Run()
    {
        string[] lines = {"first" , "second", "third"};
        string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        using(StreamWriter outputFile = new StreamWriter(Path.Combine(docPath)))
        {
            foreach(string line in lines)
            {
                outputFile.WriteLine(line);
            }
        }
    }
}