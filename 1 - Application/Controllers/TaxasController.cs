using Microsoft.AspNetCore.Mvc;

namespace Granito.Controllers;

[ApiController]
[Route("[api/controller]")]
public class TaxasController : ControllerBase
{
    private readonly ILogger<TaxasController> _logger;

    public TaxasController(ILogger<TaxasController> logger)
    {
        _logger = logger;
    }

    [HttpGet("/Taxa")]
    public async Task<IActionResult> Get()
    {
        return Ok(await Task.Run(() => 1));
    }
}
