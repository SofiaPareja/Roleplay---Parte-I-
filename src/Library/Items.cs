using System;

namespace Roleplay
{
    public class Item
    {
        private static int valorAtaque;
        private static int valorDefensa;

        public int ValorAtaque
        {
            get; set;
        }

        public int ValorDefensa
        {
           get; set;
        }

        public Item(int valorAtaque, int valorDefensa)
        {
            this.ValorAtaque = valorAtaque;
            this.ValorDefensa = valorAtaque;
        }
    }
}