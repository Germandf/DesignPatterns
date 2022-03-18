namespace DesignPatterns.Tools.Builder;

public class GeneratorConcreteBuilder : IGeneratorBuilder
{
    private Generator _generator;

    public GeneratorConcreteBuilder() => _generator = new();

    public Generator GetGenerator() => _generator;
    public void Reset() => _generator = new();
    public void SetContent(List<string> content) => _generator.Content = content;
    public void SetPath(string path) => _generator.Path = path;
    public void SetFormat(FormatType format) => _generator.Format = format;
    public void SetCharacter(CharacterType character = CharacterType.Normal) => _generator.Character = character;
}
