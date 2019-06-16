using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class Character
    {
        /// <summary>
        /// Name of the character.
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Color code of the character in RGB hex code.
        /// </summary>
        public string ColorCode { get; private set; }

        private Color

        public Character(string name)
        {
            Name = name;
        }
    }
}
