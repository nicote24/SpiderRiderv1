using System;
using SpiderRiderv1;

namespace regroupeur
{
    class Program
    {
        static void Main(string[] args)
        {
            Affichage afficher = new Affichage();
            Random random = new Random();
            int chiffreAl = random.Next(1, 3);
            string nom;
            int choixArme;
            string nomEpee;
            int choixFaction;
            int choixCreature;
            Combat combat;

            afficher.ChoisirFaction();
            choixFaction=Convert.ToInt32(Console.ReadLine());
            afficher.ChoisirNom();
            nom = Console.ReadLine();
            afficher.ChoisirArme();
            choixArme=Convert.ToInt32(Console.ReadLine());
            afficher.ChoisirNomEpee();
            nomEpee = Console.ReadLine();
            afficher.ChoisirCreature();
            choixCreature=Convert.ToInt32(Console.ReadLine());

            if (choixFaction == 1)
            {
                if (chiffreAl == 1)
                    combat = new Combat(new Reptilien(nom, 11, choixArme, nomEpee, choixCreature), new Rider("eric", 40, random.Next(1, 3), "devoir", random.Next(1, 4)), true);
                else 
                    combat = new Combat(new Rider(nom, 11, choixArme, nomEpee, choixCreature), new Rider("eric", 40, random.Next(1, 3), "devoir", random.Next(1, 4)));
            }
            else
            {
                if(chiffreAl==1)
                    combat = new Combat(new Reptilien(nom, 11, choixArme, nomEpee, choixCreature), new Rider("eric", 40, random.Next(1, 3), "devoir", random.Next(1, 4)), false);
                else
                    combat = new Combat(new Reptilien(nom, 11, choixArme, nomEpee, choixCreature), new Reptilien("eric", 40, random.Next(1, 3), "devoir", random.Next(1, 4)));
            }
           

            combat.Start();

            Console.ReadKey();
            
        }
    }
}
