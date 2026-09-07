using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace ProgramacionII.Guia04
{
    public class Ej02_EST10
    {
        public static void Main(string[] args)
        {
            int mediciones = 1;
            double suma = 0;
            const int meta = 150;

            while (mediciones <= 9)
            {
                Console.WriteLine("Ingrese la medicion N°: " + mediciones);
                double medida = double.Parse(Console.ReadLine());

                suma = suma + medida;
                mediciones++;

            }
            if (suma >= meta)
            {
                Console.WriteLine("La medicion alconzo la meta con: " + suma + " metros");

            }
            else
            {
                Console.WriteLine("No alcanzaste la meta por : "+(meta-suma)+" metros");
            }
        }
    }
}
