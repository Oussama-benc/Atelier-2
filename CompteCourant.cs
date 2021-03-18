using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanqueAPP
{
    class CompteCourant : Compte
    {
        private MAD decouvert;
        public CompteCourant(Client titu, MAD somme, MAD dec)  : base(titu, somme)
        {
            this.decouvert = dec;

        }

        public override bool Debiter(MAD somme)
        {
            MAD valnul = new MAD(0);
            if (somme > valnul)
            {
                if (plafond > somme)
                {
                    if (this.solde > somme && somme < decouvert)
                    {

                        this.solde -= somme;

                        return true;
                    }
                    else
                    {
                        Console.WriteLine("somme suppérieur au solde ");
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("somme suppérieur au plafond ");
                    return false;

                }
            }
            else
            {
                Console.WriteLine("somme  invalide ");
                return false;
            }

        }

    }
}

