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
            var medicion = new Mediciones.MedicionDeLados();
            string lado = "";

            Console.WriteLine("Vamos a calcular el perimetro de un cuadrado!");
            Console.WriteLine("Cuanto mide uno de los lados?");
            lado = Console.ReadLine();

            long ladoIntTry;
            if (long.TryParse(lado, out ladoIntTry))
            {
                //almaceno la medicion x4 (asumiendo que es un lado de un cuadrado)
                medicion.Longitudes.Add((int)ladoIntTry);
                medicion.Longitudes.Add((int)ladoIntTry);
                medicion.Longitudes.Add((int)ladoIntTry);
                medicion.Longitudes.Add((int)ladoIntTry);

                //propuesta: calcular el perimetro usando un método que utiliza el objeto medicion
                //var perimetro = CalcularPerimetro(medicion);

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
            var medicion = new Mediciones.MedicionDeLados();
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
                //almaceno la medicion x4 (asumiendo que es un lado de un cuadrado)
                medicion.Longitudes.Add((int)ladoIntTry);
                medicion.Longitudes.Add((int)ladoIntTry2);
                medicion.Longitudes.Add((int)ladoIntTry3);

                //propuesta: calcular el perimetro usando un método que utiliza el objeto medicion
                //var perimetro = CalcularPerimetro(medicion);


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
            var medicion = new Mediciones.MedicionDeLados();
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

            if (long.TryParse(lado, out ladoIntTry) && long.TryParse(lado2, out ladoIntTry2) && long.TryParse(lado3, out ladoIntTry3))
            {
                //almaceno la medicion de los lados
                medicion.Longitudes.Add((int)ladoIntTry);
                medicion.Longitudes.Add((int)ladoIntTry2);
                medicion.Longitudes.Add((int)ladoIntTry3);

                //propuesta: calcular el area usando un método que utilize el objeto medicion
                //var area = CalcularArea(medicion);

                var area = "calcular utilizando una medicion";
                    //((int) baseIntTry * (int) alturaIntTry) / 2;

                Console.WriteLine("El Area es " + area.ToString() );
            }
            else
            {
                Console.WriteLine("No es un valor válido para lado");
            }
        }

    }
}
    

