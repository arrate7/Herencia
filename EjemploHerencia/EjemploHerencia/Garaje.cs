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
        private int numeroTaxis, numeroAutobuses;

        //Este constructor inicia una lista vacia
        public Garaje(string nombre)
        {
            this.nombre = nombre;
            garaje = new List<CocheSimple>();
        }
        //Este constructor recibe una lista que has llenado previamente en el main
        public Garaje(string nombre, List<CocheSimple> garaje)
        {
            this.nombre = nombre;
            this.garaje = garaje;
        }
        //Este metodo recibe un objeto del tipo CocheSimple(puede ser: taxi, autobus o cochesimple) y lo añade a la lista
        public void AñadirCoche(CocheSimple c)
        {
            if (MeterVehiculo(c))
            {
                if (c.GetType().Name == "Taxi")
                {
                    numeroTaxis++;
                }
                else if(c.GetType().Name == "Autobus")
                {
                    numeroAutobuses++;
                }
                garaje.Add(c);
            }
        }

        //Es un getter para que te devuelva la lista de CocheSimple
        public List<CocheSimple> GetGaraje()
        {
            return garaje;
        }

        public Boolean MeterVehiculo(CocheSimple c)
        {
            if (garaje.Count < 6)
            {
                if (c.GetType().Name == "Autobus" && numeroAutobuses < 1)
                {
                    return true;
                }
                else if (c.GetType().Name == "Taxi" && numeroTaxis < 1)
                {
                    return true;
                }
                else if (c.GetType().Name == "CocheSimple")
                {
                    return true;
                }
            }

            return false;
        }
    }
}
