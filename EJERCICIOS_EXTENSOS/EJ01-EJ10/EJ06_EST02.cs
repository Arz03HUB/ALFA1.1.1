using System;
using System.Collections.Generic;
using System.Text;

namespace EJERCICIOS_EXTENSOS.EJ01_EJ10
{
    public class EJ06_EST02
    {
        public static void Main(string[] args)
        {
            const int RESERVA_INICIAL = 5000;
            const double LIMITE_ALERTA = RESERVA_INICIAL * 0.20;

            int reservaActual = RESERVA_INICIAL;
            int jornadas = 0;

            Console.WriteLine("=== CONTROL DE DOSIS - SEDES BENI ===");
            Console.WriteLine($"Reserva inicial disponible: {RESERVA_INICIAL} dosis.\n");

            Console.Write("Ingrese la cantidad fija de dosis a entregar por jornada a Trinidad: ");
            int entregaFija = int.Parse(Console.ReadLine());

            while (reservaActual > 0)
            {
                jornadas++;
                reservaActual -= entregaFija;

                if (reservaActual < 0)
                {
                    reservaActual = 0;
                }

                Console.WriteLine($"Jornada N° {jornadas} completada. Quedan: {reservaActual} dosis.");

                if (reservaActual < LIMITE_ALERTA && reservaActual > 0)
                {
                    Console.WriteLine($"  [ALERTA]: La reserva bajó del 20% (quedan menos de {LIMITE_ALERTA} dosis).");
                }
            }

            Console.WriteLine("\nLa reserva se ha agotado por completo.");
            Console.WriteLine($"Total de jornadas que duró la reserva: {jornadas}");

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}