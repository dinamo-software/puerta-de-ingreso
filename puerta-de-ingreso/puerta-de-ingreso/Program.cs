using System;

namespace puerta_de_ingreso
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularPerimetroDeUnCuadrado();
            //CalcularPerimetroDeUnTriangulo();
        }

        private static void CalcularPerimetroDeUnCuadrado()
        {
            string lado = "";

            Console.WriteLine("Vamos a calcular el perimetro de un cuadrado!");
            Console.WriteLine("Cuanto mide uno de los lados?");
            lado = Console.ReadLine();

            long ladoIntTry;
            if (long.TryParse(lado, out ladoIntTry))
            {
                var perimetro = 4 * (int)ladoIntTry;
                Console.WriteLine("El perimetro es " + perimetro.ToString());

            }
            else
            {
                Console.WriteLine("No es un valor válido para lado");
            }
        }

    }
}
