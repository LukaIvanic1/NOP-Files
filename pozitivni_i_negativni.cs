using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cijeli_i_decimalni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pozitivni x = new Pozitivni();
            x.Broj = 100;
            Console.WriteLine($"Apsolutna vrijednost od x: {x.ApsVrijednost()}");

            Negativni y = new Negativni();
            y.Broj = -100;
            Console.WriteLine($"Apsolutna vrijednost od y: {y.ApsVrijednost()}");

            Decimalni z = new Decimalni();
            z.Broj = 100.45;
            Console.WriteLine($"Apsolutna vrijednost od z: {z.ApsVrijednost()}");

            Console.ReadKey();
        }
    }

    class Brojevi
    {
        double broj;

        public double Broj { get => broj; set => broj = value; }

        public virtual double ApsVrijednost()
        {
            return 0;
        }
    }

    class Cijeli : Brojevi
    {
        public override double ApsVrijednost()
        {
            return Math.Abs(Broj);
        }
    }
    class Decimalni : Brojevi
    {
        public override double ApsVrijednost()
        {
            return Math.Abs(Broj);
        }
    }
    class Pozitivni : Cijeli
    {
        public override double ApsVrijednost()
        {
            return Math.Abs(Broj);
        }
    }
    class Negativni : Cijeli
    {
        public override double ApsVrijednost()
        {
            return Math.Abs(Broj);
        }
    }


}