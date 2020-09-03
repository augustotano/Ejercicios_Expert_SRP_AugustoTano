using System;

namespace SRP
{
    //Fue agregada una clase biblioteca para darle más sentido al programa y al metodo "AlmacenarLibro".
    class Program
    {
        static void Main(string[] args)
        {   
            Biblioteca biblioteca1 = new Biblioteca();
            Libro libro1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro libro2 = new Libro("Pro C#","Troelsen","001-035");

            biblioteca1.AlmacenarLibro(libro1,"A","7");
            biblioteca1.AlmacenarLibro(libro2,"B","3");
            Console.WriteLine($"{libro1.Codigo} {libro1.Titulo} {libro1.Autor} {libro1.Sector} {libro1.Estante}");

        }
    }
}
