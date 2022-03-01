using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generateur_de_mot_de_passe
{
    static class Outils
    {
        public static int DemanderNombrePositifNonNull(string question)
        {
            return DemanderNombreEntre(question, 1, int.MaxValue, "Erreur, le nombre doit être positif et non nul!");
        }

        public static int DemanderNombreEntre(string question, int min, int max, string messageErreurperso = null)
        {
            int nombre = DemanderNombre(question);
            if ((nombre >= min) && (nombre <= max))
            {
                return nombre;
            }
            if (messageErreurperso == null)
            {
                Console.WriteLine("Erreur! Vous devez entrer un nombre entre" + min + " et " + max);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(messageErreurperso);
                Console.WriteLine();
            }
            
            return DemanderNombreEntre(question, min, max);
        }

        public static int DemanderNombre(string question)
        {
            while (true)
            {
                Console.Write(question);
                string reponse = Console.ReadLine();

                try
                {
                    int reponseInt = int.Parse(reponse);
                    return reponseInt;
                }
                catch (Exception)
                {

                    Console.WriteLine("Erreur! Vous devez entrer un nombre!");
                    Console.WriteLine();
                }
            }
        }
    }
}
