using progJezZad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progJezZad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Proceduralni x = new Proceduralni();
            Objektni y = new Objektni();
            Funkcionalni z = new Funkcionalni();

            Console.Write("unesi postotak za Proceduralni jezik: ");
            x.Postotak = double.Parse(Console.ReadLine());

            Console.Write("unesi postotak za Objektni jezik: ");
            y.Postotak = double.Parse(Console.ReadLine());

            Console.Write("unesi postotak za Funkcionalni jezik: ");
            z.Postotak = double.Parse(Console.ReadLine());

            double zbrojPostotaka = x.Postotak + y.Postotak + z.Postotak;

            if (zbrojPostotaka != 100)
            {
                Console.WriteLine("loš unos podataka. zbroj postotaka mora biti 100");
            }
            else
            {
                Console.WriteLine("zbroj postotaka je 100");

                if (x.Postotak > y.Postotak && x.Postotak > z.Postotak)
                    Console.WriteLine("proceduralni jezik je najzastupljeniji");
                else if (y.Postotak > x.Postotak && y.Postotak > z.Postotak)
                    Console.WriteLine("objektni jezik je najzastupljeniji");
                else
                    Console.WriteLine("funkcionalni jezik je najzastupljeniji");

            }
            Console.ReadKey();
        }
    }
    class ProgramskiJezik
    {
        protected double postotak;
        public double Postotak { 
            get { return postotak; }
            set { postotak = value; }
        }
        }

    class Proceduralni : ProgramskiJezik
    {

    }
    class Objektni : ProgramskiJezik
    {

    }
    class Funkcionalni : ProgramskiJezik
    {

    }
}

