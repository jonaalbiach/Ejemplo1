using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_3
{
    internal class Perro : AnimalDomestico, NotFly
    {
        public override string Comunicarse()
        {
            return "guau .. . Guauu...";
        }

        public string Volar()
        {
            return "No vuela ";
        }
    }
}
