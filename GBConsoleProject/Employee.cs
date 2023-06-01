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
    

        public Employee(Int32 eID, String eFN, String eLN, Int32 eAS, String sN, String cN, String zC, String p, String c)
        {
            this.empID = eID;
            this.empFirstName = eFN;
            this.empLastName = eLN;
            this.empAnnualSalary = eAS;
            this.empResidence = new Residence(sN, cN, zC, p, c);
        }
        public Employee(Int32 eID, String eFN, String eLN, String sN, String cN, String zC, String p, String c)
        {
            this.empID = eID;
            this.empFirstName = eFN;
            this.empLastName = eLN;
            this.empAnnualSalary = 60000;
            this.empResidence = new Residence(sN, cN, zC, p, c);
        }

        public override string ToString()
        {
            return $"{empFirstName} {empLastName}, #{empID}\n Salary :  {empAnnualSalary}\n{empResidence.ToString()}";
        }
        public Int32 getID(){
            return this.empID;
        }
        public String getFirstName(){
            return this.empFirstName;
        }
        public String getLastName(){
            return this.empLastName;
        }
        public Int32 getAnnualSalary(){
            return this.empAnnualSalary;
        }
        public String getResidence(){
            return this.empResidence.ToString();
        }
    }
}
