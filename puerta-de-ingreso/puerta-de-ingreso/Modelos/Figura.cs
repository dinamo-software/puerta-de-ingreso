using puerta_de_ingreso.Modelos;

namespace puerta_de_ingreso
{
    public class Figura
    {
        private int cantidad;

        public Figura(int cantidad)
        {
            this.cantidad = cantidad;    
        }

        public virtual decimal CalcularArea()
        {
            return 0;
        }


        public virtual decimal CalcularPerimetro()
        {
            return 0;
        }
    }
}
