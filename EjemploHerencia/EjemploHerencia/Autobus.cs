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
        private string codAutobus;
 

        public Autobus()
        {
        }
        public Autobus(string marca, string mod, int velMax, string cod) : base(marca,mod,velMax)
        {
            codAutobus = cod;
        }
        public override string ToString()
        {
            return base.ToString() + "\nCódigo Autobus: " + codAutobus;
        }
    }
}
