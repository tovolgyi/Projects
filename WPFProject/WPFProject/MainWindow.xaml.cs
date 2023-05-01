using System;
using System.Collections.Generic;
using System.ComponentModel;
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

using WPFProject.Pages;

namespace WPFProject
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void Datatrigger(object sender, RoutedEventArgs e)
        {
            keret.Content = new Datatrigger();
        }

        private void Eventtrigger(object sender, RoutedEventArgs e)
        {
            keret.Content = new Eventtrigger();
        }

        private void HatterBeallito(object sender, RoutedEventArgs e)
        {
            keret.Content = new HatterBeallito();
        }

        private void Szamlalo(object sender, RoutedEventArgs e)
        {
            keret.Content = new Szamlalo();
        }
    }
}
