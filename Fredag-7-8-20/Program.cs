using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Fredag_7_8_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            // do while loop
            do
            {
                Console.WriteLine("Velg en opgave");
                Console.WriteLine("");

                try
                {
                    i = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                }
                catch (Exception)
                {
                    Console.WriteLine("Det er ikke et acceptabelt svar!");
                    Console.WriteLine("");
                }

                if (i > 1)
                {
                    i = 0;
                    Console.WriteLine("Det er ikke et acceptabelt svar!");
                    Console.WriteLine("");
                }
            }
            while (i == 0);

            // while loop
            while (i == 1)
            {
                string fornavn = "Magnus";

                Console.WriteLine("Get mit navn?");
                Console.WriteLine("");

                string svar = Console.ReadLine();
                Console.WriteLine("");

                while (svar != fornavn)
                {
                    Console.WriteLine("Forket get igen");
                    Console.WriteLine("");

                    svar = Console.ReadLine();
                    Console.WriteLine("");
                }
            }


            Console.WriteLine("Tryk Enter for at Afslutte");
            Console.ReadLine();
        }
    }
}