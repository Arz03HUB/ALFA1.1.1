using System;
using System.Collections.Generic;
using System.Text;

namespace EJERCICIOS_EXTENSOS.EJ11_EJ20
{
    public class EJ16_EST02
    {
        public static void Main(string[] args)
        {
            const int TOTAL = 5;
            double totalInc = 0;
            int obs = 0;

            for (int i = 1; i <= TOTAL; i++)
            {
                Console.Write($"Actas archivero {i}: ");
                double v = double.Parse(Console.ReadLine());

                if (v >= 120) totalInc += v * 0.20;
                else if (v >= 50) totalInc += v * 0.10;
                else { Console.WriteLine("Observado (sin incentivo)."); obs++; }
            }
            Console.WriteLine($"\nIncentivo total: {totalInc:F2} Bs. | Observaciones: {obs}");
            Console.ReadKey();
        }
    }
}
