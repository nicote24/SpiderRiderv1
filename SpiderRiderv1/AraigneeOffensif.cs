using System;
using System.Collections.Generic;
using System.Text;

namespace SpiderRiderv1
{

        class AraigneeOffensif : Araignee
        {
            protected AraigneeOffensif() : base(3)
            {
                Console.WriteLine("L'araignée offensive porte des attaques aussi puisantes qu'un dieu");
            }
        }
}
