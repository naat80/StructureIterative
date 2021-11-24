using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Saisie des données
            Console.Write("Distance en Km :");
            int distance = int.Parse(Console.ReadLine());

            Console.Write("Type de l'établissement (l ou c) ");
            char typeEtb = char.Parse(Console.ReadLine());

            Console.Write("Etes vous dans le secteur de votre d'établissement (o/n) ");
            char Secteur = char.Parse(Console.ReadLine());

            // Calcul le tarif aller 

            double tarifAller = 1.2;
            if (distance > 10)
            {
                tarifAller = tarifAller + (distance - 10) * 0.1;
            }

            int nbAR = 6;
            if (typeEtb == 'c' || typeEtb == 'C')
            {
                nbAR = 4;
            }
            double taux = 0;
            if (Secteur == 'o' || typeEtb == 'O')
            {
                taux = 0.4;
            }

            // Calcul du montant de l'abonnement
            double montant = tarifAller * nbAR * 2 * 35 * (1 - taux);

            Console.WriteLine($"Montant de l'abonnement : {montant}");
            Console.ReadKey();




        }
    }
}
