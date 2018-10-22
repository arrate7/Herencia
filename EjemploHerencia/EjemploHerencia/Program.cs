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

            List<CocheSimple> listaCoches = new List<CocheSimple>()
            {
                t1,a1,c1
            };
            
            foreach(CocheSimple coche in listaCoches)
            {
                Console.WriteLine(coche.GetType().Name.ToUpper());
                Console.WriteLine(coche.ToString());
                Console.WriteLine("**************************");
            }
            Console.Read();
        }
    }
}
