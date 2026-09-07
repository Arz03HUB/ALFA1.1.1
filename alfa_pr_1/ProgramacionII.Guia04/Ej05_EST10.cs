using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramacionII.Guia04
{
    public class Ej05_EST10
    {
        public static void Main(string[] args)
        {
            int cumple = 0;
            int sumCumple = 0;
            int NoCumple = 0;
            int sumNo = 0;
            int feria;

            for (feria = 1; feria <= 9; feria++)
            {
                Console.WriteLine("Ingresa cuantos postulantes hubo en la feria  N°: " + feria);
                int postulantes = int.Parse(Console.ReadLine());

                if (postulantes >= 60)
                {
                    sumCumple = sumCumple + postulantes;
                    cumple++;
                    Console.WriteLine("la feria cumple");
                    Console.WriteLine("===============");
                }
                else
                {
                    sumNo = sumNo + postulantes;
                    NoCumple++;
                    Console.WriteLine("la ferian no cumple ");
                    Console.WriteLine("====================");
                }

            }
            Console.WriteLine("Las ferias que cumplieron son: " + cumple + " con el total de estudiantes de : " + sumCumple);
            Console.WriteLine("Las ferias que no cumplen son: " + NoCumple + " con el total de estudiantes de : " + sumNo);
        }  
    }
}
