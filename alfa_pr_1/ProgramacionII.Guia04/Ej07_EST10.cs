using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Text;

namespace ProgramacionII.Guia04
{
     public  class Ej07_EST10
    {
        public static void Main(string[] args)
        {
            const int alta = 70;
            const int media = 30;
            const int cursos = 7;

            int contAlta = 0;
            int contMedia = 0;
            int contBaja = 0;
            int sumaA = 0;
            int sumaB = 0;
            int sumaC = 0;

            for (int lengua = 1; lengua <= cursos; lengua++)
            {
                Console.WriteLine("Ingresa cuantos inscritos hay en el curso N°: " + lengua);
                int inscritos = int.Parse(Console.ReadLine());

                if (inscritos >= alta)
                {
                    Console.WriteLine("Inscripcion alta");
                    contAlta++;
                    sumaA = sumaA + inscritos;
                }
                else if (inscritos >= media && inscritos < alta)

                {
                    Console.WriteLine("Inscripcion medias");
                    contMedia++;
                    sumaB = sumaB + inscritos;
                }
                else
                {
                    Console.WriteLine("Inscripcion bajas");
                    contBaja++;
                    sumaC = sumaC + inscritos;
                }
            }
            Console.WriteLine("Hubo inscripciones altas en " + contAlta + " cursos con un total de " + sumaA + " inscritos");
            Console.WriteLine("Hubo inscripcion media en " + contMedia + " cursos con un total de " + sumaB + " inscritos");
            Console.WriteLine("Hubo inscripciones bajas en " + contBaja + " cursos con un total de " + sumaC + " inscritos");
        }  }
}
