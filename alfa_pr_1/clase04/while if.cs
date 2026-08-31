using System;

namespace alfa_pr_1.clase04
{
    public class while_if
    {
        public static void Main(string[] args)
        {
            int edad;

            do
            {
                Console.WriteLine("Ingrese su edad: ");
                edad = int.Parse(Console.ReadLine());

                if (edad < 1 || edad > 150)
                {
                    Console.WriteLine("Edad invalida. Intente de nuevo");
                }
                else if (edad >= 18)
                {
                    Console.WriteLine("Usted es mayor de edad.");
                }
                else
                {
                    Console.WriteLine("Usted es menor de edad.");
                }
            } while (edad < 1 || edad > 150);

            // Esta línea ahora está dentro de Main
            Console.WriteLine("edad Registrada: " + edad);
        }
    }
}