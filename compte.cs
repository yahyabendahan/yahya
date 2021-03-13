using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ateliern1
{
    class compte
    {
        private int numcompt;
        private readonly int cpt;
        private client titulaire ;
        private MAD solde;
        private MAD plafond;

        public bool Credite(MAD somme)
        {  if( somme.Val() > 0) { 
            solde += somme;
                return true;
            }
            else
            {
                Console.WriteLine("vous avez entrer un nombre negative. ");
                return false;
            }

        }
        public bool Debite(MAD somme)
        {
            if (somme <= plafond) { 
             solde -= somme;
                return true;
            }

            else{
                Console.WriteLine("vous avez depacer le debit max");
                return false;
            }
        }

        public bool Verse(compte c,MAD somme)
        { // this.solde - somme.solde  :: c.solde + somme.solde 
            if ((somme.Val() > 0)&&(somme <= plafond)){
                c.solde += somme ;
                this.solde -= somme ;
                return true;
            }
            else
            {
                Console.WriteLine("le versement ne peut pas etre efectuer");
                return false;
            }
        }
         
        public void Consulter()
        {
            Console.WriteLine("numerocmpt: "+numcompt);
           titulaire.Afficher();
            solde.Afficher();
            plafond.Afficher();
        }

    }
}
