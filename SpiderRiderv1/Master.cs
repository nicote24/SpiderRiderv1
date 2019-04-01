using System;
using System.Collections.Generic;
using System.Text;

namespace SpiderRiderv1
{
    public abstract class Master
    {
        protected string nom;
        private int age;
        private Arme armeMaster;

        public Master(string nom, int age, int choixArme, string nomArme)
        {
            this.nom = nom;
            this.age = age;

            if (choixArme == 1)
                armeMaster = new Epe(nomArme);
            else
                armeMaster = new Lance(nomArme);
        }

    }
}


