using System;
using System.Collections.Generic;
using System.Text;

namespace EJERCICIOS_EXTENSOS.EJ11_EJ20
{
    public class EJ11_EST02
    {
        public static void Main(string[] args)
        {
            const int SALIR = 3;
            int op, urgentes = 0;

            do
            {
                Console.Write("\n1) Registrar vuelo 2) Consultar meta 3) Salir: ");
                op = int.Parse(Console.ReadLine());

                if (op == 1)
                {
                    Console.Write("Zona (1 Norte, 2 Sur): ");
                    int zona = int.Parse(Console.ReadLine());
                    Console.Write("Urgente (1 Sí, 2 No): ");
                    int urg = int.Parse(Console.ReadLine());

                    if (zona == 1)
                    {
                        if (urg == 1) { Console.WriteLine("Norte - Urgente"); urgentes++; }
                        else Console.WriteLine("Norte - Normal");
                    }
                    else if (zona == 2)
                    {
                        if (urg == 1) { Console.WriteLine("Sur - Urgente"); urgentes++; }
                        else Console.WriteLine("Sur - Normal");
                    }
                }
                else if (op == 2) Console.WriteLine("Meta: 50 misiones.");
                else if (op != SALIR) Console.WriteLine("Opción inválida.");
            } while (op != SALIR);

            Console.WriteLine($"Total urgentes: {urgentes}");
            Console.ReadKey();
        }
    }
}