namespace Api;

public record Document : Vertex
{
    public Document(string name, int number) : base(Guid.NewGuid())
    {
        Name = name;
        Number = number;
        AccountId = Guid.NewGuid();
    }

    public string Name { get; init; }

    public int Number { get; init; }
};