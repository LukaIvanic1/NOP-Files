using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList jao = new ArrayList();
            jao.Add(1);
            jao.Add("string");
            jao.Add('a');
            jao.Add(10.31);

            

            foreach (var item in jao)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        
        }
    }
}
