using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_3
{
    internal class Pez : AnimalSalvaje, NotFly
    {
        public string Volar()
        {
            return "no vuela";
        }
    }
}
