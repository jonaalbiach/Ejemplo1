using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //herencia

            //Motocicleta : Motochoper, Motosport, MotoSuperSport, Ciclomotor

            Motocicleta m1 = new Motocicleta();
            m1.Motor=("a");
            m1.Color=("Roja");
            MotoSport ms1 = new MotoSport();
            ms1.Motor=("b");
            ms1.Color=("Azul");


            //Coleccion
            List<Motocicleta> ListaMotocicletas = new List<Motocicleta>();
            ListaMotocicletas.Add(ms1);
            ListaMotocicletas.Add(m1 );

            // Console.WriteLine("La lista se compone de  :  "+ ListaMotocicletas.Count);
            //Console.WriteLine("El color de la moto Sport es : "+ ListaMotocicletas[1].Color );

            foreach (Motocicleta item in ListaMotocicletas)
            {
                    Console.WriteLine("El color de las motos es:  "+ item.Color);
             }


            Console.ReadKey();






        }
    }
}
