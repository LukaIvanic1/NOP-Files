using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string korisnickiUnos;
            KlasaB klasica = new KlasaB();
            Console.WriteLine("aj upisi neki string sa onak barem 2 charactera: ");
            korisnickiUnos = Console.ReadLine();
            if (korisnickiUnos.Length >= 2)
            {
                Console.WriteLine(klasica.BezPrvogIZadnjeg(korisnickiUnos));
            }else
            {
                Console.WriteLine("STRING DULJI OD 2!!!");
            }
            Console.ReadKey();

        }


    }
    class KlasaB
    {
       public string BezPrvogIZadnjeg(string znaci)
        {
            string skraceniString = znaci.Remove(znaci.Length-1, 1);
            skraceniString = skraceniString.Remove(0, 1);
            return skraceniString;
        }
    }
}
