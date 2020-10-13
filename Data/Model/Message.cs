using System;

namespace Data.Model
{
    public class Message
    {
        public int MessageId { get; set; }
        public string MessageText { get; set; }
        public DateTimeOffset DateAdded { get; set; }
    }
}