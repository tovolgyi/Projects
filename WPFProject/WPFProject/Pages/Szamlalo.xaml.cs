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
    /// <summary>
    /// Interaction logic for Szamlalo.xaml
    /// </summary>
    public partial class Szamlalo : Page
    {
        public Szamlalo()
        {
            InitializeComponent();
        }

        private void felGomb(object sender, RoutedEventArgs e)
        {
            int ertek = int.Parse(szoveg.Text);
            ertek++;
            szoveg.Text = ertek.ToString();
        }

        private void leGomb(object sender, RoutedEventArgs e)
        {
            int ertek = int.Parse(szoveg.Text);
            ertek--;
            szoveg.Text = ertek.ToString();
        }

        private void nullaGomb(object sender, RoutedEventArgs e)
        {
            szoveg.Text = "0";
        }
    }
}
