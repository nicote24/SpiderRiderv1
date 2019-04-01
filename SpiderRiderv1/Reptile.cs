using System;
using System.Collections.Generic;
using System.Text;

namespace SpiderRiderv1
{
    class Reptile : Creature

    {

        private int vie;


        private int attaque;

        private string type;


        public Reptile(int type) : base("Reptile", "Méchant")
        {
            vie = 500;
            attaque = 75;

            if (type == 1)

            {

                vie +=10;
                this.type = "TANK";

            }
            else if (type == 2)

            {

                attaque += 5;
                vie += 5;
                this.type = "ASSASSIN";

            }
            else
            {

                attaque = +10;
                this.type = "OFFENSIF";

            }


        }


        public int Vie

        {
            get

            {

                return vie;

            }
            set
            {
                vie = value;
            }

        }



        public int Attaque

        {
            get

            {
                return attaque;
            }


        }

        public bool Estvivant()
        {
            return vie > 0;
        }
    }
}


