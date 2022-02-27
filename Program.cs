using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljeđivanje
{
    class Biljka { }

    class Stablo : Biljka
    {
        bool opadajuListovi;

        public Stablo(bool opadajuListovi)
        {
            this.opadajuListovi = opadajuListovi;
        }

        public bool OpadajuListovi { get => opadajuListovi; set => opadajuListovi = value; }
    }

    class Cvijet : Biljka { }

    class Bijelogoricno : Stablo
    {
        public Bijelogoricno(bool opadajuListovi = true) : base(opadajuListovi) { }
    }

    class Crnogoricno : Stablo
    {
        public Crnogoricno(bool opadajuListovi = false) : base(opadajuListovi) { }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bijelogoricno hrast = new Bijelogoricno();
            Crnogoricno bor = new Crnogoricno();

            Console.WriteLine("Hrast : " + hrast.OpadajuListovi);
            Console.WriteLine("Bor : " + bor.OpadajuListovi);

            Console.ReadKey();
        }
    }
}
