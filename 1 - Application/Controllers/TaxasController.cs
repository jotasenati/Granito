using Domain.Interfaces.TaxaInterface;
using Microsoft.AspNetCore.Mvc;

namespace Granito.Controllers;

[ApiController]
[Route("[api/controller]")]
public class TaxasController : ControllerBase
{
    private readonly ILogger<TaxasController> _logger;
    private readonly ITaxa _serviceTaxa;

    public TaxasController(ILogger<TaxasController> logger,ITaxa serviceTaxa)
    {
        _logger = logger;
        _serviceTaxa = serviceTaxa;
    }

    [HttpGet("/Taxa")]
    public async Task<IActionResult> Get()
    {
        return Ok(await Task.Run(() => _serviceTaxa.BuscaTaxa()));
    }
}
