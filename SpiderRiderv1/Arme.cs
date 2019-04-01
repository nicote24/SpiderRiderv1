using System;
using System.Collections.Generic;
using System.Text;

namespace SpiderRiderv1
{
    public abstract class Arme
    {
        private string nomArme;
        protected int att;
        protected int range;

        public Arme(string nomArme)
        {
            this.nomArme = nomArme;
            att = 10;
            range = 5;
        }

        public int Att
        {
            get
            {
                return att;
            }

        }
    }
}
