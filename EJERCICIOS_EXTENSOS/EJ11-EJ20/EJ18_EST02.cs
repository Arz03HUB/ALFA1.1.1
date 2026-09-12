using System;
using System.Collections.Generic;
using System.Text;

namespace EJERCICIOS_EXTENSOS.EJ11_EJ20
{
    public class EJ18_EST02
    {
        public static void Main(string[] args)
        {
            const int ANIO_INICIAL = 1545;
            const int TOTAL_ANIOS = 10;

            int totalPiezas = 0;
            int hitosConmemorados = 0;

            Console.WriteLine("=== LÍNEA DE TIEMPO NUMISMÁTICA (CASA DE LA MONEDA) ===\n");

            for (int serie = 1; serie <= TOTAL_ANIOS; serie++)
            {
                int anioReal = ANIO_INICIAL + (serie - 1);

                Console.Write($"Año {anioReal} (Año #{serie} de la serie) - Piezas registradas: ");
                int piezas = int.Parse(Console.ReadLine());
                totalPiezas += piezas;

                if (serie % 5 == 0)
                {
                    Console.Write($"  -> ¡Año de hito ({anioReal})! ¿Hubo acto conmemorativo? (1 = Sí, 2 = No): ");
                    int acto = int.Parse(Console.ReadLine());

                    if (acto == 1)
                    {
                        Console.WriteLine("     Registro: Hito histórico conmemorado con acto solemne.");
                        hitosConmemorados++;
                    }
                    else
                    {
                        Console.WriteLine("     Registro: Hito histórico sin acto conmemorativo registrado.");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("=========================================");
            Console.WriteLine("BALANCE HISTÓRICO DE LA DÉCADA:");
            Console.WriteLine($"Total piezas numismáticas catalogadas: {totalPiezas}");
            Console.WriteLine($"Total de hitos conmemorados con acto: {hitosConmemorados}");
            Console.WriteLine("=========================================");

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
