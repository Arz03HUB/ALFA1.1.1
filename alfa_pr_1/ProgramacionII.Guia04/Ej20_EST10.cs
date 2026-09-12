using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramacionII.Guia04
{

    public class Ej20_EST10
    {
        public static void Main(string[] args)
        {
            const int CAMIONES = 3;
            const int MINIMO = 1;
            const int MAXIMO = 60;
            const int ENTREGA = 18;
            const int ALTA = 40;
            const int MEDIA = 20;

            int opcion;
            int total = 0;
            int cantidad = 0;

                do
                {
                    Console.WriteLine("======== EMSA ======");
                    Console.WriteLine("1) Carga de camiones");
                    Console.WriteLine("2) Reporte de clasificación");
                    Console.WriteLine("3) Simulación de cobertura");
                    Console.WriteLine("4) Salir");
                    Console.Write("Elija una opción: ");

                    opcion = int.Parse(Console.ReadLine());

                    if (opcion == 1)
                    {
                        total = 0;
                        cantidad = 0;

                        for (int i = 1; i <= CAMIONES; i++)
                        {
                            int toneladas;

                            do
                            {
                                Console.Write("Ingrese toneladas del camión " + i + ": ");
                                toneladas = int.Parse(Console.ReadLine());

                                if (toneladas < MINIMO || toneladas > MAXIMO)
                                {
                                    Console.WriteLine("Valor inválido. Debe estar entre 1 y 60.");
                                }

                            } while (toneladas < MINIMO || toneladas > MAXIMO);

                            total = total + toneladas;
                            cantidad++;
                        }

                        Console.WriteLine("Datos cargados correctamente.");
                    }
                    else if (opcion == 2)
                    {
                        if (cantidad == 0)
                        {
                            Console.WriteLine("Primero debe cargar los camiones.");
                        }
                        else
                        {
                            double promedio = (double)total / cantidad;

                            Console.WriteLine("Promedio: " + promedio);

                            if (promedio >= ALTA)
                            {
                                Console.WriteLine("RECOLECCION ALTA");
                            }
                            else if (promedio >= MEDIA)
                            {
                                Console.WriteLine("RECOLECCION MEDIA");
                            }
                            else
                            {
                                Console.WriteLine("RECOLECCION BAJA");
                            }
                        }
                    }
                    else if (opcion == 3)
                    {
                        if (cantidad == 0)
                        {
                            Console.WriteLine("Primero debe cargar los camiones.");
                        }
                        else
                        {
                            int restante = total;
                            int jornadas = 0;

                            while (restante >= ENTREGA)
                            {
                                restante = restante - ENTREGA;
                                jornadas++;
                            }

                            Console.WriteLine("Jornadas cubiertas: " + jornadas);
                        }
                    }
                    else if (opcion == 4)
                    {
                        Console.WriteLine("Resumen de la sesión.");
                        Console.WriteLine("Total cargado: " + total);
                    }
                    else
                    {
                        Console.WriteLine("Opción no válida.");
                    }

                } while (opcion != 4);
            }
        }
    }

