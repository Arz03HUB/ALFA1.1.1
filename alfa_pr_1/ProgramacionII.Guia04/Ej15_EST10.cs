using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Xml;

namespace ProgramacionII.Guia04
{
    public class Ej15_EST10
    {
        public static void Main(String[] args)
        {
            int intentos = 0;
            int resta;
            
            
            while (intentos <= 3)
            {
             Console.WriteLine("Ingrese la contraseña");
             int contraseña = int.Parse(Console.ReadLine());

                if (contraseña == 1953)
                {
                    Console.WriteLine("Acceso consedido");
                    Console.WriteLine("1. Consulta");
                    Console.WriteLine("2. Edicion");
                    int opcion = int.Parse(Console.ReadLine());

                    if (opcion == 1)
                    {
                        Console.WriteLine("A accedido a las consultas");
                    }
                    else if (opcion == 2)
                    {
                        Console.WriteLine("A accedido a las ediciones ");
                    }
                    else
                    {
                        Console.WriteLine("No existe esa opcion");
                    }
                    intentos++;
                }
                else
                {
                    intentos++;
                    resta = 4 - intentos;
                 Console.WriteLine("Acceso denegado fallaste " + intentos+ " te quedan "+ resta +" intentos" );
                }
            }

        }
    }
}
