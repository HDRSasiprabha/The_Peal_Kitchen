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
    /// Interaction logic for Dessertselectionwindow.xaml
    /// </summary>
    public partial class Dessertselectionwindow : Window
    {
        public static int qtylava = 0,qtywat = 0,qtybp = 0,qtyccs = 0;
        public static double totlava = 0,totwat = 0,totbp = 0,totccs = 0,dessertamount = 0;
        public static string itemnamelava, itemnamewat, itemnamebp, itemnameccs;
        public Dessertselectionwindow()
        {
            InitializeComponent();
        }

        private void Btn_dessertback(object sender, RoutedEventArgs e)
        {
            MainWindow des = new MainWindow();
            des.Show();
        }

        private void btn_dessertshowcart(object sender, RoutedEventArgs e)
        {
            Cart_invoice_window dessc = new Cart_invoice_window();
            dessc.Show();
        }

        private void btn_minuslava(object sender, RoutedEventArgs e)
        {
            if (qtylava==0)
            {

            }
            else
            {
                qtylava = qtylava - 1;
                totlava = 300 * qtylava;
                txt_lava.Text = Convert.ToString(qtylava);
                dessertamount = totlava + totwat + totbp + totccs;
                txt_desserttot.Text = Convert.ToString(dessertamount);
            }

        }

        private void btn_pluslava(object sender, RoutedEventArgs e)
        {
            qtylava = qtylava + 1;
            totlava = 300 * qtylava;
            txt_lava.Text = Convert.ToString(qtylava);
            dessertamount = totlava + totwat + totbp + totccs;
            txt_desserttot.Text = Convert.ToString(dessertamount);
        }

        private void btn_atcartlava(object sender, RoutedEventArgs e)
        {
            itemnamelava = "Lava Cake ";
            if (qtylava != 0)
            {
                MessageBox.Show("Your desserts add to cart successfully", "Order List", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please add quantity ", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_atcartwat(object sender, RoutedEventArgs e)
        {
            itemnamewat = "Wattalappan ";
            if (qtywat != 0)
            {
                MessageBox.Show("Your desserts add to cart successfully", "Order List", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please add quantity ", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_atcartbispudding(object sender, RoutedEventArgs e)
        {
            itemnamebp = "Biscuits Pudding ";
            if (qtybp != 0)
            {
                MessageBox.Show("Your desserts add to cart successfully", "Order List", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please add quantity ", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_atcartccwithstraw(object sender, RoutedEventArgs e)
        {
            itemnameccs = "Cheese Cake with Strawberry ";
            if (qtyccs != 0)
            {
                MessageBox.Show("Your desserts add to cart successfully", "Order List", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please add quantity ", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_minuswat(object sender, RoutedEventArgs e)
        {
            if (qtywat==0)
            {

            }
            else
            {
                qtywat = qtywat - 1;
                totwat = qtywat * 350;
                txt_wat.Text = Convert.ToString(qtywat);
                dessertamount = totlava + totwat + totbp + totccs;
                txt_desserttot.Text = Convert.ToString(dessertamount);
            }

        }

        private void btn_pluswat(object sender, RoutedEventArgs e)
        {
            qtywat = qtywat + 1;
            totwat = qtywat * 350;
            txt_wat.Text = Convert.ToString(qtywat);
            dessertamount = totlava + totwat + totbp + totccs;
            txt_desserttot.Text = Convert.ToString(dessertamount);
        }

        private void btn_minusbp(object sender, RoutedEventArgs e)
        {
            if (qtybp==0)
            {

            }
            else
            {
                qtybp = qtybp - 1;
                totbp = qtybp * 350;
                txt_bp.Text = Convert.ToString(qtybp);
                dessertamount = totlava + totwat + totbp + totccs;
                txt_desserttot.Text = Convert.ToString(dessertamount);
            }

        }

        private void btn_plusbp(object sender, RoutedEventArgs e)
        {
            qtybp = qtybp + 1;
            totbp = qtybp * 350;
            txt_bp.Text = Convert.ToString(qtybp);
            dessertamount = totlava + totwat + totbp + totccs;
            txt_desserttot.Text = Convert.ToString(dessertamount);
        }

        private void btn_minusccwithstraw(object sender, RoutedEventArgs e)
        {
            if (qtyccs == 0)
            {

            }
            else
            {
                qtyccs = qtyccs - 1;
                totccs = qtyccs * 300;
                txt_ccs.Text = Convert.ToString(qtyccs);
                dessertamount = totlava + totwat + totbp + totccs;
                txt_desserttot.Text = Convert.ToString(dessertamount);
            }
        }

        private void btn_plusccwithstraw(object sender, RoutedEventArgs e)
        {
            qtyccs = qtyccs + 1;
            totccs = qtyccs * 300;
            txt_ccs.Text = Convert.ToString(qtyccs);
            dessertamount = totlava + totwat + totbp + totccs;
            txt_desserttot.Text = Convert.ToString(dessertamount);
        }

      

      
    }
}
