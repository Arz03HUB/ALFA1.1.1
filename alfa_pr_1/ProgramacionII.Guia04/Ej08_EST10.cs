using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramacionII.Guia04
{
    public class Ej08_EST10
    {
        public static void Main(string[] args)
        {
            int tramite = 1;
            int pares = 0;
            int impares = 0;

            while (tramite <= 9)
            {
                if (tramite % 2 == 0)
                {
                    Console.WriteLine("El tramite N°: "+tramite + " se realizara en la mañana"); 
                    Console.WriteLine("=====================================================");
                    pares++;
                }
                else
                {
                    Console.WriteLine("El tramite N°: " + tramite + " se realizara en la tarde");
                    Console.WriteLine("======================================================");
                    impares++;
                }

                tramite++;
            }
            Console.WriteLine("El numero de tramites que se realizaran en la mañana son: "+ pares);
            Console.WriteLine("El numero de tramites que se realizaran en la tarde son: "+ impares);
            
        }
    }
}
