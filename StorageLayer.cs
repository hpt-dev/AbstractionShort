namespace AbstractionConsoleTest;

public abstract class StorageLayer
{
    public abstract bool SaveData(IEnumerable<string> lines);
}

