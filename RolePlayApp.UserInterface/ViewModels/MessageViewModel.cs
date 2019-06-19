using RolePlayApp.Backend.Models;
using System.Collections.Generic;

namespace RolePlayApp.UserInterface.ViewModels
{
    class MessageViewModel
    {
        public Message Message { get; private set; }

        public MessageViewModel(Message message)
        {
            Message = message;
        }

        public List<MessageItem> Items
        {
            get
            {
                return Message.Items;
            }
        }

        public string SubmissionTime
        {
            get
            {
                return $"{Message.SubmissionTime.ToLongTimeString()} - {Message.SubmissionTime.ToLongDateString()}";
            }
        }
    }
}
