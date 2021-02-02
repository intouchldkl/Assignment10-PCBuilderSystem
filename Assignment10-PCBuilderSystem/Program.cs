using System;

namespace Assignment10_PCBuilderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Order IntouchPC = new Order(1);
            IntouchPC.AddItem("CPU i9", 99.99, 1);
            IntouchPC.AddItem("RAM", 80, 2);
            IntouchPC.AddItem("Graphic card",50, 1);

            if(IntouchPC.getItem(2) != null)
            {
                Console.WriteLine(IntouchPC.getItem(2).getProductName());
            }
        }
    }
}
