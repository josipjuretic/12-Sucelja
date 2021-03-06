using System;
using System.Collections.Generic;

namespace Vsite.CSharp
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Osoba> popisOsoba = new List<Osoba>();

            popisOsoba.Add(new Osoba("Ana", new DateTime(1975, 7, 12)));
            popisOsoba.Add(new Osoba("�arko", new DateTime(1965, 12, 4)));
            popisOsoba.Add(new Osoba("Marko", new DateTime(1983, 4, 2)));

            Console.WriteLine("Ispis prije sortiranja:");
            Ispi�i(popisOsoba);
            Console.WriteLine();

            Console.WriteLine("Sortiramo po ne�emu:");
            popisOsoba.Sort();
            Ispi�i(popisOsoba);
            Console.WriteLine();

            Console.WriteLine("Sortiramo po imenu:");
            // List<T>.Sort(IComparer<T>)
            popisOsoba.Sort(new UsporedbaPoImenu());
            Ispi�i(popisOsoba);

            Console.WriteLine();

            Console.WriteLine("Sortiramo po datumu rodjenja:");
            popisOsoba.Sort((Osoba a, Osoba b) =>
            {
                return a.DatumRodjenja.CompareTo(b.DatumRodjenja);
            }
            );
            Ispi�i(popisOsoba);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();

            Console.WriteLine("Sortiramo po prezimenu:");
            popisOsoba.Sort((Osoba a, Osoba b) =>
            {
                int rezuktat = a.prezime.CompareTo(b.prezime);
                if (rezultat != 0)
                    return rezultat;

            }
   );
            Ispi�i(popisOsoba);

            Console.WriteLine();

        }

        static void Ispi�i(List<Osoba> list)
        {
            foreach (Osoba o in list)
            {
                Console.WriteLine("{0}, {1:d}", o.Ime, o.DatumRodjenja);
            }
        }
    }
}
