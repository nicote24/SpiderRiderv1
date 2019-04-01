using System;
using System.Collections.Generic;
using System.Text;

namespace SpiderRiderv1
{
    class Lance : Arme
    {
        private string nomArme;
        public Lance(string nomArme) : base(nomArme)
        {
            att+= 5;
            range+= 10;
            this.nomArme = nomArme;
        }

        public override string ToString()
        {
            return "lance du nom de "+nomArme;

        }
    }
}
