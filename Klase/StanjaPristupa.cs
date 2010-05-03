using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klase
{
    public abstract class StanjaPristupa
    {
        private string _stanje;
        
        public StanjaPristupa(string stanje) 
        {
            this._stanje = stanje;
        }

        public static StanjaPristupa POSLAT = new SPPoslat();
        public static StanjaPristupa DOBIJEN = new SPDobijen();
        public static StanjaPristupa PRIHVACEN = new SPPrihvacen();
        public static StanjaPristupa NEPRIHVACEN = new SPNeprihvacen();
    }
}
