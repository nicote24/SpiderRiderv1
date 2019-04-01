using System;
using System.Collections.Generic;
using System.Text;

namespace SpiderRiderv1
{
    class Reptilien : Master
    {
        private Reptile montureR;
        private Arme armeReptilien;
        public Reptilien(string nom, int age, int choixArme, string nomArme, int choixAraignee) : base(nom, age, choixArme, nomArme)
        {
            if (choixAraignee == 1)
                montureR = new Reptile(1);
            else if (choixAraignee == 2)
                montureR = new Reptile(2);
            else
                montureR = new Reptile(3);

            if (choixArme == 1)
                armeReptilien = new Epe(nomArme);
            else
                armeReptilien = new Lance(nomArme);

        }

        public Reptile MontureR
        {
            get
            {
                return montureR;
            }
        }
        public Arme ArmeReptilien
        {
            get
            {
                return armeReptilien;
            }
        }

        public override string ToString()
        {
            return nom + " maninant une " + armeReptilien;

        }

    }
}
