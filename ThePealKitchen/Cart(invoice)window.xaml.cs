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
    /// Interaction logic for Cart_invoice_window.xaml
    /// </summary>
    public partial class Cart_invoice_window : Window
    {


        double amount = 0;
        double Net_dis = 0;

        public Cart_invoice_window(List<BillData> myBills)
        {
            InitializeComponent();

        }

        public Cart_invoice_window(string Name)
        {
            InitializeComponent();
            Txt_Username.Text = Name;
            //CalculateDiscount();
        }

        private void CalculateDiscount()
        {
            if (Txt_Username.Text != "")
            {
                txt_discount.Text = (Convert.ToDecimal(txt_total.Text) * Convert.ToDecimal(0.1)).ToString();
            }
        }

        public List<BillData> myBills { get; set; }
        public Cart_invoice_window()
        {
            InitializeComponent();
            myBills = new List<BillData>();

            if (!string.IsNullOrEmpty(Drinksselectionwindow.itemnameco))
            {
                BillData item1 = new BillData();
                item1.name = Drinksselectionwindow.itemnameco;
                item1.quantity = Drinksselectionwindow.qtyco;
                item1.unitprice = 200;
                item1.totpriceofitem = Drinksselectionwindow.totco;
                amount = amount + Drinksselectionwindow.totco;
                myBills.Add(item1);


            }
            if (!string.IsNullOrEmpty(Drinksselectionwindow.itemnamepep))
            {
                BillData item1 = new BillData();
                item1.name = Drinksselectionwindow.itemnamepep;
                item1.quantity = Drinksselectionwindow.qtypep;
                item1.unitprice = 200;
                item1.totpriceofitem = Drinksselectionwindow.totpep;
                amount = amount + Drinksselectionwindow.totpep;
                myBills.Add(item1);

            }
            if (!string.IsNullOrEmpty(Drinksselectionwindow.itemnamemin))
            {
                BillData item1 = new BillData();
                item1.name = Drinksselectionwindow.itemnamemin;
                item1.quantity = Drinksselectionwindow.qtymin;
                item1.unitprice = 400;
                item1.totpriceofitem = Drinksselectionwindow.totmin;
                amount = amount + Drinksselectionwindow.totmin;
                myBills.Add(item1);

            }
            if (!string.IsNullOrEmpty(Drinksselectionwindow.itemnamecap))
            {
                BillData item1 = new BillData();
                item1.name = Drinksselectionwindow.itemnamecap;
                item1.quantity = Drinksselectionwindow.qtycap;
                item1.unitprice = 500;
                item1.totpriceofitem = Drinksselectionwindow.totcap;
                amount = amount + Drinksselectionwindow.totcap;
                myBills.Add(item1);

            }
            if (!string.IsNullOrEmpty(Drinksselectionwindow.itemnameice))
            {
                BillData item1 = new BillData();
                item1.name = Drinksselectionwindow.itemnameice;
                item1.quantity = Drinksselectionwindow.qtyice;
                item1.unitprice = 200;
                item1.totpriceofitem = Drinksselectionwindow.totice;
                amount = amount + Drinksselectionwindow.totice;
                myBills.Add(item1);

            }
            if (!string.IsNullOrEmpty(Dessertselectionwindow.itemnamelava))
            {
                BillData item1 = new BillData();
                item1.name = Dessertselectionwindow.itemnamelava;
                item1.quantity = Dessertselectionwindow.qtylava;
                item1.unitprice = 300;
                item1.totpriceofitem = Dessertselectionwindow.totlava;
                amount = amount + Dessertselectionwindow.totlava;
                myBills.Add(item1);

            }
            if (!string.IsNullOrEmpty(Dessertselectionwindow.itemnamewat))
            {
                BillData item1 = new BillData();
                item1.name = Dessertselectionwindow.itemnamewat;
                item1.quantity = Dessertselectionwindow.qtywat;
                item1.unitprice = 350;
                item1.totpriceofitem = Dessertselectionwindow.totwat;
                amount = amount + Dessertselectionwindow.totwat;
                myBills.Add(item1);

            }
            if (!string.IsNullOrEmpty(Dessertselectionwindow.itemnamebp))
            {
                BillData item1 = new BillData();
                item1.name = Dessertselectionwindow.itemnamebp;
                item1.quantity = Dessertselectionwindow.qtybp;
                item1.unitprice = 350;
                item1.totpriceofitem = Dessertselectionwindow.totbp;
                amount = amount + Dessertselectionwindow.totbp;
                myBills.Add(item1);

            }
            if (!string.IsNullOrEmpty(Dessertselectionwindow.itemnameccs))
            {
                BillData item1 = new BillData();
                item1.name = Dessertselectionwindow.itemnameccs;
                item1.quantity = Dessertselectionwindow.qtyccs;
                item1.unitprice = 300;
                item1.totpriceofitem = Dessertselectionwindow.totccs;
                amount = amount + Dessertselectionwindow.totccs;
                myBills.Add(item1);

            }
            if (!string.IsNullOrEmpty(Kottumenuwindow.itemnamebk))
            {
                BillData item1 = new BillData();
                item1.name = Kottumenuwindow.itemnamebk;
                item1.quantity = Kottumenuwindow.qtybk;
                item1.unitprice = 480;
                item1.totpriceofitem = Kottumenuwindow.totbk;
                amount = amount + Kottumenuwindow.totbk;
                myBills.Add(item1);
            }
            if (!string.IsNullOrEmpty(Kottumenuwindow.itemnameck))
            {
                BillData item1 = new BillData();
                item1.name = Kottumenuwindow.itemnameck;
                item1.quantity = Kottumenuwindow.qtyck;
                item1.unitprice = 350;
                item1.totpriceofitem = Kottumenuwindow.totck;
                amount = amount + Kottumenuwindow.totck;
                myBills.Add(item1);
            }
            if (!string.IsNullOrEmpty(Kottumenuwindow.itemnameek))
            {
                BillData item1 = new BillData();
                item1.name = Kottumenuwindow.itemnameek;
                item1.quantity = Kottumenuwindow.qtyek;
                item1.unitprice = 450;
                item1.totpriceofitem = Kottumenuwindow.totek;
                amount = amount + Kottumenuwindow.totek;
                myBills.Add(item1);
            }
            if (!string.IsNullOrEmpty(Kottumenuwindow.itemnamesk))
            {
                BillData item1 = new BillData();
                item1.name = Kottumenuwindow.itemnamesk;
                item1.quantity = Kottumenuwindow.qtysk;
                item1.unitprice = 350;
                item1.totpriceofitem = Kottumenuwindow.totsk;
                amount = amount + Kottumenuwindow.totsk;
                myBills.Add(item1);
            }
            if (!string.IsNullOrEmpty(Kottumenuwindow.itemnamedk))
            {
                BillData item1 = new BillData();
                item1.name = Kottumenuwindow.itemnamedk;
                item1.quantity = Kottumenuwindow.qtydk;
                item1.unitprice = 350;
                item1.totpriceofitem = Kottumenuwindow.totdk;
                amount = amount + Kottumenuwindow.totdk;
                myBills.Add(item1);
            }
            if (!string.IsNullOrEmpty(Noodlesmenuwindow.itemnamecsn))
            {
                BillData item1 = new BillData();
                item1.name = Noodlesmenuwindow.itemnamecsn;
                item1.quantity = Noodlesmenuwindow.qtycsn;
                item1.unitprice = 350;
                item1.totpriceofitem = Noodlesmenuwindow.totcsn;
                amount = amount + Noodlesmenuwindow.totcsn;
                myBills.Add(item1);
            }
            if (!string.IsNullOrEmpty(Noodlesmenuwindow.itemnamesn))
            {
                BillData item1 = new BillData();
                item1.name = Noodlesmenuwindow.itemnamesn;
                item1.quantity = Noodlesmenuwindow.qtysn;
                item1.unitprice = 450;
                item1.totpriceofitem = Noodlesmenuwindow.totsn;
                amount = amount + Noodlesmenuwindow.totsn;
                myBills.Add(item1);
            }
            if (!string.IsNullOrEmpty(Noodlesmenuwindow.itemnamevn))
            {
                BillData item1 = new BillData();
                item1.name = Noodlesmenuwindow.itemnamevn;
                item1.quantity = Noodlesmenuwindow.qtyvn;
                item1.unitprice = 480;
                item1.totpriceofitem = Noodlesmenuwindow.totvn;
                amount = amount + Noodlesmenuwindow.totvn;
                myBills.Add(item1);
            }
            if (!string.IsNullOrEmpty(Noodlesmenuwindow.itemnameefn))
            {
                BillData item1 = new BillData();
                item1.name = Noodlesmenuwindow.itemnameefn;
                item1.quantity = Noodlesmenuwindow.qtyefn;
                item1.unitprice = 350;
                item1.totpriceofitem = Noodlesmenuwindow.totefn;
                amount = amount + Noodlesmenuwindow.totefn;
                myBills.Add(item1);
            }
            if (!string.IsNullOrEmpty(Noodlesmenuwindow.itemnameffn))
            {
                BillData item1 = new BillData();
                item1.name = Noodlesmenuwindow.itemnameffn;
                item1.quantity = Noodlesmenuwindow.qtyffn;
                item1.unitprice = 350;
                item1.totpriceofitem = Noodlesmenuwindow.totffn;
                amount = amount + Noodlesmenuwindow.totffn;
                myBills.Add(item1);
            }
            if (!string.IsNullOrEmpty(Pastamenuwindow.itemnamecl))
            {
                BillData item1 = new BillData();
                item1.name = Pastamenuwindow.itemnamecl;
                item1.quantity = Pastamenuwindow.qtycl;
                item1.unitprice = 650;
                item1.totpriceofitem = Pastamenuwindow.totcl;
                amount = amount + Pastamenuwindow.totcl;
                myBills.Add(item1);
            }
            if (!string.IsNullOrEmpty(Pastamenuwindow.itemnamemcp))
            {
                BillData item1 = new BillData();
                item1.name = Pastamenuwindow.itemnamemcp;
                item1.quantity = Pastamenuwindow.qtymcp;
                item1.unitprice = 580;
                item1.totpriceofitem = Pastamenuwindow.totmcp;
                amount = amount + Pastamenuwindow.totmcp;
                myBills.Add(item1);
            }
            if (!string.IsNullOrEmpty(Pastamenuwindow.itemnamespbp))
            {
                BillData item1 = new BillData();
                item1.name = Pastamenuwindow.itemnamespbp;
                item1.quantity = Pastamenuwindow.qtyspbp;
                item1.unitprice = 500;
                item1.totpriceofitem = Pastamenuwindow.totspbp;
                amount = amount + Pastamenuwindow.totspbp;
                myBills.Add(item1);
            }
            if (!string.IsNullOrEmpty(Ricemenuwindow.itemnamecfr))
            {
                BillData item1 = new BillData();
                item1.name = Ricemenuwindow.itemnamecfr;
                item1.quantity = Ricemenuwindow.qtycfr;
                item1.unitprice = 350;
                item1.totpriceofitem = Ricemenuwindow.totcfr;
                amount = amount + Ricemenuwindow.totcfr;
                myBills.Add(item1);
            }
            if (!string.IsNullOrEmpty(Ricemenuwindow.itemnamecb))
            {
                BillData item1 = new BillData();
                item1.name = Ricemenuwindow.itemnamecb;
                item1.quantity = Ricemenuwindow.qtycb;
                item1.unitprice = 450;
                item1.totpriceofitem = Ricemenuwindow.totcb;
                amount = amount + Ricemenuwindow.totcb;
                myBills.Add(item1);
            }
            if (!string.IsNullOrEmpty(Ricemenuwindow.itemnamevr))
            {
                BillData item1 = new BillData();
                item1.name = Ricemenuwindow.itemnamevr;
                item1.quantity = Ricemenuwindow.qtyvr;
                item1.unitprice = 380;
                item1.totpriceofitem = Ricemenuwindow.totvr;
                amount = amount + Ricemenuwindow.totvr;
                myBills.Add(item1);
            }
            if (!string.IsNullOrEmpty(Ricemenuwindow.itemnamesfr))
            {
                BillData item1 = new BillData();
                item1.name = Ricemenuwindow.itemnamesfr;
                item1.quantity = Ricemenuwindow.qtysfr;
                item1.unitprice = 550;
                item1.totpriceofitem = Ricemenuwindow.totsfr;
                amount = amount + Ricemenuwindow.totsfr;
                myBills.Add(item1);
            }
            if (!string.IsNullOrEmpty(Ricemenuwindow.itemnamengr))
            {
                BillData item1 = new BillData();
                item1.name = Ricemenuwindow.itemnamengr;
                item1.quantity = Ricemenuwindow.qtyngr;
                item1.unitprice = 480;
                item1.totpriceofitem = Ricemenuwindow.totngr;
                amount = amount + Ricemenuwindow.totngr;
                myBills.Add(item1);
            }

            
            txt_total.Text = Convert.ToString(amount);

            String name = null;
            if (App.Current.Properties["NameOfProperty"] != null)
            {
                name = App.Current.Properties["NameOfProperty"].ToString();
            }
            
            if (name != null)
            {
                txt_discount.Text = (Convert.ToDecimal(txt_total.Text) * Convert.ToDecimal(0.1)).ToString();
                Net_dis = Convert.ToDouble(txt_discount.Text);
            }

            DataContext = this;
            txt_Finaltot.Text = Convert.ToString(amount - Net_dis);

        }


        private void Btn_backin(object sender, RoutedEventArgs e)
        {
            MainWindow usmenu = new MainWindow();
            usmenu.Show();

        }

        private void Btn_proceed(object sender, RoutedEventArgs e)
        {
            Hide();
            Window1 w = new Window1();
            w.Show();

        }

        private void txt_total_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btn_Reset_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.Application.Restart();
            Close();

        }
    }
}
