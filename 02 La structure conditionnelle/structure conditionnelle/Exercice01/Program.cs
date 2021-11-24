using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sasissez une quantitée :");
            int qte = int.Parse(Console.ReadLine());
            Console.Write("Saisissez un prix unitaire");
            double prixttc = double.Parse(Console.ReadLine());

            double montant = 0;

            if (qte == 1)
            {
                montant = prixttc;
            }
            else
            {
                montant = prixttc + (qte - 1) * prixttc * (1 - 0.04);
            }
            Console.WriteLine($"Montant à payer : {montant}");
            Console.ReadKey();
        }
    }