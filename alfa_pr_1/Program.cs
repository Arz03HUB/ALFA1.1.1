namespace alfa_pr_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========================");
            Console.WriteLine("===Bienvenido a Bolivia===");
            Console.WriteLine("==========================");
            Console.WriteLine("Que departamentos deseas conocer");
            Console.WriteLine("1:Cochabamaba");
            Console.WriteLine("2:La paz");
            Console.WriteLine("3:Santa Cruz");
            Console.WriteLine("4:Oruro");
            Console.WriteLine("5:Potosi");
            Console.WriteLine("6:Beni");
            Console.WriteLine("7.Chuquisaca");
            Console.WriteLine("8:Tarija");
            Console.WriteLine("9:Pando");
            int opcion = int.Parse(Console.ReadLine());
            if (opcion <= 9 && opcion >= 1)
            {
                if (opcion == 1)
                {
                    Console.WriteLine("Cochabamba es un departamento de Bolivia, ubicado en la región central del país. Su capital es la ciudad de Cochabamba, conocida por su clima agradable y su rica cultura. El departamento cuenta con una diversidad geográfica que incluye valles, montañas y ríos, lo que lo convierte en un lugar ideal para actividades al aire libre y turismo.");
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("La Paz es un departamento de Bolivia situado en el oeste del país. Su capital es la ciudad de La Paz, que se encuentra a una altitud impresionante y es conocida por su paisaje montañoso y su vibrante vida cultural. El departamento alberga importantes sitios turísticos, como el Valle de la Luna y el teleférico urbano más largo del mundo.");
                }
                else if (opcion == 3)
                {
                    Console.WriteLine("Santa Cruz es un departamento de Bolivia ubicado en la región oriental del país. Su capital es la ciudad de Santa Cruz de la Sierra, que se destaca por su crecimiento económico y su diversidad cultural. El departamento cuenta con una gran variedad de paisajes, desde llanuras hasta selvas tropicales, lo que lo convierte en un destino atractivo para los visitantes.");
                }
                else if (opcion == 4)
                {
                    Console.WriteLine("Oruro es un departamento de Bolivia situado en el altiplano andino. Su capital es la ciudad de Oruro, famosa por su carnaval, declarado Patrimonio Cultural Inmaterial de la Humanidad por la UNESCO. El departamento cuenta con una rica tradición minera y una cultura vibrante que se refleja en sus festividades y expresiones artísticas.");
                }
                else if (opcion == 5)
                {
                    Console.WriteLine("Potosí es un departamento de Bolivia ubicado en el sur del país. Su capital es la ciudad de Potosí, conocida por su historia minera y su arquitectura colonial. El departamento alberga el Cerro Rico, una montaña rica en minerales que ha sido explotada durante siglos y ha dejado una huella significativa en la historia económica y social de Bolivia.");
                }
                else if (opcion == 6)
                {
                    Console.WriteLine("Beni es un departamento de Bolivia situado en la región amazónica del país. Su capital es Trinida");
                }
                else if (opcion == 7)
                {
                    Console.WriteLine("Oruro es un departamento de Bolivia situado en el altiplano andino. Su capital es la ciudad de Oruro, famosa por su carnaval, declarado Patrimonio Cultural Inmaterial de la Humanidad por la UNESCO. El departamento cuenta con una rica tradición minera y una cultura vibrante que se refleja en sus festividades y expresiones artísticas.");
                }
                else if (opcion == 8)
                {
                    Console.WriteLine("Potosí es un departamento de Bolivia ubicado en el sur del país. Su capital es la ciudad de Potosí, conocida por su historia minera y su arquitectura colonial. El departamento alberga el Cerro Rico, una montaña rica en minerales que ha sido explotada durante siglos y ha dejado una huella significativa en la historia económica y social de Bolivia.");
                }
                else

                    Console.WriteLine("Beni es un departamento");
            }





            else
            {
                Console.WriteLine("Beni ");
            }



        }
    }
}
