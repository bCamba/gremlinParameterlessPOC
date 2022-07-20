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
        var test = new Document("test");
        await _g.AddV(test)
            .FirstAsync();
        return test;
    }
}