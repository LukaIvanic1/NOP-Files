using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nebeska_tijela
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Planet Zemlja = new Planet(1000,2000);
            Satelit Mjesec = new Satelit(100, 200);
        }
    }
    class NebeskoTijelo
    {
        double BrzinaOkoOsi,BrzinaOkoSunca;


    }
    class Planet : NebeskoTijelo
    {
        public Planet(double d1, double d2) {
            double BrzinaOkoOsi = d1;
            double BrzinaOkoSunca = d2;

        }
    }
    class Satelit : NebeskoTijelo
    {
        public Satelit(double d1, double d2)
        {
            double BrzinaOkoOsi = d1;
            double BrzinaOkoSunca = d2;

        }
    }

}
