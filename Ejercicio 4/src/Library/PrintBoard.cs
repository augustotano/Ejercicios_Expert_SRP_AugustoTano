using System;
using System.Text;
using System.Threading;

namespace PII_Game_Of_Life
{
    public class PrintBoard
    {
        public bool[,] b {get; set;}  //variable que representa el tablero
        public int width {get; set;} //variabe que representa el ancho del tablero
        public int height {get; set;} //variabe que representa altura del tablero

        public void ImprimirTablero()
        {
            while (true)
                {
                    Console.Clear();
                    StringBuilder s = new StringBuilder();
                    for (int y = 0; y<height; y++)
                    {
                        for (int x = 0; x<width; x++)
                        {
                            if(b[x,y])
                            {
                                s.Append("|X|");
                            }
                            else
                            {
                                s.Append("___");
                            }
                        }
                        s.Append("\n");
                    }
                    Console.WriteLine(s.ToString());
                    //=================================================
                    //Invocar método para calcular siguiente generación
                    //=================================================
                    Thread.Sleep(300); 
                }
        }
        
    }
}

/* Codigo original para referencia


bool[,] b //variable que representa el tablero
int width //variabe que representa el ancho del tablero
int height //variabe que representa altura del tablero
While (true)
{
    Console.Clear();
    StringBuilder s = new StringBuilder();
    for (int y = 0; y<height;y++)
    {
        for (int x = 0; x<width; x++)
        {
            if(b[x,y])
            {
                s.Append("|X|");
            }
            else
            {
                s.Append("___");
            }
        }
        s.Append("\n");
    }
    Console.WriteLine(s.ToString());
    //=================================================
    //Invocar método para calcular siguiente generación
    //=================================================
    Thread.Sleep(300);
}

*/