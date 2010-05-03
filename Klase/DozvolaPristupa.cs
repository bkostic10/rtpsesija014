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

        public StanjaPristupa Stanje
        {
            get { return _stanje; }
            set { _stanje = value; }
        }
        
        public Administrator Admin
        {
            get { return _admin; }
            set { _admin = value; }
        }
        public bool JeDozvoljeno
        {
            get { return _jeDozvoljeno; }
            set { _jeDozvoljeno = value; }
        }

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
            _stanje.zahtevDobijen(admin,this);
        }


        public void zahtevNijePrihvacen(Administrator admin)
        {
            _stanje.zahtevNijePrihvacen(admin, this);
        }

        public void zahtevPrihvacen(Administrator admin)
        {
            _stanje.zahtevPrihvacen(admin,this);
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
