using System;
using System.Collections.Generic;
using System.Text;

namespace SpiderRiderv1
{
    class AraigneeAssassin : Araignee
    {
        protected AraigneeAssassin() : base(2)
        {
            Console.WriteLine("L'araignée assassin est discrète et rapide comme l'éclair, très efficace pour tuer ses adversaires par derrière");
        }
    }
}
