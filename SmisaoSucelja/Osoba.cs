using System;

namespace Vsite.CSharp
{
    class Osoba : IComparable(Osoba)
    {
        public Osoba(string ime, string Prezime, DateTime datumRodjenja)
        {
            Ime = ime;
            Prezime = prezime;
            DatumRodjenja = datumRodjenja;
        }

        public readonly string Ime;
        public readonly string Prezime;
        public readonly DateTime DatumRodjenja;

        #region IComparable(osoba) Members


    }
}
