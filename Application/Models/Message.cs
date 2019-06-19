using System;
using System.Collections.Generic;

namespace RolePlayApp.Backend.Models
{
    public class Message
    {
        public DateTime SubmissionTime { get; } = DateTime.Now;
        public List<MessageItem> Items { get; } = new List<MessageItem>();

        public Message()
        {

        }

        public Message(params MessageItem[] messages)
        {
            Items.AddRange(messages);
        }

        public Message(List<MessageItem> messages)
        {
            Items.AddRange(messages);
        }
    }
}
