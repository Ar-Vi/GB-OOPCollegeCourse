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
    }
}
