namespace DesignPatterns.Tools.Builder;

public class GeneratorDirector
{
    private IGeneratorBuilder _generatorBuilder;

    public GeneratorDirector(IGeneratorBuilder generatorBuilder) =>
        _generatorBuilder = generatorBuilder;

    public void SetBuilder(IGeneratorBuilder generatorBuilder) =>
        _generatorBuilder = generatorBuilder;

    public void CreateSimpleJson(List<string> content, string path)
    {
        _generatorBuilder.Reset();
        _generatorBuilder.SetContent(content);
        _generatorBuilder.SetPath(path);
        _generatorBuilder.SetFormat(FormatType.Json);
    }

    public void CreateSimplePipe(List<string> content, string path)
    {
        _generatorBuilder.Reset();
        _generatorBuilder.SetContent(content);
        _generatorBuilder.SetPath(path);
        _generatorBuilder.SetFormat(FormatType.Pipes);
        _generatorBuilder.SetCharacter(CharacterType.Uppercase);
    }
}
