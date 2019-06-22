using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RolePlayApp.Backend.Models

{
    public class MessageComposer : INotifyPropertyChanged
    {
        public ObservableCollection<MessageItem> Items { get; private set; } = new ObservableCollection<MessageItem>();

        private string _text = string.Empty;
        private MessageItemType _type = MessageItemType.Environment;

        public MessageItemType Type
        {
            get => _type; set
            {
                _type = value;
                NotifyPropertyChanged();
            }
        }

        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Add(MessageItem item)
        {
            Items.Add(item);
        }

        public Message ComposeMessage(bool clear = true)
        {
            Message message = new Message(Items);
            if (clear) Items.Clear();
            return message;
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
