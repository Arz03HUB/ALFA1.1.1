using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ProgramacionII.Guia04
{
    public class Ej14_EST10
    {
        public static void Main(string[] args)
        {
            int total = 0;
            int zona;
            int dia;

            for ( zona = 1; zona <= 3; zona++)
            { 
                int subtotal = 0;

                for ( dia = 1; dia <= 5; dia++)
                {
                    Console.WriteLine("Ingrese los documentos del dia " + dia +" de la zona "+ zona );
                    int documento = int.Parse(Console.ReadLine());

                    subtotal = subtotal + documento;
                }
                Console.WriteLine("El subtotal de la zona " + zona +" es "+ subtotal);

                if (subtotal > 240 )
                {
                    Console.WriteLine("CATALOGACION ALTA");
                }
                else
                {
                    Console.WriteLine("CATALOGACION BAJA");
                }  

                total = total + subtotal;
            }

            Console.WriteLine("Total de calama "+ total );
        }

    }
}
