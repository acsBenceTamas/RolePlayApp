using RolePlayApp.Backend.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace RolePlayApp.UserInterface.ViewModels
{
    class MessageViewModel
    {
        public Message MessageBehind { get; private set; }

        public MessageViewModel(Message message)
        {
            MessageBehind = message;
        }

        public ObservableCollection<MessageItem> Items
        {
            get
            {
                return MessageBehind.Items;
            }

            set
            {
                MessageBehind.Items = value;
            }
        }

        public string SubmissionTime
        {
            get
            {
                return $"{MessageBehind.SubmissionTime.ToLongTimeString()} - {MessageBehind.SubmissionTime.ToLongDateString()}";
            }
        }
    }
}
