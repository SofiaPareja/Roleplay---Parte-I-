using System;

namespace Roleplay
{
    public class Hechizo
    {
        private int valorAtaque;

        private string nombre;

        public int ValorAtaque
        {
            get; set;
        }
        public string Nombre
        {
            get; set;
        }

        public Hechizo(int valorAtaque, string nombre)
        {
            this.ValorAtaque = valorAtaque;
            this.Nombre = nombre;
        }
    }
}