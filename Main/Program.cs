using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Klase;
namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {        
        
            Sistem s1 = new Sistem("Kladionica");
            Korisnik k1 = new Korisnik("Pera Peric");
            Korisnik k2 = new Korisnik("Zile Zivkovic");
            Administrator a = new Administrator("Aca Stojanovic");

            Console.WriteLine("Sistem: {0}", s1.Ime);
            Console.WriteLine("Admin: {0}", a.Ime);
            Console.WriteLine("Korisnik: {0}", k1.Ime);
            DozvolaPristupa doz1 = new DozvolaPristupa(k1, s1);
            doz1.zahtevDobijen(a);
            doz1.zahtevNijePrihvacen(a);

            Console.WriteLine();

            Console.WriteLine("Sistem: {0}", s1.Ime);
            Console.WriteLine("Admin: {0}", a.Ime);
            Console.WriteLine("Korisnik: {0}", k2.Ime);
            DozvolaPristupa doz2 = new DozvolaPristupa(k2, s1);
            doz2.zahtevDobijen(a);
            doz2.zahtevPrihvacen(a);

            Console.ReadLine();
            
        }
    }
}
