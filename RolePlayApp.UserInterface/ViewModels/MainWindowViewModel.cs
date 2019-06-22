using RolePlayApp.Backend.Models;
using System.Collections.ObjectModel;
using System.Windows.Media;

namespace RolePlayApp.UserInterface.ViewModels
{
    class MainWindowViewModel
    {
        public ObservableCollection<Message> Messages { get; set; } = new ObservableCollection<Message>();

        public ObservableCollection<Character> Characters { get; set; } = new ObservableCollection<Character>();

        public MessageComposer Composer { get; set; } = new MessageComposer();

        public Character SelectedCharacter { get; set; }

        public MainWindowViewModel()
        {
            AddCharacter("Kayden", Colors.Orange);
            AddCharacter("Ashe", Colors.Red);
            for (int i = 0; i < 5; i++)
            {
                TestMessageShit();
            }
            Composer.Add(new MessageItem("He composes a new message 1", MessageItemType.Action, Characters[0]));
            Composer.Add(new MessageItem("He composes a new message 2", MessageItemType.Action, Characters[0]));
            Composer.Add(new MessageItem("She composes a new message 1", MessageItemType.Action, Characters[1]));
        }

        private void AddCharacter(string name, Color color)
        {
            Characters.Add(new Character(name, color));
        }

        private void TestMessageShit()
        {
            Messages.Add(new Message(
                new MessageItem("He walks over to the window.", MessageItemType.Action, Characters[0]),
                new MessageItem("I am currently talking.", MessageItemType.Speech, Characters[0]),
                new MessageItem("He scratches his head.", MessageItemType.Action, Characters[0]),
                new MessageItem("Yes, you are definitely talking.", MessageItemType.Speech, Characters[1]),
                new MessageItem("She looks down at him.", MessageItemType.Action, Characters[1]),
                new MessageItem("A giant macro hand smashes through the window and shit. This message is intentionally extra long to test wrapping. Like, really freaking long, if I am perfectly honest with myself." +
                "\nAlso contains line braks just in case.", MessageItemType.Environment)
                ));
        }
    }
}
