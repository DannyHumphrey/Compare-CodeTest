using System;

namespace Services.Models
{
    public class GetMessageModel : AddMessageModel
    {
        public int MessageId { get; set; }
        public DateTimeOffset MessageDate { get; set; }
    }
}