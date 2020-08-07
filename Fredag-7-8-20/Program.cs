using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Fredag_7_8_20
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn = "Magnus";

            Console.WriteLine("Get mit navn?");
            string svar = Console.ReadLine();

            while (svar != fornavn)
            {
                Console.WriteLine("Forket get igen");
                svar = Console.ReadLine();
            }

            Console.ReadLine();
        }
    }
}