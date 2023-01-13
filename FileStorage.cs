namespace AbstractionConsoleTest;

public class FileStorage : StorageLayer
{
    public override bool SaveData(IEnumerable<string> lines)
    {
        try
        {
            using StreamWriter file = new("UserInfo.txt");

            foreach (string line in lines)
            {
                if (!line.Contains("Second"))
                {
                    file.WriteLine(line);
                }
            }

            return true;
        }
        catch
        {
            return false;
        }
    }
}

