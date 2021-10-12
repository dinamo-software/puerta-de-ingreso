using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using puerta_de_ingreso.Mediciones;

namespace puerta_de_ingreso.Modelos
{
    public class Pentagono : Figura //herencia
    {
        private static string TipoDeFigura = @"Pentagono";

        public Pentagono(MedicionDeLados medicion) : base(medicion) // herencia
        {
            // la unica variable que tiene figura es la cantidad de lados,  ¿como llamo individualmente a  cada lado? 
        }

        public override string ObtenerTipo()
        {
            return ObtenerTipo(Pentagono.TipoDeFigura);
        }

        public override decimal CalcularArea() //polimorfismo
        {
            //area de pentagono REGULAR (todos sus lados son iguales)
            decimal apotema;
            decimal anguloTeta;
            
            return 0;
        }

        public override decimal CalcularPerimetro()

        {
            decimal perimetro = this.Medicion.Longitudes.Sum();
            return perimetro;
        }
    }
}

