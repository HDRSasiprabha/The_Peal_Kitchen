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
using System.Data.SqlClient;
namespace ThePealKitchen
{
    /// <summary>
    /// Interaction logic for Drinksselectionwindow.xaml
    /// </summary>
    public partial class Drinksselectionwindow : Window
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public static int qtypep = 0, qtyco = 0, qtymin = 0, qtycap = 0, qtyice = 0;
        public static double totpep = 0, totco = 0, totmin = 0, totcap = 0, totice = 0, drinktot = 0;
        public static string itemnameco, itemnamepep, itemnamemin, itemnamecap, itemnameice;

        public Drinksselectionwindow()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=DESKTOP-4S88VMD;Initial Catalog=ThePealKitchen;Integrated Security=True");
        }



        private void Btn_plusp(object sender, RoutedEventArgs e)
        {

            qtypep = qtypep + 1;
            txt_qtypep.Text = Convert.ToString(qtypep);
            totpep = 200 * qtypep;
            drinktot = totcap + totco + totice + totmin + totpep;
            txt_drinktot.Text = Convert.ToString(drinktot);

        }

        private void Btn_minusp(object sender, RoutedEventArgs e)
        {

            if (qtypep == 0)
            {

            }
            else
            {
                qtypep = qtypep - 1;
                txt_qtypep.Text = Convert.ToString(qtypep);
                totpep = 200 * qtypep;
                drinktot = totcap + totco + totice + totmin + totpep;
                txt_drinktot.Text = Convert.ToString(drinktot);
            }
        }

        private void Btn_plusm(object sender, RoutedEventArgs e)
        {

            qtymin = qtymin + 1;
            txt_qtymin.Text = Convert.ToString(qtymin);
            totmin = 400 * qtymin;
            drinktot = totcap + totco + totice + totmin + totpep;
            txt_drinktot.Text = Convert.ToString(drinktot);
        }

        private void btn_atcartcola(object sender, RoutedEventArgs e)
        {
            itemnameco = "Coca Cola (150ml) ";


            if (qtyco != 0)
            {

                MessageBox.Show("Your desserts add to cart successfully", "Order List", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please add quantity ", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }




        }

        private void btn_atcartpep(object sender, RoutedEventArgs e)
        {
            itemnamepep = "Pepsi (150ml) ";

            if (qtypep != 0)
            {
                MessageBox.Show("Your desserts add to cart successfully", "Order List", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please add quantity ", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_atcartmoji(object sender, RoutedEventArgs e)
        {
            itemnamemin = "Mint Mojito ";

            if (qtymin != 0)
            {
                MessageBox.Show("Your desserts add to cart successfully", "Order List", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please add quantity ", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_atcartcap(object sender, RoutedEventArgs e)
        {
            itemnamecap = "Cappuccino ";

            if (qtycap != 0)
            {
                MessageBox.Show("Your desserts add to cart successfully", "Order List", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please add quantity ", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_atcartice(object sender, RoutedEventArgs e)
        {
            itemnameice = "Iced Coffee ";

            if (qtyice != 0)
            {
                MessageBox.Show("Your desserts add to cart successfully", "Order List", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please add quantity ", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Btn_minusm(object sender, RoutedEventArgs e)
        {

            if (qtymin == 0)
            {

            }
            else
            {
                qtymin = qtymin - 1;
                txt_qtymin.Text = Convert.ToString(qtymin);
                totmin = 400 * qtymin;
                drinktot = totcap + totco + totice + totmin + totpep;
                txt_drinktot.Text = Convert.ToString(drinktot);
            }

        }

        private void Btn_plusco(object sender, RoutedEventArgs e)
        {

            qtyco = qtyco + 1;
            txt_qtyco.Text = Convert.ToString(qtyco);
            totco = 200 * qtyco;
            drinktot = totcap + totco + totice + totmin + totpep;
            txt_drinktot.Text = Convert.ToString(drinktot);
        }

        private void Btn_minusco(object sender, RoutedEventArgs e)
        {

            if (qtyco == 0)
            {

            }
            else
            {
                qtyco = qtyco - 1;
                txt_qtyco.Text = Convert.ToString(qtyco);
                totco = 200 * qtyco;
                drinktot = totcap + totco + totice + totmin + totpep;
                txt_drinktot.Text = Convert.ToString(drinktot);
            }
        }

        private void Btn_minuscap(object sender, RoutedEventArgs e)
        {

            if (qtycap == 0)
            {

            }
            else
            {
                qtycap = qtycap - 1;
                txt_qtycap.Text = Convert.ToString(qtycap);
                totcap = 500 * qtycap;
                drinktot = totcap + totco + totice + totmin + totpep;
                txt_drinktot.Text = Convert.ToString(drinktot);
            }
        }

        private void Btn_pluscap(object sender, RoutedEventArgs e)
        {

            qtycap = qtycap + 1;
            txt_qtycap.Text = Convert.ToString(qtycap);
            totcap = 500 * qtycap;
            drinktot = totcap + totco + totice + totmin + totpep;
            txt_drinktot.Text = Convert.ToString(drinktot);
        }

        private void Btn_plusic(object sender, RoutedEventArgs e)
        {

            qtyice = qtyice + 1;
            txt_qtyice.Text = Convert.ToString(qtyice);
            totice = 200 * qtyice;
            drinktot = totcap + totco + totice + totmin + totpep;
            txt_drinktot.Text = Convert.ToString(drinktot);
        }

        private void Btn_minusic(object sender, RoutedEventArgs e)
        {

            if (qtyice == 0)
            {

            }
            else
            {
                qtyice = qtyice - 1;
                txt_qtyice.Text = Convert.ToString(qtyice);
                totice = 200 * qtyice;
                drinktot = totcap + totco + totice + totmin + totpep;
                txt_drinktot.Text = Convert.ToString(drinktot);
            }
        }

        private void Btn_showcartdw(object sender, RoutedEventArgs e)
        {
            Cart_invoice_window dsw = new Cart_invoice_window();
            dsw.Show();
        }

        private void Btn_drinkback(object sender, RoutedEventArgs e)
        {
            MainWindow dri = new MainWindow();
            dri.Show();
        }
    }
}
