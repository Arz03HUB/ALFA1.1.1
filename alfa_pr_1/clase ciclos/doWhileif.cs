using System;
using System.Collections.Generic;
using System.Text;

namespace alfa_pr_1.clase_ciclos
{
    public class doWhileif
    {
        public static void Main(string[] args)
        {
            int edad;

            do
            {
                Console.Write("Ingrese su edad (1 a 120): ");
                edad = int.Parse(Console.ReadLine());

                if (edad < 1 || edad > 120)
                {
                    Console.WriteLine("Edad invalida. Intente de nuevo.");
                }
            }
            while (edad >= 1 || edad >= 120);

            Console.WriteLine("Edad registrada: " + edad);
        }
    }
}
