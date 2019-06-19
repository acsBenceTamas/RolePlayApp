using System;
using System.Globalization;
using System.Windows.Data;
using RolePlayApp.Backend.Models;
using RolePlayApp.UserInterface.ViewModels;

namespace RolePlayApp.UserInterface.Converters
{
    [ValueConversion(typeof(MessageItem), typeof(MessageItemView))]
    public class MessageItemConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.GetType() == typeof(MessageItem))
            {
                return new MessageItemView((MessageItem) value);
            }
            else
            {
                throw new ArgumentException("'value' must be a MessageItem.", "value");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.GetType() == typeof(MessageItemView))
            {
                return ((MessageItemView) value).Item;
            }
            else
            {
                throw new ArgumentException("'value' must be a MessageItemView.", "value");
            }
        }
    }
}
