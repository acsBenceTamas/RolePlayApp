using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RolePlayApp.Backend.Models
{
    public struct MessageItem : INotifyPropertyChanged
    {
        private Character _character;

        public event PropertyChangedEventHandler PropertyChanged;

        public MessageItem(string text, MessageItemType type, Character character) : this()
        {
            Text = text;
            Type = type;
            _character = character;
        }
        public MessageItem(string text, MessageItemType type) : this()
        {
            Text = text;
            Type = type;
            _character = null;
        }

        public string Text { get; set; }
        public MessageItemType Type { get; set; }
        public Character Character
        {
            get => _character;
            set
            {
                _character = value;
                NotifyPropertyChanged();
            }
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
