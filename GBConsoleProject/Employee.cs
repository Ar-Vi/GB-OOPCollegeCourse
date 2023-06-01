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

        //Basic Emp Constructor 
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
            return $"{empFirstName} {empLastName}, #{empID}\nSalary :  {empAnnualSalary}\n{empResidence.ToString()}";
        }

        //Getters
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

        //Setters
        public void setID(Int32 eID){
            this.empID = eID;
        }
        public void setFirstName(String eFN){
            this.empFirstName = eFN;
        }
        public void setLastName(String eLN){
            this.empLastName = eLN;
        }
        public void setAnnualSalary(Int32 eAS){
            this.empAnnualSalary = eAS;
        }
        public void setResidence(String sN, String cN, String zC, String p, String c){
            this.empResidence.setStreetName(sN);
            this.empResidence.setCityName(cN);
            this.empResidence.setZipCode(zC);
            this.empResidence.setProvince(p);
            this.empResidence.setCountry(c);
        }
        
    

    }
}
