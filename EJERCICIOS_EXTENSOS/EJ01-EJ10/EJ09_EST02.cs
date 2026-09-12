using System;
using System.Collections.Generic;
using System.Text;

namespace EJERCICIOS_EXTENSOS.EJ01_EJ10
{
    public class EJ09_EST02
    {
        public static void Main(string[] args)
        {
            const int TOTAL_HOSPITALES = 9;

            int maximoAtenciones = 0;
            int minimoAtenciones = 0;
            int hospitalMaximo = 1;
            int hospitalMinimo = 1;

            Console.WriteLine("=== REPORTE DE ATENCIONES MÉDICAS (SEDES POTOSÍ) ===\n");

            for (int i = 1; i <= TOTAL_HOSPITALES; i++)
            {
                Console.Write($"Ingrese las atenciones médicas del Hospital #{i}: ");
                int atenciones = int.Parse(Console.ReadLine());

                if (i == 1)
                {
                    maximoAtenciones = atenciones;
                    minimoAtenciones = atenciones;
                    hospitalMaximo = 1;
                    hospitalMinimo = 1;
                }
                else
                {
                    if (atenciones > maximoAtenciones)
                    {
                        maximoAtenciones = atenciones;
                        hospitalMaximo = i;
                    }

                    if (atenciones < minimoAtenciones)
                    {
                        minimoAtenciones = atenciones;
                        hospitalMinimo = i;
                    }
                }
            }

            Console.WriteLine("\n=========================================");
            Console.WriteLine("RESULTADOS DE EXTREMOS REGISTRADOS:");
            Console.WriteLine($"Mayor atención médica: {maximoAtenciones} atenciones (Hospital #{hospitalMaximo})");
            Console.WriteLine($"Menor atención médica: {minimoAtenciones} atenciones (Hospital #{hospitalMinimo})");
            Console.WriteLine("=========================================");

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
