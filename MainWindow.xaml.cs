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

namespace Prakt8SavTask2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RedSelected(object sender, RoutedEventArgs e)
        {
            brsh.Color = Color.FromRgb(255, 0, 0);
        }

        private void BlueSelected(object sender, RoutedEventArgs e)
        {
            brsh.Color = Color.FromRgb(0, 0, 255);
        }

        private void GreenSelected(object sender, RoutedEventArgs e)
        {
            brsh.Color = Color.FromRgb(0, 255, 0);
        }

        private void ChangeSize(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            brsh.Height = slid.Value;
            brsh.Width = slid.Value;
        }
    }
}
