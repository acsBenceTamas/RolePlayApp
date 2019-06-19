﻿using System;
using System.Globalization;
using System.Windows.Data;
using RolePlayApp.Backend.Models;
using RolePlayApp.UserInterface.ViewModels;

namespace RolePlayApp.UserInterface.Converters
{
    [ValueConversion(typeof(MessageItem), typeof(MessageItemViewModel))]
    public class MessageItemConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.GetType() == typeof(MessageItem))
            {
                return new MessageItemViewModel((MessageItem) value);
            }
            else
            {
                throw new ArgumentException("Must be a MessageItem.", "value");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.GetType() == typeof(MessageItemViewModel))
            {
                return ((MessageItemViewModel) value).Item;
            }
            else
            {
                throw new ArgumentException("Must be a MessageItemView.", "value");
            }
        }
    }
}
