using System.Threading.Tasks;
using Services.Models;

namespace Services
{
    public interface IServiceReturn<in TModelIn, TModelOut>
    {
        Task<TModelOut> RunAsync(TModelIn model);
    }
}