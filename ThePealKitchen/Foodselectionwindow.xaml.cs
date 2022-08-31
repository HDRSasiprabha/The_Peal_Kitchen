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
using System.Windows.Shapes;

namespace ThePealKitchen
{
    /// <summary>
    /// Interaction logic for Foodselectionwindow.xaml
    /// </summary>
    public partial class Foodselectionwindow : Window
    {
        public Foodselectionwindow()
        {
            InitializeComponent();
        }

        private void Btn_ricecheckmenu(object sender, RoutedEventArgs e)
        {
            Ricemenuwindow rw = new Ricemenuwindow();
            rw.Show();
        }

        private void Btn_noodlescheckmenu(object sender, RoutedEventArgs e)
        {
            Noodlesmenuwindow nw = new Noodlesmenuwindow();
            nw.Show();
        }

        private void Btn_pastacheckmenu(object sender, RoutedEventArgs e)
        {
            Pastamenuwindow pw = new Pastamenuwindow();
            pw.Show();
        }

        private void Btn_kottucheckmenu(object sender, RoutedEventArgs e)
        {
            Kottumenuwindow kw = new Kottumenuwindow();
            kw.Show();
        }

        private void Btn_back(object sender, RoutedEventArgs e)
        {
            MainWindow usmenu = new MainWindow();
            usmenu.Show();
        }
    }
}
