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
        //Variables estaticas que uso para contar cuantos taxis y autobuses hay en el garaje
        private static int numeroTaxis, numeroAutobuses;

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
        //Este metodo recibe un objeto del tipo CocheSimple(puede ser: taxi, autobus o cochesimple) y lo añade al garaje si tiene sitio
        public void AñadirCoche(CocheSimple c)
        {
            //Si el método MeterVehiculo nos devuelve true, añadiremos el vehículo
            if (MeterVehiculo(c))
            {
                //Si el objeto que queremos meter es un Taxi, le añadimos uno al contador de taxis.
                if (c.GetType().Name == "Taxi")
                {
                    numeroTaxis++;
                }
                //Si el objeto que queremos meter es un Autobus, le añadimos uno al contador de autobuses.
                else if (c.GetType().Name == "Autobus")
                {
                    numeroAutobuses++;
                }
                //Como hemos verificado que se puede meter, lo metemos
                Console.WriteLine("Vehívulo del tipo " + c.GetType().Name + " añadido.");
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
            //Primero compruebo que el garaje no este lleno, el tope es de 6 vehiculos
            if (garaje.Count < 6)
            {
                //si el tipo de vehiculo que quiero meter es un bus y no hay mas buses en el garaje, se puede merter (return true) 
                if (c.GetType().Name == "Autobus" && numeroAutobuses < 1)
                {
                    Console.WriteLine("No se pueden meter mas taxis al garaje");
                    return true;
                }
                //si el tipo de vehiculo que quiero meter es un taxi y no hay mas taxis en el garaje, se puede merter (return true) 
                else if (c.GetType().Name == "Taxi" && numeroTaxis < 1)
                {
                    Console.WriteLine("No se pueden meter mas autobuses al garaje");
                    return true;
                }
                //en el caso de cochesimple podrás meter todos los que quieras
                else if (c.GetType().Name == "CocheSimple")
                {
                    return true;
                }
                Console.ReadLine();
            }
            Console.WriteLine("No caben más vehículos en el garaje");
            Console.ReadLine();
            return false;
        }
    }
}
