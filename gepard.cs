using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasljedjivanje1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gepard g = new Gepard();
           // Console.WriteLine(g.Opasna);
            g.Opasnost();
           // Console.WriteLine(g.Opasna);
            Console.ReadKey();

        }
    }
    class Cat
    {
        public bool Opasna { get; set; }
        void Opasnost()
        {
            Opasna = false;
        }
        
    }

    class Gepard : Cat
    {
        public bool Opasna { get; set; }
        public void Opasnost()
        {
            Opasna = true;
        }
    }


}
