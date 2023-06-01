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
            
            Console.WriteLine("=================\n=================\n WELCOME =================\n=================\n");

            while(choice!="4")
            {
                Console.WriteLine("MENU\n==================\n[1] Add Employee\n[2] Generate Payroll\n[3] Find an Employee's information\n[4] Exit Program :(");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                    //COLLECTING PARAMS FOR EMP OBJ
                        //generated ID based on how many emps there are
                        // will never be repeated among employees
                        Int32 empID = employeeDB.Count+1;

                        Console.WriteLine("First Name: ");
                        String empFirstName = Console.ReadLine();

                        Console.WriteLine("Last Name: ");
                        String empLastName = Console.ReadLine();

                        Console.WriteLine("Annual Salary (Leave blank if basic): ");
                        Int32 empAnnualSalary = Int32.Parse(Console.ReadLine());

                        // PARAMETERS FOR RESIDENCE OBJ
                        Console.WriteLine("Street: ");
                        String streetName = Console.ReadLine();
                        Console.WriteLine("City: ");
                        String cityName = Console.ReadLine();
                        Console.WriteLine("Zip Code: ");
                        String zipCode = Console.ReadLine();
                        Console.WriteLine("Province: ");
                        String province = Console.ReadLine();
                        Console.WriteLine("Country: ");
                        String country = Console.ReadLine();

                        //Check if overloaded case is needed
                        Employee empToAdd;
                        if(empAnnualSalary == null){
                            empToAdd = new Employee(empID, empFirstName, empLastName, streetName, cityName, zipCode, province, country);

                        }
                        else{
                            empToAdd = new Employee(empID, empFirstName, empLastName, empAnnualSalary, streetName, cityName, zipCode, province, country);

                        }
                        
                        //Adding emp to DB
                        employeeDB.Add(empToAdd);

                        Console.WriteLine("Employee Added!");
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
