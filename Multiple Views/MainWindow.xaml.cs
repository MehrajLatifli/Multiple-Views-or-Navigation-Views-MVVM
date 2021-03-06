using Multiple_Views.ViewModels;
using System;
using System.Collections.Generic;
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

namespace Multiple_Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Red_bt_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new RedVM();
        }

        private void Orange_bt_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new OrangeVM();
        }

        private void Plum_bt_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new PlumVM();
        }
    }
}
