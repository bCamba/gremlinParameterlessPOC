namespace Api;

public abstract record Edge : BaseAuditableEntity
{
    public Edge(Guid createdBy, Guid modifiedBy, DateTime createdTime) : base(createdBy, modifiedBy, createdTime)
    {
    }

    public Edge(Guid userId) : base(userId)
    {
    }
}