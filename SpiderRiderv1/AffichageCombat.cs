using System;
using System.Collections.Generic;
using System.Text;

namespace SpiderRiderv1
{
    class AffichageCombat
    {
        public void Appartion(Rider rider)
        {
            Console.WriteLine("Un rider ennemie apparait, son nom: " + rider);
        }

        public void Apparition(Reptilien reptilien)
        {
            Console.WriteLine("Un rptilien ennemie apparait, son nom: " + reptilien);
        }

        public void CoupRiderReptile(Reptilien reptile)
        {
            Console.WriteLine("le rider et sa monture attaque la monture ennemie, celle-ci se retrouve donc a : " + reptile.MontureR.Vie+" hp");
        }
        
        public void CoupReptileReptile(Reptilien reptile)
        {
            Console.WriteLine("le reptile et sa monture attaque la monture ennemie, celle-ci se retrouve donc a : " + reptile.MontureR.Vie + " hp");
        }

        public void CoupRiderRider(Rider rider)
        {
            Console.WriteLine("le rider et sa monture attaque la monture ennemie, celle-ci se retrouve donc a : " + rider.MontureA.Vie + " hp");
        }

        public void CoupReptileRider(Rider rider)
        {
            Console.WriteLine("le reptile et sa monture attaque la monture ennemie, celle-ci se retrouve donc a : " + rider.MontureA.Vie + " hp");
        }
        public void EstMort(Reptilien reptile)
        {
            Console.WriteLine("le reptilien du nom de : " + reptile+ " est mort");
        }

        public void EstMort(Rider rider, int nbCoups)
        {
            Console.WriteLine("le rider du nom de : " + rider + " est mort");
            Console.WriteLine("nombre de coups portés : " + nbCoups);
        }

        public void EstGagnant(Reptilien reptile)
        {
            Console.WriteLine("le reptilien du nom de : " + reptile + " remporte donc la victoire");
        }

        public void EstGagnant(Rider rider)
        {
            Console.WriteLine("le rider du nom de : " + rider + " remporte donc la victoire");
        }
    }
}
