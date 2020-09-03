using System;
using System.Collections;

namespace SRP
{
    public class Biblioteca
    {
        private ArrayList ListaLibros = new ArrayList();

        public void AlmacenarLibro(Libro libro, String sector, String estante)
        {
            libro.Sector = sector;
            libro.Estante = estante;
            ListaLibros.Add(libro);
        
        }

    }
}
