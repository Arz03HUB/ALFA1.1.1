using System;
using System.Collections.Generic;
using System.Text;

namespace EJERCICIOS_EXTENSOS.EJ11_EJ20
{
    public class EJ17_EST02
    {
        public static void Main(string[] args)
        {
            const int CENTINELA = -1;
            int cant = 0;
            double suma = 0;

            Console.Write($"Expedientes ({CENTINELA} para salir): ");
            int v = int.Parse(Console.ReadLine());

            while (v != CENTINELA)
            {
                suma += v;
                cant++;
                Console.Write($"Expedientes ({CENTINELA} para salir): ");
                v = int.Parse(Console.ReadLine());
            }

            if (cant > 0)
            {
                double prom = suma / cant;
                Console.WriteLine($"Total: {suma} | Promedio: {prom:F2}");
                if (prom >= 350) Console.WriteLine("Clasificación: ALTO");
                else if (prom >= 150) Console.WriteLine("Clasificación: MEDIO");
                else Console.WriteLine("Clasificación: BAJO");
            }
            else Console.WriteLine("No hubo datos ingresados.");
            Console.ReadKey();
        }
    }
}