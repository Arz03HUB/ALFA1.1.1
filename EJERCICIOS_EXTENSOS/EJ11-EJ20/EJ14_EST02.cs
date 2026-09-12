using System;
using System.Collections.Generic;
using System.Text;

namespace EJERCICIOS_EXTENSOS.EJ11_EJ20
{
    public class EJ14_EST02
    {
        public static void Main(string[] args)
        {
            const int ZONAS = 4, DIAS = 3, UMBRAL = 180;
            int total = 0;

            for (int z = 1; z <= ZONAS; z++)
            {
                int subtotal = 0;
                for (int d = 1; d <= DIAS; d++)
                {
                    Console.Write($"Zona {z} Día {d} usuarios: ");
                    subtotal += int.Parse(Console.ReadLine());
                }
                total += subtotal;

                if (subtotal >= UMBRAL) Console.WriteLine($"-> Zona {z}: {subtotal} (USO ALTO)\n");
                else Console.WriteLine($"-> Zona {z}: {subtotal} (USO BAJO)\n");
            }
            Console.WriteLine($"Total general: {total} usuarios.");
            Console.ReadKey();
        }
    }
}
