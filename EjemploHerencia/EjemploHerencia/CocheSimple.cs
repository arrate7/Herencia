﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CocheSimple
    {
        private int VelocMax;
        private string Marca;
        private string Modelo;
        private Object a;


        public CocheSimple(string marca, string mod, int velMax)
        {
            this.VelocMax = velMax;
            this.Marca = marca;
            this.Modelo = mod;
        }

        public CocheSimple()
        {

        }

        public int GetVelocidad()
        {
            return VelocMax;
        }
        public string GetMarca()
        {
            return Marca;
        }
        public string GetModelo()
        {
            return Modelo;
        }

        public void SetMarca(string marca)
        {
            this.Marca = marca;
        }

        public override string ToString()
        {
            return "Marca: " + Marca + "\nModelo: " + Modelo+ "\nVelocidad: " + VelocMax;
        }

        public virtual string MostrarDatos()
        {
            return "Marca: " + Marca + "\nModelo: " + Modelo+  "\nVelocidad: " + VelocMax;
        }
    }
}
