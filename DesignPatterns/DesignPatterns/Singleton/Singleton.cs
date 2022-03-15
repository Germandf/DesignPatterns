namespace DesignPatterns.Singleton;

public class Singleton
{
    private readonly static Singleton _instance = new();

    public static Singleton Instance
    {
        get 
        { 
            return _instance;
        }
    }

    private Singleton() { }
}
