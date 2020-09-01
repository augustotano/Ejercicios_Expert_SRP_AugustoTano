using System;

namespace SRP
{
    
    class Program
    {
        static void Main(string[] args)
        {   
            Biblioteca biblioteca1 = new Biblioteca();
            Libro libro1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro libro2 = new Libro("Pro C#","Troelsen","001-035");

            //No dependerian de libro, sino de biblioteca.
            biblioteca1.AlmacenarLibro("A","7");
            biblioteca1.AlmacenarLibro("B","3");

        }
    }
}
