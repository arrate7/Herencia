using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace EjemploHerencia
{
    class Program
    {
        static void Main(string[] args)
        {

            Taxi t1 = new Taxi("Fiat", "Punto", 120, "abc");
            Taxi t2 = new Taxi("Fiat", "Punto", 120, "abc");
            Autobus a1 = new Autobus("Alsa", "azul",100,"ztz");
            CocheSimple c1 = new CocheSimple("Ferrari", "Testa Rosa", 180);

            //Aqui he creado la lista ya llena
            List<CocheSimple> list1 = new List<CocheSimple>()
            {
                t1,a1,c1
            };
            //He pasado la lista llena y he creado un garaje
            Garaje g1 = new Garaje("Garaje de Arrate",list1);

            //He creado un garaje vacio
            Garaje g2 = new Garaje("Garaje de Arrate");

            //Con el método AñadirCoche y pasandole el coche que le quiero meter, lleno el garaje
            g2.AñadirCoche(t1);
            g2.AñadirCoche(a1);
            g2.AñadirCoche(c1);
            g2.AñadirCoche(t2);

            foreach (CocheSimple coche in g2.GetGaraje())
            {
                Console.WriteLine(coche.GetType().Name.ToUpper());
                Console.WriteLine(coche.ToString());
                Console.WriteLine("**************************");
            }

            Console.WriteLine("Número de Vehículos: " + g1.GetGaraje().Count);
            Console.Read();
        }
    }
}
