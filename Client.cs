using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanqueAPP
{
    class Client
    {
        private  string nom;
        private  string prenom;
        private  string adressse;
        private List<Compte> liste_des_comptes;



        public Client(string n,string p,string a , List<Compte> comptes)
        {
            this.nom = n;
            this.prenom= p;
            this.adressse= a;
            liste_des_comptes = comptes;
        }

        public void afficher()
        {

            Console.WriteLine("Le nom est :" + this.nom);
            Console.WriteLine("Le prenom est :" + this.prenom);
            Console.WriteLine("L'adresse est :" + this.adressse);
        }
    }
}
