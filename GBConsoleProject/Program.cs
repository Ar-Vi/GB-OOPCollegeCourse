using System;
using System.Collections;

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
            var employeeDB = new ArrayList();
            string choice = "start";
            

            

           

            

            while(choice!="4")
            {
                Console.WriteLine("MENU\n==================\n[1] Add Employee\n[2] Generate Payroll\n[3] Find an Employee's information\n[4] Exit Program :(");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                     
                        break;
                    case "2":
                        // code block
                        break;
                    case "3":
                        // code block
                        break;
                    case "4":
                        Console.WriteLine("Cya!");
                        break;

                    default:
                        Console.WriteLine("INVALID INPUT >:(");
                        break;
                }
            }



           

        }
    }
}
