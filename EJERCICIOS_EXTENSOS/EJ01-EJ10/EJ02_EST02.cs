using System;
using System.Collections.Generic;
using System.Text;

namespace EJERCICIOS_EXTENSOS.EJ01_EJ10
{
    public class EJ02_EST02
    {
        public static void Main(string[] args)
        {
            const double Max_hectares = 10000;
            const int focos_totales = 7;

            double suma = 0;
            int contador = 1;
            Console.WriteLine("Registro de hectareas de focos de incendios");

            while (contador <= focos_totales)
            {
                Console.WriteLine($"Ingrese hectareas del foco {contador}:");
                double hectareas = double.Parse(Console.ReadLine());
                suma += hectareas;
                contador++;
            }
            Console.WriteLine($"Total de hectareas afectadas: {suma}");
        }    
    }
}
