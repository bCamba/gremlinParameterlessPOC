namespace Api;

public abstract record BaseEntity
{
    public Guid Id { get; init; } = Guid.NewGuid();
}