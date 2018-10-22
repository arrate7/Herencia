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
            //CocheSimple cs1 = new CocheSimple("Ferrari","Testa Rosa", 120);
            Taxi t1 = new Taxi("Fiat", "Punto", 120, "abc");
            Autobus a1 = new Autobus("Alsa", "Azul", 100, "ztz");
            CocheSimple c1 = new CocheSimple("Un coche", "verde", 180);

            List<CocheSimple> listaVehiculos = new List<CocheSimple>()
            {
                t1,a1,c1
            };

            foreach (CocheSimple coche in listaVehiculos)
            {
                Console.WriteLine(coche.ToString());
                Console.WriteLine("**********************************");

            }
            Console.ReadLine();
        }
    }
}
