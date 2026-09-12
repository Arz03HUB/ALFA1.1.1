using System;

namespace EJERCICIOS_EXTENSOS.EJ01_EJ10
{
    public class EJ01_EST02
    {
        public static void Main(string[] args)
        {
            const int total_operaciones = 5;
            int operacionActual = 1;
            Console.WriteLine(" registro de cambios");
            while (operacionActual <= total_operaciones)
            {
                Console.WriteLine($"operaciones de cambio {operacionActual}");
                operacionActual++;
            }
            Console.WriteLine($"total de operaciones procesados: {total_operaciones}");
            Console.ReadLine();

        }    
    }
}
