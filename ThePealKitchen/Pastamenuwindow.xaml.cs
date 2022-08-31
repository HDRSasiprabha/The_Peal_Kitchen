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
using System.Windows.Shapes;

namespace ThePealKitchen
{
    /// <summary>
    /// Interaction logic for Pastamenuwindow.xaml
    /// </summary>
    public partial class Pastamenuwindow : Window
    {
        public static int qtycl = 0, qtymcp = 0, qtyspbp = 0;
        public static double totcl = 0, totmcp = 0, totspbp = 0 ,pastatot=0;
        public static string itemnamecl, itemnamemcp, itemnamespbp;
        public Pastamenuwindow()
        {
            InitializeComponent();
        }

        private void Btn_pastaback(object sender, RoutedEventArgs e)
        {
            Foodselectionwindow pasta = new Foodselectionwindow();
            pasta.Show();
        }

        private void Btn_addcartpasta(object sender, RoutedEventArgs e)
        {
            Cart_invoice_window pastain = new Cart_invoice_window();
            pastain.Show();
        }

        private void btn_pluscl(object sender, RoutedEventArgs e)
        {
            qtycl = qtycl + 1;
            txt_cl.Text = Convert.ToString(qtycl);
            totcl = 650 * qtycl;
            pastatot = totcl + totmcp + totspbp;
            txt_pastatot.Text = Convert.ToString(pastatot);
        }

        private void btn_atcartcl(object sender, RoutedEventArgs e)
        {
            itemnamecl = "Chicken Lasagna ";
            if (qtycl != 0)
            {
                MessageBox.Show("Your foods add to cart successfully", "Order List", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please add quantity ", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_atcartmcp(object sender, RoutedEventArgs e)
        {
            itemnamemcp = "Macaroni & Cheese Pasta ";
            if (qtymcp != 0)
            {
                MessageBox.Show("Your foods add to cart successfully", "Order List", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please add quantity ", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

       
        private void btn_atcartsbcp(object sender, RoutedEventArgs e)
        {
            itemnamespbp = "Macaroni & Cheese Pasta ";
            if (qtyspbp != 0)
            {
                MessageBox.Show("Your foods add to cart successfully", "Order List", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please add quantity ", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_minuscl(object sender, RoutedEventArgs e)
        {
            if (qtycl==0)
            {

            }
            else
            {
                qtycl = qtycl - 1;
                txt_cl.Text = Convert.ToString(qtycl);
                totcl = 650 * qtycl;
                pastatot = totcl + totmcp + totspbp;
                txt_pastatot.Text = Convert.ToString(pastatot);
            }

        }

        private void btn_plusmcpasta(object sender, RoutedEventArgs e)
        {
            qtymcp = qtymcp + 1;
            txt_mcpasta.Text = Convert.ToString(qtymcp);
            totmcp = 580 * qtymcp;
            pastatot = totcl + totmcp + totspbp;
            txt_pastatot.Text = Convert.ToString(pastatot);
        }

        private void btn_minusmcpasta(object sender, RoutedEventArgs e)
        {
            if (qtymcp==0)
            {

            }
            else
            {
                qtymcp = qtymcp - 1;
                txt_mcpasta.Text = Convert.ToString(qtymcp);
                totmcp = 580 * qtymcp;
                pastatot = totcl + totmcp + totspbp;
                txt_pastatot.Text = Convert.ToString(pastatot);
            }
        }

        private void btn_plusspbpasta(object sender, RoutedEventArgs e)
        {
            qtyspbp = qtyspbp + 1;
            txt_spcpasta.Text = Convert.ToString(qtyspbp);
            totspbp = 500 * qtyspbp;
            pastatot = totcl + totmcp + totspbp;
            txt_pastatot.Text = Convert.ToString(pastatot);
        }

        private void btn_minusspbpasta(object sender, RoutedEventArgs e)
        {
            if (qtyspbp==0)
            {

            }
            else
            {
                qtyspbp = qtyspbp - 1;
                txt_spcpasta.Text = Convert.ToString(qtyspbp);
                totspbp = 500 * qtyspbp;
                pastatot = totcl + totmcp + totspbp;
                txt_pastatot.Text = Convert.ToString(pastatot);
            }
        }
        
    }
}
