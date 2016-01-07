using System;

namespace Vsite.CSharp
{
    struct Duljina : IComparable, IComparable<Duljina>
    {
        private int duljina;

        public Duljina(int duljina)
        {
            this.duljina = duljina;
        }

        public override string ToString()
        {
            return string.Format("{0} m", duljina);
        }
        
        public int CompareTo(Duljina druga)
        {
            return duljina - druga.duljina;
        }

        int IComparable.CompareTo(object obj)
        {
            return duljina - ((Duljina)obj).duljina;
        }
    }
}
