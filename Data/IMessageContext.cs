using System.Data.Entity;
using System.Threading.Tasks;
using Data.Model;

namespace Data
{
    public interface IMessageContext  
    {
        DbSet<Message> Messages { get; set; }

        Task SaveAsync();
    }
}