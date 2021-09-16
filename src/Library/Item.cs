using System;

namespace Roleplay
{
    public class Item
    {
        private int valorAtaque;
        private int valorDefensa;
        private string nombre;

        public int ValorAtaque
        {
            get; set;
        }

        public int ValorDefensa
        {
           get; set;
        }

        public string Nombre
        {
            get; set;
        }

        public Item(int valorAtaque, int valorDefensa, string nombre)
        {
            this.ValorAtaque = valorAtaque;
            this.ValorDefensa = valorDefensa;
            this.Nombre = nombre;
        }
    }
}