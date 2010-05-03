using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klase
{
    public class StanjaPristupa
    {
        private string _stanje;
        
        public StanjaPristupa(string stanje) 
        {
            this._stanje = stanje;
        }

        public static StanjaPristupa POSLAT = new StanjaPristupa("POSLAT");
        public static StanjaPristupa DOBIJEN = new StanjaPristupa("DOBIJEN");
        public static StanjaPristupa PRIHVACEN = new StanjaPristupa("PRIHVACEN");
        public static StanjaPristupa NEPRIHVACEN = new StanjaPristupa("NEPRIHVACEN");
        public void aaaa() { }
    }
}
