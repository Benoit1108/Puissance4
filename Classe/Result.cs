using System;
using System.Text;

namespace Puissance4.Classe
{
    public class Result
    {
        private InterfaceJeu jeu;

        public Result(InterfaceJeu jeu)
        {
            this.jeu = jeu;
        }

        public void win(Player player)
        {
            if(player is RealPlayer)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Vous avez gagné !");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Vous avez perdu ! Contre un bot sans IA"); 
                Console.ResetColor();
            }
            this.askGame();
        }

        private void askGame()
        {
            Boolean hasChoose = false;
            do
            {
                Console.WriteLine("Veux tu relancer une nouvelle partie ? " + "\n" + "Y or N" );
                String answer =  Console.ReadLine();
                if(answer.ToLower() == "y")
                {
                    hasChoose = true;
                    this.jeu.newGame();
                }
                else if(answer.ToLower() == "n")
                {
                    this.exit();
                    hasChoose = true;
                }
                else
                {
                    Console.WriteLine("Saisir Y ou N !");
                }
            }
            while(!hasChoose);
        }

        private void exit()
        {
            Console.WriteLine("Bye bye !");
        }
    }
}