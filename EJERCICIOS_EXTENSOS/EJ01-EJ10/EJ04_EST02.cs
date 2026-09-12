using System;
using System.Collections.Generic;
using System.Text;

namespace EJERCICIOS_EXTENSOS.EJ01_EJ10
{
    public class EJ04_EST02
    {
        public static void Main(string[] args)
        {
            const string TEXTO_PARCELAS = "Registro actual: 45 parcelas verificadas en la Chiquitania.";
            const string TEXTO_META = "Meta del periodo: 12000 hectáreas fiscalizadas.";
            const string TEXTO_RANGO = "Rango permitido para chaqueos no autorizados: 0 a 5 hectáreas (tolerancia mínima).";
            const int OPCION_SALIDA = 4;

            int opcion;

            do
            {
                Console.WriteLine("\n--- MENÚ DE CONSULTA (ABT) ---");
                Console.WriteLine("1) Ver el registro de parcelas verificadas");
                Console.WriteLine("2) Ver la meta del periodo");
                Console.WriteLine("3) Ver el rango válido de hectáreas desmontadas sin permiso");
                Console.WriteLine("4) Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.WriteLine($"\n[INFO]: {TEXTO_PARCELAS}");
                }
                else if (opcion == 2)
                {
                    Console.WriteLine($"\n[INFO]: {TEXTO_META}");
                }
                else if (opcion == 3)
                {
                    Console.WriteLine($"\n[INFO]: {TEXTO_RANGO}");
                }
                else if (opcion == OPCION_SALIDA)
                {
                    Console.WriteLine("\nSaliendo del sistema de consultas de la ABT...");
                }
                else
                {
                    Console.WriteLine("\n[ERROR]: Opción no existente. Intente nuevamente con las opciones 1, 2, 3 o 4.");
                }

            } while (opcion != OPCION_SALIDA);

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}