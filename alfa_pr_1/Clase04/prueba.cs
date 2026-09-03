using System;
using System.Collections.Generic;
using System.Text;

namespace alfa_pr_1.Clase04
{
    public class prueba
    {
        public static void main(string[] args)
        {
            Console.WriteLine("Ingrese el valor para num1");
            int uno = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor para num2");
            int dos = int.Parse(Console.ReadLine());

            Console.WriteLine("la suma es :" + uno + " " + dos);
        }
    }
}
