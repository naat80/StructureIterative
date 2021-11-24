using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Note obtenue au premier partiel :");
            double p1 = double.Parse(Console.ReadLine());
            double p2 = double.Parse(Console.ReadLine());
            Console.Write("Note obtenue à l'examen");
            double ex = double.Parse(Console.ReadLine());

            string reponse;
            if (ex >= 10)
            {
                reponse = "Candidat reçu";
            }
            else if ((p1 + p2 + ex) / 3 >= 10)
            {
                reponse = "Candidat reçu";
            }
            else
            {
                reponse = "Candidat ajourné";
            }
            Console.WriteLine($"Décision du jury : {reponse}");
        }
    }
}
