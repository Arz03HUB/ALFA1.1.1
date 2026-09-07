using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramacionII.Guia04
{
    public class Ej06_EST10
    {
        public static void Main(string[] args)
        {
            int reserva = 6000;
            double alerta = reserva * 0.20;
            int jornadas = 0;
             Console.WriteLine("la entrega diaria a tarija es de 1000 kg");
            while (reserva > alerta)
            {
               
                reserva = reserva - 1000;
                jornadas++;
                Console.WriteLine("En la jornada N° : "+ jornadas + " Aun queda " + reserva + " kg porque se entregaron 1000 kg");
                Console.WriteLine("============================================================================================");

                if (reserva <= alerta)
                {
                    Console.WriteLine("Alerta hay menos del 20% en la reserva,ya no se aran entregas ");
                    Console.WriteLine("La reserva duro "+ jornadas + " jornadas");
                }
            }


        }
    }
}
