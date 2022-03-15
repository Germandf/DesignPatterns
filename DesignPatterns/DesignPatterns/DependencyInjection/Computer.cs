namespace DesignPatterns.DependencyInjection;

public class Computer
{
    private Processor _processor;
    private int _memory;
    private int _storage;

    public Computer(Processor processor, int memory, int storage)
    {
        _processor = processor;
        _memory = memory;
        _storage = storage;
    }
}
