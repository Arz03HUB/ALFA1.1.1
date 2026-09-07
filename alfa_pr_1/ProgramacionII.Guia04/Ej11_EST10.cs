using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramacionII.Guia04
{
    public class Ej11_EST10
    {
        public static void Main(string[] args)
        {
            int urgentes = 0;
            int opcion;

            do
            {
                Console.WriteLine("============MENU============");
                Console.WriteLine("  1. Registrar incidente");
                Console.WriteLine("  2. Consultar meta");
                Console.WriteLine("  3. Salir");
                Console.WriteLine("============================");
                Console.WriteLine("Elige una opcion");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.WriteLine("============================");
                    Console.WriteLine("  1. Zona Norte ");
                    Console.WriteLine("  2. Zona Sur");
                    Console.WriteLine("============================");
                    int zona = int.Parse(Console.ReadLine());
                    Console.WriteLine(" ");

                    if (zona == 1 || zona == 2)
                    {
                        Console.WriteLine("El incidente es urgente ?");
                        Console.WriteLine("============================");
                        Console.WriteLine("  1. Si");
                        Console.WriteLine("  2. No");
                        Console.WriteLine("============================");
                        int registrar = int.Parse(Console.ReadLine());
                        Console.WriteLine(" ");

                        if (registrar == 1)
                        {
                            Console.WriteLine("Incidente urgente registrado");
                            urgentes++;
                        }
                        else if (registrar == 2)
                        {
                            Console.WriteLine("El incidente no se registra como urgente");
                        }
                        else
                        {
                            Console.WriteLine("opcion invalida");
                        }
                    }
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("La meta registrada es :");
                }
                else if (opcion == 3)
                {
                    Console.WriteLine("Saliendo del programa");
                }
                else
                {
                    Console.WriteLine("Opcion invalida");
                }
            }
            while (opcion != 3);
            {
                Console.WriteLine("Los incidentes registrados como uregentes son: "+ urgentes );
            }



        }
    }
}
