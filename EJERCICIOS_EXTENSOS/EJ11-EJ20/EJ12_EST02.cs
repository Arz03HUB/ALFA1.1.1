using System;
using System.Collections.Generic;
using System.Text;

namespace EJERCICIOS_EXTENSOS.EJ11_EJ20
{
    public class EJ12_EST02
    {
        public static void Main(string[] args)
        {
            const int TOTAL = 9;
            const double EXCELENTE = 85.0, ACEPTABLE = 65.0;
            int confirmados = 0, pendientes = 0;

            for (int i = 1; i <= TOTAL; i++)
            {
                Console.Write($"Frase {i} (% precisión): ");
                double p = double.Parse(Console.ReadLine());

                if (p >= EXCELENTE)
                {
                    Console.Write("¿Verificado en campo? (1 Sí, 2 No): ");
                    if (int.Parse(Console.ReadLine()) == 1) { Console.WriteLine("EXCELENTE CONFIRMADO"); confirmados++; }
                    else { Console.WriteLine("EXCELENTE PENDIENTE"); pendientes++; }
                }
                else if (p >= ACEPTABLE) Console.WriteLine("PRECISIÓN ACEPTABLE");
                else Console.WriteLine("PRECISIÓN DEFICIENTE");
            }
            Console.WriteLine($"\nConfirmados: {confirmados} | Pendientes: {pendientes}");
            Console.ReadKey();
        }
    }
}
