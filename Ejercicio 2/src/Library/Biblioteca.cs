using System;
using System.Collections;

namespace SRP
{
    public class Biblioteca
    {
        //No cumple SRP. Tendrían que estar en su propia clase biblioteca.
        ArrayList ListaLibros = new ArrayList();


        //Debería estar tambien en su propia clase llamada biblioteca.
        public void AlmacenarLibro(Libro libro, String sector, String estante)
        {
            ListaLibros.Add((libro, sector, estante));
            Console.WriteLine(ListaLibros[0]);
        }

    }
}
