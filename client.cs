using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ateliern1
{
    class client
    {
        private string nom;
        private string prenom;
        private string adresse;

        public void Afficher()
        {
            Console.WriteLine("Nom :" +nom+" Prenom :"+prenom+" adresse :"+adresse);
        }
    }
}
