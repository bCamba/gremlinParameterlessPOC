namespace Api;

public abstract record Vertex : BaseAuditableEntity
{
    public Vertex(Guid createdBy, Guid modifiedBy, DateTime createdTime) : base(createdBy, modifiedBy, createdTime)
    {
    }

    public Vertex(Guid userId) : base(userId)
    {
    }
    
    public Guid AccountId { get; init; }
}