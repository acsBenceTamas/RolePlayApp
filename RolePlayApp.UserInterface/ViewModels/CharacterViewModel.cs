using RolePlayApp.Backend.Models;

namespace RolePlayApp.UserInterface.ViewModels
{
    class CharacterViewModel
    {
        public CharacterViewModel(Character character)
        {
            CharacterBehind = character;
        }

        public Character CharacterBehind { get; }

        public string ForegroundColor { get { return CharacterBehind.Color.ToString(); } }

        public string Name { get { return CharacterBehind.Name; } }

        public bool Selected { get; set; }
    }
}
