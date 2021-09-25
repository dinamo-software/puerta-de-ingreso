using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puerta_de_ingreso
{
    /// <summary>
    /// patron de diseño "factory"
    /// </summary>
    public abstract class Factory
    {
        public static Figura Create(Mediciones.MedicionDeLados medicion)
        {
            int cantidad = medicion.Longitudes.Count;
            
            return new Figura(cantidad);

        }
    }
}
