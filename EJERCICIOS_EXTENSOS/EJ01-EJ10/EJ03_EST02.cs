using System;
using System.Collections.Generic;
using System.Text;

namespace EJERCICIOS_EXTENSOS.EJ01_EJ10
{
    public class EJ03_EST02
    {
        public static void Main(string[] args)
        {
            const int LIMITE_MINIMO = 0;
            const int LIMITE_MAXIMO = 24;

            int horas;

            Console.WriteLine("=== SISTEMA DE REGISTRO DE HORAS DE AGUA (EPSAS) ===\n");

            do
            {
                Console.Write($"Ingrese las horas de servicio de agua al día ({LIMITE_MINIMO} a {LIMITE_MAXIMO}): ");
                horas = int.Parse(Console.ReadLine());

                if (horas < LIMITE_MINIMO || horas > LIMITE_MAXIMO)
                {
                    Console.WriteLine($"[ERROR]: Dato inválido. Debe ingresar un valor entre {LIMITE_MINIMO} y {LIMITE_MAXIMO} horas. Intente nuevamente.\n");
                }

            } while (horas < LIMITE_MINIMO || horas > LIMITE_MAXIMO);

            Console.WriteLine($"\nDato validado con éxito. Horas registradas: {horas} horas.");

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}