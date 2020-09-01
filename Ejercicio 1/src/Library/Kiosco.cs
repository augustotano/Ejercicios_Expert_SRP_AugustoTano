using System;

namespace Expert_SRP
{
    public class Kiosco 
    {
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) 
        {
            Double pesos = ConvertirAPesos(dinero, moneda);
            return pesos >= a.PrecioDulce + a.PrecioMasa;
        }

        //Debería estar en su propia clase, encargada de convertir el dinero. No cumple SRP.
        //La clase kiosco no cumple Expert, no es ideal porque no tiene la información cómo para encargarse de esto.
        //Una clase propia de persona o similar que almacenara el dinero que tuviera una persona podría ser util para futuros cálculos.
        private Double ConvertirAPesos(Double dinero, String moneda)
        {
            if (moneda.Equals("U$S")) 
            {
                return dinero / 30;
            } 
            else if (moneda.Equals("$")) 
            {
                return dinero;
            }
            else 
            {
                return -1;
            }
        }
    }
}