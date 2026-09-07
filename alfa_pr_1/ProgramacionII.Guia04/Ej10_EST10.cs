using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramacionII.Guia04
{
    public class Ej10_EST10
    {
        public static void Main(string[] args)
        {
            double suma = 0;
            int comunidades = 1;


            while (comunidades <= 7)
            {
                Console.WriteLine("Ingresa los kilovatios de la comunidad N° " + comunidades);
                double kilovatios = double.Parse(Console.ReadLine());
                suma = suma + kilovatios;
                comunidades++;

            }
            double promedio = (suma / 7);
            if (promedio <= 200)
            {
                Console.WriteLine("La situacion de san matias es aceaptable solo usan " + promedio + " kilovatios en promedio");
            }
            else
            {
                Console.WriteLine("la situacion de san matias requiere intervencion usan " + promedio + " kilovatios en promedio");
            }
        }
    }
}

