using System;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            GameBoard gameBoard = new GameBoard();
            PrintBoard printer = new PrintBoard();
            Cell celula = new Cell();

            gameBoard.ObtenerBoard();
            celula.EjecutarTodo();
            printer.ImprimirTablero();
            Console.WriteLine("Hello World!");
        }
    }
}
