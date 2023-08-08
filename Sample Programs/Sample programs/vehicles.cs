/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidhya
{
    class vehicles
    {
        public string name, number;
    }
    class vehiclesinfo
    {
       // private string a;
        private vehiclereport vp;
        private vehicles getvehicles()
        {
            vehicles a = new vehicles();
            a.name = "vidhya";
            a.number = "TN235467";
            return a;

        }
        public vehiclesinfo()
        {
            var v = getvehicles();
            vp = new vehiclereport(v);        
        }
        public vehiclesinfo(string name)
        {
           //vp.name = name;
        }
        public void getinsurename()
        {
            var p = vp.getinsurancenumber();
            Console.WriteLine(p.name+p.number);

        }
        class vehiclereport
        {
            public vehicles v;

            public vehiclereport(vehicles v)
            {
                this.v = v;
            }
            public vehicles getinsurancenumber()
            {
                return v;
            }
        }
    }       
}
*/