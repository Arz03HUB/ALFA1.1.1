using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Numerics;
using System.Text;

namespace ProgramacionII.Guia04
{
    public class Ej18_EST10
    {
        public static void Main(string[] argas)
        {
            double total = 0;
            int tiempo;
            int año = 0;

            for (año = 2016; año <= 2025; año++)
            {
                Console.WriteLine("Cuantos productos va a registrar");
                double producto = double.Parse(Console.ReadLine());

                total = total + producto;

                if (año % 5 == 0)
                {
                    Console.WriteLine("Hubo algun acto conmemorativo");
                    Console.WriteLine("1. Si");
                    Console.WriteLine("2. No");
                    int opcion = int.Parse(Console.ReadLine());

                    if (opcion == 1)
                    {
                        Console.WriteLine("Se resgistro correctamente ");
                    }
                    else
                    {
                        Console.WriteLine("No se registro correctamente");
                    }

                }
                
            }
            Console.WriteLine("]La suma de los hittos es: " + total);
        }
        



        }
    }

