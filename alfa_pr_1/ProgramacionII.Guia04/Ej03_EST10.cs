using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramacionII.Guia04
{
    public class Ej03_EST10
    {
        public static void Main(string[] args)
        {
            const int minimo = 0;
            const int maximo = 120;
            int estudiantes;

            do
            {
                Console.WriteLine("Ingrese el numero de estudiantes que abandonaron la escuela:");
                estudiantes = int.Parse(Console.ReadLine());

                if (estudiantes < minimo || estudiantes > maximo)
                {
                    Console.WriteLine("el dato de estudiantes es invalido ");
                }
            }
            while (estudiantes < minimo || estudiantes > maximo);
              {
                Console.WriteLine("el numero de estudianrtes que abandonaron la escuela es: " + estudiantes);

              }

            
            
         } 
    }
}   