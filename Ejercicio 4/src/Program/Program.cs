using System;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Lector tablero = new Lector();
            tablero.ObtenerTablero();

            bool[,] gameBoard = tablero.Board;
            

            
        }
    }
}
