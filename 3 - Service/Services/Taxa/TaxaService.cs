using Domain.Interfaces.TaxaInterface;
using Extensions.Taxa;

namespace Service.Services.TaxaService;

public class TaxaService : ITaxa
{
    public Task<double> BuscaTaxa()
    {
        return Task.Run(() => Taxas.taxaPadrao());
    }
}