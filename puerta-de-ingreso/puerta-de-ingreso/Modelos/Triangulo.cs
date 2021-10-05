using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using puerta_de_ingreso.Mediciones;

namespace puerta_de_ingreso.Modelos
{
    class Triangulo : Figura
    {
        public Triangulo(int cantidad) : base(cantidad)
        {
            // la unica variable que tiene figura es la cantidad de lados,  ¿como llamo individualmente a  cada lado? 
        }
        
        public override decimal CalcularArea()
        {
            //como hago para llamar aca a los dos lados que necesito para calcular el area
            return 0;
        }

        public override decimal CalcularPerimetro()
        
        {
            //como le pido a medicion de lados desde aca los lados de la figura siendo que en figura no se guardan los lados sino en medicion de lados

   
    }
}

