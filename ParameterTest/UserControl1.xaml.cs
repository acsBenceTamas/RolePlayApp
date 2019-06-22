using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace ParameterTest
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public static readonly DependencyProperty ItemsProperty = DependencyProperty.Register("Items", typeof(ObservableCollection<string>), typeof(UserControl1));
        public static readonly DependencyProperty ItemProperty = DependencyProperty.Register("Item", typeof(string), typeof(UserControl1));

        public UserControl1()
        {
            InitializeComponent();
            Grid.DataContext = this;
            Item = "Default";
        }

        public ObservableCollection<string> Items
        {
            get { return (ObservableCollection<string>)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        public string Item
        {
            get { return (string)GetValue(ItemsProperty); }
            set { SetValue(ItemProperty, value); }
        }
    }
}
