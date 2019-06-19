using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayApp.Backend.Models
{
    public struct MessageItem
    {
        public MessageItem(string text, MessageItemType type, Character character)
        {
            Text = text;
            Type = type;
            Character = character;
        }
        public MessageItem(string text, MessageItemType type)
        {
            Text = text;
            Type = type;
            Character = null;
        }

        public string Text { get; set; }
        public MessageItemType Type { get; set; }
        public Character Character { get; set; }
    }

   public enum MessageItemType
    {
        /// <summary>
        /// A <see cref="Character"/>'s action.
        /// </summary>
        Action,
        /// <summary>
        /// A <see cref="Character"/>'s speech.
        /// </summary>
        Speech,
        /// <summary>
        /// An environmental event that does not belong to a specific
        /// <see cref="Character"/> or belongs to several.
        /// </summary>
        Environment
    }
}
