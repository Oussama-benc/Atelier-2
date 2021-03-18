using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanqueAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            string nom = Console.ReadLine();
            Client c1 = new Client(nom,"Oussama","benchama");
            MAD solde1 = new MAD(4000);
            Compte cpt = new Compte(c1, solde1);

            cpt.consulter();
            Console.ReadKey();


        }
    }
}
