using System;

namespace puerta_de_ingreso
{
    class Program
    {
        static void Main(string[] args)
        {
            string continuar = "S";

            do
            {
                var medicion = ObtenerMedicionDeLados();
                
                //crear este metodo
                CalcularPerimetro(medicion);
                
                //crear este metodo
                CalcularArea(medicion);

                Console.WriteLine();
                Console.WriteLine("Desea continuar? (S/N) ");
                continuar = Console.ReadLine();

            } while (continuar == "S");
            

            //no usar estos metodos, los dejo para tenerlos de ejemplo, en la proxima version los borro
           //CalcularPerimetroDeUnCuadrado();
           //CalcularPerimetroDeUnTriangulo();
           //CalcularAreaDeUnTriangulo();
        }

        private static Mediciones.MedicionDeLados ObtenerMedicionDeLados()
        {
            var medicion = new Mediciones.MedicionDeLados();
            Console.WriteLine("# Iniciamos la medición de los lados de una figura");

            string lado = "";
            do
            {
                Console.Write("Ingrese medida del lado: ");
                lado = Console.ReadLine();
                if (string.IsNullOrEmpty(lado)) break;

                long ladoIntTry;
                if (long.TryParse(lado, out ladoIntTry))
                {
                    medicion.Longitudes.Add((int)ladoIntTry);
                }
                else
                {
                    Console.WriteLine("### ERROR ###");
                }

            } while (!string.IsNullOrEmpty(lado));

            return medicion;
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

                var perimetro = medicion.CalcularPerimetro();
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

            if (long.TryParse(lado, out ladoIntTry) && long.TryParse(lado2, out ladoIntTry2) &&
                long.TryParse(lado3, out ladoIntTry3))
            {
                //almaceno la medicion x3 (asumiendo que es un lado de un triangulo)
                medicion.Longitudes.Add((int) ladoIntTry);
                medicion.Longitudes.Add((int) ladoIntTry2);
                medicion.Longitudes.Add((int) ladoIntTry3);

                var perimetro = medicion.CalcularPerimetro();
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
           

            Console.WriteLine("Vamos a calcular el Area de un Triangulo!");
            Console.WriteLine("Cuanto mide la base?");
            lado = Console.ReadLine();
            Console.WriteLine("Cuanto mide la altura?");
            lado2 = Console.ReadLine();
            
            
            long ladoIntTry;
            long ladoIntTry2;


            if (long.TryParse(lado, out ladoIntTry) && long.TryParse(lado2, out ladoIntTry2)) 
            {
                //almaceno la medicion de los lados
                medicion.Longitudes.Add((int)ladoIntTry);
                medicion.Longitudes.Add((int)ladoIntTry2);

                //propuesta: calcular el area usando un método que utilize el objeto medicion
               
                var area = medicion.CalcularAreaTriangulo();
                Console.WriteLine("El Area es " + area.ToString() );
            }
            else
            {
                Console.WriteLine("No es un valor válido para lado");
            }
        }

    }
}
    

