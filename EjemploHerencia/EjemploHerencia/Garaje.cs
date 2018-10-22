using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerencia
{
    class Garaje
    {
        private string nombre;
        private List<CocheSimple> garaje;
        private int numeroCoches;

        public Garaje(string nombre)
        {
            this.nombre = nombre;
            garaje = new List<CocheSimple>();
        }
        public Garaje(string nombre, List<CocheSimple> garaje)
        {
            this.nombre = nombre;
            this.garaje = garaje;
        }

        public void AñadirCoche(CocheSimple c)
        {
            garaje.Add(c);
        }

        public List<CocheSimple> GetGaraje()
        {
            return garaje;
        }
    }
}
