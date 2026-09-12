using System;
using System.Collections.Generic;
using System.Text;

namespace EJERCICIOS_EXTENSOS.EJ11_EJ20
{
    public class EJ13_EST02
    {
        public static void Main(string[] args)
        {
            const double META = 2000.0;
            double acumulado = 0;
            int periodos = 0;

            while (acumulado < META)
            {
                periodos++;
                Console.Write($"Periodo {periodos}: ");
                double avance = double.Parse(Console.ReadLine());

                if (avance == 0) Console.WriteLine("  Aviso: Periodo improductivo.");
                else acumulado += avance;

                double saldo = META - acumulado;
                Console.WriteLine($"  Saldo pendiente: {(saldo < 0 ? 0 : saldo)} qq.");
            }
            Console.WriteLine($"\nTotal: {acumulado} qq | Excedente: {acumulado - META} qq | Periodos: {periodos}");
            Console.ReadKey();
        }
    }
}
