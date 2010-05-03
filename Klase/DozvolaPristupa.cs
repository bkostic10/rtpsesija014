using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klase
{
    public class DozvolaPristupa
    {
        private Sistem _sistem;
        private Korisnik _korisnik;
        private Administrator _admin;
        private bool _jeDozvoljeno;

        private StanjaPristupa _stanje;

        public DozvolaPristupa(Korisnik korisnik, Sistem sistem)
        {
            this._korisnik = korisnik;
            this._sistem = sistem;
            _stanje = StanjaPristupa.POSLAT;
            _jeDozvoljeno = false;
            obavestiAdminaOZahtevu();
        }

        public void zahtevDobijen(Administrator admin)
        {
            if (_stanje != StanjaPristupa.POSLAT)
                return;
            biceOdlucenoOd(admin);
            _stanje = StanjaPristupa.DOBIJEN;
        }


        public void zahtevNijePrihvacen(Administrator admin)
        {
            if (_stanje != StanjaPristupa.DOBIJEN)
                return;
            if (_admin != admin)
                return;
            _stanje = StanjaPristupa.NEPRIHVACEN;
            _jeDozvoljeno = false;
            obavestiKorisnikaORezultatuZahteva();
        }

        public void zahtevPrihvacen(Administrator admin)
        {
            if (_stanje != StanjaPristupa.DOBIJEN)
                return;
            if (_admin != admin)
                return;
            _stanje = StanjaPristupa.PRIHVACEN;
            _jeDozvoljeno = true;
            obavestiKorisnikaORezultatuZahteva();
        }
        public void biceOdlucenoOd(Administrator admin)
        {
            this._admin = admin;
        }
        public void obavestiAdminaOZahtevu()
        {
            if (_jeDozvoljeno)
            {
                Console.WriteLine("Korisnik trazi pristup (pristup dozvoljen)");
            }
            else
            {
                Console.WriteLine("Korisnik trazi pristup (pristup nije dozvoljen)");
            }
        }
        public void obavestiKorisnikaORezultatuZahteva()
        {
            if (_jeDozvoljeno)
            {
                Console.WriteLine("Admin dozvoljava pristup");
            }
            else
            {
                Console.WriteLine("Admin ne dozvoljava pristup");
            }
        }

    }
}
