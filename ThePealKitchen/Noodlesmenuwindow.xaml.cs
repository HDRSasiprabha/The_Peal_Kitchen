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
    /// Interaction logic for Noodlesmenuwindow.xaml
    /// </summary>
    public partial class Noodlesmenuwindow : Window
    { 
    public static int qtycsn = 0, qtysn = 0, qtyvn = 0, qtyefn = 0, qtyffn = 0;
    public static double totcsn = 0, totsn = 0, totvn = 0, totefn = 0, totffn = 0, noodlesstot = 0;
    public static string itemnamecsn, itemnamesn, itemnamevn, itemnameefn, itemnameffn;
    public Noodlesmenuwindow()
    {
        InitializeComponent();
    }

    private void Btn_showcartnw(object sender, RoutedEventArgs e)
    {
        Cart_invoice_window nsc = new Cart_invoice_window();
        nsc.Show();
    }

    private void Btn_backnw(object sender, RoutedEventArgs e)
    {
        Foodselectionwindow nfs = new Foodselectionwindow();
        nfs.Show();
    }

    private void btn_minuscsn(object sender, RoutedEventArgs e)
    {
        if (qtycsn == 0)
        {

        }
        else
        {
            qtycsn = qtycsn - 1;
            txt_csn.Text = Convert.ToString(qtycsn);
            totcsn = 350 * qtycsn;
            noodlesstot = totcsn + totefn + totffn + totsn + totvn;
            txt_noodlesstot.Text = Convert.ToString(noodlesstot);
        }
    }

    private void btn_atcartcsn(object sender, RoutedEventArgs e)
    {
        itemnamecsn = "Chicken Spicy Noodless ";
        if (qtycsn != 0)
        {
            MessageBox.Show("Your Noodless add to cart successfully", "Order List", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        else
        {
            MessageBox.Show("Please add quantity ", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    private void btn_atcartsfn(object sender, RoutedEventArgs e)
    {
        itemnamesn = "SeaFood Noodless ";
        if (qtysn != 0)
        {
            MessageBox.Show("Your Noodless add to cart successfully", "Order List", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        else
        {
            MessageBox.Show("Please add quantity ", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    private void btn_atcartvn(object sender, RoutedEventArgs e)
    {
        itemnamevn = "Vegetable Noodless ";
        if (qtyvn != 0)
        {
            MessageBox.Show("Your Noodless add to cart successfully", "Order List", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        else
        {
            MessageBox.Show("Please add quantity ", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    private void btn_atcartefn(object sender, RoutedEventArgs e)
    {
        itemnameefn = "Egg Fried Noodless ";
        if (qtyefn != 0)
        {
            MessageBox.Show("Your Noodless add to cart successfully", "Order List", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        else
        {
            MessageBox.Show("Please add quantity ", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    private void btn_atcartffn(object sender, RoutedEventArgs e)
    {
        itemnameffn = "Fish Fried Noodless ";
        if (qtyffn != 0)
        {
            MessageBox.Show("Your Noodless add to cart successfully", "Order List", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        else
        {
            MessageBox.Show("Please add quantity ", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    private void btn_pluscsn(object sender, RoutedEventArgs e)
    {
        qtycsn = qtycsn + 1;
        txt_csn.Text = Convert.ToString(qtycsn);
        totcsn = 350 * qtycsn;
        noodlesstot = totcsn + totefn + totffn + totsn + totvn;
        txt_noodlesstot.Text = Convert.ToString(noodlesstot);
    }

    private void btn_minussn(object sender, RoutedEventArgs e)
    {
        if (qtysn == 0)
        {

        }
        else
        {
            qtysn = qtysn - 1;
            txt_sn.Text = Convert.ToString(qtysn);
            totsn = 450 * qtysn;
            noodlesstot = totcsn + totefn + totffn + totsn + totvn;
            txt_noodlesstot.Text = Convert.ToString(noodlesstot);
        }
    }

    private void btn_plussn(object sender, RoutedEventArgs e)
    {
        qtysn = qtysn + 1;
        txt_sn.Text = Convert.ToString(qtysn);
        totsn = 450 * qtysn;
        noodlesstot = totcsn + totefn + totffn + totsn + totvn;
        txt_noodlesstot.Text = Convert.ToString(noodlesstot);
    }

    private void btn_minusvn(object sender, RoutedEventArgs e)
    {
        if (qtyvn == 0)
        {

        }
        else
        {
            qtyvn = qtyvn - 1;
            txt_vn.Text = Convert.ToString(qtyvn);
            totvn = 480 * qtyvn;
            noodlesstot = totcsn + totefn + totffn + totsn + totvn;
            txt_noodlesstot.Text = Convert.ToString(noodlesstot);
        }
    }

    private void btn_plusvn(object sender, RoutedEventArgs e)
    {
        qtyvn = qtyvn + 1;
        txt_vn.Text = Convert.ToString(qtyvn);
        totvn = 480 * qtyvn;
        noodlesstot = totcsn + totefn + totffn + totsn + totvn;
        txt_noodlesstot.Text = Convert.ToString(noodlesstot);
    }

    private void btn_minusefn(object sender, RoutedEventArgs e)
    {
        if (qtyefn == 0)
        {

        }
        else
        {
            qtyefn = qtyefn - 1;
            txt_efn.Text = Convert.ToString(qtyefn);
            totefn = 350 * qtyefn;
            noodlesstot = totcsn + totefn + totffn + totsn + totvn;
            txt_noodlesstot.Text = Convert.ToString(noodlesstot);
        }
    }

    private void btn_plusefn(object sender, RoutedEventArgs e)
    {
        qtyefn = qtyefn + 1;
        txt_efn.Text = Convert.ToString(qtyefn);
        totefn = 350 * qtyefn;
        noodlesstot = totcsn + totefn + totffn + totsn + totvn;
        txt_noodlesstot.Text = Convert.ToString(noodlesstot);
    }

    private void btn_minusffn(object sender, RoutedEventArgs e)
    {
        if (qtyffn == 0)
        {

        }
        else
        {
            qtyffn = qtyffn - 1;
            txt_ffn.Text = Convert.ToString(qtyffn);
            totffn = 350 * qtyffn;
            noodlesstot = totcsn + totefn + totffn + totsn + totvn;
            txt_noodlesstot.Text = Convert.ToString(noodlesstot);
        }
    }

    private void btn_plusffn(object sender, RoutedEventArgs e)
    {
        qtyffn = qtyffn + 1;
        txt_ffn.Text = Convert.ToString(qtyffn);
        totffn = 350 * qtyffn;
        noodlesstot = totcsn + totefn + totffn + totsn + totvn;
        txt_noodlesstot.Text = Convert.ToString(noodlesstot);
    }
}
}
