using RolePlayApp.Backend.Models;
using RolePlayApp.UserInterface.ViewModels.HelperClasses;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;

namespace RolePlayApp.UserInterface.ViewModels
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private Character _selectedCharacter;

        public ObservableCollection<Backend.Models.Message> Messages { get; set; } = new ObservableCollection<Backend.Models.Message>();

        public ObservableCollection<Character> Characters { get; set; } = new ObservableCollection<Character>();

        public MessageComposer Composer { get; set; } = new MessageComposer();

        public Character SelectedCharacter
        {
            get => _selectedCharacter; set
            {
                _selectedCharacter = value;
                NotifyPropertyChanged();
            }
        }

        public ICommand SendMessageCommand { get; set; }

        public ICommand AddMessageItemCommand { get; set; }

        public ICommand SelectCharacterCommand { get; set; }

        public ICommand SelectMessageTypeCommand { get; set; }

        public MainWindowViewModel()
        {
            SendMessageCommand = new RelayCommand(o => SendMessage(), o => Composer.Items.Count > 0);
            AddMessageItemCommand = new RelayCommand(o => AddMessageItemToPreparedMessage(), o => CanAddMessageItemToPreparedMessage());
            SelectCharacterCommand = new RelayCommand<string>(i => SelectCharacter(i), i => CanSelectCharacter(i));
            SelectMessageTypeCommand = new RelayCommand<MessageItemType>(type => SelectMessageType(type), i => true);
            AddCharacter("Kayden", Colors.Orange);
            AddCharacter("Ashe", Colors.Red);
        }

        private void SelectMessageType(MessageItemType type)
        {
            Composer.Type = type;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private bool CanSelectCharacter(string i)
        {
            return Characters.Count >= int.Parse(i);
        }

        private void SelectCharacter(string i)
        {
            SelectedCharacter = Characters[int.Parse(i) - 1];
            if (Composer.Type == MessageItemType.Environment) Composer.Type = MessageItemType.Speech;
        }

        private void AddMessageItemToPreparedMessage()
        {
            Composer.Add(new MessageItem(Composer.Text, Composer.Type, SelectedCharacter));
            Composer.Text = string.Empty;
        }

        private bool CanAddMessageItemToPreparedMessage()
        {
            if (Composer.Text.Length == 0) return false;
            if (!Characters.Contains(SelectedCharacter) && Composer.Type != MessageItemType.Environment)
            {
                MessageBox.Show("Select a character or set message type to Environment.");
                return false;
            }
            return true;
        }

        private void SendMessage()
        {
            Messages.Add(Composer.ComposeMessage());
        }

        private void AddCharacter(string name, Color color)
        {
            Characters.Add(new Character(name, color));
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
