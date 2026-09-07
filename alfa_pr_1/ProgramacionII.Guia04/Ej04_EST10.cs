using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramacionII.Guia04
{
    public class Ej04_EST10
    {
        public static void Main(string[] args)
        {
            const string opcion1 = "1. Ver el registro de talleres";
            const string opcion2 = "2. Ver la meta de tiempo";
            const string opcion3 = "3. Ver participantes que aprobaron el taller";
            const string opcion4 = "4. Salir";
            int opcion;

            do
            {
                Console.WriteLine("============ MENU ==============");
                Console.WriteLine(opcion1);
                Console.WriteLine(opcion2);
                Console.WriteLine(opcion3);
                Console.WriteLine(opcion4);
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.WriteLine("Los talleres disponibles son: ");
                    Console.WriteLine("==============================");
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("Se alcanzo la meta");
                    Console.WriteLine("==================");
                }
                else if (opcion == 3)
                {
                    Console.WriteLine("Los participantes que aprobaron son 100 personas :");
                    Console.WriteLine("==================================================");
                }
                else if (opcion == 4)
                {
                    Console.WriteLine("saliendo del sistema");
                    Console.WriteLine("====================");
                }
                else
                {
                    Console.WriteLine("opcion invalida");
                }
            }
            while (opcion != 4);
            { }
            }
        }

    }


