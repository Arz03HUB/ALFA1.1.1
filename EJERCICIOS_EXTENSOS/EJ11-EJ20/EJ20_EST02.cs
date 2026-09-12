using System;
using System.Collections.Generic;
using System.Text;

namespace EJERCICIOS_EXTENSOS.EJ11_EJ20
{
    public class EJ20_EST02
    {
        public static void Main(string[] args)
        {
            const int SURTIDORES = 4;
            const double LIMITE_MIN_LITROS = 100.0;
            const double LIMITE_MAX_LITROS = 20000.0;
            const double ENTREGA_CISTERNA = 8000.0;
            const double UMBRAL_ABASTECIDO = 12000.0;
            const double UMBRAL_PARCIAL = 6000.0;
            const int OPCION_SALIR = 4;

            double totalDespachado = 0.0;
            bool hayDatosCargados = false;
            int opcionMenu;

            do
            {
                Console.WriteLine("\n=== SISTEMA DE MONITOREO DE COMBUSTIBLE (ANH) ===");
                Console.WriteLine("1) Carga de surtidores");
                Console.WriteLine("2) Reporte de clasificación");
                Console.WriteLine("3) Simulación de cobertura");
                Console.WriteLine("4) Salir");
                Console.Write("Seleccione una opción: ");
                opcionMenu = int.Parse(Console.ReadLine());

                if (opcionMenu == 1)
                {
                    totalDespachado = 0.0;
                    Console.WriteLine("\n--- INGRESO DE DESPACHO POR SURTIDOR ---");

                    for (int i = 1; i <= SURTIDORES; i++)
                    {
                        double litros;
                        do
                        {
                            Console.Write($"Ingrese litros despachados en Surtidor #{i} ({LIMITE_MIN_LITROS} - {LIMITE_MAX_LITROS}): ");
                            litros = double.Parse(Console.ReadLine());

                            if (litros < LIMITE_MIN_LITROS || litros > LIMITE_MAX_LITROS)
                            {
                                Console.WriteLine($"  [ERROR]: Valor fuera de rango legal. Intente nuevamente.");
                            }
                        } while (litros < LIMITE_MIN_LITROS || litros > LIMITE_MAX_LITROS);

                        totalDespachado += litros;
                    }

                    hayDatosCargados = true;
                    Console.WriteLine($"\nCarga exitosa. Total acumulado: {totalDespachado:F2} litros.");
                }
                else if (opcionMenu == 2)
                {
                    if (hayDatosCargados)
                    {
                        double promedio = totalDespachado / SURTIDORES;
                        Console.WriteLine($"\nPromedio por surtidor: {promedio:F2} litros.");

                        if (promedio >= UMBRAL_ABASTECIDO)
                        {
                            Console.WriteLine("Clasificación: ABASTECIDO");
                        }
                        else if (promedio >= UMBRAL_PARCIAL)
                        {
                            Console.WriteLine("Clasificación: PARCIAL");
                        }
                        else
                        {
                            Console.WriteLine("Clasificación: DESABASTECIDO");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n[ADVERTENCIA]: Primero debe registrar los datos en la Opción 1.");
                    }
                }
                else if (opcionMenu == 3)
                {
                    if (hayDatosCargados)
                    {
                        double reserva = totalDespachado;
                        int jornadasCubiertas = 0;

                        while (reserva >= ENTREGA_CISTERNA)
                        {
                            reserva -= ENTREGA_CISTERNA;
                            jornadasCubiertas++;
                        }

                        Console.WriteLine($"\n--- SIMULACIÓN DE COBERTURA (8000 L / JORNADA) ---");
                        Console.WriteLine($"El total despachado logra cubrir: {jornadasCubiertas} jornadas completas de cisterna.");
                        Console.WriteLine($"Combustible remanente: {reserva:F2} litros.");
                    }
                    else
                    {
                        Console.WriteLine("\n[ADVERTENCIA]: Primero debe registrar los datos en la Opción 1.");
                    }
                }
                else if (opcionMenu == OPCION_SALIR)
                {
                    Console.WriteLine("\n=========================================");
                    Console.WriteLine("RESUMEN DE CIERRE DE SESIÓN (ANH):");
                    Console.WriteLine($"Total final procesado en sesión: {totalDespachado:F2} litros.");
                    Console.WriteLine("=========================================");
                }
                else
                {
                    Console.WriteLine("\n[ERROR]: Opción inválida. Ingrese un valor del 1 al 4.");
                }

            } while (opcionMenu != OPCION_SALIR);

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
