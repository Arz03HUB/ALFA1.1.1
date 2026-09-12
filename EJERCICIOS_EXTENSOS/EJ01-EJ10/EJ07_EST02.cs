using System;
using System.Collections.Generic;
using System.Text;

namespace EJERCICIOS_EXTENSOS.EJ01_EJ10
{
    public class EJ07_EST02
    {
        public static void Main(string[] args)
        {
            const int TOTAL_ESQUINAS = 5;
            const int UMBRAL_ACCESIBLE = 25;
            const int UMBRAL_PARCIAL = 12;

            int totalAccesibles = 0;
            int totalParciales = 0;
            int totalNoAccesibles = 0;

            Console.WriteLine("=== SEMÁFORO DE ACCESIBILIDAD (GAMLP - LA PAZ) ===\n");

            for (int i = 1; i <= TOTAL_ESQUINAS; i++)
            {
                Console.Write($"Ingrese la cantidad de rampas en buen estado para la esquina #{i}: ");
                int rampas = int.Parse(Console.ReadLine());

                if (rampas >= UMBRAL_ACCESIBLE)
                {
                    Console.WriteLine("-> Clasificación: ZONA ACCESIBLE\n");
                    totalAccesibles++;
                }
                else if (rampas >= UMBRAL_PARCIAL)
                {
                    Console.WriteLine("-> Clasificación: ACCESIBILIDAD PARCIAL\n");
                    totalParciales++;
                }
                else
                {
                    Console.WriteLine("-> Clasificación: ZONA NO ACCESIBLE\n");
                    totalNoAccesibles++;
                }
            }

            Console.WriteLine("========================================");
            Console.WriteLine("RESUMEN FINAL DE LA EVALUACIÓN:");
            Console.WriteLine($"Esquinas clasificadas como ZONA ACCESIBLE: {totalAccesibles}");
            Console.WriteLine($"Esquinas clasificadas como ACCESIBILIDAD PARCIAL: {totalParciales}");
            Console.WriteLine($"Esquinas clasificadas como ZONA NO ACCESIBLE: {totalNoAccesibles}");
            Console.WriteLine("========================================");

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}