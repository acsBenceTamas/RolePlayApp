using System.Collections.Generic;

namespace RolePlayApp.Backend.Models

{
    public class MessageComposer
    {
        private List<MessageItem> _messages = new List<MessageItem>();

        public void Add(MessageItem item)
        {
            _messages.Add(item);
        }

        public Message Compose()
        {
            return new Message(_messages);
        }
    }
}
