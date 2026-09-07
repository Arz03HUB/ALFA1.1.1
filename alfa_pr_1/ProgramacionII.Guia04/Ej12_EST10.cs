using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramacionII.Guia04
{
    public class Ej12_EST10
    {
        public static void Main(string[] args)
        {
            int confirmado = 0;
            int pendiente = 0;
            int doc;

            for(doc = 1; doc <= 5; doc++)
            {
                Console.WriteLine("Que valor tiene el documento digitalizado N°: " + doc);
                int valor = int.Parse(Console.ReadLine());

                if (valor >= 300)
                {
                    Console.WriteLine("Este documento fue verificado? ");
                    Console.WriteLine("===============================");
                    Console.WriteLine("      1. Si ");
                    Console.WriteLine("      2. No ");
                    Console.WriteLine("===============================");
                    int opcion = int.Parse(Console.ReadLine());

                    if (opcion == 1)
                    {
                        Console.WriteLine("AVANCE ALTO CONFIRMADO");
                        confirmado++;
                    }
                    else
                    {
                        Console.WriteLine("AVANCE ALTO PENDIENTE DE VERIFICACION");
                        pendiente++;
                    }

                }
                else if (valor < 300 && valor >= 120)
                {
                    Console.WriteLine("AVANCE MEDIO");
                }
                else
                {
                    Console.WriteLine("AVANCE BAJO");
                }
            }
            Console.WriteLine("Los documentos confirmados son: " + confirmado);
            Console.WriteLine("Los documentos pendientes son: " + pendiente);

        }
    }
}
