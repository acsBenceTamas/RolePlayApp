using RolePlayApp.Backend.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace RolePlayApp.UserInterface.Views
{
    /// <summary>
    /// Interaction logic for MessageItemDisplay.xaml
    /// </summary>
    public partial class MessageItemView : UserControl
    {
        public static readonly DependencyProperty MessagesProperty = DependencyProperty.Register("MessageItems", typeof(ObservableCollection<MessageItem>), typeof(MessageItemView));

        public ObservableCollection<MessageItem> MessageItems
        {
            get { return (ObservableCollection<MessageItem>)GetValue(MessagesProperty); }
            set { SetValue(MessagesProperty, value); }
        }

        public MessageItemView()
        {
            InitializeComponent();
            Grid.DataContext = this;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            ((MessageItemView)sender).BringIntoView();
        }
    }
}
