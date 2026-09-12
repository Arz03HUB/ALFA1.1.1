using System;
using System.Collections.Generic;
using System.Text;

namespace EJERCICIOS_EXTENSOS.EJ11_EJ20
{
    public class EJ15_EST02
    {
        public static void Main(string[] args)
        {
            const int CLAVE = 1809;
            int intentos = 4;
            bool ok = false;

            do
            {
                Console.Write("Código: ");
                if (int.Parse(Console.ReadLine()) == CLAVE)
                {
                    ok = true;
                    Console.Write("Nivel (1 Consulta, 2 Edición): ");
                    int niv = int.Parse(Console.ReadLine());
                    if (niv == 1) Console.WriteLine("Modo: Consulta");
                    else Console.WriteLine("Modo: Edición");
                }
                else
                {
                    intentos--;
                    Console.WriteLine($"Incorrecto. Quedan {intentos} intentos.");
                }
            } while (intentos > 0 && !ok);

            if (!ok) Console.WriteLine("Cuenta bloqueada.");
            Console.ReadKey();
        }
    }
}