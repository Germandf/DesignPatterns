using System.Text.Json;

namespace DesignPatterns.Tools.Builder;

public class Generator
{
    public List<string> Content { get; set; } = new();
    public string Path { get; set; }
    public FormatType Format { get; set; }
    public CharacterType Character { get; set; }

    public void Save()
    {
        string result = string.Empty;
        result = Format == FormatType.Json ? GetJson() : GetPipe();
        if (Character == CharacterType.Uppercase) result = result.ToUpper();
        else if (Character == CharacterType.Lowercase) result = result.ToLower();
        File.WriteAllText(Path, result);
    }

    private string GetJson() => JsonSerializer.Serialize(Content);
    private string GetPipe() => Content.Aggregate((accum, current) => $"{accum}|{current}");
}
