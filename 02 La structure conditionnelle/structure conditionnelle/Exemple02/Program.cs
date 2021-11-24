using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple02
{
    class Program
    {
        // Attribuer une appréciation selon la note obtenue
        static void Main(string[] args)
        {
            Console.WriteLine("Note :");
            double note = double.Parse(Console.ReadLine());
            string appreciation;

            if (note > 20 || note < 0)
            { 
                appreciation = "Note non valide"; 
            }

            else if (note > 13)

            {
                appreciation = "Très satisfaisant";

            }
            else if (note >= 10)
            {
                appreciation = "Satisfaisant";
            }
            else if (note > 6)
            {
                appreciation = "Insuffisant";
            }
            else if (note >= 0)
            {
                appreciation = "Très insuffisant";
            }
            else
            {
                appreciation = "Note non valide";
            }
            Console.WriteLine($"Appreciation : {appreciation}");
            Console.ReadKey();


        }
    }
}
