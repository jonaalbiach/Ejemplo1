using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_3
{
    internal class Gato : AnimalDomestico, NotFly
    {

        public override string Comunicarse()
        {
            return "miau ... miua...";
        }

        public string Volar()
        {
            return "no vuela";
        }
    }
}
