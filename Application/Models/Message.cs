using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace RolePlayApp.Backend.Models
{
    public class Message
    {
        public DateTime SubmissionTime { get; set; } = DateTime.Now;
        public ObservableCollection<MessageItem> Items { get; set; } = new ObservableCollection<MessageItem>();

        public Message()
        {
        }

        public Message(params MessageItem[] messages)
        {
            foreach(var message in messages)
            {
                Items.Add(message);
            }
        }

        public Message(IList<MessageItem> messages)
        {
            foreach (var message in messages)
            {
                Items.Add(message);
            }
        }
    }
}
