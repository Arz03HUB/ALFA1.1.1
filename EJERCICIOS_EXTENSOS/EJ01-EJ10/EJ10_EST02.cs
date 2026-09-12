using System;
using System.Collections.Generic;
using System.Text;

namespace EJERCICIOS_EXTENSOS.EJ01_EJ10
{
    public class EJ10_EST02
    {
        public static void Main(string[] args)
        {
            const int TOTAL_CONSULTAS = 5;
            const double UMBRAL_DURACION = 20.0;

            int contador = 1;
            double sumaMinutos = 0.0;

            Console.WriteLine("=== MONITOREO DE TELEMEDICINA (APOLO - LA PAZ) ===\n");

            while (contador <= TOTAL_CONSULTAS)
            {
                Console.Write($"Ingrese la duración de la teleconsulta #{contador} (en minutos): ");
                double minutos = double.Parse(Console.ReadLine());

                sumaMinutos += minutos;
                contador++;
            }

            double promedio = sumaMinutos / TOTAL_CONSULTAS;

            Console.WriteLine($"\nDuración promedio registrada: {promedio:F2} minutos.");

            if (promedio >= UMBRAL_DURACION)
            {
                Console.WriteLine("DIAGNÓSTICO: La situación de Apolo es ACEPTABLE.");
            }
            else
            {
                Console.WriteLine("DIAGNÓSTICO: La situación de Apolo REQUIERE INTERVENCIÓN.");
            }

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}