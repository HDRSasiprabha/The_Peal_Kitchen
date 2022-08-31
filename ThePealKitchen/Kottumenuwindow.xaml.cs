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
    /// Interaction logic for Kottumenuwindow.xaml
    /// </summary>
    public partial class Kottumenuwindow : Window
    {
        public static int qtyck = 0, qtyek = 0, qtybk = 0,qtysk = 0,qtydk = 0;
        public static double totck = 0, totek = 0, totbk = 0, totsk = 0, totdk = 0,kottutot=0;
        public static string itemnameck, itemnameek, itemnamebk, itemnamesk, itemnamedk;
          public Kottumenuwindow()
        {
            InitializeComponent();
        }

        private void Btn_backkottu(object sender, RoutedEventArgs e)
        {
            Foodselectionwindow kfs = new Foodselectionwindow();
            kfs.Show();
        }

        private void Btn_showcartkottu(object sender, RoutedEventArgs e)
        {
            Cart_invoice_window ksc = new Cart_invoice_window();
            ksc.Show();
        }

        private void btn_plusck(object sender, RoutedEventArgs e)
        {
            qtyck = qtyck + 1;
            txt_ck.Text = Convert.ToString(qtyck);
            totck = 350 * qtyck;
            kottutot = totbk + totck + totdk + totek + totsk;
            txt_kottutot.Text = Convert.ToString(kottutot);

        }

        private void btn_atcartck(object sender, RoutedEventArgs e)
        {
            itemnameck = "Chicken Kottu ";
            if (qtyck != 0)
            {
                MessageBox.Show("Your foods add to cart successfully", "Order List", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please add quantity ", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_atcartek(object sender, RoutedEventArgs e)
        {
            itemnameek = "Egg Kottu ";
            if (qtyek != 0)
            {
                MessageBox.Show("Your foods add to cart successfully", "Order List", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please add quantity ", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_atcartbk(object sender, RoutedEventArgs e)
        {
            itemnamebk = "Beef Kottu ";
            if (qtybk != 0)
            {
                MessageBox.Show("Your foods add to cart successfully", "Order List", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please add quantity ", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_atcartsfk(object sender, RoutedEventArgs e)
        {
            itemnamesk = "SeaFood Kottu ";
            if (qtysk != 0)
            {
                MessageBox.Show("Your foods add to cart successfully", "Order List", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please add quantity ", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_atcartdk(object sender, RoutedEventArgs e)
        {
            itemnamedk = "Dolphin Kottu ";
            if (qtydk != 0)
            {
                MessageBox.Show("Your foods add to cart successfully", "Order List", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please add quantity ", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_minusck(object sender, RoutedEventArgs e)
        {
            if (qtyck == 0)
            {

            }
            else
            {
                qtyck = qtyck - 1;
                txt_ck.Text = Convert.ToString(qtyck);
                totck = 350 * qtyck;
                kottutot = totbk + totck + totdk + totek + totsk;
                txt_kottutot.Text = Convert.ToString(kottutot);
            }
        }

        private void btn_plusek(object sender, RoutedEventArgs e)
        {
            qtyek = qtyek + 1;
            txt_ek.Text = Convert.ToString(qtyek);
            totek = 450 * qtyek;
            kottutot = totbk + totck + totdk + totek + totsk;
            txt_kottutot.Text = Convert.ToString(kottutot);
        }

        private void btn_minusek(object sender, RoutedEventArgs e)
        {
            if (qtyek== 0)
            {

            }
            else
            {
                qtyek = qtyek - 1;
                txt_ek.Text = Convert.ToString(qtyek);
                totek = 450 * qtyek;
                kottutot = totbk + totck + totdk + totek + totsk;
                txt_kottutot.Text = Convert.ToString(kottutot);
            }
        }

        private void btn_plusbk(object sender, RoutedEventArgs e)
        {
            qtybk = qtybk + 1;
            txt_bk.Text = Convert.ToString(qtybk);
            totbk = 480 * qtybk;
            kottutot = totbk + totck + totdk + totek + totsk;
            txt_kottutot.Text = Convert.ToString(kottutot);
        }

        private void btn_minusbk(object sender, RoutedEventArgs e)
        {
            if (qtybk == 0)
            {

            }
            else
            {
                qtybk = qtybk - 1;
                txt_bk.Text = Convert.ToString(qtybk);
                totbk = 480 * qtybk;
                kottutot = totbk + totck + totdk + totek + totsk;
                txt_kottutot.Text = Convert.ToString(kottutot);
            }
        }

        private void btn_minussk(object sender, RoutedEventArgs e)
        {
            if (qtysk == 0)
            {

            }
            else
            {
                qtysk = qtysk - 1;
                txt_sk.Text = Convert.ToString(qtysk);
                totsk = 350 * qtysk;
                kottutot = totbk + totck + totdk + totek + totsk;
                txt_kottutot.Text = Convert.ToString(kottutot);
            }
        }

        private void btn_plussk(object sender, RoutedEventArgs e)
        {
            qtysk = qtysk + 1;
            txt_sk.Text = Convert.ToString(qtysk);
            totsk = 350 * qtysk;
            kottutot = totbk + totck + totdk + totek + totsk;
            txt_kottutot.Text = Convert.ToString(kottutot);
        }

        private void btn_minusdk(object sender, RoutedEventArgs e)
        {
            if (qtydk == 0)
            {

            }
            else
            {
                qtydk = qtydk - 1;
                txt_dk.Text = Convert.ToString(qtydk);
                totdk = 350 * qtydk;
                kottutot = totbk + totck + totdk + totek + totsk;
                txt_kottutot.Text = Convert.ToString(kottutot);
            }
        }

        private void btn_plusdk(object sender, RoutedEventArgs e)
        {
            qtydk = qtydk + 1;
            txt_dk.Text = Convert.ToString(qtydk);
            totdk = 350 * qtydk;
            kottutot = totbk + totck + totdk + totek + totsk;
            txt_kottutot.Text = Convert.ToString(kottutot);
        }
    }
}
