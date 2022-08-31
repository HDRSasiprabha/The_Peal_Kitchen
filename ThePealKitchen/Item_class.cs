using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ThePealKitchen
{
    public class Item_class
    {
        public static int qty = 0;
        public static double tot = 0;
       
        
        public static string itemID;
        public static double totamount = 0;
     
        public void minusqty(double unitprice)
        {
            if (qty == 0)
            {

            }
            else
            {
                qty = qty - 1;
                tot = unitprice * qty;
                totamount = totamount + tot;
            }
        }
        public void plusqty(double unitprice)
        {
            qty = qty + 1;
            tot = unitprice * qty;
            totamount = totamount + tot;
        }
        public void addtocart()
        {
            
            if (qty != 0)
            {
                MessageBox.Show("Your desserts add to cart successfully", "Order List", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please add quantity ", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }
}
