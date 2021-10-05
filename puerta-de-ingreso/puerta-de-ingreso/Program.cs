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
                var figura = Factory.Create(medicion);

                if (figura != null)
                {
                    var tipo = figura.ObtenerTipo();
                    Console.WriteLine("La figura es un " + tipo);

                    var perimetro = figura.CalcularPerimetro();
                    Console.WriteLine("El perimetro es " + perimetro.ToString());

                    var area = figura.CalcularArea();
                    Console.WriteLine("El area es " + area.ToString());
                }
                

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

    }
}
    

