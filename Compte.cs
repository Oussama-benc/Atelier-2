susing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanqueAPP
{
    class Compte
    {
        private  readonly int numcomp;
        private static int cpt;
        private  readonly Client titulaire;
         protected MAD solde;
        protected  static MAD plafond; 

         static Compte()
        {
            cpt = 0;
            plafond = new MAD(2000);

        }
        public Compte(Client titu, MAD somme)
        {
            this.numcomp = ++cpt;
            this.titulaire = titu;
            this.solde = somme;
        }

        public void consulter()
        {
            Console.WriteLine("le num est :" + this.numcomp);
            this.titulaire.afficher();
            this.solde.afficher();
        }

        public bool crediter(MAD somme)
        {
            MAD valnul = new MAD(0);
            if (somme > valnul)
            {
                this.solde += somme;
                return true;
            }
             return false;
        }

        public virtual bool  Debiter(MAD somme)
        {
            MAD valnul = new MAD(0);
            if (somme > valnul )
            {
                if(plafond > somme)
                {
                    if(this.solde > somme)
                    {
                        this.solde -= somme;
                        return true;
                    }
                    else {
                        Console.WriteLine("somme > solde ");
                        return false;
                    }
                }
                    else
                    {
                        Console.WriteLine("somme > plafond ");
                        return false;

                    }
            }
            else
                    {
                        Console.WriteLine("somme  invalide ");
                        return false;
                    }

        }

        public bool verser(Compte c, MAD somme)
        {
            if (this.Debiter(somme))
            {
                c.crediter(somme);
                return true;
            }
            return false;


        }






    }
}





