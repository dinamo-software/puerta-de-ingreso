using System;

namespace puerta_de_ingreso
{
    class Program
    {
        static void Main(string[] args)
        {
           CalcularPerimetroDeUnCuadrado();
           CalcularPerimetroDeUnTriangulo();
           CalcularAreaDeUnTriangulo();
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
        
        private static void CalcularPerimetroDeUnTriangulo()
        {
            string lado = "";
            string lado2 = "";
            string lado3 = "";

            Console.WriteLine("Vamos a calcular el perimetro de un Triangulo!");
            Console.WriteLine("Cuanto miden los 3 lados?");
            lado = Console.ReadLine();
            lado2 = Console.ReadLine();
            lado3 = Console.ReadLine();

            long ladoIntTry;
            long ladoIntTry2;
            long ladoIntTry3;
            
            if (long.TryParse(lado, out ladoIntTry) && long.TryParse(lado2, out ladoIntTry2)&& long.TryParse(lado3, out ladoIntTry3))
            {
                var perimetro =  (int)ladoIntTry + (int)ladoIntTry2 + (int)ladoIntTry3 ;
                Console.WriteLine("El perimetro es " + perimetro.ToString());

            }
            else
            {
                Console.WriteLine("No es un valor válido para lado");
            }
        }
        
        private static void CalcularAreaDeUnTriangulo()
        {
            string basee = "";
            string altura = "";
            Console.WriteLine("Vamos a calcular el Area de un triango");
            Console.WriteLine("cuando mide la base?");
            basee = Console.ReadLine();
            Console.WriteLine("cuando mide la altura?");
            altura = Console.ReadLine();
            long baseIntTry;
            long alturaIntTry;
            if (long.TryParse(basee, out baseIntTry) && (long.TryParse(altura, out alturaIntTry)))
            {
                var area = ((int) baseIntTry * (int) alturaIntTry) / 2 ;
                Console.WriteLine("El Area es " + area.ToString() );
            }
            else
            {
                Console.WriteLine("No es un valor válido para lado");
            }
        }
        }
}
    

