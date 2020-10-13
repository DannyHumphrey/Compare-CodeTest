using System.Data.Entity;
using System.Threading.Tasks;
using Data.Model;

namespace Data
{
    public class MessageContext : DbContext, IMessageContext
    {
        public DbSet<Message> Messages { get; set; }

        public async Task SaveAsync()
        {
            await this.SaveChangesAsync().ContinueWith(a =>
            {
                if (a.IsCompleted && a.IsFaulted)
                {
                    //ToDo Error Handling
                }
            });
        }
    }
}