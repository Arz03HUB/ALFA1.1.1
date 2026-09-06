using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ProgramacionII.Guia04
{
    public class Ej01_EST10
    {
        public static void Main(string[] args)
        {
            const int TotalMuestreo = 7;

            int puntos = 1;           // inicializacion

            while (puntos <= 7)        // condicion 
            {
                Console.WriteLine("Punto de muestreo N°: " + puntos);
                puntos++;     // actulizacion 
            }
        }
    }
}
