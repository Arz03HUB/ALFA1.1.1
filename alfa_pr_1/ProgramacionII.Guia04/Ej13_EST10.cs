using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramacionII.Guia04
{
    public class Ej13_EST10
    {
        public static void Main(string[] args)
        {
            
            int suma = 0;
            int periodo = 1;

           

            while(suma <= 1800)
            {
              Console.WriteLine("Cual es el avance de el periodo N°: " + periodo );
              int avance = int.Parse(Console.ReadLine());

                suma = suma + avance;
                periodo++;

                Console.WriteLine("La cantidad que falta es :" + (1800 - avance));

                if (avance == 0)
                 {
                    Console.WriteLine("El periodo fue improductivo");
                 }
                else
                {
                    Console.WriteLine("El periodo fue registrado");
                }
            }
            Console.WriteLine("El total acumulado es:" + suma);
            Console.WriteLine("Se hizo en un total de periodos de: "+ periodo);
            Console.WriteLine("El sobrante de el total que sobrepaso los 1800 es: " + (suma - 1800));
        }
    }
}
