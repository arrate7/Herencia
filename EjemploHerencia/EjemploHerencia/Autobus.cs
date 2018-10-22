using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerencia
{
    class Autobus : CocheSimple
    {
        private string CodAutobus;

        public Autobus()
        {
        }
        public Autobus(string marca, string mod, int velMax, string cod) : base(marca, mod, velMax)
        {
            CodAutobus = cod;
        }

        public override string ToString()
        {
            return base.ToString() + "\nCódigo Autobus: " + CodAutobus;
        }
    }
}
