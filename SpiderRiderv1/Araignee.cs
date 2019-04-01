using System;
using System.Collections.Generic;
using System.Text;

namespace SpiderRiderv1
{
        class Araignee : Creature
        {
            private int vie ;
            private int vitesse;
            private int attaque;
            private string type;

            public Araignee(int type) : base("Araignée", "Gentil")
            {
                vie = 500;
                vitesse = 50;
                attaque = 75;

                if (type == 1)

                {

                    vie +=10;
                    this.type = "TANK";

                }
                else if (type == 2)

                {

                    vie += 5;
                    attaque += 5;
                    this.type = "ASSASSIN";

                }
                else
                {
                    attaque +=10;
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


            public int Vitesse
            {
                get
                {
                    return vitesse;
                }

            }

            public int Attaque
            {
                get
                {
                    return attaque;
                }
 
            }
            public override string ToString()
            {
                return "Attaque :" + attaque + "/n" + "Vitesse : " + vitesse + "/n" + "Vie :" + vie;

            }

            public bool Estvivant()
            {
                return vie > 0;
            }
        }
}


