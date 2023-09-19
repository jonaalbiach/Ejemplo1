using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalDomestico a1 = new AnimalDomestico();
            a1.Nombre = ("Rogelio");

            Gato g1 = new Gato();
            g1.Nombre = ("Zaramay");
            Perro p1 = new Perro();
            p1.Nombre = ("Simon");

            //Nuevo comentario de prueba


           // Console.WriteLine("El perro se comunica: .." + p1.Comunicarse());
            //Console.WriteLine("El gato se comunica: .." + g1.Comunicarse());

            //            Console.WriteLine("El nombre es "+ a1.ToString());
            
            
            
            // -- POLIMORFISMO
            List<Animal> ListaAnimales = new List<Animal>();
            ListaAnimales.Add(g1);
            ListaAnimales.Add(p1);
            ListaAnimales.Add(new Tigre());
            ListaAnimales.Add(new Pez());

            List<NotFly> ListaNoVoladores = new List<NotFly>();
            ListaNoVoladores.Add(new Perro());
            ListaNoVoladores.Add(new Tigre());
            ListaNoVoladores.Add( new Pez());
            ListaNoVoladores.Add(new Gato());

            Console.WriteLine("lista de mis animales no voladores");
            Console.WriteLine(ListaNoVoladores.Count);
            Console.ReadKey();
           // Console.WriteLine("Como se comunican mis animales?: ");
            //foreach (Animal Item in ListaAnimales)
            //{

                
//                Console.WriteLine(Item.Comunicarse());
//            }
//            Console.ReadKey();
        }
    }
}

