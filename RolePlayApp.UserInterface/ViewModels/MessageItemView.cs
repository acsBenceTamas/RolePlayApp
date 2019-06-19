using System.Windows.Media;
using RolePlayApp.Backend.Models;

namespace RolePlayApp.UserInterface.ViewModels
{
    class MessageItemView
    {
        public MessageItem Item;

        public MessageItemView(MessageItem item)
        {
            Item = item;
        }

        public string Text
        {
            get
            {
                return Item.Text;
            }
        }

        public string CharacterName
        {
            get
            {
                if (Item.Type != MessageItemType.Environment)
                {
                    return Item.Character.Name;
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public string NameColor
        {
            get
            {
                Color nameColor = Colors.Black;
                if (Item.Type != MessageItemType.Environment)
                {
                    nameColor = Item.Character.Color;
                }
                return nameColor.ToString();
            }
        }

        public string BackgroundColor
        {
            get
            {
                Color bgColor = Colors.Black;
                switch (Item.Type)
                {
                    case MessageItemType.Action:
                    case MessageItemType.Speech:
                        bgColor = Item.Character.Color;
                        bgColor.ScA *= 0.2f;
                        break;
                    case MessageItemType.Environment:
                        bgColor = Colors.Gray;
                        bgColor.ScA *= 0.2f;
                        break;
                }
                return bgColor.ToString();
            }
        }

        public string FontStyle
        {
            get
            {
                string style;
                if (Item.Type == MessageItemType.Speech)
                {
                    style = "Normal";
                }
                else
                {
                    style = "Italic";
                }
                return style;
            }
        }

        public string FontWeight
        {
            get
            {
                string style;
                if (Item.Type == MessageItemType.Speech)
                {
                    style = "Normal";
                }
                else
                {
                    style = "Bold";
                }
                return style;
            }
        }
    }
}
