using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Montant de la commission mensuelle");
            double montant = Double.Parse(Console.ReadLine());

            double taux;

            if (montant < 20000)
            {
                taux = 0.3;
            }
            else if (montant < 30000)
            {
                taux = 0.4;
            }
            else if (montant < 40000)
            {
                taux = 0.5;
            }
            else
            {
                taux = 0.6;
            }
            double montantcomission = montant * taux;
            Console.WriteLine($"Montant de la commission : {montant}");
            Console.ReadKey();
        }
    }
}
