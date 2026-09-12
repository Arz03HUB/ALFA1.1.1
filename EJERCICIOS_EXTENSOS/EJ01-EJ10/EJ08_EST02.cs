using System;
using System.Collections.Generic;
using System.Text;

namespace EJERCICIOS_EXTENSOS.EJ01_EJ10
{
    public class EJ08_EST02
    {
        public static void Main(string[] args)
        {
            const int TOTAL_TRAMOS = 7;

            int contadorTramo = 1;
            int tramosPares = 0;
            int tramosImpares = 0;

            Console.WriteLine("=== ASIGNACIÓN DE TURNOS DE INSPECCIÓN (ABC - LA PAZ A ORURO) ===\n");

            while (contadorTramo <= TOTAL_TRAMOS)
            {
                if (contadorTramo % 2 == 0)
                {
                    Console.WriteLine($"Tramo #{contadorTramo} -> Turno MAÑANA (Par)");
                    tramosPares++;
                }
                else
                {
                    Console.WriteLine($"Tramo #{contadorTramo} -> Turno TARDE (Impar)");
                    tramosImpares++;
                }

                contadorTramo++;
            }

            Console.WriteLine("\n=========================================");
            Console.WriteLine("RESUMEN DE INSPECCIÓN:");
            Console.WriteLine($"Tramos asignados al turno Mañana (Pares): {tramosPares}");
            Console.WriteLine($"Tramos asignados al turno Tarde (Impares): {tramosImpares}");
            Console.WriteLine($"Total tramos inspeccionados: {tramosPares + tramosImpares}");
            Console.WriteLine("=========================================");

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
