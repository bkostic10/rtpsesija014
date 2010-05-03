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

        private string _stanje;

        public static string POSLAT = "POSLAT";
        public static string DOBIJEN = "DOBIJEN";
        public static string PRIHVACEN = "PRIHVACEN";
        public static string NEPRIHVACEN = "NEPRIHVACEN";

        public DozvolaPristupa(Korisnik korisnik, Sistem sistem)
        {
            this._korisnik = korisnik;
            this._sistem = sistem;
            _stanje = POSLAT;
            _jeDozvoljeno = false;
            obavestiAdminaOZahtevu();
        }

        public void zahtevDobijen(Administrator admin)
        {
            if (_stanje != POSLAT)
                return;
            biceOdlucenoOd(admin);
            _stanje = DOBIJEN;
        }


        public void zahtevNijePrihvacen(Administrator admin)
        {
            if (_stanje != DOBIJEN)
                return;
            if (_admin != admin)
                return;
            _stanje = NEPRIHVACEN;
            _jeDozvoljeno = false;
            obavestiKorisnikaORezultatuZahteva();
        }

        public void zahtevPrihvacen(Administrator admin)
        {
            if (_stanje != DOBIJEN)
                return;
            if (_admin != admin)
                return;
            _stanje = PRIHVACEN;
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
