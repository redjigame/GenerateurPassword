using System;

namespace generateur_de_mot_de_passe
{
    class Program
    {
        

        static void Main(string[] args)
        {
            const int NB_MDP = 4;

            int longueurMotDePasse = Outils.DemanderNombrePositifNonNull("longueur du mot de passe : ");

            Console.WriteLine();

            int choixAlphabet = Outils.DemanderNombreEntre("Voulez vous un MDP avec \n" +
                "1-Seulement minuscules? \n" +
                "2-Seulement majuscules? \n" +
                "3-minuscules et majuscules? \n" +
                "4-minuscules + majuscules + chiffres? \n" +
                "5-minuscules + majuscules + chiffres + speciales?", 1, 4);

            Console.WriteLine();

            string minuscules = "abcdefghijklmnopqrstuvwxyz";
            string majuscules = minuscules.ToUpper();
            string chiffres = "0123456789";
            string caractereSpeciaux = "@#$%";

            string alphabet = minuscules + majuscules + chiffres + caractereSpeciaux;
            string motdePasse = "";
            Random rand = new Random();

            if (choixAlphabet == 1)
            {
                alphabet = minuscules;
            }
            else if (choixAlphabet == 2)
            {
                alphabet = majuscules;
            }
            else if (choixAlphabet == 3)
            {
                alphabet = minuscules + majuscules ;
            }
            else if(choixAlphabet == 4)
            {
                alphabet = minuscules + majuscules + chiffres ;
            }
            else if (choixAlphabet == 5)
            {
                alphabet = minuscules + majuscules + chiffres + caractereSpeciaux;
            }
            else
            {
                Console.WriteLine("Erreur");
            }

            int longueurAlphabet = alphabet.Length;

            for (int J = 0; J < NB_MDP; J++)
            {
                motdePasse = "";
                for (int i = 0; i < longueurMotDePasse; i++)
                {
                    int index = rand.Next(0, longueurAlphabet);
                    motdePasse += alphabet[index];
                }

                Console.WriteLine(motdePasse);
            }
        }
    }
}
