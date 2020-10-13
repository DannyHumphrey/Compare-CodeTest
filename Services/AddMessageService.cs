using System;
using System.Threading.Tasks;
using Data;
using Data.Model;
using Services.Models;

namespace Services
{
    public class AddMessageService : Service<AddMessageModel>
    {
        public AddMessageService(IMessageContext context) : base(context) { }

        public override async Task RunAsync(AddMessageModel model)
        {
            _context.Messages.Add(new Message()
            {
                DateAdded = DateTimeOffset.UtcNow,
                MessageText = model.MessageText
            });
            
            await this._context.SaveAsync();
        }
    }
}