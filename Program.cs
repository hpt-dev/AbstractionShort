namespace AbstractionConsoleTest;
class Program
{

    static void Main(string[] args)
    {
        StorageLayer persistence = new FileStorage();
        Run(persistence);
    }

    static void Run(StorageLayer persistence)
    {
        // Complex Calculation, API request etc goes here

        // Important data result
        string[] lines = { "Harry Potter", "Wizard", "Hogwarts" };

        // Data Storage
        persistence.SaveData(lines);
    }

}


//class Program
//{
//    static void Main(string[] args)
//    {
//        Run();
//    }
//
//    static void Run()
//    {
//        // Complex Calculation, API request etc goes here
//
//        // Important data result
//        string[] lines = { "Harry Potter", "Wizard", "Hogwarts" };
//
//        // Data storage
//        using StreamWriter file = new("UserInfo.txt");
//
//        foreach (string line in lines)
//        {
//            if (!line.Contains("Second"))
//            {
//                file.WriteLine(line);
//            }
//        }
//    }
//}
