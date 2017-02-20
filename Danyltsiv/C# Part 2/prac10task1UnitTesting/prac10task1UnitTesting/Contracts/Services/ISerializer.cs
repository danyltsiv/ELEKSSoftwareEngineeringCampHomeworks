namespace prac9task1MVC1.Contracts.Services
{
    public interface ISerializer
    {
        string Serialize<T>(T ObjectForParsing) where T : class;
        T Deserialize<T>(string FilePath) where T : class;
    }
}
