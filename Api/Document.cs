namespace Api;

public record Document
{
    public string Name { get; init; }

    public Document(string name)
    {
        Name = name.Trim();
    }
}