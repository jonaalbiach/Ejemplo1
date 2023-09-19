using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_3
{
    internal class Animal
    {
        public string Color { get; set; }
        public string Nombre { get; set; }

        public override string ToString()
        {
            return "El nombre es: " + Nombre ;
        }
        public virtual string Comunicarse ( )
        {
            return "ruido ... ruido ...";
        }
    }
}
