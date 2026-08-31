using System;
using System.Collections.Generic;
using System.Text;

namespace alfa_pr_1.clase04
{
    public class while_ciclo
    {
        public static void Main(string[] args)
        {
            int contador = 1;

            while (contador <= 5)
            {
                Console.WriteLine("Vuelta numero " + contador);
                contador++;
            }

            Console.WriteLine("Fin del bucle while");
        } // Cierra Main
    } // Cierra class @while
} // Cierra namespace
