namespace DesignPatterns.Tools.Singleton;

public sealed class Log
{
    private static Log _instance = null!;
    private string _path;
    private static object _protect = new();

    private Log(string path) =>
        _path = path;

    public static Log GetInstance(string path)
    {
        lock (_protect)
            if (_instance is null)
                _instance = new Log(path);
        return _instance;
    }

    public void Save(string message) =>
        File.AppendAllText(_path, message + Environment.NewLine);
}
