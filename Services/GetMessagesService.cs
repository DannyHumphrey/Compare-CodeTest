using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Data.Model;
using Services.Models;

namespace Services
{
    public class GetMessagesService : ServiceWithReturn<FilterMessagesModel, IEnumerable<GetMessageModel>>
    {
        public GetMessagesService(IMessageContext context) : base(context) { }

        public override async Task<IEnumerable<GetMessageModel>> RunAsync(FilterMessagesModel model)
        {
            var set = _context.Messages.AsQueryable();

            if (string.IsNullOrEmpty(model.MessageText))
            {
                set = set.Where(m => m.MessageText.Contains(model.MessageText));
            }

            var messages = await set.Select(m => new GetMessageModel()
            {
               MessageDate = m.DateAdded,
               MessageId = m.MessageId,
               MessageText = m.MessageText
            }).ToListAsync();

            return messages;
        }
    }
}