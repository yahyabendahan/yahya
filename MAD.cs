using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ateliern1
{
    class MAD
    {
        private double valeur;

        public double Val()
        {
            return this.valeur;
        }


        public void Afficher() {
            Console.WriteLine("la valeur est" + valeur);
        }

        public static MAD operator+ (MAD A, MAD B){
            MAD res = new MAD(0);
            res.valeur = A.valeur + B.valeur;
            return res;

        }
    
    public static MAD operator-(MAD A, MAD B)
        {
          MAD res = new MAD(0);
    res.valeur = A.valeur - B.valeur ;
            return res ;
        }

        public static bool operator<=(MAD A, MAD B){
           return A.valeur <= B.valeur ;   
        }
        public static bool operator >=(MAD A, MAD B)
        {
            return A.valeur >= B.valeur;
        }
        public static bool operator >(MAD A,double s)
        {
            return A.valeur > s;
            
        }
        public static bool operator <(MAD A, double s)
        {
            return A.valeur < s;

        }

    }
}
