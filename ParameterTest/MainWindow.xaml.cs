using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ParameterTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> Items { get; set; } = new ObservableCollection<string>();
        public string Item { get; set; } = "Item";
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Items.Add("First.");
            Items.Add("Second.");
            Items.Add("Third.");
        }
    }
}
