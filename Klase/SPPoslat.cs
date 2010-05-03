using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klase
{
    public class SPPoslat : StanjaPristupa
    {
        public SPPoslat() : base("POSLAT") { }
        
        public override void zahtevDobijen(Administrator admin, DozvolaPristupa dozvola)
        {
            dozvola.biceOdlucenoOd(admin);
            dozvola.Stanje = DOBIJEN;
        }
    }
}
