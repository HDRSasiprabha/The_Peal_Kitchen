using MaterialDesignThemes.Wpf;
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
    /// Interaction logic for ManagerView.xaml
    /// </summary>
    public partial class ManagerView : Window
    {
        public ManagerView()
        {
            InitializeComponent();
            
        }

        private void Btn_managerpoweroff(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Btn_waiterdetails(object sender, RoutedEventArgs e)
        {
            waiterdetailspage waiter = new waiterdetailspage();
            this.Content = waiter;
          
        }

        private void Btn_Customerdetails(object sender, RoutedEventArgs e)
        {
            Customerdetailspage customer = new Customerdetailspage();
            this.Content = customer;
            
        }

        private void Btn_orderdetails(object sender, RoutedEventArgs e)
        {
            Orderdetailspage order = new Orderdetailspage();
            this.Content = order;
            
        }

        private void Btn_invoicedetails(object sender, RoutedEventArgs e)
        {
            Invoicedetailspage invoice = new Invoicedetailspage();
            this.Content = invoice;
           
        }
      

        private void Btn_itemdetails(object sender, RoutedEventArgs e)
        {
            itemdetailspage item = new itemdetailspage();
            this.Content = item;
           
        }
    }
}
