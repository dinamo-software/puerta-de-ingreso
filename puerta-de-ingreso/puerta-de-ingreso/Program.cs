using System;
using System.Linq;

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

            } while (continuar == "S" | continuar=="s");

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
                    medicion.Longitudes.Add((int) ladoIntTry);
                }
                else
                {
                    Console.WriteLine("### ERROR ###");
                }

            } while (!string.IsNullOrEmpty(lado));

            return medicion;
        }

        private static void CalcularPerimetro(Mediciones.MedicionDeLados medicion)
        {
            var perimetro = medicion.CalcularPerimetro();
                Console.WriteLine("El perimetro es " + perimetro.ToString());
        }

        private static void CalcularArea(Mediciones.MedicionDeLados medicion)
        {
            // necesito explicacion de LINQ 
           // var agrupacion = medicion.Longitudes.GroupBy(x => x);
            {
                if (medicion.Longitudes.Count() == 4)
                {
                    var perimetro = medicion.CalcularAreaCuadrado();

                    Console.WriteLine("El area es " + perimetro.ToString());
                 
                }
            }
        }
    }
}
    

