using System;

namespace Vsite.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Duljina d1 = new Duljina(2);
                Duljina d2 = new Duljina(1);

                // Dopuniti strukturu Duljina tako da implementira sučelje IComparable i napisati kod za metodu CompareTo


                // TODO: Dodati naredbu koja će usporediti duljine d1 i d2 te ispisati koja je veća
                if (d1.CompareTo(d2) < 0)
                    Console.WriteLine("d1 je manji od d2");
                if (d1.CompareTo(d2) > 0)
                    Console.WriteLine("d1 je veći od d2");
                else
                     Console.WriteLine("d1 je jednako d2");


                // Dodati naredbu koja će usporediti d1 sa stringom "pero". Provjeriti da li prevoditelj javlja pogrešku te ako nema pogreške, pokrenut program.
                //int a = d1.CompareTo("pero");

                // TODO: Promijeniti implementaciju sučelja IComparable tako da prevoditelj javi pogrešku na usporedbu strukture Duljina i stringa. Provjeriti javlja li prevoditelj pogrešku.


                // TODO: Dopuniti strukturu Duljina tako da implementira i sučelje IComparable<Duljina>. Provjeriti javlja li prevoditelj pogrešku.



            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
