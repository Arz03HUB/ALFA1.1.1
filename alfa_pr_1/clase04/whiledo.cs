using System;
using System.Collections.Generic;
using System.Text;

namespace alfa_pr_1.clase04
{
    public class while_do

    {
        public static void Main(string[] args)
    {
        int opcion;
        
        do
        {
            Console.WriteLine("1. jugar");
            Console.WriteLine("2. salir");
            Console.WriteLine("opcion: ");
            opcion = int.Parse(Console.ReadLine());
        } 
        while (opcion != 2);
    } // Cierra Main
    
    }
}

