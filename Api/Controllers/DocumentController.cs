using ExRam.Gremlinq.Core;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class DocumentController : ControllerBase
{
    private readonly IGremlinQuerySource _g;

    public DocumentController(IGremlinQuerySource g)
    {
        _g = g;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<Document> Get()
    {
        var test = new Document("test", 10);
        await _g.AddV(test)
            .FirstAsync();

        var owns = new Owns(Guid.NewGuid());

        await _g.V<Document>(test.Id)
            .AddE(owns)
            .To(_ => _.V(test.Id));
        
        return test;
    }
}