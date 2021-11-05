using System;
using System.Text;
using Puissance4;

namespace Puissance4.Classe
{
    class Grille
    {
        private static int[,] _board = new int[7, 7];
        int heigth  
        {  
            get {return heigth; }
            set { heigth = 7; } 
            }
        int width 
        { 
            get {return width; }
            set { width = 7; }
        }

        public void init() {


            Console.WriteLine(" 0 1 2 3 4 5 6 ");
            Console.WriteLine("┌─┬─┬─┬─┬─┬─┬─┐");
            for (var i = 0; i < this.width; i++)
            {
                var line = new StringBuilder("│");
                for (var j = 0; j < this.heigth; j++)
                    {
                        if (_board[i, j] == 0)
                            line.Append(' ');
                        else if (_board[i, j] == 1)
                            line.Append('O');
                        else
                            line.Append('X');
                        line.Append('│');
                    }

                    Console.WriteLine(line.ToString());

                    if (i != 6) Console.WriteLine("├─┼─┼─┼─┼─┼─┼─┤");
                }
                Console.WriteLine("└─┴─┴─┴─┴─┴─┴─┘");
        }
    }
}