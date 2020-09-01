using System;

namespace SRP
{
    public class Biblioteca
    {
        //No cumple SRP. Tendrían que estar en su propia clase biblioteca.
        public 
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }

        //Debería estar tambien en su propia clase llamada biblioteca.
        public void AlmacenarLibro(Libro libro, String sector, String estante)
        {
            libro;
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }

    }
}
