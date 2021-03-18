using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanqueAPP
{
    class Operation
    {
        private static int cpt;
        private DateTime date;
        private string libelle;
        private MAD montant;
        private int num;
         
        static Operation()
        {
            cpt = 0;
        }

        public Operation(string libelle1, MAD mont)
        {
            this.num = cpt++;
            this.date = DateTime.Today;
            this.libelle = libelle1;
            this.montant = mont;
        }

        public void afficher()
        {
            Console.WriteLine("Le num : \t" + this.num + " Libelle : \t" + this.libelle + "||" + this.date + "||" + this.montant + "MAD");
        }


    }
}
