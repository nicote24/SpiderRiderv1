using System;
using System.Collections.Generic;
using System.Text;

namespace SpiderRiderv1
{
    public abstract class Creature
    {
        private string nom;
        private string faction;

        protected Creature(string nom, string faction)
        {
            this.nom = nom;
            this.faction = faction;
        }
        public string Nom
        {
            get
            {
                return nom;
            }
        }
        public string Faction
        {
            get
            {
                return faction;
            }

        }
        public override string ToString()
        {
            return "Faction : " + faction + "/n" + "Nom :" + nom;

        }

    }
}

