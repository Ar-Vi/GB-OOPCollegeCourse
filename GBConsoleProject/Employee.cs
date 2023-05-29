using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBConsoleProject
{
    class Employee
    {

        private Int32 empID;
        private String empFirstName;
        private String empLastName;
        private Int32 empAnnualSalary;
        private Residence empResidence;
    

        public Employee(Int32 eID, String eFN, String eLN, Int32 eAS, Residence eR)
        {
            this.empID = eID;
            this.empFirstName = eFN;
            this.empLastName = eLN;
            this.empAnnualSalary = eAS;
            this.empResidence = eR;
        }
        public Employee(Int32 eID, String eFN, String eLN, Residence eR)
        {
            this.empID = eID;
            this.empFirstName = eFN;
            this.empLastName = eLN;
            this.empAnnualSalary = 60000;
            this.empResidence = eR;
        }

        public override string ToString()
        {
            return $"{empFirstName} {empLastName}, #{empID}\n Salary :  {empAnnualSalary}\n{empResidence.ToString()}";
        }
    }
}
