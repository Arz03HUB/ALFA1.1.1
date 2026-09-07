using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramacionII.Guia04
{
    public class Ej09_EST10
    {
        public static void Main(string[] args)
        {
            double maximo = 0;
            double minimo = 0;
            int lotemax = 0;
            int lotemin = 0;
            int lote;

            for (lote = 1; lote <= 5; lote++)
            {
                Console.WriteLine("Ingresa el peso del lote N°: "+ lote);
                double tonelada = double.Parse(Console.ReadLine());

                if (lote == 1)
                {
                    maximo = tonelada;
                    minimo = tonelada;
                    lotemax = lote;
                    lotemin = lote;
                }
                if(tonelada > maximo)
                {
                    maximo = tonelada;
                    lotemax = lote;
                }    
                if (tonelada < minimo)
                {
                    minimo = tonelada;
                    lotemin = lote;
                }
            }
            Console.WriteLine("El lote con mayor peso es el N°: " + lotemax + " con un peso de: " + maximo);
            Console.WriteLine("El lote con menor peso es el N°: " + lotemin + " con un peso de: " + minimo);
        }
        
    }
}
