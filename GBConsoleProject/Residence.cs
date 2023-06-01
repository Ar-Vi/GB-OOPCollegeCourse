using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBConsoleProject
{
    class Residence
    {

        private string streetName;
        private string cityName;
        private string zipCode;
        private string province;
        private string country;

      
        public Residence(string sN, string cN,string zC,string p,string c)
        {
            this.streetName = sN;
            this.cityName = cN;
            this.zipCode = zC;
            this.province = p;
            this.country = c;
        }

        public override string ToString()
        {
            return $"The Residence is: {country}, {province}, {cityName}, {streetName}, {zipCode}";
        }

        //Getters
        public String getStreetName(){
            return this.streetName;
        }
        public String getProvince(){
            return this.province;
        }public String getCityName(){
            return this.cityName;
        }public String getCountry(){
            return this.country;
        }public String getZipCode(){
            return this.zipCode;
        }

        //Setters
        public void setStreetName(String sN){
            this.streetName = sN;
        }
        public void setProvince(String p){
            this.streetName = p;
        }
        public void setCityName(String cN){
            this.streetName = cN;
        }
        public void setCountry(String c){
            this.streetName = c;
        }
        public void setZipCode(String zC){
            this.streetName = zC;
        }
    }
}
