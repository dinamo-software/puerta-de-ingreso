﻿using puerta_de_ingreso.Mediciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puerta_de_ingreso.Modelos
{
    public class Rectangulo : Figura // herencia
    {
        public Rectangulo(MedicionDeLados medicion) : base(medicion) // herencia
        {
        }

        public override string ObtenerTipo()
        {
            return ObtenerTipo("Rectangulo");
        }

        public override decimal CalcularArea() //polimorfismo
        {
            var areaDeFigura = base.CalcularArea();

            areaDeFigura = areaDeFigura + 10;

            //como hago para llamar aca a los dos lados que necesito para calcular el area
            return areaDeFigura;
        }

        public override decimal CalcularPerimetro() //polimorfismo

        {
            //como le pido a medicion de lados desde aca los lados de la figura siendo que en figura no se guardan los lados sino en medicion de lados
            return 4;
        }


    }
}
