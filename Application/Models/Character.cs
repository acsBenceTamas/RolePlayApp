using System.Windows.Media;

namespace RolePlayApp.Backend.Models
{
    public class Character
    {
        private static int _currentIndex = 0;

        /// <summary>
        /// Index of this character.
        /// </summary>
        public int Index { get; private set; } = _currentIndex++;

        /// <summary>
        /// Gets or sets the name of the character.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the character color for display.
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// Creates an instance of the <see cref="Character"/> class.
        /// Has one parameter that sets the name of the character and sets
        /// <see cref="Color"/> to <see cref="Colors.Black"/> by default.
        /// </summary>
        /// <param name="name">Name of the character.</param>
        public Character(string name)
        {
            Name = name;
            Color = Colors.Black;
        }

        /// <summary>
        /// Creates an instance of the <see cref="Character"/> class.
        /// Has two parameters: the name of the character and its color
        /// for display purposes.
        /// </summary>
        /// <param name="name">Name of the character.</param>
        /// <param name="color">Color of the character's name and message background.</param>
        public Character(string name, Color color)
        {
            Name = name;
            Color = color;
        }
    }
}
