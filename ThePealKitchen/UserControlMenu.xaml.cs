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

namespace ThePealKitchen
{
    /// <summary>
    /// Interaction logic for UserControlMenu.xaml
    /// </summary>
    public partial class UserControlMenu : UserControl
    {
        
        public UserControlMenu()
        {
            InitializeComponent();
        }
        


        private void Btn_foodmenu(object sender, RoutedEventArgs e)
        {
            Foodselectionwindow fw = new Foodselectionwindow();
            fw.Show();
        }

        private void Btn_drinksmenu(object sender, RoutedEventArgs e)
        {
            Drinksselectionwindow dw = new Drinksselectionwindow();
            dw.Show();
        }

        private void Btn_dessertsmenu(object sender, RoutedEventArgs e)
        {
            Dessertselectionwindow iw = new Dessertselectionwindow();
            iw.Show();
        }
    }
}
