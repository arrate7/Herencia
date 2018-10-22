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
            Autobus a1 = new Autobus("Alsa", "azul",100,"ztz");
            CocheSimple c1 = new CocheSimple("Ferrari", "Testa Rosa", 180);

            List<CocheSimple> list1 = new List<CocheSimple>()
            {
                t1,a1,c1
            };

            Garaje g1 = new Garaje("Garaje de Arrate",list1);
            //g1.AñadirCoche(t1);
            //g1.AñadirCoche(a1);
            //g1.AñadirCoche(c1);

            foreach (CocheSimple coche in g1.GetGaraje())
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
