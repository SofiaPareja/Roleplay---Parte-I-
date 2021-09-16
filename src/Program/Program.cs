using System;

namespace Roleplay
{
    class Program
    {
        static void Main(string[] args)
        {
            Enanos enano = new Enanos("Gimli");
            Item escudo = new Item(0,5,"Escudo");
            Item hacha = new Item(3,2,"Hacha");
        }
    }
}
