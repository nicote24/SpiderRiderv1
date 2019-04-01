using System;
using System.Collections.Generic;
using System.Text;

namespace SpiderRiderv1
{
    class Epe : Arme
    {
        private string nomArme;
        public Epe(string nomArme) : base(nomArme)
        {
            att += 10;
            range += 5;
            this.nomArme = nomArme;

        }

        public override string ToString()
        {
            return "epe du nom de " + nomArme; ;

        }

    }
}
