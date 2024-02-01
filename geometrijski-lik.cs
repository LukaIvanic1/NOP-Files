using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometrija
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trokut trokut1 = new Trokut();
            trokut1.UcitajStranice();
            Console.WriteLine($"Opseg trokuta: {trokut1.Opseg()}");

            Trokut trokut2 = new Trokut();
            trokut2.UcitajStranice();
            Console.WriteLine($"Opseg trokuta: {trokut2.Opseg()}");

            Cetverokut cetverokut = new Cetverokut();
            cetverokut.UcitajStranice();
            Console.WriteLine($"Opseg četverokuta: {cetverokut.Opseg()}");

            Console.ReadKey();
        }
    }

    class GeometrijskiLik
    {
        int BrojStranica;

        public GeometrijskiLik(int brojStranica)
        {
            BrojStranica = brojStranica;
        }

        double[] Stranice = new double[10];

        public void UcitajStranice()
        {
            
            for(int i = 0; i < BrojStranica; i++)
            {
                Stranice[i] = Int32.Parse(Console.ReadLine());
            }
        }
        public double Opseg()
        {
            double sum = 0;
            for(int i = 0; i < Stranice.Length; i++)
            {
                sum += Stranice[i];
            }
            return sum;
        }

    }

    class Trokut : GeometrijskiLik
    {
        public Trokut() : base(3)
        {
        }
    }

    class Cetverokut : GeometrijskiLik
    {
        public Cetverokut() : base(4)
        {
        }
    }






}
