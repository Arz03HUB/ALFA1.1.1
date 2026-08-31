using System;
using System.Collections.Generic;
using System.Text;

namespace alfa_pr_1.clase_ciclos
{
    public class doWhile
    {
        public static void Main(string[] args)
        {
            int vida = 0;

            while (vida > 0)
            {
                Console.WriteLine("Se te esta cacabando las vida" + vida);
                vida--;
            }
        }
    }
}