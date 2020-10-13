using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IService<in TModel>
    {
        Task RunAsync(TModel model);
    }
}