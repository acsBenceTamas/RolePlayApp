using System;
using System.Globalization;
using System.Windows.Data;
using RolePlayApp.Backend.Models;
using RolePlayApp.UserInterface.ViewModels;

namespace RolePlayApp.UserInterface.Converters
{
    [ValueConversion(typeof(MessageItem), typeof(MessageItemViewModel))]
    public class MessageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.GetType() == typeof(Message))
            {
                return new MessageViewModel((Message) value);
            }
            else
            {
                throw new ArgumentException("Must be a MessageItem.", "value");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.GetType() == typeof(MessageViewModel))
            {
                return ((MessageViewModel) value).MessageBehind;
            }
            else
            {
                throw new ArgumentException("Must be a MessageItemViewModel.", "value");
            }
        }
    }
}
