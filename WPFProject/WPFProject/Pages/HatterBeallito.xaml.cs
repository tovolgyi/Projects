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

namespace WPFProject.Pages
{
    public partial class HatterBeallito : Page
    {
        public HatterBeallito()
        {
            InitializeComponent();
        }

        private void sarga(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.Yellow;
        }

        private void piros(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.Red;
        }
    }
}
