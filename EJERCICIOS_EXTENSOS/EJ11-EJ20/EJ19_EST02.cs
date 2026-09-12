using System;
using System.Collections.Generic;
using System.Text;

namespace EJERCICIOS_EXTENSOS.EJ11_EJ20
{
    public class EJ19_EST02
    {
        public static void Main(string[] args)
        {
            const int PUNTOS_INTENSIVA = 70;
            const int PUNTOS_PREVENTIVA = 35;
            const int META_PUNTOS = 1800;

            int recursos = 3;
            int puntos = 0;
            int ronda = 0;
            bool seRetiro = false;

            Console.WriteLine("=== SIMULADOR DE CAMPAÑA - DEFENSORÍA DEL PUEBLO (EL ALTO) ===\n");

            do
            {
                ronda++;
                Console.WriteLine($"--- RONDA #{ronda} | Recursos restantes: {recursos} | Puntos actuales: {puntos} ---");
                Console.WriteLine("Estrategias disponibles:");
                Console.WriteLine("1) Intervención intensiva (+70 pts, consume 1 recurso)");
                Console.WriteLine("2) Intervención preventiva (+35 pts, no consume recursos)");
                Console.WriteLine("3) Retirarse");
                Console.Write("Seleccione estrategia: ");
                int estrategia = int.Parse(Console.ReadLine());

                if (estrategia == 1)
                {
                    puntos += PUNTOS_INTENSIVA;
                    recursos--;

                    if (recursos == 1)
                    {
                        Console.WriteLine("  [PRECAUCIÓN]: ¡Solo queda 1 recurso disponible!");
                    }
                }
                else if (estrategia == 2)
                {
                    puntos += PUNTOS_PREVENTIVA;
                }
                else if (estrategia == 3)
                {
                    seRetiro = true;
                    Console.WriteLine("La brigada decidió retirarse de la campaña.");
                }
                else
                {
                    Console.WriteLine("[ERROR]: Estrategia no válida. Se pierde la ronda.");
                }

                Console.WriteLine();

            } while (recursos > 0 && !seRetiro && puntos < META_PUNTOS);

            Console.WriteLine("=========================================");
            Console.WriteLine($"FIN DE LA CAMPAÑA. Puntaje final alcanzado: {puntos}");

            if (puntos >= 1200)
            {
                Console.WriteLine("Clasificación de resultado: REVISIÓN ALTA");
            }
            else if (puntos >= 500)
            {
                Console.WriteLine("Clasificación de resultado: REVISIÓN MEDIA");
            }
            else
            {
                Console.WriteLine("Clasificación de resultado: REVISIÓN BAJA");
            }
            Console.WriteLine("=========================================");

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
