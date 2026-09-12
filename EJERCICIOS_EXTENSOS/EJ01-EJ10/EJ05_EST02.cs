using System;
using System.Collections.Generic;
using System.Text;

namespace EJERCICIOS_EXTENSOS.EJ01_EJ10
{
    public class EJ05_EST02
    {
        public static void Main(string[] args)
        {
            const int TOTAL_PANADERIAS = 7;
            const int UMBRAL_PRODUCCION = 2500;

            int contadorCumplen = 0;
            int contadorNoCumplen = 0;

            Console.WriteLine("=== SEGUIMIENTO DE PRODUCCIÓN DE PAN DE BATALLA (EMAPA) ===\n");

            for (int i = 1; i <= TOTAL_PANADERIAS; i++)
            {
                Console.Write($"Ingrese la producción de la panadería #{i} (unidades): ");
                int produccion = int.Parse(Console.ReadLine());

                if (produccion >= UMBRAL_PRODUCCION)
                {
                    Console.WriteLine("-> Estado: CUMPLE");
                    contadorCumplen++;
                }
                else
                {
                    Console.WriteLine("-> Estado: NO CUMPLE");
                    contadorNoCumplen++;
                }
            }

            Console.WriteLine("\n=========================================");
            Console.WriteLine("RESUMEN DE PRODUCCIÓN:");
            Console.WriteLine($"Panaderías que CUMPLEN el umbral: {contadorCumplen}");
            Console.WriteLine($"Panaderías que NO CUMPLEN el umbral: {contadorNoCumplen}");
            Console.WriteLine("=========================================");

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}