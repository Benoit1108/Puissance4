using System;
using System.Text;

namespace Puissance4.Classe
{
    class Result
    {

        Boolean win = false;
        
        public void exit()
        {
            Console.WriteLine("Voulez aller fermer l'application");
            Environment.Exit(0);
        }

        public void newGame() {
            Grille.init();
        }

        public Boolean Win()
        {
            if(win == true)
            {
                Console.WriteLine("Vous avez gagné !");
            }
        }
    }
}