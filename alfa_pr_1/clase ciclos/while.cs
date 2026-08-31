using System;
using System.Collections.Generic;
using System.Text;

namespace alfa_pr_1.clase_ciclos
{
    public class CiclosWhile
    {
        public static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("el numero es " + num );

            while (num <= 5)          
            {
                Console.WriteLine("el numero se actualizo a " + num);
                num++;                  
            }

            Console.WriteLine("Fin");
        }
    }
}

