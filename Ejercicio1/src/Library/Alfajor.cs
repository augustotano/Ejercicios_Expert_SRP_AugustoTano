using System;

namespace Expert_SRP
{
    public class Alfajor 
    {
        public Alfajor(double precioMasa, double precioDulce)
        {
            this.PrecioDulce = precioDulce;
            this.PrecioMasa = precioMasa;
            this.PrecioTotal = this.PrecioMasa + this.PrecioDulce;
        }
        public Double PrecioDulce {get;set;}
        public Double PrecioMasa {get; set;}
        public Double PrecioTotal {get; set;}

    }
}