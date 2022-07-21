namespace Api;

public record DatabaseSettings(string? Uri, string? Database, string? Graph, string? AuthKey)
{
    public const string AppSettingsParameter = "Gremlinq:CosmosDb";

    public DatabaseSettings() : this(null, null, null, null)
    {
    }
}