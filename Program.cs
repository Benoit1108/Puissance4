using System;
using System.Text;
using Puissance4.Classe;

namespace Puissance4
{
    class Program
    {
        
        private static int _currentPlayer = 1;

        static void Main(string[] args)
        {
            while (true)
            {
                int coup = 1;

                Grille grille = new Grille();
                grille.init();

                Player p1 = new Player();
                Player p2 = new Player();

                if(coup == 1)
                {
                    p1.play();
                    coup = 2;
                }            
                else
                {
                    p2.play();
                    coup = 1;
                }    
                /*Console.WriteLine($"Joueur {_currentPlayer}, en quelle colonne jouez-vous ?");

                if (!int.TryParse(Console.ReadLine(), out int column) || column < 0 || column > 6) continue;*/
                
                var full = true;
                for (var i = 6; i > -1; i--)
                {
                    if (_board[i, column] == 0)
                    {
                        _board[i, column] = _currentPlayer;
                        full = false;
                        break;
                    }
                }

                if (!full) _currentPlayer = _currentPlayer == 1 ? 2 : 1;
            }
        }
    }
}
