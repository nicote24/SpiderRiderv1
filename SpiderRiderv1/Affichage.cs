using System;
using System.Collections.Generic;
using System.Text;

namespace regroupeur
{
    class Affichage
    {
        public void ChoisirFaction()
        {
            Console.WriteLine("veuillez chosir votre faction");
            Console.WriteLine("1-SpiderRider");
            Console.WriteLine("2-Reptilien");
        }

        public void ChoisirArme()
        {
            Console.WriteLine("veuillez chosir votre arme");
            Console.WriteLine("1-epee");
            Console.WriteLine("2-lance");
        }

        public void ChoisirNom()
        {
            Console.WriteLine("veuillez entrez votre nom");
        }

        public void ChoisirNomEpee()
        {
            Console.WriteLine("veuillez choisir le nom de votre epee");
        }

        public void ChoisirCreature()
        {
            Console.WriteLine("veuillez choisir votre araignee");
            Console.WriteLine("1-Creature Tank");
            Console.WriteLine("2-Creature assassin");
            Console.WriteLine("3-Creature Offensif");
        }
    }
}
