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
        
        public void zahtevDobijen(Administrator admin, DozvolaPristupa dozvola)
        {
            if (dozvola.Stanje != POSLAT)
                return;
            dozvola.biceOdlucenoOd(admin);
            dozvola.Stanje = StanjaPristupa.DOBIJEN;
        }


        public void zahtevNijePrihvacen(Administrator admin, DozvolaPristupa dozvola)
        {
            if (dozvola.Stanje != DOBIJEN)
                return;
            if (dozvola.Admin != admin)
                return;
            dozvola.Stanje = NEPRIHVACEN;
            dozvola.JeDozvoljeno = false;
            dozvola.obavestiKorisnikaORezultatuZahteva();
        }

        public void zahtevPrihvacen(Administrator admin, DozvolaPristupa dozvola)
        {
            if (dozvola.Stanje != DOBIJEN)
                return;
            if (dozvola.Admin != admin)
                return;
            dozvola.Stanje = PRIHVACEN;
            dozvola.JeDozvoljeno = true;
            dozvola.obavestiKorisnikaORezultatuZahteva();
        }
    }
}
