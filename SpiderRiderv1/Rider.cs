using System;
using System.Collections.Generic;
using System.Text;

namespace SpiderRiderv1
{
    class Rider : Master
    {
        private Araignee montureA;
        private Arme armeRider;
        public Rider(string nom, int age, int choixArme, string nomArme, int choixAraignee) : base(nom, age, choixArme, nomArme)
        {
            if (choixAraignee == 1)
                montureA = new Araignee(1);
            else if (choixAraignee == 2)
                montureA = new Araignee(2);
            else
                montureA = new Araignee(3);

            if (choixArme == 1)
                armeRider = new Epe(nomArme);
            else
                armeRider = new Lance(nomArme);

        }

        public Araignee MontureA
        {
            get
            {
                return montureA;
            }
        }

        public Arme ArmeRider
        {
            get
            {
                return armeRider;
            }
        }

        public override string ToString()
        {
            return nom + " maninant une " + armeRider;

        }
    }
}
