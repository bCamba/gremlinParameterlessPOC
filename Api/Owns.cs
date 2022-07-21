namespace Api;

public record Owns : Edge
{
    public Owns(Guid createdBy, Guid modifiedBy, DateTime createdTime) : base(createdBy, modifiedBy, createdTime)
    {
    }

    public Owns(Guid userId) : base(userId)
    {
    }
}