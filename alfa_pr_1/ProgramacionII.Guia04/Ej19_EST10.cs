using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramacionII.Guia04
{
    public class Ej19_EST10
    {
        public static void Main(string[] args)
        {
            int recursos = 3;
            int puntos = 0;
            int retirada = 0;

            do
            {
                Console.WriteLine("===========================");
                Console.WriteLine("1. Intervencion masiva ");
                Console.WriteLine("2. Intervencion preveniva");
                Console.WriteLine("3. Retirada");
                Console.WriteLine("===========================");
                int opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {

                    puntos = puntos + 20;
                    recursos--;

                    if (recursos == 1)
                    {
                        Console.WriteLine("te queda un solo recurso");
                    }
                }
                else if (opcion == 2)
                {
                    puntos = puntos + 10;
                   
                }
                else if (opcion == 3)
                {
                    retirada = 1;
                    Console.WriteLine("Te esta retirando del sistema ");
                }
                else
                {
                    Console.WriteLine("opcion invalida");
                }

                Console.WriteLine("Tus puntos acumulados son de:" + puntos);
                Console.WriteLine("tiene " + recursos + " recursos");
            }

            while (recursos > 0 && puntos < 200 && retirada == 0);
            {
                if (puntos >= 120)
                {
                    Console.WriteLine("CONTAMINADO");
                }
                else if (puntos >= 50)
                {
                    Console.WriteLine("EN ALERTA ");
                }
                else 
                {
                    Console.WriteLine("ACEPTABLE");
                }
            }
            }
        }
    }

