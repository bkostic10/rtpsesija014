using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klase
{
    public class SPDobijen : StanjaPristupa
    {
        public SPDobijen() : base("DOBIJEN") { }
        
        public override void zahtevNijePrihvacen(Administrator admin, DozvolaPristupa dozvola)
        {
            if (dozvola.Admin != admin)
                return;
            dozvola.Stanje = NEPRIHVACEN;
            dozvola.JeDozvoljeno = false;
            dozvola.obavestiKorisnikaORezultatuZahteva();
        }

        public override void zahtevPrihvacen(Administrator admin, DozvolaPristupa dozvola)
        {
            if (dozvola.Admin != admin)
                return;
            dozvola.Stanje = PRIHVACEN;
            dozvola.JeDozvoljeno = true;
            dozvola.obavestiKorisnikaORezultatuZahteva();
        }
    }
}
