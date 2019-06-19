using System.Windows;
using System.Windows.Controls;

namespace RolePlayApp.UserInterface.Views
{
    /// <summary>
    /// Interaction logic for MessageItemDisplay.xaml
    /// </summary>
    public partial class MessageItemDisplay : UserControl
    {
        public MessageItemDisplay()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            ((MessageItemDisplay)sender).BringIntoView();
        }
    }
}
