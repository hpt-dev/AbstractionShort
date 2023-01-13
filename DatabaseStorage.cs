namespace AbstractionConsoleTest;

public class DatabaseStorage : StorageLayer
{
    public override bool SaveData(IEnumerable<string> lines)
    {
        // Database storage implementation goes here ...

        return true;
    }
}
