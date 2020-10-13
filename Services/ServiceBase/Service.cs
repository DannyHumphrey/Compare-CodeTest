using System.Threading.Tasks;
using Data;

namespace Services
{
    public abstract class Service<TModel> : IService<TModel>
    {
        protected IMessageContext _context;
        
        protected Service(IMessageContext context)
        {
            
        }
        public abstract Task RunAsync(TModel model);
    }
}