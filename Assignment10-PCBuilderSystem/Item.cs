using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment10_PCBuilderSystem
{
    class Item
    {
        private string productName;
        private double price;
        private int quantity;

        public Item(string productName,int quantity,double price)
        {
            this.productName = productName;
            this.quantity = quantity;
            this.price = price;
        }

        public string getProductName()
        {
            return productName;
        }

        public Double getPrice()
        {
            return price;
        }

        public int  getQuantity()
        {
            return quantity;
        }
    }
}
