using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment10_PCBuilderSystem
{
    class Order
    {
        Item[] items = new Item[100];
        private int itemCount;
        private int customerID;
        private DateTime orderDate;

        public Order(int customerID)
        {
            this.customerID = customerID;
            itemCount = 0;
            orderDate = DateTime.Now;

        }

        public void AddItem(string productName,double price,int quantity)
        {
            
            items[itemCount] = new Item(productName, quantity, price);
            itemCount++;
        }
        public Item getItem(int i)
        {
            if(i < itemCount)
            {
                return items[i];
            }
            else
            {
                return null
            }
        }
    }
}
