using RolePlayApp.Backend.Models;
using RolePlayApp.UserInterface.ViewModels;
using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace RolePlayApp.UserInterface.Converters
{
    [ValueConversion(typeof(Character), typeof(CharacterViewModel))]
    class CharacterConverter:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return new CharacterViewModel(new Character("None"));
            }
            else if (value.GetType() == typeof(Character))
            {
                return new CharacterViewModel((Character)value);
            }
            else
            {
                throw new ArgumentException("Must be a Character.", "value");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.GetType() == typeof(CharacterViewModel))
            {
                return ((CharacterViewModel)value).CharacterBehind;
            }
            else
            {
                throw new ArgumentException("Must be a CharacterViewModel.", "value");
            }
        }
    }
}
