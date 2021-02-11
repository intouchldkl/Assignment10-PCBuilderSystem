using System;

namespace Assignment10_PCBuilderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Item[] shopItems = new Item[10];
            FillShop(shopItems);
            PrintMenu(shopItems);
            Order myOrder = FillOrder(shopItems);

            Console.WriteLine(myOrder.CalculateBill());

           
        }

        static void FillShop(Item[] shopItems)
        {
            shopItems[0] = new Item("CPU", 0, 99.99);
            shopItems[1] = new Item("Motherboard", 0, 59.99);
            shopItems[2] = new Item("Graphic card", 0, 69.99);
            shopItems[3] = new Item("RAM", 0, 49.99);
            shopItems[4] = new Item("Keyboard", 0, 19.99);
            shopItems[5] = new Item("Monitor", 0, 89.99);
        }

        
        static void PrintMenu(Item[] shopItems)
        {

           
            Console.WriteLine("{0,3}{1,15} {2,5:c2}", "#", "PRODUCT", "PRICE");
            for (int i = 0; i < shopItems.Length;i++)
            {
                if (shopItems[i] != null)
                {

                    Console.WriteLine("{0,3}{1,15} {2,5:c2}",i,shopItems[i].getProductName(),shopItems[i].getPrice());
                }
            }

        }

        static Order FillOrder(Item[] shopsItems)
        {
            Order myOrder = new Order(0);
            string UserInput = "";

            while (UserInput != "exit")
            {
                Console.WriteLine("CHOOSE A NUMBER");
                UserInput = Console.ReadLine();
                if (UserInput == "exit") break;
                int i;
               if( !int.TryParse(UserInput, out i)) continue;
               
            
                

                Console.WriteLine("How many " + shopsItems[i].getProductName() + " would you like?");

                UserInput = Console.ReadLine();
                int quantity;
                if (!int.TryParse(UserInput, out quantity)) continue;
             

                myOrder.AddItem(shopsItems[i].getProductName(), shopsItems[i].getPrice(), quantity);

            }
            return myOrder;
        }

    }
}
