namespace DesignPatterns.Tools.Builder;

public interface IGeneratorBuilder
{
    void Reset();
    void SetContent(List<string> content);
    void SetPath(string path);
    void SetFormat(FormatType format);
    void SetCharacter(CharacterType character = CharacterType.Normal);
}

public enum FormatType
{
    Json,
    Pipes
}

public enum CharacterType
{
    Normal,
    Uppercase,
    Lowercase
}