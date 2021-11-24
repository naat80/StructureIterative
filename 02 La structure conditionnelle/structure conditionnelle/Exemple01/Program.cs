using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple01
{
    class Program
    {// Calcul du montant de la TVA
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Saisie des données
            Console.Write("Montant hors taxe :");
            double MontantHT = double.Parse(Console.ReadLine());
            Console.Write("Code TVA :");
            int code = int.Parse(Console.ReadLine());

            // Calcul de la TVA
            double MontantTVA;
            if (code == 1)
            {
                MontantTVA = MontantHT * 0.2;
                Console.WriteLine($"Montant de la TVA : {MontantTVA}");
            }
            else if (code == 2)
            {
                MontantTVA = MontantHT * 0.055;
                Console.WriteLine($"Montant de la TVA : {MontantTVA}");
            } else if (code ==3)
            {
                MontantTVA = MontantHT * 0.1;
                Console.WriteLine($"Montant de la TVA : {MontantTVA}");
            }
            else
            {
                Console.WriteLine("Code TVA inexistant");
            }
            Console.ReadKey();
        }
    }
}
