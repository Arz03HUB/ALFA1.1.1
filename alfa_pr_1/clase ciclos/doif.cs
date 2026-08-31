using System;
using System.Collections.Generic;
using System.Text;

namespace alfa_pr_1.clase_ciclos
{
    public class doif
    {
        public static void Main(string[] arg)
        {
            int opcion;

            do
            {
                Console.WriteLine("1: Inicio");
                Console.WriteLine("2: Game over");
                Console.Write("Opcion: ");
                opcion = int.Parse(Console.ReadLine());
            }
            while (opcion != 2);
            Console.WriteLine("Fin del juego");
        }
    }
}
