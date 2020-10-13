using System.Threading.Tasks;
using Data;

namespace Services
{
    public abstract class ServiceWithReturn<TModelIn, TModelOut> : IServiceReturn<TModelIn, TModelOut>
    {
        protected IMessageContext _context;
        
        protected ServiceWithReturn(IMessageContext context)
        {
            
        }
        
        public abstract Task<TModelOut> RunAsync(TModelIn model);
    }
}