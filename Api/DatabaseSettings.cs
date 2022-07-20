using ExRam.Gremlinq.Core;
using ExRam.Gremlinq.Core.Models;
using ExRam.Gremlinq.Providers.CosmosDb;
using Gremlin.Net.Structure;

namespace Api;

public record DatabaseSettings(string DatabaseName, string GraphName, string GremlinEndpointUrl, string CosmosDbAuthKey)
{
    public const string AppSettingsParameter = "DatabaseSettings";
    public const string AppSettingsConnectionStringParameter = "DatabaseSettings:ConnectionString";

    public DatabaseSettings() : this(string.Empty, string.Empty, string.Empty, string.Empty)
    {
    }

    public IGremlinQuerySource ConfigureCosmosGremlinQuerySource()
    {
        var model = GraphModel.FromBaseTypes<Vertex, Edge>(lookup => lookup.IncludeAssembliesOfBaseTypes());

        return GremlinQuerySource.g
            .ConfigureEnvironment(env => env
                .UseModel(model))
            .UseCosmosDb(builder => builder
                .At(new Uri(GremlinEndpointUrl), DatabaseName,
                    GraphName)
                .AuthenticateBy(CosmosDbAuthKey));
    }
}