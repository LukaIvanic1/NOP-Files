using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacic
{
    class Biljka
    {
    }



    class Stablo : Biljka
    {
        bool otpadajuListovi;
        
        
        public bool OtpadajuListovi    { get => otpadajuListovi; set => otpadajuListovi = value; }
        public Stablo(bool otpadajuListovi)
        {
            
            
            OtpadajuListovi = otpadajuListovi;
        }
    }

    class Cvijet : Biljka
    {
    }

    class Crnogoricno : Stablo
    {
        public Crnogoricno() :base(true)
        {
            
        }
    }

    class Bjelogoricno : Stablo
    {
        public Bjelogoricno() : base(false)
        {
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bjelogoricno Hrast = new Bjelogoricno();
            Crnogoricno Bor = new Crnogoricno();
            
            Console.Write($"Hrast: {Hrast.OtpadajuListovi}\nBor: {Bor.OtpadajuListovi}");

            
            Console.ReadKey();
        }
    }
}