using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramacionII.Guia04
{
public class Ej17_EST10
    {
        public static void Main(string[] argas)
        {
            int cantidad = 0;
            double suma = 0;
            double promedio;

            Console.WriteLine("Ingresa los hitos que hiciste");
            double hito = double.Parse(Console.ReadLine());
            
            while (hito != -1)
            {
                cantidad++;
                suma = suma + hito;

                Console.WriteLine("Ingresa los hitos que hiciste");
                hito = double.Parse(Console.ReadLine());

            }
            if (cantidad == 0)
            {
                Console.WriteLine("Se ingresaron 0 datos");
            }
            else
            {
                promedio = suma / cantidad;

                if (promedio >= 120)
                {
                    Console.WriteLine("Clasificacion: Alta ");
                }
                else if (promedio >= 50)
                {
                    Console.WriteLine("Clasificacion: Media ");
                }
                else
                {
                    Console.WriteLine("Clasificacion: Baja");
                }

                Console.WriteLine("La catidad de veces que se ingreso hitos fue: "+ cantidad);
                Console.WriteLine("La suma de los hitos es: "+ suma);
                Console.WriteLine("El promedio es: "+ promedio);

            }
        }
    }
}
