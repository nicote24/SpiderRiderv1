using System;
using System.Collections.Generic;
using System.Text;

namespace SpiderRiderv1
{
    class AraigneeTank : Araignee
    {
        protected AraigneeTank() : base(1)
        {
            Console.WriteLine("L'araignée tank est lente et faible, mais elle est très résistante");
        }
    }
}
