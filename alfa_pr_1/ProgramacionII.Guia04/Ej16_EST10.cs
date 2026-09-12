using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramacionII.Guia04
{
    public class Ej16_EST10
    {
        public static void Main(string[] args)
        {
            double incentivo = 0;
            double totalincentivo = 0;
            int observaciones = 0;
            int test;

            for (test = 1; test <= 7; test++)
            {
                Console.WriteLine("Cuantos testimonios hiciste ");
                int testimonio = int.Parse(Console.ReadLine());

                if (testimonio >= 180)
                {
                    incentivo = testimonio * 0.2;
                    
                }
                else if (testimonio >= 70)
                {
                    incentivo = testimonio * 0.1;
                    
                }
                else
                {
                    observaciones++;
                    
                }

                totalincentivo = totalincentivo + incentivo;
            }

            Console.WriteLine("El total de inecetivos que se dio fue "+ totalincentivo);
            Console.WriteLine("Las obsevaciones que hubo fueron "+observaciones);
        } 

    }
}
