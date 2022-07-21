namespace Api;

public abstract record BaseAuditableEntity : BaseEntity
{
    protected BaseAuditableEntity(Guid createdBy, Guid modifiedBy, DateTime createdTime)
    {
        CreatedBy = createdBy;
        ModifiedBy = modifiedBy;
        CreatedTime = createdTime;
        LastModified = DateTime.UtcNow;
    }

    protected BaseAuditableEntity(Guid userId)
    {
        CreatedBy = userId;
        ModifiedBy = userId;

        var creationTime = DateTime.UtcNow;

        CreatedTime = creationTime;
        LastModified = creationTime;
    }

    public DateTime CreatedTime { get; init; }
    public DateTime LastModified { get; init; }
    public Guid CreatedBy { get; init; }
    public Guid ModifiedBy { get; init; }
}