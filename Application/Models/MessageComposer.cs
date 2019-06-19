using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace RolePlayApp.Backend.Models

{
    public class MessageComposer
    {
        public ObservableCollection<MessageItem> Items { get; private set; } = new ObservableCollection<MessageItem>();

        public void Add(MessageItem item)
        {
            Items.Add(item);
        }

        public Message Compose()
        {
            return new Message(Items);
        }
    }
}
