using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project1
{
    public class Deal
    {
        private Item itemselected;

        public Item Itemselected
        {
            get { return itemselected; }
            set { itemselected = value; }
        }
        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        private int subtotal;

        public int Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }
        private int total;

        public int Total
        {
            get { return total; }
            set { total = value; }
        }
        private int tax;

        public int Tax
        {
            get { return tax; }
            set { tax = value; }
        }

    }
}