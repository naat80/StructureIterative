using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Montant imposable : ");
            double mtImposable = double.Parse(Console.ReadLine());

            Console.WriteLine("Nombre de parts : ");
            double nbPart = double.Parse(Console.ReadLine());

            double qF = mtImposable / nbPart;

            double mtImpot;
            if (qF <= 10084)
            {
                mtImpot = 0;

            }else if (qF <= 25710)
            {
                mtImpot = (qF - 10085) * 0.11;
            } else if (qF <= 73516)
            {
                mtImpot = (25710 - 10085) * 0.11 + (qF - 25710) * 0.30;
            } else if (qF <= 158122)
            {
                mtImpot = (25710 - 10085) * 0.11 + (73516 - 25710) * 0.30
                    + (qF - 73516) * 0.41;
            } else
            {
                mtImpot = (25710 - 10085) * 0.11 + (73516 - 25710) * 0.30
                    + (158122 - 73516) * 0.41 + (qF - 158122) * 0.45;
            }
            mtImpot *= nbPart;
            mtImpot = Math.Floor(mtImpot);

            Console.WriteLine($"Montant de l'impot : {mtImpot} ");
            Console.ReadKey();
        }
    }
}
