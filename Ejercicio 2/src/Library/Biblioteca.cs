using System;
using System.Collections;

namespace SRP
{
    public class Biblioteca
    {
        ArrayList ListaLibros = new ArrayList();

        public void AlmacenarLibro(Libro libro, String sector, String estante)
        {
            ListaLibros.Add((libro, sector, estante));
        }

    }
}
