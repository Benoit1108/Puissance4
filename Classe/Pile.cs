using System;
using System.Text;

namespace Puissance4.Classe
{
    class Pile
    {
        int listChip;
        int heigthPile  
        {  
            get {return heigth; }
            set { heigth = 7; } 
        }

        public Boolean full()
        {
            Grille grille = new Grille();

            if(this.heigthPile != grille.heigh())
            {
                return false;
            }
            else
            {
                Console.WriteLine("Colonne pleine");
                return true;
            }
        }
    }
}