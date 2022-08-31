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
    /// Interaction logic for Ricemenuwindow.xaml
    /// </summary>
    public partial class Ricemenuwindow : Window
    {
        public static int qtyvr = 0, qtysfr = 0,qtyngr = 0, qtycb = 0, qtycfr = 0;
        public static double totvr = 0, totsfr = 0, totngr = 0, totcb = 0, totcfr = 0, ricetot = 0;
        public static string itemnamevr, itemnamesfr, itemnamengr, itemnamecb, itemnamecfr;
        public Ricemenuwindow()
        {
            InitializeComponent();
        }

        private void Btn_riceshowcart(object sender, RoutedEventArgs e)
        {
            Cart_invoice_window rsc = new Cart_invoice_window();
            rsc.Show();
        }

        private void Btn_riceback(object sender, RoutedEventArgs e)
        {
            Foodselectionwindow rfs = new Foodselectionwindow();
            rfs.Show();
        }

        private void btn_plusvegrice(object sender, RoutedEventArgs e)
        {
            qtyvr = qtyvr + 1;
            txt_vegrice.Text = Convert.ToString(qtyvr);
            totvr = 380 * qtyvr;
            ricetot = totvr + totsfr + totngr + totcfr + totcb;
            txt_ricetot.Text = Convert.ToString(ricetot);
        }

        private void btn_atcartcfr(object sender, RoutedEventArgs e)
        {
            itemnamecfr = "Chicken Fried Rice ";
            if (qtycfr != 0)
            {
                MessageBox.Show("Your foods add to cart successfully", "Order List", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please add quantity ", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_atcartseafrice(object sender, RoutedEventArgs e)
        {
            itemnamesfr = "SeaFood Rice ";
            if (qtysfr != 0)
            {
                MessageBox.Show("Your foods add to cart successfully", "Order List", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please add quantity ", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_atcartngr(object sender, RoutedEventArgs e)
        {
            itemnamengr = "Nasi Goreng Rice ";
            if (qtyngr != 0)
            {
                MessageBox.Show("Your foods add to cart successfully", "Order List", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please add quantity ", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_atcartcb(object sender, RoutedEventArgs e)
        {
            itemnamecb = "Chicken Biriyani ";
            if (qtycb != 0)
            {
                MessageBox.Show("Your foods add to cart successfully", "Order List", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please add quantity ", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_atcartvr(object sender, RoutedEventArgs e)
        {
            itemnamevr = "Vegetable Rice ";
            if (qtyvr != 0)
            {
                MessageBox.Show("Your foods add to cart successfully", "Order List", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please add quantity ", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_minusvegrice(object sender, RoutedEventArgs e)
        {
            if (qtyvr==0)
            {

            }
            else
            {
                qtyvr = qtyvr - 1;
                txt_vegrice.Text = Convert.ToString(qtyvr);
                totvr = 380 * qtyvr;
                ricetot = totvr + totsfr + totngr + totcfr + totcb;
                txt_ricetot.Text = Convert.ToString(ricetot);
            }
        }

        private void btn_plusseafrice(object sender, RoutedEventArgs e)
        {
            qtysfr = qtysfr + 1;
            txt_seafrice.Text = Convert.ToString(qtysfr);
            totsfr = 550 * qtysfr;
            ricetot = totvr + totsfr + totngr + totcfr + totcb;
            txt_ricetot.Text = Convert.ToString(ricetot);
        }

        private void btn_minusseafrice(object sender, RoutedEventArgs e)
        {
            if (qtysfr == 0)
            {

            }
            else
            {
                qtysfr = qtysfr - 1;
                txt_seafrice.Text = Convert.ToString(qtysfr);
                totsfr = 550 * qtysfr;
                ricetot = totvr + totsfr + totngr + totcfr + totcb;
                txt_ricetot.Text = Convert.ToString(ricetot);
            }
        }

        private void btn_plusngrice(object sender, RoutedEventArgs e)
        {
            qtyngr = qtyngr + 1;
            txt_ngrice.Text = Convert.ToString(qtyngr);
            totngr = 480 * qtyngr;
            ricetot = totvr + totsfr + totngr + totcfr + totcb;
            txt_ricetot.Text = Convert.ToString(ricetot);
        }

        private void btn_minusngrice(object sender, RoutedEventArgs e)
        {
            if (qtyngr==0)
            {

            }
            else
            {
                qtyngr = qtyngr - 1;
                txt_ngrice.Text = Convert.ToString(qtyngr);
                totngr = 480 * qtyngr;
                ricetot = totvr + totsfr + totngr + totcfr + totcb;
                txt_ricetot.Text = Convert.ToString(ricetot);
            }
        }

        private void btn_pluschbiriyani(object sender, RoutedEventArgs e)
        {
            qtycb = qtycb + 1;
            txt_chbiriyani.Text = Convert.ToString(qtycb);
            totcb = 450 * qtycb;
            ricetot = totvr + totsfr + totngr + totcfr + totcb;
            txt_ricetot.Text = Convert.ToString(ricetot);
        }

        private void btn_minuschbiriyani(object sender, RoutedEventArgs e)
        {
            if (qtycb==0)
            {

            }
            else
            {
                qtycb = qtycb - 1;
                txt_chbiriyani.Text = Convert.ToString(qtycb);
                totcb = 450 * qtycb;
                ricetot = totvr + totsfr + totngr + totcfr + totcb;
                txt_ricetot.Text = Convert.ToString(ricetot);
            }
        }

        private void btn_pluschfrice(object sender, RoutedEventArgs e)
        {
            qtycfr = qtycfr + 1;
            txt_chfrice.Text = Convert.ToString(qtycfr);
            totcfr = 350 * qtycfr;
            ricetot = totvr + totsfr + totngr + totcfr + totcb;
            txt_ricetot.Text = Convert.ToString(ricetot);
        }

        private void btn_minuschfrice(object sender, RoutedEventArgs e)
        {
            if (qtycfr==0)
            {

            }
            else
            {
                qtycfr = qtycfr - 1;
                txt_chfrice.Text = Convert.ToString(qtycfr);
                totcfr = 350 * qtycfr;
                ricetot = totvr + totsfr + totngr + totcfr + totcb;
                txt_ricetot.Text = Convert.ToString(ricetot);
            }
        }
    }
}
