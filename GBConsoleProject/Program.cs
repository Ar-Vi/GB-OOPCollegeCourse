using System;

namespace GBConsoleProject
{
    class Program
    {
        static void inventoryParse(string[] items, double[] prices)
        {
            int len = items.Length;
   
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(items[i] + ", $" + Convert.ToString(prices[i]));
            }
        }
        public static void Main(string[] args)
        {
            double wallet;
            string userName;
            string choice = "start";
            string[] inventory = { "Banan", "FruitHere", "Computer" };
            double[] prices = { 12.0, 1.97, 390.99 };

            Console.WriteLine("Enter Thy Name:");

            userName = Console.ReadLine();
            Console.WriteLine("How much money you got?");
            wallet = Convert.ToDouble(Console.ReadLine());

            while(choice!="e" && choice != "E")
            {
                Console.WriteLine("\nWhat may I do for you, " + userName + "?\n[1] Look at Inventory\n[2] Place Order in Cart\n[3] Checkout\n[E] Exit Program :(");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("OK, here's the Goods");
                        inventoryParse(inventory, prices);
                        break;
                    case "2":
                        // code block
                        break;
                    case "3":
                        // code block
                        break;
                    case "E":
                        Console.WriteLine("Bye bye " + userName + ", hope you exist tmrw too");
                        break;

                    default:
                        Console.WriteLine("INVALID INPUT >:(");
                        break;
                }
            }



           

        }
    }
}
